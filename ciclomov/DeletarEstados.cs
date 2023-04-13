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
    public partial class frmDeletarEstados : Form
    {
        int verificarEstado;
        public frmDeletarEstados()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmListarEstados area_ListarEstados = new frmListarEstados();

            area_ListarEstados.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (ckbConfirmacaoEstado.Checked)
            {
                MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
                MySqlCommand comando2 = new MySqlCommand("SELECT * FROM estados WHERE cod_estado = @Id", cnn);
                MySqlCommand comando = new MySqlCommand("DELETE FROM estados WHERE cod_estado = @Id", cnn);
                try
                {
                    cnn.Open();

                    comando2.Parameters.AddWithValue("@Id", txtCodigoDeletarEstado.Text);
                    comando.Parameters.AddWithValue("@Id", txtCodigoDeletarEstado.Text);

                    MySqlDataReader myReader;

                    myReader = comando2.ExecuteReader();
                    try
                    {
                        if (myReader.Read())
                        {
                            verificarEstado = 1;
                        }
                    }
                    finally
                    {
                        myReader.Close();
                    }

                    if (verificarEstado == 1)
                    {
                        myReader = comando.ExecuteReader();

                        try
                        {
                            MessageBox.Show("Item deletado!");
                            txtCodigoDeletarEstado.Text = "";
                            ckbConfirmacaoEstado.Checked = false;
                            verificarEstado = 0;
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
    }
}
