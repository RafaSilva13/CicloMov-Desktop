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
    public partial class frmInserirCidades : Form
    {
        public frmInserirCidades()
        {
            InitializeComponent();
        }

        private void frmInserirCidades_Load(object sender, EventArgs e)
        {
            cbxEstado.Text = "";
            txtNomeCidade.Text = "";

            MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
            MySqlCommand comando = new MySqlCommand("SELECT * FROM estados", cnn);
            try
            {

                cnn.Open();

                MySqlDataReader myReader;

                myReader = comando.ExecuteReader();
                try
                {

                    int i = 0;

                    while (myReader.Read())
                    {
                        cbxEstado.Items.Insert(i, myReader.GetString(1));
                        i++;
                    }

                }
                finally
                {
                    myReader.Close();
                    cnn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (cbxEstado.Text != "" && txtNomeCidade.Text != "")
            {
                int estado = cbxEstado.SelectedIndex;
                string cidade = txtNomeCidade.Text;

                MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
                MySqlCommand comando = new MySqlCommand("INSERT INTO cidades (id_estado, descricao_cidade) VALUES (@idEstado, @descricao)", cnn);
                try
                {
                    cnn.Open();

                    comando.Parameters.AddWithValue("@idEstado", estado);
                    comando.Parameters.AddWithValue("@descricao", cidade);

                    MySqlDataReader myReader;
                    myReader = comando.ExecuteReader();
                    try
                    {
                        MessageBox.Show("Ponto inserido com sucesso!");

                        cbxEstado.Text = "";
                        txtNomeCidade.Text = "";

                    }
                    finally
                    {
                        myReader.Close();
                        cnn.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
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
