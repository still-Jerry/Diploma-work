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
    using BusinessClass = Modules.BusinessClass;
    using SQLClass = Modules.SQLClass;
    public partial class DirectoryForm : Form
    {
        public DirectoryForm()
        {
            InitializeComponent();
            CategoryDataGridView.DataSource = SQLClass.GetSelectInDataTable(" category ", attributes: " idСategory, nameСategory as 'Название' ");
            CategoryDataGridView.Columns[0].Visible = false;

        }
        #region Typical events of all forms
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

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch(tabControl.SelectedIndex){
                    case (0):
                        CategoryDataGridView.DataSource = SQLClass.GetSelectInDataTable(" category ", attributes: " idСategory, nameСategory as 'Название' ");
                        CategoryDataGridView.Columns[0].Visible = false;
                        break;
                    case(1):
                        SeriesDataGridView.DataSource = SQLClass.GetSelectInDataTable(" seriesproduct ", attributes:
                           "idSeries as '№', `nameProduct` as 'Продукт', expirationDateSeries as 'Годен до', countProductSeries as 'Кол-во'",
                           join: "inner join product on productIdSeries=`idProduct`");
                        SeriesDataGridView.Columns[0].Width = 70;
                        SeriesDataGridView.Columns[3].Width = 80;

                        break;
                    case(2):
                        UsersDataGridView.DataSource = SQLClass.GetSelectInDataTable(" diploma.user ", attributes:
                           "idUser, concat(surnameUser, ' ', nameUser, ' ', patronymicUser) as 'ФИО', `loginUser` as 'Логин', `nameRole` as 'Роль'",
                           join: "inner join `role` on `idRole` = roleUser");
                        UsersDataGridView.Columns[0].Visible = false;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            CreateUserForm NewForm = new CreateUserForm();
            this.Visible = false;
            NewForm.ShowDialog();
        }

        private void SeriesButton_Click(object sender, EventArgs e)
        {
            MoreProductMessageForm NewForm = new MoreProductMessageForm();
            this.Visible = false;
            NewForm.ShowDialog();
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            DirectoryFormMessageForm NewForm = new DirectoryFormMessageForm();
            this.Visible = false;
            NewForm.ShowDialog();
        }

    }
}
