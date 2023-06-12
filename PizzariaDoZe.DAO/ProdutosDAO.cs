using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe_DAO
{

    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public char Tipo { get; set; }
        public string ML { get; set; }

        public Produto(int id = 0, string nome = "", string descricao = ""

        , decimal valor = 0, char

        tipo = ' ', string ml = "")
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            Tipo = tipo;
            ML = ml;
        }
    }

    public class ProdutosDAO
    {
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }
        public ProdutosDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }
        //MÉTODO INSERIR AQUI

        public int Inserir(Produto produto)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var nome = comando.CreateParameter(); nome.ParameterName = "@nome";
            nome.Value = produto.Nome; comando.Parameters.Add(nome);
            var descricao = comando.CreateParameter(); descricao.ParameterName = "@descricao";
            descricao.Value = produto.Descricao; comando.Parameters.Add(descricao);
            var valorProduto = comando.CreateParameter(); valorProduto.ParameterName = "@valorProduto";
            valorProduto.Value = produto.Valor; comando.Parameters.Add(valorProduto);
            var tipo = comando.CreateParameter(); tipo.ParameterName = "@tipo";
            tipo.Value = produto.Tipo; comando.Parameters.Add(tipo);
            var ml = comando.CreateParameter(); ml.ParameterName = "@ml";
            ml.Value = produto.ML; comando.Parameters.Add(ml);
            conexao.Open();
            //ajusta o comando SQL para capturar o ID gerado tanto do MySQL como do SQLServer
            string auxSQL_ID = Provider.Contains("MySql") ? "SELECT LAST_INSERT_ID();" : "SELECT SCOPE_IDENTITY();";
            //realiza o INSERT e retorna o ID gerado, algo que vai ser necessário na sequencia
            comando.CommandText = @"" +
            "INSERT INTO produtos (nome, descricao, valor, tipo, medida_unitaria) " +
            "VALUES (@nome, @descricao, @valorProduto, @tipo, @ml);" +
            auxSQL_ID;
            //executa o comando no banco de dados e captura o ID gerado
            var IdSaborGerado = comando.ExecuteScalar();
            return Convert.ToInt32(IdSaborGerado);
        }

        public DataTable Buscar(Produto produto)
        {

            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //verifica se tem filtro e personaliza o SQL do filtro
            string auxSqlFiltro = "";
            if (produto.Id > 0)
            {
                auxSqlFiltro = "WHERE p.id = " + produto.Id + " ";
            }
            conexao.Open();
            comando.CommandText = @" " +
            "SELECT id AS ID, nome AS Nome, descricao AS Descrição, valor AS Valor, tipo AS 'Tipo Produto', medida_unitaria AS ML " +
            "FROM produtos AS p " +
            auxSqlFiltro +
            "ORDER BY p.descricao;";
            //Executa o script na conexão e retorna as linhas afetadas.
            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;

        }
    }
}
