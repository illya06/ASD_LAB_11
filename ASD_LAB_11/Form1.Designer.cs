namespace ASD_LAB_11
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
            this.start = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.RichTextBox();
            this.text2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logOut = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(253, 83);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 0;
            this.start.Text = "START";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // text1
            // 
            this.text1.BackColor = System.Drawing.Color.White;
            this.text1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text1.Location = new System.Drawing.Point(165, 86);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(70, 18);
            this.text1.TabIndex = 1;
            this.text1.Text = "";
            // 
            // text2
            // 
            this.text2.BackColor = System.Drawing.Color.White;
            this.text2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text2.Location = new System.Drawing.Point(165, 130);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(163, 61);
            this.text2.TabIndex = 2;
            this.text2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pattern : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text : ";
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.White;
            this.logOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logOut.Location = new System.Drawing.Point(114, 209);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(214, 96);
            this.logOut.TabIndex = 5;
            this.logOut.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.RichTextBox text1;
        private System.Windows.Forms.RichTextBox text2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox logOut;
    }
}

