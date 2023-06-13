namespace АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Forms
{
    partial class OrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            this.ВackgroundGroupBox = new System.Windows.Forms.GroupBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.OrdersTabPage = new System.Windows.Forms.TabPage();
            this.OrdersTotalSumLabel = new System.Windows.Forms.Label();
            this.OrdersFilterLabel = new System.Windows.Forms.Label();
            this.OrdersSearchLabel = new System.Windows.Forms.Label();
            this.OrdersReportButton = new System.Windows.Forms.Button();
            this.OrdersSearchTextBox = new System.Windows.Forms.TextBox();
            this.OrdersFilterComboBox = new System.Windows.Forms.ComboBox();
            this.OrdersSearchСomboBox = new System.Windows.Forms.ComboBox();
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.просмотрСоставаЗаказаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelayTabPage = new System.Windows.Forms.TabPage();
            this.DelayTotalSumLabel = new System.Windows.Forms.Label();
            this.DelayFilterLabel = new System.Windows.Forms.Label();
            this.DelaySearchLabel = new System.Windows.Forms.Label();
            this.DelayReportButton = new System.Windows.Forms.Button();
            this.DelaySearchTextBox = new System.Windows.Forms.TextBox();
            this.DelayFilterComboBox = new System.Windows.Forms.ComboBox();
            this.DelaySearchСomboBox = new System.Windows.Forms.ComboBox();
            this.DelayDataGridView = new System.Windows.Forms.DataGridView();
            this.CloseButton = new System.Windows.Forms.Button();
            this.HideButton = new System.Windows.Forms.Button();
            this.ExpandButton = new System.Windows.Forms.Button();
            this.ToMenuButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ВackgroundGroupBox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.OrdersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.DelayTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelayDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ВackgroundGroupBox
            // 
            this.ВackgroundGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ВackgroundGroupBox.Controls.Add(this.tabControl);
            this.ВackgroundGroupBox.Location = new System.Drawing.Point(19, 40);
            this.ВackgroundGroupBox.Margin = new System.Windows.Forms.Padding(10);
            this.ВackgroundGroupBox.Name = "ВackgroundGroupBox";
            this.ВackgroundGroupBox.Size = new System.Drawing.Size(542, 421);
            this.ВackgroundGroupBox.TabIndex = 0;
            this.ВackgroundGroupBox.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.OrdersTabPage);
            this.tabControl.Controls.Add(this.DelayTabPage);
            this.tabControl.Location = new System.Drawing.Point(3, 14);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(536, 404);
            this.tabControl.TabIndex = 25;
            // 
            // OrdersTabPage
            // 
            this.OrdersTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(229)))));
            this.OrdersTabPage.Controls.Add(this.OrdersTotalSumLabel);
            this.OrdersTabPage.Controls.Add(this.OrdersFilterLabel);
            this.OrdersTabPage.Controls.Add(this.OrdersSearchLabel);
            this.OrdersTabPage.Controls.Add(this.OrdersReportButton);
            this.OrdersTabPage.Controls.Add(this.OrdersSearchTextBox);
            this.OrdersTabPage.Controls.Add(this.OrdersFilterComboBox);
            this.OrdersTabPage.Controls.Add(this.OrdersSearchСomboBox);
            this.OrdersTabPage.Controls.Add(this.OrdersDataGridView);
            this.OrdersTabPage.Location = new System.Drawing.Point(4, 32);
            this.OrdersTabPage.Name = "OrdersTabPage";
            this.OrdersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersTabPage.Size = new System.Drawing.Size(528, 368);
            this.OrdersTabPage.TabIndex = 0;
            this.OrdersTabPage.Text = "Заказы";
            // 
            // OrdersTotalSumLabel
            // 
            this.OrdersTotalSumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OrdersTotalSumLabel.AutoSize = true;
            this.OrdersTotalSumLabel.BackColor = System.Drawing.Color.White;
            this.OrdersTotalSumLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersTotalSumLabel.Location = new System.Drawing.Point(6, 335);
            this.OrdersTotalSumLabel.Name = "OrdersTotalSumLabel";
            this.OrdersTotalSumLabel.Size = new System.Drawing.Size(164, 25);
            this.OrdersTotalSumLabel.TabIndex = 32;
            this.OrdersTotalSumLabel.Text = "ИТОГО: 123p.";
            // 
            // OrdersFilterLabel
            // 
            this.OrdersFilterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersFilterLabel.AutoSize = true;
            this.OrdersFilterLabel.BackColor = System.Drawing.Color.White;
            this.OrdersFilterLabel.Location = new System.Drawing.Point(433, 40);
            this.OrdersFilterLabel.Name = "OrdersFilterLabel";
            this.OrdersFilterLabel.Size = new System.Drawing.Size(92, 23);
            this.OrdersFilterLabel.TabIndex = 31;
            this.OrdersFilterLabel.Text = "Период:";
            // 
            // OrdersSearchLabel
            // 
            this.OrdersSearchLabel.AutoSize = true;
            this.OrdersSearchLabel.BackColor = System.Drawing.Color.White;
            this.OrdersSearchLabel.Location = new System.Drawing.Point(3, 40);
            this.OrdersSearchLabel.Name = "OrdersSearchLabel";
            this.OrdersSearchLabel.Size = new System.Drawing.Size(109, 23);
            this.OrdersSearchLabel.TabIndex = 30;
            this.OrdersSearchLabel.Text = "Поиск по:";
            // 
            // OrdersReportButton
            // 
            this.OrdersReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersReportButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.OrdersReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersReportButton.Location = new System.Drawing.Point(360, 332);
            this.OrdersReportButton.MinimumSize = new System.Drawing.Size(85, 30);
            this.OrdersReportButton.Name = "OrdersReportButton";
            this.OrdersReportButton.Size = new System.Drawing.Size(164, 33);
            this.OrdersReportButton.TabIndex = 29;
            this.OrdersReportButton.Text = "Сформировать";
            this.OrdersReportButton.UseVisualStyleBackColor = false;
            this.OrdersReportButton.Click += new System.EventHandler(this.OrdersReportButton_Click);
            // 
            // OrdersSearchTextBox
            // 
            this.OrdersSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersSearchTextBox.Location = new System.Drawing.Point(3, 6);
            this.OrdersSearchTextBox.MaxLength = 70;
            this.OrdersSearchTextBox.Name = "OrdersSearchTextBox";
            this.OrdersSearchTextBox.Size = new System.Drawing.Size(522, 31);
            this.OrdersSearchTextBox.TabIndex = 28;
            this.OrdersSearchTextBox.TextChanged += new System.EventHandler(this.OrdersSearchTextBox_TextChanged);
            this.OrdersSearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DelaySearchTextBox_KeyPress);
            // 
            // OrdersFilterComboBox
            // 
            this.OrdersFilterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrdersFilterComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersFilterComboBox.FormattingEnabled = true;
            this.OrdersFilterComboBox.Location = new System.Drawing.Point(271, 66);
            this.OrdersFilterComboBox.Name = "OrdersFilterComboBox";
            this.OrdersFilterComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OrdersFilterComboBox.Size = new System.Drawing.Size(253, 31);
            this.OrdersFilterComboBox.TabIndex = 27;
            this.OrdersFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.OrdersFilterComboBox_SelectedIndexChanged);
            // 
            // OrdersSearchСomboBox
            // 
            this.OrdersSearchСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrdersSearchСomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersSearchСomboBox.FormattingEnabled = true;
            this.OrdersSearchСomboBox.Location = new System.Drawing.Point(3, 66);
            this.OrdersSearchСomboBox.Name = "OrdersSearchСomboBox";
            this.OrdersSearchСomboBox.Size = new System.Drawing.Size(253, 31);
            this.OrdersSearchСomboBox.TabIndex = 26;
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.AllowUserToAddRows = false;
            this.OrdersDataGridView.AllowUserToDeleteRows = false;
            this.OrdersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.OrdersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.ContextMenuStrip = this.contextMenuStrip;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.OrdersDataGridView.Location = new System.Drawing.Point(3, 100);
            this.OrdersDataGridView.MultiSelect = false;
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.ReadOnly = true;
            this.OrdersDataGridView.RowHeadersVisible = false;
            this.OrdersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersDataGridView.Size = new System.Drawing.Size(522, 229);
            this.OrdersDataGridView.TabIndex = 25;
            this.OrdersDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersDataGridView_CellDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрСоставаЗаказаToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(290, 26);
            // 
            // просмотрСоставаЗаказаToolStripMenuItem
            // 
            this.просмотрСоставаЗаказаToolStripMenuItem.Name = "просмотрСоставаЗаказаToolStripMenuItem";
            this.просмотрСоставаЗаказаToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.просмотрСоставаЗаказаToolStripMenuItem.Text = "Просмотр состава заказа";
            this.просмотрСоставаЗаказаToolStripMenuItem.Click += new System.EventHandler(this.просмотрСоставаЗаказаToolStripMenuItem_Click);
            // 
            // DelayTabPage
            // 
            this.DelayTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(229)))));
            this.DelayTabPage.Controls.Add(this.DelayTotalSumLabel);
            this.DelayTabPage.Controls.Add(this.DelayFilterLabel);
            this.DelayTabPage.Controls.Add(this.DelaySearchLabel);
            this.DelayTabPage.Controls.Add(this.DelayReportButton);
            this.DelayTabPage.Controls.Add(this.DelaySearchTextBox);
            this.DelayTabPage.Controls.Add(this.DelayFilterComboBox);
            this.DelayTabPage.Controls.Add(this.DelaySearchСomboBox);
            this.DelayTabPage.Controls.Add(this.DelayDataGridView);
            this.DelayTabPage.Location = new System.Drawing.Point(4, 32);
            this.DelayTabPage.Name = "DelayTabPage";
            this.DelayTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DelayTabPage.Size = new System.Drawing.Size(528, 368);
            this.DelayTabPage.TabIndex = 1;
            this.DelayTabPage.Text = "Просрочка";
            // 
            // DelayTotalSumLabel
            // 
            this.DelayTotalSumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DelayTotalSumLabel.AutoSize = true;
            this.DelayTotalSumLabel.BackColor = System.Drawing.Color.White;
            this.DelayTotalSumLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelayTotalSumLabel.Location = new System.Drawing.Point(6, 335);
            this.DelayTotalSumLabel.Name = "DelayTotalSumLabel";
            this.DelayTotalSumLabel.Size = new System.Drawing.Size(164, 25);
            this.DelayTotalSumLabel.TabIndex = 40;
            this.DelayTotalSumLabel.Text = "ИТОГО: 123p.";
            // 
            // DelayFilterLabel
            // 
            this.DelayFilterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelayFilterLabel.AutoSize = true;
            this.DelayFilterLabel.BackColor = System.Drawing.Color.White;
            this.DelayFilterLabel.Location = new System.Drawing.Point(433, 40);
            this.DelayFilterLabel.Name = "DelayFilterLabel";
            this.DelayFilterLabel.Size = new System.Drawing.Size(92, 23);
            this.DelayFilterLabel.TabIndex = 39;
            this.DelayFilterLabel.Text = "Период:";
            // 
            // DelaySearchLabel
            // 
            this.DelaySearchLabel.AutoSize = true;
            this.DelaySearchLabel.BackColor = System.Drawing.Color.White;
            this.DelaySearchLabel.Location = new System.Drawing.Point(3, 40);
            this.DelaySearchLabel.Name = "DelaySearchLabel";
            this.DelaySearchLabel.Size = new System.Drawing.Size(109, 23);
            this.DelaySearchLabel.TabIndex = 38;
            this.DelaySearchLabel.Text = "Поиск по:";
            // 
            // DelayReportButton
            // 
            this.DelayReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DelayReportButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.DelayReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelayReportButton.Location = new System.Drawing.Point(360, 332);
            this.DelayReportButton.MinimumSize = new System.Drawing.Size(85, 30);
            this.DelayReportButton.Name = "DelayReportButton";
            this.DelayReportButton.Size = new System.Drawing.Size(164, 33);
            this.DelayReportButton.TabIndex = 37;
            this.DelayReportButton.Text = "Сформировать";
            this.DelayReportButton.UseVisualStyleBackColor = false;
            this.DelayReportButton.Click += new System.EventHandler(this.DelayReportButton_Click);
            // 
            // DelaySearchTextBox
            // 
            this.DelaySearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DelaySearchTextBox.Location = new System.Drawing.Point(3, 6);
            this.DelaySearchTextBox.MaxLength = 70;
            this.DelaySearchTextBox.Name = "DelaySearchTextBox";
            this.DelaySearchTextBox.Size = new System.Drawing.Size(522, 31);
            this.DelaySearchTextBox.TabIndex = 36;
            this.DelaySearchTextBox.TextChanged += new System.EventHandler(this.DelaySearchTextBox_TextChanged);
            this.DelaySearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DelaySearchTextBox_KeyPress);
            // 
            // DelayFilterComboBox
            // 
            this.DelayFilterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelayFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DelayFilterComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelayFilterComboBox.FormattingEnabled = true;
            this.DelayFilterComboBox.Location = new System.Drawing.Point(271, 66);
            this.DelayFilterComboBox.Name = "DelayFilterComboBox";
            this.DelayFilterComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DelayFilterComboBox.Size = new System.Drawing.Size(253, 31);
            this.DelayFilterComboBox.TabIndex = 35;
            this.DelayFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.DelayFilterComboBox_SelectedIndexChanged);
            // 
            // DelaySearchСomboBox
            // 
            this.DelaySearchСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DelaySearchСomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelaySearchСomboBox.FormattingEnabled = true;
            this.DelaySearchСomboBox.Location = new System.Drawing.Point(3, 66);
            this.DelaySearchСomboBox.Name = "DelaySearchСomboBox";
            this.DelaySearchСomboBox.Size = new System.Drawing.Size(253, 31);
            this.DelaySearchСomboBox.TabIndex = 34;
            // 
            // DelayDataGridView
            // 
            this.DelayDataGridView.AllowUserToAddRows = false;
            this.DelayDataGridView.AllowUserToDeleteRows = false;
            this.DelayDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DelayDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DelayDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DelayDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.DelayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DelayDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.DelayDataGridView.Location = new System.Drawing.Point(3, 100);
            this.DelayDataGridView.MultiSelect = false;
            this.DelayDataGridView.Name = "DelayDataGridView";
            this.DelayDataGridView.ReadOnly = true;
            this.DelayDataGridView.RowHeadersVisible = false;
            this.DelayDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DelayDataGridView.Size = new System.Drawing.Size(522, 229);
            this.DelayDataGridView.TabIndex = 33;
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
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(229)))));
            this.BackgroundImage = global::АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(580, 480);
            this.Controls.Add(this.ToMenuButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.ExpandButton);
            this.Controls.Add(this.ВackgroundGroupBox);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(560, 350);
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrdersForm_FormClosed);
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OrdersForm_MouseDown);
            this.ВackgroundGroupBox.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.OrdersTabPage.ResumeLayout(false);
            this.OrdersTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.DelayTabPage.ResumeLayout(false);
            this.DelayTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelayDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ВackgroundGroupBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Button ExpandButton;
        private System.Windows.Forms.Button ToMenuButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem просмотрСоставаЗаказаToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage OrdersTabPage;
        private System.Windows.Forms.TabPage DelayTabPage;
        private System.Windows.Forms.Label OrdersTotalSumLabel;
        private System.Windows.Forms.Label OrdersFilterLabel;
        private System.Windows.Forms.Label OrdersSearchLabel;
        private System.Windows.Forms.Button OrdersReportButton;
        private System.Windows.Forms.TextBox OrdersSearchTextBox;
        private System.Windows.Forms.ComboBox OrdersFilterComboBox;
        private System.Windows.Forms.ComboBox OrdersSearchСomboBox;
        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.Label DelayTotalSumLabel;
        private System.Windows.Forms.Label DelayFilterLabel;
        private System.Windows.Forms.Label DelaySearchLabel;
        private System.Windows.Forms.Button DelayReportButton;
        private System.Windows.Forms.TextBox DelaySearchTextBox;
        private System.Windows.Forms.ComboBox DelayFilterComboBox;
        private System.Windows.Forms.ComboBox DelaySearchСomboBox;
        private System.Windows.Forms.DataGridView DelayDataGridView;
    }
}