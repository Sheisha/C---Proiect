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
    public partial class Inscrieri : Form
    {

        public Inscrieri()
        {
            InitializeComponent();
        }


        private void refreshGrid()
        {
            inscrieriTableAdapter.Fill(dataSet2.Inscrieri);
            inscrieriContinutTableAdapter.Fill(dataSet21.InscrieriContinut);
        }

        private void Inscrieri_Load(object sender, EventArgs e)
        {
            

            refreshGrid();

            try
            {
                inscrieriContinutBindingSource.Filter = "IdInscriere=" + txtIdInscriere.Text;
            }
            catch { }


        }

        private void inscrieriBindingSource_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                inscrieriContinutBindingSource.Filter = "IdInscriere=" + txtIdInscriere.Text;
            }
            catch { }
        }


        private void btnInscriereNoua_Click(object sender, EventArgs e)
        {
            FInscrieriAct f = new FInscrieriAct();
            f.ShowDialog();
            refreshGrid();

            try
            {
                inscrieriContinutBindingSource.Filter = "IdInscriere=" + txtIdInscriere.Text;
            }
            catch { }
        }

        private void btnModificareInscriere_Click(object sender, EventArgs e)
        {
            FInscrieriAct f = new FInscrieriAct();
            f.completeazaTitlu("MODIFICARE INSCRIERE");
            f.bs1 = inscrieriBindingSource;
            f.bs2 = inscrieriContinutBindingSource;
            f.ShowDialog();
            refreshGrid();

            try
            {
                inscrieriContinutBindingSource.Filter = "IdInscriere=" + txtIdInscriere.Text;
            }
            catch { }
        }



        private void btnStergeInscriere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";

            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = inscrieriTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            // Sterg continut comanda
            cmd.CommandText = "Delete From InscrieriContinut Where IdInscriere = " + txtIdInscriere.Text;

            //MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            // Sterg comanda
            cmd.CommandText = "Delete From Inscrieri Where IdInscriere = " + txtIdInscriere.Text;
           // MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();

            con.Close();

            // Refresh grid-uri
            refreshGrid();

            try
            {
                inscrieriContinutBindingSource.Filter = "IdInscriere=" + txtIdInscriere.Text;
            }
            catch { }
        }

        
    }
}

