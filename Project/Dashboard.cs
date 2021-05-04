using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceptionistForm
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        //This portion for hide privious form
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddDoctor().Show();
        }

        private void ShowClick(object sender, EventArgs e)
        {
            this.Hide();
            new ShowAllDoctor().Show();
        }

        private void EditClick(object sender, EventArgs e)
        {
            this.Hide();
            new EditDoctor().Show();
        }

        private void btnDeleteDoctor_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DeleteDoctor().Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
