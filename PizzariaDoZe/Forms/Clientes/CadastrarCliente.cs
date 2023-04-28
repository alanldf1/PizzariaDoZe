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
        public Button? currentButton;

        public Form currentForm;
#pragma warning disable CS1591 // O comentário XML ausente não foi encontrado para o tipo ou membro visível publicamente
        public CadastrarCliente(Button lastButton, Form lastForm)
        {
            InitializeComponent();

            Funcoes.EventoFocoCampos(this);
            this.ActiveControl = textBoxName;
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            currentButton = lastButton;
            currentForm = lastForm;
            //UserControlRegister register = new();
            //register.Dock = DockStyle.Bottom;
            //Controls.Add(register);

            userControlRegister.btnRegister.Click += btnRegister_Click;
            userControlRegister.btnCancel.Click += btnCancel_Click;
        }

        public Form Parent { get; set; }

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
        /// Botão fecha o formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(currentButton.Text);
                
            //Close();
        }

        private void textBoxComplemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {


        }

        private void userControlRegister1_Load(object sender, EventArgs e)
        {

        }

        private void CadastrarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {


            //lastForm.OpenChildForm(new Forms.Clientes.tabelaClientes(), sender, buttonText);
        }
    }
}
