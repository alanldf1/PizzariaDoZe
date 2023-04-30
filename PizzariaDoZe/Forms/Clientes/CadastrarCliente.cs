using PizzariaDoZe.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzariaDoZe.Forms.Clientes
{
#pragma warning disable CS1591 // O comentário XML ausente não foi encontrado para o tipo ou membro visível publicamente
    public partial class CadastrarCliente : Form
    {
        private FormMainMenu _mainForm;

#pragma warning disable CS1591 // O comentário XML ausente não foi encontrado para o tipo ou membro visível publicamente
        public CadastrarCliente(FormMainMenu mainForm)
        {
            InitializeComponent();

            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo resources
            Funcoes.AjustaResourcesControl(this);

            //ajuste manual de campos ou mensagens para o usuário que não puderam ser automatizadas acima
            //this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            _mainForm = mainForm;

            Funcoes.EventoFocoCampos(this);
            this.ActiveControl = textBoxName;
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            userControlRegister.btnRegister.Click += btnRegister_Click;
            userControlRegister.btnCancel.Click += btnCancel_Click;
        }

        /// <summary>
        /// Faz a verificação e envia os dados do formulario
        /// </summary>
        /// <param name="sender">Botão clicado</param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Boolean check = checkCamps();
            if (check)
            {
                Close();
            }
        }

        /// <summary>
        /// Botão fecha o formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(currentButton.Text);
            //_mainForm.activeForm = null;
            //Close();
            _mainForm.btnHome.PerformClick();

        }


        /// <summary>
        /// Verifica todos os campos obrigatórios do formulário
        /// </summary>
        /// <returns></returns>
        private bool checkCamps()
        {
            String name = this.textBoxName.Text.Trim();
            String endereco = this.textBoxEndereco.Text.Trim();
            String phone = this.maskedTextBoxPhone.Text.Trim();

            if (name == "")
            {
                MessageBox.Show("Preencha o nome do cliente.");
                return false;
            }
            if (phone == "")
            {
                MessageBox.Show("Preencha o telefone do cliente.");
                return false;
            }
            if (endereco == "")
            {
                MessageBox.Show("Preencha o endereco do cliente.");
                return false;
            }

            return true;
        }


        private void CadastrarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {

            // Display a MsgBox asking the user to save changes or abort.
            if (MessageBox.Show(Resources.pageMessage, "Pizzaria do zé", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
