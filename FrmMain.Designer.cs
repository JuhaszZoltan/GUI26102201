namespace GUI26102201
{
    partial class FrmMain
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
            lblUI001 = new Label();
            lblUI002 = new Label();
            nudLowerBound = new NumericUpDown();
            lblUI003 = new Label();
            btnDetermine = new Button();
            nudUpperBound = new NumericUpDown();
            nudGivenNumber = new NumericUpDown();
            lblResult = new Label();
            ((System.ComponentModel.ISupportInitialize)nudLowerBound).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudUpperBound).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGivenNumber).BeginInit();
            SuspendLayout();
            // 
            // lblUI001
            // 
            lblUI001.AutoSize = true;
            lblUI001.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUI001.Location = new Point(40, 25);
            lblUI001.Name = "lblUI001";
            lblUI001.Size = new Size(94, 19);
            lblUI001.TabIndex = 0;
            lblUI001.Text = "lower bound";
            // 
            // lblUI002
            // 
            lblUI002.AutoSize = true;
            lblUI002.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUI002.Location = new Point(204, 25);
            lblUI002.Name = "lblUI002";
            lblUI002.Size = new Size(96, 19);
            lblUI002.TabIndex = 0;
            lblUI002.Text = "upper bound";
            // 
            // nudLowerBound
            // 
            nudLowerBound.Location = new Point(40, 47);
            nudLowerBound.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudLowerBound.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            nudLowerBound.Name = "nudLowerBound";
            nudLowerBound.Size = new Size(94, 32);
            nudLowerBound.TabIndex = 0;
            nudLowerBound.TextAlign = HorizontalAlignment.Right;
            // 
            // lblUI003
            // 
            lblUI003.AutoSize = true;
            lblUI003.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUI003.Location = new Point(40, 107);
            lblUI003.Name = "lblUI003";
            lblUI003.Size = new Size(102, 19);
            lblUI003.TabIndex = 0;
            lblUI003.Text = "given number";
            // 
            // btnDetermine
            // 
            btnDetermine.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDetermine.Location = new Point(171, 107);
            btnDetermine.Name = "btnDetermine";
            btnDetermine.Size = new Size(128, 54);
            btnDetermine.TabIndex = 3;
            btnDetermine.Text = "determine";
            btnDetermine.UseVisualStyleBackColor = true;
            // 
            // nudUpperBound
            // 
            nudUpperBound.Location = new Point(204, 47);
            nudUpperBound.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudUpperBound.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            nudUpperBound.Name = "nudUpperBound";
            nudUpperBound.Size = new Size(94, 32);
            nudUpperBound.TabIndex = 1;
            nudUpperBound.TextAlign = HorizontalAlignment.Right;
            // 
            // nudGivenNumber
            // 
            nudGivenNumber.Location = new Point(41, 129);
            nudGivenNumber.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudGivenNumber.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            nudGivenNumber.Name = "nudGivenNumber";
            nudGivenNumber.Size = new Size(94, 32);
            nudGivenNumber.TabIndex = 2;
            nudGivenNumber.TextAlign = HorizontalAlignment.Right;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.White;
            lblResult.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblResult.Location = new Point(33, 195);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(272, 84);
            lblResult.TabIndex = 0;
            lblResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 303);
            Controls.Add(btnDetermine);
            Controls.Add(nudUpperBound);
            Controls.Add(nudGivenNumber);
            Controls.Add(nudLowerBound);
            Controls.Add(lblUI002);
            Controls.Add(lblResult);
            Controls.Add(lblUI003);
            Controls.Add(lblUI001);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "FrmMain";
            Text = "interval";
            ((System.ComponentModel.ISupportInitialize)nudLowerBound).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudUpperBound).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGivenNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI001;
        private Label lblUI002;
        private NumericUpDown nudLowerBound;
        private Label lblUI003;
        private Button btnDetermine;
        private NumericUpDown nudUpperBound;
        private NumericUpDown nudGivenNumber;
        private Label lblResult;
    }
}
