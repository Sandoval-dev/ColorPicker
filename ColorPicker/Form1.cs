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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
          
        }
   
        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
         

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// pictureBox2 nesnemin resim lokasyonunu openfileDialog1 nesnemizle seçtiğimiz resim olarak ayarladım.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
            pictureBox2.ImageLocation = openFileDialog1.FileName;
        }


        /// <summary>
        /// Picturebox2 içinde olan resmimizde fare tıklanınca gerçekleşmesi gereken olayları yazdım.
        /// Bitmap ve Color sınıfından nesne oluşturdum.
        /// Daha sonra üzerinde tıkladığımız resmin ARGB değerlerini gösteren kodu yazdım.
        /// picturebox4 te ise üzerine tıkladığımız rengi göstermesini sağladım.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_MouseDown_1(object sender, MouseEventArgs e)
        {
            Bitmap bitmap = (Bitmap)pictureBox2.Image;
            Color color2 = bitmap.GetPixel(e.X, e.Y);
            Avalue2.Text = color2.A.ToString();
            Rvalue2.Text = color2.R.ToString();
            Gvalue2.Text = color2.G.ToString();
            Bvalue2.Text = color2.B.ToString();
            pictureBox4.BackColor = color2;
        }


        /// <summary>
        /// Picturebox2 içinde olan resmimizde fare hareket edince gerçekleşmesi gereken olayları yazdım.
        /// Bitmap ve Color sınıfından nesne oluşturdum. 
        /// Daha sonra üzerinde anlık olarak gezdiğimiz rengin ARGB değerlerini gösteren kodu yazdım.
        /// Son olarak ise üzerinde gezdiğimiz rengi ufak picturebox3 ekranında anlık olarak  gösteren kodu yazdım.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_MouseMove_1(object sender, MouseEventArgs e)
        {
            Bitmap bitmap = (Bitmap)pictureBox2.Image;
            Color color2 = bitmap.GetPixel(e.X, e.Y);


            Avalue.Text = color2.A.ToString();
            Rvalue.Text = color2.R.ToString();
            GValue.Text = color2.G.ToString();
            BValue.Text = color2.B.ToString();
            pictureBox3.BackColor = color2;

        }

        /// <summary>
        /// btn_Open a tıklandığında openfileDialog1 nesnemizle showdialog formunu açtırdım ve burdan sadece resim seçilmesini sağladım
        /// Bunu ise openfileDialog1 nesnem üzerindeki property bölümünden filtre özelliğinde yazarak yaptım.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Open_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
