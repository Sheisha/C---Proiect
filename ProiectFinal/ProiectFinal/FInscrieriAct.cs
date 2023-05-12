using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace ProiectFinal
{
    public partial class FInscrieriAct : Form
    {

        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private int idCda;
        public BindingSource bs1;
        public BindingSource bs2;

        public FInscrieriAct()
        {
            InitializeComponent();
        }

        

        public void completeazaTitlu(String titlu)
        {
            lblOp.Text = titlu;
        }


        private void completeazaInscrierea()
        {
            DataRowView current = (DataRowView)bs1.Current;

            idCda = (int)current["IdInscriere"];
            txtNrInscriere.Text = Convert.ToString(current["NrInscriere"]);

            cmbSpecializare.Text = current["DenumireSpecializare"].ToString();
            txtAnStudiu.Text = Convert.ToString(current["AnStudiu"]);
            txtTotal.Text = current["Total"].ToString();

            dateTimePicker1.Value = Convert.ToDateTime(current["DataInscrierii"]);

            bs2.MoveFirst();

            dataSet2.InscriereContinutManevra.Clear();


            for (int i = 1; i <= bs2.Count; i++)
            {
                current = (DataRowView)bs2.Current;

                DataSet2.InscriereContinutManevraRow r = dataSet2.InscriereContinutManevra.NewInscriereContinutManevraRow();
                r.Nrc = Convert.ToInt16(current["Nrc"]);
                r.NumeStudent = Convert.ToString(current["NumeStudent"]);
               // r.NrAniStudiu = Convert.ToInt32(current["NrAniStudiu"]);
                r.TaxaInitiala = Convert.ToDecimal(current["TaxaInitiala"]);
               // r.TaxaAnuala = Convert.ToDecimal(current["TaxaAnuala"]);
                r.IdStudent = Convert.ToInt32(current["IdStudent"]);

                dataSet2.InscriereContinutManevra.Rows.Add(r);
                bs2.MoveNext();
            }
        }

        private void A1()
        {
            //Incarcare DataTable Produse
            specializariTableAdapter.Fill(dataSet2.Specializari);

            //Incarcare DataTable Clienti
            studentiTableAdapter.Fill(dataSet2.Studenti);

            //Setare lblOp
            //lblOp.Text = "COMANDA NOUA";

            // Protectie la modificare
            txtNrInscriere.ReadOnly = true;
            txtTotal.ReadOnly = true;

            nrcDataGridViewTextBoxColumn.ReadOnly = true;
          //  nrAniStudiuDataGridViewTextBoxColumn.ReadOnly = true;
            //taxaInitialaDataGridViewTextBoxColumn.ReadOnly = true;
          //  taxaAnualaDataGridViewTextBoxColumn.ReadOnly = true;
            idStudentDataGridViewTextBoxColumn.ReadOnly = true;

            // Initializare cmbClient
            //cmbStudent.SelectedIndex = -1;

             if (lblOp.Text == "MODIFICARE INSCRIERE") completeazaInscrierea();
              else if (lblOp.Text == "INSCRIERE NOUA") cmbSpecializare.SelectedIndex = -1;

        }

        //private void A2()
        //{
        //    if (!validareCampuriObligatorii()) return;
        //    generez_nr_cda();
        //    // Scriu inregistrare in Comenzi si ComenziContinut
        //    adaugaInregistrareComenzi();
        //    cautaInregistrare();
        //    adaugaInregistrariComenziContinut();
        //    golireCampuri();

        //}


        private void A2()
        {
            if (!validareCampuriObligatorii()) return;
            if (lblOp.Text == "MODIFICARE INSCRIERE")
            {
                modificaInregistrare();
                stergeContinut();
                adaugaInregistrariComenziContinut();
                this.Close();
            }
            else if (lblOp.Text == "INSCRIERE NOUA")
            {
                generez_nr_cda();
                adaugaInregistrareComenzi();
                cautaInregistrare();
                adaugaInregistrariComenziContinut();
                golireCampuri();
            }

        }


        private void A3()
        {
            // Generare NrCrt
            DataRowView current = (DataRowView)inscriereContinutManevraBindingSource.Current;
            current["Nrc"] = inscriereContinutManevraBindingSource.Position + 1;
        }

        private void A4()
        {
            try
            {


                if (dataGridView1.CurrentCell.ColumnIndex == 1)
                {
                    DataRowView current = (DataRowView)studentiBindingSource.Current;


                    dataGridView1.CurrentRow.Cells[3].Value = current["IdStudent"];
                    calcTotal();
                }
                    if (dataGridView1.CurrentCell.ColumnIndex == 2)
                    {
                        inscriereContinutManevraBindingSource.EndEdit();
                        calcTotal();
                    }
                }
            
            catch { }


        }

        


        private void A5(DataGridViewRowCancelEventArgs e)
        {

            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (rezultat == DialogResult.No) e.Cancel = true;
        }

        private void FInscrieriAct_Load(object sender, EventArgs e)
        {
            
            A1();
        }

        private void inscrieriContinutManevraBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            A3();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            A4();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            A5(e);
        }


        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Format eronat");
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            calcTotal();
        }
        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A2();
        }




        private void calcTotal()
        { // Calcul total valori
            decimal t = 0;
            foreach (DataRow r in dataSet2.InscriereContinutManevra)
            {
                if (r["TaxaInitiala"] != DBNull.Value)
                    t += (decimal)r["TaxaInitiala"];
            }

            txtTotal.Text = Convert.ToString(t);
        }


        private void adaugaInregistrareComenzi()
        {
            
            string listaCampuri;
            string listaValori;
            DateTime d = dateTimePicker1.Value;

          //  DataRowView current = (DataRowView)inscriereContinutManevraBindingSource.Current;

            listaCampuri = "NrInscriere, DataInscrierii, IdSpecializare, AnStudiu";

   

            listaValori = txtNrInscriere.Text +
                          ",#" + Convert.ToString(d.Month) + "/"
                               + Convert.ToString(d.Day) + "/"
                               + Convert.ToString(d.Year) + "#,"
                               + cmbSpecializare.SelectedValue + ","
                               + txtAnStudiu.Text;

            cmd.CommandText = "Insert into Inscrieri(" + listaCampuri + ") " +
                              "Select " + listaValori;

            //MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void cautaInregistrare()
        {
            cmd.CommandText = "SELECT idInscriere From Inscrieri Where NrInscriere = " +
            txtNrInscriere.Text;

            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();

            idCda = rdr.GetInt32(0);
            rdr.Close();
            con.Close();
        }

        private void adaugaInregistrariComenziContinut()
        {
            string listaCampuri = "IdInscriere, Nrc, IdStudent, TaxaInitiala";
            string listaValori;

            con.Open();
            foreach (DataRow r in dataSet2.InscriereContinutManevra)
            {
                listaValori = idCda + "," + r["Nrc"] + "," + r["IdStudent"] + "," +
r["TaxaInitiala"];

                cmd.CommandText = "Insert into InscrieriContinut(" + listaCampuri + ") " +
"Select " + listaValori;
              //  MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }



        private void golireCampuri()
        {
            txtNrInscriere.Text = "";
            cmbSpecializare.SelectedIndex = -1;
            txtAnStudiu.Text = "";
            txtTotal.Text = "";
            dataSet2.InscriereContinutManevra.Clear();
        }

        private void generez_nr_cda()
        {
            con.ConnectionString = studentiTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;
            cmd.CommandText = "SELECT Max(Inscrieri.NrInscriere) AS NrMax FROM Inscrieri";

            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();

            txtNrInscriere.Text = Convert.ToString(rdr.GetInt32(0) + 1);
            rdr.Close();
            con.Close();
        }

        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campul Student
            if (cmbSpecializare.Text == "")
            {
                MessageBox.Show("Completati Specializare!");
                cmbSpecializare.Focus();
                return false;
            }
            if (txtAnStudiu.Text == "")
            {
                MessageBox.Show("Completati An Studiu!");
                txtAnStudiu.Focus();
                return false;
            }

            // Validare completare continut
            if (inscriereContinutManevraBindingSource.Count == 0)
            {
                MessageBox.Show("Completati inscriere !");
                dataGridView1.Focus();
                return false;
            }
            return true;
        }

        private void modificaInregistrare()
        {
            DateTime d1 = dateTimePicker1.Value;

            con.ConnectionString = specializariTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            DataRowView current = (DataRowView)inscriereContinutManevraBindingSource.Current;

            string clauzaWhere = " Where IdInscriere = " + idCda;

            string clauzaSet = "Set DataInscrierii = #" + d1.Month + "/"
                               + d1.Day + "/"
                               + d1.Year + "#," 
                               + "IdSpecializare = " + cmbSpecializare.SelectedValue 
                               + ", AnStudiu = "+ txtAnStudiu.Text;


            cmd.CommandText = "Update Inscrieri " + clauzaSet + clauzaWhere;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }


        private void stergeContinut()
        {
            cmd.CommandText = "Delete from InscrieriContinut Where IdInscriere = " + idCda;

            con.Open();
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
