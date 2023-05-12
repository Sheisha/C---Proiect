namespace ProiectFinal
{
    partial class FInscrieriAct
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
            this.nrcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.studentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new ProiectFinal.DataSet2();
            this.taxaInitialaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscriereContinutManevraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specializariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNrInscriere = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSpecializare = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtNrInscriere = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbSpecializare = new System.Windows.Forms.ComboBox();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.studentiTableAdapter = new ProiectFinal.DataSet2TableAdapters.StudentiTableAdapter();
            this.specializariTableAdapter = new ProiectFinal.DataSet2TableAdapters.SpecializariTableAdapter();
            this.lblAnStudiu = new System.Windows.Forms.Label();
            this.txtAnStudiu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscriereContinutManevraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrcDataGridViewTextBoxColumn,
            this.numeStudentDataGridViewTextBoxColumn,
            this.taxaInitialaDataGridViewTextBoxColumn,
            this.idStudentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inscriereContinutManevraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(49, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(470, 241);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // nrcDataGridViewTextBoxColumn
            // 
            this.nrcDataGridViewTextBoxColumn.DataPropertyName = "Nrc";
            this.nrcDataGridViewTextBoxColumn.HeaderText = "Nrc";
            this.nrcDataGridViewTextBoxColumn.Name = "nrcDataGridViewTextBoxColumn";
            // 
            // numeStudentDataGridViewTextBoxColumn
            // 
            this.numeStudentDataGridViewTextBoxColumn.DataPropertyName = "NumeStudent";
            this.numeStudentDataGridViewTextBoxColumn.DataSource = this.studentiBindingSource;
            this.numeStudentDataGridViewTextBoxColumn.DisplayMember = "NumeStudent";
            this.numeStudentDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.numeStudentDataGridViewTextBoxColumn.HeaderText = "NumeStudent";
            this.numeStudentDataGridViewTextBoxColumn.Name = "numeStudentDataGridViewTextBoxColumn";
            this.numeStudentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.numeStudentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // studentiBindingSource
            // 
            this.studentiBindingSource.DataMember = "Studenti";
            this.studentiBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taxaInitialaDataGridViewTextBoxColumn
            // 
            this.taxaInitialaDataGridViewTextBoxColumn.DataPropertyName = "TaxaInitiala";
            this.taxaInitialaDataGridViewTextBoxColumn.HeaderText = "TaxaInitiala";
            this.taxaInitialaDataGridViewTextBoxColumn.Name = "taxaInitialaDataGridViewTextBoxColumn";
            // 
            // idStudentDataGridViewTextBoxColumn
            // 
            this.idStudentDataGridViewTextBoxColumn.DataPropertyName = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn.HeaderText = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn.Name = "idStudentDataGridViewTextBoxColumn";
            // 
            // inscriereContinutManevraBindingSource
            // 
            this.inscriereContinutManevraBindingSource.DataMember = "InscriereContinutManevra";
            this.inscriereContinutManevraBindingSource.DataSource = this.dataSet2;
            this.inscriereContinutManevraBindingSource.CurrentChanged += new System.EventHandler(this.inscrieriContinutManevraBindingSource_CurrentChanged);
            // 
            // specializariBindingSource
            // 
            this.specializariBindingSource.DataMember = "Specializari";
            this.specializariBindingSource.DataSource = this.dataSet2;
            // 
            // lblNrInscriere
            // 
            this.lblNrInscriere.AutoSize = true;
            this.lblNrInscriere.Location = new System.Drawing.Point(46, 27);
            this.lblNrInscriere.Name = "lblNrInscriere";
            this.lblNrInscriere.Size = new System.Drawing.Size(61, 13);
            this.lblNrInscriere.TabIndex = 1;
            this.lblNrInscriere.Text = "Nr Inscriere";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(46, 61);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // lblSpecializare
            // 
            this.lblSpecializare.AutoSize = true;
            this.lblSpecializare.Location = new System.Drawing.Point(46, 92);
            this.lblSpecializare.Name = "lblSpecializare";
            this.lblSpecializare.Size = new System.Drawing.Size(64, 13);
            this.lblSpecializare.TabIndex = 3;
            this.lblSpecializare.Text = "Specializare";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(336, 85);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total";
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(420, 24);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(99, 13);
            this.lblOp.TabIndex = 5;
            this.lblOp.Text = "INSCRIERE NOUA";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(373, 85);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 6;
            // 
            // txtNrInscriere
            // 
            this.txtNrInscriere.Location = new System.Drawing.Point(113, 24);
            this.txtNrInscriere.Name = "txtNrInscriere";
            this.txtNrInscriere.Size = new System.Drawing.Size(100, 20);
            this.txtNrInscriere.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // cmbSpecializare
            // 
            this.cmbSpecializare.DataSource = this.specializariBindingSource;
            this.cmbSpecializare.DisplayMember = "DenumireSpecializare";
            this.cmbSpecializare.FormattingEnabled = true;
            this.cmbSpecializare.Location = new System.Drawing.Point(113, 89);
            this.cmbSpecializare.Name = "cmbSpecializare";
            this.cmbSpecializare.Size = new System.Drawing.Size(121, 21);
            this.cmbSpecializare.TabIndex = 9;
            this.cmbSpecializare.ValueMember = "IdSpecializare";
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(339, 17);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmare.TabIndex = 10;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // studentiTableAdapter
            // 
            this.studentiTableAdapter.ClearBeforeFill = true;
            // 
            // specializariTableAdapter
            // 
            this.specializariTableAdapter.ClearBeforeFill = true;
            // 
            // lblAnStudiu
            // 
            this.lblAnStudiu.AutoSize = true;
            this.lblAnStudiu.Location = new System.Drawing.Point(46, 128);
            this.lblAnStudiu.Name = "lblAnStudiu";
            this.lblAnStudiu.Size = new System.Drawing.Size(53, 13);
            this.lblAnStudiu.TabIndex = 11;
            this.lblAnStudiu.Text = "An Studiu";
            // 
            // txtAnStudiu
            // 
            this.txtAnStudiu.Location = new System.Drawing.Point(113, 128);
            this.txtAnStudiu.Name = "txtAnStudiu";
            this.txtAnStudiu.Size = new System.Drawing.Size(100, 20);
            this.txtAnStudiu.TabIndex = 12;
            // 
            // FInscrieriAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 459);
            this.Controls.Add(this.txtAnStudiu);
            this.Controls.Add(this.lblAnStudiu);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.cmbSpecializare);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtNrInscriere);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSpecializare);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNrInscriere);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FInscrieriAct";
            this.Text = "Inscriere";
            this.Load += new System.EventHandler(this.FInscrieriAct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscriereContinutManevraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.Label lblNrInscriere;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSpecializare;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtNrInscriere;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbSpecializare;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.BindingSource studentiBindingSource;
        private DataSet2TableAdapters.StudentiTableAdapter studentiTableAdapter;
        private DataSet2TableAdapters.SpecializariTableAdapter specializariTableAdapter;
        private System.Windows.Forms.BindingSource specializariBindingSource;
       // private System.Windows.Forms.DataGridViewComboBoxColumn denumireSpecializareDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblAnStudiu;
      //  private System.Windows.Forms.DataGridViewTextBoxColumn idSpecializareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn numeStudentDataGridViewTextBoxColumn;
       // private System.Windows.Forms.DataGridViewTextBoxColumn nrAniStudiuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxaInitialaDataGridViewTextBoxColumn;
       // private System.Windows.Forms.DataGridViewTextBoxColumn taxaAnualaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource inscriereContinutManevraBindingSource;
        private System.Windows.Forms.TextBox txtAnStudiu;
    }
}