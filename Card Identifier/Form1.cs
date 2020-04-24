/*
 Create an app with 5 PictureBox controls
 Each PictureBox should display a different card from the set of images
 When the user clicks any of the PictureBox controls, the name of the card should be in a Label control. 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Identifier
{
    public partial class FormCardIdentifier : Form
    {
        public FormCardIdentifier()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "2 of clubs";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "2 of diamonds";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "2 of hearts";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "2 of spades";

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "the joker";
        }
    }
}
