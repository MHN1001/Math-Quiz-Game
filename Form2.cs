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
using System.Reflection.Emit;
using static System.Net.Mime.MediaTypeNames;

namespace Math_Quiz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private string GameRequirementFile = "C:\\Users\\Admin\\Pictures\\picture for math quiz game\\QuizOrder.txt";
        private string GameResultFile = "C:\\Users\\Admin\\Pictures\\picture for math quiz game\\GameResult.txt";

        enum enAnswerStatus { Correct = 1, Wrong, inknown };
        enum enOparetionType { Addition = 1, Subtraction, Miltiplication, Division, Mix };
        enum enGameLevel { easy = 1, medium, hard, mix };
        enum enRadioButtons { rb1 = 1, rb2, rb3, rb4 };
        enRadioButtons RadioButtonsCorrentAnswer;


        enum enRequirementTime { Required, NotRequired }


        private struct stGameRequirement
        {
            public byte Rounds;
            public enGameLevel Level;
            public enOparetionType OparetionType;
            public enRequirementTime requirementTime;
            public short Time;
        }
        stGameRequirement GameRequirement;

        private struct stGameStatus
        {
            public byte Rounds;
            public byte RoundsPassed;
            public enGameLevel level;

            public double Number1;
            public enOparetionType OP;
            public double Number2;
            public double Result;
            public enAnswerStatus AnswerStatus;

            public byte CorrectQuestions;
            public byte WrongQuestions;
            public byte SkipQuestion;

            public short TimeLeft;
        }
        stGameStatus GameStatus;


        private void CheckIfTimerRuirement()
        {
            if(GameRequirement.requirementTime == enRequirementTime.Required)
            {
                timer1.Start();
            }
        }

        //Get Game Requirement
        private void SetLevel(string Level)
        {
            switch(Level.ToUpper())
            {
                case "EASY":
                {
                    GameRequirement.Level = enGameLevel.easy;
                    break;
                }
                case "MEDIUM":
                {
                    GameRequirement.Level = enGameLevel.medium;
                    break;
                }
                case "HARD":
                {
                    GameRequirement.Level = enGameLevel.hard;
                    break;
                }
                case "MIX":
                {
                    GameRequirement.Level = enGameLevel.mix;
                    break;
                }
            }
        }
        private void SetOparetionType(string OparetionType)
        {
            switch(OparetionType.ToUpper())
            {
                case "+":
                {
                    GameRequirement.OparetionType = enOparetionType.Addition;
                    break;
                }
                case "-":
                {
                    GameRequirement.OparetionType = enOparetionType.Subtraction;
                    break;
                }
                case "*":
                {
                    GameRequirement.OparetionType = enOparetionType.Miltiplication;
                    break;
                }
                case "MIX":
                {
                    GameRequirement.OparetionType = enOparetionType.Mix;
                    break;
                }
            }
        }
        private void GetPlayerChoiceReady(string ChoiceLine)
        {
            string[] RecordChoice = ChoiceLine.Split('#');

            GameRequirement.Rounds = Convert.ToByte(RecordChoice[0]);
            SetLevel(RecordChoice[1]);
            SetOparetionType(RecordChoice[2]);
            CheckIfTimeRequired(Convert.ToInt16(RecordChoice[3]));

        }
        private void GetPlayerChoiceFromFile()
        {
            StreamReader reader = new StreamReader(GameRequirementFile);

            string ChoiceRecordLine = reader.ReadToEnd();

            GetPlayerChoiceReady(ChoiceRecordLine);

            reader.Close();
        }

        //Check If Time Required
        private void CheckIfTimeRequired(short TimeDuration)
        {
            if(TimeDuration == 0)
            {
                GameRequirement.requirementTime = enRequirementTime.NotRequired;
            }
            else
            {
                GameRequirement.requirementTime = enRequirementTime.Required;
                GameRequirement.Time = TimeDuration;
                GameStatus.TimeLeft = TimeDuration;
            }
        }

        //Game Result
        private string checkTime()
        {

            if(GameRequirement.requirementTime == enRequirementTime.Required)
            {
                return GameRequirement.Time.ToString();
            }
            else return "NO TIME REQUIRED";


        }

        private string GetResultGameForSenditToFile()
        {


            string StrResultGame = GameRequirement.Rounds + "#" + GameStatus.RoundsPassed + "#" + GameRequirement.Level + "#" +
                                   GameRequirement.OparetionType + "#" + checkTime() + "#" + +GameStatus.TimeLeft + "#" +
                                   GameStatus.CorrectQuestions + "#" + GameStatus.WrongQuestions + "#" +
                                   GameStatus.SkipQuestion;

            return StrResultGame;
        }
        private void SendResultGameToFile()
        {
            StreamWriter writer = new StreamWriter(GameResultFile);

            writer.Write(GetResultGameForSenditToFile());

            writer.Close();
        }

        private void GoToResultForm()
        {
            SendResultGameToFile();
            //Call Form3
            Form form3 = new Form3();
            form3.ShowDialog();

        }

        //Update Choice Label
        private void UpdateGameStatusLabels()
        {
            lblRound.Text = GameStatus.Rounds.ToString();
            lblLevel.Text = GameStatus.level.ToString().ToUpper();
            lblOparetionType.Text = GameStatus.OP.ToString().ToUpper();
            lblCorrectAnswer.Text = GameStatus.CorrectQuestions.ToString();
            lblWrongAnswers.Text = GameStatus.WrongQuestions.ToString();

            if(GameRequirement.requirementTime == enRequirementTime.Required)
            {
                lblTime.Text = GameStatus.TimeLeft.ToString() + " s";
            }
            else
                lblTime.Text = "NO TIME REQUIRED";
        }

        //Answer
        private void CheckIfThePlayerChooseTheCorrectAnswer(RadioButton rb)
        {
            if(RadioButtonsCorrentAnswer == (enRadioButtons)Convert.ToInt16(rb.Tag))
            {
                GameStatus.AnswerStatus = enAnswerStatus.Correct;
            }
            else
                GameStatus.AnswerStatus = enAnswerStatus.Wrong;
        }
        private void CheckTheAnswer()
        {


            switch(GameStatus.AnswerStatus)
            {
                case enAnswerStatus.inknown:
                {
                    return;
                }
                case enAnswerStatus.Wrong:
                {
                    GameStatus.WrongQuestions++;
                    UpdateGameStatusLabels();
                    PerformQuiestion();
                    break;
                }
                case enAnswerStatus.Correct:
                {
                    GameStatus.CorrectQuestions++;
                    UpdateGameStatusLabels();
                    PerformQuiestion();
                    break;
                }
            }

            GameStatus.Rounds--;
            GameStatus.RoundsPassed++;
            UpdateGameStatusLabels();
            UncheckedAllRadionButtons();
        }

        //Question 
        private char GetRandomlyOparetionType()
        {
            Random random = new Random();
            GameStatus.OP = (enOparetionType)random.Next(1, 4);
            return GetOparetionType(GameStatus.OP);
        }
        private char GetOparetionType(enOparetionType oparetionType)
        {
            switch(oparetionType)
            {
                case enOparetionType.Mix:
                {
                    return GetRandomlyOparetionType();
                    break;
                }
                case enOparetionType.Addition:
                {
                    return '+';
                    break;
                }
                case enOparetionType.Subtraction:
                {
                    return '-';
                    break;
                }
                case enOparetionType.Miltiplication:
                {
                    return '*';
                    break;
                }
                default:
                {
                    return '/';
                    break;
                }
            }
        }
        private double GetRandomlyNumber()
        {
            Random randomLevel = new Random();
            GameStatus.level = (enGameLevel)randomLevel.Next(1, 3);
            return GetNumber(GameStatus.level);
        }
        private double GetNumber(enGameLevel gameLevel)
        {
            Random randomNumber = new Random();

            switch(gameLevel)
            {
                case enGameLevel.mix:
                {
                    return GetRandomlyNumber();
                }
                case enGameLevel.easy:
                {
                    return randomNumber.Next(1, 100);
                }
                case enGameLevel.medium:
                {
                    return randomNumber.Next(100, 350);
                }
                default:
                {
                    return randomNumber.Next(350, 1000);
                }
            }
        }
        private void SetUpQuestion(double number1, double number2, char OparetionType)
        {
            switch(OparetionType)
            {
                case '+':
                {
                    GameStatus.Result = number1 + number2;
                    tbQuestionScreen.Text = Convert.ToString(number1) + " + " + Convert.ToString(number2);
                    break;
                }
                case '-':
                {
                    GameStatus.Result = number1 - number2;
                    tbQuestionScreen.Text = Convert.ToString(number1) + " - " + Convert.ToString(number2);
                    break;
                }
                case '*':
                {
                    GameStatus.Result = number1 * number2;
                    tbQuestionScreen.Text = Convert.ToString(number1) + " * " + Convert.ToString(number2);
                    break;
                }
                case '/':
                {
                    GameStatus.Result = number1 / number2;
                    tbQuestionScreen.Text = Convert.ToString(number1) + " / " + Convert.ToString(number2);
                    break;
                }
            }
        }
        private void PerformQuiestion()
        {

            if(GameStatus.Rounds > 0)
            {

                GameStatus.Number1 = GetNumber(GameRequirement.Level);
                this.Refresh();
                GameStatus.Number2 = GetNumber(GameRequirement.Level);
                char op = GetOparetionType(GameRequirement.OparetionType);

                SetUpQuestion(GameStatus.Number1, GameStatus.Number2, op);
                SetForRadionButtonsRandomAnswer();

                UpdateGameStatusLabels();

            }
            else
            {
                if(GameRequirement.requirementTime == enRequirementTime.Required)
                {
                    timer1.Stop();
                }

                GoToResultForm();
            }
        }

        //Radio buttons
        private void UncheckedAllRadionButtons()
        {
            rbResult1.Checked = false;
            rbResult2.Checked = false;
            rbResult3.Checked = false;
            rbResult4.Checked = false;

            GameStatus.AnswerStatus = enAnswerStatus.inknown;


        }
        private void GiveTheWrongAnswerForRadioButtons(RadioButton rb1, RadioButton rb2, RadioButton rb3)
        {
            Random randomrb1 = new Random();
            Random randomrb2 = new Random();
            Random randomrb3 = new Random();

            rb1.Text = Convert.ToString(randomrb1.Next(Convert.ToInt32(GameStatus.Result - Convert.ToInt32(GameStatus.Result + GameStatus.Number2))
                                                        , Convert.ToInt32(GameStatus.Result)));

            rb2.Text = Convert.ToString(randomrb2.Next(Convert.ToInt32(GameStatus.Result - GameStatus.Number1),
                                                       Convert.ToInt32(GameStatus.Result + GameStatus.Number2)));

            rb3.Text = Convert.ToString(randomrb3.Next(0, Convert.ToInt32(GameStatus.Number2 * 2)));
        }
        private void TargetTheRadionButtonThatHaveTheRightAnswer()
        {
            switch(RadioButtonsCorrentAnswer)
            {
                case enRadioButtons.rb1:
                {
                    GiveTheWrongAnswerForRadioButtons(rbResult2, rbResult3, rbResult4);
                    break;
                }
                case enRadioButtons.rb2:
                {
                    GiveTheWrongAnswerForRadioButtons(rbResult1, rbResult3, rbResult4);
                    break;
                }
                case enRadioButtons.rb3:
                {
                    GiveTheWrongAnswerForRadioButtons(rbResult2, rbResult1, rbResult4);
                    break;
                }
                case enRadioButtons.rb4:
                {
                    GiveTheWrongAnswerForRadioButtons(rbResult2, rbResult3, rbResult1);
                    break;
                }
            }

        }
        private void GiveTheCorrectAnswerForRadioButton()
        {
            Random randomrb = new Random();

            switch(randomrb.Next(1, 4))
            {
                case 1:
                {
                    RadioButtonsCorrentAnswer = enRadioButtons.rb1;
                    rbResult1.Text = Convert.ToString(GameStatus.Result);
                    break;
                }
                case 2:
                {
                    RadioButtonsCorrentAnswer = enRadioButtons.rb2;
                    rbResult2.Text = Convert.ToString(GameStatus.Result);
                    break;
                }
                case 3:
                {
                    RadioButtonsCorrentAnswer = enRadioButtons.rb3;
                    rbResult3.Text = Convert.ToString(GameStatus.Result);
                    break;
                }
                case 4:
                {
                    RadioButtonsCorrentAnswer = enRadioButtons.rb4;
                    rbResult4.Text = Convert.ToString(GameStatus.Result);
                    break;
                }
            }
        }
        private void SetForRadionButtonsRandomAnswer()
        {
            GiveTheCorrectAnswerForRadioButton();
            TargetTheRadionButtonThatHaveTheRightAnswer();
        }


        //Restart Game
        private void ResetGameSatus()
        {
            GameStatus.Rounds = GameRequirement.Rounds;
            GameStatus.RoundsPassed = 0;
            GameRequirement.Level = GameRequirement.Level;
            GameStatus.Number1 = 0;
            GameStatus.Number2 = 0;
            GameStatus.OP = GameRequirement.OparetionType;
            GameStatus.AnswerStatus = enAnswerStatus.inknown;
            GameStatus.CorrectQuestions = 0;
            GameStatus.WrongQuestions = 0;
            GameStatus.TimeLeft = GameRequirement.Time;
            GameStatus.SkipQuestion = 0;
        }
        private void RestartGame()
        {
            UncheckedAllRadionButtons();
            ResetGameSatus();
        }

        //Avents

        private void Form2_Load(object sender, EventArgs e)
        {
            GameStatus.AnswerStatus = enAnswerStatus.inknown;
            UncheckedAllRadionButtons();

            GetPlayerChoiceFromFile();
            UpdateGameStatusLabels();
            GameStatus.Rounds = GameRequirement.Rounds;
            PerformQuiestion();
            CheckIfTimerRuirement();

        }
        private void RadioButons_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfThePlayerChooseTheCorrectAnswer((RadioButton)sender);
        }
        private void btnCheckAnsewr_Click(object sender, EventArgs e)
        {
            CheckTheAnswer();
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            GameStatus.SkipQuestion++;
            GameStatus.RoundsPassed++;
            UncheckedAllRadionButtons();
            if(( GameStatus.Rounds-- ) == 0)
            {
                GoToResultForm();
                return;
            }
            UncheckedAllRadionButtons();
            PerformQuiestion();
            SetForRadionButtonsRandomAnswer();
        }

        //Menue Strip Options
        private void TSMIrestartGame_Click(object sender, EventArgs e)
        {
            RestartGame();
            UpdateGameStatusLabels();
            PerformQuiestion();
            UpdateGameStatusLabels();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(GameStatus.TimeLeft > 0)
            {
                GameStatus.TimeLeft--;
                lblTime.Text = GameStatus.TimeLeft.ToString() + " s";
            }
            else
            {
                timer1.Stop();

                GoToResultForm();
            }

        }

        private void btnCheckAnsewr_MouseEnter(object sender, EventArgs e)
        {
            btnCheckAnsewr.BackColor = Color.Green;
        }

        private void btnCheckAnsewr_MouseLeave(object sender, EventArgs e)
        {
            btnCheckAnsewr.BackColor = Color.Yellow;
        }

        private void btnNextQuestion_MouseEnter(object sender, EventArgs e)
        {
            btnNextQuestion.BackColor = Color.Yellow;
        }

        private void btnNextQuestion_MouseLeave(object sender, EventArgs e)
        {
            btnNextQuestion.BackColor = Color.DarkOrange;
        }
    }
}
