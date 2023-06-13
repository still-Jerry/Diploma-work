namespace АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Forms
{
    partial class DelayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DelayForm));
            this.ВackgroundGroupBox = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SpecComboBox = new System.Windows.Forms.ComboBox();
            this.AlphabetСomboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.CloseButton = new System.Windows.Forms.Button();
            this.HideButton = new System.Windows.Forms.Button();
            this.ExpandButton = new System.Windows.Forms.Button();
            this.ToMenuButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ВackgroundGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ВackgroundGroupBox
            // 
            this.ВackgroundGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ВackgroundGroupBox.Controls.Add(this.dateTimePicker);
            this.ВackgroundGroupBox.Controls.Add(this.SpecComboBox);
            this.ВackgroundGroupBox.Controls.Add(this.AlphabetСomboBox);
            this.ВackgroundGroupBox.Controls.Add(this.dataGridView);
            this.ВackgroundGroupBox.Location = new System.Drawing.Point(19, 40);
            this.ВackgroundGroupBox.Margin = new System.Windows.Forms.Padding(10);
            this.ВackgroundGroupBox.Name = "ВackgroundGroupBox";
            this.ВackgroundGroupBox.Size = new System.Drawing.Size(530, 403);
            this.ВackgroundGroupBox.TabIndex = 0;
            this.ВackgroundGroupBox.TabStop = false;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(6, 18);
            this.dateTimePicker.MaxDate = new System.DateTime(2023, 5, 11, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker.TabIndex = 11;
            this.dateTimePicker.Value = new System.DateTime(2023, 5, 11, 0, 0, 0, 0);
            // 
            // SpecComboBox
            // 
            this.SpecComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpecComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpecComboBox.FormattingEnabled = true;
            this.SpecComboBox.Location = new System.Drawing.Point(379, 18);
            this.SpecComboBox.Name = "SpecComboBox";
            this.SpecComboBox.Size = new System.Drawing.Size(145, 31);
            this.SpecComboBox.TabIndex = 10;
            // 
            // AlphabetСomboBox
            // 
            this.AlphabetСomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AlphabetСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlphabetСomboBox.FormattingEnabled = true;
            this.AlphabetСomboBox.Items.AddRange(new object[] {
            "ы"});
            this.AlphabetСomboBox.Location = new System.Drawing.Point(228, 18);
            this.AlphabetСomboBox.Name = "AlphabetСomboBox";
            this.AlphabetСomboBox.Size = new System.Drawing.Size(145, 31);
            this.AlphabetСomboBox.TabIndex = 9;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Location = new System.Drawing.Point(6, 55);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(518, 342);
            this.dataGridView.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.IndianRed;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(533, 12);
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
            this.HideButton.Location = new System.Drawing.Point(475, 12);
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
            this.ExpandButton.Location = new System.Drawing.Point(504, 12);
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
            // DelayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(251)))), ((int)(((byte)(229)))));
            this.BackgroundImage = global::АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(568, 462);
            this.Controls.Add(this.ToMenuButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.ExpandButton);
            this.Controls.Add(this.ВackgroundGroupBox);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(1024, 720);
            this.Name = "DelayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прострочка";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DelayForm_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DelayForm_MouseDown);
            this.ВackgroundGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Timer timer1;
    }
}