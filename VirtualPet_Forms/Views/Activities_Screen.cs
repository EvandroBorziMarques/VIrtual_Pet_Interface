using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VirtualPet_Forms.Models;
using System.IO;
using Newtonsoft.Json;

namespace VirtualPet_Forms.Views
{
    public partial class Activities_Screen : Form
    {
        Dog dogs;
        Cat cats;
        string path = "";
        public Activities_Screen(Dog dog)
        {
            InitializeComponent();
            dogs = dog;
            seedScreen(dogs, cats);            
        }

        public Activities_Screen(Cat cat)
        {
            InitializeComponent();
            cats = cat;
            seedScreen(dogs, cats);
        }

        private void seedScreen(Dog? dog, Cat? cat)
        {
            if (dogs != null)
            {
                name_txtbox.Text = dog.Name;
                color_txtbox.Text = dog.Color;
                weight_txtbox.Text = dog.Weight.ToString("0.00");
                height_txtbox.Text = dog.Height.ToString("0.00");
            }
            else
            {
                name_txtbox.Text = cat.Name;
                color_txtbox.Text = cat.Color;
                weight_txtbox.Text = cat.Weight.ToString("0.00");
                height_txtbox.Text = cat.Height.ToString("0.00");
            }
            
        }
        private void eat_button_Click(object sender, EventArgs e)
        {
            if(dogs != null)
            {
                dogs.comer();
            }
            else
            {
                cats.comer();
            }            
            seedScreen(dogs, cats);
        }

        private void sleep_button_Click(object sender, EventArgs e)
        {
            if (dogs != null)
            {
                dogs.dormir();
            }
            else
            {
                cats.dormir();
            }
            seedScreen(dogs, cats);
        }

        private void go_out_button_Click(object sender, EventArgs e)
        {
            if (dogs != null)
            {
                dogs.passear();
            }
            else
            {
                cats.passear();
            }
            seedScreen(dogs, cats);
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (path == "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "filtro (*.vrp) | *.vrp";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = saveFileDialog.FileName;
                }                
            }
            string data = JsonConvert.SerializeObject(dogs);
            using (StreamWriter sw = new StreamWriter(path))
            {                
                sw.Write(data);
                             
            }
        }
    }
}
