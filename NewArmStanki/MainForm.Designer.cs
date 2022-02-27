namespace NewArmStanki
{
    partial class MainForm
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
            this.panelMainForm2Blue = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelEditDep = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMainForm2Blue.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelEditDep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainForm2Blue
            // 
            this.panelMainForm2Blue.BackColor = System.Drawing.Color.LightGray;
            this.panelMainForm2Blue.Controls.Add(this.panel2);
            this.panelMainForm2Blue.Controls.Add(this.panel1);
            this.panelMainForm2Blue.Controls.Add(this.panelEditDep);
            this.panelMainForm2Blue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainForm2Blue.Location = new System.Drawing.Point(0, 0);
            this.panelMainForm2Blue.Name = "panelMainForm2Blue";
            this.panelMainForm2Blue.Size = new System.Drawing.Size(1113, 426);
            this.panelMainForm2Blue.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.AccessibleDescription = "";
            this.panel2.AccessibleName = "";
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(751, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 175);
            this.panel2.TabIndex = 16;
            this.panel2.Click += new System.EventHandler(this.pictureBox3_Click);
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(112, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Удалить из ППР";
            this.label3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.label3.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::NewArmStanki.Properties.Resources.dele;
            this.pictureBox3.Location = new System.Drawing.Point(116, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 92);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = "";
            this.panel1.AccessibleName = "";
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(378, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 175);
            this.panel1.TabIndex = 16;
            this.panel1.Click += new System.EventHandler(this.pictureBox2_Click);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Редактировать обслуживающее подразделение";
            this.label2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.label2.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NewArmStanki.Properties.Resources._8675174_ic_fluent_note_edit_regular_icon;
            this.pictureBox2.Location = new System.Drawing.Point(125, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panelEditDep
            // 
            this.panelEditDep.AccessibleDescription = "";
            this.panelEditDep.AccessibleName = "";
            this.panelEditDep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelEditDep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEditDep.Controls.Add(this.label1);
            this.panelEditDep.Controls.Add(this.pictureBox1);
            this.panelEditDep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelEditDep.Location = new System.Drawing.Point(37, 95);
            this.panelEditDep.Name = "panelEditDep";
            this.panelEditDep.Size = new System.Drawing.Size(315, 175);
            this.panelEditDep.TabIndex = 15;
            this.panelEditDep.Click += new System.EventHandler(this.pictureBox1_Click);
            this.panelEditDep.MouseLeave += new System.EventHandler(this.panelEditDep_MouseLeave);
            this.panelEditDep.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelEditDep_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Редактировать ремонтное подразделение";
            this.label1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.panelEditDep_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NewArmStanki.Properties.Resources.meh;
            this.pictureBox1.Location = new System.Drawing.Point(99, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.panelEditDep_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelEditDep_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 426);
            this.Controls.Add(this.panelMainForm2Blue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panelMainForm2Blue.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelEditDep.ResumeLayout(false);
            this.panelEditDep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMainForm2Blue;
        private System.Windows.Forms.Panel panelEditDep;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}