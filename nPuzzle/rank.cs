using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace nPuzzle
{
    public partial class rank : Form
    {
       public int Psize;
        public string usrname;
        public int scores;
        public rank()
        {
            InitializeComponent();
          
        }

        public void checkrank(int size, int count, string usrname)
        {
            string[] name = new string[3];
            int[] scores = new int[3];
            if (size == 2)
            {

                StreamReader reader = new StreamReader(@"D:\바탕화면\nPuzzle\명예의전당\2순위.txt");
                while (reader.EndOfStream == false)
                {
                    scores[0] = int.Parse(reader.ReadLine());
                    scores[1] = int.Parse(reader.ReadLine());
                    scores[2] = int.Parse(reader.ReadLine());
                    name[0] = reader.ReadLine();
                    name[1] = reader.ReadLine();
                    name[2] = reader.ReadLine();
                }
                reader.Close();
                
                if (scores[2] > count)
                {
                    int tmp = scores[2];
                    scores[2] = count;
                    string tmpname = name[2];
                    name[2] = usrname;
                }
                for(int i = 0; i < 2; i++)
                {
                    for(int j = i + 1; j < 3; j++)
                    {
                        if (scores[i] > scores[j])
                        {
                            int tmp = scores[i];
                            scores[i] = scores[j];
                            scores[j] = tmp;

                            string tmpname = name[i];
                            name[i] = name[j];
                            name[j] = tmpname;
                        }
                    }
                }

                StreamWriter writer = new StreamWriter(@"D:\바탕화면\nPuzzle\명예의전당\2순위.txt");
                for (int i = 0; i < 3; i++)
                {
                    writer.WriteLine(scores[i]);
                }
                for (int i = 0; i < 3; i++)
                {
                    writer.WriteLine(name[i]);
                }
                writer.Close();
                FirstUsr.Text = name[0];
                SecondUsr.Text = name[1];
                ThridUsr.Text = name[2];
            }
            if (size == 3)
            {

                StreamReader reader = new StreamReader(@"D:\바탕화면\nPuzzle\명예의전당\3순위.txt");
                while (reader.EndOfStream == false)
                {
                    scores[0] = int.Parse(reader.ReadLine());
                    scores[1] = int.Parse(reader.ReadLine());
                    scores[2] = int.Parse(reader.ReadLine());
                    name[0] = reader.ReadLine();
                    name[1] = reader.ReadLine();
                    name[2] = reader.ReadLine();
                }
                reader.Close();

                if (scores[2] > count)
                {
                    int tmp = scores[2];
                    scores[2] = count;
                    string tmpname = name[2];
                    name[2] = usrname;
                }
                for (int i = 0; i < 2; i++)
                {
                    for (int j = i + 1; j < 3; j++)
                    {
                        if (scores[i] > scores[j])
                        {
                            int tmp = scores[i];
                            scores[i] = scores[j];
                            scores[j] = tmp;

                            string tmpname = name[i];
                            name[i] = name[j];
                            name[j] = tmpname;
                        }
                    }
                }

                StreamWriter writer = new StreamWriter(@"D:\바탕화면\nPuzzle\명예의전당\3순위.txt");
                for (int i = 0; i < 3; i++)
                {
                    writer.WriteLine(scores[i]);
                }
                for (int i = 0; i < 3; i++)
                {
                    writer.WriteLine(name[i]);
                }
                writer.Close();
                FirstUsr.Text = name[0];
                SecondUsr.Text = name[1];
                ThridUsr.Text = name[2];
            }
        }

        private void rank_Load(object sender, EventArgs e)
        {
            nPuzzle.Text = Psize.ToString() + "x" + Psize.ToString() + "Puzzle Game";
            checkrank(Psize,scores, usrname);
        }


        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Owner.Visible = true;
        }

        private void backbtn_MouseEnter(object sender, EventArgs e)
        {
            backbtn.Location = new Point(backbtn.Location.X, backbtn.Location.Y - 7);
           
        }

        private void backbtn_MouseLeave(object sender, EventArgs e)
        {
            backbtn.Location = new Point(backbtn.Location.X, backbtn.Location.Y + 7);
        }

        private void exitbtn_MouseEnter(object sender, EventArgs e)
        {
            exitbtn.Location = new Point(exitbtn.Location.X - 7, exitbtn.Location.Y);
            
        }

        private void exitbtn_MouseLeave(object sender, EventArgs e)
        {
            exitbtn.Location = new Point(exitbtn.Location.X + 7, exitbtn.Location.Y);
           
        }

    }
}
