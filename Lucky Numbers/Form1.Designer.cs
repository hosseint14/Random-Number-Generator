namespace Lucky_Numbers
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnGenerate = new Button();
            lblNumber = new Label();
            txtMaxNumber = new TextBox();
            lblMaxNumberHint = new Label();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(76, 175, 80);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(27, 130);
            btnGenerate.Margin = new Padding(4);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(170, 41);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.ForeColor = Color.FromArgb(51, 51, 51);
            lblNumber.Location = new Point(131, 222);
            lblNumber.Margin = new Padding(4, 0, 4, 0);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(306, 28);
            lblNumber.TabIndex = 1;
            lblNumber.Text = "Random number will appear here.";
            // 
            // txtMaxNumber
            // 
            txtMaxNumber.Location = new Point(27, 88);
            txtMaxNumber.Margin = new Padding(4);
            txtMaxNumber.Name = "txtMaxNumber";
            txtMaxNumber.Size = new Size(170, 34);
            txtMaxNumber.TabIndex = 2;
            // 
            // lblMaxNumberHint
            // 
            lblMaxNumberHint.AutoSize = true;
            lblMaxNumberHint.ForeColor = Color.FromArgb(51, 51, 51);
            lblMaxNumberHint.Location = new Point(27, 46);
            lblMaxNumberHint.Margin = new Padding(4, 0, 4, 0);
            lblMaxNumberHint.Name = "lblMaxNumberHint";
            lblMaxNumberHint.Size = new Size(410, 28);
            lblMaxNumberHint.TabIndex = 1;
            lblMaxNumberHint.Text = "Enter the number of unique random numbers:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 303);
            Controls.Add(txtMaxNumber);
            Controls.Add(lblMaxNumberHint);
            Controls.Add(lblNumber);
            Controls.Add(btnGenerate);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerate;
        private Label lblNumber;
        private TextBox txtMaxNumber;
        private Label lblMaxNumberHint;
    }
}
