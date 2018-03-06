namespace RandomNumToluA
{
    partial class frmRandomNumbers
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblNumberAnswer = new System.Windows.Forms.Label();
            this.lblRandomNumber = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(56, 34);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(307, 19);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Click the button to get a number from 1 to 10\r\n";
            // 
            // lblNumberAnswer
            // 
            this.lblNumberAnswer.AutoSize = true;
            this.lblNumberAnswer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberAnswer.Location = new System.Drawing.Point(57, 123);
            this.lblNumberAnswer.Name = "lblNumberAnswer";
            this.lblNumberAnswer.Size = new System.Drawing.Size(125, 19);
            this.lblNumberAnswer.TabIndex = 2;
            this.lblNumberAnswer.Text = "The number is :   ";
            // 
            // lblRandomNumber
            // 
            this.lblRandomNumber.AutoSize = true;
            this.lblRandomNumber.Location = new System.Drawing.Point(204, 127);
            this.lblRandomNumber.Name = "lblRandomNumber";
            this.lblRandomNumber.Size = new System.Drawing.Size(0, 13);
            this.lblRandomNumber.TabIndex = 3;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(139, 76);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(160, 23);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Generate The Number";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // frmRandomNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(443, 174);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblRandomNumber);
            this.Controls.Add(this.lblNumberAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Name = "frmRandomNumbers";
            this.Text = "Random Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblNumberAnswer;
        private System.Windows.Forms.Label lblRandomNumber;
        private System.Windows.Forms.Button btnCheck;
    }
}

