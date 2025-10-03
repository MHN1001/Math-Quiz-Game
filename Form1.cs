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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string DB_File = "C:\\Users\\Admin\\Pictures\\picture for math quiz game\\QuizOrder.txt";

        private struct stMathQuizPlayerRequirement
        {
            public string QuizLevel;
            public string OparetionType;
            public byte NumberOfRounds;
            public byte TimeDuration;
        }
        stMathQuizPlayerRequirement QuizMainRequirement;


        private void GetQuizLevel()
        {
            QuizMainRequirement.QuizLevel = cbQuizLevel.SelectedItem.ToString().ToUpper();
        }
        private void GetOparetionType(RadioButton radioButton)
        {

            if(radioButton == rbAddition)
                QuizMainRequirement.OparetionType = "+";
            else if(radioButton == rbSubtraction)
                QuizMainRequirement.OparetionType = "-";
            else if(radioButton == rbMultiplication)
                QuizMainRequirement.OparetionType = "*";
            else if(radioButton == rbDivision)
                QuizMainRequirement.OparetionType = "/";
            else
                QuizMainRequirement.OparetionType = "Mix";

        }
        private void GetNumberOfRounds()
        {
            QuizMainRequirement.NumberOfRounds = Convert.ToByte(NUPDnumberOfRounds.Value);
        }
        private string GenerateOrderREcordToSend()
        {

            string OrderRecord = QuizMainRequirement.NumberOfRounds + "#" + QuizMainRequirement.QuizLevel.ToUpper() +
                                  "#" + QuizMainRequirement.OparetionType.ToUpper() + "#" + QuizMainRequirement.TimeDuration.ToString().ToUpper();

            return OrderRecord;
        }
        private void SendOrderToFile()
        {
            FillFileByOrder(DB_File, GenerateOrderREcordToSend());
        }

        private void GetTimeDuration()
        {
            QuizMainRequirement.TimeDuration = Convert.ToByte(NUPDTimeDuration.Value);
        }

        //Events 
        private void OparetionTypeRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            GetOparetionType((RadioButton)sender);
        }

        private void NUPnumberOfRounds_ValueChanged(object sender, EventArgs e)
        {
            GetNumberOfRounds();
        }
        private void FillFileByOrder(string FileName, string RecordOrder)
        {

            using(StreamWriter writer = new StreamWriter(FileName))
            {
                writer.Write(RecordOrder);

            }
        }
        private void cbQuizLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetQuizLevel();
        }

        private void CallForm2()
        {
            Form form2 = new Form2();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckFromThePlayerChoice();
        }

        private void CheckFromThePlayerChoice()
        {
            if(!string.IsNullOrEmpty(QuizMainRequirement.OparetionType) &&
               !string.IsNullOrEmpty(QuizMainRequirement.QuizLevel))
            {

                if(QuizMainRequirement.NumberOfRounds == 0)
                {
                    errorProvider1.SetError(NUPDnumberOfRounds, "The Minimum Round You Can Choose is 1");
                    return;
                }
                else
                {
                    SendOrderToFile();
                    CallForm2();
                    this.Close();
                }
            }
            else
                return;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbQuizLevel.SelectedIndex = cbQuizLevel.Items.Count - 1;
            rbMix.Checked = true;
        }

        private void NUPDTimeDuration_ValueChanged(object sender, EventArgs e)
        {
            GetTimeDuration();
        }


    }
}

