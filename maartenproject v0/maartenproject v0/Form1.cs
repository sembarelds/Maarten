using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maartenproject_v0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 secondForm;
            secondForm = new Form2();
            secondForm.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            base.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\bakst\\OneDrive - Friesland College\\School Sem Barelds\\Jaar 1\\adult-medieval-knight-costume.jpg");

        }
    }
    public class refer1
    {
        public static void variables()
        {
            var test1 = "hallooootjes";
        }
    }
