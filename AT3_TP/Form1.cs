using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AT3_TP
{
    public partial class Form1 : Form
    {
        //Declaration des Childs 
        Passager PassagerForm;
        Pilote PiloteForm;
        //Declaration des Connection est la command qu'il va etre execute
        string connection_String = @"data source = DESKTOP-7TC9CTO\SQLEXPRESS;database=VolAvion;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command;
        //declarer un pointer pour holder une method qu'il va gerer la connection est les command
        Action<string> Inserer_Info;
        public Form1()
        {
            InitializeComponent();
            Inserer_Info = query =>
            {
                try
                {
                    using (connection)
                    {
                        connection = new SqlConnection(connection_String);
                        command = new SqlCommand(query, connection);
                        connection.Open();
                        int nombre_lignes_affecte = command.ExecuteNonQuery();
                        MessageBox.Show(nombre_lignes_affecte + " lignes a ete affecte.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
        }
        void Changer_Form(Form NewForm)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            NewForm.MdiParent = this;
            NewForm.Dock = DockStyle.Fill;
            NewForm.Show();
        }

        private void passagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PassagerForm = new Passager(Inserer_Info);
            Changer_Form(PassagerForm);
        }

        private void piloteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PiloteForm = new Pilote(Inserer_Info);
            Changer_Form(PiloteForm);
        }
    }
}
