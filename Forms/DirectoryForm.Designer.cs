﻿namespace АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Forms
{
    partial class DirectoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ВackgroundGroupBox = new System.Windows.Forms.GroupBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryTabPage = new System.Windows.Forms.TabPage();
            this.CategoryButton = new System.Windows.Forms.Button();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.CategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.SeriesTabPage = new System.Windows.Forms.TabPage();
            this.SeriesDataGridView = new System.Windows.Forms.DataGridView();
            this.SeriesTextBox = new System.Windows.Forms.TextBox();
            this.UsersTabPage = new System.Windows.Forms.TabPage();
            this.UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.UsersButton = new System.Windows.Forms.Button();
            this.UsersTextBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.HideButton = new System.Windows.Forms.Button();
            this.ExpandButton = new System.Windows.Forms.Button();
            this.ToMenuButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ВackgroundGroupBox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.CategoryTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDataGridView)).BeginInit();
            this.SeriesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeriesDataGridView)).BeginInit();
            this.UsersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ВackgroundGroupBox
            // 
            this.ВackgroundGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ВackgroundGroupBox.Controls.Add(this.tabControl);
            this.ВackgroundGroupBox.Location = new System.Drawing.Point(19, 40);
            this.ВackgroundGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.ВackgroundGroupBox.Name = "ВackgroundGroupBox";
            this.ВackgroundGroupBox.Size = new System.Drawing.Size(542, 411);
            this.ВackgroundGroupBox.TabIndex = 0;
            this.ВackgroundGroupBox.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.ContextMenuStrip = this.contextMenuStrip;
            this.tabControl.Controls.Add(this.CategoryTabPage);
            this.tabControl.Controls.Add(this.SeriesTabPage);
            this.tabControl.Controls.Add(this.UsersTabPage);
            this.tabControl.Location = new System.Drawing.Point(3, 14);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(536, 394);
            this.tabControl.TabIndex = 2;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(199, 48);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // CategoryTabPage
            // 
            this.CategoryTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(229)))));
            this.CategoryTabPage.Controls.Add(this.CategoryButton);
            this.CategoryTabPage.Controls.Add(this.CategoryTextBox);
            this.CategoryTabPage.Controls.Add(this.CategoryDataGridView);
            this.CategoryTabPage.Location = new System.Drawing.Point(4, 32);
            this.CategoryTabPage.Name = "CategoryTabPage";
            this.CategoryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CategoryTabPage.Size = new System.Drawing.Size(528, 358);
            this.CategoryTabPage.TabIndex = 0;
            this.CategoryTabPage.Text = "Категории";
            // 
            // CategoryButton
            // 
            this.CategoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryButton.BackColor = System.Drawing.Color.White;
            this.CategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryButton.Location = new System.Drawing.Point(409, 6);
            this.CategoryButton.MinimumSize = new System.Drawing.Size(85, 30);
            this.CategoryButton.Name = "CategoryButton";
            this.CategoryButton.Size = new System.Drawing.Size(116, 31);
            this.CategoryButton.TabIndex = 16;
            this.CategoryButton.Text = "Добавить";
            this.CategoryButton.UseVisualStyleBackColor = false;
            this.CategoryButton.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryTextBox.Location = new System.Drawing.Point(3, 6);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(403, 31);
            this.CategoryTextBox.TabIndex = 2;
            this.CategoryTextBox.TextChanged += new System.EventHandler(this.CategoryTextBox_TextChanged);
            // 
            // CategoryDataGridView
            // 
            this.CategoryDataGridView.AllowUserToAddRows = false;
            this.CategoryDataGridView.AllowUserToDeleteRows = false;
            this.CategoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CategoryDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.CategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryDataGridView.ContextMenuStrip = this.contextMenuStrip;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.CategoryDataGridView.Location = new System.Drawing.Point(3, 43);
            this.CategoryDataGridView.MultiSelect = false;
            this.CategoryDataGridView.Name = "CategoryDataGridView";
            this.CategoryDataGridView.ReadOnly = true;
            this.CategoryDataGridView.RowHeadersVisible = false;
            this.CategoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoryDataGridView.Size = new System.Drawing.Size(522, 312);
            this.CategoryDataGridView.TabIndex = 1;
            // 
            // SeriesTabPage
            // 
            this.SeriesTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(229)))));
            this.SeriesTabPage.Controls.Add(this.SeriesDataGridView);
            this.SeriesTabPage.Controls.Add(this.SeriesTextBox);
            this.SeriesTabPage.Location = new System.Drawing.Point(4, 32);
            this.SeriesTabPage.Name = "SeriesTabPage";
            this.SeriesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SeriesTabPage.Size = new System.Drawing.Size(528, 358);
            this.SeriesTabPage.TabIndex = 1;
            this.SeriesTabPage.Text = "Серии";
            // 
            // SeriesDataGridView
            // 
            this.SeriesDataGridView.AllowUserToAddRows = false;
            this.SeriesDataGridView.AllowUserToDeleteRows = false;
            this.SeriesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeriesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SeriesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SeriesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.SeriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SeriesDataGridView.ContextMenuStrip = this.contextMenuStrip;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SeriesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.SeriesDataGridView.Location = new System.Drawing.Point(3, 43);
            this.SeriesDataGridView.MultiSelect = false;
            this.SeriesDataGridView.Name = "SeriesDataGridView";
            this.SeriesDataGridView.ReadOnly = true;
            this.SeriesDataGridView.RowHeadersVisible = false;
            this.SeriesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SeriesDataGridView.Size = new System.Drawing.Size(522, 312);
            this.SeriesDataGridView.TabIndex = 19;
            // 
            // SeriesTextBox
            // 
            this.SeriesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeriesTextBox.Location = new System.Drawing.Point(3, 6);
            this.SeriesTextBox.Name = "SeriesTextBox";
            this.SeriesTextBox.Size = new System.Drawing.Size(522, 31);
            this.SeriesTextBox.TabIndex = 17;
            this.SeriesTextBox.TextChanged += new System.EventHandler(this.SeriesTextBox_TextChanged);
            // 
            // UsersTabPage
            // 
            this.UsersTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(229)))));
            this.UsersTabPage.Controls.Add(this.UsersDataGridView);
            this.UsersTabPage.Controls.Add(this.UsersButton);
            this.UsersTabPage.Controls.Add(this.UsersTextBox);
            this.UsersTabPage.Location = new System.Drawing.Point(4, 32);
            this.UsersTabPage.Name = "UsersTabPage";
            this.UsersTabPage.Size = new System.Drawing.Size(528, 358);
            this.UsersTabPage.TabIndex = 2;
            this.UsersTabPage.Text = "Пользователи";
            // 
            // UsersDataGridView
            // 
            this.UsersDataGridView.AllowUserToAddRows = false;
            this.UsersDataGridView.AllowUserToDeleteRows = false;
            this.UsersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.UsersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGridView.ContextMenuStrip = this.contextMenuStrip;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.UsersDataGridView.Location = new System.Drawing.Point(3, 43);
            this.UsersDataGridView.MultiSelect = false;
            this.UsersDataGridView.Name = "UsersDataGridView";
            this.UsersDataGridView.ReadOnly = true;
            this.UsersDataGridView.RowHeadersVisible = false;
            this.UsersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersDataGridView.Size = new System.Drawing.Size(522, 312);
            this.UsersDataGridView.TabIndex = 19;
            this.UsersDataGridView.DoubleClick += new System.EventHandler(this.UsersDataGridView_DoubleClick);
            // 
            // UsersButton
            // 
            this.UsersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersButton.BackColor = System.Drawing.Color.White;
            this.UsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersButton.Location = new System.Drawing.Point(409, 6);
            this.UsersButton.MinimumSize = new System.Drawing.Size(85, 30);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(116, 31);
            this.UsersButton.TabIndex = 18;
            this.UsersButton.Text = "Добавить";
            this.UsersButton.UseVisualStyleBackColor = false;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // UsersTextBox
            // 
            this.UsersTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersTextBox.Location = new System.Drawing.Point(3, 6);
            this.UsersTextBox.Name = "UsersTextBox";
            this.UsersTextBox.Size = new System.Drawing.Size(403, 31);
            this.UsersTextBox.TabIndex = 17;
            this.UsersTextBox.TextChanged += new System.EventHandler(this.UsersTextBox_TextChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.IndianRed;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(545, 12);
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
            this.HideButton.Location = new System.Drawing.Point(487, 12);
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
            this.ExpandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExpandButton.Location = new System.Drawing.Point(516, 12);
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
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(229)))));
            this.BackgroundImage = global::АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(580, 470);
            this.Controls.Add(this.ToMenuButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.ExpandButton);
            this.Controls.Add(this.ВackgroundGroupBox);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(560, 350);
            this.Name = "DirectoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поставщики";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DirectoryForm_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DirectoryForm_MouseDown);
            this.ВackgroundGroupBox.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.CategoryTabPage.ResumeLayout(false);
            this.CategoryTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDataGridView)).EndInit();
            this.SeriesTabPage.ResumeLayout(false);
            this.SeriesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeriesDataGridView)).EndInit();
            this.UsersTabPage.ResumeLayout(false);
            this.UsersTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ВackgroundGroupBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Button ExpandButton;
        private System.Windows.Forms.Button ToMenuButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage CategoryTabPage;
        private System.Windows.Forms.TabPage SeriesTabPage;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.DataGridView CategoryDataGridView;
        private System.Windows.Forms.TabPage UsersTabPage;
        private System.Windows.Forms.Button CategoryButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.DataGridView SeriesDataGridView;
        private System.Windows.Forms.TextBox SeriesTextBox;
        private System.Windows.Forms.DataGridView UsersDataGridView;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.TextBox UsersTextBox;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}