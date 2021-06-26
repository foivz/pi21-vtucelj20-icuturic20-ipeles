
namespace Projekt
{
    partial class IzborKvizaZaPregledForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzborKvizaZaPregledForm));
            this.label1 = new System.Windows.Forms.Label();
            this.razredComboBox = new System.Windows.Forms.ComboBox();
            this.predmetComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cjelinaComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kvizComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pregledajButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.skolaLabel = new System.Windows.Forms.Label();
            this.skolaComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Razred:";
            // 
            // razredComboBox
            // 
            this.razredComboBox.FormattingEnabled = true;
            this.razredComboBox.Location = new System.Drawing.Point(63, 93);
            this.razredComboBox.Name = "razredComboBox";
            this.razredComboBox.Size = new System.Drawing.Size(242, 21);
            this.razredComboBox.TabIndex = 1;
            this.razredComboBox.SelectedIndexChanged += new System.EventHandler(this.razredComboBox_SelectedIndexChanged);
            // 
            // predmetComboBox
            // 
            this.predmetComboBox.FormattingEnabled = true;
            this.predmetComboBox.Location = new System.Drawing.Point(63, 133);
            this.predmetComboBox.Name = "predmetComboBox";
            this.predmetComboBox.Size = new System.Drawing.Size(242, 21);
            this.predmetComboBox.TabIndex = 3;
            this.predmetComboBox.SelectedIndexChanged += new System.EventHandler(this.predmetComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(13, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Predmet:";
            // 
            // cjelinaComboBox
            // 
            this.cjelinaComboBox.FormattingEnabled = true;
            this.cjelinaComboBox.Location = new System.Drawing.Point(63, 177);
            this.cjelinaComboBox.Name = "cjelinaComboBox";
            this.cjelinaComboBox.Size = new System.Drawing.Size(242, 21);
            this.cjelinaComboBox.TabIndex = 5;
            this.cjelinaComboBox.SelectedIndexChanged += new System.EventHandler(this.cjelinaComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(18, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cjelina:";
            // 
            // kvizComboBox
            // 
            this.kvizComboBox.FormattingEnabled = true;
            this.kvizComboBox.Location = new System.Drawing.Point(63, 221);
            this.kvizComboBox.Name = "kvizComboBox";
            this.kvizComboBox.Size = new System.Drawing.Size(242, 21);
            this.kvizComboBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(27, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kviz:";
            // 
            // pregledajButton
            // 
            this.pregledajButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pregledajButton.Location = new System.Drawing.Point(91, 264);
            this.pregledajButton.Name = "pregledajButton";
            this.pregledajButton.Size = new System.Drawing.Size(167, 43);
            this.pregledajButton.TabIndex = 8;
            this.pregledajButton.Text = "Pregledaj";
            this.pregledajButton.UseVisualStyleBackColor = true;
            this.pregledajButton.Click += new System.EventHandler(this.pregledajButton_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(20, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(306, 40);
            this.label5.TabIndex = 9;
            this.label5.Text = "Odaberite za koji kviz želite pregledati pitanja i odgovore";
            // 
            // skolaLabel
            // 
            this.skolaLabel.AutoSize = true;
            this.skolaLabel.BackColor = System.Drawing.Color.Transparent;
            this.skolaLabel.Location = new System.Drawing.Point(20, 59);
            this.skolaLabel.Name = "skolaLabel";
            this.skolaLabel.Size = new System.Drawing.Size(37, 13);
            this.skolaLabel.TabIndex = 10;
            this.skolaLabel.Text = "Škola:";
            // 
            // skolaComboBox
            // 
            this.skolaComboBox.FormattingEnabled = true;
            this.skolaComboBox.Location = new System.Drawing.Point(63, 56);
            this.skolaComboBox.Name = "skolaComboBox";
            this.skolaComboBox.Size = new System.Drawing.Size(242, 21);
            this.skolaComboBox.TabIndex = 11;
            this.skolaComboBox.SelectedIndexChanged += new System.EventHandler(this.skolaComboBox_SelectedIndexChanged);
            // 
            // IzborKvizaZaPregledForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt.Properties.Resources.a3d6c0c54caa8b169a8928c33b4c1f4d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(333, 388);
            this.Controls.Add(this.skolaComboBox);
            this.Controls.Add(this.skolaLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pregledajButton);
            this.Controls.Add(this.kvizComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cjelinaComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.predmetComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.razredComboBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IzborKvizaZaPregledForm";
            this.Text = "Odabir kviza";
            this.Load += new System.EventHandler(this.IzborKvizaZaPregledForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox razredComboBox;
        private System.Windows.Forms.ComboBox predmetComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cjelinaComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox kvizComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button pregledajButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label skolaLabel;
        private System.Windows.Forms.ComboBox skolaComboBox;
    }
}