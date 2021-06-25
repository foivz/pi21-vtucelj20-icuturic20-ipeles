
namespace Projekt
{
    partial class GlavnaPocetnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaPocetnaForm));
            this.rjesavajKvizButton = new System.Windows.Forms.Button();
            this.pregledajPitanjaButton = new System.Windows.Forms.Button();
            this.statistikaButton = new System.Windows.Forms.Button();
            this.pregledajUcenikeButton = new System.Windows.Forms.Button();
            this.pregledajNastavnikeButton = new System.Windows.Forms.Button();
            this.dodajSkoluButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rjesavajKvizButton
            // 
            this.rjesavajKvizButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rjesavajKvizButton.Location = new System.Drawing.Point(22, 93);
            this.rjesavajKvizButton.Name = "rjesavajKvizButton";
            this.rjesavajKvizButton.Size = new System.Drawing.Size(144, 43);
            this.rjesavajKvizButton.TabIndex = 0;
            this.rjesavajKvizButton.Text = "Rješavaj kviz";
            this.rjesavajKvizButton.UseVisualStyleBackColor = true;
            this.rjesavajKvizButton.Click += new System.EventHandler(this.rjesavajKvizButton_Click);
            // 
            // pregledajPitanjaButton
            // 
            this.pregledajPitanjaButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pregledajPitanjaButton.Location = new System.Drawing.Point(22, 200);
            this.pregledajPitanjaButton.Name = "pregledajPitanjaButton";
            this.pregledajPitanjaButton.Size = new System.Drawing.Size(144, 43);
            this.pregledajPitanjaButton.TabIndex = 1;
            this.pregledajPitanjaButton.Text = "Pregledaj pitanja";
            this.pregledajPitanjaButton.UseVisualStyleBackColor = true;
            // 
            // statistikaButton
            // 
            this.statistikaButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statistikaButton.Location = new System.Drawing.Point(361, 93);
            this.statistikaButton.Name = "statistikaButton";
            this.statistikaButton.Size = new System.Drawing.Size(144, 43);
            this.statistikaButton.TabIndex = 2;
            this.statistikaButton.Text = "Statistika";
            this.statistikaButton.UseVisualStyleBackColor = true;
            // 
            // pregledajUcenikeButton
            // 
            this.pregledajUcenikeButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pregledajUcenikeButton.Location = new System.Drawing.Point(190, 126);
            this.pregledajUcenikeButton.Name = "pregledajUcenikeButton";
            this.pregledajUcenikeButton.Size = new System.Drawing.Size(144, 43);
            this.pregledajUcenikeButton.TabIndex = 3;
            this.pregledajUcenikeButton.Text = "Pregledaj učenike";
            this.pregledajUcenikeButton.UseVisualStyleBackColor = true;
            this.pregledajUcenikeButton.Click += new System.EventHandler(this.pregledajUcenikeButton_Click);
            // 
            // pregledajNastavnikeButton
            // 
            this.pregledajNastavnikeButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pregledajNastavnikeButton.Location = new System.Drawing.Point(190, 184);
            this.pregledajNastavnikeButton.Name = "pregledajNastavnikeButton";
            this.pregledajNastavnikeButton.Size = new System.Drawing.Size(144, 43);
            this.pregledajNastavnikeButton.TabIndex = 4;
            this.pregledajNastavnikeButton.Text = "Pregledaj nastavnike";
            this.pregledajNastavnikeButton.UseVisualStyleBackColor = true;
            // 
            // dodajSkoluButton
            // 
            this.dodajSkoluButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajSkoluButton.Location = new System.Drawing.Point(361, 200);
            this.dodajSkoluButton.Name = "dodajSkoluButton";
            this.dodajSkoluButton.Size = new System.Drawing.Size(144, 43);
            this.dodajSkoluButton.TabIndex = 5;
            this.dodajSkoluButton.Text = "Dodaj školu";
            this.dodajSkoluButton.UseVisualStyleBackColor = true;
            // 
            // GlavnaPocetnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt.Properties.Resources.a3d6c0c54caa8b169a8928c33b4c1f4d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(517, 406);
            this.Controls.Add(this.dodajSkoluButton);
            this.Controls.Add(this.pregledajNastavnikeButton);
            this.Controls.Add(this.pregledajUcenikeButton);
            this.Controls.Add(this.statistikaButton);
            this.Controls.Add(this.pregledajPitanjaButton);
            this.Controls.Add(this.rjesavajKvizButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GlavnaPocetnaForm";
            this.Text = "Početna";
            this.Load += new System.EventHandler(this.GlavnaPocetnaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rjesavajKvizButton;
        private System.Windows.Forms.Button pregledajPitanjaButton;
        private System.Windows.Forms.Button statistikaButton;
        private System.Windows.Forms.Button pregledajUcenikeButton;
        private System.Windows.Forms.Button pregledajNastavnikeButton;
        private System.Windows.Forms.Button dodajSkoluButton;
    }
}