
namespace Projekt
{
    partial class PopisUcenikaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopisUcenikaForm));
            this.dgvPopisUcenika = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dodajUcenikaButton = new System.Windows.Forms.Button();
            this.izbrisiUcenikaButton = new System.Windows.Forms.Button();
            this.povratakNaPocetnuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisUcenika)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPopisUcenika
            // 
            this.dgvPopisUcenika.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPopisUcenika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisUcenika.Location = new System.Drawing.Point(9, 27);
            this.dgvPopisUcenika.Name = "dgvPopisUcenika";
            this.dgvPopisUcenika.Size = new System.Drawing.Size(927, 332);
            this.dgvPopisUcenika.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popis učenika:";
            // 
            // dodajUcenikaButton
            // 
            this.dodajUcenikaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dodajUcenikaButton.BackColor = System.Drawing.Color.Transparent;
            this.dodajUcenikaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dodajUcenikaButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajUcenikaButton.Location = new System.Drawing.Point(495, 378);
            this.dodajUcenikaButton.Name = "dodajUcenikaButton";
            this.dodajUcenikaButton.Size = new System.Drawing.Size(213, 53);
            this.dodajUcenikaButton.TabIndex = 2;
            this.dodajUcenikaButton.Text = "Dodaj učenika";
            this.dodajUcenikaButton.UseVisualStyleBackColor = false;
            this.dodajUcenikaButton.Click += new System.EventHandler(this.dodajUcenikaButton_Click);
            // 
            // izbrisiUcenikaButton
            // 
            this.izbrisiUcenikaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.izbrisiUcenikaButton.BackColor = System.Drawing.Color.Transparent;
            this.izbrisiUcenikaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.izbrisiUcenikaButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izbrisiUcenikaButton.Location = new System.Drawing.Point(723, 378);
            this.izbrisiUcenikaButton.Name = "izbrisiUcenikaButton";
            this.izbrisiUcenikaButton.Size = new System.Drawing.Size(213, 53);
            this.izbrisiUcenikaButton.TabIndex = 3;
            this.izbrisiUcenikaButton.Text = "Izbriši učenika";
            this.izbrisiUcenikaButton.UseVisualStyleBackColor = false;
            this.izbrisiUcenikaButton.Click += new System.EventHandler(this.izbrisiUcenikaButton_Click);
            // 
            // povratakNaPocetnuButton
            // 
            this.povratakNaPocetnuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.povratakNaPocetnuButton.BackColor = System.Drawing.Color.Transparent;
            this.povratakNaPocetnuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.povratakNaPocetnuButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.povratakNaPocetnuButton.Location = new System.Drawing.Point(9, 396);
            this.povratakNaPocetnuButton.Name = "povratakNaPocetnuButton";
            this.povratakNaPocetnuButton.Size = new System.Drawing.Size(168, 35);
            this.povratakNaPocetnuButton.TabIndex = 4;
            this.povratakNaPocetnuButton.Text = "Povratak na početnu";
            this.povratakNaPocetnuButton.UseVisualStyleBackColor = false;
            this.povratakNaPocetnuButton.Click += new System.EventHandler(this.povratakNaPocetnuButton_Click);
            // 
            // PopisUcenikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt.Properties.Resources.a3d6c0c54caa8b169a8928c33b4c1f4d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 443);
            this.Controls.Add(this.povratakNaPocetnuButton);
            this.Controls.Add(this.izbrisiUcenikaButton);
            this.Controls.Add(this.dodajUcenikaButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPopisUcenika);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PopisUcenikaForm";
            this.Text = "Popis učenika";
            this.Load += new System.EventHandler(this.PopisUcenikaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisUcenika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPopisUcenika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodajUcenikaButton;
        private System.Windows.Forms.Button izbrisiUcenikaButton;
        private System.Windows.Forms.Button povratakNaPocetnuButton;
    }
}