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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.редактироватьПодразделениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьПодразделениеРемонтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьВидРемонтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMainForm2Blue = new System.Windows.Forms.Panel();
            this.panelEditDep = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panelMainForm2Blue.SuspendLayout();
            this.panelEditDep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьПодразделениеToolStripMenuItem,
            this.редактироватьПодразделениеРемонтаToolStripMenuItem,
            this.редактироватьВидРемонтаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 29);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // редактироватьПодразделениеToolStripMenuItem
            // 
            this.редактироватьПодразделениеToolStripMenuItem.Name = "редактироватьПодразделениеToolStripMenuItem";
            this.редактироватьПодразделениеToolStripMenuItem.Size = new System.Drawing.Size(243, 25);
            this.редактироватьПодразделениеToolStripMenuItem.Text = "Редактировать подразделение";
            this.редактироватьПодразделениеToolStripMenuItem.Click += new System.EventHandler(this.редактироватьПодразделениеToolStripMenuItem_Click);
            // 
            // редактироватьПодразделениеРемонтаToolStripMenuItem
            // 
            this.редактироватьПодразделениеРемонтаToolStripMenuItem.Name = "редактироватьПодразделениеРемонтаToolStripMenuItem";
            this.редактироватьПодразделениеРемонтаToolStripMenuItem.Size = new System.Drawing.Size(308, 25);
            this.редактироватьПодразделениеРемонтаToolStripMenuItem.Text = "Редактировать подразделение ремонта";
            // 
            // редактироватьВидРемонтаToolStripMenuItem
            // 
            this.редактироватьВидРемонтаToolStripMenuItem.Name = "редактироватьВидРемонтаToolStripMenuItem";
            this.редактироватьВидРемонтаToolStripMenuItem.Size = new System.Drawing.Size(224, 25);
            this.редактироватьВидРемонтаToolStripMenuItem.Text = "Редактировать вид ремонта";
            // 
            // panelMainForm2Blue
            // 
            this.panelMainForm2Blue.BackColor = System.Drawing.Color.LightGray;
            this.panelMainForm2Blue.Controls.Add(this.panelEditDep);
            this.panelMainForm2Blue.Controls.Add(this.menuStrip1);
            this.panelMainForm2Blue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainForm2Blue.Location = new System.Drawing.Point(0, 0);
            this.panelMainForm2Blue.Name = "panelMainForm2Blue";
            this.panelMainForm2Blue.Size = new System.Drawing.Size(787, 483);
            this.panelMainForm2Blue.TabIndex = 3;
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
            this.panelEditDep.Location = new System.Drawing.Point(52, 63);
            this.panelEditDep.Name = "panelEditDep";
            this.panelEditDep.Size = new System.Drawing.Size(298, 175);
            this.panelEditDep.TabIndex = 15;
            this.panelEditDep.Click += new System.EventHandler(this.pictureBox1_Click);
            this.panelEditDep.MouseLeave += new System.EventHandler(this.panelEditDep_MouseLeave);
            this.panelEditDep.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelEditDep_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Редактировать подразделение";
            this.label1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.panelEditDep_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NewArmStanki.Properties.Resources._8675174_ic_fluent_note_edit_regular_icon;
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
            this.ClientSize = new System.Drawing.Size(787, 483);
            this.Controls.Add(this.panelMainForm2Blue);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMainForm2Blue.ResumeLayout(false);
            this.panelMainForm2Blue.PerformLayout();
            this.panelEditDep.ResumeLayout(false);
            this.panelEditDep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьПодразделениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьПодразделениеРемонтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьВидРемонтаToolStripMenuItem;
        private System.Windows.Forms.Panel panelMainForm2Blue;
        private System.Windows.Forms.Panel panelEditDep;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}