
namespace _emlak_otomasyon
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.rbtnKiralikKonut = new System.Windows.Forms.RadioButton();
            this.rbtnSatilikKonut = new System.Windows.Forms.RadioButton();
            this.txtMaxMetrekare = new System.Windows.Forms.TextBox();
            this.txtMinMetrekare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxFiyat = new System.Windows.Forms.TextBox();
            this.txtMinFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.cbIsitma = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cbEmlakTipi = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnKiralikKonut
            // 
            this.rbtnKiralikKonut.AutoSize = true;
            this.rbtnKiralikKonut.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnKiralikKonut.Location = new System.Drawing.Point(517, 159);
            this.rbtnKiralikKonut.Name = "rbtnKiralikKonut";
            this.rbtnKiralikKonut.Size = new System.Drawing.Size(190, 37);
            this.rbtnKiralikKonut.TabIndex = 43;
            this.rbtnKiralikKonut.Text = "Kiralık Konut";
            this.rbtnKiralikKonut.UseVisualStyleBackColor = true;
            // 
            // rbtnSatilikKonut
            // 
            this.rbtnSatilikKonut.AutoSize = true;
            this.rbtnSatilikKonut.Checked = true;
            this.rbtnSatilikKonut.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnSatilikKonut.Location = new System.Drawing.Point(325, 159);
            this.rbtnSatilikKonut.Name = "rbtnSatilikKonut";
            this.rbtnSatilikKonut.Size = new System.Drawing.Size(186, 37);
            this.rbtnSatilikKonut.TabIndex = 42;
            this.rbtnSatilikKonut.TabStop = true;
            this.rbtnSatilikKonut.Text = "Satılık Konut";
            this.rbtnSatilikKonut.UseVisualStyleBackColor = true;
            // 
            // txtMaxMetrekare
            // 
            this.txtMaxMetrekare.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaxMetrekare.Location = new System.Drawing.Point(399, 87);
            this.txtMaxMetrekare.MaxLength = 10;
            this.txtMaxMetrekare.Name = "txtMaxMetrekare";
            this.txtMaxMetrekare.Size = new System.Drawing.Size(90, 34);
            this.txtMaxMetrekare.TabIndex = 40;
            this.txtMaxMetrekare.Text = "0";
            // 
            // txtMinMetrekare
            // 
            this.txtMinMetrekare.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMinMetrekare.Location = new System.Drawing.Point(291, 87);
            this.txtMinMetrekare.MaxLength = 10;
            this.txtMinMetrekare.Name = "txtMinMetrekare";
            this.txtMinMetrekare.Size = new System.Drawing.Size(90, 34);
            this.txtMinMetrekare.TabIndex = 39;
            this.txtMinMetrekare.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(379, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 27);
            this.label1.TabIndex = 41;
            this.label1.Text = "-";
            // 
            // txtMaxFiyat
            // 
            this.txtMaxFiyat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaxFiyat.Location = new System.Drawing.Point(399, 36);
            this.txtMaxFiyat.MaxLength = 10;
            this.txtMaxFiyat.Name = "txtMaxFiyat";
            this.txtMaxFiyat.Size = new System.Drawing.Size(90, 34);
            this.txtMaxFiyat.TabIndex = 36;
            this.txtMaxFiyat.Text = "0";
            // 
            // txtMinFiyat
            // 
            this.txtMinFiyat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMinFiyat.Location = new System.Drawing.Point(291, 35);
            this.txtMinFiyat.MaxLength = 10;
            this.txtMinFiyat.Name = "txtMinFiyat";
            this.txtMinFiyat.Size = new System.Drawing.Size(90, 34);
            this.txtMinFiyat.TabIndex = 35;
            this.txtMinFiyat.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(380, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 27);
            this.label4.TabIndex = 37;
            this.label4.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(118, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 33);
            this.label2.TabIndex = 38;
            this.label2.Text = "Fiyat Aralığı:";
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.Image")));
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.Location = new System.Drawing.Point(447, 207);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(139, 69);
            this.btnAra.TabIndex = 34;
            this.btnAra.Text = "Ara";
            this.btnAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // cbIsitma
            // 
            this.cbIsitma.DropDownHeight = 165;
            this.cbIsitma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsitma.DropDownWidth = 185;
            this.cbIsitma.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbIsitma.FormattingEnabled = true;
            this.cbIsitma.IntegralHeight = false;
            this.cbIsitma.Items.AddRange(new object[] {
            "Klima",
            "Merkezi Sistem",
            "Güneş Enerjisi",
            "Kombi (Elektrikli)",
            "Isıtma Sistemi Yok",
            "Jeotermal",
            "Kalorifer (Akaryakıt)",
            "Kalorifer (Doğalgaz)",
            "Kalorifer (Kömür)",
            "Kat Kaloriferi (Akaryakıt)",
            "Kombi (Doğalgaz)",
            "Soba (Doğalgaz)",
            "Soba (Kömür)",
            "Yerden Isıtma"});
            this.cbIsitma.Location = new System.Drawing.Point(666, 89);
            this.cbIsitma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbIsitma.Name = "cbIsitma";
            this.cbIsitma.Size = new System.Drawing.Size(203, 34);
            this.cbIsitma.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(518, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 33);
            this.label15.TabIndex = 32;
            this.label15.Text = "Isıtma:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(118, 87);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(136, 33);
            this.label20.TabIndex = 31;
            this.label20.Text = "Metrekare:";
            // 
            // cbEmlakTipi
            // 
            this.cbEmlakTipi.DropDownHeight = 212;
            this.cbEmlakTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmlakTipi.DropDownWidth = 165;
            this.cbEmlakTipi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbEmlakTipi.FormattingEnabled = true;
            this.cbEmlakTipi.IntegralHeight = false;
            this.cbEmlakTipi.Items.AddRange(new object[] {
            "Ahşap Ev",
            "Apartman",
            "Apartman Dairesi",
            "Çiftlik Evi",
            "Dağ Evi",
            "Daire (Bahçe Dublex)",
            "Daire (Çatı Dublex)",
            "Dublex",
            "Fourlex",
            "İkiz Ev",
            "Köşk",
            "Köy Evi",
            "Malikane",
            "Müstakil Ev",
            "Residence",
            "Stüdyo",
            "Townhouse",
            "Triplex",
            "Villa",
            "Yalı",
            "Taş Ev",
            "Apart"});
            this.cbEmlakTipi.Location = new System.Drawing.Point(666, 36);
            this.cbEmlakTipi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEmlakTipi.Name = "cbEmlakTipi";
            this.cbEmlakTipi.Size = new System.Drawing.Size(203, 34);
            this.cbEmlakTipi.TabIndex = 29;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(518, 39);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(145, 33);
            this.label19.TabIndex = 28;
            this.label19.Text = "Emlak Tipi:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(85, 294);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(901, 150);
            this.dataGridView1.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(922, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 59);
            this.button1.TabIndex = 45;
            this.button1.Text = "Geri Dön";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1073, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rbtnKiralikKonut);
            this.Controls.Add(this.rbtnSatilikKonut);
            this.Controls.Add(this.txtMaxMetrekare);
            this.Controls.Add(this.txtMinMetrekare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaxFiyat);
            this.Controls.Add(this.txtMinFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.cbIsitma);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cbEmlakTipi);
            this.Controls.Add(this.label19);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arama";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnKiralikKonut;
        private System.Windows.Forms.RadioButton rbtnSatilikKonut;
        private System.Windows.Forms.TextBox txtMaxMetrekare;
        private System.Windows.Forms.TextBox txtMinMetrekare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxFiyat;
        private System.Windows.Forms.TextBox txtMinFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cbIsitma;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbEmlakTipi;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}