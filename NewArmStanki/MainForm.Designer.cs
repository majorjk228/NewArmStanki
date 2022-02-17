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
            this.panelMainForm.SuspendLayout();
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
            this.panelMainForm2Blue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainForm2Blue.Location = new System.Drawing.Point(0, 107);
            this.panelMainForm2Blue.Name = "panelMainForm2Blue";
            this.panelMainForm2Blue.Size = new System.Drawing.Size(800, 380);
            this.panelMainForm2Blue.TabIndex = 3;
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
            this.panelMainForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainForm;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label labelMainForm;
        private System.Windows.Forms.Panel panelMainForm2Blue;
    }
}