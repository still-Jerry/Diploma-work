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
    public partial class MoreProductForm : Form
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
        /// <summary>
        /// <Button_Click>Buttons transitions</Button_Click>
        /// </summary>
        private void ToMenuButton_Click(object sender, EventArgs e)
        {
            ProductForm NewForm = new ProductForm();
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

        public MoreProductForm()
        {
            InitializeComponent();
            switch (ViewsClass.MoreProductButtonState) { 
            
                case 1:
                    DeleteButton.Visible = true;
                    AddButton.Visible = false;
                    EditButton.Visible = true;

                    AddToOrderButton.Visible = false;
                    break;
                case 2:
                    DeleteButton.Visible = false;
                    AddButton.Visible = true;
                    EditButton.Visible = false;

                    AddToOrderButton.Visible = false;

                    break;
                default:
                    DeleteButton.Visible = false;
                    AddButton.Visible = false;
                    EditButton.Visible = false;
                    ImageButton.Visible = false;

                    AddToOrderButton.Visible = true;
                    break;
            }

            List<String> category = SQLClass.GetSelectInList("`category`", attributes: " `nameСategory` ", order: " ORDER BY `nameСategory` ASC");
            for (Int16 i = 0; i < category.Count(); i++)
            {
                CategoryComboBox.Items.Add(category[i]);
            }

            OutputProduct();
        }
        /// <summary>Private form functions</summary>
        void OutputProduct() {
            NameTextBox.Text = BusinessClass.SelectedProductList[1];
            CategoryComboBox.SelectedItem = BusinessClass.SelectedProductList[12];
            ManufactureTextBox.Text = BusinessClass.SelectedProductList[7];

            var path = AppDomain.CurrentDomain.BaseDirectory + "\\Res\\Product\\";
            if (BusinessClass.SelectedProductList[8] == "" || BusinessClass.SelectedProductList[8] == " ")
            {
                pictureBox.Image = Properties.Resources.plug as Bitmap;
            }
            else
            {
                path += BusinessClass.SelectedProductList[8];
                pictureBox.Image = Image.FromFile(path);
            }
            if (BusinessClass.SelectedProductList[9] == "1")
            {
                checkBox.Checked = true;
            }
            else
            {
                checkBox.Checked = false;
            }
        }
     

    }
}
