using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CicloMov
{
    public partial class frmDeletarCidades : Form
    {
        int verificarCidade;
        public frmDeletarCidades()
        {
            InitializeComponent();
        }

        private void frmDeletarCidades_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (ckbConfirmacaoCidade.Checked)
            {
                MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
                MySqlCommand comando2 = new MySqlCommand("SELECT * FROM cidades WHERE cod_cidade = @Id", cnn);
                MySqlCommand comando = new MySqlCommand("DELETE FROM cidades WHERE cod_cidade = @Id", cnn);
                try
                {
                    cnn.Open();

                    comando2.Parameters.AddWithValue("@Id", txtCodigoDeletarCidade.Text);
                    comando.Parameters.AddWithValue("@Id", txtCodigoDeletarCidade.Text);

                    MySqlDataReader myReader;

                    myReader = comando2.ExecuteReader();
                    try
                    {
                        if (myReader.Read())
                        {
                            verificarCidade = 1;
                        }
                    }
                    finally
                    {
                        myReader.Close();
                    }

                    if (verificarCidade == 1)
                    {
                        myReader = comando.ExecuteReader();

                        try
                        {
                            MessageBox.Show("Item deletado!");
                            txtCodigoDeletarCidade.Text = "";
                            ckbConfirmacaoCidade.Checked = false;
                            verificarCidade = 0;
                        }
                        finally
                        {
                            myReader.Close();
                            cnn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cidade não encontrado!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cidade não encontrado!");
                }
            }
            else
            {
                MessageBox.Show("Por favor marque a checkbox!");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmListarCidades area_cidades = new frmListarCidades();

            area_cidades.Show();
        }
    }
}
