using System.Data.Common;
using System.Configuration;
using System.Data;


namespace PizzariaDoZe_DAO
{
    public class Pedidos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public char Tipo { get; set; }
        public string ML { get; set; }

        public Pedidos(int id = 0, string nome = "", string descricao = ""

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
    public class PedidosDAO
    {
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }
        public PedidosDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }
        // MÉTODO INSERIR AQUI
        public int Inserir(Funcionario funcionario)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var nome = comando.CreateParameter(); nome.ParameterName = "@nome";
            nome.Value = funcionario.Nome; comando.Parameters.Add(nome);
            var cpf = comando.CreateParameter(); cpf.ParameterName = "@cpf";
            cpf.Value = funcionario.Cpf; comando.Parameters.Add(cpf);
            var matricula = comando.CreateParameter(); matricula.ParameterName = "@matricula";
            matricula.Value = funcionario.Matricula; comando.Parameters.Add(matricula);
            var senha = comando.CreateParameter(); senha.ParameterName = "@senha";
            senha.Value = funcionario.Senha; comando.Parameters.Add(senha);
            var grupo = comando.CreateParameter(); grupo.ParameterName = "@funcao";
            grupo.Value = funcionario.Funcao; comando.Parameters.Add(grupo);
            var motorista = comando.CreateParameter(); motorista.ParameterName = "@motorista";
            motorista.Value = funcionario.Motorista; comando.Parameters.Add(motorista);
            var validade_motorista = comando.CreateParameter(); validade_motorista.ParameterName = "@validade_motorista";
            validade_motorista.Value = funcionario.Validade; comando.Parameters.Add(validade_motorista);
            var observacao = comando.CreateParameter(); observacao.ParameterName = "@observacao";
            observacao.Value = funcionario.Observacao; comando.Parameters.Add(observacao);
            var telefone = comando.CreateParameter(); telefone.ParameterName = "@telefone";
            telefone.Value = funcionario.Telefone; comando.Parameters.Add(telefone);
            var email = comando.CreateParameter(); email.ParameterName = "@email";
            email.Value = funcionario.Email; comando.Parameters.Add(email);
            var numero = comando.CreateParameter(); numero.ParameterName = "@numero";
            numero.Value = funcionario.Numero; comando.Parameters.Add(numero);
            var complemento = comando.CreateParameter(); complemento.ParameterName = "@complemento";
            complemento.Value = funcionario.Complemento; comando.Parameters.Add(complemento);
            var enderecos_id = comando.CreateParameter(); enderecos_id.ParameterName = "@enderecos_id";
            enderecos_id.Value = funcionario.EnderecoId; comando.Parameters.Add(enderecos_id);

            conexao.Open();
            //ajusta o comando SQL para capturar o ID gerado tanto do MySQL como do SQLServer
            string auxSQL_ID = Provider.Contains("MySql") ? "SELECT LAST_INSERT_ID();" : "SELECT SCOPE_IDENTITY();";
            //realiza o INSERT e retorna o ID gerado, algo que vai ser necessário na sequencia
            comando.CommandText = @"INSERT INTO funcionarios (nome, cpf, matricula, senha, funcao, motorista, validade_motorista, observacao, telefone, email, numero, complemento, enderecos_id)
            VALUES (@nome, @cpf, @matricula, @senha, @funcao, @motorista, @validade_motorista, @observacao, @telefone, @email, @numero, @complemento, @enderecos_id);" + auxSQL_ID;
            //executa o comando no banco de dados e captura o ID gerado
            var IdGerado = comando.ExecuteScalar();
            return Convert.ToInt32(IdGerado);
        }

        public DataTable Buscar(Funcionario funcionario)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //verifica se tem filtro e personaliza o SQL do filtro
            conexao.Open();
            comando.CommandText = @" " +
            "SELECT ped.id as id, CONCAT(c.nome, \" (\", c.cpf,\")\") as cliente, " +
            "IF(ped.entrega = 0, \"Retirada\", \"Entrega\") as tipo_entrega, " +
            "(SELECT COUNT(lpiz.pizza_id) FROM lista_pizzas lpiz WHERE lpiz.pedido_id = ped.id) as pizzas, ped.observacao as observacao, " +
            "IF(ped.borda IS NULL, \"Sem\", ped.borda) as borda, " +
            "(SELECT COUNT(lprod.id) FROM lista_produtos lprod WHERE lprod.pedido_id = ped.id) as produtos, fun.nome as vendedor, " +
            "ped.data as data_e_hora, IF(ped.status = 1, \"Em  rota de entrega\", " +
            "IF(ped.status = 2, \"Entregue\", \"Em preparo\")) as status " +
            "FROM pedido ped " +
            "LEFT JOIN clientes c ON ped.clientes_id = c.id " +
            "LEFT JOIN funcionarios fun ON ped.funcionarios_id = fun.id " +
            "GROUP BY ped.id" +
            "ORDER BY p.data;";
            //Executa o script na conexão e retorna as linhas afetadas.
            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }

    }
}
