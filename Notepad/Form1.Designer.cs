
namespace Notepad
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Boldbtn = new System.Windows.Forms.CheckBox();
            this.Fontbtn = new System.Windows.Forms.CheckBox();
            this.Colorbtn = new System.Windows.Forms.CheckBox();
            this.Cutbtn = new System.Windows.Forms.CheckBox();
            this.Pastebtn = new System.Windows.Forms.CheckBox();
            this.Copybtn = new System.Windows.Forms.CheckBox();
            this.Newbtn = new System.Windows.Forms.CheckBox();
            this.Openbtn = new System.Windows.Forms.CheckBox();
            this.Savebtn = new System.Windows.Forms.CheckBox();
            this.Exitbtn = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(707, 460);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Boldbtn
            // 
            this.Boldbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.Boldbtn.AutoSize = true;
            this.Boldbtn.Location = new System.Drawing.Point(144, 8);
            this.Boldbtn.Name = "Boldbtn";
            this.Boldbtn.Size = new System.Drawing.Size(38, 23);
            this.Boldbtn.TabIndex = 1;
            this.Boldbtn.Text = "Bold";
            this.Boldbtn.UseVisualStyleBackColor = true;
            this.Boldbtn.CheckedChanged += new System.EventHandler(this.Boldbtn_CheckedChanged);
            // 
            // Fontbtn
            // 
            this.Fontbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.Fontbtn.AutoSize = true;
            this.Fontbtn.Location = new System.Drawing.Point(188, 8);
            this.Fontbtn.Name = "Fontbtn";
            this.Fontbtn.Size = new System.Drawing.Size(38, 23);
            this.Fontbtn.TabIndex = 2;
            this.Fontbtn.Text = "Font";
            this.Fontbtn.UseVisualStyleBackColor = true;
            this.Fontbtn.CheckedChanged += new System.EventHandler(this.Fontbtn_CheckedChanged);
            // 
            // Colorbtn
            // 
            this.Colorbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.Colorbtn.AutoSize = true;
            this.Colorbtn.Location = new System.Drawing.Point(232, 8);
            this.Colorbtn.Name = "Colorbtn";
            this.Colorbtn.Size = new System.Drawing.Size(41, 23);
            this.Colorbtn.TabIndex = 3;
            this.Colorbtn.Text = "Color";
            this.Colorbtn.UseVisualStyleBackColor = true;
            this.Colorbtn.CheckedChanged += new System.EventHandler(this.Color_CheckedChanged);
            // 
            // Cutbtn
            // 
            this.Cutbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.Cutbtn.AutoSize = true;
            this.Cutbtn.Location = new System.Drawing.Point(279, 8);
            this.Cutbtn.Name = "Cutbtn";
            this.Cutbtn.Size = new System.Drawing.Size(33, 23);
            this.Cutbtn.TabIndex = 4;
            this.Cutbtn.Text = "Cut";
            this.Cutbtn.UseVisualStyleBackColor = true;
            this.Cutbtn.CheckedChanged += new System.EventHandler(this.Cutbtn_CheckedChanged);
            // 
            // Pastebtn
            // 
            this.Pastebtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.Pastebtn.AutoSize = true;
            this.Pastebtn.Location = new System.Drawing.Point(365, 8);
            this.Pastebtn.Name = "Pastebtn";
            this.Pastebtn.Size = new System.Drawing.Size(44, 23);
            this.Pastebtn.TabIndex = 5;
            this.Pastebtn.Text = "Paste";
            this.Pastebtn.UseVisualStyleBackColor = true;
            this.Pastebtn.CheckedChanged += new System.EventHandler(this.Pastebtn_CheckedChanged);
            // 
            // Copybtn
            // 
            this.Copybtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.Copybtn.AutoSize = true;
            this.Copybtn.Location = new System.Drawing.Point(318, 8);
            this.Copybtn.Name = "Copybtn";
            this.Copybtn.Size = new System.Drawing.Size(41, 23);
            this.Copybtn.TabIndex = 6;
            this.Copybtn.Text = "Copy";
            this.Copybtn.UseVisualStyleBackColor = true;
            this.Copybtn.CheckedChanged += new System.EventHandler(this.Copybtn_CheckedChanged);
            // 
            // Newbtn
            // 
            this.Newbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.Newbtn.AutoSize = true;
            this.Newbtn.Location = new System.Drawing.Point(12, 8);
            this.Newbtn.Name = "Newbtn";
            this.Newbtn.Size = new System.Drawing.Size(39, 23);
            this.Newbtn.TabIndex = 7;
            this.Newbtn.Text = "New";
            this.Newbtn.UseVisualStyleBackColor = true;
            this.Newbtn.CheckedChanged += new System.EventHandler(this.Newbtn_CheckedChanged);
            // 
            // Openbtn
            // 
            this.Openbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.Openbtn.AutoSize = true;
            this.Openbtn.Location = new System.Drawing.Point(56, 8);
            this.Openbtn.Name = "Openbtn";
            this.Openbtn.Size = new System.Drawing.Size(43, 23);
            this.Openbtn.TabIndex = 8;
            this.Openbtn.Text = "Open";
            this.Openbtn.UseVisualStyleBackColor = true;
            this.Openbtn.CheckedChanged += new System.EventHandler(this.Openbtn_CheckedChanged);
            // 
            // Savebtn
            // 
            this.Savebtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.Savebtn.AutoSize = true;
            this.Savebtn.Location = new System.Drawing.Point(100, 8);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(42, 23);
            this.Savebtn.TabIndex = 9;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.CheckedChanged += new System.EventHandler(this.Savebtn_CheckedChanged);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.Exitbtn.AutoSize = true;
            this.Exitbtn.Location = new System.Drawing.Point(415, 8);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(34, 23);
            this.Exitbtn.TabIndex = 10;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.CheckedChanged += new System.EventHandler(this.Exitbtn_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 509);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Openbtn);
            this.Controls.Add(this.Newbtn);
            this.Controls.Add(this.Copybtn);
            this.Controls.Add(this.Pastebtn);
            this.Controls.Add(this.Cutbtn);
            this.Controls.Add(this.Colorbtn);
            this.Controls.Add(this.Fontbtn);
            this.Controls.Add(this.Boldbtn);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox Boldbtn;
        private System.Windows.Forms.CheckBox Fontbtn;
        private System.Windows.Forms.CheckBox Colorbtn;
        private System.Windows.Forms.CheckBox Cutbtn;
        private System.Windows.Forms.CheckBox Pastebtn;
        private System.Windows.Forms.CheckBox Copybtn;
        private System.Windows.Forms.CheckBox Newbtn;
        private System.Windows.Forms.CheckBox Openbtn;
        private System.Windows.Forms.CheckBox Savebtn;
        private System.Windows.Forms.CheckBox Exitbtn;
    }
}

