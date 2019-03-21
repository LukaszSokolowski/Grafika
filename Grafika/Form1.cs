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

            if (checkBox1.Checked)
            {
                Console.WriteLine("Rysuj przyrostowym");
                label8.Hide();
            }
            else if (checkBox2.Checked)
            {
                Console.WriteLine("Rysuj z punktem środkowym");
                label8.Hide();
            }
            else
            {
                label8.Show();
                isValidInput = false;
            }

            if (isValidInput) {
                Bitmap image1 = new Bitmap(bitmapWidth, bitmapHeight);
                /*
                int x, y;

                for (x = 0; x < image1.Width; x++)
                {
                    for (y = 0; y < image1.Height; y++)
                    {
                        Color pixelColor = image1.GetPixel(x, y);
                        Color newColor = Color.FromArgb(pixelColor.R, 0, 0);
                        image1.SetPixel(x, y, newColor);
                    }
                }
                */
                image1.SetPixel(x1, y1, Color.Black);
                image1.SetPixel(x2, y2, Color.Black);
                pictureBox1.Image = image1;
            } else {
                Console.WriteLine("BŁĄD");
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
