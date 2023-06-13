namespace АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Forms
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.ВackgroundGroupBox = new System.Windows.Forms.GroupBox();
            this.ToSpeciallyButton = new System.Windows.Forms.Button();
            this.ToDirectoryButton = new System.Windows.Forms.Button();
            this.ToOrdersButton = new System.Windows.Forms.Button();
            this.ToProductButton = new System.Windows.Forms.Button();
            this.ToAuthorizationButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.HideButton = new System.Windows.Forms.Button();
            this.ExpandButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ВackgroundGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ВackgroundGroupBox
            // 
            this.ВackgroundGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ВackgroundGroupBox.Controls.Add(this.ToSpeciallyButton);
            this.ВackgroundGroupBox.Controls.Add(this.ToDirectoryButton);
            this.ВackgroundGroupBox.Controls.Add(this.ToOrdersButton);
            this.ВackgroundGroupBox.Controls.Add(this.ToProductButton);
            this.ВackgroundGroupBox.Controls.Add(this.ToAuthorizationButton);
            this.ВackgroundGroupBox.Location = new System.Drawing.Point(19, 40);
            this.ВackgroundGroupBox.Margin = new System.Windows.Forms.Padding(10);
            this.ВackgroundGroupBox.Name = "ВackgroundGroupBox";
            this.ВackgroundGroupBox.Size = new System.Drawing.Size(219, 241);
            this.ВackgroundGroupBox.TabIndex = 0;
            this.ВackgroundGroupBox.TabStop = false;
            // 
            // ToSpeciallyButton
            // 
            this.ToSpeciallyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToSpeciallyButton.BackColor = System.Drawing.Color.White;
            this.ToSpeciallyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToSpeciallyButton.Location = new System.Drawing.Point(6, 202);
            this.ToSpeciallyButton.MinimumSize = new System.Drawing.Size(85, 30);
            this.ToSpeciallyButton.Name = "ToSpeciallyButton";
            this.ToSpeciallyButton.Size = new System.Drawing.Size(208, 33);
            this.ToSpeciallyButton.TabIndex = 17;
            this.ToSpeciallyButton.Text = "Спец.возможности";
            this.ToSpeciallyButton.UseVisualStyleBackColor = false;
            this.ToSpeciallyButton.Click += new System.EventHandler(this.ToSpeciallyButton_Click);
            // 
            // ToDirectoryButton
            // 
            this.ToDirectoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToDirectoryButton.BackColor = System.Drawing.Color.White;
            this.ToDirectoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToDirectoryButton.Location = new System.Drawing.Point(6, 163);
            this.ToDirectoryButton.MinimumSize = new System.Drawing.Size(85, 30);
            this.ToDirectoryButton.Name = "ToDirectoryButton";
            this.ToDirectoryButton.Size = new System.Drawing.Size(208, 33);
            this.ToDirectoryButton.TabIndex = 15;
            this.ToDirectoryButton.Text = "Справочники";
            this.ToDirectoryButton.UseVisualStyleBackColor = false;
            this.ToDirectoryButton.Click += new System.EventHandler(this.ToSuppliersButton_Click);
            // 
            // ToOrdersButton
            // 
            this.ToOrdersButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToOrdersButton.BackColor = System.Drawing.Color.White;
            this.ToOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToOrdersButton.Location = new System.Drawing.Point(6, 107);
            this.ToOrdersButton.MinimumSize = new System.Drawing.Size(85, 30);
            this.ToOrdersButton.Name = "ToOrdersButton";
            this.ToOrdersButton.Size = new System.Drawing.Size(208, 33);
            this.ToOrdersButton.TabIndex = 14;
            this.ToOrdersButton.Text = "Ведение учёта";
            this.ToOrdersButton.UseVisualStyleBackColor = false;
            this.ToOrdersButton.Click += new System.EventHandler(this.ToOrdersButton_Click);
            // 
            // ToProductButton
            // 
            this.ToProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToProductButton.BackColor = System.Drawing.Color.White;
            this.ToProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToProductButton.Location = new System.Drawing.Point(6, 68);
            this.ToProductButton.MinimumSize = new System.Drawing.Size(85, 30);
            this.ToProductButton.Name = "ToProductButton";
            this.ToProductButton.Size = new System.Drawing.Size(208, 33);
            this.ToProductButton.TabIndex = 13;
            this.ToProductButton.Text = "Просмотр товаров";
            this.ToProductButton.UseVisualStyleBackColor = false;
            this.ToProductButton.Click += new System.EventHandler(this.ToProductButton_Click);
            // 
            // ToAuthorizationButton
            // 
            this.ToAuthorizationButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToAuthorizationButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.ToAuthorizationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToAuthorizationButton.Location = new System.Drawing.Point(6, 18);
            this.ToAuthorizationButton.MinimumSize = new System.Drawing.Size(85, 30);
            this.ToAuthorizationButton.Name = "ToAuthorizationButton";
            this.ToAuthorizationButton.Size = new System.Drawing.Size(208, 33);
            this.ToAuthorizationButton.TabIndex = 12;
            this.ToAuthorizationButton.Text = "Выйти из системы";
            this.ToAuthorizationButton.UseVisualStyleBackColor = false;
            this.ToAuthorizationButton.Click += new System.EventHandler(this.ToAuthorizationButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.IndianRed;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(222, 12);
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
            this.HideButton.Location = new System.Drawing.Point(164, 12);
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
            this.ExpandButton.Location = new System.Drawing.Point(193, 12);
            this.ExpandButton.MaximumSize = new System.Drawing.Size(23, 21);
            this.ExpandButton.MinimumSize = new System.Drawing.Size(23, 21);
            this.ExpandButton.Name = "ExpandButton";
            this.ExpandButton.Size = new System.Drawing.Size(23, 21);
            this.ExpandButton.TabIndex = 11;
            this.ExpandButton.Text = "▢";
            this.ExpandButton.UseVisualStyleBackColor = false;
            this.ExpandButton.Click += new System.EventHandler(this.ExpandButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(229)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(257, 300);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.ExpandButton);
            this.Controls.Add(this.ВackgroundGroupBox);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(257, 300);
            this.MinimumSize = new System.Drawing.Size(257, 205);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuForm_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuForm_MouseDown);
            this.ВackgroundGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ВackgroundGroupBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Button ExpandButton;
        private System.Windows.Forms.Button ToAuthorizationButton;
        private System.Windows.Forms.Button ToSpeciallyButton;
        private System.Windows.Forms.Button ToDirectoryButton;
        private System.Windows.Forms.Button ToOrdersButton;
        private System.Windows.Forms.Button ToProductButton;
        private System.Windows.Forms.Timer timer1;
    }
}