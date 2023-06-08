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

    using ViewsClass = Modules.ViewsClass;
    public partial class OrdersMessageForm : Form
    {
        public static String start;
        public static String end;

        /// <summary> Inactivity Tracking </summary>

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (GetIdleTime() >= 60000)
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


        private void OrdersMessageForm_MouseDown(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.SizeAll;
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
            this.Cursor = Cursors.Default;
        }

        private void OrdersMessageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public OrdersMessageForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (StartDateTimePicker.Value >= EndDateTimePicker.Value)
            {
                MessageBox.Show("Дата начала периода должна быть меньше дады конца", "Инфомация");
            }
            else {
                start = StartDateTimePicker.Value.Year + "." + StartDateTimePicker.Value.Month + "." + StartDateTimePicker.Value.Day;
                end = EndDateTimePicker.Value.Year + "." + EndDateTimePicker.Value.Month + "." + EndDateTimePicker.Value.Day;
                ViewsClass.EnabledForm = true;
                this.Visible = false;
                ViewsClass.EnabledForm = true;
            }
        }

    }
}
