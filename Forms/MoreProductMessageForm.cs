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
    public partial class MoreProductMessageForm : Form
    {
       

        public MoreProductMessageForm()
        {
            InitializeComponent();
            if (!ViewsClass.DirectoryFormAdd) {
                dateTimePicker.Value = Convert.ToDateTime(BusinessClass.SelectedFromDataGridList[2]);
                numericUpDown.Value = Convert.ToDecimal(BusinessClass.SelectedFromDataGridList[3]);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ViewsClass.DirectoryFormAdd = true;

            ViewsClass.EnabledForm = true;
            this.Visible = false;
            ViewsClass.EnabledForm = true;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (numericUpDown.Value == 0)
            {
                MessageBox.Show("Количество продуктов в серии должно быть больше 0.", "Информация");
            }
            else
            {
                if (!ViewsClass.DirectoryFormAdd)
                {
                    if (SQLClass.UpdateToDataBase("  seriesproduct ", " countProductSeries = '"+numericUpDown.Value+"', " +
                        " expirationDateSeries = '" + dateTimePicker.Value.Year + "." + dateTimePicker.Value.Month + "." + dateTimePicker.Value.Day+"' ",
                        " where idSeries = " + BusinessClass.SelectedFromDataGridList[0]))
                    {
                        MessageBox.Show("Успешное изменение серии!", "Информация");
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка. Серия не изменена.", "Информация");

                    }
                }
                else
                {
                    if (SQLClass.AddToDataBase("  seriesproduct ", " null, " + BusinessClass.SelectedFromDataGridList[0] + ", '" +
                    dateTimePicker.Value.Year + "." + dateTimePicker.Value.Month + "." + dateTimePicker.Value.Day + "', " + numericUpDown.Value))
                    {
                        MessageBox.Show("Успешное добаление серии!", "Информация");
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка. Серия не добавлена.", "Информация");

                    }
                    dateTimePicker.Value = DateTime.Now.Date;
                    numericUpDown.Value = 0;
                }
            }
        }
    }
}
