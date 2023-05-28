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
    using ViewsClass=Modules.ViewsClass;
    using BusinessClass = Modules.BusinessClass;

    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            if (BusinessClass.UserInfoList[5] == "2")
            {
              
               this.Height = 214;
               this.Width = 257;

            }
            else {
                this.Height = 378;
                this.Width = 257;
            }
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
            else {
                this.WindowState = FormWindowState.Normal;
                ViewsClass.StateWindows = true;
            }
           
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void ToAuthorizationButton_Click(object sender, EventArgs e)
        {
            AuthorizationForm NewForm = new AuthorizationForm();
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

        private void ToProductButton_Click(object sender, EventArgs e)
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

        private void ToOrdersButton_Click(object sender, EventArgs e)
        {
            OrdersForm NewForm = new OrdersForm();
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

        private void ToSuppliersButton_Click(object sender, EventArgs e)
        {
            DirectoryForm NewForm = new DirectoryForm();
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

        private void ToUsersButton_Click(object sender, EventArgs e)
        {
            UsersForm NewForm = new UsersForm();
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

        private void ToSpeciallyButton_Click(object sender, EventArgs e)
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

        private void ToDelayButton_Click(object sender, EventArgs e)
        {
            DelayForm NewForm = new DelayForm();
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
        


       
    }
}
