using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinus
{
    public partial class Form1 : Form
    {
        //int timer = 0;
        PointF[] pnt = new PointF[9];
        Timer t = new Timer();
        Pen myPen = new Pen(Color.Blue, 3);
        Pen myPen1 = new Pen(Color.Red, 3);
        const float PI = 3.14f;

        public Form1()
        {
            InitializeComponent();
            this.ResizeRedraw = true;

           t.Interval = 1000;

            t.Tick += Anim;
            t.Start();



        }
       
        private void Anim(object sender, EventArgs e)
        {
           // timer++;
            //const float PI = 3.14f;
            int y = 0, index = 0, pm = 0; //index nomer pointa
            for (float x = -2 * PI; x <= 2 * PI + 1; x += PI / 2)
            {
                if (index % 2 == 0) { y = 0; }
                else if (pm % 2 == 0) { y = 1; pm++; }
                else if (pm % 2 == 1) { y = -1; pm++; }
                pnt[index] = new PointF(x * 100 + this.Width / 2, -y * 100 + this.Height / 2);
                index++;
              // Refresh();

            }
                Refresh();
           

            // t.Stop();
        }

        private void mypaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //Pen myPen = new Pen(Color.Blue, 3);
            //Pen myPen1 = new Pen(Color.Red, 3);

            //GraphicsPath gr = new GraphicsPath();
            //gr.StartFigure();
            //g.DrawCurve();


            //pnt[0] = new Point( Height/2, Width/2);
            //pnt[1] = new Point((Height/2)+20, (Width/2)+25);
            //pnt[2] = new Point(Height/2, Width/2+4);
            //pnt[3] = new Point(Height/2+2,);

            //pnt[4] = new Point();

            //PointF[] pnt = new PointF[9];
            //const float PI = 3.14f;
            //int y = 0, index = 0, pm = 0; //index nomer pointa
            //for (float x = -2 * PI; x <= 2 * PI + 1; x += PI / 2)
            //{
            //    if (index % 2 == 0) { y = 0; }
            //    else if (pm % 2 == 0) { y = 1; pm++; }
            //    else if (pm % 2 == 1) { y = -1; pm++; }
            //    pnt[index] = new PointF(x * 100 + this.Width / 2, -y * 100 + this.Height / 2);
            //    index++;


            //}
            using (Font font1 = new Font("Times New Roman", 14, FontStyle.Bold, GraphicsUnit.Pixel))
            {

                PointF pointF1 = new PointF( Width/2, Height/2);
                e.Graphics.DrawString("0", font1, Brushes.Blue, pointF1);

                PointF pointF2 = new PointF(Width/2+(PI*100)/2, Height/2);
                e.Graphics.DrawString("90" ,font1, Brushes.Blue, pointF2);
                PointF pointF3 = new PointF(Width / 2 + (PI * 100), Height/2);
                e.Graphics.DrawString("180", font1, Brushes.Blue, pointF3);
                PointF pointF4 = new PointF(Width / 2 + (3 * PI * 100) / 2, Height/2);
                e.Graphics.DrawString("270", font1, Brushes.Blue, pointF4);
                PointF pointF5 = new PointF(Width / 2 + (2 * PI * 100), Height/2);
                e.Graphics.DrawString("360", font1, Brushes.Blue, pointF5);


                PointF pointF6 = new PointF(Width / 2 + (-PI * 100) / 2, Height / 2);
                e.Graphics.DrawString("-90", font1, Brushes.Blue, pointF6);
                PointF pointF7 = new PointF(Width / 2 + (-PI * 100), Height / 2);
                e.Graphics.DrawString("-180", font1, Brushes.Blue, pointF7);
                PointF pointF8 = new PointF(Width / 2 + (-3 * PI * 100) / 2, Height / 2);
                e.Graphics.DrawString("-270", font1, Brushes.Blue, pointF8);
                PointF pointF9 = new PointF(Width / 2 + (-2 * PI * 100), Height / 2);
                e.Graphics.DrawString("-360", font1, Brushes.Blue, pointF9);

                PointF pointF10 = new PointF(Width/2, Height/2-100);
                e.Graphics.DrawString("1", font1, Brushes.Blue, pointF10);
                PointF pointF11= new PointF(Width/2, Height/2+100);
                e.Graphics.DrawString("-1", font1, Brushes.Blue, pointF11);



               
            }


           
                 g.DrawLine(myPen, 0, Height / 2, Width, Height / 2);
                   g.DrawLine(myPen, Width / 2, 0, Width / 2, Height);

            
              g.DrawCurve(myPen1, pnt);



        }
    }
}
