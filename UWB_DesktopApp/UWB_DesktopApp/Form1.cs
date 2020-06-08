using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace UWB_DesktopApp
{
    public partial class Form1 : Form
    {
        double origin_x, origin_y, scale;
        String PicPath = Directory.GetCurrentDirectory() + "\\defaultmap\\test.jpg";
        SerialPort mySerialPort = new SerialPort();
        int[] baseX = new int[] { 0, 0, 0 };
        int[] baseY = new int[] { 0, 0, 0 };

        double[] X0 = new double[] { 0, 0, 0 };
        double[] Y0 = new double[] { 0, 0, 0 };
        double d1, d2, d3;
        double[] pre_loc = new double[] { 0, 0 };
        double[] cur_loc = new double[2];

        public Form1()
        {
            InitializeComponent();
            Console.WriteLine(PicPath);

        }

        private void bt_loadBG_Click(object sender, EventArgs e)
        {
            this.picBoxMain.Click += new System.EventHandler(this.pictureBox1_MouseClick);
            picBoxMain.Cursor = Cursors.Cross;
        }

        private void btScale_Click(object sender, EventArgs e)
        {
            this.picBoxMain.Click += new System.EventHandler(this.pictureBox1_MouseClick1);
            picBoxMain.Cursor = Cursors.Cross;
        }
        private void pictureBox1_MouseClick1(object sender, EventArgs e)
        {
            this.picBoxMain.Click -= new System.EventHandler(this.pictureBox1_MouseClick1);
            picBoxMain.Cursor = Cursors.Default;
            if (tbYScale.Text == "0")
            { 
                scale = Convert.ToDouble(tbXScale.Text) / (this.PointToClient(Cursor.Position).X - origin_x) ;
                labScale.Text = "1px=" + (scale*100).ToString("0.#")+ "cm";
            }
        }

        private void gbMap_Enter(object sender, EventArgs e)
        {

        }

        private void btBaseSet_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(picBoxMain.Width, picBoxMain.Height);
            Graphics g = Graphics.FromImage(bm);
            Image Im1 = Image.FromFile(PicPath);
            if (Im1.Width > Im1.Height)
                g.DrawImage(Im1, 0, 0, picBoxMain.Width, picBoxMain.Width * Im1.Height / Im1.Width);
            else
                g.DrawImage(Im1, picBoxMain.Width / 2 - picBoxMain.Height * Im1.Width / Im1.Height / 2, 0, picBoxMain.Height * Im1.Width / Im1.Height, picBoxMain.Height);
            Pen p = new Pen(Color.Blue);
            int radius = 7;

            g.FillEllipse(Brushes.Blue, Convert.ToInt32(origin_x) - picBoxMain.Left - radius,
                Convert.ToInt32(origin_y) - picBoxMain.Top - radius, 2 * radius, 2 * radius);

            g.DrawLine(new Pen(Color.Red, 2), new Point(0, 0), new Point(picBoxMain.Width, 0));
            g.DrawLine(new Pen(Color.Red, 2), new Point(0, 0), new Point(0, picBoxMain.Height));
            g.DrawLine(new Pen(Color.Red, 2), new Point(picBoxMain.Width, 0), new Point(picBoxMain.Width, picBoxMain.Height));
            g.DrawLine(new Pen(Color.Red, 2), new Point(0, picBoxMain.Height), new Point(picBoxMain.Width, picBoxMain.Height));

            // setting the base
            baseX[0] = Convert.ToInt32(origin_x) + Convert.ToInt32(Convert.ToDouble(tbX1.Text)/scale);
            baseX[1] = Convert.ToInt32(origin_x) + Convert.ToInt32(Convert.ToDouble(tbX2.Text)/scale);
            baseX[2] = Convert.ToInt32(origin_x) + Convert.ToInt32(Convert.ToDouble(tbX3.Text)/scale);
            baseY[0] = Convert.ToInt32(origin_y) - Convert.ToInt32(Convert.ToDouble(tbY1.Text)/scale);
            baseY[1] = Convert.ToInt32(origin_y) - Convert.ToInt32(Convert.ToDouble(tbY2.Text)/scale);
            baseY[2] = Convert.ToInt32(origin_y) - Convert.ToInt32(Convert.ToDouble(tbY3.Text)/scale);

            g.DrawRectangle(new Pen(Color.Blue,2), new Rectangle(baseX[0]-20, baseY[0]-20, 20, 20));
            g.DrawRectangle(new Pen(Color.Blue,2), new Rectangle(baseX[1]-20, baseY[1]-20, 20, 20));
            g.DrawRectangle(new Pen(Color.Blue,2), new Rectangle(baseX[2]-20, baseY[2]-20, 20, 20));

            X0[0] =  Convert.ToDouble(tbX1.Text);
            X0[1] =  Convert.ToDouble(tbX2.Text);
            X0[2] =  Convert.ToDouble(tbX3.Text);
            Y0[0] =  Convert.ToDouble(tbY1.Text);
            Y0[1] =  Convert.ToDouble(tbY2.Text);
            Y0[2] =  Convert.ToDouble(tbY3.Text);

            picBoxMain.Image = bm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btOpenSerial.Text == "打开")
            {
                String serialport = comboSerialPorts.Text;
                if (serialport == "")
                    return;
                int baudrate = Int32.Parse(comboBaudRate.Text);
                int databits = Int32.Parse(comboDataBits.Text);
                String parity = comboParity.Text;
                int stopbits = Int32.Parse(comboStopBits.Text);

                mySerialPort = new SerialPort(serialport);
                mySerialPort.BaudRate = baudrate;
                mySerialPort.Parity = Parity.None;
                mySerialPort.StopBits = StopBits.One;
                mySerialPort.DataBits = databits;
                mySerialPort.Handshake = Handshake.None;
                mySerialPort.RtsEnable = true;

                mySerialPort.Open();

                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);


                //_serialPort = new SerialPort(serialport, baudrate, Parity.None, databits, StopBits.One);
                //_serialPort.Handshake = Handshake.None;
                //_serialPort.Open();
                btOpenSerial.Text = "关闭";
                btOpenSerial.BackColor = Color.Green;
            }
            else
            {
                mySerialPort.Close();
                btOpenSerial.Text = "打开";
                btOpenSerial.BackColor = Color.Red;
            }
        }
        public void update_plot()
        { 
            if ((pre_loc[0] != 0) && (pre_loc[1] != 0))
            {
                Graphics g = Graphics.FromImage(picBoxMain.Image);
                int preX = Convert.ToInt32(origin_x) + Convert.ToInt32(pre_loc[0] / scale);
                int preY = Convert.ToInt32(origin_y) - Convert.ToInt32(pre_loc[1] / scale);
                int curX = Convert.ToInt32(origin_x) + Convert.ToInt32(cur_loc[0] / scale);
                int curY = Convert.ToInt32(origin_y) - Convert.ToInt32(cur_loc[1] / scale);
                g.DrawLine(new Pen(Color.Red, 2), new Point(preX, preY),
                    new Point(curX, curY));
                this.Invalidate();
                this.Invoke(new Action(() =>
                {
                    picBoxMain.Refresh();//updaing the picturebox for seeing results.
                                          // this.Text = ((pos / 1000).ToString() + "KB");
                }));
            }
            pre_loc[0] = cur_loc[0];
            pre_loc[1] = cur_loc[1];
        }
        public void Caculate_Location()
        {
            double a, b, c, d,gamma1, gamma2;
            //gamma1 = d_m_k(2)^2-d_m_k(1)^2-(xo(2)^2-xo(1)^2+yo(2)^2-yo(1)^2);
            gamma1 = d2 * d2 - d1 * d1 - (X0[1] * X0[1] - X0[0] * X0[0] + Y0[1] * Y0[1] - Y0[0] * Y0[0]);
            //gamma2 = d_m_k(3) ^ 2 - d_m_k(1) ^ 2 - (xo(3) ^ 2 - xo(1) ^ 2 + yo(3) ^ 2 - yo(1) ^ 2);
            gamma2 = d3 * d3 - d1 * d1 - (X0[2] * X0[2] - X0[0] * X0[0] + Y0[2] * Y0[2] - Y0[0] * Y0[0]);
            //A = 2*[xo(1)-xo(2) yo(1)-yo(2)
            //xo(1) - xo(3) yo(1) - yo(3)];
            a = 2 * X0[0] - 2 * X0[1];
            b = 2 * Y0[0] - 2 * Y0[1];
            c = 2 * X0[0] - 2 * X0[2];
            d = 2 * Y0[0] - 2 * Y0[2];

            cur_loc[0] = (d * gamma1 - b * gamma2) / (a * d - b * c);
            cur_loc[1] = (-c * gamma1 + a * gamma2) / (a * d - b * c);

            Console.WriteLine("x:"+ cur_loc[0] + '\n');
            Console.WriteLine("y:" + cur_loc[1] + '\n');

            update_plot();

        }
        public void Process_Msg(string indata)
        {
            string[] get = indata.Split(',');
            if (get.Length == 4)
            {
                d1 = Convert.ToDouble(get[1]);
                d2 = Convert.ToDouble(get[2]);
                d3 = Convert.ToDouble(get[3]);
                Caculate_Location();
            }
        }
        private void DataReceivedHandler(
                       object sender,
                       SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            //Console.WriteLine("Data Received:");
            Process_Msg(indata);
        }



        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Console.WriteLine("data received");
            //Console.WriteLine(e.ToString());
        }

        private void pictureBox1_MouseClick(object sender, EventArgs e)
        {
            //MessageBox.Show(string.Format("X: {0} Y: {1}", MousePosition.X, MousePosition.Y));
            this.picBoxMain.Click -= new System.EventHandler(this.pictureBox1_MouseClick);
            picBoxMain.Cursor = Cursors.Default;
            origin_x = this.PointToClient(Cursor.Position).X;
            origin_y = this.PointToClient(Cursor.Position).Y;

            Bitmap bm = new Bitmap(picBoxMain.Width,picBoxMain.Height);
            Graphics g = Graphics.FromImage(bm);
            Image Im1 = Image.FromFile(PicPath);
            if (Im1.Width > Im1.Height)
                g.DrawImage(Im1, 0, 0, picBoxMain.Width, picBoxMain.Width * Im1.Height / Im1.Width);
            else
                g.DrawImage(Im1,picBoxMain.Width/2- picBoxMain.Height * Im1.Width / Im1.Height/2, 0, picBoxMain.Height * Im1.Width / Im1.Height, picBoxMain.Height);
            Pen p = new Pen(Color.Blue);
            int radius = 7;
            
            g.FillEllipse(Brushes.Blue,Convert.ToInt32(origin_x)-picBoxMain.Left-radius,
                Convert.ToInt32(origin_y)-picBoxMain.Top- radius, 2*radius, 2*radius);

            g.DrawLine(new Pen(Color.Red,2), new Point(0, 0), new Point(picBoxMain.Width, 0));
            g.DrawLine(new Pen(Color.Red,2), new Point(0, 0), new Point(0,picBoxMain.Height));
            g.DrawLine(new Pen(Color.Red, 2), new Point(picBoxMain.Width, 0), new Point(picBoxMain.Width, picBoxMain.Height));
            g.DrawLine(new Pen(Color.Red, 2), new Point(0,picBoxMain.Height), new Point(picBoxMain.Width, picBoxMain.Height));

            picBoxMain.Image = bm;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //Console.WriteLine(picBoxMain.Height);
            //Console.WriteLine(this.Height);
            picBoxMain.Height = Convert.ToInt32(this.Height * 0.8);
            picBoxMain.Width = Convert.ToInt32(this.Width * 0.8);
            picBoxMain.Left = 10;
            picBoxMain.Top = 10;

            Bitmap bm = new Bitmap(picBoxMain.Width, picBoxMain.Height);
            Graphics g = Graphics.FromImage(bm);
            Image Im1 =  Image.FromFile(PicPath);
            if (Im1.Width > Im1.Height)
                g.DrawImage(Im1, 0, 0, picBoxMain.Width, picBoxMain.Width * Im1.Height / Im1.Width);
            else
                g.DrawImage(Im1, picBoxMain.Width / 2 - picBoxMain.Height * Im1.Width / Im1.Height / 2, 0, picBoxMain.Height * Im1.Width / Im1.Height, picBoxMain.Height);

            g.DrawLine(new Pen(Color.Red,2), new Point(0, 0), new Point(picBoxMain.Width, 0));
            g.DrawLine(new Pen(Color.Red,2), new Point(0, 0), new Point(0,picBoxMain.Height));
            g.DrawLine(new Pen(Color.Red, 2), new Point(picBoxMain.Width, 0), new Point(picBoxMain.Width, picBoxMain.Height));
            g.DrawLine(new Pen(Color.Red, 2), new Point(0, picBoxMain.Height), new Point(picBoxMain.Width, picBoxMain.Height));


            picBoxMain.Image = bm;

            //load serial port numbers
            string[] ports = SerialPort.GetPortNames();

            // Display each port name to the console.
            foreach (string port in ports)
            {
                //Console.WriteLine(port);
                comboSerialPorts.Items.Add(port);
            }


            //bt_loadBG.Left = Convert.ToInt32(this.Width * 0.8) + 20;
            gbMap.Left = Convert.ToInt32(this.Width * 0.8) + 20;
            gbMap.Top = 20;
            gbMap.Width = Convert.ToInt32(this.Width * 0.2) - 40;

            gbBaseSet.Left = Convert.ToInt32(this.Width * 0.8) + 20;
            gbBaseSet.Top = gbMap.Height+20;
            gbBaseSet.Width = Convert.ToInt32(this.Width * 0.2) - 40;

            gbSerial.Left = Convert.ToInt32(this.Width * 0.8) + 20;
            gbSerial.Top = gbMap.Height + 20+ gbBaseSet.Height+20;
            gbSerial.Width = Convert.ToInt32(this.Width * 0.2) - 40;

        }
    }
}
