using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Forms
{
    using ViewsClass = Modules.ViewsClass;
    using SQLClass = Modules.SQLClass;
    using BusinessClass = Modules.BusinessClass;

    public partial class CreateUserForm : Form
    {
        #region Typical events of all forms
        /// <summary>window display buttons </summary>
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
        /// <summary>
        /// <CreateParams>Shape stretching</CreateParams>
        /// </summary>

        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_THICKFRAME = 0x40000;

                var cp = base.CreateParams;
                cp.Style |= WS_THICKFRAME;

                return cp;
            }
        }

        #endregion
        public CreateUserForm()
        {
            InitializeComponent();
            List<String> role = SQLClass.GetSelectInList("`role`", attributes: " `nameRole` ");
            for (Int16 i = 0; i < role.Count(); i++)
            {
                ComboBox.Items.Add(role[i]);
            }
            ComboBox.SelectedItem = "Фармацевт";

            if (!ViewsClass.DirectoryFormAdd)
            {
                AddButton.Visible = false;
                EditButton.Visible = true;


                FTextBox.Text = BusinessClass.SelectedFromDataGridList[1];
                NTextBox.Text = BusinessClass.SelectedFromDataGridList[2];
                OTextBox.Text = BusinessClass.SelectedFromDataGridList[3];
                LoginTextBox.Text = BusinessClass.SelectedFromDataGridList[4];
                ComboBox.SelectedItem = BusinessClass.SelectedFromDataGridList[9];

            }
            else {
                AddButton.Visible = true;
                EditButton.Visible = false;
            }
            if (BusinessClass.SelectedFromDataGridList[0] == BusinessClass.UserInfoList[0]) {
                ComboBox.Enabled = false;
            }
        }

        private void ToMenuButton_Click(object sender, EventArgs e)
        {
            ViewsClass.DirectoryFormAdd = true;

            DirectoryForm NewForm = new DirectoryForm();
            this.Visible = false;
            NewForm.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FTextBox.Text.Replace(" ", "").Replace(" ", "") == "" ||
                   NTextBox.Text.Replace(" ", "").Replace(" ", "") == "" ||
                    LoginTextBox.Text.Replace(" ", "").Replace(" ", "") == "" ||
                    PwdTextBox1.Text.Replace(" ", "").Replace(" ", "") == "" ||
                    PwdTextBox2.Text.Replace(" ", "").Replace(" ", "") == "")
                {
                    MessageBox.Show("Необходимо заполнить поля: Имя, Фамилия, Логин, Пароль, Повторение пароля", "Информация");

                }
                else if (PwdTextBox1.Text != PwdTextBox2.Text)
                {
                    MessageBox.Show("Несовпадение паролей", "Ошибка");
                }
                else
                {
                    var role = SQLClass.GetSelectInList(" role ", " where nameRole = '" + ComboBox.Text + "'")[0];
                    Random rnd = new Random();
                    var salt = BusinessClass.GetRandomTextString(rnd.Next(5, 12));
                    var pwd = Modules.PersonalDataClass.Hashing(PwdTextBox1.Text, salt);

                    if (SQLClass.AddToDataBase(" `user`", "null, '" +
                        FTextBox.Text + "', '" + NTextBox.Text + "', '" + OTextBox.Text + "', '" +
                        LoginTextBox.Text + "', '" + pwd + "', '" + role + "', '" + salt+"'"))
                    {
                        MessageBox.Show("Успешное добавление пользователя!", "Информация");
                        FTextBox.Text = "";
                        NTextBox.Text = "";
                        OTextBox.Text = "";
                        LoginTextBox.Text = "";
                        PwdTextBox1.Text = "";
                        PwdTextBox2.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка. Пользователь не добавлен.", "Ошибка");

                    }
                }
            }
            catch { 
            
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try{
                if (FTextBox.Text.Replace(" ", "").Replace(" ", "") == "" ||
                    NTextBox.Text.Replace(" ", "").Replace(" ", "") == "" ||
                    LoginTextBox.Text.Replace(" ", "").Replace(" ", "") == "")
                {
                    MessageBox.Show("Необходимо заполнить поля: Имя, Фамилия, Логин", "Информация");

                }
                else if (PwdTextBox1.Text != PwdTextBox2.Text)
                {
                    MessageBox.Show("Несовпадение паролей", "Ошибка");
                }
                else
                {
                    var role = SQLClass.GetSelectInList(" role ", " where nameRole = '" + ComboBox.Text + "'")[0];
                    Boolean update;
                    if (PwdTextBox1.Text.Replace(" ", "").Replace(" ", "") == "") { 
                    update=SQLClass.UpdateToDataBase(" `user` ",
                        "surnameUser = '" + FTextBox.Text+ "', "+
                        "nameUser = '" + NTextBox.Text + "', "+
                        "patronymicUser = '" + OTextBox.Text + "', "+
                        "loginUser = '" + LoginTextBox.Text + "', "+
                        "roleUser = " + role , 
                        " where idUser = " +BusinessClass.SelectedFromDataGridList[0]);
                    }else{
                       Random rnd = new Random();
                        var salt = BusinessClass.GetRandomTextString(rnd.Next(5, 12));
                        var pwd = Modules.PersonalDataClass.Hashing(PwdTextBox1.Text, salt);
                     update=SQLClass.UpdateToDataBase(" `user` ",
                        "surnameUser = '" + FTextBox.Text+ "', "+
                        "nameUser = '" + NTextBox.Text + "', "+
                        "patronymicUser = '" + OTextBox.Text + "', "+
                        "loginUser = '" + LoginTextBox.Text + "', "+
                        "passwordUser = '" +pwd +"', "+
                        "saltUser = '" + salt+"', "+
                        "roleUser = " + role , 
                        " where idUser = " +BusinessClass.SelectedFromDataGridList[0]);
                    }
                    if (update)
                    {
                        MessageBox.Show("Успешное редактирование пользователя!", "Информация");
                        ViewsClass.DirectoryFormAdd = true;

                        DirectoryForm NewForm = new DirectoryForm();
                        this.Visible = false;
                        NewForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка. Пользователь не изменён.", "Ошибка");

                    }
                } 
            }
            catch { 
            
            }
        }

        private void PwdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PwdCheckBox.Checked)
            {
                PwdTextBox1.UseSystemPasswordChar = false;
                PwdTextBox2.UseSystemPasswordChar = false;

            }
            else
            {
                PwdTextBox1.UseSystemPasswordChar = true;
                PwdTextBox2.UseSystemPasswordChar = true;

            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            PwdCheckBox.Checked = true;
            PwdTextBox1.Text = BusinessClass.GetRandomTextString(pwd: true);
            PwdTextBox2.Text = PwdTextBox1.Text;
        }

        private void FTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (!((l >= 'А' && l <= 'я')|| l == 'ё' || l == 'Ё'|| l == '\b' || l == '-')) {
                e.Handled = true;
            }
        }

        private void FTextBox_TextChanged(object sender, EventArgs e)
        {
            FTextBox.Text = ViewsClass.ToUpperString(FTextBox.Text);
            FTextBox.SelectionStart = FTextBox.Text.Length;
            FTextBox.Focus();
        }

        private void NTextBox_TextChanged(object sender, EventArgs e)
        {
            NTextBox.Text = ViewsClass.ToUpperString(NTextBox.Text);
            NTextBox.SelectionStart = NTextBox.Text.Length;
            NTextBox.Focus();
        }

        private void OTextBox_TextChanged(object sender, EventArgs e)
        {
            OTextBox.Text = ViewsClass.ToUpperString(OTextBox.Text);
            OTextBox.SelectionStart = OTextBox.Text.Length;
            OTextBox.Focus();
        }



    }
}
