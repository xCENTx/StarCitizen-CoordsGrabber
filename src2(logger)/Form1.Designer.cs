
namespace StarCitizen_DevTool
{
    partial class Main
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
            this.X_textBox = new System.Windows.Forms.TextBox();
            this.Y_textBox = new System.Windows.Forms.TextBox();
            this.Z_textBox = new System.Windows.Forms.TextBox();
            this.tele_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.active_Panel = new System.Windows.Forms.Panel();
            this.output_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.summary_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // X_textBox
            // 
            this.X_textBox.Location = new System.Drawing.Point(39, 9);
            this.X_textBox.Name = "X_textBox";
            this.X_textBox.Size = new System.Drawing.Size(168, 20);
            this.X_textBox.TabIndex = 0;
            // 
            // Y_textBox
            // 
            this.Y_textBox.Location = new System.Drawing.Point(39, 35);
            this.Y_textBox.Name = "Y_textBox";
            this.Y_textBox.Size = new System.Drawing.Size(168, 20);
            this.Y_textBox.TabIndex = 1;
            // 
            // Z_textBox
            // 
            this.Z_textBox.Location = new System.Drawing.Point(39, 61);
            this.Z_textBox.Name = "Z_textBox";
            this.Z_textBox.Size = new System.Drawing.Size(168, 20);
            this.Z_textBox.TabIndex = 2;
            // 
            // tele_button
            // 
            this.tele_button.Location = new System.Drawing.Point(39, 87);
            this.tele_button.Name = "tele_button";
            this.tele_button.Size = new System.Drawing.Size(168, 23);
            this.tele_button.TabIndex = 3;
            this.tele_button.Text = "TEST COORDINATES";
            this.tele_button.UseVisualStyleBackColor = true;
            this.tele_button.Click += new System.EventHandler(this.tele_button_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Z_textBox);
            this.panel1.Controls.Add(this.tele_button);
            this.panel1.Controls.Add(this.X_textBox);
            this.panel1.Controls.Add(this.Y_textBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 115);
            this.panel1.TabIndex = 4;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(12, 191);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(246, 88);
            this.richTextBox.TabIndex = 4;
            this.richTextBox.Text = "";
            // 
            // active_Panel
            // 
            this.active_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.active_Panel.Location = new System.Drawing.Point(0, 282);
            this.active_Panel.Name = "active_Panel";
            this.active_Panel.Size = new System.Drawing.Size(270, 10);
            this.active_Panel.TabIndex = 5;
            // 
            // output_button
            // 
            this.output_button.Location = new System.Drawing.Point(12, 163);
            this.output_button.Name = "output_button";
            this.output_button.Size = new System.Drawing.Size(246, 23);
            this.output_button.TabIndex = 6;
            this.output_button.Text = "LOG WORKING COORDINATES";
            this.output_button.UseVisualStyleBackColor = true;
            this.output_button.Click += new System.EventHandler(this.output_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "posX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "posY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "posZ";
            // 
            // summary_textBox
            // 
            this.summary_textBox.Location = new System.Drawing.Point(80, 137);
            this.summary_textBox.Name = "summary_textBox";
            this.summary_textBox.Size = new System.Drawing.Size(178, 20);
            this.summary_textBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "SUMMARY";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 292);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.summary_textBox);
            this.Controls.Add(this.output_button);
            this.Controls.Add(this.active_Panel);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "NightCity::dev";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox X_textBox;
        private System.Windows.Forms.TextBox Y_textBox;
        private System.Windows.Forms.TextBox Z_textBox;
        private System.Windows.Forms.Button tele_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Panel active_Panel;
        private System.Windows.Forms.Button output_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox summary_textBox;
        private System.Windows.Forms.Label label4;
    }
}

