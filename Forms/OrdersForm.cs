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
using System.IO;
using Word = Microsoft.Office.Interop.Word;

namespace АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Forms
{
    using ViewsClass = Modules.ViewsClass;
    using BusinessClass = Modules.BusinessClass;
    using SQLClass = Modules.SQLClass;

    public partial class OrdersForm : Form
    {
        string period = "";
        Double totalSum = 0;

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

        private void OrdersForm_MouseDown(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.SizeAll;
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
            this.Cursor = Cursors.Default;
        }

        private void OrdersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
            OrdersFilterComboBox.Items.Add("Всё время");
            OrdersFilterComboBox.Items.Add("Месяц");
            OrdersFilterComboBox.Items.Add("Год");
            OrdersFilterComboBox.Items.Add("Произвольный период");
            OrdersFilterComboBox.SelectedItem="Всё время";

            OrdersSearchСomboBox.Items.Add("пользователям");
            OrdersSearchСomboBox.Items.Add("номеру заказа");
            OrdersSearchСomboBox.SelectedItem = "номеру заказа";


            DelayFilterComboBox.Items.Add("Всё время");
            DelayFilterComboBox.Items.Add("Месяц");
            DelayFilterComboBox.Items.Add("Год");
            DelayFilterComboBox.Items.Add("Произвольный период");
            DelayFilterComboBox.SelectedItem = "Всё время";

            DelaySearchСomboBox.Items.Add("наименованию");
            DelaySearchСomboBox.Items.Add("номеру серии");
            DelaySearchСomboBox.SelectedItem = "номеру серии";

            if (BusinessClass.UserInfoList[5] == "2")
            {
                OrdersReportButton.Visible = false;
                DelayReportButton.Visible = false;
            }
            else
            {
                OrdersReportButton.Visible = true;
                DelayReportButton.Visible = true;
            }

            if (ViewsClass.StateWindows)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            GetOrders();
            GetDelay();
            OrdersDataGridView.Columns[0].Width = 80;
            OrdersDataGridView.Columns[3].Width = 100;
            
            
        }

        /// <summary>Private form functions</summary> 
        void GetOrders()
        {
            try
            {
                string where="";
                switch(OrdersFilterComboBox.Text){
                    case("Месяц"):
                        period = DateTime.Today.Day + "." + (DateTime.Today.Month - 1) + "." + DateTime.Today.Year + " - " + DateTime.Today.Date.ToString().Split(' ')[0];

                        where = "where dateOrder>=date('" + DateTime.Today.Year + "." + (DateTime.Today.Month - 1) + "." + DateTime.Today.Day + "') and dateOrder<=current_date() ";
                        break;
                    case ("Год"):
                        period = DateTime.Today.Day + "." + DateTime.Today.Month + "." + (DateTime.Today.Year - 1) + " - " + DateTime.Today.Date.ToString().Split(' ')[0];

                        where = "where dateOrder>=date('" + (DateTime.Today.Year - 1) + "." + DateTime.Today.Month + "." + DateTime.Today.Day + "') and dateOrder<=current_date() ";
                        break;
                    case ("Произвольный период"):
                        ViewsClass.EnabledForm = false;
                        OrdersMessageForm NewForm = new OrdersMessageForm();
                        this.Enabled = ViewsClass.EnabledForm;
                        NewForm.ShowDialog();
                        this.Enabled = true;

                        period = OrdersMessageForm.start + " - " + OrdersMessageForm.end;


                        where = "where dateOrder>=date('"+OrdersMessageForm.start+"') and dateOrder<=date('"+OrdersMessageForm.end+ "') ";

                        break;
                    default:
                        period = " за всё время.";

                        break;
                }
                OrdersDataGridView.DataSource = SQLClass.GetSelectInDataTable(" `order` ", 
                    attributes:"idOrder as №, concat(`surnameUser`, ' ',`nameUser`, ' ', `patronymicUser`) as 'Пользователь', dateOrder as 'Дата оформления', "+
                     " round(sum(`priceProduct`*quantityList),2) as 'Сумма заказа'",
                    join: "inner join `list` on `idOrderList` = `idOrder`"+
                        " inner join `seriesproduct` on `seriesproduct`.`idSeries` = `list`.`seriesProductList` " +
                        " inner join `diploma`.`product` on `seriesproduct`.`productIdSeries` = `product`.`idProduct` "+
                        " inner join `diploma`.`user` on `user`.`idUser` = `userOrder` ",
                    where:where,
                    order: " group by idOrder order by idOrder");
                foreach (DataGridViewRow row in OrdersDataGridView.Rows)
                {
                    var fio = row.Cells[1].Value.ToString().TrimEnd();
                    row.Cells[1].Value="";
                    int к = fio.Split(' ').Length;
                    for (int i = 0; i < fio.Split(' ').Length;i++ )
                    {

                        row.Cells[1].Value = row.Cells[1].Value.ToString() + fio.Split(' ')[i][0] + "****** ";
                    }
                }
                ChangeNumbers();
               
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Ошибка");
            }
        }
       
