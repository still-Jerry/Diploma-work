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
    public partial class ProductForm : Form
    {
        Int32 page = 1;
        Int32 rows = 0;
        Int32 allPages;

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


        /// <summary>
        /// <Button_Click>Buttons transitions</Button_Click>
        /// </summary>
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

        private void ToListButton_Click(object sender, EventArgs e)
        {

            ListForm NewForm = new ListForm();
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
                rows = ViewsClass.ViewTableWithPicturesOnDataGrid(dataGridView, RequestGetProduct(), page);
                allPages = rows % 5 > 0 ? rows / 5 + 1 : rows / 5;
                PagesLabel.Text = page + " / " + allPages;
                numericUpDown.Maximum = allPages;
                numericUpDown.Value = page;

            }

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (numericUpDown.Value != page && numericUpDown.Value!=0)
            {
                page = Convert.ToInt32(numericUpDown.Value) - 1;
            }
            if (page * 5 < rows)
            {
                page++;
                rows = ViewsClass.ViewTableWithPicturesOnDataGrid(dataGridView, RequestGetProduct(), page);
                allPages = rows % 5 > 0 ? rows / 5 + 1 : rows / 5;
                PagesLabel.Text = page + " / " + allPages;
                numericUpDown.Maximum = allPages;
                numericUpDown.Value = page;
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            rows = ViewsClass.ViewTableWithPicturesOnDataGrid(dataGridView, RequestGetProduct(), page);
            allPages = rows % 5 > 0 ? rows / 5 + 1 : rows / 5;
            PagesLabel.Text = page + " / " + allPages;
            numericUpDown.Maximum = allPages;
            numericUpDown.Value = page;
        }

        #endregion

        //тк как тут картинка надо переделать отображение , ноо будет другиЮ но код рабочий для другх таблиц, ток подумать над шапкой модет снова брать вьюшки а может просто поменять шапку 
        //void GetProduct() {
        //    try
        //    {
        //        string order, where;
        //        if (AlphabetСomboBox.SelectedItem == "по возрастанию цены")
        //        {
        //            order = " ORDER BY `priceProduct` ASC";
        //        }
        //        else
        //        {
        //            order = " ORDER BY `priceProduct` DESC";

        //        }

        //        if (SpecComboBox.SelectedItem == "Все категории")
        //        {
        //            where = "";
        //        }
        //        else
        //        {
        //            where = " where `categoryProduct` = '" + SpecComboBox.Text + "' ";
        //        }
        //        dataGridView.DataSource = SQLClass.GetSelectInDataTable("product", where: where, order: order);
        //    }
        //    catch(Exception ex) {
        //        MessageBox.Show(ex.Message, "Ошибка");
        //    }
        //}


        public ProductForm()
        {
            InitializeComponent();
            List<String> category = SQLClass.GetSelectInList("`category`", attributes: " `nameСategory` ", order: " ORDER BY `nameСategory` ASC");
            for (Int16 i = 0; i < category.Count(); i++) {
                SpecComboBox.Items.Add(category[i]);
            }
                SpecComboBox.Items.Add("Все категории");

            SpecComboBox.SelectedItem = "Все категории";

            AlphabetСomboBox.Items.Add("по возрастанию цены");
            AlphabetСomboBox.Items.Add("по убыванию цены");

            AlphabetСomboBox.SelectedIndex = 0;
          
            if (BusinessClass.UserInfoList[5] == "2")
            {
                contextMenuStrip.Items[2].Visible = false;
                AddNewProductButton.Visible = false;
            }
            else {
                contextMenuStrip.Items[2].Visible = true;
                AddNewProductButton.Visible = true;
            
            }
            
        }

        /// <summary>Private form functions</summary>
        
        DataTable RequestGetProduct()
        {
            try
            {
                string order, where;
                if (AlphabetСomboBox.SelectedItem == "по возрастанию цены")
                {
                    order = " ORDER BY `priceProduct` ASC";
                }
                else
                {
                    order = " ORDER BY `priceProduct` DESC";

                }

                if (SpecComboBox.SelectedItem == "Все категории")
                {
                    where = "";
                }
                else
                {
                    where = " where `nameСategory` = '" + SpecComboBox.Text + "' ";
                }
                return SQLClass.GetSelectInDataTable(
                    "product", 
                    where: where, 
                    order: order, 
                    attributes: " idProduct, pictureProduct, nameProduct, priceProduct, discountProduct ",
                    join: " inner join category on `product`.`categoryProduct` = `category`.`idСategory`"
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return null;
            }
        }

        /// <summary>Function Events </summary>

        private void просмотрТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessClass.SelectedFromDataGridList = SQLClass.GetSelectInList("Product",
                    where: " where idProduct = " + dataGridView.SelectedRows[0].Cells[0].Value,
                    join: " inner join category on `product`.`categoryProduct` = `category`.`idСategory`");
                ViewsClass.MoreProductButtonState = 0;
                MoreProductForm NewForm = new MoreProductForm();
                this.Visible = false;
                NewForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void редактированиеТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessClass.SelectedFromDataGridList = SQLClass.GetSelectInList("Product",
                    where: " where idProduct = " + dataGridView.SelectedRows[0].Cells[0].Value,
                    join: " inner join category on `product`.`categoryProduct` = `category`.`idСategory`");
                ViewsClass.MoreProductButtonState = 1;
                MoreProductForm NewForm = new MoreProductForm();
                this.Visible = false;
                NewForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
        private void SpecComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

           page = 1;
           rows= ViewsClass.ViewTableWithPicturesOnDataGrid(dataGridView, RequestGetProduct(), page);
           page = rows == 0 ? page = 0 : page=1;
           allPages = rows % 5 > 0 ? rows / 5 + 1 : rows / 5;
           PagesLabel.Text = page + " / " + allPages;
           numericUpDown.Maximum = allPages;
           numericUpDown.Value = page;
        }


        //сделай енаблед фолс 


        private void AddNewProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessClass.SelectedFromDataGridList = SQLClass.GetSelectInList("Product",
                    where: " where idProduct = " + dataGridView.SelectedRows[0].Cells[0].Value,
                    join: " inner join category on `product`.`categoryProduct` = `category`.`idСategory`");
                ViewsClass.MoreProductButtonState = 2;
                MoreProductForm NewForm = new MoreProductForm();
                this.Visible = false;
                NewForm.ShowDialog();
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown.Maximum = allPages;
        }

        private void добавитьКЗаказуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusinessClass.SelectedFromDataGridList = SQLClass.GetSelectInList("Product",
                    where: " where idProduct = " + dataGridView.SelectedRows[0].Cells[0].Value,
                    join: " inner join category on `product`.`categoryProduct` = `category`.`idСategory`");

            if(SQLClass.GetSelectInList("`seriesproduct`",
                attributes: " concat(idSeries,')  ',ExpirationDateSeries, ' ', countProductSeries, ' шт.') ",
                order: " ORDER BY `ExpirationDateSeries` ASC",
                where: " where productIdSeries = " + BusinessClass.SelectedFromDataGridList[0]).Count==0)
            {
                MessageBox.Show("Отсутсвуют серии продукта. Добавьте серию через меню редактироваения (администратор).", "Информация");
            }else{
                ViewsClass.EnabledForm = false;
                ProductMessageForm NewForm = new ProductMessageForm();
                this.Enabled = ViewsClass.EnabledForm;
                NewForm.ShowDialog();
                this.Enabled = true;
            }
           

        }

      


    }
}
