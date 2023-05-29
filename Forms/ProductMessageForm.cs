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

    public partial class ProductMessageForm : Form
    {

        public ProductMessageForm()
        {
            InitializeComponent();
            if (SQLClass.GetSelectInList(" product ", " where idProduct = '" + BusinessClass.SelectedFromDataGridList[0] + "'", " isPrescriptionProduct ")[0] == "0")
            {
                BackgroundGroupBox.Height = 67;
                this.Height = 110;
                numericUpDown.Visible = false;
                NumberLabel.Visible = false;
            }
            List<String> series = SQLClass.GetSelectInList("`seriesproduct`",
                attributes: " concat(idSeries,')  ',ExpirationDateSeries, ' ', countProductSeries, ' шт.') ",
                order: " ORDER BY `ExpirationDateSeries` ASC",
                where: " where productIdSeries = " + BusinessClass.SelectedFromDataGridList[0]);

            for (Int16 i = 0; i < series.Count(); i++)
            {
                comboBox.Items.Add(series[i]);
            }
            if (comboBox.Items.Count == 0)
            {
                MessageBox.Show("Отсутсвуют серии продукта. Добавьте серию через меню редактироваения (администратор).", "Информация");
                ViewsClass.EnabledForm = true;
                this.Visible = false;
                ViewsClass.EnabledForm = true;
            }
            else {
                comboBox.SelectedIndex = 0;
            
            }
           
        }
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
        #endregion

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ViewsClass.EnabledForm = true;
            this.Visible = false;
            ViewsClass.EnabledForm = true;
        }

      
    }
}
