using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OM_aLLin
{
    public partial class Form_floyd : Form
    {
        List<string> listStats;
        int pointer = 0;
        Matrix mtrx = new Matrix();
        public Form_floyd()
        {
            InitializeComponent();
        }

        private void Form_floyd_Load(object sender, EventArgs e)
        {
            DevLoadText();
            
        }

        private void DevLoadText()
        {
            richTextBox_InputMTRX.Text = "7 9 7\n9 7 8\n7 8 8";
        }



        private void toNextStep()
        {
            if (pointer < listStats.Count - 1)
            {

                buttonPrevStep.Enabled = true;
                pointer++;
                richTextBox1.Text = listStats[pointer];
            }
            if (pointer == listStats.Count - 1)
            {
                buttonNextStep.Enabled = false;

            }
            labelPointer.Text = $"{pointer + 1}/{listStats.Count}";
        }
        private void initPointer()
        {
            labelPointer.Text = $"{pointer + 1}/{listStats.Count}";
            buttonPrevStep.Enabled = false;
        }
        private void toPrevStep()
        {
            if (pointer > 0)
            {
                buttonNextStep.Enabled = true;
                pointer--;
                richTextBox1.Text = listStats[pointer];
            }
            if (pointer == 0)
            {
                buttonPrevStep.Enabled = false;
            }
            labelPointer.Text = $"{pointer + 1}/{listStats.Count}";
        }

        private void buttonNextStep_Click(object sender, EventArgs e)
        {
            toNextStep();
        }

        private void buttonPrevStep_Click(object sender, EventArgs e)
        {
            toPrevStep();
        }

        private void loadMatrixRichToMem()
        {
            mtrx = new Matrix(InputMaker.StringToArr(richTextBox_InputMTRX.Text));
        }

        private void btn_LoadMTRX_Click(object sender, EventArgs e)
        {
            loadMatrixRichToMem();
        }

        private void runCalculateIter()
        {
            int iterations = int.Parse(textBox_iterations.Text);
            IterationGame ig = new IterationGame(mtrx, iterations);
            string chances;
            listStats = ig.Calculate(out chances);
            richTextBox1.Text = listStats[0];
            richTextBox_chances.Text = chances;
            initPointer();
        }

        private void button_calculateIter_Click(object sender, EventArgs e)
        {
            runCalculateIter();
        }

        private void buttonNextStep_Click_1(object sender, EventArgs e)
        {
            toNextStep();
        }

        private void buttonPrevStep_Click_1(object sender, EventArgs e)
        {
            toPrevStep();
        }
    }
}
