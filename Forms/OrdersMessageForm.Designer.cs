namespace АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Forms
{
    partial class OrdersMessageForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.BackgroundGroupBox = new System.Windows.Forms.GroupBox();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SeriesLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BackgroundGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKButton.Location = new System.Drawing.Point(328, 88);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(59, 30);
            this.OKButton.TabIndex = 20;
            this.OKButton.Text = "ОК";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Location = new System.Drawing.Point(6, 88);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(93, 30);
            this.CancelButton.TabIndex = 21;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // BackgroundGroupBox
            // 
            this.BackgroundGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackgroundGroupBox.BackColor = System.Drawing.Color.White;
            this.BackgroundGroupBox.Controls.Add(this.EndDateTimePicker);
            this.BackgroundGroupBox.Controls.Add(this.StartDateTimePicker);
            this.BackgroundGroupBox.Controls.Add(this.SeriesLabel);
            this.BackgroundGroupBox.Controls.Add(this.NumberLabel);
            this.BackgroundGroupBox.Location = new System.Drawing.Point(2, 0);
            this.BackgroundGroupBox.MaximumSize = new System.Drawing.Size(391, 107);
            this.BackgroundGroupBox.MinimumSize = new System.Drawing.Size(391, 67);
            this.BackgroundGroupBox.Name = "BackgroundGroupBox";
            this.BackgroundGroupBox.Size = new System.Drawing.Size(391, 85);
            this.BackgroundGroupBox.TabIndex = 25;
            this.BackgroundGroupBox.TabStop = false;
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDateTimePicker.Location = new System.Drawing.Point(185, 48);
            this.EndDateTimePicker.MaxDate = new System.DateTime(2023, 6, 8, 0, 0, 0, 0);
            this.EndDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(200, 31);
            this.EndDateTimePicker.TabIndex = 31;
            this.EndDateTimePicker.Value = new System.DateTime(2023, 6, 8, 0, 0, 0, 0);
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDateTimePicker.Location = new System.Drawing.Point(185, 9);
            this.StartDateTimePicker.MaxDate = new System.DateTime(2023, 6, 8, 0, 0, 0, 0);
            this.StartDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(200, 31);
            this.StartDateTimePicker.TabIndex = 30;
            this.StartDateTimePicker.Value = new System.DateTime(2023, 6, 8, 0, 0, 0, 0);
            // 
            // SeriesLabel
            // 
            this.SeriesLabel.AutoSize = true;
            this.SeriesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(229)))));
            this.SeriesLabel.Location = new System.Drawing.Point(6, 9);
            this.SeriesLabel.Name = "SeriesLabel";
            this.SeriesLabel.Size = new System.Drawing.Size(91, 23);
            this.SeriesLabel.TabIndex = 29;
            this.SeriesLabel.Text = "Начало:";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(229)))));
            this.NumberLabel.Location = new System.Drawing.Point(6, 48);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(80, 23);
            this.NumberLabel.TabIndex = 27;
            this.NumberLabel.Text = "Конец:";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OrdersMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(394, 128);
            this.ControlBox = false;
            this.Controls.Add(this.BackgroundGroupBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(394, 128);
            this.MinimumSize = new System.Drawing.Size(394, 128);
            this.Name = "OrdersMessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Произвольный период";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrdersMessageForm_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OrdersMessageForm_MouseDown);
            this.BackgroundGroupBox.ResumeLayout(false);
            this.BackgroundGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.GroupBox BackgroundGroupBox;
        private System.Windows.Forms.Label SeriesLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.Timer timer1;
    }
}