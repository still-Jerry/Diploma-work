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
    using SQLClass = Modules.SQLClass;
    using PersonalDataClass = Modules.PersonalDataClass;

    public partial class AuthorizationForm : Form
    {
        public static List<String> UserInfoList;
        Int16 countEntarense = 1;
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AuthorizationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void EntarenceButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (countEntarense <= 0) {
                    CaptchaForm CForm = new CaptchaForm();
                    this.Enabled = ViewsClass.EnabledForm;
                    CForm.ShowDialog();
                }
                if (PersonalDataClass.CheckUserEquality(LoginTextBox.Text, PwdTextBox.Text))
                {
                    UserInfoList = SQLClass.GetSelectInList("`user`", " where `loginUser` = '" + LoginTextBox.Text + "' ", "idUser, surnameUser, nameUser, patronymicUser, loginUser, roleUser");

                    MessageBox.Show("Добро пожаловать, " + UserInfoList[1] + " " + UserInfoList[2] + " " + UserInfoList[3] + "!", "Информация");
                    MenuForm NewForm = new MenuForm();
                    this.Visible = false;
                    NewForm.ShowDialog();
                }else{
                    if (countEntarense <= 0) {
                        MessageBox.Show("Система заблокируется на 10 секунд", "Информация");
                        Thread.Sleep(10000);
                        this.Enabled = true;
                        
                    }
                    //MessageBox.Show("Несовпадение логина", "Ошибка");
                    countEntarense--;
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
    }
}
