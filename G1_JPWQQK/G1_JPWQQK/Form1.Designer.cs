namespace G1_JPWQQK
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.answerBtn1 = new System.Windows.Forms.Button();
            this.answerBtn2 = new System.Windows.Forms.Button();
            this.answerBtn3 = new System.Windows.Forms.Button();
            this.questionPicture = new System.Windows.Forms.PictureBox();
            this.nextBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.questionPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionTextLabel.Location = new System.Drawing.Point(22, 9);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(600, 81);
            this.questionTextLabel.TabIndex = 0;
            this.questionTextLabel.Text = "Kérdés";
            this.questionTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerBtn1
            // 
            this.answerBtn1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.answerBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerBtn1.Location = new System.Drawing.Point(22, 93);
            this.answerBtn1.Name = "answerBtn1";
            this.answerBtn1.Size = new System.Drawing.Size(600, 100);
            this.answerBtn1.TabIndex = 1;
            this.answerBtn1.Text = "Válasz1";
            this.answerBtn1.UseVisualStyleBackColor = false;
            this.answerBtn1.Click += new System.EventHandler(this.answerBtn1_Click);
            // 
            // answerBtn2
            // 
            this.answerBtn2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.answerBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerBtn2.Location = new System.Drawing.Point(22, 199);
            this.answerBtn2.Name = "answerBtn2";
            this.answerBtn2.Size = new System.Drawing.Size(600, 100);
            this.answerBtn2.TabIndex = 2;
            this.answerBtn2.Text = "Válasz2";
            this.answerBtn2.UseVisualStyleBackColor = false;
            this.answerBtn2.Click += new System.EventHandler(this.answerBtn2_Click);
            // 
            // answerBtn3
            // 
            this.answerBtn3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.answerBtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerBtn3.Location = new System.Drawing.Point(22, 305);
            this.answerBtn3.Name = "answerBtn3";
            this.answerBtn3.Size = new System.Drawing.Size(600, 100);
            this.answerBtn3.TabIndex = 3;
            this.answerBtn3.Text = "Válasz3";
            this.answerBtn3.UseVisualStyleBackColor = false;
            this.answerBtn3.Click += new System.EventHandler(this.answerBtn3_Click);
            // 
            // questionPicture
            // 
            this.questionPicture.Location = new System.Drawing.Point(649, 93);
            this.questionPicture.Name = "questionPicture";
            this.questionPicture.Size = new System.Drawing.Size(600, 339);
            this.questionPicture.TabIndex = 4;
            this.questionPicture.TabStop = false;
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextBtn.Location = new System.Drawing.Point(221, 411);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(200, 50);
            this.nextBtn.TabIndex = 5;
            this.nextBtn.Text = "Következő kérdés";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1291, 473);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.questionPicture);
            this.Controls.Add(this.answerBtn3);
            this.Controls.Add(this.answerBtn2);
            this.Controls.Add(this.answerBtn1);
            this.Controls.Add(this.questionTextLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.Button answerBtn1;
        private System.Windows.Forms.Button answerBtn2;
        private System.Windows.Forms.Button answerBtn3;
        private System.Windows.Forms.PictureBox questionPicture;
        private System.Windows.Forms.Button nextBtn;
    }
}

