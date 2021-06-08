
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisUcenika)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPopisUcenika
            // 
            this.dgvPopisUcenika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisUcenika.Location = new System.Drawing.Point(9, 27);
            this.dgvPopisUcenika.Name = "dgvPopisUcenika";
            this.dgvPopisUcenika.Size = new System.Drawing.Size(584, 266);
            this.dgvPopisUcenika.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popis učenika:";
            // 
            // dodajUcenikaButton
            // 
            this.dodajUcenikaButton.Location = new System.Drawing.Point(39, 319);
            this.dodajUcenikaButton.Name = "dodajUcenikaButton";
            this.dodajUcenikaButton.Size = new System.Drawing.Size(213, 53);
            this.dodajUcenikaButton.TabIndex = 2;
            this.dodajUcenikaButton.Text = "Dodaj učenika";
            this.dodajUcenikaButton.UseVisualStyleBackColor = true;
            // 
            // izbrisiUcenikaButton
            // 
            this.izbrisiUcenikaButton.Location = new System.Drawing.Point(353, 319);
            this.izbrisiUcenikaButton.Name = "izbrisiUcenikaButton";
            this.izbrisiUcenikaButton.Size = new System.Drawing.Size(213, 53);
            this.izbrisiUcenikaButton.TabIndex = 3;
            this.izbrisiUcenikaButton.Text = "Izbriši učenika";
            this.izbrisiUcenikaButton.UseVisualStyleBackColor = true;
            // 
            // PopisUcenikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 387);
            this.Controls.Add(this.izbrisiUcenikaButton);
            this.Controls.Add(this.dodajUcenikaButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPopisUcenika);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PopisUcenikaForm";
            this.Text = "Popis učenika";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisUcenika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPopisUcenika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodajUcenikaButton;
        private System.Windows.Forms.Button izbrisiUcenikaButton;
    }
}