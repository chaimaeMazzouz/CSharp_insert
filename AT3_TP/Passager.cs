using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT3_TP
{
    public partial class Passager : Form
    {
        Action<string> Insert_Info;
        public Passager(Action<string> insert_Info)
        {
            InitializeComponent();
            Insert_Info = insert_Info;
        }

        private void Inserer_Passanger_Click(object sender, EventArgs e)
        {
            string ma_query = string.Format("insert into passager values('{0}','{1}','{2}','{3}')", Passager_Pass.Text, Passager_Nom.Text, Passager_Prenom.Text, Passager_ville.Text);
            Insert_Info(ma_query);
        }
    }
}
