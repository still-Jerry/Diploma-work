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
    public partial class SpeciallyForm : Form
    {
        public SpeciallyForm()
        {
            InitializeComponent();
        }

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

        private void ToDiscountFormButton_Click(object sender, EventArgs e)
        {
            DiscountForm NewForm = new DiscountForm();
            this.Visible = false;
            NewForm.ShowDialog();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            ViewsClass.SpeciallyFormImport = true;
            ViewsClass.EnabledForm = false;
            SpeciallyMessageForm NewForm = new SpeciallyMessageForm();
            this.Enabled = ViewsClass.EnabledForm;
            NewForm.ShowDialog();
            this.Enabled = true;
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ViewsClass.SpeciallyFormImport = false;
            ViewsClass.EnabledForm = false;
            SpeciallyMessageForm NewForm = new SpeciallyMessageForm();
            this.Enabled = ViewsClass.EnabledForm;
            NewForm.ShowDialog();
            this.Enabled = true;
        }
    }
}
