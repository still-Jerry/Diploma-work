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

    public partial class DiscountForm : Form
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

        private void ToSpeciallyFormButton_Click(object sender, EventArgs e)
        {
            SpeciallyForm NewForm = new SpeciallyForm();
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

        private void DiscountForm_MouseDown(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.SizeAll;
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
            this.Cursor = Cursors.Default;
        }

        private void DiscountForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        #endregion
        /// <summary>Private form functions</summary>
        Boolean RequestGetProduct()
        {
            try
            {
                if (comboBox.SelectedItem == "Все категории")
                {
                    if (SQLClass.UpdateToDataBase(" product ", " discountProduct = '" + (DiscountNumericUpDown.Value / 100).ToString().Replace(',', '.') + "'", ""))
                    {
                        return true;
                    }
                }
                else
                {
                    var id = SQLClass.GetSelectInList(
                    "category",
                    where: " where `nameСategory` = '"+ comboBox.SelectedItem+"'",
                    attributes: " idСategory "
                    )[0];
                    if (SQLClass.UpdateToDataBase(" product ", " discountProduct = '" + (DiscountNumericUpDown.Value / 100).ToString().Replace(',', '.') + "'", " where categoryProduct = " + id))
                    {
                        return true;
                    }

                }
                return false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return false;
                
            }
        }
        public DiscountForm()
        {
            InitializeComponent();
            List<String> category = SQLClass.GetSelectInList("`category`", attributes: " `nameСategory` ", order: " ORDER BY `nameСategory` ASC");
            for (Int16 i = 0; i < category.Count(); i++)
            {
                comboBox.Items.Add(category[i]);
            }
            comboBox.Items.Add("Все категории");
            comboBox.SelectedItem = "Все категории";

            DayNumericUpDown.Value = ViewsClass.DiscountDay;
            timer1.Start();
        }

        private void ChangeDayButton_Click(object sender, EventArgs e)
        {
            if (RequestGetProduct()) {
                MessageBox.Show("Успешное обновление скидки!", "Информация");
            }else{
                MessageBox.Show("Скидки не обновлены.", "Информация");
            
            }
        }

        private void CangeDayButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (BusinessClass.WriteCounfig(DayNumericUpDown.Value.ToString(), AppDomain.CurrentDomain.BaseDirectory + "\\Res\\discount.conf"))
                {
                    ViewsClass.DiscountDay = Convert.ToInt16(DayNumericUpDown.Value);
                    MessageBox.Show("Скидочный день успешно изменён.", "Информация");
                }
                else {
                    MessageBox.Show("Ошибка чтения. Скидочный день не изменён.", "Информация");
                
                }
                
            }
            catch {
                MessageBox.Show("Ошибка. Скидочный день не изменён.", "Информация");
            
            }
        }


       
    }
}
