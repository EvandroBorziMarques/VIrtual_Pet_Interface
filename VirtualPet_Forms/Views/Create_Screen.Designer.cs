
namespace VirtualPet_Forms.Views
{
    partial class Create_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.choice_pet_box = new System.Windows.Forms.ComboBox();
            this.escolha_pet = new System.Windows.Forms.Label();
            this.name_pet = new System.Windows.Forms.Label();
            this.name_pet_txtlabel = new System.Windows.Forms.TextBox();
            this.pet_color = new System.Windows.Forms.Label();
            this.save_pet_button = new System.Windows.Forms.Button();
            this.color_pet_box = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // choice_pet_box
            // 
            this.choice_pet_box.FormattingEnabled = true;
            this.choice_pet_box.Items.AddRange(new object[] {
            "Dog",
            "Cat"});
            this.choice_pet_box.Location = new System.Drawing.Point(34, 34);
            this.choice_pet_box.Name = "choice_pet_box";
            this.choice_pet_box.Size = new System.Drawing.Size(121, 23);
            this.choice_pet_box.TabIndex = 0;
            this.choice_pet_box.Text = "Dog";
            this.choice_pet_box.SelectedIndexChanged += new System.EventHandler(this.choice_pet_box_SelectedIndexChanged);
            // 
            // escolha_pet
            // 
            this.escolha_pet.AutoSize = true;
            this.escolha_pet.Location = new System.Drawing.Point(34, 16);
            this.escolha_pet.Name = "escolha_pet";
            this.escolha_pet.Size = new System.Drawing.Size(91, 15);
            this.escolha_pet.TabIndex = 1;
            this.escolha_pet.Text = "Choice your Pet";
            // 
            // name_pet
            // 
            this.name_pet.AutoSize = true;
            this.name_pet.Location = new System.Drawing.Point(34, 79);
            this.name_pet.Name = "name_pet";
            this.name_pet.Size = new System.Drawing.Size(86, 15);
            this.name_pet.TabIndex = 2;
            this.name_pet.Text = "Name your Pet";
            // 
            // name_pet_txtlabel
            // 
            this.name_pet_txtlabel.Location = new System.Drawing.Point(34, 97);
            this.name_pet_txtlabel.Name = "name_pet_txtlabel";
            this.name_pet_txtlabel.Size = new System.Drawing.Size(121, 23);
            this.name_pet_txtlabel.TabIndex = 3;
            this.name_pet_txtlabel.TextChanged += new System.EventHandler(this.name_pet_txtlabel_TextChanged);
            // 
            // pet_color
            // 
            this.pet_color.AutoSize = true;
            this.pet_color.Location = new System.Drawing.Point(34, 146);
            this.pet_color.Name = "pet_color";
            this.pet_color.Size = new System.Drawing.Size(83, 15);
            this.pet_color.TabIndex = 4;
            this.pet_color.Text = "Color your Pet";
            // 
            // save_pet_button
            // 
            this.save_pet_button.Location = new System.Drawing.Point(53, 213);
            this.save_pet_button.Name = "save_pet_button";
            this.save_pet_button.Size = new System.Drawing.Size(75, 23);
            this.save_pet_button.TabIndex = 6;
            this.save_pet_button.Text = "Save";
            this.save_pet_button.UseVisualStyleBackColor = true;
            this.save_pet_button.Click += new System.EventHandler(this.save_pet_button_Click);
            // 
            // color_pet_box
            // 
            this.color_pet_box.FormattingEnabled = true;
            this.color_pet_box.Items.AddRange(new object[] {
            "White",
            "Black",
            "Brown",
            "Gray"});
            this.color_pet_box.Location = new System.Drawing.Point(34, 165);
            this.color_pet_box.Name = "color_pet_box";
            this.color_pet_box.Size = new System.Drawing.Size(121, 23);
            this.color_pet_box.TabIndex = 7;
            this.color_pet_box.Text = "White";
            this.color_pet_box.SelectedIndexChanged += new System.EventHandler(this.color_pet_box_SelectedIndexChanged);
            // 
            // Create_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 243);
            this.Controls.Add(this.color_pet_box);
            this.Controls.Add(this.save_pet_button);
            this.Controls.Add(this.pet_color);
            this.Controls.Add(this.name_pet_txtlabel);
            this.Controls.Add(this.name_pet);
            this.Controls.Add(this.escolha_pet);
            this.Controls.Add(this.choice_pet_box);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(197, 282);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(197, 282);
            this.Name = "Create_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create_Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox choice_pet_box;
        private System.Windows.Forms.Label escolha_pet;
        private System.Windows.Forms.Label name_pet;
        private System.Windows.Forms.TextBox name_pet_txtlabel;
        private System.Windows.Forms.Label pet_color;
        private System.Windows.Forms.Button save_pet_button;
        private System.Windows.Forms.ComboBox color_pet_box;
    }
}