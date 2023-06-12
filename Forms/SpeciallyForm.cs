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
    using ViewsClass = Modules.ViewsClass;
    using SQLClass = Modules.SQLClass;

    public partial class SpeciallyForm : Form
    {
    
        #region Typical events of all forms
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExpandButton_Click(object sender, EventArgs e)
        {
            if (ViewsClass.StateWindows)
            {
                this.WindowState = FormWindowState.Maximized;
                ViewsClass.StateWindows = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                ViewsClass.StateWindows = true;
            }
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void SpeciallyForm_MouseDown(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.SizeAll;
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
            this.Cursor = Cursors.Default;
        }

        private void SpeciallyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ToMenuButton_Click(object sender, EventArgs e)
        {
            MenuForm NewForm = new MenuForm();
            this.Visible = false;
            NewForm.ShowDialog();
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
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

        #endregion

        public SpeciallyForm()
        {
            InitializeComponent();
        }
        private void ToDiscountFormButton_Click(object sender, EventArgs e)
        {
            DiscountForm NewForm = new DiscountForm();
            this.Visible = false;
            NewForm.ShowDialog();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            ViewsClass.SpeciallyFormImport = true;
            ViewsClass.EnabledForm = false;
            SpeciallyMessageForm NewForm = new SpeciallyMessageForm();
            this.Enabled = ViewsClass.EnabledForm;
            NewForm.ShowDialog();
            this.Enabled = true;
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ViewsClass.SpeciallyFormImport = false;
            ViewsClass.EnabledForm = false;
            SpeciallyMessageForm NewForm = new SpeciallyMessageForm();
            this.Enabled = ViewsClass.EnabledForm;
            NewForm.ShowDialog();
            this.Enabled = true;
        }

        private void BackupButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = folderBrowserDialog.SelectedPath + "\\backup_" + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "_руч.sql";

                if (SQLClass.BacupExport(filepath))
                {
                    MessageBox.Show("Успешное создание бэкапа", "Информация");

                }
                else
                {
                    MessageBox.Show("Бэкап не создан", "Ошибка");

                }
            }
        }


    }
}
