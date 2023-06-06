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


            }
            else {
                AddButton.Visible = true;
                EditButton.Visible = false;
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
            if (FTextBox.Text.Replace(" ", "").Replace(" ", "") == "" ||
               NTextBox.Text.Replace(" ", "").Replace(" ", "") == "" ||
                LoginTextBox.Text.Replace(" ", "").Replace(" ", "") == "")
            {
                MessageBox.Show("Необходимо заполнить поля: Имя, Фамилия, Логин", "Информация");

            }
            else if (PwdTextBox1.Text != PwdTextBox2.Text) {
                MessageBox.Show("Несовпадение паролей", "Ошибка");            
            }
            else
            {
                if (SQLClass.AddToDataBase("", ""))
                {
                    MessageBox.Show("Успешное добавление пользователя!", "Информация");
                }
                else
                {
                    MessageBox.Show("Произошла ошибка. Пользователь не добавлен.", "Ошибка");

                }
            } 
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
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
                if (SQLClass.UpdateToDataBase("", "",""))
                {
                    MessageBox.Show("Успешное редактирование пользователя!", "Информация");
                }
                else
                {
                    MessageBox.Show("Произошла ошибка. Пользователь не изменён.", "Ошибка");

                }
            } 

        }


    }
}
