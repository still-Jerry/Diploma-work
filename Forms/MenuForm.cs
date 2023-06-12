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
    using ViewsClass=Modules.ViewsClass;
    using BusinessClass = Modules.BusinessClass;

    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            if (BusinessClass.UserInfoList[5] == "2")
            {
              
               this.Height = 205;
               this.Width = 257;

            }
            else {
                this.Height = 300;
                this.Width = 257;
            }
            timer1.Start();
        }
        #region Typical events of all forms
        private void MenuForm_MouseDown(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.SizeAll;
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
            this.Cursor = Cursors.Default;
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
        private void ToProductButton_Click(object sender, EventArgs e)
        {
            ProductForm NewForm = new ProductForm();
            this.Visible = false;
            NewForm.ShowDialog();
            
        }

        private void ToOrdersButton_Click(object sender, EventArgs e)
        {
            OrdersForm NewForm = new OrdersForm();
            this.Visible = false;
            NewForm.ShowDialog();
            

        }

        private void ToSuppliersButton_Click(object sender, EventArgs e)
        {
            DirectoryForm NewForm = new DirectoryForm();
            this.Visible = false;
            NewForm.ShowDialog();
            

        }



        private void ToSpeciallyButton_Click(object sender, EventArgs e)
        {
            SpeciallyForm NewForm = new SpeciallyForm();
            this.Visible = false;
            NewForm.ShowDialog();
            

        }






       
    }
}
