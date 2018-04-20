namespace NobiWinClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 35);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Find agent";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Navn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefon:";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(205, 10);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(79, 20);
            this.txt1.TabIndex = 8;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(77, 85);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(79, 20);
            this.txt4.TabIndex = 9;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(78, 54);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(79, 20);
            this.txt3.TabIndex = 10;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(78, 23);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(79, 20);
            this.txt2.TabIndex = 11;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(77, 115);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(79, 20);
            this.txt5.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kampagne:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 154);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Label label5;
    }
}

