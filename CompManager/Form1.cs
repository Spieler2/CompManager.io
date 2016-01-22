using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;



namespace CompManager
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            Foo();
            progressInformation.Show();
            progressSpinner.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Programm wird beendet!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            System.Windows.Forms.Application.Exit();
        }

        private void progressSpinner_Click(object sender, EventArgs e)
        {

        }

        public async Task Foo()
        {
            progressInformation.Text = "Daten werden validiert";
            await Task.Delay(2000);
            progressInformation.Text = "Daten holen";
            await Task.Delay(2000);
            progressInformation.Text = "Login erfolgreich";

        }

    }
}
