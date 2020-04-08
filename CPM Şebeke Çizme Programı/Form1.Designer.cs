namespace CPM_Şebeke_Çizme_Programı
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgw_Faaliyet_Tablosu = new System.Windows.Forms.DataGridView();
            this.Kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ÖncüFaaliyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ÖncüFaaliyet2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ÖncüFaaliyet3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ÖncüFaaliyet4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ÖncüFaaliyet5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ÖncüFaaliyet6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faaliyet_Suresi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Sebeke_Ciz = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgw_CPM_sebeke_tablosu = new System.Windows.Forms.DataGridView();
            this.Kod_cpm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gosterdigi_Faaliyetler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Erken_Baslangic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Erken_Sonlanma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gec_Baslangıc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gec_Sonlanma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faaliyet_Suresi_cpm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_kritik_yol_bul = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Faaliyet_Tablosu)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_CPM_sebeke_tablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_Faaliyet_Tablosu
            // 
            this.dgw_Faaliyet_Tablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Faaliyet_Tablosu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kod,
            this.ÖncüFaaliyet,
            this.ÖncüFaaliyet2,
            this.ÖncüFaaliyet3,
            this.ÖncüFaaliyet4,
            this.ÖncüFaaliyet5,
            this.ÖncüFaaliyet6,
            this.Faaliyet_Suresi});
            this.dgw_Faaliyet_Tablosu.Location = new System.Drawing.Point(6, 6);
            this.dgw_Faaliyet_Tablosu.Name = "dgw_Faaliyet_Tablosu";
            this.dgw_Faaliyet_Tablosu.Size = new System.Drawing.Size(845, 370);
            this.dgw_Faaliyet_Tablosu.TabIndex = 0;
            this.dgw_Faaliyet_Tablosu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Kod
            // 
            this.Kod.HeaderText = "KOD";
            this.Kod.Name = "Kod";
            // 
            // ÖncüFaaliyet
            // 
            this.ÖncüFaaliyet.HeaderText = "ÖncüFaaliyet1";
            this.ÖncüFaaliyet.Name = "ÖncüFaaliyet";
            // 
            // ÖncüFaaliyet2
            // 
            this.ÖncüFaaliyet2.HeaderText = "ÖncüFaaliyet2";
            this.ÖncüFaaliyet2.Name = "ÖncüFaaliyet2";
            // 
            // ÖncüFaaliyet3
            // 
            this.ÖncüFaaliyet3.HeaderText = "ÖncüFaaliyet3";
            this.ÖncüFaaliyet3.Name = "ÖncüFaaliyet3";
            // 
            // ÖncüFaaliyet4
            // 
            this.ÖncüFaaliyet4.HeaderText = "ÖncüFaaliyet4";
            this.ÖncüFaaliyet4.Name = "ÖncüFaaliyet4";
            // 
            // ÖncüFaaliyet5
            // 
            this.ÖncüFaaliyet5.HeaderText = "ÖncüFaaliyet5";
            this.ÖncüFaaliyet5.Name = "ÖncüFaaliyet5";
            // 
            // ÖncüFaaliyet6
            // 
            this.ÖncüFaaliyet6.HeaderText = "ÖncüFaaliyet6";
            this.ÖncüFaaliyet6.Name = "ÖncüFaaliyet6";
            // 
            // Faaliyet_Suresi
            // 
            this.Faaliyet_Suresi.HeaderText = "Faaliyet_Suresi";
            this.Faaliyet_Suresi.Name = "Faaliyet_Suresi";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(865, 476);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Sebeke_Ciz);
            this.tabPage1.Controls.Add(this.dgw_Faaliyet_Tablosu);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(857, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Faaliyet Tablosu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Sebeke_Ciz
            // 
            this.btn_Sebeke_Ciz.BackColor = System.Drawing.Color.Lime;
            this.btn_Sebeke_Ciz.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sebeke_Ciz.Location = new System.Drawing.Point(474, 382);
            this.btn_Sebeke_Ciz.Name = "btn_Sebeke_Ciz";
            this.btn_Sebeke_Ciz.Size = new System.Drawing.Size(377, 62);
            this.btn_Sebeke_Ciz.TabIndex = 1;
            this.btn_Sebeke_Ciz.Text = "CPM Şebekeyi Oluştur";
            this.btn_Sebeke_Ciz.UseVisualStyleBackColor = false;
            this.btn_Sebeke_Ciz.Click += new System.EventHandler(this.btn_Sebeke_Ciz_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_kritik_yol_bul);
            this.tabPage2.Controls.Add(this.dgw_CPM_sebeke_tablosu);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(857, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CPM Şebeke Tablosu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgw_CPM_sebeke_tablosu
            // 
            this.dgw_CPM_sebeke_tablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_CPM_sebeke_tablosu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kod_cpm,
            this.Gosterdigi_Faaliyetler,
            this.Erken_Baslangic,
            this.Erken_Sonlanma,
            this.Gec_Baslangıc,
            this.Gec_Sonlanma,
            this.Faaliyet_Suresi_cpm});
            this.dgw_CPM_sebeke_tablosu.Location = new System.Drawing.Point(6, 6);
            this.dgw_CPM_sebeke_tablosu.Name = "dgw_CPM_sebeke_tablosu";
            this.dgw_CPM_sebeke_tablosu.Size = new System.Drawing.Size(772, 370);
            this.dgw_CPM_sebeke_tablosu.TabIndex = 0;
            // 
            // Kod_cpm
            // 
            this.Kod_cpm.HeaderText = "KOD";
            this.Kod_cpm.Name = "Kod_cpm";
            // 
            // Gosterdigi_Faaliyetler
            // 
            this.Gosterdigi_Faaliyetler.HeaderText = "Gosterdigi Faaliyetler";
            this.Gosterdigi_Faaliyetler.Name = "Gosterdigi_Faaliyetler";
            // 
            // Erken_Baslangic
            // 
            this.Erken_Baslangic.HeaderText = "Erken_Baslangic";
            this.Erken_Baslangic.Name = "Erken_Baslangic";
            // 
            // Erken_Sonlanma
            // 
            this.Erken_Sonlanma.HeaderText = "Erken_Sonlanma";
            this.Erken_Sonlanma.Name = "Erken_Sonlanma";
            // 
            // Gec_Baslangıc
            // 
            this.Gec_Baslangıc.HeaderText = "Gec_Baslangıc";
            this.Gec_Baslangıc.Name = "Gec_Baslangıc";
            // 
            // Gec_Sonlanma
            // 
            this.Gec_Sonlanma.HeaderText = "Gec_Sonlanma";
            this.Gec_Sonlanma.Name = "Gec_Sonlanma";
            // 
            // Faaliyet_Suresi_cpm
            // 
            this.Faaliyet_Suresi_cpm.HeaderText = "Faaliyet_Suresi_cpm";
            this.Faaliyet_Suresi_cpm.Name = "Faaliyet_Suresi_cpm";
            // 
            // btn_kritik_yol_bul
            // 
            this.btn_kritik_yol_bul.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_kritik_yol_bul.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kritik_yol_bul.ForeColor = System.Drawing.Color.Red;
            this.btn_kritik_yol_bul.Location = new System.Drawing.Point(165, 382);
            this.btn_kritik_yol_bul.Name = "btn_kritik_yol_bul";
            this.btn_kritik_yol_bul.Size = new System.Drawing.Size(686, 62);
            this.btn_kritik_yol_bul.TabIndex = 2;
            this.btn_kritik_yol_bul.Text = "Tablodaki Şebekeye Göre Kritik Yolu Bul";
            this.btn_kritik_yol_bul.UseVisualStyleBackColor = false;
            this.btn_kritik_yol_bul.Click += new System.EventHandler(this.btn_kritik_yol_bul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 502);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "CPM Şebeke Çizme Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Faaliyet_Tablosu)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_CPM_sebeke_tablosu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_Faaliyet_Tablosu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ÖncüFaaliyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ÖncüFaaliyet2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ÖncüFaaliyet3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ÖncüFaaliyet4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ÖncüFaaliyet5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ÖncüFaaliyet6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faaliyet_Suresi;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Sebeke_Ciz;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgw_CPM_sebeke_tablosu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kod_cpm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gosterdigi_Faaliyetler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Erken_Baslangic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Erken_Sonlanma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gec_Baslangıc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gec_Sonlanma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faaliyet_Suresi_cpm;
        private System.Windows.Forms.Button btn_kritik_yol_bul;
    }
}

