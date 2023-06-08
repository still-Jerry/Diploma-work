namespace АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Forms
{
    partial class DiscountForm
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
            this.ВackgroundGroupBox = new System.Windows.Forms.GroupBox();
            this.DayLabel = new System.Windows.Forms.Label();
            this.CangeDayButton = new System.Windows.Forms.Button();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.ChangeDayButton = new System.Windows.Forms.Button();
            this.DiscountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.HideButton = new System.Windows.Forms.Button();
            this.ExpandButton = new System.Windows.Forms.Button();
            this.ToSpeciallyFormButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ВackgroundGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DayNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ВackgroundGroupBox
            // 
            this.ВackgroundGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ВackgroundGroupBox.Controls.Add(this.DayLabel);
            this.ВackgroundGroupBox.Controls.Add(this.CangeDayButton);
            this.ВackgroundGroupBox.Controls.Add(this.DiscountLabel);
            this.ВackgroundGroupBox.Controls.Add(this.ChangeDayButton);
            this.ВackgroundGroupBox.Controls.Add(this.DiscountNumericUpDown);
            this.ВackgroundGroupBox.Controls.Add(this.DayNumericUpDown);
            this.ВackgroundGroupBox.Controls.Add(this.comboBox);
            this.ВackgroundGroupBox.Controls.Add(this.CategoryLabel);
            this.ВackgroundGroupBox.Location = new System.Drawing.Point(19, 40);
            this.ВackgroundGroupBox.Margin = new System.Windows.Forms.Padding(10);
            this.ВackgroundGroupBox.Name = "ВackgroundGroupBox";
            this.ВackgroundGroupBox.Size = new System.Drawing.Size(302, 241);
            this.ВackgroundGroupBox.TabIndex = 0;
            this.ВackgroundGroupBox.TabStop = false;
            // 
            // DayLabel
            // 
            this.DayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DayLabel.AutoSize = true;
            this.DayLabel.BackColor = System.Drawing.Color.White;
            this.DayLabel.Location = new System.Drawing.Point(6, 164);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(58, 23);
            this.DayLabel.TabIndex = 7;
            this.DayLabel.Text = "День";
            // 
            // CangeDayButton
            // 
            this.CangeDayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CangeDayButton.BackColor = System.Drawing.Color.White;
            this.CangeDayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CangeDayButton.Location = new System.Drawing.Point(106, 164);
            this.CangeDayButton.Name = "CangeDayButton";
            this.CangeDayButton.Size = new System.Drawing.Size(183, 61);
            this.CangeDayButton.TabIndex = 6;
            this.CangeDayButton.Text = "Изменить скидочный день";
            this.CangeDayButton.UseVisualStyleBackColor = false;
            this.CangeDayButton.Click += new System.EventHandler(this.CangeDayButton_Click);
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.BackColor = System.Drawing.Color.White;
            this.DiscountLabel.Location = new System.Drawing.Point(6, 90);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(80, 23);
            this.DiscountLabel.TabIndex = 5;
            this.DiscountLabel.Text = "Скидка";
            // 
            // ChangeDayButton
            // 
            this.ChangeDayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeDayButton.BackColor = System.Drawing.Color.White;
            this.ChangeDayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeDayButton.Location = new System.Drawing.Point(106, 81);
            this.ChangeDayButton.Name = "ChangeDayButton";
            this.ChangeDayButton.Size = new System.Drawing.Size(183, 66);
            this.ChangeDayButton.TabIndex = 4;
            this.ChangeDayButton.Text = "Установить для категории";
            this.ChangeDayButton.UseVisualStyleBackColor = false;
            this.ChangeDayButton.Click += new System.EventHandler(this.ChangeDayButton_Click);
            // 
            // DiscountNumericUpDown
            // 
            this.DiscountNumericUpDown.Location = new System.Drawing.Point(6, 116);
            this.DiscountNumericUpDown.Name = "DiscountNumericUpDown";
            this.DiscountNumericUpDown.Size = new System.Drawing.Size(81, 31);
            this.DiscountNumericUpDown.TabIndex = 3;
            // 
            // DayNumericUpDown
            // 
            this.DayNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DayNumericUpDown.Location = new System.Drawing.Point(6, 190);
            this.DayNumericUpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.DayNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DayNumericUpDown.Name = "DayNumericUpDown";
            this.DayNumericUpDown.Size = new System.Drawing.Size(80, 31);
            this.DayNumericUpDown.TabIndex = 2;
            this.DayNumericUpDown.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            // 
            // comboBox
            // 
            this.comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(6, 44);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(283, 31);
            this.comboBox.TabIndex = 1;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.BackColor = System.Drawing.Color.White;
            this.CategoryLabel.Location = new System.Drawing.Point(6, 18);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(183, 23);
            this.CategoryLabel.TabIndex = 0;
            this.CategoryLabel.Text = "Категория товара";
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.IndianRed;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(305, 12);
            this.CloseButton.MaximumSize = new System.Drawing.Size(23, 21);
            this.CloseButton.MinimumSize = new System.Drawing.Size(23, 21);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(23, 21);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // HideButton
            // 
            this.HideButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideButton.BackColor = System.Drawing.Color.Gainsboro;
            this.HideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HideButton.Location = new System.Drawing.Point(247, 12);
            this.HideButton.MaximumSize = new System.Drawing.Size(23, 21);
            this.HideButton.MinimumSize = new System.Drawing.Size(23, 21);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(23, 21);
            this.HideButton.TabIndex = 12;
            this.HideButton.Text = "-";
            this.HideButton.UseVisualStyleBackColor = false;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // ExpandButton
            // 
            this.ExpandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpandButton.BackColor = System.Drawing.Color.Gainsboro;
            this.ExpandButton.Enabled = false;
            this.ExpandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExpandButton.Location = new System.Drawing.Point(276, 12);
            this.ExpandButton.MaximumSize = new System.Drawing.Size(23, 21);
            this.ExpandButton.MinimumSize = new System.Drawing.Size(23, 21);
            this.ExpandButton.Name = "ExpandButton";
            this.ExpandButton.Size = new System.Drawing.Size(23, 21);
            this.ExpandButton.TabIndex = 11;
            this.ExpandButton.Text = "▢";
            this.ExpandButton.UseVisualStyleBackColor = false;
            this.ExpandButton.Click += new System.EventHandler(this.ExpandButton_Click);
            // 
            // ToSpeciallyFormButton
            // 
            this.ToSpeciallyFormButton.BackColor = System.Drawing.Color.Gainsboro;
            this.ToSpeciallyFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToSpeciallyFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToSpeciallyFormButton.Location = new System.Drawing.Point(19, 12);
            this.ToSpeciallyFormButton.MaximumSize = new System.Drawing.Size(33, 21);
            this.ToSpeciallyFormButton.MinimumSize = new System.Drawing.Size(33, 21);
            this.ToSpeciallyFormButton.Name = "ToSpeciallyFormButton";
            this.ToSpeciallyFormButton.Size = new System.Drawing.Size(33, 21);
            this.ToSpeciallyFormButton.TabIndex = 14;
            this.ToSpeciallyFormButton.Text = "<<";
            this.ToSpeciallyFormButton.UseVisualStyleBackColor = false;
            this.ToSpeciallyFormButton.Click += new System.EventHandler(this.ToSpeciallyFormButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(229)))));
            this.BackgroundImage = global::АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(340, 300);
            this.Controls.Add(this.ToSpeciallyFormButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.ExpandButton);
            this.Controls.Add(this.ВackgroundGroupBox);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(340, 300);
            this.Name = "DiscountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа со скидками";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DiscountForm_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DiscountForm_MouseDown);
            this.ВackgroundGroupBox.ResumeLayout(false);
            this.ВackgroundGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DayNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ВackgroundGroupBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Button ExpandButton;
        private System.Windows.Forms.Button ToSpeciallyFormButton;
        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.Button CangeDayButton;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.Button ChangeDayButton;
        private System.Windows.Forms.NumericUpDown DiscountNumericUpDown;
        private System.Windows.Forms.NumericUpDown DayNumericUpDown;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Timer timer1;
    }
}