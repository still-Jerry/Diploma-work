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

    public partial class ProductMessageForm : Form
    {
        #region Typical events of all forms
        /// <summary>window display buttons </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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


        private void ProductMessageForm_MouseDown(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.SizeAll;
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
            this.Cursor = Cursors.Default;
        }

        private void ProductMessageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion


        public ProductMessageForm()
        {
            InitializeComponent();
            try{
                if (SQLClass.GetSelectInList(" product ", " where idProduct = '" + BusinessClass.SelectedFromDataGridList[0] + "'", " isPrescriptionProduct ")[0] == "0")
                {
                    BackgroundGroupBox.Height = 67;
                    this.Height = 110;
                    numericUpDown.Visible = false;
                    NumberLabel.Visible = false;
                }
                List<String> series = SQLClass.GetSelectInList("`seriesproduct`",
                    attributes: " concat(idSeries,') ',ExpirationDateSeries, ' ', countProductSeries, ' шт.') ",
                    order: " ORDER BY `ExpirationDateSeries` ASC",
                    where: " where productIdSeries = " + BusinessClass.SelectedFromDataGridList[0]);

                for (Int16 i = 0; i < series.Count(); i++)
                {
                    if (BusinessClass.SeriesCountPrescriptionNumberDictionary.ContainsKey(series[i].Split(')')[0])){

                        var sr = series[i].Split(' ');
                        sr[2]=(Convert.ToInt32(sr[2])-
                            BusinessClass.SeriesCountPrescriptionNumberDictionary[series[i].Split(')')[0]][0]).ToString();
                        comboBox.Items.Add(sr[0] + ' ' + sr[1] + ' ' + sr[2] + ' ' + sr[3]);

                        
                    }else{
                        comboBox.Items.Add(series[i]);
                    }

                }
            comboBox.SelectedIndex = 0;
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
           
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ViewsClass.EnabledForm = true;
            this.Visible = false;
            ViewsClass.EnabledForm = true;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                string series = comboBox.Text.Split(')')[0];
                if (BusinessClass.SelectedFromDataGridList[10] == "1" && numericUpDown.Value == 0)
                {
                    MessageBox.Show("Данный товар является рецепторным. Пожалуйста, введите рецепторный номер.", "Информация");
                }
                else if (Convert.ToDateTime(comboBox.Text.Split(' ')[1]) <= DateTime.Today)
                {
                    MessageBox.Show("Нельзя добавить товар с истёкшим сроком годности.", "Информация");
                }
                else if (comboBox.Text.Split(' ')[2]=="0")
                {
                  MessageBox.Show("Товар данной серии закончился, невозможно добаить его к заказу.","Информация");

                }
                else
                {
                    if (BusinessClass.SeriesCountPrescriptionNumberDictionary.ContainsKey(series))
                    {
                        int[] values = BusinessClass.SeriesCountPrescriptionNumberDictionary[series];
                        values[0] += 1;
                        BusinessClass.SeriesCountPrescriptionNumberDictionary[series] = values;
                    }
                    else
                    {
                   
                        BusinessClass.SeriesCountPrescriptionNumberDictionary.Add(
                                                            series,
                                                            new int[] { 
                                                        1,
                                                        Convert.ToInt32(numericUpDown.Value)
                                                    });
                        

                    }
                    MessageBox.Show("Товар добавлен к заказу.", "Информация");

                    ViewsClass.EnabledForm = true;
                    this.Visible = false;
                    ViewsClass.EnabledForm = true;
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

      
    }
}
