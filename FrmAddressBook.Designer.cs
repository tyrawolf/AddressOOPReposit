namespace AddressDemo
{
    partial class FrmAddressBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddressBook));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnTambah = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnHapus = new System.Windows.Forms.ToolStripButton();
            this.textKota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbemail = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtnomor = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lbtgllahir = new System.Windows.Forms.Label();
            this.lbalamat = new System.Windows.Forms.Label();
            this.lbnomor = new System.Windows.Forms.Label();
            this.lbnama = new System.Windows.Forms.Label();
            this.txtTglLahir = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbBanyakRecordData = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTambah,
            this.btnEdit,
            this.btnHapus});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(678, 27);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnTambah
            // 
            this.btnTambah.Image = ((System.Drawing.Image)(resources.GetObject("btnTambah.Image")));
            this.btnTambah.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(85, 24);
            this.btnTambah.Text = "&Tambah";
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(59, 24);
            this.btnEdit.Text = "&Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Image = ((System.Drawing.Image)(resources.GetObject("btnHapus.Image")));
            this.btnHapus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 24);
            this.btnHapus.Text = "&Hapus";
            // 
            // textKota
            // 
            this.textKota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textKota.Location = new System.Drawing.Point(157, 94);
            this.textKota.Name = "textKota";
            this.textKota.Size = new System.Drawing.Size(334, 22);
            this.textKota.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Kota";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 41;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(157, 183);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(334, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(12, 183);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(42, 17);
            this.lbemail.TabIndex = 40;
            this.lbemail.Text = "Email";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlamat.Location = new System.Drawing.Point(157, 66);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(334, 22);
            this.txtAlamat.TabIndex = 1;
            // 
            // txtnomor
            // 
            this.txtnomor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnomor.Location = new System.Drawing.Point(157, 122);
            this.txtnomor.Name = "txtnomor";
            this.txtnomor.Size = new System.Drawing.Size(334, 22);
            this.txtnomor.TabIndex = 3;
            // 
            // txtNama
            // 
            this.txtNama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNama.Location = new System.Drawing.Point(157, 41);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(334, 22);
            this.txtNama.TabIndex = 0;
            // 
            // lbtgllahir
            // 
            this.lbtgllahir.AutoSize = true;
            this.lbtgllahir.Location = new System.Drawing.Point(12, 153);
            this.lbtgllahir.Name = "lbtgllahir";
            this.lbtgllahir.Size = new System.Drawing.Size(96, 17);
            this.lbtgllahir.TabIndex = 35;
            this.lbtgllahir.Text = "Tanggal Lahir";
            // 
            // lbalamat
            // 
            this.lbalamat.AutoSize = true;
            this.lbalamat.Location = new System.Drawing.Point(12, 66);
            this.lbalamat.Name = "lbalamat";
            this.lbalamat.Size = new System.Drawing.Size(51, 17);
            this.lbalamat.TabIndex = 33;
            this.lbalamat.Text = "Alamat";
            // 
            // lbnomor
            // 
            this.lbnomor.AutoSize = true;
            this.lbnomor.Location = new System.Drawing.Point(12, 122);
            this.lbnomor.Name = "lbnomor";
            this.lbnomor.Size = new System.Drawing.Size(106, 17);
            this.lbnomor.TabIndex = 31;
            this.lbnomor.Text = "Nomor Telepon";
            // 
            // lbnama
            // 
            this.lbnama.AutoSize = true;
            this.lbnama.Location = new System.Drawing.Point(12, 41);
            this.lbnama.Name = "lbnama";
            this.lbnama.Size = new System.Drawing.Size(45, 17);
            this.lbnama.TabIndex = 29;
            this.lbnama.Text = "Nama";
            // 
            // txtTglLahir
            // 
            this.txtTglLahir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTglLahir.Location = new System.Drawing.Point(157, 150);
            this.txtTglLahir.Name = "txtTglLahir";
            this.txtTglLahir.Size = new System.Drawing.Size(334, 22);
            this.txtTglLahir.TabIndex = 4;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Location = new System.Drawing.Point(552, 41);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(94, 42);
            this.btnFilter.TabIndex = 7;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvData.Location = new System.Drawing.Point(12, 263);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(654, 150);
            this.dgvData.TabIndex = 45;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nama";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Alamat";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kota";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nomor Telepon";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tanggal Lahir";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Email";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // lbBanyakRecordData
            // 
            this.lbBanyakRecordData.AutoSize = true;
            this.lbBanyakRecordData.Location = new System.Drawing.Point(12, 228);
            this.lbBanyakRecordData.Name = "lbBanyakRecordData";
            this.lbBanyakRecordData.Size = new System.Drawing.Size(149, 17);
            this.lbBanyakRecordData.TabIndex = 46;
            this.lbBanyakRecordData.Text = "{Banyak Record Data}";
            // 
            // FrmAddressBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 455);
            this.Controls.Add(this.lbBanyakRecordData);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtTglLahir);
            this.Controls.Add(this.textKota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtnomor);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lbtgllahir);
            this.Controls.Add(this.lbalamat);
            this.Controls.Add(this.lbnomor);
            this.Controls.Add(this.lbnama);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Name = "FrmAddressBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Address Book";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAddressBook_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnHapus;
        private System.Windows.Forms.ToolStripButton btnTambah;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.TextBox textKota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtnomor;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lbtgllahir;
        private System.Windows.Forms.Label lbalamat;
        private System.Windows.Forms.Label lbnomor;
        private System.Windows.Forms.Label lbnama;
        private System.Windows.Forms.TextBox txtTglLahir;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lbBanyakRecordData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}