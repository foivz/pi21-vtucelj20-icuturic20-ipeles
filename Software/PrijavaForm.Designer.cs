
namespace Projekt
{
    partial class PrijavaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrijavaForm));
            this.ucenikBbutton = new System.Windows.Forms.Button();
            this.nastavnikButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.superadminButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ucenikBbutton
            // 
            this.ucenikBbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ucenikBbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ucenikBbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucenikBbutton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ucenikBbutton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ucenikBbutton.Location = new System.Drawing.Point(27, 129);
            this.ucenikBbutton.Name = "ucenikBbutton";
            this.ucenikBbutton.Size = new System.Drawing.Size(156, 51);
            this.ucenikBbutton.TabIndex = 0;
            this.ucenikBbutton.Text = "Učenik - testUcenik";
            this.ucenikBbutton.UseVisualStyleBackColor = false;
            this.ucenikBbutton.Click += new System.EventHandler(this.ucenikBbutton_Click);
            // 
            // nastavnikButton
            // 
            this.nastavnikButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nastavnikButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nastavnikButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nastavnikButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nastavnikButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nastavnikButton.Location = new System.Drawing.Point(212, 129);
            this.nastavnikButton.Name = "nastavnikButton";
            this.nastavnikButton.Size = new System.Drawing.Size(156, 51);
            this.nastavnikButton.TabIndex = 1;
            this.nastavnikButton.Text = "Nastavnik - brantuc1";
            this.nastavnikButton.UseVisualStyleBackColor = false;
            this.nastavnikButton.Click += new System.EventHandler(this.nastavnikButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.adminButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adminButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adminButton.Location = new System.Drawing.Point(27, 199);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(156, 51);
            this.adminButton.TabIndex = 2;
            this.adminButton.Text = "Admin - marspernj";
            this.adminButton.UseVisualStyleBackColor = false;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // superadminButton
            // 
            this.superadminButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.superadminButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.superadminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.superadminButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.superadminButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.superadminButton.Location = new System.Drawing.Point(212, 199);
            this.superadminButton.Name = "superadminButton";
            this.superadminButton.Size = new System.Drawing.Size(156, 51);
            this.superadminButton.TabIndex = 3;
            this.superadminButton.Text = "Superadmin - vtucelj20";
            this.superadminButton.UseVisualStyleBackColor = false;
            this.superadminButton.Click += new System.EventHandler(this.superadminButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(89, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prijava korisnika";
            // 
            // PrijavaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt.Properties.Resources.a3d6c0c54caa8b169a8928c33b4c1f4d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(413, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.superadminButton);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.nastavnikButton);
            this.Controls.Add(this.ucenikBbutton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrijavaForm";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ucenikBbutton;
        private System.Windows.Forms.Button nastavnikButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button superadminButton;
        private System.Windows.Forms.Label label1;
    }
}