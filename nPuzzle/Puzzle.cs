
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace nPuzzle
{

    // 퍼즐클래스 시작
    public partial class puzzle : Form
    {


        //구성요소 
        public string checkusrname;
        int btnX = 220; // 버튼 생성위치x값
        int btnY = 150; //버튼 생성위치y값
        int btn1_SIZE = 75; //버튼 세로사이즈
        int btn2_SIZE = 75; //버튼 가로사이즈
       public static int[] randomNumbers = new int[0]; //배열요소입니다.
        public int numberOfRows; //퍼즐행
        public int numberOfCol;  //퍼즐열      
        const int BLANK_SPACE = 0; //빈칸은 배열에서 0으로 표시했습니다.
        bool flagLoad = false; //퍼즐만들때 기준점
        public static int clickcount = 0;//클릭수
        rank rk = new rank();
        Solution sol = new Solution(randomNumbers);
        public puzzle()
        {
            InitializeComponent();
        }

        //퍼즐,사이즈,위치 변경해주는 함수
        public void changesize()
        {
            if (numberOfCol < 3 && numberOfRows < 3)
            {
                btn2_SIZE = 120;
                btn1_SIZE = 120;
            }
            if (numberOfRows == 5 && numberOfCol == 5)
            {
                btn1_SIZE = 60;
                btn2_SIZE = 60;
                btnX = 180;
                btnY = 110;
            }
            if (numberOfCol > 5 && numberOfRows > 5)
            {
                btn2_SIZE = 50;
                btn1_SIZE = 50;
                btnX = 160;
                btnY = 120;
            }
            

        }
        //풀수없는 퍼즐 걸러주는 함수입니다.
        public bool IsSolvable(int[] intArray)
        {
            bool solvable = false; // 풀수잇는지 아닌지 체크
            int countInversions = 0; //반전갯수 체크
            bool evenInversions = false; // 반전갯수 짝수
            bool evenRowIndex = false; // 짝수 행
            int rowIndex;

            for (int k = 0; k < intArray.Length; k++)
            {
                if (intArray[k] == BLANK_SPACE)
                {
                    rowIndex = (k / numberOfCol);
                    if (rowIndex % 2 == 0)
                    {
                        evenRowIndex = true;
                        break;
                    }
                }
            }

            for (int i = 0; i < intArray.Length - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j] && intArray[j] != BLANK_SPACE)
                    {
                        countInversions++;
                    }
                }
            }

            if (countInversions % 2 == 0) //반전갯수가 짝
            {
                evenInversions = true;
            }

            if (intArray.Length % 2 != 0 && evenInversions) //반전갯수가 짝이고, 행의 길이가 홀이면 풀수있어용
            {
                solvable = true;
            }
            else if (intArray.Length % 2 == 0) //행의 길이가 짝일 경우 ex)4x4,6x6 일 경우는 빈칸이 짝수 행&반전이 홀수개  OR 빈칸 홀수 && 반전짝수 면 풀수있어용!

            {
                if (evenRowIndex && !evenInversions)
                {
                    solvable = true;
                }
                else if (!evenRowIndex && evenInversions)
                {
                    solvable = true;
                }
            }
            if (numberOfCol == 1 && countInversions > 0 || numberOfRows == 1 && countInversions > 0) //위에 적은것 빼고 나머지는 다 못풀어용! 
            {
                solvable = false;
            }
            if (numberOfCol == 1 && countInversions == 0 || numberOfRows == 1 && countInversions == 0)
            {
                solvable = true;
            }

            return solvable;
        }

        //배열 셔플 함수입니다.  요 배열기반으로 탐색알고리즘을 적용하시면 됩니당.
        public int[] ShuffleArray()
        {
            int totalSize = numberOfRows * numberOfCol;
            int[] shuffledArray = new int[totalSize];
            int tempVar;

            do
            {
                //초기 배열구성입니다.
                for (int i = 0; i < totalSize; i++)
                {
                    shuffledArray[i] = i;
                }
                Random z = new Random();

                for (int t = 0; t < shuffledArray.Length; t++)
                {
                    tempVar = shuffledArray[t];
                    int r = z.Next(t, shuffledArray.Length);
                    shuffledArray[t] = shuffledArray[r];
                    shuffledArray[r] = tempVar;
                }
            } while (!IsSolvable(shuffledArray));

            return shuffledArray;

        }
        //퍼즐 완성한거 체크해주는 함수입니다.
        public bool CheckWin()
        {
            for (int i = 0; i < randomNumbers.Length - 1; i++)
            {
                if (randomNumbers[i] != i + 1)
                {
                    return false;
                }
            }
            return true;

        }

        //퍼즐만드는 부분입니다.
        public void CreatePuzzle()
        {
            Count.Text = clickcount.ToString();
            if (CheckWin())
            {
                ShuffleArray();
            }
            changesize();
            int count = 0;
            int btnStartX = btnX;
            int btnStartY = btnY;
            bool validColRow = true;
            const string BLANK_SPACE = "0";

            try
            {

                if (numberOfRows < 0 || numberOfCol < 0)
                {
                    throw new Exception(); //예외처리 요거안넣으니 에러뜨더라구요.
                }
                validColRow = true;
            }
            catch (Exception)
            {
                validColRow = false;
                MessageBox.Show("올바른 행과열의 값을 넣으십시오.");//숫자 아닌거 넣었을 때
            }

            if (validColRow == true)
            {
                if (!flagLoad)
                {
                    randomNumbers = ShuffleArray();
                }

                for (int i = 0; i < numberOfRows; i++)
                {
                    for (int j = 0; j < numberOfCol; j++)
                    {
                        tile t = new tile(this);
                        t.BackgroundImage = Image.FromFile(@"D:\화성버튼-1.png");
                        t.BackgroundImageLayout = ImageLayout.Zoom;
                        t.Left = btnStartX;
                        t.Top = btnStartY;
                        t.Width = btn2_SIZE;
                        t.Height = btn2_SIZE;
                        t.BringToFront();
                        t.FlatAppearance.BorderColor = Color.FromArgb(26, 29, 47);
                        t.BackColor = Color.FromArgb(26, 29, 47); 
                        t.Font = new Font("둥근모꼴", 22);
                        t.ForeColor = Color.White;
                        t.Text = randomNumbers[count].ToString();
                        btnStartX += btn1_SIZE;
                        count++;

                        if (t.Text != BLANK_SPACE)
                        {
                            this.Controls.Add(t);

                        }
                        t.Click += Button_Click;
                    }
                    
                    btnStartY += btn1_SIZE;
                    btnStartX = btnX;
                }
                sol.puzzel = randomNumbers;
            }
           

        }

        //버튼만든거 없애주는 함수입니다. 
        public void DeleteButtons()
        {
            List<tile> buttons = this.Controls.OfType<tile>().ToList();
            foreach (tile btn in buttons)
            {
                if (btn.Top >= btnY)
                {
                    this.Controls.Remove(btn);
                    btn.Dispose();
                }
            }
        }


        //저장 함수 구현中
        public void SaveFile(string fileName)
        {
            StreamWriter writer;
            writer = new StreamWriter(fileName);

            writer.WriteLine(numberOfRows);
            writer.WriteLine(numberOfCol);
            writer.WriteLine(clickcount);
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                writer.WriteLine(randomNumbers[i]);
            }
            writer.Close();
        }
        //불러오기 함수 구현中
        public virtual void LoadFile(string fileName)
        {
            StreamReader reader;
            reader = new StreamReader(fileName);
            while (reader.EndOfStream == false)
            {
                numberOfRows = int.Parse(reader.ReadLine());
                numberOfCol = int.Parse(reader.ReadLine());
                clickcount= int.Parse(reader.ReadLine());
                int[] tempArray = new int[numberOfRows * numberOfCol];
                for (int i = 0; i < tempArray.Length; i++)
                {
                    tempArray[i] = Convert.ToInt32(reader.ReadLine());
                }
                randomNumbers = tempArray;
            }
            reader.Close();
            flagLoad = true;
           
            CreatePuzzle();
        }
        private static DateTime Delay(int MS)//이미지 출력을 위한 딜레이함수
        {
            DateTime Break = DateTime.Now;
            TimeSpan wait = new TimeSpan(0, 0, 0, 0, MS);
            DateTime KeepGo = Break.Add(wait);

            while (KeepGo >= Break)
            {
                System.Windows.Forms.Application.DoEvents();
                Break = DateTime.Now;
            }

            return DateTime.Now;
        }
        private void Button_Click(object sender, EventArgs e)
        {
            tile btn = (tile)sender;
            clickcount++;//클릭수 증가
            Count.Text = clickcount.ToString();

            int position = 0; //버튼 기준점

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                if (btn.Text == randomNumbers[i].ToString())
                {
                    position = i;
                }
            }

            if (position % numberOfCol != 0 && randomNumbers[position - 1] == BLANK_SPACE)
            {
                btn.Left -= btn1_SIZE;
                randomNumbers[position - 1] = randomNumbers[position];
                randomNumbers[position] = BLANK_SPACE;
            }
            else if (position % numberOfCol != numberOfCol - 1 && randomNumbers[position + 1] == BLANK_SPACE)
            {
                btn.Left += btn1_SIZE;
                randomNumbers[position + 1] = randomNumbers[position];
                randomNumbers[position] = BLANK_SPACE;
            }
            else if (position >= numberOfCol && randomNumbers[position - numberOfCol] == BLANK_SPACE)
            {
                btn.Top -= btn1_SIZE;
                randomNumbers[position - numberOfCol] = randomNumbers[position];
                randomNumbers[position] = BLANK_SPACE;
            }
            else if (position < randomNumbers.Length - numberOfCol && randomNumbers[position + numberOfCol] == BLANK_SPACE)
            {
                btn.Top += btn1_SIZE;
                randomNumbers[position + numberOfCol] = randomNumbers[position];
                randomNumbers[position] = BLANK_SPACE;
            }
            
            if (CheckWin())
            {
                wingif.Visible = true;
                DeleteButtons();
                Delay(3020);
                wingif.Visible = false;
                rk.Owner = this;
                rk.usrname = checkusrname;
                rk.scores = clickcount;
                    rk.Psize = numberOfCol;
                    winimg.Visible = true;
                    winimg2.Visible = true;
                    YesBtn.Visible = true;
                    NoBtn.Visible = true;
                    wincom2.Visible = true;
                    winimg.Visible = true;
                    clickcount = 0;
                    Count.Text = clickcount.ToString();
                

            }

        }
        //세이브버튼 구현中
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.DefaultExt = ".csv";
            DialogResult result = dlgSave.ShowDialog();
            switch (result)
            {
                case DialogResult.Cancel:
                    break;
                case DialogResult.OK:
                    try
                    {
                        string filename = dlgSave.FileName;
                        SaveFile(filename);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("저장중 에러!");
                    }

                    break;
                default:
                    break;
            }
        }


        private void Puzzle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();           //종료시 unvisible 한 폼 싹다 종료
        }

        private void Puzzle_Load(object sender, EventArgs e)
        {
            sol.rows = numberOfRows;
            sol.cols = numberOfCol;
            sollabel2.Visible = false;
            usrname.Text = checkusrname;
            Countbox.Visible = false;
            YesBtn.Visible = false;
            NoBtn.Visible = false;
            wingif.Visible = false;
            wincom2.Visible = false;
            winimg.Visible = false;
            winimg2.Visible = false;
            label1.Text = numberOfRows.ToString() + "x" + numberOfCol.ToString() + "Puzzle Game";
            usrname.Text = checkusrname;
            DeleteButtons();
            CreatePuzzle();

        }

  

     

        private void winbtnno_Click(object sender, EventArgs e)
        {
            YesBtn.Visible = false;
            NoBtn.Visible = false;
            wingif.Visible = false;
            wincom2.Visible = false;
            winimg.Visible = false;
            winimg2.Visible = false;
        }

        private void winbtnyes_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            rk.ShowDialog();

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.DefaultExt = ".csv";
            DialogResult result = dlgSave.ShowDialog();
            switch (result)
            {
                case DialogResult.Cancel:
                    break;
                case DialogResult.OK:
                    try
                    {
                        string filename = dlgSave.FileName;
                        SaveFile(filename);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error in file save");
                    }

                    break;
                default:
                    break;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.DefaultExt = ".csv";
            DialogResult result = dlgSave.ShowDialog();
            switch (result)
            {
                case DialogResult.Cancel:
                    break;
                case DialogResult.OK:
                    try
                    {
                        string filename = dlgSave.FileName;
                        SaveFile(filename);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error in file save");
                    }

                    break;
                default:
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            clickcount = 0;
            Count.Text = clickcount.ToString();
            DeleteButtons();
            clickcount = 0;
            this.Visible = false;
            StartMenu str = new StartMenu();
            str.ShowDialog();
        }

        private void backlabel_Click(object sender, EventArgs e)
        {
            clickcount = 0;
            Count.Text = clickcount.ToString();
            DeleteButtons();
            clickcount = 0;
            this.Visible = false;
            StartMenu str = new StartMenu();
            str.ShowDialog();
        }

        private void restratbtn_Click(object sender, EventArgs e)
        {
            int[] reset = { 0 };
            sol.puzzel = reset;
            clickcount = 0;
            Count.Text = clickcount.ToString();
            DeleteButtons();
            clickcount = 0;
            CreatePuzzle();
        }

        private void restartlabel_Click(object sender, EventArgs e)
        {
            
            clickcount = 0;
            Count.Text = clickcount.ToString();
            DeleteButtons();
            clickcount = 0;
            CreatePuzzle();
        }
        
        
        private void solBtn_Click(object sender, EventArgs e) //김도윤!
        {   
            sol.ShowDialog();
            DeleteButtons();
            
          
        }

        private void label5_Click(object sender, EventArgs e)
        {//여기 2개다 솔루션으로 가는 폼 붙여넣기
            solBtn_Click(sender, e);
        }

        private void backbtn_MouseEnter(object sender, EventArgs e)
        {
            backbtn.Location = new Point(backbtn.Location.X - 7, backbtn.Location.Y - 7);
        }

        private void backbtn_MouseLeave(object sender, EventArgs e)
        {
            backbtn.Location = new Point(backbtn.Location.X + 7, backbtn.Location.Y + 7);
        }

        private void restratbtn_MouseEnter(object sender, EventArgs e)
        {
            restratbtn.Location = new Point(restratbtn.Location.X - 7, restratbtn.Location.Y - 7);
        }

        private void restratbtn_MouseLeave(object sender, EventArgs e)
        {
            restratbtn.Location = new Point(restratbtn.Location.X + 7, restratbtn.Location.Y + 7);
        }

        private void savebtn_MouseEnter(object sender, EventArgs e)
        {
            savebtn.Location = new Point(savebtn.Location.X - 7, savebtn.Location.Y - 7);

        }

        private void savebtn_MouseLeave(object sender, EventArgs e)
        {
            savebtn.Location = new Point(savebtn.Location.X + 7, savebtn.Location.Y + 7);
        }

        private void exitbtn_MouseEnter(object sender, EventArgs e)
        {
            exitbtn.Location = new Point(exitbtn.Location.X - 7, exitbtn.Location.Y - 7);
        }

        private void exitbtn_MouseLeave(object sender, EventArgs e)
        {
            exitbtn.Location = new Point(exitbtn.Location.X + 7, exitbtn.Location.Y + 7);
        }

        private void solBtn_MouseEnter(object sender, EventArgs e)
        {
            sollabel2.Visible = true;
            solBtn.Location = new Point(solBtn.Location.X - 7, solBtn.Location.Y - 7);

        }

        private void solBtn_MouseLeave(object sender, EventArgs e)
        {
            sollabel2.Visible = false;
            solBtn.Location = new Point(solBtn.Location.X + 7, solBtn.Location.Y + 7);
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            rk.ShowDialog();
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            YesBtn.Visible = false;
            NoBtn.Visible = false;
            wingif.Visible = false;
            wincom2.Visible = false;
            winimg.Visible = false;
            winimg2.Visible = false;
        }

        private void YesBtn_MouseEnter(object sender, EventArgs e)
        {
            YesBtn.Location = new Point(YesBtn.Location.X, YesBtn.Location.Y - 5);
            YesBtn.ForeColor = Color.Chartreuse;
        }

        private void YesBtn_MouseLeave(object sender, EventArgs e)
        {
            YesBtn.Location = new Point(YesBtn.Location.X, YesBtn.Location.Y + 5);
            YesBtn.ForeColor = Color.White;
        }

        private void NoBtn_MouseEnter(object sender, EventArgs e)
        {
            NoBtn.Location = new Point(NoBtn.Location.X, NoBtn.Location.Y - 5);
            NoBtn.ForeColor = Color.OrangeRed;
        }

        private void NoBtn_MouseLeave(object sender, EventArgs e)
        {
            NoBtn.Location = new Point(NoBtn.Location.X, NoBtn.Location.Y + 5);
            NoBtn.ForeColor = Color.White;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            sollabel2.Visible = true;
            solBtn.Location = new Point(solBtn.Location.X - 7, solBtn.Location.Y - 7);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            sollabel2.Visible = false;
            solBtn.Location = new Point(solBtn.Location.X + 7, solBtn.Location.Y + 7);
        }
    }
}
