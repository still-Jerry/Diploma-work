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


    public partial class DirectoryFormMessageForm : Form
    {
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
        private void DirectoryFormMessageForm_MouseDown(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.SizeAll;
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
            this.Cursor = Cursors.Default;
        }

        private void DirectoryFormMessageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public DirectoryFormMessageForm()
        {
            InitializeComponent();
            if (!ViewsClass.DirectoryFormAdd) {
                textBox.Text = BusinessClass.SelectedFromDataGridList[1];
            }
            timer1.Start();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox.Text.Replace(" ", "").Replace(" ", "") == "")
                {
                    MessageBox.Show("Заполните пустое поле!", "Ошибка");

                }
                else
                {
                    if (!ViewsClass.DirectoryFormAdd)
                    {
                        if (SQLClass.UpdateToDataBase(" category ", " nameСategory = '" + textBox.Text + "' ", " where idСategory = " + BusinessClass.SelectedFromDataGridList[0]))
                        {
                            MessageBox.Show("Успешное изменение категории!", "Информация");
                        }
                        else
                        {
                            MessageBox.Show("Произошла ошибка, категория не изменена!", "Информация");

                        }
                    }
                    else
                    {
                        if (SQLClass.AddToDataBase(" category ", "null, '" + textBox.Text + "'"))
                        {
                            MessageBox.Show("Успешное добавление категории!", "Информация");
                            textBox.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Произошла ошибка, категория не добавлена!", "Информация");

                        }
                    }
                }
            }
            catch { 
            
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ViewsClass.DirectoryFormAdd = true;

            ViewsClass.EnabledForm = true;
            this.Visible = false;
            ViewsClass.EnabledForm = true;
        }


    }
}
