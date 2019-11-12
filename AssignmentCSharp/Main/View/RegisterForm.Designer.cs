namespace AssignmentCSharp.Main.View
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.reenterBox = new System.Windows.Forms.TextBox();
            this.roleBox = new System.Windows.Forms.ComboBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(139, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Re-enter password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Role:";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(196, 148);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(412, 22);
            this.emailBox.TabIndex = 5;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(196, 193);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(412, 22);
            this.passwordBox.TabIndex = 6;
            // 
            // reenterBox
            // 
            this.reenterBox.Location = new System.Drawing.Point(196, 240);
            this.reenterBox.Name = "reenterBox";
            this.reenterBox.Size = new System.Drawing.Size(412, 22);
            this.reenterBox.TabIndex = 7;
            // 
            // roleBox
            // 
            this.roleBox.FormattingEnabled = true;
            this.roleBox.Items.AddRange(new object[] {
            "Stock Keeper",
            "Kitchen Staff",
            "Cashier",
            ""});
            this.roleBox.Location = new System.Drawing.Point(196, 282);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(146, 24);
            this.roleBox.TabIndex = 8;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(357, 369);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 9;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.roleBox);
            this.Controls.Add(this.reenterBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox reenterBox;
        private System.Windows.Forms.ComboBox roleBox;
        private System.Windows.Forms.Button RegisterButton;
    }
}