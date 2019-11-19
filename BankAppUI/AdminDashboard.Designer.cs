namespace BankAppUI
{
    partial class AdminDashboard
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
            this.BtnCreateUsers = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LbWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCreateUsers
            // 
            this.BtnCreateUsers.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnCreateUsers.Location = new System.Drawing.Point(112, 157);
            this.BtnCreateUsers.Name = "BtnCreateUsers";
            this.BtnCreateUsers.Size = new System.Drawing.Size(523, 58);
            this.BtnCreateUsers.TabIndex = 0;
            this.BtnCreateUsers.Text = "Create Users";
            this.BtnCreateUsers.UseVisualStyleBackColor = false;
            this.BtnCreateUsers.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(112, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(523, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "Create Customers";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(112, 333);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(523, 55);
            this.button3.TabIndex = 2;
            this.button3.Text = "Check All Transaction";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LbWelcome
            // 
            this.LbWelcome.AutoSize = true;
            this.LbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbWelcome.Location = new System.Drawing.Point(109, 73);
            this.LbWelcome.Name = "LbWelcome";
            this.LbWelcome.Size = new System.Drawing.Size(109, 38);
            this.LbWelcome.TabIndex = 3;
            this.LbWelcome.Text = "label1";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbWelcome);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnCreateUsers);
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreateUsers;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LbWelcome;
    }
}