
namespace OM_aLLin
{
    partial class FormTrueFloyd
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
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.labelPointer = new System.Windows.Forms.Label();
            this.buttonPrevStep = new System.Windows.Forms.Button();
            this.buttonNextStep = new System.Windows.Forms.Button();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Location = new System.Drawing.Point(505, 29);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(148, 128);
            this.richTextBoxInput.TabIndex = 0;
            this.richTextBoxInput.Text = "";
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(87, 29);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(358, 242);
            this.richTextBoxOutput.TabIndex = 1;
            this.richTextBoxOutput.Text = "";
            // 
            // labelPointer
            // 
            this.labelPointer.AutoSize = true;
            this.labelPointer.Location = new System.Drawing.Point(245, 274);
            this.labelPointer.Name = "labelPointer";
            this.labelPointer.Size = new System.Drawing.Size(30, 13);
            this.labelPointer.TabIndex = 6;
            this.labelPointer.Text = "2/11";
            // 
            // buttonPrevStep
            // 
            this.buttonPrevStep.Location = new System.Drawing.Point(203, 269);
            this.buttonPrevStep.Name = "buttonPrevStep";
            this.buttonPrevStep.Size = new System.Drawing.Size(36, 23);
            this.buttonPrevStep.TabIndex = 5;
            this.buttonPrevStep.Text = "prev";
            this.buttonPrevStep.UseVisualStyleBackColor = true;
            this.buttonPrevStep.Click += new System.EventHandler(this.buttonPrevStep_Click_1);
            // 
            // buttonNextStep
            // 
            this.buttonNextStep.Location = new System.Drawing.Point(281, 269);
            this.buttonNextStep.Name = "buttonNextStep";
            this.buttonNextStep.Size = new System.Drawing.Size(39, 23);
            this.buttonNextStep.TabIndex = 4;
            this.buttonNextStep.Text = "next";
            this.buttonNextStep.UseVisualStyleBackColor = true;
            this.buttonNextStep.Click += new System.EventHandler(this.buttonNextStep_Click_1);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(530, 210);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(75, 23);
            this.buttonUpload.TabIndex = 7;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // FormTrueFloyd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.labelPointer);
            this.Controls.Add(this.buttonPrevStep);
            this.Controls.Add(this.buttonNextStep);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.richTextBoxInput);
            this.Name = "FormTrueFloyd";
            this.Text = "FormTrueFloyd";
            this.Load += new System.EventHandler(this.FormTrueFloyd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Label labelPointer;
        private System.Windows.Forms.Button buttonPrevStep;
        private System.Windows.Forms.Button buttonNextStep;
        private System.Windows.Forms.Button buttonUpload;
    }
}