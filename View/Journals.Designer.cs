namespace LazyCalculator
{
    partial class Journals
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
            this.btnGetJournalEntries = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label34 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.journalDataGrid = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.journalDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetJournalEntries
            // 
            this.btnGetJournalEntries.Location = new System.Drawing.Point(331, 10);
            this.btnGetJournalEntries.Name = "btnGetJournalEntries";
            this.btnGetJournalEntries.Size = new System.Drawing.Size(75, 23);
            this.btnGetJournalEntries.TabIndex = 12;
            this.btnGetJournalEntries.Text = "Refresh";
            this.btnGetJournalEntries.UseVisualStyleBackColor = true;
            this.btnGetJournalEntries.Click += new System.EventHandler(this.btnGetJournalEntries_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(211, 11);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(185, 15);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(20, 13);
            this.label34.TabIndex = 10;
            this.label34.Text = "To";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "From";
            // 
            // journalDataGrid
            // 
            this.journalDataGrid.AllowUserToAddRows = false;
            this.journalDataGrid.AllowUserToDeleteRows = false;
            this.journalDataGrid.AllowUserToOrderColumns = true;
            this.journalDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.journalDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.journalDataGrid.Location = new System.Drawing.Point(12, 41);
            this.journalDataGrid.Name = "journalDataGrid";
            this.journalDataGrid.ReadOnly = true;
            this.journalDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.journalDataGrid.Size = new System.Drawing.Size(955, 397);
            this.journalDataGrid.TabIndex = 8;
            this.journalDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.journalDataGrid_CellDoubleClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(53, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // Journals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(979, 450);
            this.Controls.Add(this.btnGetJournalEntries);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.journalDataGrid);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Journals";
            this.Text = "Journals";
            ((System.ComponentModel.ISupportInitialize)(this.journalDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetJournalEntries;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView journalDataGrid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}