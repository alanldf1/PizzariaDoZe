using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe_DAO
{

    public class Sabor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public byte[] Foto { get; set; }
        public char Categoria { get; set; }
        public char Tipo { get; set; }
        public List<Ingrediente> SaborIngredientes { get; set; }
        public Sabor(int id = 0, string nome = "",string descricao = ""

        , byte[] foto = null, char
        categoria = ' ', char tipo = ' ', List<Ingrediente> saborIngredientes = null)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Foto = foto;
            Categoria = categoria;
            Tipo = tipo;
            this.SaborIngredientes = saborIngredientes;
        }
    }
    public class SaborDAO
    {
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }
        public SaborDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }
        // Método INSERIR aqui
        public int Inserir(Sabor sabor)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var nome = comando.CreateParameter(); nome.ParameterName = "@nome"; nome.Value = sabor.Nome; comando.Parameters.Add(nome);
            var descricao = comando.CreateParameter(); descricao.ParameterName = "@descricao"; descricao.Value = sabor.Descricao; comando.Parameters.Add(descricao);
            var foto = comando.CreateParameter(); foto.ParameterName = "@foto"; foto.Value = sabor.Foto; comando.Parameters.Add(foto);
            var categoria = comando.CreateParameter(); categoria.ParameterName = "@categoria"; categoria.Value = sabor.Categoria; comando.Parameters.Add(categoria);
            var tipo = comando.CreateParameter(); tipo.ParameterName = "@tipo"; tipo.Value = sabor.Tipo; comando.Parameters.Add(tipo);
            conexao.Open();
            // Inicia o controle de Transação LOCAL
            DbTransaction transacao = conexao.BeginTransaction();
            // Associa o command com o controle de Transação
            comando.Transaction = transacao;
            try
            {
                //ajusta o comando SQL para capturar o ID gerado tanto do MySQL como do SQLServer
                string auxSQL_ID = Provider.Contains("MySql") ? "SELECT LAST_INSERT_ID();" : "SELECT SCOPE_IDENTITY();";
                //realiza o INSERT e retorna o ID gerado, algo que vai ser necessário na sequencia
                comando.CommandText = @"INSERT INTO sabores (nome, descricao, foto, categoria, tipo) VALUES (@nome, @descricao, @foto, @categoria, @tipo);" + auxSQL_ID;
                //executa o comando no banco de dados e captura o ID gerado
                var IdSaborGerado = comando.ExecuteScalar();
                // realiza um loop para pegar todos os ingredientes selecionados
                foreach (Ingrediente auxIngrediente in sabor.SaborIngredientes)
                {
                    // salvar os ingredientes do sabor
                    comando.CommandText = @"INSERT INTO lista_ingredientes(sabores_id, ingredientes_id) VALUES (" + Convert.ToInt32(IdSaborGerado) + "," + auxIngrediente.Id + ")";
                    //Executa o script na conexão e retorna o número de linhas afetadas.
                    var linhasRecebimentoComanda = comando.ExecuteNonQuery();
                }
                // Como não ocorreu nenhum erro, confirma as transações através do Commit()
                transacao.Commit();
                return Convert.ToInt32(IdSaborGerado);
            }
            catch (Exception ex)
            {
                // Alguns dos comandos SQL acima gerou erro, dessa forma, todos os comandos serão desfeitos através do Rollback()
                transacao.Rollback();
                // retorna uma exceção para quem chamou a execução
                throw new Exception(ex.Message);
            }
        }

        public DataTable Buscar(Sabor sabor)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //verifica se tem filtro e personaliza o SQL do filtro
            string auxSqlFiltro = "";
            if (sabor.Id > 0)
            {
                auxSqlFiltro = "WHERE s.id = " + sabor.Id + " ";
            }
            else if (sabor.Descricao.Length > 0)
            {
                auxSqlFiltro = "WHERE s.descricao like '%" + sabor.Descricao + "%' ";
            }
            conexao.Open();
            comando.CommandText = @" " +
            "SELECT s.id AS ID, s.nome AS Nome, s.descricao AS Descricao, s.foto AS Foto, s.categoria AS Categoria, s.tipo AS Tipo, " +
            "(SELECT GROUP_CONCAT(i.nome SEPARATOR ', ') FROM lista_ingredientes AS iss, ingredientes i WHERE iss.sabores_id = s.id AND i.id = iss.ingredientes_id ) AS Ingredientes " +
            "FROM sabores AS s " +
            auxSqlFiltro +
            "ORDER BY s.descricao;";
            //Executa o script na conexão e retorna as linhas afetadas.
            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }
    }
}
