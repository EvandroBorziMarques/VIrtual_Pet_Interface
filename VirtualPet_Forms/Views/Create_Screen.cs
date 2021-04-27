using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VirtualPet_Forms.Models;


namespace VirtualPet_Forms.Views
{
    public partial class Create_Screen : Form
    {
        public Create_Screen()
        {
            InitializeComponent();
        }

        private void choice_pet_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void name_pet_txtlabel_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void color_pet_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void create_pet_button_Click(object sender, EventArgs e)
        {
            string typePet = choice_pet_box.Text;
            string namePet = name_pet_txtlabel.Text;
            string colorPet = color_pet_box.Text;

            typePet = typePet.ToLower();

            if (typePet == "dog")
            {
                Dog dog = new Dog(namePet, colorPet);

                this.Hide();
                Activities_Screen frm = new Activities_Screen(dog);
                frm.Closed += (s, args) => this.Close();
                frm.Show();
                
            }
            else if (typePet == "cat")
            {
                Cat cat = new Cat(namePet, colorPet);

                this.Hide();
                Activities_Screen frm = new Activities_Screen(cat);
                frm.Closed += (s, args) => this.Close();
                frm.Show();
            }

        }
    }
}
