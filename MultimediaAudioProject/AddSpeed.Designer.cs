
namespace MultimediaAudioProject
{
    partial class AddSpeed
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.slowlb = new System.Windows.Forms.Label();
            this.fastlbl = new System.Windows.Forms.Label();
            this.ratio = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
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
            this.Header.TabIndex = 0;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseHover += new System.EventHandler(this.Header_MouseHover);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
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
            this.Add.Location = new System.Drawing.Point(105, 171);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(134, 55);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(79, 87);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(196, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // slowlb
            // 
            this.slowlb.AutoSize = true;
            this.slowlb.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slowlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.slowlb.Location = new System.Drawing.Point(269, 87);
            this.slowlb.Name = "slowlb";
            this.slowlb.Size = new System.Drawing.Size(50, 21);
            this.slowlb.TabIndex = 3;
            this.slowlb.Text = "Slow";
            // 
            // fastlbl
            // 
            this.fastlbl.AutoSize = true;
            this.fastlbl.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.fastlbl.Location = new System.Drawing.Point(23, 87);
            this.fastlbl.Name = "fastlbl";
            this.fastlbl.Size = new System.Drawing.Size(50, 21);
            this.fastlbl.TabIndex = 4;
            this.fastlbl.Text = "Fast";
            // 
            // ratio
            // 
            this.ratio.AutoSize = true;
            this.ratio.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratio.Location = new System.Drawing.Point(170, 113);
            this.ratio.Name = "ratio";
            this.ratio.Size = new System.Drawing.Size(18, 19);
            this.ratio.TabIndex = 20;
            this.ratio.Text = "1";
            // 
            // AddSpeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(340, 238);
            this.Controls.Add(this.ratio);
            this.Controls.Add(this.fastlbl);
            this.Controls.Add(this.slowlb);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Header);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddSpeed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSpeed";
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label slowlb;
        private System.Windows.Forms.Label fastlbl;
        private System.Windows.Forms.Label ratio;
    }
}