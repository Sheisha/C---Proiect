namespace ProiectFinal
{
    partial class Inscrieri
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
            this.nrInscriereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInscrieriiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSpecializareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anStudiuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idInscriereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireSpecializareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscrieriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new ProiectFinal.DataSet2();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idInscriereDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxaInitialaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscrieriContinutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet21 = new ProiectFinal.DataSet2();
            this.txtIdInscriere = new System.Windows.Forms.TextBox();
            this.btnInscriereNoua = new System.Windows.Forms.Button();
            this.btnModificareInscriere = new System.Windows.Forms.Button();
            this.btnStergeInscriere = new System.Windows.Forms.Button();
            this.inscrieriTableAdapter = new ProiectFinal.DataSet2TableAdapters.InscrieriTableAdapter();
            this.inscrieriContinutTableAdapter = new ProiectFinal.DataSet2TableAdapters.InscrieriContinutTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscrieriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscrieriContinutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrInscriereDataGridViewTextBoxColumn,
            this.dataInscrieriiDataGridViewTextBoxColumn,
            this.idSpecializareDataGridViewTextBoxColumn,
            this.anStudiuDataGridViewTextBoxColumn,
            this.idInscriereDataGridViewTextBoxColumn,
            this.denumireSpecializareDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inscrieriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 205);
            this.dataGridView1.TabIndex = 0;
            // 
            // nrInscriereDataGridViewTextBoxColumn
            // 
            this.nrInscriereDataGridViewTextBoxColumn.DataPropertyName = "NrInscriere";
            this.nrInscriereDataGridViewTextBoxColumn.HeaderText = "NrInscriere";
            this.nrInscriereDataGridViewTextBoxColumn.Name = "nrInscriereDataGridViewTextBoxColumn";
            // 
            // dataInscrieriiDataGridViewTextBoxColumn
            // 
            this.dataInscrieriiDataGridViewTextBoxColumn.DataPropertyName = "DataInscrierii";
            this.dataInscrieriiDataGridViewTextBoxColumn.HeaderText = "DataInscrierii";
            this.dataInscrieriiDataGridViewTextBoxColumn.Name = "dataInscrieriiDataGridViewTextBoxColumn";
            // 
            // idSpecializareDataGridViewTextBoxColumn
            // 
            this.idSpecializareDataGridViewTextBoxColumn.DataPropertyName = "IdSpecializare";
            this.idSpecializareDataGridViewTextBoxColumn.HeaderText = "IdSpecializare";
            this.idSpecializareDataGridViewTextBoxColumn.Name = "idSpecializareDataGridViewTextBoxColumn";
            // 
            // anStudiuDataGridViewTextBoxColumn
            // 
            this.anStudiuDataGridViewTextBoxColumn.DataPropertyName = "AnStudiu";
            this.anStudiuDataGridViewTextBoxColumn.HeaderText = "AnStudiu";
            this.anStudiuDataGridViewTextBoxColumn.Name = "anStudiuDataGridViewTextBoxColumn";
            // 
            // idInscriereDataGridViewTextBoxColumn
            // 
            this.idInscriereDataGridViewTextBoxColumn.DataPropertyName = "IdInscriere";
            this.idInscriereDataGridViewTextBoxColumn.HeaderText = "IdInscriere";
            this.idInscriereDataGridViewTextBoxColumn.Name = "idInscriereDataGridViewTextBoxColumn";
            // 
            // denumireSpecializareDataGridViewTextBoxColumn
            // 
            this.denumireSpecializareDataGridViewTextBoxColumn.DataPropertyName = "DenumireSpecializare";
            this.denumireSpecializareDataGridViewTextBoxColumn.HeaderText = "DenumireSpecializare";
            this.denumireSpecializareDataGridViewTextBoxColumn.Name = "denumireSpecializareDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // inscrieriBindingSource
            // 
            this.inscrieriBindingSource.DataMember = "Inscrieri";
            this.inscrieriBindingSource.DataSource = this.dataSet2;
            this.inscrieriBindingSource.PositionChanged += new System.EventHandler(this.inscrieriBindingSource_PositionChanged);
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInscriereDataGridViewTextBoxColumn1,
            this.nrcDataGridViewTextBoxColumn,
            this.idStudentDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.taxaInitialaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.inscrieriContinutBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(19, 251);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(548, 186);
            this.dataGridView2.TabIndex = 1;
            // 
            // idInscriereDataGridViewTextBoxColumn1
            // 
            this.idInscriereDataGridViewTextBoxColumn1.DataPropertyName = "IdInscriere";
            this.idInscriereDataGridViewTextBoxColumn1.HeaderText = "IdInscriere";
            this.idInscriereDataGridViewTextBoxColumn1.Name = "idInscriereDataGridViewTextBoxColumn1";
            this.idInscriereDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nrcDataGridViewTextBoxColumn
            // 
            this.nrcDataGridViewTextBoxColumn.DataPropertyName = "Nrc";
            this.nrcDataGridViewTextBoxColumn.HeaderText = "Nrc";
            this.nrcDataGridViewTextBoxColumn.Name = "nrcDataGridViewTextBoxColumn";
            // 
            // idStudentDataGridViewTextBoxColumn
            // 
            this.idStudentDataGridViewTextBoxColumn.DataPropertyName = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn.HeaderText = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn.Name = "idStudentDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NumeStudent";
            this.dataGridViewTextBoxColumn1.HeaderText = "NumeStudent";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // taxaInitialaDataGridViewTextBoxColumn
            // 
            this.taxaInitialaDataGridViewTextBoxColumn.DataPropertyName = "TaxaInitiala";
            this.taxaInitialaDataGridViewTextBoxColumn.HeaderText = "TaxaInitiala";
            this.taxaInitialaDataGridViewTextBoxColumn.Name = "taxaInitialaDataGridViewTextBoxColumn";
            // 
            // inscrieriContinutBindingSource
            // 
            this.inscrieriContinutBindingSource.DataMember = "InscrieriContinut";
            this.inscrieriContinutBindingSource.DataSource = this.dataSet21;
            // 
            // dataSet21
            // 
            this.dataSet21.DataSetName = "DataSet2";
            this.dataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtIdInscriere
            // 
            this.txtIdInscriere.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscrieriBindingSource, "IdInscriere", true));
            this.txtIdInscriere.Location = new System.Drawing.Point(792, 46);
            this.txtIdInscriere.Name = "txtIdInscriere";
            this.txtIdInscriere.ReadOnly = true;
            this.txtIdInscriere.Size = new System.Drawing.Size(135, 20);
            this.txtIdInscriere.TabIndex = 2;
            // 
            // btnInscriereNoua
            // 
            this.btnInscriereNoua.Location = new System.Drawing.Point(792, 84);
            this.btnInscriereNoua.Name = "btnInscriereNoua";
            this.btnInscriereNoua.Size = new System.Drawing.Size(135, 23);
            this.btnInscriereNoua.TabIndex = 3;
            this.btnInscriereNoua.Text = "Inscriere Noua";
            this.btnInscriereNoua.UseVisualStyleBackColor = true;
            this.btnInscriereNoua.Click += new System.EventHandler(this.btnInscriereNoua_Click);
            // 
            // btnModificareInscriere
            // 
            this.btnModificareInscriere.Location = new System.Drawing.Point(792, 113);
            this.btnModificareInscriere.Name = "btnModificareInscriere";
            this.btnModificareInscriere.Size = new System.Drawing.Size(135, 23);
            this.btnModificareInscriere.TabIndex = 4;
            this.btnModificareInscriere.Text = "Modificare Inscriere";
            this.btnModificareInscriere.UseVisualStyleBackColor = true;
            this.btnModificareInscriere.Click += new System.EventHandler(this.btnModificareInscriere_Click);
            // 
            // btnStergeInscriere
            // 
            this.btnStergeInscriere.Location = new System.Drawing.Point(792, 142);
            this.btnStergeInscriere.Name = "btnStergeInscriere";
            this.btnStergeInscriere.Size = new System.Drawing.Size(135, 23);
            this.btnStergeInscriere.TabIndex = 5;
            this.btnStergeInscriere.Text = "Sterge Inscriere";
            this.btnStergeInscriere.UseVisualStyleBackColor = true;
            this.btnStergeInscriere.Click += new System.EventHandler(this.btnStergeInscriere_Click);
            // 
            // inscrieriTableAdapter
            // 
            this.inscrieriTableAdapter.ClearBeforeFill = true;
            // 
            // inscrieriContinutTableAdapter
            // 
            this.inscrieriContinutTableAdapter.ClearBeforeFill = true;
            // 
            // Inscrieri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 494);
            this.Controls.Add(this.btnStergeInscriere);
            this.Controls.Add(this.btnModificareInscriere);
            this.Controls.Add(this.btnInscriereNoua);
            this.Controls.Add(this.txtIdInscriere);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Inscrieri";
            this.Text = "Inscrieri";
            this.Load += new System.EventHandler(this.Inscrieri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscrieriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscrieriContinutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtIdInscriere;
        private System.Windows.Forms.Button btnInscriereNoua;
        private System.Windows.Forms.Button btnModificareInscriere;
        private System.Windows.Forms.Button btnStergeInscriere;
        private DataSet2 dataSet2;
        private DataSet2TableAdapters.InscrieriTableAdapter inscrieriTableAdapter;
        
        private DataSet2TableAdapters.InscrieriContinutTableAdapter inscrieriContinutTableAdapter;
        private System.Windows.Forms.BindingSource inscrieriBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrInscriereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInscrieriiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSpecializareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anStudiuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInscriereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireSpecializareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private DataSet2 dataSet21;
        private System.Windows.Forms.BindingSource inscrieriContinutBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInscriereDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxaInitialaDataGridViewTextBoxColumn;
    }
}