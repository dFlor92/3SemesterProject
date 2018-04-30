namespace NobiWinClient
{
    partial class testLeadList
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.leadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leadBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.leadBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.txtRefresh = new System.Windows.Forms.Button();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dmaa02171065555DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.leadBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txt6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmaa02171065555DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.Status});
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.leadBindingSource, "Id", true));
            this.dataGridView1.DataSource = this.leadBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(208, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 494);
            this.dataGridView1.TabIndex = 29;
            // 
            // leadBindingSource
            // 
            this.leadBindingSource.DataSource = typeof(NobiWinClient.LeadService.Lead);
            // 
            // leadBindingSource3
            // 
            this.leadBindingSource3.DataSource = typeof(NobiWinClient.LeadService.Lead);
            // 
            // leadBindingSource2
            // 
            this.leadBindingSource2.DataSource = typeof(NobiWinClient.LeadService.Lead);
            // 
            // txtRefresh
            // 
            this.txtRefresh.Location = new System.Drawing.Point(87, 181);
            this.txtRefresh.Name = "txtRefresh";
            this.txtRefresh.Size = new System.Drawing.Size(75, 23);
            this.txtRefresh.TabIndex = 28;
            this.txtRefresh.Text = "Refresh";
            this.txtRefresh.UseVisualStyleBackColor = true;
            this.txtRefresh.Click += new System.EventHandler(this.txtRefresh_Click);
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(87, 106);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(79, 20);
            this.txt5.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Kampagne:";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(88, 14);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(79, 20);
            this.txt2.TabIndex = 25;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(88, 45);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(79, 20);
            this.txt3.TabIndex = 24;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(87, 76);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(79, 20);
            this.txt4.TabIndex = 23;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(88, 468);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(79, 20);
            this.txt1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Navn:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 499);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 24);
            this.button1.TabIndex = 18;
            this.button1.Text = "Find agent";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 471);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Id:";
            // 
            // agentBindingSource7
            // 
            this.agentBindingSource7.DataSource = typeof(NobiWinClient.AgentService.Agent);
            // 
            // leadBindingSource1
            // 
            this.leadBindingSource1.DataSource = typeof(NobiWinClient.LeadService.Lead);
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(87, 137);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(79, 20);
            this.txt6.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Status:";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // testLeadList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 536);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtRefresh);
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
            this.Name = "testLeadList";
            this.Text = "testLeadList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmaa02171065555DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dmaa02171065555DataSet1BindingSource;
        private System.Windows.Forms.BindingSource agentBindingSource;
        private System.Windows.Forms.Button txtRefresh;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource agentBindingSource7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource leadBindingSource;
        private System.Windows.Forms.BindingSource leadBindingSource1;
        private System.Windows.Forms.BindingSource leadBindingSource2;
        private System.Windows.Forms.BindingSource leadBindingSource3;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}