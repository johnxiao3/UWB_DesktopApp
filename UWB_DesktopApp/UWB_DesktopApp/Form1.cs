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

namespace UWB_DesktopApp
{
    public partial class Form1 : Form
    {
        double origin_x, origin_y, scale;
        String PicPath = Directory.GetCurrentDirectory() + "\\defaultmap\\test.jpg";
        int[] baseX = new int[] { 0, 0, 0 };
        int[] baseY = new int[] { 0, 0, 0 };

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

            picBoxMain.Image = bm;
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


            //bt_loadBG.Left = Convert.ToInt32(this.Width * 0.8) + 20;
            gbMap.Left = Convert.ToInt32(this.Width * 0.8) + 20;
            gbMap.Top = 20;
            gbMap.Width = Convert.ToInt32(this.Width * 0.2) - 40;

            gbBaseSet.Left = Convert.ToInt32(this.Width * 0.8) + 20;
            gbBaseSet.Top = gbMap.Height+20;
            gbBaseSet.Width = Convert.ToInt32(this.Width * 0.2) - 40;

        }
    }
}
