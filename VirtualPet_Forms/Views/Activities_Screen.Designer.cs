
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
            this.SuspendLayout();
            // 
            // eat_button
            // 
            this.eat_button.Location = new System.Drawing.Point(318, 36);
            this.eat_button.Name = "eat_button";
            this.eat_button.Size = new System.Drawing.Size(75, 23);
            this.eat_button.TabIndex = 0;
            this.eat_button.Text = "Eat";
            this.eat_button.UseVisualStyleBackColor = true;
            // 
            // sleep_button
            // 
            this.sleep_button.Location = new System.Drawing.Point(318, 84);
            this.sleep_button.Name = "sleep_button";
            this.sleep_button.Size = new System.Drawing.Size(75, 23);
            this.sleep_button.TabIndex = 1;
            this.sleep_button.Text = "Sleep";
            this.sleep_button.UseVisualStyleBackColor = true;
            // 
            // go_out_button
            // 
            this.go_out_button.Location = new System.Drawing.Point(318, 139);
            this.go_out_button.Name = "go_out_button";
            this.go_out_button.Size = new System.Drawing.Size(75, 23);
            this.go_out_button.TabIndex = 2;
            this.go_out_button.Text = "Go Out";
            this.go_out_button.UseVisualStyleBackColor = true;
            // 
            // Activities_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 182);
            this.Controls.Add(this.go_out_button);
            this.Controls.Add(this.sleep_button);
            this.Controls.Add(this.eat_button);
            this.Name = "Activities_Screen";
            this.Text = "Activities_Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button eat_button;
        private System.Windows.Forms.Button sleep_button;
        private System.Windows.Forms.Button go_out_button;
    }
}