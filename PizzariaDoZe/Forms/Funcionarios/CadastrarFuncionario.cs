using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.Forms.Funcionarios
{
#pragma warning disable CS1591 // O comentário XML ausente não foi encontrado para o tipo ou membro visível publicamente
    public partial class CadastrarFuncionario : Form
    {
#pragma warning disable CS1591 // O comentário XML ausente não foi encontrado para o tipo ou membro visível publicamente
        public CadastrarFuncionario()
        {
            InitializeComponent();

            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo resources
            Funcoes.AjustaResourcesControl(this);

            //ajuste manual de campos ou mensagens para o usuário que não puderam ser automatizadas acima
            //this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            Funcoes.EventoFocoCampos(this);

            this.ActiveControl = textBoxName;

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

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
                this.textBoxValidadeCarta.Text = "";
                this.textBoxObservation.Text = "";

            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Boolean check = checkCamps();
            if (check)
            {
                Close();
                //FormMainMenu fm = new FormMainMenu();
                //fm.returnTheForm("Home");
            }
        }

        private bool checkCamps()
        {
            //Nome, cpf, matricula, email, telefone, funcao -> se for entregador = carteira de motorista, validade e observação, cep, pais, cidade, uf, logradouro, numero, complemento
            String name = this.textBoxName.Text.Trim();
            String cpf = this.textBoxCpf.Text.Trim();
            String email = this.textBoxEmail.Text.Trim();
            String phone = this.textBoxPhone.Text.Trim();
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
    }
}
