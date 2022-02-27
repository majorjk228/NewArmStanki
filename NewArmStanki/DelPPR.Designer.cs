
namespace NewArmStanki
{
    partial class DelPPR
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.buttonEditDep = new System.Windows.Forms.Button();
            this.LabelEditDep = new System.Windows.Forms.Label();
            this.panelMainForm2Blue.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainForm2Blue
            // 
            this.panelMainForm2Blue.BackColor = System.Drawing.Color.LightGray;
            this.panelMainForm2Blue.Controls.Add(this.label1);
            this.panelMainForm2Blue.Controls.Add(this.comboBox2);
            this.panelMainForm2Blue.Controls.Add(this.buttonEditDep);
            this.panelMainForm2Blue.Controls.Add(this.LabelEditDep);
            this.panelMainForm2Blue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelMainForm2Blue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainForm2Blue.Location = new System.Drawing.Point(0, 0);
            this.panelMainForm2Blue.Name = "panelMainForm2Blue";
            this.panelMainForm2Blue.Size = new System.Drawing.Size(533, 392);
            this.panelMainForm2Blue.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(169, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Инвентарный номер";
            // 
            // comboBox2
            // 
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(76, 173);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(401, 39);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.DropDown += new System.EventHandler(this.comboBox2_DropDown);
            // 
            // buttonEditDep
            // 
            this.buttonEditDep.BackColor = System.Drawing.Color.White;
            this.buttonEditDep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditDep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(155)))), ((int)(((byte)(216)))));
            this.buttonEditDep.FlatAppearance.BorderSize = 2;
            this.buttonEditDep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(155)))), ((int)(((byte)(216)))));
            this.buttonEditDep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(155)))), ((int)(((byte)(216)))));
            this.buttonEditDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditDep.Location = new System.Drawing.Point(217, 280);
            this.buttonEditDep.Name = "buttonEditDep";
            this.buttonEditDep.Size = new System.Drawing.Size(112, 44);
            this.buttonEditDep.TabIndex = 6;
            this.buttonEditDep.Text = "Удалить";
            this.buttonEditDep.UseVisualStyleBackColor = false;
            // 
            // LabelEditDep
            // 
            this.LabelEditDep.AutoSize = true;
            this.LabelEditDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelEditDep.Location = new System.Drawing.Point(158, 29);
            this.LabelEditDep.Name = "LabelEditDep";
            this.LabelEditDep.Size = new System.Drawing.Size(236, 33);
            this.LabelEditDep.TabIndex = 0;
            this.LabelEditDep.Text = "Удалить из ППР";
            // 
            // DelPPR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 392);
            this.Controls.Add(this.panelMainForm2Blue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "DelPPR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удалить из ППР";
            this.panelMainForm2Blue.ResumeLayout(false);
            this.panelMainForm2Blue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainForm2Blue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button buttonEditDep;
        private System.Windows.Forms.Label LabelEditDep;
    }
}