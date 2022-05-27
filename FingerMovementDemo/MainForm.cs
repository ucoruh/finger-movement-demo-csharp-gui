using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ParmakSimilasyonu
{
    public partial class MainForm : Form
    {
        double length;
        double length_bas;

        double degreesA;
        double degreesB;
        double degreesC;
        
        int xa, ya, x1, y1, x2, y2,x3,y3;

        public MainForm()
        {
            length = 100;
            
            xa = 0;
            ya = 0;
            
            x1 = 0;
            y1 = 0;
            
            x2 = 0;
            y2 = 0;
            
            x3 = 0;
            y3 = 0;
            
            degreesA = 0;
            degreesB = 0;
            degreesC = 0;

            InitializeComponent();

            label5.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
        }

        
      

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            MainForm.ActiveForm.Refresh();

            Graphics g = this.CreateGraphics();
            label4.Text = hScrollBar1.Value.ToString();
            label3.Text = hScrollBar2.Value.ToString();
            degreesA = hScrollBar1.Value + 180;
            degreesB = hScrollBar2.Value;
            degreesC = hScrollBar3.Value;


            g.DrawRectangle(Pens.Red, xa, ya, 3, 3);
            //////////////////////////////////////////////
            x1 = (int)(xa + Math.Cos(degreesA / 180.0 * Math.PI) * length);

            y1 = (int)(ya - Math.Sin(degreesA / 180.0 * Math.PI) * length);
            /////////////////////////////////////////////
            x2 = (int)(x1 + Math.Cos((degreesB + degreesA) / 180.0 * Math.PI) * (length - 10));

            y2 = (int)(y1 - Math.Sin((degreesB + degreesA) / 180.0 * Math.PI) * (length - 10));
            /////////////////////////////////////////////
            x3 = (int)(x2 + Math.Cos((degreesB + degreesA + degreesC) / 180.0 * Math.PI) * (length - 20));

            y3 = (int)(y2 - Math.Sin((degreesB + degreesA + degreesC) / 180.0 * Math.PI) * (length - 20));
            ////////////////////////////////////////////
            g.DrawLine(Pens.Blue, xa, ya, x1, y1);
            g.DrawLine(Pens.Blue, x1, y1, x2, y2);
            g.DrawLine(Pens.Blue, x2, y2, x3, y3);
            ///////////////////////////////////////////
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            MainForm.ActiveForm.Refresh();

            Graphics g = this.CreateGraphics();
            label4.Text = hScrollBar1.Value.ToString();
            label3.Text = hScrollBar2.Value.ToString();
            degreesA = hScrollBar1.Value + 180;
            degreesB = hScrollBar2.Value;
            degreesC = hScrollBar3.Value;


            g.DrawRectangle(Pens.Red, xa, ya, 3, 3);
            //////////////////////////////////////////////
            x1 = (int)(xa + Math.Cos(degreesA / 180.0 * Math.PI) * length);

            y1 = (int)(ya - Math.Sin(degreesA / 180.0 * Math.PI) * length);
            /////////////////////////////////////////////
            x2 = (int)(x1 + Math.Cos((degreesB + degreesA) / 180.0 * Math.PI) * (length - 10));

            y2 = (int)(y1 - Math.Sin((degreesB + degreesA) / 180.0 * Math.PI) * (length - 10));
            /////////////////////////////////////////////
            x3 = (int)(x2 + Math.Cos((degreesB + degreesA + degreesC) / 180.0 * Math.PI) * (length - 20));

            y3 = (int)(y2 - Math.Sin((degreesB + degreesA + degreesC) / 180.0 * Math.PI) * (length - 20));
            ////////////////////////////////////////////
            g.DrawLine(Pens.Blue, xa, ya, x1, y1);
            g.DrawLine(Pens.Blue, x1, y1, x2, y2);
            g.DrawLine(Pens.Blue, x2, y2, x3, y3);
            ///////////////////////////////////////////
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawRectangle(Pens.Red, e.X, e.Y, 3, 3);

            xa = e.X;
            ya = e.Y;

        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            MainForm.ActiveForm.Refresh();

            Graphics g = this.CreateGraphics();
            label4.Text = hScrollBar1.Value.ToString();
            label3.Text = hScrollBar2.Value.ToString();
            degreesA = hScrollBar1.Value + 180;
            degreesB = hScrollBar2.Value;
            degreesC = hScrollBar3.Value;


            g.DrawRectangle(Pens.Red, xa, ya, 3, 3);
            //////////////////////////////////////////////
            x1 = (int)(xa + Math.Cos(degreesA / 180.0 * Math.PI) * length);

            y1 = (int)(ya - Math.Sin(degreesA / 180.0 * Math.PI) * length);
            /////////////////////////////////////////////
            x2 = (int)(x1 + Math.Cos((degreesB + degreesA) / 180.0 * Math.PI) * (length - 10));

            y2 = (int)(y1 - Math.Sin((degreesB + degreesA) / 180.0 * Math.PI) * (length - 10));
            /////////////////////////////////////////////
            x3 = (int)(x2 + Math.Cos((degreesB + degreesA + degreesC) / 180.0 * Math.PI) * (length - 20));

            y3 = (int)(y2 - Math.Sin((degreesB + degreesA + degreesC) / 180.0 * Math.PI) * (length - 20));
            ////////////////////////////////////////////
            g.DrawLine(Pens.Blue, xa, ya, x1, y1);
            g.DrawLine(Pens.Blue, x1, y1, x2, y2);
            g.DrawLine(Pens.Blue, x2, y2, x3, y3);
            ///////////////////////////////////////////
        }
    }
}