        void GetDelay()
        {
            try
            {
                string where = "";
                switch (DelayFilterComboBox.Text)
                {
                    case ("Месяц"):
                        period = DateTime.Today.Day + "." + (DateTime.Today.Month - 1) + "." + DateTime.Today.Year + " - " + DateTime.Today.Date.ToString().Split(' ')[0];

                        where = " where expirationDateSeries>=date('" + DateTime.Today.Year + "." + (DateTime.Today.Month - 1) + "." + DateTime.Today.Day + "') and expirationDateSeries<=current_date() ";
                        break;
                    case ("Год"):
                        period = DateTime.Today.Day + "." + DateTime.Today.Month + "." + (DateTime.Today.Year - 1) + " - " + DateTime.Today.Date.ToString().Split(' ')[0];

                        where = " where expirationDateSeries>=date('" + (DateTime.Today.Year - 1) + "." + DateTime.Today.Month + "." + DateTime.Today.Day + "') and expirationDateSeries<=current_date() ";
                        break;
                    case ("Произвольный период"):
                        ViewsClass.EnabledForm = false;
                        OrdersMessageForm NewForm = new OrdersMessageForm();
                        this.Enabled = ViewsClass.EnabledForm;
                        NewForm.ShowDialog();
                        this.Enabled = true;

                        period = OrdersMessageForm.start + " - " + OrdersMessageForm.end;


                        where = " where expirationDateSeries>=date('" + OrdersMessageForm.start + "') and expirationDateSeries<=date('" + OrdersMessageForm.end + "') ";

                        break;
                    default:
                        period = " за всё время.";
                        where = " where expirationDateSeries <= current_date()";
                        break;
                }
                DelayDataGridView.DataSource = SQLClass.GetSelectInDataTable(" `seriesproduct` ",
                    attributes: "idSeries as 'Серия', `nameProduct` as 'Товар'," +
                     "expirationDateSeries as 'Годен  до', `priceProduct` as 'Цена',"+
                     "countProductSeries as 'Кол-во', (countProductSeries*`priceProduct`) as 'Утбыток'",
                    join: " inner join `diploma`.`product` on `seriesproduct`.`productIdSeries` = `product`.`idProduct` " ,
                    where: where,
                    order: " order by 'Утбыток'");
              
                ChangeNumbers();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        void ChangeNumbers()
        {
            try
            {
                totalSum = 0;

                foreach (DataGridViewRow row in OrdersDataGridView.Rows)
                {
                    totalSum += Convert.ToDouble(row.Cells[3].Value.ToString());

                }
                OrdersTotalSumLabel.Text = "Итого: " + totalSum + " p.";

                totalSum = 0;
                foreach (DataGridViewRow row in DelayDataGridView.Rows)
                {
                    totalSum += Convert.ToDouble(row.Cells[5].Value.ToString());

                }
                DelayTotalSumLabel.Text = "Итого: " + totalSum + " p.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        bool OrderReportCreate(bool visible)
        {
            try
            {
                String path = AppDomain.CurrentDomain.BaseDirectory + "\\Res\\Documents\\OrderReports";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                string number = "";
                string date = "";
                string worker = "";
                string cost = "";
                double cost1 = 0.0;
                foreach (DataGridViewRow row in OrdersDataGridView.Rows)
                {
                    number += row.Cells[0].Value.ToString() + "\v";
                    worker += SQLClass.GetSelectInList(" `order` ",
                        " where idOrder = " + row.Cells[0].Value.ToString(),
                        attributes: "concat(`surnameUser`, ' ',`nameUser`, ' ', `patronymicUser`)",
                        join: "inner join `diploma`.`user` on `user`.`idUser` = `userOrder`")[0] +"\v";

                    date += row.Cells[2].Value.ToString().Split(' ')[0] + "\v";
                    cost += row.Cells[3].Value.ToString() + "\v";
                    cost1 += Convert.ToDouble(row.Cells[3].Value.ToString());

                }


                string FileCheck = AppDomain.CurrentDomain.BaseDirectory + "\\Res\\Documents\\order_report_template.docx";
                string newFileName = path + "\\Отчёт_о_заказах_" + DateTime.Now.ToString("yyyy_MM_dd__HH_mm_ss") + ".doc";

                FileInfo fileInf = new FileInfo(FileCheck);
                fileInf.CopyTo(newFileName, true);

                var wordApp = new Word.Application();
                wordApp.Visible = false;

                var wordDocument = wordApp.Documents.Open(newFileName);
                BusinessClass.ReplaceWordStub("{dateReport}", DateTime.Now.ToString("dd.MM.yyyy_HH:mm:ss"), wordDocument);
                BusinessClass.ReplaceWordStub("{user}", BusinessClass.UserInfoList[1] + " " + BusinessClass.UserInfoList[2] + " " + BusinessClass.UserInfoList[3], wordDocument);
                BusinessClass.ReplaceWordStub("{period}", period, wordDocument);
                BusinessClass.ReplaceWordStub("{№}", number, wordDocument);
                BusinessClass.ReplaceWordStub("{worker}", worker, wordDocument);
                BusinessClass.ReplaceWordStub("{date}", date, wordDocument);
                BusinessClass.ReplaceWordStub("{cost}", cost, wordDocument);
                BusinessClass.ReplaceWordStub("{cost1}", cost1.ToString(), wordDocument);

                wordDocument.Save();
                wordApp.Visible = visible;
                if (!visible) { wordDocument.Close(Word.WdSaveOptions.wdDoNotSaveChanges); }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        bool DelayReportCreate(bool visible)
        {
            try
            {
                String path = AppDomain.CurrentDomain.BaseDirectory + "\\Res\\Documents\\DelayReports";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                string number = "";
                string date = "";
                string product = "";
                string price = "";
                string count = "";
                string cost = "";
                double cost1 = 0.0;
                foreach (DataGridViewRow row in DelayDataGridView.Rows)
                {
                    number += row.Cells[0].Value.ToString() + "\v";
                    product += row.Cells[1].Value.ToString() + "\v"; 
                    date += row.Cells[2].Value.ToString().Split(' ')[0] + "\v";
                    price += row.Cells[3].Value.ToString() + "\v";
                    count += row.Cells[4].Value.ToString() + "\v"; 
                    cost += row.Cells[5].Value.ToString() + "\v";
                    cost1 += Convert.ToDouble(row.Cells[5].Value.ToString());

                }


                string FileCheck = AppDomain.CurrentDomain.BaseDirectory + "\\Res\\Documents\\delay_report_template.docx";
                string newFileName = path + "\\Отчёт_о_просроченных_товарах_" + DateTime.Now.ToString("yyyy_MM_dd__HH_mm_ss") + ".doc";

                FileInfo fileInf = new FileInfo(FileCheck);
                fileInf.CopyTo(newFileName, true);

                var wordApp = new Word.Application();
                wordApp.Visible = false;

                var wordDocument = wordApp.Documents.Open(newFileName);
                BusinessClass.ReplaceWordStub("{dateReport}", DateTime.Now.ToString("dd.MM.yyyy_HH:mm:ss"), wordDocument);
                BusinessClass.ReplaceWordStub("{user}", BusinessClass.UserInfoList[1] + " " + BusinessClass.UserInfoList[2] + " " + BusinessClass.UserInfoList[3], wordDocument);
                BusinessClass.ReplaceWordStub("{period}", period, wordDocument);
                BusinessClass.ReplaceWordStub("{№}", number, wordDocument);
                BusinessClass.ReplaceWordStub("{product}", product, wordDocument);
                BusinessClass.ReplaceWordStub("{date}", date, wordDocument);
                BusinessClass.ReplaceWordStub("{price}", price, wordDocument);
                BusinessClass.ReplaceWordStub("{count}", count, wordDocument);
                BusinessClass.ReplaceWordStub("{cost}", cost, wordDocument);
                BusinessClass.ReplaceWordStub("{cost1}", cost1.ToString(), wordDocument);

                wordDocument.Save();
                wordApp.Visible = visible;
                if (!visible) { wordDocument.Close(Word.WdSaveOptions.wdDoNotSaveChanges); }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        #region Oreders

        private void OrdersSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                OrdersSearchTextBox.Text = ViewsClass.ToUpperString(OrdersSearchTextBox.Text);
                OrdersSearchTextBox.SelectionStart = OrdersSearchTextBox.Text.Length;
                OrdersSearchTextBox.Focus();

                List<string> listR;
                if (OrdersSearchСomboBox.SelectedItem == "номеру заказа")
                {
                    listR = SQLClass.GetSelectInList("`order`", " where idOrder like '" + OrdersSearchTextBox.Text.TrimStart() + "%'",
                    "idOrder", " order by idOrder");
                }
                else
                {
                    listR = SQLClass.GetSelectInList("`order`", " where surnameUser like '" + OrdersSearchTextBox.Text.TrimStart() + "%'" +
                        " or nameUser like '" + OrdersSearchTextBox.Text.TrimStart() + "%'" + " or patronymicUser like '" + OrdersSearchTextBox.Text.TrimStart() + "%'",
                        "idOrder", " order by idOrder",
                        " inner join `diploma`.`user` on `user`.`idUser` = `userOrder` ");
                }

                DataGridViewRow first = null;
                foreach (DataGridViewRow row in OrdersDataGridView.Rows)
                {
                    if (listR.Contains(row.Cells[0].Value.ToString()))
                    {
                        row.DefaultCellStyle.BackColor = Color.Pink;

                        if (first == null)
                        {
                            first = row;
                        }
                        first.Selected = true;
                        OrdersDataGridView.FirstDisplayedScrollingRowIndex = first.Index;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;

                    }
                    if (OrdersSearchTextBox.Text.Replace(" ", "").Replace("   ", "") == "")
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }

            }
            catch
            {

            }
        }

        private void OrdersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (BusinessClass.UserInfoList[5] == "1")
            {
                DataGridViewRow selected = OrdersDataGridView.SelectedRows[0];

                foreach (DataGridViewRow row in OrdersDataGridView.Rows)
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
                        row.Cells[1].Value = SQLClass.GetSelectInList(" `order` ",
                        " where idOrder = " + OrdersDataGridView.SelectedRows[0].Cells[0].Value,
                        attributes: "concat(`surnameUser`, ' ',`nameUser`, ' ', `patronymicUser`)",
                        join: "inner join `diploma`.`user` on `user`.`idUser` = `userOrder`")[0];
                    }

                }

                OrdersDataGridView.Columns[0].Width = 80;
                OrdersDataGridView.Columns[3].Width = 100;
            }
        }

        private void OrdersReportButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вывести отчёт?", "Информация", MessageBoxButtons.YesNo);
            bool checkF = false;
            if (dr == DialogResult.Yes)
            {
                checkF = true;
            }
            else
            {
                checkF = false;
            }
            this.Enabled = false;
            if (!OrderReportCreate(checkF))
            {
                MessageBox.Show("Отчёт не сформирован.", "Ошибка");
            }
            this.Enabled = true;
        }

        private void OrdersFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetOrders();
        }

        private void просмотрСоставаЗаказаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusinessClass.SelectedFromDataGridList = SQLClass.GetSelectInList("diploma.order",
                   where: " where idOrder = " + OrdersDataGridView.SelectedRows[0].Cells[0].Value);
            MoreOrderForm NewForm = new MoreOrderForm();
            this.Visible = false;
            NewForm.ShowDialog();
        }
        #endregion      

