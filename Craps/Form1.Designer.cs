namespace Craps
{
    partial class CrapsGame
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
            this.lblDice1 = new System.Windows.Forms.Label();
            this.lblDice2 = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblBankBalance = new System.Windows.Forms.Label();
            this.txtBoxBets = new System.Windows.Forms.TextBox();
            this.lblDisplayResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDice1
            // 
            this.lblDice1.Image = global::Craps.Properties.Resources.Die0;
            this.lblDice1.Location = new System.Drawing.Point(339, 60);
            this.lblDice1.Name = "lblDice1";
            this.lblDice1.Size = new System.Drawing.Size(50, 50);
            this.lblDice1.TabIndex = 0;
            this.lblDice1.Click += new System.EventHandler(this.lblDice1_Click);
            // 
            // lblDice2
            // 
            this.lblDice2.Image = global::Craps.Properties.Resources.Die0;
            this.lblDice2.Location = new System.Drawing.Point(411, 60);
            this.lblDice2.Name = "lblDice2";
            this.lblDice2.Size = new System.Drawing.Size(50, 50);
            this.lblDice2.TabIndex = 1;
            this.lblDice2.Click += new System.EventHandler(this.lblDice2_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRoll.Location = new System.Drawing.Point(336, 141);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(127, 45);
            this.btnRoll.TabIndex = 2;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblBankBalance
            // 
            this.lblBankBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBankBalance.Location = new System.Drawing.Point(255, 206);
            this.lblBankBalance.Name = "lblBankBalance";
            this.lblBankBalance.Size = new System.Drawing.Size(88, 29);
            this.lblBankBalance.TabIndex = 3;
            this.lblBankBalance.Text = "$100.00";
            this.lblBankBalance.Click += new System.EventHandler(this.lblBankBalance_Click);
            // 
            // txtBoxBets
            // 
            this.txtBoxBets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxBets.Location = new System.Drawing.Point(339, 203);
            this.txtBoxBets.Name = "txtBoxBets";
            this.txtBoxBets.PlaceholderText = "enter your bet";
            this.txtBoxBets.Size = new System.Drawing.Size(122, 29);
            this.txtBoxBets.TabIndex = 4;
            this.txtBoxBets.TextChanged += new System.EventHandler(this.txtBoxBets_TextChanged);
            // 
            // lblDisplayResults
            // 
            this.lblDisplayResults.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDisplayResults.Location = new System.Drawing.Point(480, 206);
            this.lblDisplayResults.Name = "lblDisplayResults";
            this.lblDisplayResults.Size = new System.Drawing.Size(100, 26);
            this.lblDisplayResults.TabIndex = 5;
            this.lblDisplayResults.Text = "Result";
            this.lblDisplayResults.Click += new System.EventHandler(this.lblDisplayResults_Click);
            // 
            // CrapsGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDisplayResults);
            this.Controls.Add(this.txtBoxBets);
            this.Controls.Add(this.lblBankBalance);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.lblDice2);
            this.Controls.Add(this.lblDice1);
            this.Name = "CrapsGame";
            this.Text = "Craps";
            this.Load += new System.EventHandler(this.CrapsGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDice1;
        private Label lblDice2;
        private Button btnRoll;
        private Label lblBankBalance;
        private TextBox txtBoxBets;
        private Label lblDisplayResults;
    }
}