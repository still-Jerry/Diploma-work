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
    public partial class MoreOrderForm : Form
    {
        Double totalSum = 0;

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
            OrdersForm NewForm = new OrdersForm();
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

        public MoreOrderForm()
        {
            InitializeComponent();
            RequestGetProduct();
        }

        /// <summary>Private form functions</summary>
        void RequestGetProduct()
        {
            try
            {
               DataTable table =  SQLClass.GetSelectInDataTable(
                                    " diploma.order ",
                                    where: " where idOrderList = " + BusinessClass.SelectedFromDataGridList[0],
                                    attributes: " idProduct,`pictureProduct`,`nameProduct`, `priceProduct`,"+
                                    " `idSeries`, `expirationDateSeries` , `prescriptionNumberList`, `quantityList`",
                                    join: " inner join `list` on idOrderList = idOrder"+
                                    " inner join seriesproduct on seriesProductList = `idSeries`"+
                                    " inner join product on `productIdSeries` = `idProduct`"
                                    );
                dataGridView.Rows.Clear();
               
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    Image img;
                    var path = AppDomain.CurrentDomain.BaseDirectory + "\\Res\\Product\\";
                    if (table.Rows[i][1].ToString() == "" || table.Rows[i][1].ToString() == " ")
                    {
                        img = Properties.Resources.plug as Bitmap;

                    }
                    else
                    {
                        try
                        {
                            path += table.Rows[i][1].ToString();
                            img = Image.FromFile(path);
                        }
                        catch(Exception ex) {
                            MessageBox.Show(ex.Message, "Ошибка");
                            img = Properties.Resources.plug as Bitmap;
                        }
                    }
                    if (table.Rows[i][6].ToString() != "0")
                    {
                        dataGridView.Rows.Add(
                            table.Rows[i][0].ToString(),
                            img,
                             table.Rows[i][2].ToString() +
                            "\n\nЦена: " + table.Rows[i][3].ToString() + " p." +
                            "\nИтого: " + Convert.ToDouble(table.Rows[i][3]) * Convert.ToDouble(table.Rows[i][7]) + " p." +
                            "\n\nСерия: " + table.Rows[i][4].ToString() +
                            "\nГоден до: " + table.Rows[i][5].ToString().Split(' ')[0] +
                             "\n№ рецепта: " + table.Rows[i][6].ToString(), table.Rows[i][7].ToString());
                    }
                    else {
                        dataGridView.Rows.Add(
                                table.Rows[i][0].ToString(),
                                img,
                                table.Rows[i][2].ToString() +
                                "\n\nЦена: " + table.Rows[i][3].ToString() + " p." +
                                "\nИтого: " + Convert.ToDouble(table.Rows[i][3]) * Convert.ToDouble(table.Rows[i][7]) + " p." +
                                "\n\nСерия: " + table.Rows[i][4].ToString() +
                                "\nГоден до: " + table.Rows[i][5].ToString().Split(' ')[0],
                                table.Rows[i][7].ToString());
                    }

                    dataGridView.Rows[dataGridView.Rows.Count - 1].Height = 100;

                }
                ChangeNumbers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        void ChangeNumbers()
        {
            try
            {
                totalSum = 0;

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    totalSum += Convert.ToDouble(row.Cells[2].Value.ToString().Replace("\n", "\\").Split('\\')[3].Replace("Итого:", "").Replace("p.", ""));

                }
                TotalSumLabel.Text = "Итого: " + totalSum + " p.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }


        private void просмотрТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                BusinessClass.SelectedFromDataGridList = SQLClass.GetSelectInList("Product",
                    where: " where idProduct = " + dataGridView.SelectedRows[0].Cells[0].Value);
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

        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int h = 100;
           
            if (dataGridView.SelectedRows[0].Height >= 220 || dataGridView.SelectedRows[0].Height < h)
            {
                dataGridView.SelectedRows[0].Height = h;
            }
            else
            {
                dataGridView.SelectedRows[0].Height = 220;

            }
        }

    }
}
