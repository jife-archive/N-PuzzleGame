using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nPuzzle
{   
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        StartMenu sm = new StartMenu();
       
        private void StartBtn_Click(object sender, EventArgs e)
        {   
            this.Visible = false;
           
            sm.Owner = this;
            sm.ShowDialog();
        }

      
        private void Namebox_MouseClick(object sender, MouseEventArgs e)
        {
            Namebox.Clear();
        }

        private void ChecknameBtn_Click(object sender, EventArgs e)
        {
            sm.usrname = Namebox.Text.ToString();
          
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            NameCheck.Visible = false;
            nameNo.Visible = false;
            NameYes.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            sm.usrname = Namebox.Text.ToString();
            Namebox.Visible = false;
            NameCheck.Text = sm.usrname + "이(가) 맞습니까?";
            NameCheck.Visible = true;
            nameNo.Visible = true;
            NameYes.Visible = true;
        }

      
        private void NameYes_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            sm.Owner = this;
            sm.ShowDialog();
        }

        private void nameNo_Click(object sender, EventArgs e)
        {
            NameCheck.Visible = false;
            nameNo.Visible = false;
            NameYes.Visible = false;
            Namebox.Visible = true;
            label1.Visible = true;
        }
    }
}
