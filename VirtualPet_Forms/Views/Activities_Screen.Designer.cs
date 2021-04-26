
namespace VirtualPet_Forms.Views
{
    partial class Activities_Screen
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
            this.eat_button = new System.Windows.Forms.Button();
            this.sleep_button = new System.Windows.Forms.Button();
            this.go_out_button = new System.Windows.Forms.Button();
            this.name_lbl = new System.Windows.Forms.Label();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.color_lbl = new System.Windows.Forms.Label();
            this.color_txtbox = new System.Windows.Forms.TextBox();
            this.weight_lbl = new System.Windows.Forms.Label();
            this.weight_txtbox = new System.Windows.Forms.TextBox();
            this.height_lbl = new System.Windows.Forms.Label();
            this.height_txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // eat_button
            // 
            this.eat_button.Location = new System.Drawing.Point(225, 12);
            this.eat_button.Name = "eat_button";
            this.eat_button.Size = new System.Drawing.Size(75, 23);
            this.eat_button.TabIndex = 0;
            this.eat_button.Text = "Eat";
            this.eat_button.UseVisualStyleBackColor = true;
            // 
            // sleep_button
            // 
            this.sleep_button.Location = new System.Drawing.Point(225, 67);
            this.sleep_button.Name = "sleep_button";
            this.sleep_button.Size = new System.Drawing.Size(75, 23);
            this.sleep_button.TabIndex = 1;
            this.sleep_button.Text = "Sleep";
            this.sleep_button.UseVisualStyleBackColor = true;
            // 
            // go_out_button
            // 
            this.go_out_button.Location = new System.Drawing.Point(225, 122);
            this.go_out_button.Name = "go_out_button";
            this.go_out_button.Size = new System.Drawing.Size(75, 23);
            this.go_out_button.TabIndex = 2;
            this.go_out_button.Text = "Go Out";
            this.go_out_button.UseVisualStyleBackColor = true;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(20, 16);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(39, 15);
            this.name_lbl.TabIndex = 3;
            this.name_lbl.Text = "Name";
            // 
            // name_txtbox
            // 
            this.name_txtbox.Location = new System.Drawing.Point(74, 12);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(129, 23);
            this.name_txtbox.TabIndex = 4;
            // 
            // color_lbl
            // 
            this.color_lbl.AutoSize = true;
            this.color_lbl.Location = new System.Drawing.Point(20, 49);
            this.color_lbl.Name = "color_lbl";
            this.color_lbl.Size = new System.Drawing.Size(36, 15);
            this.color_lbl.TabIndex = 5;
            this.color_lbl.Text = "Color";
            // 
            // color_txtbox
            // 
            this.color_txtbox.Location = new System.Drawing.Point(74, 46);
            this.color_txtbox.Name = "color_txtbox";
            this.color_txtbox.Size = new System.Drawing.Size(129, 23);
            this.color_txtbox.TabIndex = 6;
            // 
            // weight_lbl
            // 
            this.weight_lbl.AutoSize = true;
            this.weight_lbl.Location = new System.Drawing.Point(20, 87);
            this.weight_lbl.Name = "weight_lbl";
            this.weight_lbl.Size = new System.Drawing.Size(45, 15);
            this.weight_lbl.TabIndex = 7;
            this.weight_lbl.Text = "Weight";
            // 
            // weight_txtbox
            // 
            this.weight_txtbox.Location = new System.Drawing.Point(74, 84);
            this.weight_txtbox.Name = "weight_txtbox";
            this.weight_txtbox.Size = new System.Drawing.Size(129, 23);
            this.weight_txtbox.TabIndex = 8;
            // 
            // height_lbl
            // 
            this.height_lbl.AutoSize = true;
            this.height_lbl.Location = new System.Drawing.Point(20, 125);
            this.height_lbl.Name = "height_lbl";
            this.height_lbl.Size = new System.Drawing.Size(43, 15);
            this.height_lbl.TabIndex = 9;
            this.height_lbl.Text = "Height";
            // 
            // height_txtbox
            // 
            this.height_txtbox.Location = new System.Drawing.Point(74, 122);
            this.height_txtbox.Name = "height_txtbox";
            this.height_txtbox.Size = new System.Drawing.Size(129, 23);
            this.height_txtbox.TabIndex = 10;
            // 
            // Activities_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 154);
            this.Controls.Add(this.height_txtbox);
            this.Controls.Add(this.height_lbl);
            this.Controls.Add(this.weight_txtbox);
            this.Controls.Add(this.weight_lbl);
            this.Controls.Add(this.color_txtbox);
            this.Controls.Add(this.color_lbl);
            this.Controls.Add(this.name_txtbox);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.go_out_button);
            this.Controls.Add(this.sleep_button);
            this.Controls.Add(this.eat_button);
            this.Name = "Activities_Screen";
            this.Text = "Activities_Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eat_button;
        private System.Windows.Forms.Button sleep_button;
        private System.Windows.Forms.Button go_out_button;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.Label color_lbl;
        private System.Windows.Forms.TextBox color_txtbox;
        private System.Windows.Forms.Label weight_lbl;
        private System.Windows.Forms.TextBox weight_txtbox;
        private System.Windows.Forms.Label height_lbl;
        private System.Windows.Forms.TextBox height_txtbox;
    }
}