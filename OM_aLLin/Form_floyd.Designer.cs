
namespace OM_aLLin
{
    partial class Form_floyd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPointer = new System.Windows.Forms.Label();
            this.buttonPrevStep = new System.Windows.Forms.Button();
            this.buttonNextStep = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_InputMTRX = new System.Windows.Forms.RichTextBox();
            this.btn_LoadMTRX = new System.Windows.Forms.Button();
            this.button_calculateIter = new System.Windows.Forms.Button();
            this.textBox_iterations = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_chances = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPointer
            // 
            this.labelPointer.AutoSize = true;
            this.labelPointer.Location = new System.Drawing.Point(247, 319);
            this.labelPointer.Name = "labelPointer";
            this.labelPointer.Size = new System.Drawing.Size(30, 13);
            this.labelPointer.TabIndex = 7;
            this.labelPointer.Text = "2/11";
            // 
            // buttonPrevStep
            // 
            this.buttonPrevStep.Location = new System.Drawing.Point(205, 314);
            this.buttonPrevStep.Name = "buttonPrevStep";
            this.buttonPrevStep.Size = new System.Drawing.Size(36, 23);
            this.buttonPrevStep.TabIndex = 6;
            this.buttonPrevStep.Text = "prev";
            this.buttonPrevStep.UseVisualStyleBackColor = true;
            this.buttonPrevStep.Click += new System.EventHandler(this.buttonPrevStep_Click_1);
            // 
            // buttonNextStep
            // 
            this.buttonNextStep.Location = new System.Drawing.Point(283, 314);
            this.buttonNextStep.Name = "buttonNextStep";
            this.buttonNextStep.Size = new System.Drawing.Size(39, 23);
            this.buttonNextStep.TabIndex = 5;
            this.buttonNextStep.Text = "next";
            this.buttonNextStep.UseVisualStyleBackColor = true;
            this.buttonNextStep.Click += new System.EventHandler(this.buttonNextStep_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 75);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(512, 233);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // richTextBox_InputMTRX
            // 
            this.richTextBox_InputMTRX.Location = new System.Drawing.Point(530, 75);
            this.richTextBox_InputMTRX.Name = "richTextBox_InputMTRX";
            this.richTextBox_InputMTRX.Size = new System.Drawing.Size(184, 139);
            this.richTextBox_InputMTRX.TabIndex = 8;
            this.richTextBox_InputMTRX.Text = "";
            // 
            // btn_LoadMTRX
            // 
            this.btn_LoadMTRX.Location = new System.Drawing.Point(584, 221);
            this.btn_LoadMTRX.Name = "btn_LoadMTRX";
            this.btn_LoadMTRX.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadMTRX.TabIndex = 9;
            this.btn_LoadMTRX.Text = "Загрузить";
            this.btn_LoadMTRX.UseVisualStyleBackColor = true;
            this.btn_LoadMTRX.Click += new System.EventHandler(this.btn_LoadMTRX_Click);
            // 
            // button_calculateIter
            // 
            this.button_calculateIter.Location = new System.Drawing.Point(584, 268);
            this.button_calculateIter.Name = "button_calculateIter";
            this.button_calculateIter.Size = new System.Drawing.Size(75, 23);
            this.button_calculateIter.TabIndex = 10;
            this.button_calculateIter.Text = "CalculateIter";
            this.button_calculateIter.UseVisualStyleBackColor = true;
            this.button_calculateIter.Click += new System.EventHandler(this.button_calculateIter_Click);
            // 
            // textBox_iterations
            // 
            this.textBox_iterations.Location = new System.Drawing.Point(530, 49);
            this.textBox_iterations.Name = "textBox_iterations";
            this.textBox_iterations.Size = new System.Drawing.Size(100, 20);
            this.textBox_iterations.TabIndex = 11;
            this.textBox_iterations.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(530, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Количество итераций";
            // 
            // richTextBox_chances
            // 
            this.richTextBox_chances.Location = new System.Drawing.Point(101, 12);
            this.richTextBox_chances.Name = "richTextBox_chances";
            this.richTextBox_chances.Size = new System.Drawing.Size(256, 57);
            this.richTextBox_chances.TabIndex = 13;
            this.richTextBox_chances.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Вероятнсоти";
            // 
            // Form_floyd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox_chances);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_iterations);
            this.Controls.Add(this.button_calculateIter);
            this.Controls.Add(this.btn_LoadMTRX);
            this.Controls.Add(this.richTextBox_InputMTRX);
            this.Controls.Add(this.labelPointer);
            this.Controls.Add(this.buttonPrevStep);
            this.Controls.Add(this.buttonNextStep);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form_floyd";
            this.Text = "Form_floyd";
            this.Load += new System.EventHandler(this.Form_floyd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPointer;
        private System.Windows.Forms.Button buttonPrevStep;
        private System.Windows.Forms.Button buttonNextStep;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox_InputMTRX;
        private System.Windows.Forms.Button btn_LoadMTRX;
        private System.Windows.Forms.Button button_calculateIter;
        private System.Windows.Forms.TextBox textBox_iterations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_chances;
        private System.Windows.Forms.Label label2;
    }
}