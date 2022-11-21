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
    public partial class StartMenu : Form
    {
        public int size;
        public int SendCols;
        public string usrname;
        public StartMenu()
        {
            InitializeComponent();
        }
        puzzle puzzle = new puzzle();
        private void StartMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.DefaultExt = ".csv";
            DialogResult result = dlgOpen.ShowDialog();
            switch (result)
            {
                case DialogResult.Cancel:
                    break;
                case DialogResult.OK:
                    try
                    {
                        string filename = dlgOpen.FileName;
                        puzzle.LoadFile(filename);
                        this.Visible = false;
                        puzzle.ShowDialog();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("불러오기 실패! 다시 시도해주십시오.");
                    }
                    break;
                default:
                    break;
            }

        }

        private void StartMenu_Load(object sender, EventArgs e)
        {
            UserName.Text = usrname;
            label4.Visible = false;
        }

        
        private void loadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.DefaultExt = ".csv";
            DialogResult result = dlgOpen.ShowDialog();
            switch (result)
            {
                case DialogResult.Cancel:
                    break;
                case DialogResult.OK:
                    try
                    {
                        string filename = dlgOpen.FileName;
                        puzzle.LoadFile(filename);
                        this.Visible = false;
                        puzzle.ShowDialog();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("불러오기 실패! 다시 시도해주십시오.");
                    }
                    break;
                default:
                    break;
            }
        }

        private void loadBtn_MouseEnter(object sender, EventArgs e)
        {
            loadBtn.Location = new Point(loadBtn.Location.X, loadBtn.Location.Y - 7);
        }

        private void loadBtn_MouseLeave(object sender, EventArgs e)
        {
            loadBtn.Location = new Point(loadBtn.Location.X, loadBtn.Location.Y + 7);
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            loadBtn_Click(sender, e);

        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            loadBtn.Location = new Point(loadBtn.Location.X, loadBtn.Location.Y - 7);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            loadBtn.Location = new Point(loadBtn.Location.X, loadBtn.Location.Y + 7);
        }

   

        private void startBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            puzzle.Owner = this;
            size = Convert.ToInt32(txtRow.Text);
            SendCols = Convert.ToInt32(txtRow.Text);
            puzzle.checkusrname = usrname;

            if (SendCols > 7 && size > 7 && SendCols < 10 && size < 10)
            {
                if (MessageBox.Show("너무 큰 퍼즐을 만들었습니다. 정말 진행하시겠습니까? 화면크기에 맞지않을 수 있습니다.", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {

                    this.Visible = true;

                }
                else
                {
                    puzzle.numberOfRows = size;
                    puzzle.numberOfCol = size;
                    puzzle.ShowDialog();
                }

            }
            else if (SendCols != size)
            {
                MessageBox.Show("정사각형 형태로 만들어주세요.....\n예를 들면 2x2, 3x3 이런거 있자나요  :(");
                this.Visible = true;
            }
            else if (SendCols > 10 || size > 10)
            {
                MessageBox.Show("당신은 저거 못풀어요....\n되도록이면 10이하로 설정해주세요 :(");
                this.Visible = true;
            }
            else if (SendCols == 0 || size == 0)
            {
                MessageBox.Show("0으로는 퍼즐을 만들수가 없습니다 :(");
                this.Visible = true;
            }
            else
            {
                puzzle.numberOfRows = size;
                puzzle.numberOfCol = size;
                puzzle.ShowDialog();
            }
        }

        private void startBtn_MouseEnter(object sender, EventArgs e)
        {
            label4.Visible = true;
            startBtn.Location = new Point(startBtn.Location.X-2, startBtn.Location.Y-7);
        }
        private void startBtn_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
            startBtn.Location = new Point(startBtn.Location.X + 2, startBtn.Location.Y + 7);
        }

        private void startLabel_MouseEnter(object sender, EventArgs e)
        {
            label4.Visible = true;
            startBtn.Location = new Point(startBtn.Location.X - 2, startBtn.Location.Y - 7);
        }

        private void startLabel_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
            startBtn.Location = new Point(startBtn.Location.X + 2, startBtn.Location.Y + 7);
        }
    }
}
