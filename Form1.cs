using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Xml.Linq;

namespace htemurtas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(1085, 675);
            StartPosition = FormStartPosition.CenterScreen;
        }

        readonly int n = 20, w = 100;
        readonly Random rnd = new Random();
        readonly SolidBrush Boya = new SolidBrush(Color.Yellow);
        readonly Pen Kalem = new Pen(Color.Red, 1);
        Bitmap[] Bmp;
        int i, j, k, x, y;
        int[] aMat, bMat;

        private void PicBox_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void PicBox_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void PicBox_MouseUp(object sender, MouseEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PicBox.BackColor = Color.Aqua;
            PicBox.Dock = DockStyle.Fill;
            Bitmap Rsm = new Bitmap("../../Bayrak.jpg");
            Rectangle Rect = new Rectangle(0, 0, w, w);
            aMat = new int[n];
            bMat = new int[n];
            Bmp = new Bitmap[n];
            for (i = 0; i < n; i++)
            {
                aMat[i] = i;
                bMat[i] = rnd.Next(2);
                Rect.X = (i % 5) * w;
                Rect.Y = (i / 5) * w;
                Bmp[i] = Rsm.Clone(Rect, Rsm.PixelFormat);
            }
			for (i = 0; i < n; i++) {
                j = rnd.Next(n);
                k = aMat[i];
                aMat[i] = aMat[j];
                aMat[j] = k;
            }
        }

        private void PicBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics grf = e.Graphics;
            grf.SmoothingMode = SmoothingMode.AntiAlias;

            for (i = 0; i < n; i++) {
                x = 300 + (i % 5) * w;
                y = 20 + (i / 5) * w;
                if (bMat[i] == 1) grf.DrawImage(Bmp[i], x, y);
                else {
                    grf.DrawRectangle(Kalem, x, y, w, w);
                    grf.FillRectangle(Boya, x, y, w, w);
                }
                j = aMat[i];
                x = 20 + (i % 10) * (w + 5);
                y = 450 + (i / 10) * (w + 5);
                if (bMat[j] == 0) grf.DrawImage(Bmp[j], x, y);
                else {
                    grf.DrawRectangle(Kalem, x, y, w, w);
                    grf.FillRectangle(Boya, x, y, w, w);
                }
            }
        }
    }
}
