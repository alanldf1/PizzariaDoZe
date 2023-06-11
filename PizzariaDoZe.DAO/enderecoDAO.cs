using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe_DAO
{
    public class Endereco
    {
        //pais
        public int PaisId { get; set; }
        public string PaisName { get; set; }
        //uf
        public int UfId { get; set; }
        public string NomeUf { get; set; }
        public string Uf { get; set; }

        //cidade
        public int CidadeId { get; set; }
        public string NomeCidade { get; set; }
        //endereco
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }

        

        public Endereco(int id = 0, string logradouro = "", string cep = "", string bairro = "",
            int cidadeId = 0, string nomeCidade = "",
            int ufId = 0, string nomeUf = "", string uf = "",
            int paisId = 0, string paisName = "")
        {
            Id = id;
            Logradouro = logradouro;
            Cep = cep;
            Bairro = bairro;
            CidadeId = cidadeId;
            NomeCidade = nomeCidade;
            UfId = ufId;
            Uf = uf;
            NomeUf = nomeUf;
            PaisId = paisId;
            PaisName = paisName;
        }
    }

    public class EnderecoDAO
    {
        /// <summary>
        /// Utilização de mais do que um provider com o mesmo script (MySQL, SQLServer, Firebird...)
        /// </summary>
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }

        public EnderecoDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }

        //public void InserirDbProvider(Ingrediente ingrediente)
        //{
        //    using var conexao = factory.CreateConnection(); //Cria conexão
        //    conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
        //    using var comando = factory.CreateCommand(); //Cria comando
        //    comando!.Connection = conexao; //Atribui conexão

        //    //Adiciona parâmetro (@campo e valor)
        //    var nome = comando.CreateParameter(); nome.ParameterName = "@nome";
        //    nome.Value = ingrediente.Nome; comando.Parameters.Add(nome);

        //    conexao.Open();

        //    comando.CommandText = @"INSERT INTO ingredientes(nome) VALUES (@nome)";

        //    //Executa o script na conexão e retorna o número de linhas afetadas.
        //    var linhas = comando.ExecuteNonQuery();

        //    //using faz o Close() automático quando fecha o seu escopo
        //}



        public DataTable Buscar(Endereco endereco)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //verifica se tem filtro e personaliza o SQL do filtro
            string auxSqlFiltro = "";
            if (endereco.Id > 0)
            {
                auxSqlFiltro = "WHERE e.id = " + endereco.Id + " ";
            }
            else if (endereco.Cep.Length > 0)
            {
                auxSqlFiltro = "WHERE e.cep = '" + endereco.Cep + "' ";
            }
            conexao.Open();
            comando.CommandText = @" " +
            "SELECT e.id AS ID, e.cep AS CEP, e.logradouro AS Logradouro, e.bairro AS Bairro, " +
            "c.id AS IDCidade, c.nome AS Cidade, " +
            "u.id AS IDUF, u.nome AS uf_nome, u.uf AS uf," +
            "p.id AS IDPais, p.nome AS Pais " +
            "FROM enderecos AS e " +
            "INNER JOIN cidades AS c ON c.id = e.cidades_id " +
            "INNER JOIN uf AS u ON u.id = c.uf_id " +
            "INNER JOIN pais AS p ON p.id = u.pais_id " +
            auxSqlFiltro +
            "ORDER BY e.cep;";
            //Executa o script na conexão e retorna as linhas afetadas.
            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }
    }
}
