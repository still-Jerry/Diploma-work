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
    using BusinessClass = Modules.BusinessClass;
    using SQLClass = Modules.SQLClass;

    public partial class ListForm : Form
    {
        Double sum = 0;
        Double totalSum = 0;
        string selectedId = "";
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

        /// <summary> Inactivity Tracking </summary>

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (GetIdleTime() >= 60000)
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

        private void ListForm_MouseDown(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.SizeAll;
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
            this.Cursor = Cursors.Default;
        }

        private void ListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
      
                selectedId = dataGridView.SelectedRows[0].Cells[0].Value.ToString();

                var value = dataGridView.CurrentCell.Value;
                Convert.ToInt32(dataGridView.CurrentCell.Value);
                if (value == null || value.ToString() == "0")
                {
                    удалитьИзЗаказаToolStripMenuItem_Click(sender, e);
                }
                else {
                    
                    List <String> list = SQLClass.GetSelectInList("seriesproduct", " where idSeries = " + selectedId);
                    if (Convert.ToInt32(list[3]) <= Convert.ToInt32(value))
                    {
                        dataGridView.CurrentCell.Value = Convert.ToInt32(list[3]);
                        BusinessClass.SeriesCountPrescriptionNumberDictionary[selectedId][0] = Convert.ToInt32(list[3]);
                        RequestGetProduct();
                    }
                    else {
                        BusinessClass.SeriesCountPrescriptionNumberDictionary[selectedId][0] = Convert.ToInt32(value);
                        RequestGetProduct();
                    }
                    ChangeNumbers();
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
            timer1.Start();
        }
        /// <summary>Private form functions</summary> 
        void ChangeNumbers() {
            try
            {
                sum = 0;
                totalSum = 0;

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    sum += Convert.ToDouble(row.Cells[2].Value.ToString().Replace("\n", "\\").Split('\\')[2].Replace("Цена:", "").Replace("p.", "")) * Convert.ToDouble(row.Cells[3].Value);
                    if (ViewsClass.DiscountDay == Convert.ToInt16(DateTime.Today.Day))
                    {
                        totalSum += Convert.ToDouble(row.Cells[2].Value.ToString().Replace("\n", "\\").Split('\\')[4].Replace("Итого:", "").Replace("p.", ""));

                    }
                    else {

                        totalSum += Convert.ToDouble(row.Cells[2].Value.ToString().Replace("\n", "\\").Split('\\')[3].Replace("Итого:", "").Replace("p.", ""));
                    
                    }
                }
                if (ViewsClass.DiscountDay == Convert.ToInt16(DateTime.Today.Day))
                {
                    DiscountLabel.Text = "Скидка: " + Math.Round(100 - (totalSum * 100 / sum), 2) + "%";

                }
                else {
                    DiscountLabel.Text = "Скидка: 0%";
                
                }
                SumLabel.Text = "Общая сумма: " + sum + " p.";
                TotalSumLabel.Text = "Итого: " + totalSum + " p.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
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

                foreach (DataGridViewRow  row in dataGridView.Rows)
                {
                    List <String > list = SQLClass.GetSelectInList(
                                                            "seriesproduct",
                                                            where: " where `idSeries` = " + row.Cells[0].Value.ToString()
                                                            );
                    row.Cells[3].Value = BusinessClass.SeriesCountPrescriptionNumberDictionary[list[0]][0];
                    if (ViewsClass.DiscountDay == Convert.ToInt16(DateTime.Today.Day)) {
                        var value = row.Cells[2].Value.ToString().Replace("\n", "\\").Split('\\');
                        row.Cells[2].Value = value[0] + "\n";
                        for (int i=1; i<value.Count()-1; i++){
                            row.Cells[2].Value += value[i]+"\n";
                        }
                        row.Cells[2].Value=row.Cells[2].Value.ToString()+ "Итого: "
                            + (Convert.ToDouble(value[value.Count()-1].Replace("Итого:","").Replace("p.", ""))
                            *  BusinessClass.SeriesCountPrescriptionNumberDictionary[list[0]][0])+" p.";
                    }
                    else {
                        row.Cells[2].Value = row.Cells[2].Value.ToString() + "\nИтого: " +
                           Convert.ToDouble(row.Cells[2].Value.ToString().Replace("\n", "\\").Split('\\')[2].Replace("Цена:", "").Replace("p.", ""))
                            * BusinessClass.SeriesCountPrescriptionNumberDictionary[list[0]][0] + " p.";

                        }
                    row.Cells[2].Value  =row.Cells[2].Value.ToString()+
                        "\n\nСерия: " + list[0]
                        + "\nГоден до: " + list[2].Split(' ')[0];
                    if (BusinessClass.SeriesCountPrescriptionNumberDictionary[list[0]][1] != 0) {
                        row.Cells[2].Value = row.Cells[2].Value.ToString() +
                            "\n№ рецепта: " + BusinessClass.SeriesCountPrescriptionNumberDictionary[list[0]][1];
                    }
                }
                ChangeNumbers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
        /// <summary>Function Events </summary>
        
        private void ClearButton_Click(object sender, EventArgs e)
        {
            
            //var question = MessageBox.Show("Вы уверены, что хотите очистить заказ? Изменения необратимы.", "Предупреждение", MessageBoxButtons.YesNo);
            //if (question == DialogResult.Yes)
            //{
                dataGridView.Rows.Clear();
                BusinessClass.SeriesCountPrescriptionNumberDictionary.Clear();

                //MessageBox.Show("Заказ очищен.", "Информация");

                ProductForm NewForm = new ProductForm();
                this.Visible = false;
                NewForm.ShowDialog();

            //}
            //else {
            //    dataGridView.CurrentCell.Value = 1;
            //}
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
                    if (selectedId != "")
                    {
                        BusinessClass.SeriesCountPrescriptionNumberDictionary.Remove(selectedId);

                        selectedId = "";
                    }
                    else {
                        BusinessClass.SeriesCountPrescriptionNumberDictionary.Remove(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    
                    }
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
                   values.Remove(values.Length - 2), "{idOrderList}", order: "ORDER BY idOrder DESC LIMIT 1")) {

                       foreach (string series in BusinessClass.SeriesCountPrescriptionNumberDictionary.Keys) {
                           SQLClass.UpdateToDataBase(" seriesproduct ", " countProductSeries = countProductSeries-"+
                               BusinessClass.SeriesCountPrescriptionNumberDictionary[series][0],
                               " where idSeries = " + series);
                       }
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

        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int h = 100;
            if (ViewsClass.DiscountDay == Convert.ToInt16(DateTime.Today.Day)) {
                h = 120;
            }
            if (dataGridView.SelectedRows[0].Height >= 220 || dataGridView.SelectedRows[0].Height < h)
            {
                dataGridView.SelectedRows[0].Height = h;
            }
            else {
                dataGridView.SelectedRows[0].Height = 220;
            
            }
        }

        private void просмотрТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                BusinessClass.SelectedFromDataGridList = SQLClass.GetSelectInList("Product",
                    where: " where idSeries = " + dataGridView.SelectedRows[0].Cells[0].Value,
                    join: " inner join seriesproduct on productIdSeries = idProduct");
                ViewsClass.MoreProductButtonState = 4;
                MoreProductForm NewForm = new MoreProductForm();
                this.Visible = false;
                NewForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }


      


  


      
    }
}
