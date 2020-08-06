using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Project_WinForm
{
    public partial class UserHome : UserControl
    {
        public UserHome()
        {
            InitializeComponent();
        }

        private int imageNumber = 1;
        private void Loadnext()
        {
            if (imageNumber == 4)
            {
                imageNumber = 1;
            }

            pictureBox1.ImageLocation = string.Format(@"image\{0}.jpg", imageNumber);
            imageNumber++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Loadnext();
        }
    }
}
