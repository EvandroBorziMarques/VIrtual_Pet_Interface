using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualPet_Forms.Views;

namespace VirtualPet_Forms
{
    public partial class Pet_Form : Form
    {
        public Pet_Form()
        {
            InitializeComponent();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create_Screen frm = new Create_Screen();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }
    }
}