        #region Delay
        private void DelaySearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (!((l >= 'А' && l <= 'я') || l == 'ё' || l == 'Ё' || l == '\b' || l == '-'
               || l == '0' || l == '1' || l == '2' || l == '3' || l == '4' || l == '5'
               || l == '6' || l == '7' || l == '8' || l == '9' || l == ' '))
            {
                e.Handled = true;
            }
        }

        private void DelaySearchTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                DelaySearchTextBox.Text = ViewsClass.ToUpperString(DelaySearchTextBox.Text);
                DelaySearchTextBox.SelectionStart = DelaySearchTextBox.Text.Length;
                DelaySearchTextBox.Focus();

                List<string> listR;
                if (DelaySearchСomboBox.SelectedItem == "номеру серии")
                {
                    listR = SQLClass.GetSelectInList("`seriesproduct`", " where idSeries like '" + DelaySearchTextBox.Text.TrimStart() + "%'",
                    "idSeries", " order by idSeries");
                }
                else
                {
                    listR = SQLClass.GetSelectInList("`seriesproduct`", " where nameProduct like '" + DelaySearchTextBox.Text.TrimStart() + "%'",
                        "idSeries", " order by idSeries",
                        " inner join product on productIdSeries = `idProduct` ");
                }

                DataGridViewRow first = null;
                foreach (DataGridViewRow row in DelayDataGridView.Rows)
                {
                    if (listR.Contains(row.Cells[0].Value.ToString()))
                    {
                        row.DefaultCellStyle.BackColor = Color.Pink;

                        if (first == null)
                        {
                            first = row;
                        }
                        first.Selected = true;
                        DelayDataGridView.FirstDisplayedScrollingRowIndex = first.Index;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;

                    }
                    if (DelaySearchTextBox.Text.Replace(" ", "").Replace("   ", "") == "")
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }

            }
            catch
            {

            }
        }

        private void DelayFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDelay();
        }

        private void DelayReportButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вывести отчёт?", "Информация", MessageBoxButtons.YesNo);
            bool checkF = false;
            if (dr == DialogResult.Yes)
            {
                checkF = true;
            }
            else
            {
                checkF = false;
            }
            this.Enabled = false;
            if (!DelayReportCreate(checkF))
            {
                MessageBox.Show("Отчёт не сформирован.", "Ошибка");
            }
            this.Enabled = true;
        }

        #endregion

      





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


        //SELECT idSeries as 'Серия', `nameProduct` as 'Наименование',
        //expirationDateSeries as 'Годен  до', `priceProduct` as 'Цена',
        //countProductSeries as 'Кол-во', (countProductSeries*`priceProduct`) as 'Утбыток' 
        //FROM diploma.seriesproduct inner join product on productIdSeries = `idProduct`
        //where expirationDateSeries <= current_date();
    }
}
