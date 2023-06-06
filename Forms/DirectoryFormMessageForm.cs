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
    using SQLClass = Modules.SQLClass;
    using ViewsClass = Modules.ViewsClass;
    using BusinessClass = Modules.BusinessClass;


    public partial class DirectoryFormMessageForm : Form
    {
        public DirectoryFormMessageForm()
        {
            InitializeComponent();
            if (!ViewsClass.DirectoryFormAdd) {
                textBox.Text = BusinessClass.SelectedFromDataGridList[1];
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox.Text.Replace(" ", "").Replace(" ", "") == "")
                {
                    MessageBox.Show("Заполните пустое поле!", "Ошибка");

                }
                else
                {
                    if (!ViewsClass.DirectoryFormAdd)
                    {
                        if (SQLClass.UpdateToDataBase(" category ", " nameСategory = '" + textBox.Text + "' ", " where idСategory = " + BusinessClass.SelectedFromDataGridList[0]))
                        {
                            MessageBox.Show("Успешное изменение категории!", "Информация");
                        }
                        else
                        {
                            MessageBox.Show("Произошла ошибка, категория не изменена!", "Информация");

                        }
                    }
                    else
                    {
                        if (SQLClass.AddToDataBase(" category ", "null, '" + textBox.Text + "'"))
                        {
                            MessageBox.Show("Успешное добавление категории!", "Информация");
                            textBox.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Произошла ошибка, категория не добавлена!", "Информация");

                        }
                    }
                }
            }
            catch { 
            
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ViewsClass.DirectoryFormAdd = true;

            ViewsClass.EnabledForm = true;
            this.Visible = false;
            ViewsClass.EnabledForm = true;
        }
    }
}
