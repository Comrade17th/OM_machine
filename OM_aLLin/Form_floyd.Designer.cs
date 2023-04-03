
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
            this.SuspendLayout();
            // 
            // labelPointer
            // 
            this.labelPointer.AutoSize = true;
            this.labelPointer.Location = new System.Drawing.Point(174, 319);
            this.labelPointer.Name = "labelPointer";
            this.labelPointer.Size = new System.Drawing.Size(30, 13);
            this.labelPointer.TabIndex = 7;
            this.labelPointer.Text = "2/11";
            // 
            // buttonPrevStep
            // 
            this.buttonPrevStep.Location = new System.Drawing.Point(132, 314);
            this.buttonPrevStep.Name = "buttonPrevStep";
            this.buttonPrevStep.Size = new System.Drawing.Size(36, 23);
            this.buttonPrevStep.TabIndex = 6;
            this.buttonPrevStep.Text = "prev";
            this.buttonPrevStep.UseVisualStyleBackColor = true;
            // 
            // buttonNextStep
            // 
            this.buttonNextStep.Location = new System.Drawing.Point(210, 314);
            this.buttonNextStep.Name = "buttonNextStep";
            this.buttonNextStep.Size = new System.Drawing.Size(39, 23);
            this.buttonNextStep.TabIndex = 5;
            this.buttonNextStep.Text = "next";
            this.buttonNextStep.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(31, 75);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(320, 233);
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
            // Form_floyd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}