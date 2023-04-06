using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.Forms.Clientes
{
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();

            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo resources
            Funcoes.AjustaResourcesControl(this);

            //ajuste manual de campos ou mensagens para o usuário que não puderam ser automatizadas acima
            //this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion
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
                //FormMainMenu fm = new FormMainMenu();
                //fm.returnTheForm("Home");
            }
        }

        /// <summary>
        /// Verifica todos os campos obrigatórios do formulário
        /// </summary>
        /// <returns></returns>
        private bool checkCamps()
        {
            String name = this.textBoxName.Text.Trim();
            String endereco = this.textBoxEndereco.Text.Trim();
            String phone = this.textBoxPhone.Text.Trim();

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
