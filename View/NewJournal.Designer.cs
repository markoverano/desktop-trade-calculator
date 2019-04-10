namespace LazyCalculator
{
    partial class NewJournal
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
            this.txtBuyReason = new System.Windows.Forms.TextBox();
            this.txtSellReason = new System.Windows.Forms.TextBox();
            this.btnSaveJournal = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExitTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpExitDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEntryTime = new System.Windows.Forms.DateTimePicker();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBuyReason
            // 
            this.txtBuyReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuyReason.Location = new System.Drawing.Point(126, 83);
            this.txtBuyReason.Multiline = true;
            this.txtBuyReason.Name = "txtBuyReason";
            this.txtBuyReason.Size = new System.Drawing.Size(187, 77);
            this.txtBuyReason.TabIndex = 0;
            // 
            // txtSellReason
            // 
            this.txtSellReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellReason.Location = new System.Drawing.Point(126, 228);
            this.txtSellReason.Multiline = true;
            this.txtSellReason.Name = "txtSellReason";
            this.txtSellReason.Size = new System.Drawing.Size(187, 80);
            this.txtSellReason.TabIndex = 1;
            // 
            // btnSaveJournal
            // 
            this.btnSaveJournal.Location = new System.Drawing.Point(53, 325);
            this.btnSaveJournal.Name = "btnSaveJournal";
            this.btnSaveJournal.Size = new System.Drawing.Size(75, 23);
            this.btnSaveJournal.TabIndex = 2;
            this.btnSaveJournal.Text = "Save";
            this.btnSaveJournal.UseVisualStyleBackColor = true;
            this.btnSaveJournal.Click += new System.EventHandler(this.btnSaveJournal_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntryDate.Location = new System.Drawing.Point(92, 43);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(97, 20);
            this.dtpEntryDate.TabIndex = 6;
            // 
            // dtpExitTime
            // 
            this.dtpExitTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpExitTime.Location = new System.Drawing.Point(195, 181);
            this.dtpExitTime.Name = "dtpExitTime";
            this.dtpExitTime.Size = new System.Drawing.Size(80, 20);
            this.dtpExitTime.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Entry Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Exit Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Reason For Selling";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Reason For Buying";
            // 
            // dtpExitDate
            // 
            this.dtpExitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExitDate.Location = new System.Drawing.Point(92, 181);
            this.dtpExitDate.Name = "dtpExitDate";
            this.dtpExitDate.Size = new System.Drawing.Size(97, 20);
            this.dtpExitDate.TabIndex = 14;
            // 
            // dtpEntryTime
            // 
            this.dtpEntryTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntryTime.Location = new System.Drawing.Point(195, 43);
            this.dtpEntryTime.Name = "dtpEntryTime";
            this.dtpEntryTime.Size = new System.Drawing.Size(80, 20);
            this.dtpEntryTime.TabIndex = 15;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(92, 9);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(76, 20);
            this.txtStock.TabIndex = 17;
            this.txtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Stock";
            // 
            // NewJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(347, 363);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpEntryTime);
            this.Controls.Add(this.dtpExitDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpExitTime);
            this.Controls.Add(this.dtpEntryDate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSaveJournal);
            this.Controls.Add(this.txtSellReason);
            this.Controls.Add(this.txtBuyReason);
            this.Name = "NewJournal";
            this.Text = "NewJournal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuyReason;
        private System.Windows.Forms.TextBox txtSellReason;
        private System.Windows.Forms.Button btnSaveJournal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtpEntryDate;
        private System.Windows.Forms.DateTimePicker dtpExitTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpExitDate;
        private System.Windows.Forms.DateTimePicker dtpEntryTime;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label4;
    }
}