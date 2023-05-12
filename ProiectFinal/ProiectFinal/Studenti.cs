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
    public partial class Studenti : Form
    {
        public Studenti()
        {
            InitializeComponent();
        }

        private void Studenti_Load(object sender, EventArgs e)
        {
            A1();
        }

        private void A1()
        {

            //Umple cu date obiectele DataTable: Persoane, Localitati (din DataSet):
            studentiTableAdapter.Fill(this.dataSet1.Studenti);

            //Configurare PB
            PB.SizeMode = PictureBoxSizeMode.StretchImage;

            //Protectie grid 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            //Protectie txtIdPersoana
            txtIdStudent.ReadOnly = true;

            A3();
        }

        private void A2()
        {
            //Configurare butoane
            configureazaButoane(false);

            //Dezlegare controale Panel
            legareControale(false);

            //Ridicare protectie controale Panel
            protectiePanel(false);

            //Modifcare lblOp
            lblOp.Text = "ADAUGARE";

            //Pozitionare cursor pe primul camp
            txtStudent.Focus();

            // Golire campuri
            golireCampuri();
        }

        private void A3()
        {
            //Initializare lblOp
            lblOp.Text = "";

            //Çonfigurare(butoane)
            configureazaButoane(true);

            //Protectie componente Panel
            protectiePanel(true);

            //Legare controale
            legareControale(true);
        }

        private void A4()
        {
            if (lblOp.Text == "ADAUGARE")
            {
                if (!validareCampuriObligatorii()) return;

                adauga_inregistrare();

                golireCampuri();

                //Pune cursor pe primul camp
                txtStudent.Focus();
                refresh_grid(studentiBindingSource.Position);
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                modifica_inregistrare();
                refresh_grid(studentiBindingSource.Position);
                A3();
            }
            else
                MessageBox.Show("Operatie actualizare neefectuata");
        }

        private void A5(TextBox txtB)
        {
            decimal p;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;

            if (lblOp.Text == "") return;
            if (txtB.Text == "") return;
            if (btnRenuntare.Focused) return;


            if (txtB == txtNrTelefon)
            {
                // Validare numericitate
                try { p = Convert.ToDecimal(txtB.Text); }
                catch { MessageBox.Show("Format eronat"); txtB.Focus(); }
                return;
            }


            if (txtB == txtCNP)
            {
                try { p = Convert.ToDecimal(txtB.Text); }
                catch { MessageBox.Show("Format eronat"); txtB.Focus(); }
                con.ConnectionString = studentiTableAdapter.Connection.ConnectionString;
                cmd.Connection = con;



                if (lblOp.Text == "ADAUGARE")
                {
                    cmd.CommandText = "Select NumeStudent From Studenti where CNP='" + txtCNP.Text + "'";
                    con.Open();
                    r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        MessageBox.Show("CNP deja existent");
                        txtCNP.Focus();
                    }
                    con.Close();
                }

                else if (lblOp.Text == "MODIFICARE")
                {
                    cmd.CommandText = "Select NumeStudent From Studenti where CNP='" + txtCNP.Text +
                                      "' and IdStudent  <> " + txtIdStudent.Text;
                    con.Open();
                    r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        MessageBox.Show("CNP deja existent");
                        txtCNP.Focus();
                    }
                    con.Close();
                }
            }
        }

        private void A6()
        {
            if (lblOp.Text == "")
                return;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSpImagine.Text = openFileDialog1.FileName;
                PB.ImageLocation = txtSpImagine.Text;
            }
        }
        private void A7()
        {
            //Configurare butoane
            configureazaButoane(false);

            //Dezlegare controale Panel
            legareControale(false);

            //Ridicare protectie controale Panel
            protectiePanel(false);

            //Modifcare lblOp
            lblOp.Text = "MODIFICARE";

            //Pozitionare cursor pe primul camp
            txtStudent.Focus();
        }

        private void A8()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;

            con.ConnectionString = studentiTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            cmd.CommandText = "Select IdStudent From InscrieriContinut where IdStudent=" + txtIdStudent.Text;
            con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Student referit in tabela inscrieri! Nu se poate sterge!");
                con.Close();
                return;
            }
            con.Close();

            cmd.CommandText = "Delete From Studenti Where IdStudent = " + txtIdStudent.Text;

            //MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            refresh_grid(studentiBindingSource.Position);

        }

        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;

            btnAdaugare.Enabled = v;
            btnModificare.Enabled = v;
            btnStergere.Enabled = v;
        }

        private void legareControale(bool v)
        {
            if (v)
            {
                txtStudent.DataBindings.Add("Text", studentiBindingSource, "NumeStudent");
                txtCNP.DataBindings.Add("Text", studentiBindingSource, "CNP");
                txtNrTelefon.DataBindings.Add("Text", studentiBindingSource, "NrTelefon");
                txtSpImagine.DataBindings.Add("Text", studentiBindingSource, "SpImagine");
                txtIdStudent.DataBindings.Add("Text", studentiBindingSource, "IdStudent");

                PB.DataBindings.Clear();
                PB.DataBindings.Add("ImageLocation", studentiBindingSource, "SpImagine");
            }
            else
            {
                txtStudent.DataBindings.Clear();
                txtCNP.DataBindings.Clear();
                txtNrTelefon.DataBindings.Clear();
                txtSpImagine.DataBindings.Clear();
                txtIdStudent.DataBindings.Clear();

                PB.DataBindings.Clear();
            }
        }
        private void protectiePanel(bool v)
        {
            txtStudent.ReadOnly = v;
            txtCNP.ReadOnly = v;
            txtNrTelefon.ReadOnly = v;
            txtSpImagine.ReadOnly = v;
        }
        private void golireCampuri()
        {
            txtStudent.Text = "";
            txtCNP.Text = "";
            txtIdStudent.Text = "";
            txtNrTelefon.Text = "";
            txtSpImagine.Text = "";
            PB.ImageLocation = "";
        }
        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile: Nume, CNP, Salariu, Localitate
            if (txtStudent.Text == "")
            {
                MessageBox.Show("Completati Nume Student !");
                txtStudent.Focus();
                return false;
            }
            if (txtCNP.Text == "")
            {
                MessageBox.Show("Completati CNP !");
                txtCNP.Focus();
                return false;
            }
            if (txtNrTelefon.Text == "")
            {
                MessageBox.Show("Completati Nr Telefon !");
                txtNrTelefon.Focus();
                return false;
            }

            return true;
        }

        private void adauga_inregistrare()
        {
            string listaCampuri;
            string listaValori;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = studentiTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            listaCampuri = "NumeStudent, CNP, NrTelefon, SpImagine";
            listaValori = 
                          "'" + txtStudent.Text + "'" +
                          ",'" + txtCNP.Text + "'" + 
                          ",'" + txtNrTelefon.Text + "'" +
                          ",'" + txtSpImagine.Text + "'";

            cmd.CommandText = "Insert into Studenti(" + listaCampuri + ") " +
                              "Select " + listaValori;

            //MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }
        private void refresh_grid(int p)
        {
            studentiTableAdapter.Fill(this.dataSet1.Studenti);
            studentiBindingSource.Position = p;
        }
        private void modifica_inregistrare()
        {
            string listaSet;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = studentiTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            listaSet = "NumeStudent = '" + txtStudent.Text + "'," +
                       "CNP = '" + txtCNP.Text + "'," +
                       "NrTelefon = '" + txtNrTelefon.Text + "'," +
                       "SpImagine = '" + txtSpImagine.Text + "'";

            cmd.CommandText = "Update Studenti Set " + listaSet + " Where IdStudent=" + txtIdStudent.Text;

           // MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            
        }
        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            A2();
        }
        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A3();
        }
        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A4();
        }
        private void btnModificare_Click(object sender, EventArgs e)
        {
            A7();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            A8();
        }
        private void txtSpImagine_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            A6();
        }

        private void txtCNP_Leave(object sender, EventArgs e)
        {
            A5(txtCNP);
        }

        private void txtNrTelefon_Leave(object sender, EventArgs e)
        {
            A5(txtNrTelefon);
        }

    }
}
