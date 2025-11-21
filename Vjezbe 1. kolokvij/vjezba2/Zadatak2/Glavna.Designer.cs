namespace Zadatak2
{
    partial class Glavna
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
            this.txtDatumUpisa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKnjige = new System.Windows.Forms.DataGridView();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjige)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDatumUpisa
            // 
            this.txtDatumUpisa.Location = new System.Drawing.Point(439, 39);
            this.txtDatumUpisa.Name = "txtDatumUpisa";
            this.txtDatumUpisa.Size = new System.Drawing.Size(161, 20);
            this.txtDatumUpisa.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Datum  upisa:";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(439, 9);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(161, 20);
            this.txtAutor.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Autor:";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(134, 64);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(161, 20);
            this.txtCijena.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Cijena:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(134, 38);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(161, 20);
            this.txtISBN.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "ISBN:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(134, 12);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(161, 20);
            this.txtNaziv.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Naziv:";
            // 
            // dgvKnjige
            // 
            this.dgvKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKnjige.Location = new System.Drawing.Point(15, 103);
            this.dgvKnjige.Name = "dgvKnjige";
            this.dgvKnjige.Size = new System.Drawing.Size(622, 199);
            this.dgvKnjige.TabIndex = 47;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(660, 164);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 46;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(660, 132);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(75, 23);
            this.btnUcitaj.TabIndex = 45;
            this.btnUcitaj.Text = "Učitaj";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(660, 103);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 44;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 332);
            this.Controls.Add(this.txtDatumUpisa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKnjige);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.btnDodaj);
            this.Name = "Glavna";
            this.Text = "Knjige";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjige)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDatumUpisa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKnjige;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.Button btnDodaj;
    }
}

