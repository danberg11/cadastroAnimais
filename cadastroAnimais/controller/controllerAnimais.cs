using cadastroAnimal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroAnimal.Controller
{
    internal class ControllerAnimais
    {
        //crud
        //c-create/inserir no banco
        //r-read/ler a tabela do banco
        //u-update/alterar registros da tabela do banco
        //d-delete/apagar registros da tabela do banco

        //metodo de inserir registros na tabela do banco
        public void EnviarBanco()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar()); // faz a conexão entre o codigo e o banco de dados.
            SqlCommand cmd = new SqlCommand("PCadastroAnimais", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {

                cmd.Parameters.AddWithValue("@nome", Animais.Nome);
                cmd.Parameters.AddWithValue("@raca", Animais.Raca);
                cmd.Parameters.AddWithValue("@porte", Animais.Porte);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados inseridos com sucesso");

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
