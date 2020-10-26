using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Bisque;

            string[] color = {"red", "blue", "white", "black", "Transparent"};

            comboBoxBack.Text = "Transparent";
            comboBoxColor.Text = "Transparent";
            
            comboBoxColor.Items.AddRange(color);
            comboBoxBack.Items.AddRange(color);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            int lineWidth = int.Parse(textBoxWidth.Text);
            string lineColor = comboBoxColor.Text;
            string filling = comboBoxBack.Text;
            
            if (radioButtonCircle.Checked)
            {
                Draw.drawCircle(pictureBox1, lineWidth, lineColor, filling);
            }
            if (radioButtonQuadrate.Checked)
            {
                Draw.DrawQuadrate(pictureBox1, lineWidth, lineColor, filling);
            }
            if (radioButtonTriangle.Checked)
            {
                Draw.DrawTriangle(pictureBox1, lineWidth, lineColor, filling);
            }
            
        }
        
    }
    
    
}
