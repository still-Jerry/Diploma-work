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

    public partial class OrdersForm : Form
    {
      
        #region Typical events of all forms
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

        public OrdersForm()
        {
            InitializeComponent();
            FilterComboBox.Items.Add("Всё время");
            FilterComboBox.Items.Add("Месяц");
            FilterComboBox.Items.Add("Год");
            FilterComboBox.Items.Add("Произвольный период");
            FilterComboBox.SelectedItem="Всё время";

            SearchСomboBox.Items.Add("пользователям");
            SearchСomboBox.Items.Add("номеру заказа");
            SearchСomboBox.SelectedItem = "номеру заказа";

            GetProduct();

        }
        void GetProduct()
        {
            try
            {
                string where="";
                switch(FilterComboBox.Text){
                    case("Месяц"):
                        where = " dateOrder>=date('" + DateTime.Today.Day + "." + (DateTime.Today.Month-1) + "." + DateTime.Today.Year + "') and dateOrder<=current_date() ";
                        break;
                    case ("Год"):
                        where = " dateOrder>=date('" + DateTime.Today.Day + "." + DateTime.Today.Month + "." + (DateTime.Today.Year-1) + "') and dateOrder<=current_date() ";
                        break;
                    case ("Произвольный период"):
                        break;
                    default:
                        break;
                }
                dataGridView.DataSource = SQLClass.GetSelectInDataTable(" `order` ", 
                    attributes:"idOrder as №, concat(`surnameUser`, ' ',`nameUser`, ' ', `patronymicUser`) as 'Пользователь', dateOrder as 'Дата оформления', "+
                     " round(sum(`priceProduct`*(1-`discountProduct`)*quantityList),2) as 'Сумма заказа', sum(quantityList) as 'Кол-во продуктов'",
                    join: "inner join `list` on `idOrderList` = `idOrder`"+
                        " inner join `seriesproduct` on `seriesproduct`.`idSeries` = `list`.`seriesProductList` " +
                        " inner join `diploma`.`product` on `seriesproduct`.`productIdSeries` = `product`.`idProduct` "+
                        " inner join `diploma`.`user` on `user`.`idUser` = `userOrder` "+
                        " group by idOrder",
                    where:where);
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    var fio = row.Cells[1].Value.ToString().TrimEnd();
                    row.Cells[1].Value="";
                    int к = fio.Split(' ').Length;
                    for (int i = 0; i < fio.Split(' ').Length;i++ )
                    {

                        row.Cells[1].Value = row.Cells[1].Value.ToString() + fio.Split(' ')[i][0] + "****** ";
                    }
                }
               
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Ошибка");
            }
        }

    

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GetProduct();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selected = dataGridView.SelectedRows[0];
            
            foreach (DataGridViewRow row in dataGridView.Rows)
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
                else {
                    row.Cells[1].Value = SQLClass.GetSelectInList(" `order` ",
                    " where idOrder = " + dataGridView.SelectedRows[0].Cells[0].Value,
                    attributes: "concat(`surnameUser`, ' ',`nameUser`, ' ', `patronymicUser`)",
                    join: "inner join `diploma`.`user` on `user`.`idUser` = `userOrder`")[0];
                }
              
            }

            dataGridView.Columns[0].Width = 80;
            dataGridView.Columns[3].Width = 100;
            dataGridView.Columns[4].Width = 80;
        }

     

        //SELECT idOrder, concat(`surnameUser`, " ",`nameUser`, " ", `patronymicUser`) as 'Пользователь', dateOrder as 'Дата оформления', 
        //sum(`priceProduct`*(1-`discountProduct`)*quantityList) as 'Сумма заказа', sum(quantityList) as 'Кол-во продукктов' FROM diploma.order 
        //inner join `list` on `idOrderList` = `idOrder`
        //inner join `seriesproduct` on `seriesproduct`.`idSeries` = `list`.`seriesProductList`
        //inner join `diploma`.`product` on `seriesproduct`.`productIdSeries` = `product`.`idProduct`
        //inner join `diploma`.`user` on `user`.`idUser` = `userOrder`
        //group by idOrder

        
        //dataGridViewSelectedRows[0].Cells[1].Value = SQLClass.GetSelectInList(" `order` ", 
        //" where idOrder = " + dataGridView.SelectedRows[0].Cells[0].Value,
        //attributes: "concat(`surnameUser`, ' ',`nameUser`, ' ', `patronymicUser`)",
        //join: "inner join `diploma`.`user` on `user`.`idUser` = `userOrder`")[0];
    }
}
