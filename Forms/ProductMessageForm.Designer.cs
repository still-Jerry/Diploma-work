namespace АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Forms
{
    partial class ProductMessageForm
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.SeriesLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BackgroundGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKButton.Location = new System.Drawing.Point(323, 110);
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
            this.CancelButton.Location = new System.Drawing.Point(2, 110);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(93, 30);
            this.CancelButton.TabIndex = 21;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // BackgroundGroupBox
            // 
            this.BackgroundGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackgroundGroupBox.Controls.Add(this.comboBox);
            this.BackgroundGroupBox.Controls.Add(this.SeriesLabel);
            this.BackgroundGroupBox.Controls.Add(this.NumberLabel);
            this.BackgroundGroupBox.Controls.Add(this.numericUpDown);
            this.BackgroundGroupBox.Location = new System.Drawing.Point(2, 0);
            this.BackgroundGroupBox.MaximumSize = new System.Drawing.Size(391, 107);
            this.BackgroundGroupBox.MinimumSize = new System.Drawing.Size(391, 67);
            this.BackgroundGroupBox.Name = "BackgroundGroupBox";
            this.BackgroundGroupBox.Size = new System.Drawing.Size(391, 107);
            this.BackgroundGroupBox.TabIndex = 25;
            this.BackgroundGroupBox.TabStop = false;
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(6, 35);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(379, 31);
            this.comboBox.TabIndex = 30;
            // 
            // SeriesLabel
            // 
            this.SeriesLabel.AutoSize = true;
            this.SeriesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(229)))));
            this.SeriesLabel.Location = new System.Drawing.Point(6, 9);
            this.SeriesLabel.Name = "SeriesLabel";
            this.SeriesLabel.Size = new System.Drawing.Size(175, 23);
            this.SeriesLabel.TabIndex = 29;
            this.SeriesLabel.Text = "Серия продукта:";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(229)))));
            this.NumberLabel.Location = new System.Drawing.Point(6, 78);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(216, 23);
            this.NumberLabel.TabIndex = 27;
            this.NumberLabel.Text = "Рецепторный номер:";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(246, 73);
            this.numericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(139, 31);
            this.numericUpDown.TabIndex = 25;
            this.numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProductMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(394, 150);
            this.ControlBox = false;
            this.Controls.Add(this.BackgroundGroupBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(394, 150);
            this.MinimumSize = new System.Drawing.Size(394, 110);
            this.Name = "ProductMessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Указание серии продукта";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductMessageForm_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProductMessageForm_MouseDown);
            this.BackgroundGroupBox.ResumeLayout(false);
            this.BackgroundGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.GroupBox BackgroundGroupBox;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label SeriesLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Timer timer1;

    }
}