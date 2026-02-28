namespace KanserTespitProgramı
{
    partial class HastaListesiForm
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
            dgvList = new DataGridView();
            btnSil = new Button();
            txtAra = new TextBox();
            btnAra = new Button();
            groupBox1 = new GroupBox();
            lblTemiz = new Label();
            lblRiskli = new Label();
            lblToplam = new Label();
            dtpBaslangic = new DateTimePicker();
            dtpBitis = new DateTimePicker();
            groupBox2 = new GroupBox();
            btnFiltrele = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvList
            // 
            dgvList.AllowUserToAddRows = false;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(-2, -3);
            dgvList.Name = "dgvList";
            dgvList.ReadOnly = true;
            dgvList.Size = new Size(890, 569);
            dgvList.TabIndex = 0;
            dgvList.CellContentClick += dgvList_CellContentClick;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(667, 343);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 1;
            btnSil.Text = "KAYDI SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtAra
            // 
            txtAra.ForeColor = SystemColors.GrayText;
            txtAra.Location = new Point(614, 264);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(100, 23);
            txtAra.TabIndex = 2;
            txtAra.Text = "İsim Giriniz";
            txtAra.Enter += txtAra_Enter;
            txtAra.Leave += txtAra_Leave;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(720, 264);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(75, 23);
            btnAra.TabIndex = 3;
            btnAra.Text = "ARA";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTemiz);
            groupBox1.Controls.Add(lblRiskli);
            groupBox1.Controls.Add(lblToplam);
            groupBox1.Location = new Point(605, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "GENEL DURUM";
            // 
            // lblTemiz
            // 
            lblTemiz.AutoSize = true;
            lblTemiz.Location = new Point(18, 72);
            lblTemiz.Name = "lblTemiz";
            lblTemiz.Size = new Size(50, 15);
            lblTemiz.TabIndex = 2;
            lblTemiz.Text = "Temiz: 0";
            // 
            // lblRiskli
            // 
            lblRiskli.AutoSize = true;
            lblRiskli.Location = new Point(18, 47);
            lblRiskli.Name = "lblRiskli";
            lblRiskli.Size = new Size(46, 15);
            lblRiskli.TabIndex = 1;
            lblRiskli.Text = "Riskli: 0";
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Location = new Point(18, 22);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(59, 15);
            lblToplam.TabIndex = 0;
            lblToplam.Text = "Toplam: 0";
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Format = DateTimePickerFormat.Short;
            dtpBaslangic.Location = new Point(18, 29);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(91, 23);
            dtpBaslangic.TabIndex = 5;
            dtpBaslangic.ValueChanged += dtpBaslangic_ValueChanged;
            // 
            // dtpBitis
            // 
            dtpBitis.Format = DateTimePickerFormat.Short;
            dtpBitis.Location = new Point(18, 58);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(91, 23);
            dtpBitis.TabIndex = 6;
            dtpBitis.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnFiltrele);
            groupBox2.Controls.Add(dtpBitis);
            groupBox2.Controls.Add(dtpBaslangic);
            groupBox2.Location = new Point(605, 139);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "TARİH FİLTRESİ";
            // 
            // btnFiltrele
            // 
            btnFiltrele.Location = new Point(115, 45);
            btnFiltrele.Name = "btnFiltrele";
            btnFiltrele.Size = new Size(75, 23);
            btnFiltrele.TabIndex = 7;
            btnFiltrele.Text = "GETİR";
            btnFiltrele.UseVisualStyleBackColor = true;
            btnFiltrele.Click += btnFiltrele_Click;
            // 
            // button1
            // 
            button1.Location = new Point(657, 480);
            button1.Name = "button1";
            button1.Size = new Size(99, 23);
            button1.TabIndex = 8;
            button1.Text = "EXCEL'E AKTAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnExcel_Click;
            // 
            // HastaListesiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnAra);
            Controls.Add(txtAra);
            Controls.Add(btnSil);
            Controls.Add(dgvList);
            MaximizeBox = false;
            Name = "HastaListesiForm";
            Text = "Hasta Listesi";
            Load += HastaListesiForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvList;
        private Button btnSil;
        private TextBox txtAra;
        private Button btnAra;
        private GroupBox groupBox1;
        private Label lblTemiz;
        private Label lblRiskli;
        private Label lblToplam;
        private DateTimePicker dtpBaslangic;
        private DateTimePicker dtpBitis;
        private GroupBox groupBox2;
        private Button btnFiltrele;
        private Button button1;
    }
}