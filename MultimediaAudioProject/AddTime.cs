using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultimediaAudioProject
{
    public partial class AddTime : Form
    {
        public AddTime()
        {
            InitializeComponent();
        }



      

        private void AddTime_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }
        string myVal;
        public string MyVal
        {
            get { return myVal; }
            set { myVal = value; }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (time.Text == "")
            {
                MessageBox.Show("Only Correct values");
                return;
            }
            
            myVal = time.Text;





        }

        private void time_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Header_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Header_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
