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
    using BusinessClass = Modules.BusinessClass;
    using ViewsClass = Modules.ViewsClass;
    public partial class CaptchaForm : Form
    {
        

        public CaptchaForm()
        {
            InitializeComponent();
            string ALF = "1234567890abcdefghijklmnopqrstuvwxyz";
            Random rnd = new Random();
            label1.Text = ALF[rnd.Next(ALF.Length)].ToString();
            label2.Text = ALF[rnd.Next(ALF.Length)].ToString();
            label3.Text = ALF[rnd.Next(ALF.Length)].ToString();
            label4.Text = ALF[rnd.Next(ALF.Length)].ToString();
            label5.Text = ALF[rnd.Next(ALF.Length)].ToString();
        }
       

        private void NewButton_Click(object sender, EventArgs e)
        {
            string ALF = "1234567890abcdefghijklmnopqrstuvwxyz";
            Random rnd = new Random();
            label1.Text = ALF[rnd.Next(ALF.Length)].ToString();
            label2.Text = ALF[rnd.Next(ALF.Length)].ToString();
            label3.Text = ALF[rnd.Next(ALF.Length)].ToString();
            label4.Text = ALF[rnd.Next(ALF.Length)].ToString();
            label5.Text = ALF[rnd.Next(ALF.Length)].ToString();

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text == label1.Text + label2.Text + label3.Text + label4.Text + label5.Text)
            {
                ViewsClass.EnabledForm = true;
                this.Visible = false;
                ViewsClass.EnabledForm = true;
            }
        }

        
    }
}
