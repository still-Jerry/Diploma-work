namespace АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Forms
{
    partial class CreateUserForm
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.HideButton = new System.Windows.Forms.Button();
            this.ExpandButton = new System.Windows.Forms.Button();
            this.ToMenuButton = new System.Windows.Forms.Button();
            this.ВackgroundGroupBox = new System.Windows.Forms.GroupBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PwdLabel1 = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.PwdTextBox1 = new System.Windows.Forms.TextBox();
            this.PwdLabel2 = new System.Windows.Forms.Label();
            this.PwdCheckBox = new System.Windows.Forms.CheckBox();
            this.PwdTextBox2 = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.OTextBox = new System.Windows.Forms.TextBox();
            this.OLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.NTextBox = new System.Windows.Forms.TextBox();
            this.NLabel = new System.Windows.Forms.Label();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.FTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.АLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ВackgroundGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.IndianRed;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(475, 12);
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
            this.HideButton.Location = new System.Drawing.Point(417, 12);
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
            this.ExpandButton.Location = new System.Drawing.Point(446, 12);
            this.ExpandButton.MaximumSize = new System.Drawing.Size(23, 21);
            this.ExpandButton.MinimumSize = new System.Drawing.Size(23, 21);
            this.ExpandButton.Name = "ExpandButton";
            this.ExpandButton.Size = new System.Drawing.Size(23, 21);
            this.ExpandButton.TabIndex = 11;
            this.ExpandButton.Text = "▢";
            this.ExpandButton.UseVisualStyleBackColor = false;
            this.ExpandButton.Click += new System.EventHandler(this.ExpandButton_Click);
            // 
            // ToMenuButton
            // 
            this.ToMenuButton.BackColor = System.Drawing.Color.Gainsboro;
            this.ToMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToMenuButton.Location = new System.Drawing.Point(19, 12);
            this.ToMenuButton.MaximumSize = new System.Drawing.Size(33, 21);
            this.ToMenuButton.MinimumSize = new System.Drawing.Size(33, 21);
            this.ToMenuButton.Name = "ToMenuButton";
            this.ToMenuButton.Size = new System.Drawing.Size(33, 21);
            this.ToMenuButton.TabIndex = 14;
            this.ToMenuButton.Text = "<<";
            this.ToMenuButton.UseVisualStyleBackColor = false;
            this.ToMenuButton.Click += new System.EventHandler(this.ToMenuButton_Click);
            // 
            // ВackgroundGroupBox
            // 
            this.ВackgroundGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ВackgroundGroupBox.Controls.Add(this.LoginTextBox);
            this.ВackgroundGroupBox.Controls.Add(this.LoginLabel);
            this.ВackgroundGroupBox.Controls.Add(this.PwdLabel1);
            this.ВackgroundGroupBox.Controls.Add(this.GenerateButton);
            this.ВackgroundGroupBox.Controls.Add(this.PwdTextBox1);
            this.ВackgroundGroupBox.Controls.Add(this.PwdLabel2);
            this.ВackgroundGroupBox.Controls.Add(this.PwdCheckBox);
            this.ВackgroundGroupBox.Controls.Add(this.PwdTextBox2);
            this.ВackgroundGroupBox.Controls.Add(this.AddButton);
            this.ВackgroundGroupBox.Controls.Add(this.OTextBox);
            this.ВackgroundGroupBox.Controls.Add(this.OLabel);
            this.ВackgroundGroupBox.Controls.Add(this.EditButton);
            this.ВackgroundGroupBox.Controls.Add(this.NTextBox);
            this.ВackgroundGroupBox.Controls.Add(this.NLabel);
            this.ВackgroundGroupBox.Controls.Add(this.ComboBox);
            this.ВackgroundGroupBox.Controls.Add(this.FTextBox);
            this.ВackgroundGroupBox.Controls.Add(this.CategoryLabel);
            this.ВackgroundGroupBox.Controls.Add(this.АLabel);
            this.ВackgroundGroupBox.Location = new System.Drawing.Point(19, 40);
            this.ВackgroundGroupBox.Margin = new System.Windows.Forms.Padding(10);
            this.ВackgroundGroupBox.Name = "ВackgroundGroupBox";
            this.ВackgroundGroupBox.Size = new System.Drawing.Size(472, 356);
            this.ВackgroundGroupBox.TabIndex = 0;
            this.ВackgroundGroupBox.TabStop = false;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LoginTextBox.Location = new System.Drawing.Point(243, 180);
            this.LoginTextBox.MaxLength = 70;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(219, 31);
            this.LoginTextBox.TabIndex = 133;
            // 
            // LoginLabel
            // 
            this.LoginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.Color.White;
            this.LoginLabel.Location = new System.Drawing.Point(243, 154);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(69, 23);
            this.LoginLabel.TabIndex = 132;
            this.LoginLabel.Text = "Логин";
            // 
            // PwdLabel1
            // 
            this.PwdLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PwdLabel1.AutoSize = true;
            this.PwdLabel1.BackColor = System.Drawing.Color.White;
            this.PwdLabel1.Location = new System.Drawing.Point(10, 154);
            this.PwdLabel1.Name = "PwdLabel1";
            this.PwdLabel1.Size = new System.Drawing.Size(82, 23);
            this.PwdLabel1.TabIndex = 126;
            this.PwdLabel1.Text = "Пароль";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateButton.BackColor = System.Drawing.Color.White;
            this.GenerateButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.GenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GenerateButton.Location = new System.Drawing.Point(243, 226);
            this.GenerateButton.MinimumSize = new System.Drawing.Size(208, 31);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(215, 55);
            this.GenerateButton.TabIndex = 131;
            this.GenerateButton.Text = "Сгенерировать пароль";
            this.GenerateButton.UseVisualStyleBackColor = false;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // PwdTextBox1
            // 
            this.PwdTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PwdTextBox1.Location = new System.Drawing.Point(10, 180);
            this.PwdTextBox1.MaxLength = 70;
            this.PwdTextBox1.Name = "PwdTextBox1";
            this.PwdTextBox1.Size = new System.Drawing.Size(215, 31);
            this.PwdTextBox1.TabIndex = 127;
            this.PwdTextBox1.UseSystemPasswordChar = true;
            // 
            // PwdLabel2
            // 
            this.PwdLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PwdLabel2.AutoSize = true;
            this.PwdLabel2.BackColor = System.Drawing.Color.White;
            this.PwdLabel2.Location = new System.Drawing.Point(10, 226);
            this.PwdLabel2.Name = "PwdLabel2";
            this.PwdLabel2.Size = new System.Drawing.Size(203, 23);
            this.PwdLabel2.TabIndex = 128;
            this.PwdLabel2.Text = "Повторение пароля";
            // 
            // PwdCheckBox
            // 
            this.PwdCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PwdCheckBox.AutoSize = true;
            this.PwdCheckBox.BackColor = System.Drawing.Color.White;
            this.PwdCheckBox.Location = new System.Drawing.Point(10, 309);
            this.PwdCheckBox.Name = "PwdCheckBox";
            this.PwdCheckBox.Size = new System.Drawing.Size(195, 27);
            this.PwdCheckBox.TabIndex = 130;
            this.PwdCheckBox.Text = "Показать пароль";
            this.PwdCheckBox.UseVisualStyleBackColor = false;
            this.PwdCheckBox.CheckedChanged += new System.EventHandler(this.PwdCheckBox_CheckedChanged);
            // 
            // PwdTextBox2
            // 
            this.PwdTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PwdTextBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PwdTextBox2.Location = new System.Drawing.Point(10, 252);
            this.PwdTextBox2.MaxLength = 70;
            this.PwdTextBox2.Name = "PwdTextBox2";
            this.PwdTextBox2.Size = new System.Drawing.Size(215, 31);
            this.PwdTextBox2.TabIndex = 129;
            this.PwdTextBox2.UseSystemPasswordChar = true;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(243, 309);
            this.AddButton.MinimumSize = new System.Drawing.Size(208, 31);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(215, 34);
            this.AddButton.TabIndex = 125;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // OTextBox
            // 
            this.OTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OTextBox.Location = new System.Drawing.Point(243, 45);
            this.OTextBox.MaxLength = 70;
            this.OTextBox.Name = "OTextBox";
            this.OTextBox.Size = new System.Drawing.Size(215, 31);
            this.OTextBox.TabIndex = 124;
            this.OTextBox.TextChanged += new System.EventHandler(this.OTextBox_TextChanged);
            this.OTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FTextBox_KeyPress);
            // 
            // OLabel
            // 
            this.OLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OLabel.AutoSize = true;
            this.OLabel.BackColor = System.Drawing.Color.White;
            this.OLabel.Location = new System.Drawing.Point(243, 19);
            this.OLabel.Name = "OLabel";
            this.OLabel.Size = new System.Drawing.Size(99, 23);
            this.OLabel.TabIndex = 123;
            this.OLabel.Text = "Отчество";
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.EditButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Location = new System.Drawing.Point(243, 309);
            this.EditButton.MinimumSize = new System.Drawing.Size(208, 31);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(215, 34);
            this.EditButton.TabIndex = 122;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // NTextBox
            // 
            this.NTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NTextBox.Location = new System.Drawing.Point(10, 105);
            this.NTextBox.MaxLength = 70;
            this.NTextBox.Name = "NTextBox";
            this.NTextBox.Size = new System.Drawing.Size(215, 31);
            this.NTextBox.TabIndex = 121;
            this.NTextBox.TextChanged += new System.EventHandler(this.NTextBox_TextChanged);
            this.NTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FTextBox_KeyPress);
            // 
            // NLabel
            // 
            this.NLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NLabel.AutoSize = true;
            this.NLabel.BackColor = System.Drawing.Color.White;
            this.NLabel.Location = new System.Drawing.Point(10, 79);
            this.NLabel.Name = "NLabel";
            this.NLabel.Size = new System.Drawing.Size(48, 23);
            this.NLabel.TabIndex = 120;
            this.NLabel.Text = "Имя";
            // 
            // ComboBox
            // 
            this.ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(243, 105);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(215, 31);
            this.ComboBox.TabIndex = 119;
            // 
            // FTextBox
            // 
            this.FTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FTextBox.Location = new System.Drawing.Point(10, 45);
            this.FTextBox.MaxLength = 70;
            this.FTextBox.Name = "FTextBox";
            this.FTextBox.Size = new System.Drawing.Size(215, 31);
            this.FTextBox.TabIndex = 118;
            this.FTextBox.TextChanged += new System.EventHandler(this.FTextBox_TextChanged);
            this.FTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FTextBox_KeyPress);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.BackColor = System.Drawing.Color.White;
            this.CategoryLabel.Location = new System.Drawing.Point(243, 79);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(56, 23);
            this.CategoryLabel.TabIndex = 117;
            this.CategoryLabel.Text = "Роль";
            // 
            // АLabel
            // 
            this.АLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.АLabel.AutoSize = true;
            this.АLabel.BackColor = System.Drawing.Color.White;
            this.АLabel.Location = new System.Drawing.Point(10, 19);
            this.АLabel.Name = "АLabel";
            this.АLabel.Size = new System.Drawing.Size(97, 23);
            this.АLabel.TabIndex = 116;
            this.АLabel.Text = "Фамилия";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(229)))));
            this.BackgroundImage = global::АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(510, 415);
            this.Controls.Add(this.ToMenuButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.ExpandButton);
            this.Controls.Add(this.ВackgroundGroupBox);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(510, 415);
            this.Name = "CreateUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateUserForm_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CreateUserForm_MouseDown);
            this.ВackgroundGroupBox.ResumeLayout(false);
            this.ВackgroundGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Button ExpandButton;
        private System.Windows.Forms.Button ToMenuButton;
        private System.Windows.Forms.GroupBox ВackgroundGroupBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PwdLabel1;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TextBox PwdTextBox1;
        private System.Windows.Forms.Label PwdLabel2;
        private System.Windows.Forms.CheckBox PwdCheckBox;
        private System.Windows.Forms.TextBox PwdTextBox2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox OTextBox;
        private System.Windows.Forms.Label OLabel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox NTextBox;
        private System.Windows.Forms.Label NLabel;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.TextBox FTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label АLabel;
        private System.Windows.Forms.Timer timer1;
    }
}