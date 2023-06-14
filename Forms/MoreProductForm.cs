using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace АИС_по_ведению_БД_учета_продажи_лекарственных_препаратов.Forms
{
    using ViewsClass = Modules.ViewsClass;
    using BusinessClass = Modules.BusinessClass;
    using SQLClass = Modules.SQLClass;
    public partial class MoreProductForm : Form
    {
        String pictureName="";
        String CategotyID = "";
        
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
        private void MoreProductForm_MouseDown(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.SizeAll;
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
            this.Cursor = Cursors.Default;
        }

        private void MoreProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        #endregion
        /// <summary>
        /// <Button_Click>Buttons transitions</Button_Click>
        /// </summary>
        private void ToMenuButton_Click(object sender, EventArgs e)
        {
            if (ViewsClass.MoreProductButtonState == 4)
            {
                ListForm NewForm = new ListForm();
                this.Visible = false;
                NewForm.ShowDialog();
            }
            else {
                
                ProductForm NewForm = new ProductForm();
                this.Visible = false;
                NewForm.ShowDialog();
            }
         
        }

        public MoreProductForm()
        {
            InitializeComponent();
            List<String> category = SQLClass.GetSelectInList("`category`", attributes: " `nameСategory` ", order: " ORDER BY `nameСategory` ASC");
            for (Int16 i = 0; i < category.Count(); i++)
            {
                CategoryComboBox.Items.Add(category[i]);
            }
            CategoryComboBox.SelectedIndex=0;

            switch (ViewsClass.MoreProductButtonState) { 
            
                case 1:
                    pictureName = BusinessClass.SelectedFromDataGridList[7];
                    DeleteButton.Visible = true;
                    AddButton.Visible = false;
                    EditButton.Visible = true;

                    AddToOrderButton.Visible = false;
                    AddToSeriesButton.Visible = true;
                    OutputProduct();
                    break;
                case 2:
                    DeleteButton.Visible = false;
                    AddButton.Visible = true;
                    EditButton.Visible = false;

                    AddToOrderButton.Visible = false;
                    AddToSeriesButton.Visible = false;
                    break;
                default:
                    pictureName = BusinessClass.SelectedFromDataGridList[7];
                    DeleteButton.Visible = false;
                    AddButton.Visible = false;
                    EditButton.Visible = false;
                    ImageButton.Visible = false;

                    AddToOrderButton.Visible = true;
                    AddToSeriesButton.Visible = false;
                                        
                    NameTextBox.ReadOnly = true;
                    CategoryComboBox.Enabled = false;
                    DescriptionTextBox.ReadOnly = true;
                    ManufactureTextBox.ReadOnly = true;
                    checkBox.Enabled = false;
                    PriceUpDown.Enabled = false;
                    StorageRackUpDown.Enabled = false;
                    DiscountUpDown.Enabled = false;

                    OutputProduct();

                    break;
            }

           

            
        }
        /// <summary>Private form functions</summary>
        void OutputProduct() {
            NameTextBox.Text = BusinessClass.SelectedFromDataGridList[1];
            CategoryComboBox.SelectedItem = BusinessClass.SelectedFromDataGridList[11];
            DescriptionTextBox.Text = BusinessClass.SelectedFromDataGridList[5];
            ManufactureTextBox.Text = BusinessClass.SelectedFromDataGridList[6];
            var path = AppDomain.CurrentDomain.BaseDirectory + "\\Res\\Product\\";
            if (BusinessClass.SelectedFromDataGridList[7] == "" || BusinessClass.SelectedFromDataGridList[7] == " ")
            {
                pictureBox.Image = Properties.Resources.plug as Bitmap;
            }
            else
            {
                try
                {
                    path += BusinessClass.SelectedFromDataGridList[7];
                    pictureBox.Image = Image.FromFile(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                    pictureBox.Image = Properties.Resources.plug as Bitmap;
                }
            }
            if (BusinessClass.SelectedFromDataGridList[8] == "1")
            {
                checkBox.Checked = true;
            }
            else
            {
                checkBox.Checked = false;
            }
            PriceUpDown.Value = Convert.ToDecimal(BusinessClass.SelectedFromDataGridList[3]);
            StorageRackUpDown.Value = Convert.ToDecimal(BusinessClass.SelectedFromDataGridList[4]);
            DiscountUpDown.Value = Convert.ToDecimal(BusinessClass.SelectedFromDataGridList[9])*100;
           

        }

        Boolean DuplicateCheck() {
            try
            {
                if (SQLClass.GetSelectInList(" product ", 
                    where: "where nameProduct = '" + NameTextBox.Text + "' and "+
                    "priceProduct = '"+ PriceUpDown.Value+"' and "+
                    "categoryProduct = '"+CategotyID+"' and  "+ 
                    "descriptionProduct = '"+ DescriptionTextBox.Text +"' and "+
                    "isPrescriptionProduct = '"+ Convert.ToInt32(checkBox.Checked)+"' and "+
                    "manufacturerProduct = '" + ManufactureTextBox.Text+"'"
                ).Count !=0){
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return false;
            }
        }

        /// <summary>Function Events </summary>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var question = MessageBox.Show("Уверены, что хотите удалить данный товар? Изменения необратимы.", "Предупреждение", MessageBoxButtons.YesNo);
                if (question == DialogResult.Yes) {
                    if (SQLClass.DeleteFromDataBase(" seriesproduct ", "where productIdSeries = " + Convert.ToInt32(BusinessClass.SelectedFromDataGridList[0])))
                    {
                         MessageBox.Show("Удаление серий продукта прошло успешно!", "Информация"); 
                    } else {
                        MessageBox.Show("Произошла ошибка.\nСерия не удалёна, либо её не существовало.", "Информация");
                    }

                    if (SQLClass.DeleteFromDataBase(" product ", "where idProduct = " + Convert.ToInt32(BusinessClass.SelectedFromDataGridList[0])))
                    {
                        MessageBox.Show("Удаление прошло успешно!", "Информация");
                        ProductForm NewForm = new ProductForm();
                        this.Visible = false;
                        NewForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка.\nТовар не удалён.", "Информация");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameTextBox.Text.Replace(" ", "").Replace(" ","") == "" || PriceUpDown.Value == 0 )
                {
                    MessageBox.Show("Проверьте заполненность всех необходимых полей:\nналичие наименования, поле 'цена' не нулевое.", "Информация");
                }
                else
                {
                    DialogResult question;
                    CategotyID = SQLClass.GetSelectInList(" category ", " where nameСategory = '" + CategoryComboBox.Text + "'")[0];

                    if (DuplicateCheck())
                    { 
                        question = MessageBox.Show("Похожий товар уже существует. Вы уверены, что хотите продолжить?", "Предупреждение", MessageBoxButtons.YesNo);
                    }
                    else
                    {
                        question = MessageBox.Show("Уверены, что хотите изменить данный товар?", "Предупреждение", MessageBoxButtons.YesNo);
                    }
                    if (question == DialogResult.Yes)
                    {
                        if (pictureName != BusinessClass.SelectedFromDataGridList[7])
                        {
                            try
                            {
                                File.Copy(openFileDialog1.FileName, AppDomain.CurrentDomain.BaseDirectory + "\\Res\\Product\\" + pictureName);
                            }
                            catch
                            {
                                MessageBox.Show("Изображение не сохранено");
                                pictureName = "";
                            }
                        }
                        if (SQLClass.UpdateToDataBase(" product ",
                           "nameProduct = '" + NameTextBox.Text + "' , " +
                            "categoryProduct = '" + CategotyID + "' ," +
                            "priceProduct = '" + Convert.ToDouble(PriceUpDown.Value).ToString().Replace(',', '.') + "' , " +
                            "storageRackProduct = '" + Convert.ToDouble(StorageRackUpDown.Value) + "' , " +
                            "descriptionProduct = '" + DescriptionTextBox.Text + "' , " +
                            "manufacturerProduct = '" + ManufactureTextBox.Text + "' , " +
                            "pictureProduct = '" + pictureName + "' , " +
                            "isPrescriptionProduct = '" + Convert.ToInt32(checkBox.Checked) + "' , " +
                            "discountProduct = '" + (Convert.ToDecimal(DiscountUpDown.Value)/100).ToString().Replace(',', '.') + "'",
                            " where idProduct = " + BusinessClass.SelectedFromDataGridList[0]))
                        {
                            MessageBox.Show("Изменения сохранены!", "Информация");
                        }
                        else
                        {
                            MessageBox.Show("Произошла ошибка.\nТовар не изменён.", "Информация");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameTextBox.Text.Replace(" ", "").Replace(" ", "") == " " ||PriceUpDown.Value == 0 )
                {
                    MessageBox.Show("Проверьте заполненность всех необходимых полей:\nналичие наименования, поле 'цена' не нулевое.", "Информация");
                }
                else
                {
                    DialogResult question;
                    CategotyID = SQLClass.GetSelectInList(" category ", " where nameСategory = '" + CategoryComboBox.Text+"'")[0];

                    if (DuplicateCheck())
                    {
                        question = MessageBox.Show("Похожий товар уже существует. Вы уверены, что хотите продолжить?", "Предупреждение", MessageBoxButtons.YesNo);
                    }
                    else
                    {
                        question = MessageBox.Show("Уверены, что хотите добавить данный товар?", "Предупреждение", MessageBoxButtons.YesNo);
                    }
                    if (question == DialogResult.Yes)
                    {
                        if (pictureName != "")
                        {
                            try
                            {
                                File.Copy(openFileDialog1.FileName, AppDomain.CurrentDomain.BaseDirectory + "\\Res\\Product\\" + pictureName);
                            }
                            catch
                            {
                                MessageBox.Show("Изображение не сохранено");
                                pictureName = "";
                            }
                        }
                        BusinessClass.SelectedFromDataGridList =SQLClass.TransactionAddToDataBase1(" product ", 
                            "null, '" +
                            NameTextBox.Text + "' , '" +
                            CategotyID + "' , '" +
                            Convert.ToDouble(PriceUpDown.Value).ToString().Replace(',', '.') + "' , '" +
                            Convert.ToDouble(StorageRackUpDown.Value) + "' , '" +
                            DescriptionTextBox.Text + "' , '" +
                            ManufactureTextBox.Text + "' , '" +
                            pictureName + "' , '" +
                            Convert.ToInt32(checkBox.Checked) + "' , '" +
                            (Convert.ToDecimal(DiscountUpDown.Value) / 100).ToString().Replace(',', '.') + "'",
                            " product ", order: "ORDER BY idProduct DESC LIMIT 1"
                            );
                        if (BusinessClass.SelectedFromDataGridList.Count!=0)
                       {
                            var res = MessageBox.Show("Добавление прошло успешно!\nДобавить серию продукта?.", "Информация", MessageBoxButtons.YesNo);

                            if (res == DialogResult.Yes) {
                                ViewsClass.EnabledForm = false;
                                MoreProductMessageForm NewForm1 = new MoreProductMessageForm();
                                this.Enabled = ViewsClass.EnabledForm;
                                NewForm1.ShowDialog();
                                this.Enabled = ViewsClass.EnabledForm;

                            }
                            
                            MoreProductForm NewForm = new MoreProductForm();
                            this.Visible = false;
                            NewForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Произошла ошибка.\nТовар не добален.", "Информация");
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ImageButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureName =DateTime.Now.Ticks+ openFileDialog1.FileName.Split(new[] { '\\' }).Last();


                    pictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddToSeriesButton_Click(object sender, EventArgs e)
        {
            ViewsClass.EnabledForm = false;
            MoreProductMessageForm NewForm = new MoreProductMessageForm();
            this.Enabled = ViewsClass.EnabledForm;
            NewForm.ShowDialog();
            this.Enabled = ViewsClass.EnabledForm;

        }

        private void ManufactureTextBox_TextChanged(object sender, EventArgs e)
        {
            ManufactureTextBox.Text = ViewsClass.ToUpperString(ManufactureTextBox.Text);
            ManufactureTextBox.SelectionStart = ManufactureTextBox.Text.Length;
            ManufactureTextBox.Focus();
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            DescriptionTextBox.Text = ViewsClass.ToUpperString(DescriptionTextBox.Text);
            DescriptionTextBox.SelectionStart = DescriptionTextBox.Text.Length;
            DescriptionTextBox.Focus();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            NameTextBox.Text = ViewsClass.ToUpperString(NameTextBox.Text);
            NameTextBox.SelectionStart = NameTextBox.Text.Length;
            NameTextBox.Focus();
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (!((l >= 'А' && l <= 'я') || l == 'ё' || l == 'Ё' || l == '\b' || l == '-'
               || l == '0' || l == '1' || l == '2' || l == '3' || l == '4' || l == '5'
               || l == '6' || l == '7' || l == '8' || l == '9' || l == ' '))
            {
                e.Handled = true;
            }
        }

   


     
     

    }
}
