using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:/Users/Christian/Desktop/Curso-CSHARP-LearnWtutorials/Tutorial28/ima/iphone.jpg";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:/Users/Christian/Desktop/Curso-CSHARP-LearnWtutorials/Tutorial28/ima/smart watch.jpg";
        }
    }
}
