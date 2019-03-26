using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafika {
    public partial class Form1 : Form {
        private int bitmapWidth = 501;
        private int bitmapHeight = 501;
        int x1 = 0;
        int y1 = 0;
        int x2 = 0;
        int y2 = 0;

         private bool isValidInput() {
            bool valid = true;

            if (Int32.TryParse(textBox1.Text, out x1))
            {
                Console.WriteLine(x1);
                textBox1.BackColor = Color.White;
            }
            else
            {
                Console.WriteLine("ERROR");
                textBox1.BackColor = Color.Red;
                valid = false;
            }

            if (Int32.TryParse(textBox2.Text, out y1))
            {
                Console.WriteLine(y1);
                textBox2.BackColor = Color.White;
            }
            else
            {
                Console.WriteLine("ERROR");
                textBox2.BackColor = Color.Red;
                valid = false;
            }

            if (Int32.TryParse(textBox3.Text, out x2))
            {
                Console.WriteLine(x2);
                textBox3.BackColor = Color.White;
            }
            else
            {
                Console.WriteLine("ERROR");
                textBox3.BackColor = Color.Red;
                valid = false;
            }

            if (Int32.TryParse(textBox4.Text, out y2))
            {
                Console.WriteLine(y2);
                textBox4.BackColor = Color.White;
            }
            else
            {
                Console.WriteLine("ERROR");
                textBox4.BackColor = Color.Red;
                valid = false;
            }
            if ((x1<=500 && x1>=0) && (x2 <=500 && x2 >= 0) && (y1 <=500 && y1 >= 0) && (y2 <=500 && y2 >= 0)){
                label7.Hide();
                Console.WriteLine("OK");
            } else
            {
                Console.WriteLine("Błąd123");
                label7.Show();
                valid = false;
            }

            return valid;
        }

        public Form1(){
            InitializeComponent();
            pictureBox1.BackColor = Color.Tomato;
            label7.Hide();
            label8.Hide();
            checkBox1.Checked = true;
      
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            bool isValidInput = Program.form1.isValidInput();
            Bitmap bitmap = new Bitmap(bitmapWidth, bitmapHeight);

            if (checkBox1.Checked && isValidInput)
            {
                Console.WriteLine("Rysuj przyrostowym");
                label8.Hide();
/*
                double dist1, dist2;

                dist1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
                dist2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
                if (dist1>dist2)
                {
                    int swap = x2;
                    x2 = x1;
                    x1 = swap;

                    swap = y2;
                    y2 = y1;
                    y1 = swap;

                }
*/
                float dy, dx,x, y, step;
                dy = y2 - y1;
                dx = x2 - x1;

                if (dx >= dy)
                    step = dx;
                else
                    step = dy;

                dx = dx / step;
                dy = dy / step;
                x = x1;
                y = y1;
                int i = 1;
                while (i <= step)
                {
                    bitmap.SetPixel((int)Math.Floor(x), (int)Math.Floor(y), Color.Black);
                    x += dx;
                    y += dy;
                    i++;
                }
                pictureBox1.Image = bitmap;

            }
            else if (checkBox2.Checked && isValidInput)
            {
                Console.WriteLine("Rysuj z punktem środkowym");
                label8.Hide();

                int dX, dY, g, h, c;

                  dX = x2-x1;
                  if ( dX > 0 ) g = +1; else g = -1;
                  dX = Math.Abs(dX);
                  dY = y2-y1;
                  if ( dY > 0 ) h = +1; else h = -1;
                  dY = Math.Abs(dY);
                  if ( dX > dY ) {
                    c = -dX;
                    while ( x1 != x2 ) {
                      bitmap.SetPixel( x1, y1, Color.Black );
                      c += 2*dY;
                      if ( c > 0 ) { y1 += h; c -= 2*dX; }
                      x1 += g;
                    }
                  }
                  else {
                    c = -dY;
                    while ( y1 != y2 ) {
                      bitmap.SetPixel( x1, y1, Color.Black );
                      c += 2*dX;
                      if ( c > 0 ) { x1 += g; c -= 2*dY; }
                      y1 += h;
                    }
                  }

                pictureBox1.Image = bitmap;
            }
            else
            {
                label8.Show();
                isValidInput = false;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
            else
            {
              //  checkBox1.Checked = true;        
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
            else
            {
               // checkBox2.Checked = true;
            }
        }
    }
}
