using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe_DAO
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int EnderecoId { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }

        public Cliente(int id = 0, string nome = "", string cpf = "", string telefone = "", string email = "",
        int endereco_id = 0, string numero = "", string complemento = "")
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            EnderecoId = endereco_id;
            Numero = numero;
            Complemento = complemento;
        }
    }

    public class ClienteDAO
    {
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }
        public ClienteDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }
        // MÉTODO INSERIR AQUI
        public int Inserir(Cliente cliente)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var nome = comando.CreateParameter(); nome.ParameterName = "@nome";
            nome.Value = cliente.Nome; comando.Parameters.Add(nome);
            var cpf = comando.CreateParameter(); cpf.ParameterName = "@cpf";
            cpf.Value = cliente.Cpf; comando.Parameters.Add(cpf);
            var telefone = comando.CreateParameter(); telefone.ParameterName = "@telefone";
            telefone.Value = cliente.Telefone; comando.Parameters.Add(telefone);
            var email = comando.CreateParameter(); email.ParameterName = "@email";
            email.Value = cliente.Email; comando.Parameters.Add(email);
            var endereco_id = comando.CreateParameter(); endereco_id.ParameterName = "@endereco_id";
            endereco_id.Value = cliente.EnderecoId; comando.Parameters.Add(endereco_id);
            var numero = comando.CreateParameter(); numero.ParameterName = "@numero";
            numero.Value = cliente.Numero; comando.Parameters.Add(numero);
            var complemento = comando.CreateParameter(); complemento.ParameterName = "@complemento";
            complemento.Value = cliente.Complemento; comando.Parameters.Add(complemento);
            conexao.Open();
            //ajusta o comando SQL para capturar o ID gerado tanto do MySQL como do SQLServer
            string auxSQL_ID = Provider.Contains("MySql") ? "SELECT LAST_INSERT_ID();" : "SELECT SCOPE_IDENTITY();";
            //realiza o INSERT e retorna o ID gerado, algo que vai ser necessário na sequencia
            comando.CommandText = @"INSERT INTO clientes (nome, cpf, telefone, email, numero, complemento, enderecos_id)
            VALUES(@nome, @cpf, @telefone, @email, @numero, @complemento, @endereco_id);" + auxSQL_ID;
            //executa o comando no banco de dados e captura o ID gerado
            var IdGerado = comando.ExecuteScalar();
            return Convert.ToInt32(IdGerado);
        }

        public DataTable Buscar(Cliente cliente)
        { 
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //verifica se tem filtro e personaliza o SQL do filtro
            string auxSqlFiltro = "WHERE 1 = 1 ";
            if (cliente.Id > 0)
            {
                auxSqlFiltro += " AND cc.id = " + cliente.Id;
            }

            if (!string.IsNullOrEmpty(cliente.Nome))
            {
                auxSqlFiltro += " AND cc.nome = '" + cliente.Nome + "'";
            }

            if (!string.IsNullOrEmpty(cliente.Telefone))
            {
                auxSqlFiltro += " AND cc.telefone = '" + cliente.Telefone + "'";
            }

            if (!string.IsNullOrEmpty(cliente.Cpf))
            {
                auxSqlFiltro += " AND cc.cpf = '" + cliente.Cpf + "'";
            }
            conexao.Open();
            comando.CommandText = @" " +
            "SELECT cc.id AS ID, cc.nome AS Nome, cc.cpf AS CPF, cc.telefone AS Telefone, cc.email AS 'E-mail', " +
            "e.cep AS CEP, e.logradouro AS Logradouro, e.bairro AS Bairro, " +
            " c.nome AS Cidade, " +
            " u.uf AS UF, " +
            "cc.numero AS Número, cc.complemento AS Complemento " +
            "FROM clientes AS cc " +
            "INNER JOIN enderecos AS e ON e.id = cc.enderecos_id " +
            "INNER JOIN cidades AS c ON c.id = e.cidades_id " +
            "INNER JOIN uf AS u ON u.id = c.uf_id " +
            "INNER JOIN pais AS p ON p.id = u.pais_id " +
            auxSqlFiltro +
            "ORDER BY cc.nome;";
            //Executa o script na conexão e retorna as linhas afetadas.
            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }
    }
}
