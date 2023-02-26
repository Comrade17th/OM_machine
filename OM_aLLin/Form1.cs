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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            run_test(richTextBox1);
        }

        static void run_test(RichTextBox richTextBox)
        {

            int[,] priceMap = new int[,] {
            { 2, 3, 4, 3 },
            { 5, 3, 1, 2 },
            { 2, 1, 4, 2 }
            };
            int[] storage = new int[] { 414, 138, 184 };
            int[] needs = new int[] {276, 92, 138, 184 };
            TrafficOptimization TO = new TrafficOptimization(priceMap, storage, needs);
            richTextBox.Text = TO.GetInfo();
        }
    }
}
