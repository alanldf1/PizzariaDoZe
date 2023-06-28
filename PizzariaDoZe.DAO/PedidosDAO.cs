using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe_DAO
{

    public class Pedido
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public byte[] Foto { get; set; }
        public char Categoria { get; set; }
        public char Tipo { get; set; }
        public List<Ingrediente> SaborIngredientes { get; set; }
        public Pedido(int id = 0, string nome = "", string descricao = ""

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
    public class PedidoDAO
    {
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }
        public PedidoDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }
        // Método INSERIR aqui
        public int Inserir(Pedido pedido)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var nome = comando.CreateParameter(); nome.ParameterName = "@nome"; nome.Value = pedido.Nome; comando.Parameters.Add(nome);
            var descricao = comando.CreateParameter(); descricao.ParameterName = "@descricao"; descricao.Value = pedido.Descricao; comando.Parameters.Add(descricao);
            var foto = comando.CreateParameter(); foto.ParameterName = "@foto"; foto.Value = pedido.Foto; comando.Parameters.Add(foto);
            var categoria = comando.CreateParameter(); categoria.ParameterName = "@categoria"; categoria.Value = pedido.Categoria; comando.Parameters.Add(categoria);
            var tipo = comando.CreateParameter(); tipo.ParameterName = "@tipo"; tipo.Value = pedido.Tipo; comando.Parameters.Add(tipo);
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
                foreach (Ingrediente auxIngrediente in pedido.SaborIngredientes)
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

        public DataTable Buscar(Pedido pedido)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //verifica se tem filtro e personaliza o SQL do filtro
            string auxSqlFiltro = "";
            if (pedido.Id > 0)
            {
                auxSqlFiltro = "WHERE ped.id = " + pedido.Id + " ";
            }
            conexao.Open();
            comando.CommandText = @" " +
            "SELECT ped.id as id, CONCAT(c.nome, '(', c.cpf, ')') as cliente, " +
            "IF(ped.entrega = 0, 'Retirada', 'Entrega') as tipo_entrega, " +
            "(SELECT COUNT(lpiz.pizza_id) FROM lista_pizzas lpiz WHERE lpiz.pedido_id = ped.id) as pizzas, ped.observacao as observacao, " +
            "(SELECT COUNT(lprod.id) FROM lista_produtos lprod WHERE lprod.pedido_id = ped.id) as produtos, fun.nome as vendedor, ped.data as data_e_hora, " +
            "IF(ped.status = 1, 'Emrota de entrega', IF(ped.status = 2, 'Entregue', 'Em preparo')) as status " +
            "FROM pedido ped " +
            "LEFT JOIN clientes c ON ped.clientes_id = c.id " +
            "LEFT JOIN funcionarios fun ON ped.funcionarios_id = fun.id " +
            "GROUP BY ped.id " +
            auxSqlFiltro +
            "ORDER BY ped.data;";
            //Executa o script na conexão e retorna as linhas afetadas.
            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }
    }
}
