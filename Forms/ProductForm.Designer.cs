namespace АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Forms
{
    partial class ProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ВackgroundGroupBox = new System.Windows.Forms.GroupBox();
            this.AddNewProductButton = new System.Windows.Forms.Button();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PagesLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ToListButton = new System.Windows.Forms.Button();
            this.SpecComboBox = new System.Windows.Forms.ComboBox();
            this.AlphabetСomboBox = new System.Windows.Forms.ComboBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImgColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьКЗаказуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseButton = new System.Windows.Forms.Button();
            this.HideButton = new System.Windows.Forms.Button();
            this.ExpandButton = new System.Windows.Forms.Button();
            this.ToMenuButton = new System.Windows.Forms.Button();
            this.ВackgroundGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ВackgroundGroupBox
            // 
            this.ВackgroundGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ВackgroundGroupBox.Controls.Add(this.AddNewProductButton);
            this.ВackgroundGroupBox.Controls.Add(this.numericUpDown);
            this.ВackgroundGroupBox.Controls.Add(this.PagesLabel);
            this.ВackgroundGroupBox.Controls.Add(this.NextButton);
            this.ВackgroundGroupBox.Controls.Add(this.BackButton);
            this.ВackgroundGroupBox.Controls.Add(this.ToListButton);
            this.ВackgroundGroupBox.Controls.Add(this.SpecComboBox);
            this.ВackgroundGroupBox.Controls.Add(this.AlphabetСomboBox);
            this.ВackgroundGroupBox.Controls.Add(this.SearchTextBox);
            this.ВackgroundGroupBox.Controls.Add(this.dataGridView);
            this.ВackgroundGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ВackgroundGroupBox.Location = new System.Drawing.Point(19, 40);
            this.ВackgroundGroupBox.Margin = new System.Windows.Forms.Padding(10);
            this.ВackgroundGroupBox.Name = "ВackgroundGroupBox";
            this.ВackgroundGroupBox.Size = new System.Drawing.Size(542, 411);
            this.ВackgroundGroupBox.TabIndex = 0;
            this.ВackgroundGroupBox.TabStop = false;
            // 
            // AddNewProductButton
            // 
            this.AddNewProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewProductButton.BackColor = System.Drawing.Color.White;
            this.AddNewProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewProductButton.Location = new System.Drawing.Point(149, 377);
            this.AddNewProductButton.MinimumSize = new System.Drawing.Size(252, 30);
            this.AddNewProductButton.Name = "AddNewProductButton";
            this.AddNewProductButton.Size = new System.Drawing.Size(253, 30);
            this.AddNewProductButton.TabIndex = 21;
            this.AddNewProductButton.Text = "Добавить новый товар";
            this.AddNewProductButton.UseVisualStyleBackColor = false;
            this.AddNewProductButton.Click += new System.EventHandler(this.AddNewProductButton_Click);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown.Location = new System.Drawing.Point(451, 378);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(58, 27);
            this.numericUpDown.TabIndex = 20;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // PagesLabel
            // 
            this.PagesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PagesLabel.AutoSize = true;
            this.PagesLabel.BackColor = System.Drawing.Color.White;
            this.PagesLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PagesLabel.Location = new System.Drawing.Point(39, 381);
            this.PagesLabel.Name = "PagesLabel";
            this.PagesLabel.Size = new System.Drawing.Size(65, 18);
            this.PagesLabel.TabIndex = 18;
            this.PagesLabel.Text = "30/104";
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.Location = new System.Drawing.Point(513, 378);
            this.NextButton.MinimumSize = new System.Drawing.Size(23, 21);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(23, 27);
            this.NextButton.TabIndex = 17;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(10, 378);
            this.BackButton.MinimumSize = new System.Drawing.Size(23, 21);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(23, 27);
            this.BackButton.TabIndex = 16;
            this.BackButton.Text = "<";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ToListButton
            // 
            this.ToListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToListButton.BackColor = System.Drawing.Color.White;
            this.ToListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToListButton.Location = new System.Drawing.Point(451, 22);
            this.ToListButton.MinimumSize = new System.Drawing.Size(85, 30);
            this.ToListButton.Name = "ToListButton";
            this.ToListButton.Size = new System.Drawing.Size(85, 31);
            this.ToListButton.TabIndex = 15;
            this.ToListButton.Text = "Заказ";
            this.ToListButton.UseVisualStyleBackColor = false;
            this.ToListButton.Click += new System.EventHandler(this.ToListButton_Click);
            // 
            // SpecComboBox
            // 
            this.SpecComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpecComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpecComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SpecComboBox.FormattingEnabled = true;
            this.SpecComboBox.Location = new System.Drawing.Point(274, 59);
            this.SpecComboBox.Name = "SpecComboBox";
            this.SpecComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SpecComboBox.Size = new System.Drawing.Size(262, 31);
            this.SpecComboBox.TabIndex = 10;
            this.SpecComboBox.SelectedIndexChanged += new System.EventHandler(this.SpecComboBox_SelectedIndexChanged);
            // 
            // AlphabetСomboBox
            // 
            this.AlphabetСomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlphabetСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlphabetСomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AlphabetСomboBox.FormattingEnabled = true;
            this.AlphabetСomboBox.Location = new System.Drawing.Point(6, 59);
            this.AlphabetСomboBox.MaximumSize = new System.Drawing.Size(262, 0);
            this.AlphabetСomboBox.Name = "AlphabetСomboBox";
            this.AlphabetСomboBox.Size = new System.Drawing.Size(262, 31);
            this.AlphabetСomboBox.TabIndex = 9;
            this.AlphabetСomboBox.SelectedIndexChanged += new System.EventHandler(this.SpecComboBox_SelectedIndexChanged);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Location = new System.Drawing.Point(6, 22);
            this.SearchTextBox.MaxLength = 70;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(439, 31);
            this.SearchTextBox.TabIndex = 8;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ColumnHeadersVisible = false;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.ImgColumn,
            this.Column});
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.Location = new System.Drawing.Point(6, 96);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(530, 276);
            this.dataGridView.TabIndex = 0;
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "IDColumn";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Visible = false;
            // 
            // ImgColumn
            // 
            this.ImgColumn.HeaderText = "ImgColumn";
            this.ImgColumn.Image = global::АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Properties.Resources.plug;
            this.ImgColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ImgColumn.Name = "ImgColumn";
            this.ImgColumn.ReadOnly = true;
            this.ImgColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column.HeaderText = "Column";
            this.Column.Name = "Column";
            this.Column.ReadOnly = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКЗаказуToolStripMenuItem,
            this.просмотрТовараToolStripMenuItem,
            this.редактированиеТовараToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(276, 70);
            // 
            // добавитьКЗаказуToolStripMenuItem
            // 
            this.добавитьКЗаказуToolStripMenuItem.Name = "добавитьКЗаказуToolStripMenuItem";
            this.добавитьКЗаказуToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.добавитьКЗаказуToolStripMenuItem.Text = "Добавить к заказу";
            this.добавитьКЗаказуToolStripMenuItem.Click += new System.EventHandler(this.добавитьКЗаказуToolStripMenuItem_Click);
            // 
            // просмотрТовараToolStripMenuItem
            // 
            this.просмотрТовараToolStripMenuItem.Name = "просмотрТовараToolStripMenuItem";
            this.просмотрТовараToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.просмотрТовараToolStripMenuItem.Text = "Просмотр товара";
            this.просмотрТовараToolStripMenuItem.Click += new System.EventHandler(this.просмотрТовараToolStripMenuItem_Click);
            // 
            // редактированиеТовараToolStripMenuItem
            // 
            this.редактированиеТовараToolStripMenuItem.Name = "редактированиеТовараToolStripMenuItem";
            this.редактированиеТовараToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.редактированиеТовараToolStripMenuItem.Text = "Редактирование товара";
            this.редактированиеТовараToolStripMenuItem.Click += new System.EventHandler(this.редактированиеТовараToolStripMenuItem_Click);
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
            // ProductForm
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
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лекарственные препараты";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.ВackgroundGroupBox.ResumeLayout(false);
            this.ВackgroundGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ВackgroundGroupBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Button ExpandButton;
        private System.Windows.Forms.Button ToMenuButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox SpecComboBox;
        private System.Windows.Forms.ComboBox AlphabetСomboBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label PagesLabel;
        private System.Windows.Forms.Button ToListButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewImageColumn ImgColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
        private System.Windows.Forms.Button AddNewProductButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьКЗаказуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрТовараToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеТовараToolStripMenuItem;
    }
}