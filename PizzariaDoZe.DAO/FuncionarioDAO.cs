using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe_DAO
{

    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public string Senha { get; set; }
        public char Funcao { get; set; }
        public string Motorista { get; set; }
        public DateTime Validade { get; set; }
        public string Observacao { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int EnderecoId { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public Funcionario(int id = 0, string nome = "", string cpf = "", string matricula = "", string senha = "", char funcao = default, string
        motorista = "", DateTime validade_motorista = default, string observacao = "", string telefone = "", string email = "", int endereco_id = 0,
        string numero = "", string complemento = "")
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Matricula = matricula;
            Senha = senha;
            Funcao = funcao;
            Motorista = motorista;
            Validade = validade_motorista;
            Observacao = observacao;
            Telefone = telefone;
            Email = email;
            EnderecoId = endereco_id;
            Numero = numero;
            Complemento = complemento;
        }
    }
    public class FuncionarioDAO
    {
        /// <summary>
        /// Utilização de mais do que um provider com o mesmo script (MySQL, SQLServer, Firebird...)
        /// </summary>
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }
        public FuncionarioDAO(string provider, string stringConexao)
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
            string auxSqlFiltro = "";
            if (funcionario.Id > 0)
            {
                auxSqlFiltro = "WHERE f.id = " + funcionario.Id + " ";
            }
            else if (funcionario.Nome.Length > 0)
            {
                auxSqlFiltro = "WHERE f.nome like '%" + funcionario.Nome + "%' ";
            }
            conexao.Open();
            comando.CommandText = @" " +
            "SELECT f.id AS ID, f.nome AS Nome, f.cpf AS CPF, f.matricula AS Matrícula, f.senha AS Senha, f.funcao AS Funcao, f.motorista AS Carteira," +
            "f.validade_motorista AS Validade, f.observacao AS Observação, f.telefone AS Telefone, f.email AS 'E-Mail', " +
            "e.cep AS CEP, e.logradouro AS Logradouro, e.bairro AS Bairro, " +
            "c.nome AS Cidade, " +
            "u.nome AS uf_nome " +
            "FROM funcionarios AS f " +
            "INNER JOIN enderecos AS e ON e.id = f.enderecos_id " +
            "INNER JOIN cidades AS c ON c.id = e.cidades_id " +
            "INNER JOIN uf AS u ON u.id = c.uf_id " +
            "INNER JOIN pais AS p ON p.id = u.pais_id " +
            auxSqlFiltro +
            "ORDER BY f.nome;";
            //Executa o script na conexão e retorna as linhas afetadas.
            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }

    }
}
