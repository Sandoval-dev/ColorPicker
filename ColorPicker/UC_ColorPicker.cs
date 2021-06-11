using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class UC_ColorPicker : UserControl
    {
       

        public UC_ColorPicker()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void lblColorSmall_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Picturebox1 içinde olan resmimizde fare tıklanınca gerçekleşmesi gereken olayları yazdım.
        /// Bitmap ve Color sınıfından nesne oluşturdum. Bitmap sınıfı ,resimler üzerinde işlem yapmamızı sağlayan bir sınıftır.
        /// Color sınıfı ise ARGB (Alpha, Red, Green, Blue) renklerine ulaşmamızı sağlar.
        /// Tıklanınca her rengin kendine özel değerini yazmasını sağlayan kodu yazdım.
        /// Küçük panelde tıkladığımız rengin gözükmesini sağlayan kodu yazdım.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixel = (Bitmap)pictureBox1.Image;
            Color color = pixel.GetPixel(e.X, e.Y);
            textRed.Text = color.R.ToString();
            textGreen.Text = color.G.ToString();
            textBlue.Text = color.B.ToString();
            panelColor.BackColor = color;
        }

        /// <summary>
        /// Picturebox1 içinde olan resmimizde fare hareket edince gerçekleşmesi gereken olayları yazdım.
        /// Bitmap ve Color sınıfından nesne oluşturdum. 
        /// Küçük ekranımızda gezdiğimiz rengi göstermesini sağlayan kodu yazdım.
        /// Daha sonra text kutumuzda rengimizin rgb değerlerini göstermesini sağladım. Bunu Color sınıfından oluşturuduğumuz nesneyle yaptım.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixel = (Bitmap)pictureBox1.Image;
            Color color = pixel.GetPixel(e.X, e.Y);
            lblColorSmall.BackColor = color;
            lblRgb.Text = "R: " + color.R.ToString() + " G: " + color.G.ToString() + " B: " + color.B.ToString();
        }

        private void lblRgb_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Uygulamamızı kapatmak için yazdığımız kod satırı
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
          ((Form)this.TopLevelControl).Close();

        }

       
    }
}
