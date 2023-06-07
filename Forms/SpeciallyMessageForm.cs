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

    public partial class SpeciallyMessageForm : Form
    {
        public SpeciallyMessageForm()
        {
            InitializeComponent();
            List<String> tables = SQLClass.RequestInListRows("Show tables;");
            for (Int16 i = 0; i < tables.Count(); i++)
            {
                comboBox.Items.Add(tables[i]);
            }
            comboBox.SelectedIndex = 0;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ViewsClass.SpeciallyFormImport = true;
            ViewsClass.EnabledForm = true;
            this.Visible = false;
            ViewsClass.EnabledForm = true;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (ViewsClass.SpeciallyFormImport)
            {

            }
            else {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    if (BusinessClass.ExportTable(SQLClass.GetSelectInDataTable(comboBox.Text), comboBox.Text, folderBrowserDialog.SelectedPath+"\\"))
                    {
                        MessageBox.Show("Экспорт произошёл успешно!", "Информация");
                    }
                    else
                    {
                        MessageBox.Show("Ошибка экспортирования.", "Ошибка");
                    }
                }
              
            }
        }
    }
}
