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
            this.start_picker = new System.Windows.Forms.DateTimePicker();
            this.end_picker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.start_hour = new System.Windows.Forms.ComboBox();
            this.start_minute = new System.Windows.Forms.ComboBox();
            this.end_minute = new System.Windows.Forms.ComboBox();
            this.end_hour = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starttidspunkt";
            // 
            // start_picker
            // 
            this.start_picker.Location = new System.Drawing.Point(16, 34);
            this.start_picker.Name = "start_picker";
            this.start_picker.Size = new System.Drawing.Size(188, 22);
            this.start_picker.TabIndex = 1;
            // 
            // end_picker
            // 
            this.end_picker.Location = new System.Drawing.Point(16, 95);
            this.end_picker.Name = "end_picker";
            this.end_picker.Size = new System.Drawing.Size(188, 22);
            this.end_picker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sluttidspunkt";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Opret vagt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // start_hour
            // 
            this.start_hour.FormattingEnabled = true;
            this.start_hour.Items.AddRange(new object[] {
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.start_hour.Location = new System.Drawing.Point(210, 34);
            this.start_hour.Name = "start_hour";
            this.start_hour.Size = new System.Drawing.Size(57, 24);
            this.start_hour.TabIndex = 5;
            this.start_hour.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // start_minute
            // 
            this.start_minute.FormattingEnabled = true;
            this.start_minute.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.start_minute.Location = new System.Drawing.Point(273, 34);
            this.start_minute.Name = "start_minute";
            this.start_minute.Size = new System.Drawing.Size(57, 24);
            this.start_minute.TabIndex = 6;
            // 
            // end_minute
            // 
            this.end_minute.FormattingEnabled = true;
            this.end_minute.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.end_minute.Location = new System.Drawing.Point(273, 97);
            this.end_minute.Name = "end_minute";
            this.end_minute.Size = new System.Drawing.Size(57, 24);
            this.end_minute.TabIndex = 8;
            // 
            // end_hour
            // 
            this.end_hour.FormattingEnabled = true;
            this.end_hour.Items.AddRange(new object[] {
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.end_hour.Location = new System.Drawing.Point(210, 97);
            this.end_hour.Name = "end_hour";
            this.end_hour.Size = new System.Drawing.Size(57, 24);
            this.end_hour.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 190);
            this.Controls.Add(this.end_minute);
            this.Controls.Add(this.end_hour);
            this.Controls.Add(this.start_minute);
            this.Controls.Add(this.start_hour);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.end_picker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.start_picker);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker start_picker;
        private System.Windows.Forms.DateTimePicker end_picker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox start_hour;
        private System.Windows.Forms.ComboBox start_minute;
        private System.Windows.Forms.ComboBox end_minute;
        private System.Windows.Forms.ComboBox end_hour;
    }
}

