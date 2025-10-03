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


namespace Math_Quiz
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

       private string GameResultFile = "C:\\Users\\Admin\\Pictures\\picture for math quiz game\\GameResult.txt";


        private struct stGameResult
        {
            public string Rounds;
            public string RoundsPassed;
            public string level;
            public string oparetionType;
            public string Time;
            public string InTime;
            public string CorrectAnswers;
            public string WrongAnswers;
            public string SkippedQuestions;
        }
        stGameResult gameResult;


        private void FillTheGameResultStructure(string[] Record)
        {
            gameResult.Rounds = Record[0];
            gameResult.RoundsPassed = Record[1];
            gameResult.level = Record[2];
            gameResult.oparetionType = Record[3];

            if((gameResult.Time = Record[4]) == "NO TIME REQUIRED")
            {
                 gameResult.InTime = "NO TIME REQUIRED";
            }
            else
            {
                  gameResult.Time = Record[4] + "s";
                  gameResult.InTime = Record[5] + "/" + gameResult.Time;
            }

            gameResult.CorrectAnswers = Record[6];
            gameResult.WrongAnswers = Record[7];
            gameResult.SkippedQuestions = Record[8];
        }

        private string[] SepareteTheRecord(string Line)
        {
            string[] Record = Line.Split('#');
            return Record;
        }

        private void GetGameResultFromFile()
        {
            StreamReader reader = new StreamReader(GameResultFile);

            FillTheGameResultStructure(SepareteTheRecord(reader.ReadLine()));

            reader.Close();
        }

        private void UpdateGameResultLabels()
        {
            lblRounds.Text = gameResult.Rounds;
            lblRoundsPassed.Text = gameResult.RoundsPassed + "/" + gameResult.Rounds;
            lblGameLevel.Text = gameResult.level;
            lblOP.Text = gameResult.oparetionType;
            lblTime.Text = gameResult.Time;
            lblInTime.Text = gameResult.InTime;
            lblCorrectAnswers.Text = gameResult.CorrectAnswers;
            lblWrongAnswers.Text = gameResult.WrongAnswers; 
            lblSkippedQuestions.Text = gameResult.SkippedQuestions;
        }

   
        private void Form3_Load_1(object sender, EventArgs e)
        {
            GetGameResultFromFile();
            UpdateGameResultLabels();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Title.ForeColor  = Color.Lime;
            timer1.Stop();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Title.ForeColor  = Color.Yellow;
            timer2.Stop();
            timer1.Start();
        }
    }
}
