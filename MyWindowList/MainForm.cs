using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowList
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnContactView_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm();
            contactForm.ShowDialog();
        }

        private void mFileExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void mHelpContacts_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm();
            contactForm.ShowDialog();

        }


        private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            using (ExitForm exitWindow = new ExitForm())
            {
                DialogResult result = exitWindow.ShowDialog();

                if (result == DialogResult.No)
                {

                    e.Cancel = true;
                }
                else
                {
                     Application.ExitThread();
                   
                }
            }
        }
    }
}
