namespace AssignmentCSharp.Main.View
{
    partial class EmailSupplierForm
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
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "To";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(345, 332);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(100, 28);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(167, 44);
            this.textBoxTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(277, 22);
            this.textBoxTo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Content";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(167, 108);
            this.textBoxSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(277, 22);
            this.textBoxSubject.TabIndex = 5;
            // 
            // textBoxContent
            // 
            this.textBoxContent.Location = new System.Drawing.Point(167, 181);
            this.textBoxContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(277, 127);
            this.textBoxContent.TabIndex = 6;
            // 
            // EmailSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 405);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EmailSupplierForm";
            this.Text = "Email Supplier";
            this.Load += new System.EventHandler(this.EmailSupplierForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxContent;
    }
}