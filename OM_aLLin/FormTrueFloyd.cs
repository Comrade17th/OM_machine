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
    public partial class FormTrueFloyd : Form
    {

        List<string> listStats;
        int pointer = 0;
        Matrix mtrx = new Matrix();
        //Floyd fld = new Floyd();
        public FormTrueFloyd()
        {
            InitializeComponent();
        }

        private void FormTrueFloyd_Load(object sender, EventArgs e)
        {
            DevLoadText();
            
        }


        private void DevLoadText()
        {
            //richTextBoxInput.Text = "0 6 i 11\ni 0 4 i\ni i 0 2\ni i i 0";
            richTextBoxInput.Text = "0 3 10 i i\n3 0 i 5 i\n10 0 i 6 15\ni 5 6 0 4\ni i i 4 0";
        }



        private void toNextStep()
        {
            if (pointer < listStats.Count - 1)
            {

                buttonPrevStep.Enabled = true;
                pointer++;
                richTextBoxOutput.Text = listStats[pointer];
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
                richTextBoxOutput.Text = listStats[pointer];
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
            mtrx = new Matrix(InputMaker.StringToArr(richTextBoxInput.Text));
        }

        private void btn_LoadMTRX_Click(object sender, EventArgs e)
        {
            loadMatrixRichToMem();
        }

        private void button_calculateIter_Click(object sender, EventArgs e)
        {
            //loadMatrixRichToMem();
           //runCalculateFloyd();
        }

        private void buttonNextStep_Click_1(object sender, EventArgs e)
        {
            toNextStep();
        }

        private void buttonPrevStep_Click_1(object sender, EventArgs e)
        {
            toPrevStep();
        }

        private void LoadResultToList()
        {
            DoCFGmagic();
            //listStats = fld.FloydWarshall(InputMaker.StringToArr(richTextBoxInput.Text));
        }

        private void DoCFGmagic()
        {
            List<string> result;// = new List<string>();
            GFG.initialise(InputMaker.StringToArr(richTextBoxInput.Text));
            GFG.floydWarshall(out result);
            listStats = result;
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {

            LoadResultToList();
            initPointer();
        }

        private void button_MakePath_Click(object sender, EventArgs e)
        {
            MakePath();
        }

        private void MakePath()
        {
            if(textBox_pointFrom.Text != "" && textBox_pointTo.Text != "")
            {
                int u = int.Parse(textBox_pointFrom.Text);
                int v = int.Parse(textBox_pointTo.Text);
                richTextBox_pathResult.Text = GFG.getPath(u, v);
            }
        }
    }
}
