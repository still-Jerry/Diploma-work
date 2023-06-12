using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Forms
{
    using ViewsClass = Modules.ViewsClass;
    using BusinessClass = Modules.BusinessClass;

    using SQLClass = Modules.SQLClass;
    using PersonalDataClass = Modules.PersonalDataClass;

    public partial class AuthorizationForm : Form
    {
        Int16 countEntarense = 1;
        public AuthorizationForm()
        {
            InitializeComponent();
        }
        #region Typical events of all forms
        /// <summary>window display buttons </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void AuthorizationForm_MouseDown(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.SizeAll;
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
            this.Cursor = Cursors.Default;

        }
        private void AuthorizationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

   

        private void EntarenceButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginTextBox.Text.Replace(" ", "").Replace(" ", "") == "" || PwdTextBox.Text.Replace(" ", "").Replace(" ", "") == "")
                {
                    MessageBox.Show("Заполните пустые поля", "Ошибка");
                }
                else
                {
                    if (countEntarense <= 0)
                    {
                        CaptchaForm CForm = new CaptchaForm();
                        this.Enabled = ViewsClass.EnabledForm;
                        CForm.ShowDialog();
                    }
                    if (PersonalDataClass.CheckUserEquality(LoginTextBox.Text, PwdTextBox.Text))
                    {
                        BusinessClass.UserInfoList = SQLClass.GetSelectInList("`user`", " where `loginUser` = '" + LoginTextBox.Text + "' ", "idUser, surnameUser, nameUser, patronymicUser, loginUser, roleUser");

                        MessageBox.Show("Добро пожаловать, " + BusinessClass.UserInfoList[1] + " " + BusinessClass.UserInfoList[2] + " " + BusinessClass.UserInfoList[3] + "!", "Информация");
                        MenuForm NewForm = new MenuForm();
                        this.Visible = false;
                        NewForm.ShowDialog();
                    }
                    else
                    {
                        if (countEntarense <= 0)
                        {
                            MessageBox.Show("Система заблокируется на 10 секунд", "Информация");
                            Thread.Sleep(10000);
                            this.Enabled = true;

                        }
                        //MessageBox.Show("Несовпадение логина", "Ошибка");
                        countEntarense--;
                    }
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
      
        private void PwdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PwdCheckBox.Checked)
            {
                PwdTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PwdTextBox.UseSystemPasswordChar = true;
            }
        }

 

     
    }
}
