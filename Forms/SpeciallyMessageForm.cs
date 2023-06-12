using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Forms
{
    using SQLClass = Modules.SQLClass;
    using ViewsClass = Modules.ViewsClass;
    using BusinessClass = Modules.BusinessClass;

    public partial class SpeciallyMessageForm : Form
    {
        #region Typical events of all forms
        /// <summary> Inactivity Tracking </summary>

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (GetIdleTime() >= 60000 && this.Visible)
            {
                AuthorizationForm NewForm = new AuthorizationForm();
                this.Visible = false;
                NewForm.ShowDialog();
            }
        }
        [DllImport("User32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        internal struct LASTINPUTINFO
        {
            public uint cbSize;

            public uint dwTime;
        }

        public static uint GetIdleTime()
        {
            LASTINPUTINFO LastUserAction = new LASTINPUTINFO();
            LastUserAction.cbSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(LastUserAction);
            GetLastInputInfo(ref LastUserAction);
            return ((uint)Environment.TickCount - LastUserAction.dwTime);
        }


        private void SpeciallyMessageForm_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.SizeAll;
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
            this.Cursor = Cursors.Default;
        }

        private void SpeciallyMessageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        public SpeciallyMessageForm()
        {
            InitializeComponent();
            List<String> tables = SQLClass.RequestInListRows("Show tables;");
            for (Int16 i = 0; i < tables.Count(); i++)
            {
                comboBox.Items.Add(tables[i]);
            }
            comboBox.SelectedIndex = 0;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ViewsClass.SpeciallyFormImport = true;
            ViewsClass.EnabledForm = true;
            this.Visible = false;
            ViewsClass.EnabledForm = true;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (ViewsClass.SpeciallyFormImport)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (BusinessClass.ImportTable(comboBox.Text, openFileDialog.FileName))
                    {
                        MessageBox.Show("Импорт произошёл успешно!", "Информация");
                    }
                    else
                    {
                        MessageBox.Show("Ошибка импортирования.", "Ошибка");
                    }
                }
            }
            else {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    if (BusinessClass.ExportTable(SQLClass.GetSelectInDataTable("`"+comboBox.Text+"`"), comboBox.Text, folderBrowserDialog.SelectedPath+"\\"))
                    {
                        MessageBox.Show("Экспорт произошёл успешно!", "Информация");
                    }
                    else
                    {
                        MessageBox.Show("Ошибка экспортирования.", "Ошибка");
                    }
                }
              
            }
        }


    }
}
