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
            this.panelMainForm = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.labelMainForm = new System.Windows.Forms.Label();
            this.panelMainForm2Blue = new System.Windows.Forms.Panel();
            this.buttonEditDep = new System.Windows.Forms.Button();
            this.textBoxEditDep = new System.Windows.Forms.TextBox();
            this.LabelEditDep = new System.Windows.Forms.Label();
            this.panelMainForm.SuspendLayout();
            this.panelMainForm2Blue.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainForm
            // 
            this.panelMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(210)))), ((int)(((byte)(165)))));
            this.panelMainForm.Controls.Add(this.CloseButton);
            this.panelMainForm.Controls.Add(this.labelMainForm);
            this.panelMainForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainForm.Location = new System.Drawing.Point(0, 0);
            this.panelMainForm.Name = "panelMainForm";
            this.panelMainForm.Size = new System.Drawing.Size(800, 107);
            this.panelMainForm.TabIndex = 2;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(0, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 23);
            this.CloseButton.TabIndex = 0;
            // 
            // labelMainForm
            // 
            this.labelMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMainForm.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelMainForm.Location = new System.Drawing.Point(0, 0);
            this.labelMainForm.Name = "labelMainForm";
            this.labelMainForm.Size = new System.Drawing.Size(800, 107);
            this.labelMainForm.TabIndex = 0;
            this.labelMainForm.Text = "Главный экран";
            this.labelMainForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMainForm2Blue
            // 
            this.panelMainForm2Blue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(208)))));
            this.panelMainForm2Blue.Controls.Add(this.buttonEditDep);
            this.panelMainForm2Blue.Controls.Add(this.textBoxEditDep);
            this.panelMainForm2Blue.Controls.Add(this.LabelEditDep);
            this.panelMainForm2Blue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainForm2Blue.Location = new System.Drawing.Point(0, 107);
            this.panelMainForm2Blue.Name = "panelMainForm2Blue";
            this.panelMainForm2Blue.Size = new System.Drawing.Size(800, 380);
            this.panelMainForm2Blue.TabIndex = 3;
            // 
            // buttonEditDep
            // 
            this.buttonEditDep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditDep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(210)))), ((int)(((byte)(165)))));
            this.buttonEditDep.FlatAppearance.BorderSize = 2;
            this.buttonEditDep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonEditDep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(210)))), ((int)(((byte)(165)))));
            this.buttonEditDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditDep.Location = new System.Drawing.Point(435, 60);
            this.buttonEditDep.Name = "buttonEditDep";
            this.buttonEditDep.Size = new System.Drawing.Size(112, 44);
            this.buttonEditDep.TabIndex = 6;
            this.buttonEditDep.Text = "Изменить";
            this.buttonEditDep.UseVisualStyleBackColor = true;
            // 
            // textBoxEditDep
            // 
            this.textBoxEditDep.Location = new System.Drawing.Point(12, 60);
            this.textBoxEditDep.Multiline = true;
            this.textBoxEditDep.Name = "textBoxEditDep";
            this.textBoxEditDep.Size = new System.Drawing.Size(401, 44);
            this.textBoxEditDep.TabIndex = 1;
            // 
            // LabelEditDep
            // 
            this.LabelEditDep.AutoSize = true;
            this.LabelEditDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelEditDep.Location = new System.Drawing.Point(12, 15);
            this.LabelEditDep.Name = "LabelEditDep";
            this.LabelEditDep.Size = new System.Drawing.Size(407, 31);
            this.LabelEditDep.TabIndex = 0;
            this.LabelEditDep.Text = "Редактировать подразделение";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.panelMainForm2Blue);
            this.Controls.Add(this.panelMainForm);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panelMainForm.ResumeLayout(false);
            this.panelMainForm2Blue.ResumeLayout(false);
            this.panelMainForm2Blue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainForm;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label labelMainForm;
        private System.Windows.Forms.Panel panelMainForm2Blue;
        private System.Windows.Forms.Label LabelEditDep;
        private System.Windows.Forms.TextBox textBoxEditDep;
        private System.Windows.Forms.Button buttonEditDep;
    }
}