using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TI89
{
   public class Cliente
    { //Declaração de variaveis
        public int id;
        public string mensagem;
        public bool achou = false;

        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        //construtor 
        public Cliente() { }
        //alterar
        public Cliente(int nCodigo, string nNome, string nEmail)
        {
            this.ID = nCodigo;
            this.Nome = nNome;
            this.Email = nEmail;
        }
        public Cliente( string nNome, string nEmail)
        {
            
            this.Nome = nNome;
            this.Email = nEmail;
        }

        //metodo para inserir com procedure
        public void Inserir()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_InsertUpdate";
            cmd.Parameters.AddWithValue("_id",0);
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_email", Email);
            cmd.Parameters.AddWithValue("_acao", MySqlDbType.Int32).Value=1;// < Insert
            cmd.ExecuteNonQuery();
            mensagem = "Cadastro Realizado com Sucesso";
            //retornar o auto incremento
            cmd = new MySqlCommand("select max(id) from cadastro",Banco.Abrir());
            id = (int)cmd.ExecuteScalar();
        }
    }
}
