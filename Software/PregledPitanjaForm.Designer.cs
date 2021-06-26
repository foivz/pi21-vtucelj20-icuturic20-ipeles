
namespace Projekt
{
    partial class PregledPitanjaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledPitanjaForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPitanjaOdgovori = new System.Windows.Forms.DataGridView();
            this.izbrisiPitanjeButton = new System.Windows.Forms.Button();
            this.azurirajPitanjeButton = new System.Windows.Forms.Button();
            this.dodajNovoPitanjeButton = new System.Windows.Forms.Button();
            this.cjelinaLabel = new System.Windows.Forms.Label();
            this.ispitLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPitanjaOdgovori)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Popis pitanja i odgovora za cjelinu:";
            // 
            // dgvPitanjaOdgovori
            // 
            this.dgvPitanjaOdgovori.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPitanjaOdgovori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPitanjaOdgovori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPitanjaOdgovori.Location = new System.Drawing.Point(9, 60);
            this.dgvPitanjaOdgovori.Name = "dgvPitanjaOdgovori";
            this.dgvPitanjaOdgovori.Size = new System.Drawing.Size(849, 304);
            this.dgvPitanjaOdgovori.TabIndex = 1;
            // 
            // izbrisiPitanjeButton
            // 
            this.izbrisiPitanjeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.izbrisiPitanjeButton.BackColor = System.Drawing.Color.Transparent;
            this.izbrisiPitanjeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.izbrisiPitanjeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.izbrisiPitanjeButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izbrisiPitanjeButton.Location = new System.Drawing.Point(312, 370);
            this.izbrisiPitanjeButton.Name = "izbrisiPitanjeButton";
            this.izbrisiPitanjeButton.Size = new System.Drawing.Size(178, 49);
            this.izbrisiPitanjeButton.TabIndex = 2;
            this.izbrisiPitanjeButton.Text = "Izbriši pitanje";
            this.izbrisiPitanjeButton.UseVisualStyleBackColor = false;
            this.izbrisiPitanjeButton.Click += new System.EventHandler(this.izbrisiPitanjeButton_Click);
            // 
            // azurirajPitanjeButton
            // 
            this.azurirajPitanjeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.azurirajPitanjeButton.BackColor = System.Drawing.Color.Transparent;
            this.azurirajPitanjeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.azurirajPitanjeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.azurirajPitanjeButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.azurirajPitanjeButton.Location = new System.Drawing.Point(496, 370);
            this.azurirajPitanjeButton.Name = "azurirajPitanjeButton";
            this.azurirajPitanjeButton.Size = new System.Drawing.Size(178, 49);
            this.azurirajPitanjeButton.TabIndex = 3;
            this.azurirajPitanjeButton.Text = "Ažuriraj pitanje";
            this.azurirajPitanjeButton.UseVisualStyleBackColor = false;
            this.azurirajPitanjeButton.Click += new System.EventHandler(this.azurirajPitanjeButton_Click);
            // 
            // dodajNovoPitanjeButton
            // 
            this.dodajNovoPitanjeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dodajNovoPitanjeButton.BackColor = System.Drawing.Color.Transparent;
            this.dodajNovoPitanjeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dodajNovoPitanjeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dodajNovoPitanjeButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajNovoPitanjeButton.Location = new System.Drawing.Point(680, 370);
            this.dodajNovoPitanjeButton.Name = "dodajNovoPitanjeButton";
            this.dodajNovoPitanjeButton.Size = new System.Drawing.Size(178, 49);
            this.dodajNovoPitanjeButton.TabIndex = 4;
            this.dodajNovoPitanjeButton.Text = "Dodaj novo pitanje";
            this.dodajNovoPitanjeButton.UseVisualStyleBackColor = false;
            this.dodajNovoPitanjeButton.Click += new System.EventHandler(this.dodajNovoPitanjeButton_Click);
            // 
            // cjelinaLabel
            // 
            this.cjelinaLabel.AutoSize = true;
            this.cjelinaLabel.BackColor = System.Drawing.Color.Transparent;
            this.cjelinaLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cjelinaLabel.Location = new System.Drawing.Point(184, 28);
            this.cjelinaLabel.Name = "cjelinaLabel";
            this.cjelinaLabel.Size = new System.Drawing.Size(45, 19);
            this.cjelinaLabel.TabIndex = 5;
            this.cjelinaLabel.Text = "label2";
            // 
            // ispitLabel
            // 
            this.ispitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ispitLabel.AutoSize = true;
            this.ispitLabel.BackColor = System.Drawing.Color.Transparent;
            this.ispitLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ispitLabel.Location = new System.Drawing.Point(694, 28);
            this.ispitLabel.Name = "ispitLabel";
            this.ispitLabel.Size = new System.Drawing.Size(45, 19);
            this.ispitLabel.TabIndex = 7;
            this.ispitLabel.Text = "label3";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(647, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "ispit:";
            // 
            // PregledPitanjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt.Properties.Resources.a3d6c0c54caa8b169a8928c33b4c1f4d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 431);
            this.Controls.Add(this.ispitLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cjelinaLabel);
            this.Controls.Add(this.dodajNovoPitanjeButton);
            this.Controls.Add(this.azurirajPitanjeButton);
            this.Controls.Add(this.izbrisiPitanjeButton);
            this.Controls.Add(this.dgvPitanjaOdgovori);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PregledPitanjaForm";
            this.Text = "Pregled pitanja";
            this.Load += new System.EventHandler(this.PregledPitanjaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPitanjaOdgovori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPitanjaOdgovori;
        private System.Windows.Forms.Button izbrisiPitanjeButton;
        private System.Windows.Forms.Button azurirajPitanjeButton;
        private System.Windows.Forms.Button dodajNovoPitanjeButton;
        private System.Windows.Forms.Label cjelinaLabel;
        private System.Windows.Forms.Label ispitLabel;
        private System.Windows.Forms.Label label4;
    }
}