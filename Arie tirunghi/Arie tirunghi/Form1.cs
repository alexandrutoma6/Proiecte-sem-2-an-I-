using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arie_tirunghi
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

        int x, y;
        int sus_x, sus_y = 900, st_x = 900, st_y, dr_x = 0, dr_y, jos_x, jos_y = 0;
        Random rnd = new Random();
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black, 2);
            Pen t = new Pen(Color.DarkGray, 4);
            Pen c = new Pen(Color.Red, 5);
            int n = 124;
            for (int i = 0; i < n; i++)
            {
                x = rnd.Next(100, 500);
                y = rnd.Next(100, 500);

                if (y > jos_y)
                {
                    jos_y = y;
                    jos_x = x;
                }
                else if (y < sus_y)
                {
                    sus_y = y;
                    sus_x = x;
                }

                if (x > dr_x)
                {
                    dr_x = x;
                    dr_y = y;
                }
                else if (x < st_x)
                {
                    st_x = x;
                    st_y = y;
                }
                e.Graphics.DrawEllipse(c, x, y, 2, 2);
            }
            //Marcarea punctelor de extrem
            e.Graphics.DrawEllipse(p, sus_x, sus_y, 2, 2);
            e.Graphics.DrawEllipse(p, st_x, st_y, 2, 2);
            e.Graphics.DrawEllipse(p, dr_x, dr_y, 2, 2);
            e.Graphics.DrawEllipse(p, jos_x, jos_y, 2, 2);

            //desenarea patrulaterului
            dreptunghi(p, st_x, dr_x, sus_y, jos_y);

            //desenarea triunghiului
            triunghi(t, st_x, dr_x, sus_y, jos_y);
            
            void dreptunghi(Pen p, int st_x, int dr_x, int sus_y, int jos_y)
            {
                e.Graphics.DrawLine(p, st_x, sus_y, st_x, jos_y);
                e.Graphics.DrawLine(p, st_x, jos_y, dr_x, jos_y);
                e.Graphics.DrawLine(p, dr_x, jos_y, dr_x, sus_y);
                e.Graphics.DrawLine(p, dr_x, sus_y, st_x, sus_y);
            }
            void triunghi(Pen t, int st_x, int dr_x, int sus_y, int jos_y)
            {
                e.Graphics.DrawLine(t, st_x, sus_y, st_x, (jos_y - 100) * 2);
                e.Graphics.DrawLine(t, st_x, (jos_y - 100) * 2, (dr_x) * 2, sus_y);
                e.Graphics.DrawLine(t, (dr_x) * 2, sus_y, st_x, sus_y);
            }
        }
    }
}
