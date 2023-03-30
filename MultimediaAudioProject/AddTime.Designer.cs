
namespace MultimediaAudioProject
{
    partial class AddTime
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
            System.Windows.Forms.Button button2;
            this.Header = new System.Windows.Forms.Panel();
            this.Add = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            button2 = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            button2.Location = new System.Drawing.Point(302, 0);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(38, 31);
            button2.TabIndex = 0;
            button2.Text = "✖";
            button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.Header.Controls.Add(button2);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(340, 25);
            this.Header.TabIndex = 1;
            this.Header.MouseLeave += new System.EventHandler(this.Header_MouseLeave);
            this.Header.MouseHover += new System.EventHandler(this.Header_MouseHover);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(81)))), ((int)(((byte)(105)))));
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.Add.Location = new System.Drawing.Point(111, 164);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(134, 55);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.lbl.Location = new System.Drawing.Point(124, 63);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(90, 21);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "Add Time";
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.time.CausesValidation = false;
            this.time.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(85, 110);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(172, 22);
            this.time.TabIndex = 6;
            this.time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.time_KeyPress);
            // 
            // AddTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(340, 238);
            this.Controls.Add(this.time);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTime";
            this.Load += new System.EventHandler(this.AddTime_Load);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox time;
    }
}