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
        private int bitmapWidth = 200;
        private int bitmapHeight = 200;
        private int currentX = 0;
        private int currentY = 0;

        public Form1(){
            InitializeComponent();
            pictureBox1.BackColor = Color.Tomato;
        }

        private void pictureBox1_Click(object sender, EventArgs e){

        }

        private void button1_Click(object sender, EventArgs e){
            Bitmap image1 = new Bitmap(bitmapWidth, bitmapHeight);
            int x, y;

            for (x = 0; x < image1.Width; x++) {
                for (y = 0; y < image1.Height; y++) {
                    Color pixelColor = image1.GetPixel(x, y);
                    Color newColor = Color.FromArgb(pixelColor.R, 0, 0);
                    image1.SetPixel(x, y, newColor);
                }
            }
            pictureBox1.Image = image1;
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
