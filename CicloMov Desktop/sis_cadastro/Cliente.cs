using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using CicloMov.Entities;
using CicloMov.IRepositories;
using Microsoft.Extensions.DependencyInjection;
using Xamarin.Forms.Internals;

namespace CicloMov
{
    public partial class frm_cliente : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;
        String strsql;
        private object dataGrid1;

        private readonly IClientesRepository _clientesRepository;

        public frm_cliente(IClientesRepository clientesRepository)
        {
            InitializeComponent();
            _clientesRepository = clientesRepository;
            PreencherTabela();
        }

        private void PreencherTabela()
        {
            dataGridView1.DataSource = _clientesRepository.GetAll();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {


            //var cliente = new Clientes()
            //{
            //    Email = ""
            //};
            //var sucesso = _clientesRepository.Insert(cliente);



        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            txt_cod_cliente.Enabled = false;
            //INÍCIO DO BLOCO DE PROGRAMAÇÃO
            if (txt_cod_cliente.Text == "" || txt_email_cliente.Text == "" || txt_tempo_cliente.Text == "" || txt_cpf_cliente.Text == "")
            {
                MessageBox.Show("Preencha todos os campos para prosseguir!");
            }
            else
            {
                try
                {
                    //A variável conexao define uma string para conexão com o BD.
                    conexao = new SqlConnection(@"Server=LAB136-16\SQLEXPRESS; Database=bd_cadastro_clayteam; User id=sa; Password=123456;");
                    strsql = "UPDATE clientes SET nome_cliente = @nome_cliente, end_cliente = @end_cliente, cel_cliente = @cel_cliente, cpf_cliente = @cpf_cliente WHERE codigo_cliente = @codigo_cliente";
                    comando = new SqlCommand(strsql, conexao);
                    comando.Parameters.AddWithValue("@codigo_cliente",
                    txt_cod_cliente.Text);
                    comando.Parameters.AddWithValue("@nome_cliente",
                    txt_email_cliente.Text);
                    comando.Parameters.AddWithValue("@end_cliente",
                    txt_tempo_cliente.Text);
                    comando.Parameters.AddWithValue("@cpf_cliente",
                    txt_cpf_cliente.Text);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("CADASTRO ATUALIZADO COM SUCESSO!!");

                    txt_cod_cliente.Text = "";
                    txt_email_cliente.Text = "";
                    txt_tempo_cliente.Text = "";
                    txt_cpf_cliente.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexao.Close();
                    conexao = null;
                    comando = null;
                }
            }
            //FIM DO BLOCO DE PROGRAMAÇÃO
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            //INÍCIO DO BLOCO DE PROGRAMAÇÃO
            if (txt_cod_cliente.Text == "")
            {
                MessageBox.Show("Preencha todos os campos para prosseguir!");
            }
            else
            {
                try
                {
                    //A variável conexao define uma string para conexão com o BD.
                    conexao = new SqlConnection(@"Server=LAB136-16\SQLEXPRESS; Database=bd_cadastro_clayteam; User id=sa; Password=123456;");

                    //Sua rotina de exclusão
                    //Confirmando exclusão para o usuário

                    //A variável conexao define uma string para conexão com o BD.
                    conexao = new SqlConnection(@"Server=LAB136-16\SQLEXPRESS;
                Database=bd_cadastro_clayteam; User id=sa; Password=123456;");

                    if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        strsql = "DELETE clientes WHERE codigo_cliente = @codigo_cliente";
                        comando = new SqlCommand(strsql, conexao);
                        comando.Parameters.AddWithValue("@codigo_cliente",
                        txt_cod_cliente.Text);
                        conexao.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("REGISTRO APAGADO COM SUCESSO!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Operação Cancelada!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexao.Close();
                    conexao = null;
                    comando = null;
                }
                //FIM DO BLOCO DE PROGRAMAÇÃO
                txt_cod_cliente.Text = "";
                txt_email_cliente.Text = "";
                txt_tempo_cliente.Text = "";
                txt_cpf_cliente.Text = "";
                txt_pesquisar.Text = "";
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            //Apaga todos os dados dos campos preenchidos.
            txt_cod_cliente.Text = "";
            txt_email_cliente.Text = "";
            txt_tempo_cliente.Text = "";
            txt_cpf_cliente.Text = "";
            txt_pesquisar.Text = "";
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            btn_editar.Enabled = true;
            btn_excluir.Enabled = true;
            btn_cadastrar.Enabled = true;
            //INÍCIO DO BLOCO DE PROGRAMAÇÃO
            if (txt_pesquisar.Text == "")
            {
                MessageBox.Show("Preencha todos os campos para prosseguir!");
            }
            else
            {
                MySqlConnection cnn = new MySqlConnection("server=localhost;database=bd_estacionamento;uid=root;pwd=\"\";");
                MySqlCommand comando = new MySqlCommand("SELECT * FROM clientes WHERE cod_clientes = @cod_clientes", cnn);
                try
                {

                    cnn.Open();

                    comando.Parameters.AddWithValue("@cod_clientes", txt_pesquisar.Text);

                    MySqlDataReader myReader;
                    myReader = comando.ExecuteReader();
                    try
                    {
                        while (myReader.Read())
                        {
                            //Console.WriteLine(myReader.GetString(0));
                            txt_cod_cliente.Text = myReader.GetString(0);
                            txt_email_cliente.Text = myReader.GetString(1);
                            txt_cpf_cliente.Text = myReader.GetString(2);
                            txt_tempo_cliente.Text = myReader.GetString(3);
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
                    MessageBox.Show("Can not open connection ! ");
                }

                //FIM DO BLOCO DE PROGRAMAÇÃO
            }
        }

        private void btn_voltar_menu_Click(object sender, EventArgs e)
        {
            var form2 = Program.ServiceProvider.GetRequiredService<frm_cliente>();
            form2.ShowDialog();

            this.Hide();
            frm_menu voltar_menu = new frm_menu();

            voltar_menu.Show();

        }

        private void frm_clientes_Load(object sender, EventArgs e)
        {
            txt_cod_cliente.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
