using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_1_3_Chapter_Assingment
{
    public partial class BasicInput : Form
    {
        public BasicInput()
        {
            InitializeComponent();

            

        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGreeting_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name;
            int age;
            double height;

            name = txtName.Text;
            age = Convert.ToInt32(numAge.Text);
            height = Convert.ToDouble(txtHeight.Text);

            lblResult.Text = "Hi " + name + ", you are " + (82 - age) + " years under the average life expectancy and you are ";
            lblResult2.Text = (2.72 - height) + " metres shorter than the tallest man alive!";

        }
    }
}
