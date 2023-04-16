namespace OM_aLLin
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonNextStep = new System.Windows.Forms.Button();
            this.buttonPrevStep = new System.Windows.Forms.Button();
            this.labelPointer = new System.Windows.Forms.Label();
            this.button_Floyd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(209, 111);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(320, 233);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // buttonNextStep
            // 
            this.buttonNextStep.Location = new System.Drawing.Point(388, 350);
            this.buttonNextStep.Name = "buttonNextStep";
            this.buttonNextStep.Size = new System.Drawing.Size(39, 23);
            this.buttonNextStep.TabIndex = 1;
            this.buttonNextStep.Text = "next";
            this.buttonNextStep.UseVisualStyleBackColor = true;
            this.buttonNextStep.Click += new System.EventHandler(this.buttonNextStep_Click);
            // 
            // buttonPrevStep
            // 
            this.buttonPrevStep.Location = new System.Drawing.Point(310, 350);
            this.buttonPrevStep.Name = "buttonPrevStep";
            this.buttonPrevStep.Size = new System.Drawing.Size(36, 23);
            this.buttonPrevStep.TabIndex = 2;
            this.buttonPrevStep.Text = "prev";
            this.buttonPrevStep.UseVisualStyleBackColor = true;
            this.buttonPrevStep.Click += new System.EventHandler(this.buttonPrevStep_Click);
            // 
            // labelPointer
            // 
            this.labelPointer.AutoSize = true;
            this.labelPointer.Location = new System.Drawing.Point(352, 355);
            this.labelPointer.Name = "labelPointer";
            this.labelPointer.Size = new System.Drawing.Size(30, 13);
            this.labelPointer.TabIndex = 3;
            this.labelPointer.Text = "2/11";
            // 
            // button_Floyd
            // 
            this.button_Floyd.Location = new System.Drawing.Point(697, 21);
            this.button_Floyd.Name = "button_Floyd";
            this.button_Floyd.Size = new System.Drawing.Size(75, 23);
            this.button_Floyd.TabIndex = 4;
            this.button_Floyd.Text = "Флойд";
            this.button_Floyd.UseVisualStyleBackColor = true;
            this.button_Floyd.Click += new System.EventHandler(this.button_Floyd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 536);
            this.Controls.Add(this.button_Floyd);
            this.Controls.Add(this.labelPointer);
            this.Controls.Add(this.buttonPrevStep);
            this.Controls.Add(this.buttonNextStep);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonNextStep;
        private System.Windows.Forms.Button buttonPrevStep;
        private System.Windows.Forms.Label labelPointer;
        private System.Windows.Forms.Button button_Floyd;
    }
}

