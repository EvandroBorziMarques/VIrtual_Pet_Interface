
namespace VirtualPet_Forms
{
    partial class Pet_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.start_button = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.start_button.Location = new System.Drawing.Point(44, 27);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(86, 33);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // load_button
            // 
            this.load_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.load_button.Location = new System.Drawing.Point(44, 88);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(86, 33);
            this.load_button.TabIndex = 1;
            this.load_button.Text = "Load";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // Pet_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 142);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.start_button);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(197, 181);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(197, 181);
            this.Name = "Pet_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button load_button;
    }
}

