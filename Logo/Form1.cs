using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
           
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen linePen = new Pen(Color.White, 20);
            SolidBrush fillbrush = new SolidBrush(Color.FromArgb(230,255,10,10));


            g.TranslateTransform(20, 400);
            g.RotateTransform(315);
            g.FillRectangle(fillbrush, 0, 0, 564, 282);

            fillbrush.Color = Color.SteelBlue;
            g.TranslateTransform(0, 282);
            g.FillRectangle(fillbrush, 0, 0, 564, 282);

            Font drawFont = new Font("Swis721 BlkCn BT", 70);
            fillbrush.Color = Color.White;
            g.DrawString("Domino's \nPizza", drawFont, fillbrush, 10, 10);

            g.DrawLine(linePen, 0, 0, 600, 0);
            g.ResetTransform();

            g.DrawLine(linePen, 10, 0, 410, 400);
            g.FillEllipse(fillbrush, 90, 356, 90, 90);
            g.FillEllipse(fillbrush, 230, 356, 90, 90);
            
            g.FillEllipse(fillbrush, 370, 152, 90, 90);

        }
    }
}
