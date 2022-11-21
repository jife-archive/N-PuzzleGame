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
    public partial class Solution : Form
    {
        public List<Solution> Children = new List<Solution>();
        public Solution parent;

        public Solution(int[] puzzel)
        {
            InitializeComponent();
            this.puzzel = puzzel;
        }

        public int[] puzzel = { 0 };
        int blank = 0;
        public int cols;
        public int rows;
        int clickcount;
        int btnX = 220; // 버튼 생성위치x값
        int btnY = 150; //버튼 생성위치y값
        int btn1_SIZE = 75; //버튼 세로사이즈
        int btn2_SIZE = 75; //버튼 가로사이즈
       
       
        public void creatpuzzle()
        {
            int btnStartX = btnX;
            int btnStartY = btnY;
            int count=0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Button p = new Button();
                    p.BackgroundImage = Image.FromFile(@"D:\화성버튼-1.png");
                    p.BackgroundImageLayout = ImageLayout.Zoom;
                    p.Left = btnStartX;
                    p.Top = btnStartY;
                    p.Width = btn2_SIZE;
                    p.Height = btn2_SIZE;
                    p.BringToFront();
                    p.FlatAppearance.BorderColor = Color.FromArgb(26, 29, 47);
                    p.BackColor = Color.FromArgb(26, 29, 47);
                    p.Font = new Font("둥근모꼴", 22);
                    p.ForeColor = Color.White;
                    p.Text = puzzel[count].ToString();
                    btnStartX += btn1_SIZE;
                    count++;
                    if (p.Text != blank.ToString())
                    {
                        this.Controls.Add(p);

                    }
                }
                btnStartY += btn1_SIZE;
                btnStartX = btnX;
            }
        }
        public void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            clickcount++;//클릭수 증가
            clcikcount.Text = clickcount.ToString();

            int position = 0; //버튼 기준점

            for (int i = 0; i < puzzel.Length; i++)
            {
                if (btn.Text == puzzel[i].ToString())
                {
                    position = i;
                }
            }

            if (position % cols != 0 && puzzel[position - 1] == blank)
            {
                btn.Left -= btn1_SIZE;
                puzzel[position - 1] = puzzel[position];
                puzzel[position] = blank;
                Solution child = new Solution(puzzel);
                Children.Add(child);
                child.parent = this;
                
            }
            else if (position % cols != cols - 1 && puzzel[position + 1] == blank)
            {
                btn.Left += btn1_SIZE;
                puzzel[position + 1] = puzzel[position];
                puzzel[position] = blank;
                Solution child = new Solution(puzzel);
                Children.Add(child);
                child.parent = this;
            }
            else if (position >= cols && puzzel[position - cols] == blank)
            {
                btn.Top -= btn1_SIZE;
                puzzel[position - cols] = puzzel[position];
                puzzel[position] = blank;
                Solution child = new Solution(puzzel);
                Children.Add(child);
                child.parent = this;
            }
            else if (position < puzzel.Length - cols && puzzel[position + cols] == blank)
            {
                btn.Top += btn1_SIZE;
                puzzel[position + cols] = puzzel[position];
                puzzel[position] = blank;
                Solution child = new Solution(puzzel);
                Children.Add(child);
                child.parent = this;
            }
        }
        public bool Checksol()
        {
            for (int i = 0; i < puzzel.Length - 1; i++)
            {
                if (puzzel[i] != i + 1)
                {
                    return false;
                }
            }
            return true;
        }
        private void Solution_Load(object sender, EventArgs e)
        {
            creatpuzzle();
        }


        private void Solution_FormClosing(object sender, FormClosingEventArgs e)//닫을때 초기화
        {
            
        }

        internal void Button_Click()
        {
            throw new NotImplementedException();
        }

    }
    
    class BFS
    {
        public BFS()
        {

        }
        public List<Solution> Serach(Solution root)
        {
            List<Solution> path = new List<Solution>();
            List<Solution> open = new List<Solution>();
            List<Solution> closed = new List<Solution>();
            open.Add(root);
            bool solutionGoal = false;
            while (open.Count > 0 && !solutionGoal)
            {
                Solution currentNode = open[0];
                closed.Add(currentNode);
                open.RemoveAt(0);
                currentNode.Button_Click();

                for(int i = 0; i < currentNode.Children.Count; i++)
                {
                    Solution currentChild = currentNode.Children[i];
                    if (currentNode.Checksol())
                    {
                        solutionGoal = true;
                    }
                }
            }
            return path;
        }
    }
   
}
