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

namespace CicloMov
{
    public partial class frm_login : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;
        String strsql;

        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (text_login_usuario.Text == "" || text_login_senha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos para prosseguir!");
            }
            else
            {
                try
                {

                    //A variável conexao define uma string para conexão com o BD.
                    conexao = new SqlConnection(@"Server=LAB136-16\SQLEXPRESS; Database=bd_cadastro_clayteam; User id=sa; Password=123456;");
                    strsql = "SELECT * FROM usuarios WHERE email_usuario = @email_usuario and senha = @senha_usuario";
                    comando = new SqlCommand(strsql, conexao);
                    comando.Parameters.AddWithValue("@email_usuario", text_login_usuario.Text);
                    comando.Parameters.AddWithValue("@senha_usuario", text_login_senha.Text);
                    conexao.Open();
                    dr = comando.ExecuteReader();

                    if (dr.Read())
                    {
                        this.Hide();

                        frm_menu menu = new frm_menu();

                        menu.Show();

                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos!\n\nTente novamente");
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

            }

        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
