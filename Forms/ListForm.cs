using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//ВЫВЕДИ СЕРИЮ И РЕЦЕПТОРНОСТЬ В ПОСМОТРЕ ТОВАРА!!!!!!!!!!
//добавить столбец в order  с общей ценой?
namespace АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Forms
{
    using ViewsClass = Modules.ViewsClass;
    using BusinessClass = Modules.BusinessClass;
    using SQLClass = Modules.SQLClass;

    public partial class ListForm : Form
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


        private void ToProductButton_Click(object sender, EventArgs e)
        {
            ProductForm NewForm = new ProductForm();
            this.Visible = false;
            NewForm.ShowDialog();
          
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
        #region Сhecking the input
        /// <summary>
        /// checking the input of numbers in a column
        /// </summary>
        private void dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(CountColumn_KeyPress);
            if (dataGridView.CurrentCell.ColumnIndex == 3) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(CountColumn_KeyPress);
                }
            }
        }

        private void CountColumn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allowed numeric and one dot  ex. 10.23
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                 && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var value = dataGridView.CurrentCell.Value;
                Convert.ToInt32(dataGridView.CurrentCell.Value);
                if (value== null || value.ToString() =="0")
                {
                    удалитьИзЗаказаToolStripMenuItem_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                dataGridView.CurrentCell.Value =1;
            }
        }
        #endregion

        public ListForm()
        {
            InitializeComponent();
            RequestGetProduct();
        }
        /// <summary>Private form functions</summary> 

        void RequestGetProduct() {
            try
            {
                String where = "";
                Boolean flag = true;
                foreach (string series in BusinessClass.SeriesCountPrescriptionNumberDictionary.Keys)
                {
                    if (flag)
                    {
                        where += " where `idSeries` = " + series;
                        flag = false;
                    }
                    else
                    {
                        where += " or `idSeries` = " + series;

                    }
                }

                ViewsClass.ViewTableWithPicturesOnDataGrid(dataGridView, SQLClass.GetSelectInDataTable(
                        "seriesproduct",
                        where: where,
                        attributes: " idSeries, pictureProduct, nameProduct, priceProduct, discountProduct ",
                        join: " inner join product on productIdSeries = idProduct"
                        ), 0, false);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
        /// <summary>Function Events </summary>
        
        private void ClearButton_Click(object sender, EventArgs e)
        {
            
            var question = MessageBox.Show("Вы уверены, что хотите очистить заказ? Изменения необратимы.", "Предупреждение", MessageBoxButtons.YesNo);
            if (question == DialogResult.Yes)
            {
                dataGridView.Rows.Clear();
                BusinessClass.SeriesCountPrescriptionNumberDictionary.Clear();

                MessageBox.Show("Заказ очищен.", "Информация");

                ProductForm NewForm = new ProductForm();
                this.Visible = false;
                NewForm.ShowDialog();

            }
            else {
                dataGridView.CurrentCell.Value = 1;
            }
        }

        private void удалитьИзЗаказаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BusinessClass.SeriesCountPrescriptionNumberDictionary.Count == 1)
            {
                ClearButton_Click(sender, e);
            }
            else
            {
                var question = MessageBox.Show("Вы уверены, что хотите удалить выбранный товар из заказа? Изменения необратимы.", "Предупреждение", MessageBoxButtons.YesNo);
                if (question == DialogResult.Yes)
                {
                    BusinessClass.SeriesCountPrescriptionNumberDictionary.Remove(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    MessageBox.Show("Товар удалён из заказа", "Информация");
                    RequestGetProduct();

                }
                else {
                    dataGridView.CurrentCell.Value = 1;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                String values = "";

                foreach (string series in BusinessClass.SeriesCountPrescriptionNumberDictionary.Keys)
                {
                    values += "(null, {idOrderList}, " +
                        BusinessClass.SeriesCountPrescriptionNumberDictionary[series][0] + ", " +
                        series + ", " + BusinessClass.SeriesCountPrescriptionNumberDictionary[series][1] + "), ";
                }
                if (SQLClass.TransactionAddToDataBase2(" `order` ",
                    "null, " + BusinessClass.UserInfoList[0] + ", '" + DateTime.Today.Year + "." + DateTime.Today.Month + "." + DateTime.Today.Day + "'",
                   " `list` ",
                   values.Remove(values.Length - 2), "{idOrderList}", order: "ORDER BY idOrder LIMIT 1")) {
                       MessageBox.Show("Успешное оформление заказа.", "Информация");
                       ClearButton_Click(sender, e);

                }else{
                    MessageBox.Show("Ошибка. Заказ не соxранён.", "Ошибка");
                
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

      


  


      
    }
}
