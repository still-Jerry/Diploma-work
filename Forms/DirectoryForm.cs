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

        #region General functional events
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
                        foreach (DataGridViewRow row in UsersDataGridView.Rows)
                        {
                            var fio = row.Cells[1].Value.ToString().TrimEnd();
                            row.Cells[1].Value = "";
                            int к = fio.Split(' ').Length;
                            for (int i = 0; i < fio.Split(' ').Length; i++)
                            {

                                row.Cells[1].Value = row.Cells[1].Value.ToString() + fio.Split(' ')[i][0] + "****** ";
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewsClass.DirectoryFormAdd = false;
            switch (tabControl.SelectedIndex)
            {
                case (0):
                    BusinessClass.SelectedFromDataGridList = SQLClass.GetSelectInList(" category ", where: " where `idСategory` = '" + CategoryDataGridView.SelectedRows[0].Cells[0].Value + "'");
                    ViewsClass.EnabledForm = false;
                    DirectoryFormMessageForm NewForm0 = new DirectoryFormMessageForm();
                    this.Enabled = ViewsClass.EnabledForm;
                    NewForm0.ShowDialog();
                    this.Enabled = true;
                    break;
                case (1):
                    BusinessClass.SelectedFromDataGridList = SQLClass.GetSelectInList(" seriesproduct ", " where idSeries = '" + SeriesDataGridView.SelectedRows[0].Cells[0].Value + "'");
                    ViewsClass.EnabledForm = false;
                    MoreProductMessageForm NewForm1 = new MoreProductMessageForm();
                    this.Enabled = ViewsClass.EnabledForm;
                    NewForm1.ShowDialog();
                    this.Enabled = ViewsClass.EnabledForm;
                    break;
                case (2):
                    BusinessClass.SelectedFromDataGridList = SQLClass.GetSelectInList(" `user` ", " where idUser = '" + UsersDataGridView.SelectedRows[0].Cells[0].Value + "'",
                        join: "inner join role on `idRole`=`roleUser`");
                    CreateUserForm NewForm2 = new CreateUserForm();
                    this.Visible = false;
                    NewForm2.ShowDialog();
                    break;
                default:
                    break;
            }
            tabControl_SelectedIndexChanged(sender, e);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res;
            switch (tabControl.SelectedIndex)
            {
                case (0):
                    if (CategoryDataGridView.RowCount > 1)
                    {
                        var count = SQLClass.GetSelectInList(" product ", attributes: "count(*)", where: " where `categoryProduct` = '" + CategoryDataGridView.SelectedRows[0].Cells[0].Value + "'")[0];

                        res = MessageBox.Show("Внимание! Будет удалено товары удалятся в количестве: " + count + " шт. Уверены что хотите продолжить? \nИзменения не обратимы.", "Предупреждение", MessageBoxButtons.YesNo);
                        if (res == DialogResult.Yes)
                        {
                            if (SQLClass.DeleteFromDataBase(" product ", where: " where `categoryProduct` = '" + CategoryDataGridView.SelectedRows[0].Cells[0].Value + "'")
                             &&
                             SQLClass.DeleteFromDataBase(" category ", where: " where `idСategory` = '" + CategoryDataGridView.SelectedRows[0].Cells[0].Value + "'")
                             )
                            {
                                MessageBox.Show("Успешное удаление категории!", "Информация");
                            }
                            else
                            {
                                MessageBox.Show("Произошла ошибка. Категория не удалилась", "Информация");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вы не можете удалить последнюю оставшуюся категорию", "Информация");
                    }

                    break;
                case (1):
                    res = MessageBox.Show("Уверены что хотите удалить выбранную серию? Изменения не обратимы.", "Предупреждение", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        if (SQLClass.DeleteFromDataBase(" seriesproduct ", where: " where `idSeries` = '" + SeriesDataGridView.SelectedRows[0].Cells[0].Value + "'"))
                        {

                            MessageBox.Show("Успешное удаление серии!", "Информация");
                        }
                        else
                        {
                            MessageBox.Show("Произошла ошибка. Серия не удалилась", "Информация");
                        }
                    }
                    break;
                case (2):
                    if (UsersDataGridView.SelectedRows[0].Cells[0].Value.ToString() == BusinessClass.UserInfoList[0])
                    {
                        MessageBox.Show("Вы не можете удалить сами себя", "Информация");
                    }
                    else
                    {
                        res = MessageBox.Show("Уверены что хотите удалить данного пользователя? Изменения не обратимы.", "Предупреждение", MessageBoxButtons.YesNo);
                        if (res == DialogResult.Yes)
                        {
                            if (SQLClass.DeleteFromDataBase(" `user` ", where: " where `idUser` = '" + UsersDataGridView.SelectedRows[0].Cells[0].Value + "'"))
                            {
                                MessageBox.Show("Успешное удаление пользователя!", "Информация");

                            }
                            else
                            {
                                MessageBox.Show("Произошла ошибка. Пользователь не удалён", "Информация");

                            }
                        }
                    }
                    break;
                default:
                    break;
            }
            tabControl_SelectedIndexChanged(sender, e);

        }
        #endregion

        #region Category
        private void CategoryButton_Click(object sender, EventArgs e)
        {
            ViewsClass.DirectoryFormAdd = true;


            ViewsClass.EnabledForm = false;
            DirectoryFormMessageForm NewForm = new DirectoryFormMessageForm();
            this.Enabled = ViewsClass.EnabledForm;
            NewForm.ShowDialog();
            this.Enabled = true;
            tabControl_SelectedIndexChanged(sender, e);
        }

        private void CategoryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<string> listR = SQLClass.GetSelectInList("`category`", " where nameСategory like '" + CategoryTextBox.Text.TrimStart() + "%'", "idСategory");

                DataGridViewRow first = null;
                foreach (DataGridViewRow row in CategoryDataGridView.Rows)
                {
                    if (listR.Contains(row.Cells[0].Value.ToString()))
                    {
                        row.DefaultCellStyle.BackColor = Color.Pink;

                        if (first == null)
                        {
                            first = row;
                        }
                        first.Selected = true;
                        CategoryDataGridView.FirstDisplayedScrollingRowIndex = first.Index;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;

                    }
                    if (CategoryTextBox.Text.Replace(" ", "").Replace("   ", "") == "")
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }

            }
            catch
            {

            }
        }
        #endregion

        #region Users
        private void UsersButton_Click(object sender, EventArgs e)
        {
            ViewsClass.DirectoryFormAdd = true;


            CreateUserForm NewForm = new CreateUserForm();
            this.Visible = false;
            NewForm.ShowDialog();
        }

        private void UsersDataGridView_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = UsersDataGridView.SelectedRows[0];

            foreach (DataGridViewRow row in UsersDataGridView.Rows)
            {
                if (row != selected)
                {
                    var fio = row.Cells[1].Value.ToString().TrimEnd(); ;
                    row.Cells[1].Value = "";
                    for (int i = 0; i < fio.Split(' ').Length; i++)
                    {
                        row.Cells[1].Value = row.Cells[1].Value.ToString() + fio.Split(' ')[i][0] + "****** ";
                    }
                }
                else
                {
                    row.Cells[1].Value = SQLClass.GetSelectInList(" diploma.user ", attributes:
                    "concat(surnameUser, ' ', nameUser, ' ', patronymicUser)",
                    where: " where idUser = " + selected.Cells[0].Value.ToString())[0];
                }

            }
        }

        private void UsersTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<string> listR = SQLClass.GetSelectInList(" `user` ",
                " where surnameUser like '" + UsersTextBox.Text.TrimStart() + "%'" +
                 " or nameUser like '" + UsersTextBox.Text.TrimStart() + "%'" +
                 " or patronymicUser like '" + UsersTextBox.Text.TrimStart() + "%'"
                 + " or loginUser like '" + UsersTextBox.Text.TrimStart() + "%'", "idUser");

                DataGridViewRow first = null;
                foreach (DataGridViewRow row in UsersDataGridView.Rows)
                {
                    if (listR.Contains(row.Cells[0].Value.ToString()))
                    {
                        row.DefaultCellStyle.BackColor = Color.Pink;

                        if (first == null)
                        {
                            first = row;
                        }
                        first.Selected = true;
                        UsersDataGridView.FirstDisplayedScrollingRowIndex = first.Index;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;

                    }
                    if (UsersTextBox.Text.Replace(" ", "").Replace("   ", "") == "")
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }

            }
            catch
            {

            }
        }
        #endregion

        private void SeriesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<string> listR = SQLClass.GetSelectInList(" `seriesproduct` ", " where idSeries like '" + SeriesTextBox.Text.TrimStart() + "%'" +
                    " or nameProduct like '" + SeriesTextBox.Text.TrimStart() + "%'",
                "idSeries",
                join: " inner join `product` on productIdSeries = idProduct ");

                DataGridViewRow first = null;
                foreach (DataGridViewRow row in SeriesDataGridView.Rows)
                {
                    if (listR.Contains(row.Cells[0].Value.ToString()))
                    {
                        row.DefaultCellStyle.BackColor = Color.Pink;

                        if (first == null)
                        {
                            first = row;
                        }
                        first.Selected = true;
                        SeriesDataGridView.FirstDisplayedScrollingRowIndex = first.Index;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;

                    }
                    if (SeriesTextBox.Text.Replace(" ", "").Replace("   ", "") == "")
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }

            }
            catch
            {

            }
        }

    



    }
}
