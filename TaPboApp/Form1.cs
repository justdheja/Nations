using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaPboApp
{
    public partial class Form1 : Form
    {
        List<string> listInfo = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCari_Click(object sender, EventArgs e)
        {
            string info = "";
            listInfo = Nations.GetIbuKota(tbInput.Text);
            for(int i = 0; i < listInfo.Count(); i++)
            {
                info += listInfo[i] + "\n";
            }
            rbHasil.Text = info;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Application show you about some information of the country");
        }
    }
}
