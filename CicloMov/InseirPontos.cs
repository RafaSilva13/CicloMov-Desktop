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
    public partial class frmInseirPontos : Form
    {
        int idcidade;
        string cidadeEscolhido;
        public frmInseirPontos()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmListarPontos area_pontos = new frmListarPontos();

            area_pontos.Show();
        }

        private void frmInseirPontos_Load(object sender, EventArgs e)
        {
            cbxEstado.Text = "";
            cbxCidade.Text = "";
            txtVagasTotais.Text = "";
            txtLinkMaps.Text = "";
            txtDescricao.Text = "";
            cbxCidade.Items.Clear();

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

        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cbxEstado.SelectedIndex;
            cbxCidade.Text = "";
            cbxCidade.Items.Clear();

            MySqlConnection cnn2 = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
            MySqlCommand comando2 = new MySqlCommand("SELECT * FROM cidades WHERE id_estado = @idEstado", cnn2);
            try
            {
                comando2.Parameters.AddWithValue("@idEstado", indice);

                cnn2.Open(); 

                MySqlDataReader myReader;

                myReader = comando2.ExecuteReader();
                try
                {
                    int i = 0;

                    while (myReader.Read())
                    {
                        cbxCidade.Items.Insert(i, myReader.GetString(2));
                        i++;
                    }

                }
                finally
                {
                    myReader.Close();
                    cnn2.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (cbxEstado.Text != "" && cbxCidade.Text != "" && txtVagasTotais.Text != "" && txtLinkMaps.Text != "" && txtDescricao.Text != "") { 
                int estado = cbxEstado.SelectedIndex;
                int cidade = idcidade;

                MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
                MySqlCommand comando = new MySqlCommand("INSERT INTO pontos (id_estado, id_cidade, vagas_livres_ponto, vagas_totais_ponto, mapa, descricao) VALUES (@idEstado, @idCidade, @vagasLivres, @vagasTotais, @link, @descricao);", cnn);
                try
                {
                    cnn.Open();

                    comando.Parameters.AddWithValue("@idEstado", estado);
                    comando.Parameters.AddWithValue("@idCidade", cidade);
                    comando.Parameters.AddWithValue("@vagasLivres", txtVagasTotais.Text);
                    comando.Parameters.AddWithValue("@vagasTotais", txtVagasTotais.Text);
                    comando.Parameters.AddWithValue("@link", txtLinkMaps.Text);
                    comando.Parameters.AddWithValue("@descricao", txtDescricao.Text);

                    MySqlDataReader myReader;
                    myReader = comando.ExecuteReader();
                    try
                    {
                        MessageBox.Show("Ponto inserido com sucesso!");

                        cbxEstado.Text = "";
                        cbxCidade.Text = "";
                        txtVagasTotais.Text = "";
                        txtLinkMaps.Text = "";
                        txtDescricao.Text = "";
                        cbxCidade.Items.Clear();
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

        private void cbxCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            cidadeEscolhido = cbxCidade.Text;

            MySqlConnection cnn2 = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
            MySqlCommand comando2 = new MySqlCommand("SELECT cod_cidade FROM cidades WHERE descricao_cidade = @nomeCidade", cnn2);
            try
            {
                comando2.Parameters.AddWithValue("@nomeCidade", cidadeEscolhido);

                cnn2.Open();

                MySqlDataReader myReader;

                myReader = comando2.ExecuteReader();
                try
                {
                    while (myReader.Read())
                    {
                        idcidade = myReader.GetInt32(0);
                    }

                }
                finally
                {
                    myReader.Close();
                    cnn2.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
