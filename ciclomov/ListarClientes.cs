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
    public partial class frmListarClientes : Form
    {
        DataTable Tbl;

        public frmListarClientes()
        {
            InitializeComponent();

        }

        private void ListarClientes_Load(object sender, EventArgs e)
        {

            Tbl = new DataTable();

            Tbl.Columns.Add("N°", typeof(int));
            Tbl.Columns.Add("Código", typeof(int));
            Tbl.Columns.Add("Nome Completo", typeof(string));
            Tbl.Columns.Add("Email", typeof(string));
            Tbl.Columns.Add("CPF", typeof(string));
            Tbl.Columns.Add("Tempo Total", typeof(string));
            Tbl.Columns.Add("Usuario", typeof(string));
            Tbl.Columns.Add("Telefone", typeof(string));

            MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
            MySqlCommand comando = new MySqlCommand("SELECT * FROM clientes", cnn);
            try
            {

                cnn.Open();

                MySqlDataReader myReader;
                myReader = comando.ExecuteReader();
                try
                {
                    while (myReader.Read())
                    {
                        int Max = dataGridView1.Rows.Count + 1;

                        DataRow Linha;

                        Linha = Tbl.NewRow();

                        Linha[0] = Max;
                        Linha[1] = myReader.GetInt32(0);
                        Linha[2] = myReader.GetString(6);
                        Linha[3] = myReader.GetString(1);
                        Linha[4] = myReader.GetString(2);
                        Linha[5] = myReader.GetString(3);
                        Linha[6] = myReader.GetString(4);
                        Linha[7] = myReader.GetString(7);

                        Tbl.Rows.Add(Linha);

                        dataGridView1.DataSource = Tbl;

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

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmDeletarClientes area_deletar = new frmDeletarClientes();

            area_deletar.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Tbl.Clear();

            MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
            MySqlCommand comando = new MySqlCommand("SELECT * FROM clientes", cnn);
            try
            {

                cnn.Open();

                MySqlDataReader myReader;
                myReader = comando.ExecuteReader();
                try
                {
                    while (myReader.Read())
                    {
                        int Max = dataGridView1.Rows.Count + 1;

                        DataRow Linha;

                        Linha = Tbl.NewRow();

                        Linha[0] = Max;
                        Linha[1] = myReader.GetInt32(0);
                        Linha[2] = myReader.GetString(6);
                        Linha[3] = myReader.GetString(1);
                        Linha[4] = myReader.GetString(2);
                        Linha[5] = myReader.GetString(3);
                        Linha[6] = myReader.GetString(4);
                        Linha[7] = myReader.GetString(7);

                        Tbl.Rows.Add(Linha);

                        dataGridView1.DataSource = Tbl;

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


        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
            MySqlCommand comando = new MySqlCommand("SELECT * FROM clientes WHERE nome_clientes = @nomeClientes", cnn);
            try
            {
                comando.Parameters.AddWithValue("@nomeClientes", txtPesquisarClientes.Text);
                cnn.Open();

                MySqlDataReader myReader;
                myReader = comando.ExecuteReader();
                try
                {
                    if (myReader.Read())
                    {
                        Tbl.Clear();

                        int Max = dataGridView1.Rows.Count + 1;

                        DataRow Linha;

                        Linha = Tbl.NewRow();

                        Linha[0] = Max;
                        Linha[1] = myReader.GetInt32(0);
                        Linha[2] = myReader.GetString(6);
                        Linha[3] = myReader.GetString(1);
                        Linha[4] = myReader.GetString(2);
                        Linha[5] = myReader.GetString(3);
                        Linha[6] = myReader.GetString(4);
                        Linha[7] = myReader.GetString(7);

                        Tbl.Rows.Add(Linha);


                        dataGridView1.DataSource = Tbl;

                    }
                    else
                    {
                        MessageBox.Show("Nome não encontrado!");
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

        private void txtPesquisarClientes_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisarClientes.Text == "")
            {
                Tbl.Clear();

                MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
                MySqlCommand comando = new MySqlCommand("SELECT * FROM clientes", cnn);
                try
                {

                    cnn.Open();

                    MySqlDataReader myReader;
                    myReader = comando.ExecuteReader();
                    try
                    {
                        while (myReader.Read())
                        {
                            int Max = dataGridView1.Rows.Count + 1;

                            DataRow Linha;

                            Linha = Tbl.NewRow();

                            Linha[0] = Max;
                            Linha[1] = myReader.GetInt32(0);
                            Linha[2] = myReader.GetString(6);
                            Linha[3] = myReader.GetString(1);
                            Linha[4] = myReader.GetString(2);
                            Linha[5] = myReader.GetString(3);
                            Linha[6] = myReader.GetString(4);
                            Linha[7] = myReader.GetString(7);

                            Tbl.Rows.Add(Linha);

                            dataGridView1.DataSource = Tbl;

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
    }
}
