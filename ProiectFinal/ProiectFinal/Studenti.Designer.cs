namespace ProiectFinal
{
    partial class Studenti
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
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStudent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PB = new System.Windows.Forms.PictureBox();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.txtNrTelefon = new System.Windows.Forms.TextBox();
            this.txtSpImagine = new System.Windows.Forms.TextBox();
            this.txtIdStudent = new System.Windows.Forms.TextBox();
            this.lblIdStudent = new System.Windows.Forms.Label();
            this.idStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spImagineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ProiectFinal.DataSet1();
            this.utilizatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilizatoriTableAdapter = new ProiectFinal.DataSet1TableAdapters.UtilizatoriTableAdapter();
            this.studentiTableAdapter = new ProiectFinal.DataSet1TableAdapters.StudentiTableAdapter();
            this.lblOp = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStudentDataGridViewTextBoxColumn,
            this.numeStudentDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn,
            this.nrTelefonDataGridViewTextBoxColumn,
            this.spImagineDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 205);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(34, 42);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugare.TabIndex = 1;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(138, 43);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(75, 23);
            this.btnModificare.TabIndex = 2;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(246, 43);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(75, 23);
            this.btnStergere.TabIndex = 3;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(606, 42);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmare.TabIndex = 4;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(700, 42);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(75, 23);
            this.btnRenuntare.TabIndex = 5;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblIdStudent);
            this.panel1.Controls.Add(this.txtIdStudent);
            this.panel1.Controls.Add(this.txtSpImagine);
            this.panel1.Controls.Add(this.txtNrTelefon);
            this.panel1.Controls.Add(this.txtCNP);
            this.panel1.Controls.Add(this.txtStudent);
            this.panel1.Controls.Add(this.PB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblStudent);
            this.panel1.Location = new System.Drawing.Point(606, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 226);
            this.panel1.TabIndex = 6;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(10, 13);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(44, 13);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CNP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NrTelefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SpImagine";
            // 
            // PB
            // 
            this.PB.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.studentiBindingSource, "SpImagine", true));
            this.PB.Location = new System.Drawing.Point(192, 79);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(135, 128);
            this.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB.TabIndex = 4;
            this.PB.TabStop = false;
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(73, 10);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(227, 20);
            this.txtStudent.TabIndex = 5;
            // 
            // txtCNP
            // 
            this.txtCNP.Location = new System.Drawing.Point(73, 41);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(100, 20);
            this.txtCNP.TabIndex = 6;
            this.txtCNP.Leave += new System.EventHandler(this.txtCNP_Leave);
            // 
            // txtNrTelefon
            // 
            this.txtNrTelefon.Location = new System.Drawing.Point(73, 79);
            this.txtNrTelefon.Name = "txtNrTelefon";
            this.txtNrTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtNrTelefon.TabIndex = 7;
            this.txtNrTelefon.Leave += new System.EventHandler(this.txtNrTelefon_Leave);
            // 
            // txtSpImagine
            // 
            this.txtSpImagine.Location = new System.Drawing.Point(73, 121);
            this.txtSpImagine.Name = "txtSpImagine";
            this.txtSpImagine.Size = new System.Drawing.Size(100, 20);
            this.txtSpImagine.TabIndex = 8;
            this.txtSpImagine.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSpImagine_MouseDoubleClick);
            // 
            // txtIdStudent
            // 
            this.txtIdStudent.Location = new System.Drawing.Point(69, 183);
            this.txtIdStudent.Name = "txtIdStudent";
            this.txtIdStudent.Size = new System.Drawing.Size(100, 20);
            this.txtIdStudent.TabIndex = 9;
            // 
            // lblIdStudent
            // 
            this.lblIdStudent.AutoSize = true;
            this.lblIdStudent.Location = new System.Drawing.Point(10, 186);
            this.lblIdStudent.Name = "lblIdStudent";
            this.lblIdStudent.Size = new System.Drawing.Size(53, 13);
            this.lblIdStudent.TabIndex = 10;
            this.lblIdStudent.Text = "IdStudent";
            // 
            // idStudentDataGridViewTextBoxColumn
            // 
            this.idStudentDataGridViewTextBoxColumn.DataPropertyName = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn.HeaderText = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn.Name = "idStudentDataGridViewTextBoxColumn";
            // 
            // numeStudentDataGridViewTextBoxColumn
            // 
            this.numeStudentDataGridViewTextBoxColumn.DataPropertyName = "NumeStudent";
            this.numeStudentDataGridViewTextBoxColumn.HeaderText = "NumeStudent";
            this.numeStudentDataGridViewTextBoxColumn.Name = "numeStudentDataGridViewTextBoxColumn";
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            // 
            // nrTelefonDataGridViewTextBoxColumn
            // 
            this.nrTelefonDataGridViewTextBoxColumn.DataPropertyName = "NrTelefon";
            this.nrTelefonDataGridViewTextBoxColumn.HeaderText = "NrTelefon";
            this.nrTelefonDataGridViewTextBoxColumn.Name = "nrTelefonDataGridViewTextBoxColumn";
            // 
            // spImagineDataGridViewTextBoxColumn
            // 
            this.spImagineDataGridViewTextBoxColumn.DataPropertyName = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.HeaderText = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.Name = "spImagineDataGridViewTextBoxColumn";
            // 
            // studentiBindingSource
            // 
            this.studentiBindingSource.DataMember = "Studenti";
            this.studentiBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilizatoriBindingSource
            // 
            this.utilizatoriBindingSource.DataMember = "Utilizatori";
            this.utilizatoriBindingSource.DataSource = this.dataSet1;
            // 
            // utilizatoriTableAdapter
            // 
            this.utilizatoriTableAdapter.ClearBeforeFill = true;
            // 
            // studentiTableAdapter
            // 
            this.studentiTableAdapter.ClearBeforeFill = true;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(795, 48);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(31, 13);
            this.lblOp.TabIndex = 7;
            this.lblOp.Text = "lblOp";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Studenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 366);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Studenti";
            this.Text = "Studenti";
            this.Load += new System.EventHandler(this.Studenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource utilizatoriBindingSource;
        private DataSet1TableAdapters.UtilizatoriTableAdapter utilizatoriTableAdapter;
        private System.Windows.Forms.BindingSource studentiBindingSource;
        private DataSet1TableAdapters.StudentiTableAdapter studentiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spImagineDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIdStudent;
        private System.Windows.Forms.TextBox txtIdStudent;
        private System.Windows.Forms.TextBox txtSpImagine;
        private System.Windows.Forms.TextBox txtNrTelefon;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}