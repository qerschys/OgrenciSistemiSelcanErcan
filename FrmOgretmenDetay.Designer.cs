namespace OgrenciSistemiSelcanErcan
{
    partial class FrmOgretmenDetay
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
                this.components = new System.ComponentModel.Container();
                this.dataGridView1 = new System.Windows.Forms.DataGridView();
                this.oGRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.oGRNUMARADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.oGRADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.oGRSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.oGRS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.oGRS2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.oGRS3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.oRTALAMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.dURUMDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
                this.tBLDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
                this.dbNotKayıtDataSet = new OgrenciSistemiSelcanErcan.DbNotKayıtDataSet();
                this.LblOrtalama = new System.Windows.Forms.Label();
                this.label9 = new System.Windows.Forms.Label();
                this.groupBox4 = new System.Windows.Forms.GroupBox();
                this.groupBox3 = new System.Windows.Forms.GroupBox();
                this.button2 = new System.Windows.Forms.Button();
                this.TxtSınav3 = new System.Windows.Forms.TextBox();
                this.TxtSınav2 = new System.Windows.Forms.TextBox();
                this.label4 = new System.Windows.Forms.Label();
                this.label5 = new System.Windows.Forms.Label();
                this.label6 = new System.Windows.Forms.Label();
                this.button1 = new System.Windows.Forms.Button();
                this.TxtSoyad = new System.Windows.Forms.TextBox();
                this.TxtAd = new System.Windows.Forms.TextBox();
                this.MskNumara = new System.Windows.Forms.MaskedTextBox();
                this.label3 = new System.Windows.Forms.Label();
                this.label2 = new System.Windows.Forms.Label();
                this.label1 = new System.Windows.Forms.Label();
                this.groupBox2 = new System.Windows.Forms.GroupBox();
                this.TxtSınav1 = new System.Windows.Forms.TextBox();
                this.groupBox1 = new System.Windows.Forms.GroupBox();
                this.tBLDERSTableAdapter = new OgrenciSistemiSelcanErcan.DbNotKayıtDataSetTableAdapters.TBLDERSTableAdapter();
                ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.tBLDERSBindingSource)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.dbNotKayıtDataSet)).BeginInit();
                this.groupBox4.SuspendLayout();
                this.groupBox3.SuspendLayout();
                this.groupBox2.SuspendLayout();
                this.groupBox1.SuspendLayout();
                this.SuspendLayout();
                // 
                // dataGridView1
                // 
                this.dataGridView1.AutoGenerateColumns = false;
                this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oGRIDDataGridViewTextBoxColumn,
            this.oGRNUMARADataGridViewTextBoxColumn,
            this.oGRADDataGridViewTextBoxColumn,
            this.oGRSOYADDataGridViewTextBoxColumn,
            this.oGRS1DataGridViewTextBoxColumn,
            this.oGRS2DataGridViewTextBoxColumn,
            this.oGRS3DataGridViewTextBoxColumn,
            this.oRTALAMADataGridViewTextBoxColumn,
            this.dURUMDataGridViewCheckBoxColumn});
                this.dataGridView1.DataSource = this.tBLDERSBindingSource;
                this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
                this.dataGridView1.Location = new System.Drawing.Point(3, 26);
                this.dataGridView1.Name = "dataGridView1";
                this.dataGridView1.RowHeadersWidth = 51;
                this.dataGridView1.RowTemplate.Height = 24;
                this.dataGridView1.Size = new System.Drawing.Size(1351, 276);
                this.dataGridView1.TabIndex = 0;
                this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
                // 
                // oGRIDDataGridViewTextBoxColumn
                // 
                this.oGRIDDataGridViewTextBoxColumn.DataPropertyName = "OGRID";
                this.oGRIDDataGridViewTextBoxColumn.HeaderText = "OGRID";
                this.oGRIDDataGridViewTextBoxColumn.MinimumWidth = 6;
                this.oGRIDDataGridViewTextBoxColumn.Name = "oGRIDDataGridViewTextBoxColumn";
                this.oGRIDDataGridViewTextBoxColumn.ReadOnly = true;
                // 
                // oGRNUMARADataGridViewTextBoxColumn
                // 
                this.oGRNUMARADataGridViewTextBoxColumn.DataPropertyName = "OGRNUMARA";
                this.oGRNUMARADataGridViewTextBoxColumn.HeaderText = "OGRNUMARA";
                this.oGRNUMARADataGridViewTextBoxColumn.MinimumWidth = 6;
                this.oGRNUMARADataGridViewTextBoxColumn.Name = "oGRNUMARADataGridViewTextBoxColumn";
                // 
                // oGRADDataGridViewTextBoxColumn
                // 
                this.oGRADDataGridViewTextBoxColumn.DataPropertyName = "OGRAD";
                this.oGRADDataGridViewTextBoxColumn.HeaderText = "OGRAD";
                this.oGRADDataGridViewTextBoxColumn.MinimumWidth = 6;
                this.oGRADDataGridViewTextBoxColumn.Name = "oGRADDataGridViewTextBoxColumn";
                // 
                // oGRSOYADDataGridViewTextBoxColumn
                // 
                this.oGRSOYADDataGridViewTextBoxColumn.DataPropertyName = "OGRSOYAD";
                this.oGRSOYADDataGridViewTextBoxColumn.HeaderText = "OGRSOYAD";
                this.oGRSOYADDataGridViewTextBoxColumn.MinimumWidth = 6;
                this.oGRSOYADDataGridViewTextBoxColumn.Name = "oGRSOYADDataGridViewTextBoxColumn";
                // 
                // oGRS1DataGridViewTextBoxColumn
                // 
                this.oGRS1DataGridViewTextBoxColumn.DataPropertyName = "OGRS1";
                this.oGRS1DataGridViewTextBoxColumn.HeaderText = "OGRS1";
                this.oGRS1DataGridViewTextBoxColumn.MinimumWidth = 6;
                this.oGRS1DataGridViewTextBoxColumn.Name = "oGRS1DataGridViewTextBoxColumn";
                // 
                // oGRS2DataGridViewTextBoxColumn
                // 
                this.oGRS2DataGridViewTextBoxColumn.DataPropertyName = "OGRS2";
                this.oGRS2DataGridViewTextBoxColumn.HeaderText = "OGRS2";
                this.oGRS2DataGridViewTextBoxColumn.MinimumWidth = 6;
                this.oGRS2DataGridViewTextBoxColumn.Name = "oGRS2DataGridViewTextBoxColumn";
                // 
                // oGRS3DataGridViewTextBoxColumn
                // 
                this.oGRS3DataGridViewTextBoxColumn.DataPropertyName = "OGRS3";
                this.oGRS3DataGridViewTextBoxColumn.HeaderText = "OGRS3";
                this.oGRS3DataGridViewTextBoxColumn.MinimumWidth = 6;
                this.oGRS3DataGridViewTextBoxColumn.Name = "oGRS3DataGridViewTextBoxColumn";
                // 
                // oRTALAMADataGridViewTextBoxColumn
                // 
                this.oRTALAMADataGridViewTextBoxColumn.DataPropertyName = "ORTALAMA";
                this.oRTALAMADataGridViewTextBoxColumn.HeaderText = "ORTALAMA";
                this.oRTALAMADataGridViewTextBoxColumn.MinimumWidth = 6;
                this.oRTALAMADataGridViewTextBoxColumn.Name = "oRTALAMADataGridViewTextBoxColumn";
                // 
                // dURUMDataGridViewCheckBoxColumn
                // 
                this.dURUMDataGridViewCheckBoxColumn.DataPropertyName = "DURUM";
                this.dURUMDataGridViewCheckBoxColumn.HeaderText = "DURUM";
                this.dURUMDataGridViewCheckBoxColumn.MinimumWidth = 6;
                this.dURUMDataGridViewCheckBoxColumn.Name = "dURUMDataGridViewCheckBoxColumn";
                // 
                // tBLDERSBindingSource
                // 
                this.tBLDERSBindingSource.DataMember = "TBLDERS";
                this.tBLDERSBindingSource.DataSource = this.dbNotKayıtDataSet;
                // 
                // dbNotKayıtDataSet2
                // 
                this.dbNotKayıtDataSet.DataSetName = "DbNotKayıtDataSet";
                this.dbNotKayıtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
                // 
                // LblOrtalama
                // 
                this.LblOrtalama.AutoSize = true;
                this.LblOrtalama.Location = new System.Drawing.Point(184, 72);
                this.LblOrtalama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.LblOrtalama.Name = "LblOrtalama";
                this.LblOrtalama.Size = new System.Drawing.Size(34, 24);
                this.LblOrtalama.TabIndex = 4;
                this.LblOrtalama.Text = "00";
                // 
                // label9
                // 
                this.label9.AutoSize = true;
                this.label9.Location = new System.Drawing.Point(9, 72);
                this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.label9.Name = "label9";
                this.label9.Size = new System.Drawing.Size(94, 24);
                this.label9.TabIndex = 1;
                this.label9.Text = "Ortalama";
                // 
                // groupBox4
                // 
                this.groupBox4.Controls.Add(this.dataGridView1);
                this.groupBox4.Location = new System.Drawing.Point(-2, 353);
                this.groupBox4.Name = "groupBox4";
                this.groupBox4.Size = new System.Drawing.Size(1357, 305);
                this.groupBox4.TabIndex = 7;
                this.groupBox4.TabStop = false;
                this.groupBox4.Text = "Sınıf Not Bilgisi";
                // 
                // groupBox3
                // 
                this.groupBox3.Controls.Add(this.LblOrtalama);
                this.groupBox3.Controls.Add(this.label9);
                this.groupBox3.Location = new System.Drawing.Point(868, 129);
                this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
                this.groupBox3.Name = "groupBox3";
                this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
                this.groupBox3.Size = new System.Drawing.Size(259, 144);
                this.groupBox3.TabIndex = 6;
                this.groupBox3.TabStop = false;
                this.groupBox3.Text = "Öğrencinin Ortalaması";
                // 
                // button2
                // 
                this.button2.Location = new System.Drawing.Point(105, 232);
                this.button2.Margin = new System.Windows.Forms.Padding(4);
                this.button2.Name = "button2";
                this.button2.Size = new System.Drawing.Size(112, 34);
                this.button2.TabIndex = 1;
                this.button2.Text = "Güncelle";
                this.button2.UseVisualStyleBackColor = true;
                this.button2.Click += new System.EventHandler(this.button2_Click_1);
                // 
                // TxtSınav3
                // 
                this.TxtSınav3.Location = new System.Drawing.Point(140, 156);
                this.TxtSınav3.Margin = new System.Windows.Forms.Padding(4);
                this.TxtSınav3.Name = "TxtSınav3";
                this.TxtSınav3.Size = new System.Drawing.Size(148, 30);
                this.TxtSınav3.TabIndex = 4;
                // 
                // TxtSınav2
                // 
                this.TxtSınav2.Location = new System.Drawing.Point(140, 114);
                this.TxtSınav2.Margin = new System.Windows.Forms.Padding(4);
                this.TxtSınav2.Name = "TxtSınav2";
                this.TxtSınav2.Size = new System.Drawing.Size(148, 30);
                this.TxtSınav2.TabIndex = 1;
                // 
                // label4
                // 
                this.label4.AutoSize = true;
                this.label4.Location = new System.Drawing.Point(9, 114);
                this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(75, 24);
                this.label4.TabIndex = 3;
                this.label4.Text = "Sınav 2";
                // 
                // label5
                // 
                this.label5.AutoSize = true;
                this.label5.Location = new System.Drawing.Point(9, 154);
                this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.label5.Name = "label5";
                this.label5.Size = new System.Drawing.Size(75, 24);
                this.label5.TabIndex = 2;
                this.label5.Text = "Sınav 3";
                // 
                // label6
                // 
                this.label6.AutoSize = true;
                this.label6.Location = new System.Drawing.Point(9, 72);
                this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.label6.Name = "label6";
                this.label6.Size = new System.Drawing.Size(73, 24);
                this.label6.TabIndex = 1;
                this.label6.Text = "Sınav 1";
                // 
                // button1
                // 
                this.button1.Location = new System.Drawing.Point(93, 244);
                this.button1.Margin = new System.Windows.Forms.Padding(4);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(216, 34);
                this.button1.TabIndex = 1;
                this.button1.Text = "Öğrenci Kaydet";
                this.button1.UseVisualStyleBackColor = true;
                this.button1.Click += new System.EventHandler(this.button1_Click);
                // 
                // TxtSoyad
                // 
                this.TxtSoyad.Location = new System.Drawing.Point(140, 156);
                this.TxtSoyad.Margin = new System.Windows.Forms.Padding(4);
                this.TxtSoyad.Name = "TxtSoyad";
                this.TxtSoyad.Size = new System.Drawing.Size(148, 30);
                this.TxtSoyad.TabIndex = 4;
                // 
                // TxtAd
                // 
                this.TxtAd.Location = new System.Drawing.Point(140, 114);
                this.TxtAd.Margin = new System.Windows.Forms.Padding(4);
                this.TxtAd.Name = "TxtAd";
                this.TxtAd.Size = new System.Drawing.Size(148, 30);
                this.TxtAd.TabIndex = 1;
                // 
                // MskNumara
                // 
                this.MskNumara.Location = new System.Drawing.Point(140, 72);
                this.MskNumara.Margin = new System.Windows.Forms.Padding(4);
                this.MskNumara.Mask = "0000";
                this.MskNumara.Name = "MskNumara";
                this.MskNumara.Size = new System.Drawing.Size(148, 30);
                this.MskNumara.TabIndex = 1;
                // 
                // label3
                // 
                this.label3.AutoSize = true;
                this.label3.Location = new System.Drawing.Point(9, 114);
                this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(34, 24);
                this.label3.TabIndex = 3;
                this.label3.Text = "Ad";
                // 
                // label2
                // 
                this.label2.AutoSize = true;
                this.label2.Location = new System.Drawing.Point(9, 154);
                this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(63, 24);
                this.label2.TabIndex = 2;
                this.label2.Text = "Soyad";
                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.Location = new System.Drawing.Point(9, 72);
                this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(83, 24);
                this.label1.TabIndex = 1;
                this.label1.Text = "Numara";
                // 
                // groupBox2
                // 
                this.groupBox2.Controls.Add(this.TxtSınav1);
                this.groupBox2.Controls.Add(this.button2);
                this.groupBox2.Controls.Add(this.TxtSınav3);
                this.groupBox2.Controls.Add(this.TxtSınav2);
                this.groupBox2.Controls.Add(this.label4);
                this.groupBox2.Controls.Add(this.label5);
                this.groupBox2.Controls.Add(this.label6);
                this.groupBox2.Location = new System.Drawing.Point(527, 31);
                this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
                this.groupBox2.Name = "groupBox2";
                this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
                this.groupBox2.Size = new System.Drawing.Size(319, 303);
                this.groupBox2.TabIndex = 5;
                this.groupBox2.TabStop = false;
                this.groupBox2.Text = "Sınav Notları";
                // 
                // TxtSınav1
                // 
                this.TxtSınav1.Location = new System.Drawing.Point(140, 66);
                this.TxtSınav1.Margin = new System.Windows.Forms.Padding(4);
                this.TxtSınav1.Name = "TxtSınav1";
                this.TxtSınav1.Size = new System.Drawing.Size(148, 30);
                this.TxtSınav1.TabIndex = 5;
                // 
                // groupBox1
                // 
                this.groupBox1.Controls.Add(this.button1);
                this.groupBox1.Controls.Add(this.TxtSoyad);
                this.groupBox1.Controls.Add(this.TxtAd);
                this.groupBox1.Controls.Add(this.MskNumara);
                this.groupBox1.Controls.Add(this.label3);
                this.groupBox1.Controls.Add(this.label2);
                this.groupBox1.Controls.Add(this.label1);
                this.groupBox1.Location = new System.Drawing.Point(173, 31);
                this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
                this.groupBox1.Name = "groupBox1";
                this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
                this.groupBox1.Size = new System.Drawing.Size(335, 315);
                this.groupBox1.TabIndex = 4;
                this.groupBox1.TabStop = false;
                this.groupBox1.Text = "Öğrenci Ekle ";
                // 
                // tBLDERSTableAdapter
                // 
                this.tBLDERSTableAdapter.ClearBeforeFill = true;
                // 
                // FrmOgretmenDetay
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(1404, 675);
                this.Controls.Add(this.groupBox4);
                this.Controls.Add(this.groupBox3);
                this.Controls.Add(this.groupBox2);
                this.Controls.Add(this.groupBox1);
                this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                this.Margin = new System.Windows.Forms.Padding(4);
                this.Name = "FrmOgretmenDetay";
                this.Text = "FrmOgretmenDetay";
                this.Load += new System.EventHandler(this.FrmOgretmenDetay_Load);
                ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.tBLDERSBindingSource)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.dbNotKayıtDataSet)).EndInit();
                this.groupBox4.ResumeLayout(false);
                this.groupBox3.ResumeLayout(false);
                this.groupBox3.PerformLayout();
                this.groupBox2.ResumeLayout(false);
                this.groupBox2.PerformLayout();
                this.groupBox1.ResumeLayout(false);
                this.groupBox1.PerformLayout();
                this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.DataGridView dataGridView1;
            private System.Windows.Forms.Label LblOrtalama;
            private System.Windows.Forms.Label label9;
            private System.Windows.Forms.GroupBox groupBox4;
            private System.Windows.Forms.GroupBox groupBox3;
            private System.Windows.Forms.Button button2;
            private System.Windows.Forms.TextBox TxtSınav3;
            private System.Windows.Forms.TextBox TxtSınav2;
            private System.Windows.Forms.Label label4;
            private System.Windows.Forms.Label label5;
            private System.Windows.Forms.Label label6;
            private System.Windows.Forms.Button button1;
            private System.Windows.Forms.TextBox TxtSoyad;
            private System.Windows.Forms.TextBox TxtAd;
            private System.Windows.Forms.MaskedTextBox MskNumara;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.GroupBox groupBox2;
            private System.Windows.Forms.GroupBox groupBox1;
            private DbNotKayıtDataSet dbNotKayıtDataSet;
            private System.Windows.Forms.BindingSource tBLDERSBindingSource;
            private DbNotKayıtDataSetTableAdapters.TBLDERSTableAdapter tBLDERSTableAdapter;
            private System.Windows.Forms.DataGridViewTextBoxColumn oGRIDDataGridViewTextBoxColumn;
            private System.Windows.Forms.DataGridViewTextBoxColumn oGRNUMARADataGridViewTextBoxColumn;
            private System.Windows.Forms.DataGridViewTextBoxColumn oGRADDataGridViewTextBoxColumn;
            private System.Windows.Forms.DataGridViewTextBoxColumn oGRSOYADDataGridViewTextBoxColumn;
            private System.Windows.Forms.DataGridViewTextBoxColumn oGRS1DataGridViewTextBoxColumn;
            private System.Windows.Forms.DataGridViewTextBoxColumn oGRS2DataGridViewTextBoxColumn;
            private System.Windows.Forms.DataGridViewTextBoxColumn oGRS3DataGridViewTextBoxColumn;
            private System.Windows.Forms.DataGridViewTextBoxColumn oRTALAMADataGridViewTextBoxColumn;
            private System.Windows.Forms.DataGridViewCheckBoxColumn dURUMDataGridViewCheckBoxColumn;
            private System.Windows.Forms.TextBox TxtSınav1;
        
    }
}

