using PizzariaDoZe.Properties;
using PizzariaDoZe_DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace PizzariaDoZe.Forms.Funcionarios
{
#pragma warning disable CS1591 // O comentário XML ausente não foi encontrado para o tipo ou membro visível publicamente
    public partial class CadastrarFuncionario : Form
    {
        private FormMainMenu _mainForm;
        private readonly EnderecoDAO enderecoDAO;
        private readonly FuncionarioDAO funcionarioDAO;


#pragma warning disable CS1591 // O comentário XML ausente não foi encontrado para o tipo ou membro visível publicamente
        public CadastrarFuncionario(FormMainMenu mainForm)
        {
            InitializeComponent();

            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo resources
            Funcoes.AjustaResourcesControl(this);

            //ajuste manual de campos ou mensagens para o usuário que não puderam ser automatizadas acima
            //this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion


            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            funcionarioDAO = new FuncionarioDAO(provider, strConnection);

            _mainForm = mainForm;

            Funcoes.EventoFocoCampos(this);

            this.ActiveControl = textBoxNome;
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            userControlRegister.btnRegister.Click += btnRegister_Click;
            userControlRegister.btnCancel.Click += btnCancel_Click;
        }

        private void radioButtonCartaSim_CheckedChanged(object sender, EventArgs e)
        {
            String? txt = groupBoxCarta.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked)!.Text;

            if (txt == "Sim")
            {
                this.panelCarta.Visible = true;
            }
            else
            {
                this.panelCarta.Visible = false;
                this.dateTimePickerValidadeCarta.Text = "";
                this.textBoxObservation.Text = "";

            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Boolean check = checkCamps();
            if (check)
            {
                //Instância e Preenche o objeto com os dados da view
                var funcionario = new Funcionario
                {
                    Id = 0,
                    Nome = textBoxNome.Text,
                    Cpf = maskedTextBoxCpf.Text,
                    Matricula = textBoxMatricula.Text,
                    Senha = Funcoes.Sha256Hash(textBoxSenha.Text),
                    Funcao = (radioButtonAdmin.Checked) ? '1' : ((radioButtonAtendente.Checked) ? '2' : '3'),
                    Validade = dateTimePickerValidadeCarta.Value,
                    Motorista = radioButtonCartaSim.Checked ? "Sim" : "Não",
                    Observacao = textBoxObservation.Text,
                    Telefone = maskedTextBoxPhone.Text,
                    Email = textBoxEmail.Text,
                    EnderecoId = int.Parse(textBoxIdEndereco.Text),
                    Numero = textBoxNumero.Text,
                    Complemento = textBoxComplemento.Text,
                };
                try
                {
                    // chama o método da model para inserir e capturar o ID do cliente
                    int IdFuncionarioGerado = funcionarioDAO.Inserir(funcionario);
                    MessageBox.Show("Dados inseridos com sucesso! " + IdFuncionarioGerado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(currentButton.Text);
            //_mainForm.activeForm = null;
            //Close();
            _mainForm.btnHome.PerformClick();

        }

        private bool checkCamps()
        {
            //Nome, cpf, matricula, email, telefone, funcao -> se for entregador = carteira de motorista, validade e observação, cep, pais, cidade, uf, logradouro, numero, complemento
            String name = this.textBoxNome.Text.Trim();
            String cpf = this.maskedTextBoxCpf.Text.Trim();
            String email = this.textBoxEmail.Text.Trim();
            String phone = this.maskedTextBoxPhone.Text.Trim();
            String? funcao = groupBoxFuncao.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked)!.Text;



            if (name == "")
            {
                MessageBox.Show("Preencha o nome do cliente.");
                return false;
            }
            if (cpf == "")
            {
                MessageBox.Show("Preencha o telefone do cliente.");
                return false;
            }
            if (email == "")
            {
                MessageBox.Show("Preencha o endereco do cliente.");
                return false;
            }
            if (phone
                == "")
            {
                MessageBox.Show("Preencha o endereco do cliente.");
                return false;
            }

            //if (funcao == "Entregador")
            //{
            //    Boolean checkBool = true;
            //    String carta = groupBoxCarta.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
            //    String validadeCarta = this.textBoxValidadeCarta.Text.Trim();
            //    String observacao = this.textBoxObservation.Text.Trim();

            //    if (carta == "")
            //    {
            //        MessageBox.Show("Selecione se o funcionário possui carteira de motorista");
            //        checkBool = false;
            //    }

            //    if (validadeCarta == "")
            //    {
            //        MessageBox.Show("Selecione se o funcionário possui carteira de motorista");
            //        checkBool = false;
            //    }
            //}

            return true;
        }

        private void CadastrarFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Display a MsgBox asking the user to save changes or abort.
            if (MessageBox.Show(Resources.pageMessage, "Pizzaria do zé", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void CadastrarFuncionario_Load(object sender, EventArgs e)
        {
            textBoxNome.Focus();
        }


        private void maskedTextBoxCep_TextChanged(object sender, EventArgs e)
        {
            string cep = maskedTextBoxCep.Text.Trim();
            if (cep.Length >= 8) // Verifica se o CEP possui a quantidade correta de caracteres
            {
                // Realize aqui a lógica para buscar o CEP
                // Chame a função ou método para buscar o CEP com base no valor digitado
                BuscarCep(cep);
            }
        }

        private void BuscarCep(string cep)
        {
            var endereco = new Endereco
            {
                Cep = cep,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);

                // seta os dados na tela
                textBoxEndereco.Text = "";
                textBoxIdEndereco.Text = "";
                textBoxUf.Text = "";
                textBoxPais.Text = "";
                //userControlEndereco.maskedTextBoxCep.Text = "";
                string enderecoCompleto = "";
                foreach (DataRow row in linhas.Rows)
                {
                    enderecoCompleto = row["logradouro"].ToString() + ", " +
                        row["bairro"].ToString() + ", " +
                        row["cidade"].ToString() + " - " + row["uf"].ToString();
                    //userControlEndereco.maskedTextBoxCep.Text = row["cep"].ToString(); ;
                    textBoxIdEndereco.Text = row["id"].ToString();
                    textBoxUf.Text = row["uf_nome"].ToString();
                    textBoxPais.Text = row["pais"].ToString();
                }
                textBoxEndereco.Text = enderecoCompleto;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
