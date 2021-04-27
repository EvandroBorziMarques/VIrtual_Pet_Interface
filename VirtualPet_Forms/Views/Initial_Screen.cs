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
using System.IO;
using Newtonsoft.Json;
using VirtualPet_Forms.Models;

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

        private void load_button_Click(object sender, EventArgs e)
        {
            string path;
            string data;

            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            path = file.FileName;

            using (StreamReader sr = new StreamReader(path))
            {
                data = sr.ReadToEnd();                              
            }
            Dog dog = JsonConvert.DeserializeObject<Dog>(data);

            this.Hide();
            Activities_Screen frm = new Activities_Screen(dog);
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }
    }
}
