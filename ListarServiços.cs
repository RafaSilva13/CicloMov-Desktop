using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CicloMov
{
    public partial class frmListarServicos : Form
    {
        DataTable Tbl5;
        public frmListarServicos()
        {
            InitializeComponent();
        }

        private void ListarServiços_Load(object sender, EventArgs e)
        {
            Tbl5 = new DataTable();

            Tbl5.Columns.Add("N°", typeof(int));
            Tbl5.Columns.Add("Código", typeof(int));
            Tbl5.Columns.Add("Clientes", typeof(string));
            Tbl5.Columns.Add("Ponto", typeof(string));
            Tbl5.Columns.Add("Tipo de Serviço", typeof(string));
            Tbl5.Columns.Add("Tempo Permanência", typeof(string));

            MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
            MySqlCommand comando = new MySqlCommand("SELECT * FROM servicos t1 INNER JOIN clientes t2 ON t1.id_clientes = t2.cod_clientes INNER JOIN pontos t3 ON t1.id_ponto = t3.cod_ponto", cnn);
            try
            {

                cnn.Open();

                MySqlDataReader myReader;
                myReader = comando.ExecuteReader();
                try
                {
                    while (myReader.Read())
                    {
                        int Max = dataGridView5.Rows.Count + 1;

                        DataRow Linha;

                        Linha = Tbl5.NewRow();

                        Linha[0] = Max;
                        Linha[1] = myReader.GetInt32(0);
                        Linha[2] = myReader.GetString(11);
                        Linha[3] = myReader.GetString(17);
                        Linha[4] = myReader.GetString(3);
                        Linha[5] = myReader.GetString(4);

                        Tbl5.Rows.Add(Linha);

                        dataGridView5.DataSource = Tbl5;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Tbl5.Clear();

            MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
            MySqlCommand comando = new MySqlCommand("SELECT * FROM servicos t1 INNER JOIN clientes t2 ON t1.id_clientes = t2.cod_clientes INNER JOIN pontos t3 ON t1.id_ponto = t3.cod_ponto", cnn);
            try
            {

                cnn.Open();

                MySqlDataReader myReader;
                myReader = comando.ExecuteReader();
                try
                {
                    while (myReader.Read())
                    {
                        int Max = dataGridView5.Rows.Count + 1;

                        DataRow Linha;

                        Linha = Tbl5.NewRow();

                        Linha[0] = Max;
                        Linha[1] = myReader.GetInt32(0);
                        Linha[2] = myReader.GetString(11);
                        Linha[3] = myReader.GetString(17);
                        Linha[4] = myReader.GetString(3);
                        Linha[5] = myReader.GetString(4);

                        Tbl5.Rows.Add(Linha);

                        dataGridView5.DataSource = Tbl5;

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

        private void txtPesquisarPontos_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisarServicos.Text == "")
            {
                Tbl5.Clear();

                MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
                MySqlCommand comando = new MySqlCommand("SELECT * FROM servicos t1 INNER JOIN clientes t2 ON t1.id_clientes = t2.cod_clientes INNER JOIN pontos t3 ON t1.id_ponto = t3.cod_ponto", cnn);
                try
                {

                    cnn.Open();

                    MySqlDataReader myReader;
                    myReader = comando.ExecuteReader();
                    try
                    {
                        while (myReader.Read())
                        {
                            int Max = dataGridView5.Rows.Count + 1;

                            DataRow Linha;

                            Linha = Tbl5.NewRow();

                            Linha[0] = Max;
                            Linha[1] = myReader.GetInt32(0);
                            Linha[2] = myReader.GetString(11);
                            Linha[3] = myReader.GetString(17);
                            Linha[4] = myReader.GetString(3);
                            Linha[5] = myReader.GetString(4);

                            Tbl5.Rows.Add(Linha);


                            dataGridView5.DataSource = Tbl5;

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
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
            MySqlCommand comando = new MySqlCommand("SELECT * FROM servicos t1 INNER JOIN clientes t2 ON t1.id_clientes = t2.cod_clientes INNER JOIN pontos t3 ON t1.id_ponto = t3.cod_ponto WHERE cod_servico = @codServico", cnn);
            try
            {
                comando.Parameters.AddWithValue("@codServico", txtPesquisarServicos.Text);
                cnn.Open();

                MySqlDataReader myReader;
                myReader = comando.ExecuteReader();
                try
                {
                    if (myReader.Read())
                    {
                        Tbl5.Clear();

                        int Max = dataGridView5.Rows.Count + 1;

                        DataRow Linha;

                        Linha = Tbl5.NewRow();

                        Linha[0] = Max;
                        Linha[1] = myReader.GetInt32(0);
                        Linha[2] = myReader.GetString(11);
                        Linha[3] = myReader.GetString(17);
                        Linha[4] = myReader.GetString(3);
                        Linha[5] = myReader.GetString(4);

                        Tbl5.Rows.Add(Linha);


                        dataGridView5.DataSource = Tbl5;

                    }
                    else
                    {
                        MessageBox.Show("Código não encontrado!");
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

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmMenu area_menu = new frmMenu();

            area_menu.Show();
        }
    }
}
