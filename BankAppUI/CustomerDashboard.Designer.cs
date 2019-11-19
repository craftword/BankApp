namespace BankAppUI
{
    partial class CustomerDashboard
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
            this.BtnWithdraw = new System.Windows.Forms.Button();
            this.BtnTransfer = new System.Windows.Forms.Button();
            this.BtnStatement = new System.Windows.Forms.Button();
            this.BtnDeposit = new System.Windows.Forms.Button();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbResults = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnWithdraw
            // 
            this.BtnWithdraw.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnWithdraw.Location = new System.Drawing.Point(78, 231);
            this.BtnWithdraw.Name = "BtnWithdraw";
            this.BtnWithdraw.Size = new System.Drawing.Size(245, 51);
            this.BtnWithdraw.TabIndex = 1;
            this.BtnWithdraw.Text = "Withdraw";
            this.BtnWithdraw.UseVisualStyleBackColor = false;
            this.BtnWithdraw.Click += new System.EventHandler(this.BtnWithdraw_Click);
            // 
            // BtnTransfer
            // 
            this.BtnTransfer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnTransfer.Location = new System.Drawing.Point(78, 318);
            this.BtnTransfer.Name = "BtnTransfer";
            this.BtnTransfer.Size = new System.Drawing.Size(245, 51);
            this.BtnTransfer.TabIndex = 2;
            this.BtnTransfer.Text = "Transfer";
            this.BtnTransfer.UseVisualStyleBackColor = false;
            this.BtnTransfer.Click += new System.EventHandler(this.BtnTransfer_Click);
            // 
            // BtnStatement
            // 
            this.BtnStatement.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnStatement.Location = new System.Drawing.Point(78, 404);
            this.BtnStatement.Name = "BtnStatement";
            this.BtnStatement.Size = new System.Drawing.Size(245, 51);
            this.BtnStatement.TabIndex = 3;
            this.BtnStatement.Text = "Account Statement";
            this.BtnStatement.UseVisualStyleBackColor = false;
            this.BtnStatement.Click += new System.EventHandler(this.BtnStatement_Click);
            // 
            // BtnDeposit
            // 
            this.BtnDeposit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnDeposit.Location = new System.Drawing.Point(78, 147);
            this.BtnDeposit.Name = "BtnDeposit";
            this.BtnDeposit.Size = new System.Drawing.Size(245, 51);
            this.BtnDeposit.TabIndex = 4;
            this.BtnDeposit.Text = "Deposit ";
            this.BtnDeposit.UseVisualStyleBackColor = false;
            this.BtnDeposit.Click += new System.EventHandler(this.BtnDeposit_Click);
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.Location = new System.Drawing.Point(73, 45);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(0, 29);
            this.lbWelcome.TabIndex = 5;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(435, 202);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(77, 32);
            this.lbResult.TabIndex = 6;
            this.lbResult.Text = "label";
            // 
            // lbResults
            // 
            this.lbResults.AutoSize = true;
            this.lbResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResults.Location = new System.Drawing.Point(435, 147);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(99, 32);
            this.lbResults.TabIndex = 7;
            this.lbResults.Text = "label1";
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.Control;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(441, 309);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(298, 34);
            this.txtInput.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(594, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear Input";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter Amount Deposit/Withdraw";
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(875, 577);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.BtnDeposit);
            this.Controls.Add(this.BtnStatement);
            this.Controls.Add(this.BtnTransfer);
            this.Controls.Add(this.BtnWithdraw);
            this.Name = "CustomerDashboard";
            this.Text = "Customer Dashbaord";
            this.Load += new System.EventHandler(this.CustomerDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnWithdraw;
        private System.Windows.Forms.Button BtnTransfer;
        private System.Windows.Forms.Button BtnStatement;
        private System.Windows.Forms.Button BtnDeposit;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbResults;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}