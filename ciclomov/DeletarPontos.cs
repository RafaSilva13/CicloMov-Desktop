using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Google.Protobuf.WellKnownTypes;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CicloMov
{
    public partial class frmDeletarPonto : Form
    {
        int verificarPonto;
        public frmDeletarPonto()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmListarPontos area_pontos = new frmListarPontos();

            area_pontos.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (ckbConfirmacaoPonto.Checked)
            {
                MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
                MySqlCommand comando2 = new MySqlCommand("SELECT * FROM pontos WHERE cod_ponto = @Id", cnn);
                MySqlCommand comando = new MySqlCommand("DELETE FROM pontos WHERE cod_ponto = @Id", cnn);
                try
                {
                    cnn.Open();

                    comando2.Parameters.AddWithValue("@Id", txtCodigoDeletarPonto.Text);
                    comando.Parameters.AddWithValue("@Id", txtCodigoDeletarPonto.Text);
                    
                    MySqlDataReader myReader;

                    myReader = comando2.ExecuteReader();
                    try
                    {
                        if(myReader.Read())
                        {
                            verificarPonto = 1;
                        }
                    }
                    finally
                    {
                        myReader.Close();
                    }

                    if(verificarPonto == 1)
                    {
                        myReader = comando.ExecuteReader();

                        try
                        {
                            MessageBox.Show("Item deletado!");
                            txtCodigoDeletarPonto.Text = "";
                            ckbConfirmacaoPonto.Checked = false;
                            verificarPonto = 0;
                        }
                        finally
                        {
                            myReader.Close();
                            cnn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ponto não encontrado!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ponto não encontrado!");
                }
            }
            else
            {
                MessageBox.Show("Por favor marque a checkbox!");
            }
        }

        private void txtCodigoDeletarPonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDeletarPonto_Load(object sender, EventArgs e)
        {

        }
    }
}
