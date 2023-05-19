namespace АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Forms
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.ВackgroundGroupBox = new System.Windows.Forms.GroupBox();
            this.EntarenceButton = new System.Windows.Forms.Button();
            this.PwdCheckBox = new System.Windows.Forms.CheckBox();
            this.PwdTextBox = new System.Windows.Forms.TextBox();
            this.PwdLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.HideButton = new System.Windows.Forms.Button();
            this.ExpandButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ВackgroundGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ВackgroundGroupBox
            // 
            this.ВackgroundGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ВackgroundGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(229)))));
            this.ВackgroundGroupBox.Controls.Add(this.button1);
            this.ВackgroundGroupBox.Controls.Add(this.EntarenceButton);
            this.ВackgroundGroupBox.Controls.Add(this.PwdCheckBox);
            this.ВackgroundGroupBox.Controls.Add(this.PwdTextBox);
            this.ВackgroundGroupBox.Controls.Add(this.PwdLabel);
            this.ВackgroundGroupBox.Controls.Add(this.LoginTextBox);
            this.ВackgroundGroupBox.Controls.Add(this.LoginLabel);
            this.ВackgroundGroupBox.Location = new System.Drawing.Point(19, 34);
            this.ВackgroundGroupBox.Margin = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.ВackgroundGroupBox.MaximumSize = new System.Drawing.Size(390, 199);
            this.ВackgroundGroupBox.Name = "ВackgroundGroupBox";
            this.ВackgroundGroupBox.Size = new System.Drawing.Size(390, 199);
            this.ВackgroundGroupBox.TabIndex = 6;
            this.ВackgroundGroupBox.TabStop = false;
            // 
            // EntarenceButton
            // 
            this.EntarenceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EntarenceButton.BackColor = System.Drawing.Color.White;
            this.EntarenceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EntarenceButton.Location = new System.Drawing.Point(299, 163);
            this.EntarenceButton.MinimumSize = new System.Drawing.Size(85, 30);
            this.EntarenceButton.Name = "EntarenceButton";
            this.EntarenceButton.Size = new System.Drawing.Size(85, 30);
            this.EntarenceButton.TabIndex = 11;
            this.EntarenceButton.Text = "Войти";
            this.EntarenceButton.UseVisualStyleBackColor = false;
            this.EntarenceButton.Click += new System.EventHandler(this.EntarenceButton_Click);
            // 
            // PwdCheckBox
            // 
            this.PwdCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PwdCheckBox.AutoSize = true;
            this.PwdCheckBox.BackColor = System.Drawing.Color.White;
            this.PwdCheckBox.Location = new System.Drawing.Point(6, 163);
            this.PwdCheckBox.Name = "PwdCheckBox";
            this.PwdCheckBox.Size = new System.Drawing.Size(195, 27);
            this.PwdCheckBox.TabIndex = 10;
            this.PwdCheckBox.Text = "Показать пароль";
            this.PwdCheckBox.UseVisualStyleBackColor = false;
            this.PwdCheckBox.CheckedChanged += new System.EventHandler(this.PwdCheckBox_CheckedChanged);
            // 
            // PwdTextBox
            // 
            this.PwdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PwdTextBox.Location = new System.Drawing.Point(7, 116);
            this.PwdTextBox.MaxLength = 70;
            this.PwdTextBox.Name = "PwdTextBox";
            this.PwdTextBox.Size = new System.Drawing.Size(377, 31);
            this.PwdTextBox.TabIndex = 9;
            this.PwdTextBox.Text = "qwerqwer";
            this.PwdTextBox.UseSystemPasswordChar = true;
            // 
            // PwdLabel
            // 
            this.PwdLabel.AutoSize = true;
            this.PwdLabel.BackColor = System.Drawing.Color.White;
            this.PwdLabel.Location = new System.Drawing.Point(7, 84);
            this.PwdLabel.Name = "PwdLabel";
            this.PwdLabel.Size = new System.Drawing.Size(91, 23);
            this.PwdLabel.TabIndex = 8;
            this.PwdLabel.Text = "Пароль:";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginTextBox.Location = new System.Drawing.Point(7, 40);
            this.LoginTextBox.MaxLength = 70;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(377, 31);
            this.LoginTextBox.TabIndex = 7;
            this.LoginTextBox.Text = "some_login@mail.com";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.Color.White;
            this.LoginLabel.Location = new System.Drawing.Point(7, 5);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(78, 23);
            this.LoginLabel.TabIndex = 6;
            this.LoginLabel.Text = "Логин:";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.IndianRed;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(393, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(23, 20);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // HideButton
            // 
            this.HideButton.BackColor = System.Drawing.Color.Gainsboro;
            this.HideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HideButton.Location = new System.Drawing.Point(334, 11);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(24, 21);
            this.HideButton.TabIndex = 9;
            this.HideButton.Text = "-";
            this.HideButton.UseVisualStyleBackColor = false;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // ExpandButton
            // 
            this.ExpandButton.BackColor = System.Drawing.Color.Gainsboro;
            this.ExpandButton.Cursor = System.Windows.Forms.Cursors.No;
            this.ExpandButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExpandButton.Enabled = false;
            this.ExpandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExpandButton.Location = new System.Drawing.Point(364, 11);
            this.ExpandButton.Name = "ExpandButton";
            this.ExpandButton.Size = new System.Drawing.Size(23, 21);
            this.ExpandButton.TabIndex = 8;
            this.ExpandButton.Text = "▢";
            this.ExpandButton.UseVisualStyleBackColor = false;
            this.ExpandButton.Click += new System.EventHandler(this.ExpandButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(245, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Н";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(229)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.ExpandButton;
            this.ClientSize = new System.Drawing.Size(428, 252);
            this.ControlBox = false;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.ExpandButton);
            this.Controls.Add(this.ВackgroundGroupBox);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация пользователя";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuthorizationForm_FormClosed);
            this.ВackgroundGroupBox.ResumeLayout(false);
            this.ВackgroundGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ВackgroundGroupBox;
        private System.Windows.Forms.Button EntarenceButton;
        private System.Windows.Forms.CheckBox PwdCheckBox;
        private System.Windows.Forms.TextBox PwdTextBox;
        private System.Windows.Forms.Label PwdLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Button ExpandButton;
        private System.Windows.Forms.Button button1;

    }
}