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
    public partial class Form1 : Form
    {
        List<string> listStats;
        int pointer = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            run_test(richTextBox1,richTextBox_debug, out listStats);
            initPointer();
            int[] arr = new int[2];
        }

        static void run_test(RichTextBox richTextBox,RichTextBox debug, out List<string> listStats)
        {
            listStats = new List<string>();
            int[,] priceMap = new int[,] {
            { 2, 3, 4, 3 },
            { 5, 3, 1, 2 },
            { 2, 1, 4, 2 }
            };
            int[] storage = new int[] { 414, 138, 184 };
            int[] needs = new int[] {276, 92, 138, 184 };
            TrafficOptimization TO = new TrafficOptimization(priceMap, storage, needs);
            
            TO.NordWestMethod(out listStats);
            richTextBox.Text = listStats[0];

            debug.Text = TO.OptimizationTest();
        }

        private void toNextStep()
        {
            if(pointer < listStats.Count -1)
            {
                
                buttonPrevStep.Enabled = true;
                pointer++;
                richTextBox1.Text = listStats[pointer];
            }
            if( pointer == listStats.Count - 1)
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

        private void button_Floyd_Click(object sender, EventArgs e)
        {
            Form_floyd frm = new Form_floyd();
            frm.Show();
        }

        private void button_trueFLoyd_Click(object sender, EventArgs e)
        {
            FormTrueFloyd frm = new FormTrueFloyd();
            frm.Show();
        }
    }
}
