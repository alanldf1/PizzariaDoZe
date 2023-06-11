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
using PizzariaDoZe_DAO;
using System.Configuration;

namespace PizzariaDoZe.Forms.Sabores
{
#pragma warning disable CS1591 // O comentário XML ausente não foi encontrado para o tipo ou membro visível publicamente
    public partial class CadastrarSabor : Form
    {
        private readonly IngredienteDAO ingredienteDAO;
        private readonly SaborDAO saborDAO;
        private FormMainMenu _mainForm;

#pragma warning disable CS1591 // O comentário XML ausente não foi encontrado para o tipo ou membro visível publicamente
        public CadastrarSabor(FormMainMenu mainForm)
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
            string strConnection =
            ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            ingredienteDAO = new IngredienteDAO(provider, strConnection);
            saborDAO = new SaborDAO(provider, strConnection);

            _mainForm = mainForm;
            Funcoes.EventoFocoCampos(this);
            this.ActiveControl = textBoxName;
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            userControlRegister.btnRegister.Click += btnRegister_Click;
            userControlRegister.btnCancel.Click += btnCancel_Click;

            CarregaIngredientesCheckedListBox();
            CarregaEnumListBox();
        }

        public bool checkCamps()
        {
            return true;
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
                //Instância e Preenche o objeto com os dados da view
                var sabor = new Sabor
                {
                    Id = 0,
                    Nome = textBoxName.Text,
                    Descricao = textBoxDescricao.Text,
                    Foto = Funcoes.ConverteImagemParaByteArray(pictureBoxImagem.Image),
                    Categoria = (char)(EnumSaborCategoria)Enum.Parse(typeof(EnumSaborCategoria), listBoxCategoria.Text),
                    Tipo = (char)(EnumSaborTipo)Enum.Parse(typeof(EnumSaborTipo), listBoxTipo.Text),
                    SaborIngredientes = checkedListBoxIngredient.CheckedItems.OfType<Ingrediente>().ToList(),
                };
                try
                {
                    // chama o método para inserir da camada model
                    saborDAO.Inserir(sabor);
                    MessageBox.Show("Dados inseridos com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //Close();
            }
            else
            {
                _mainForm.btnHome.PerformClick();
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

        private void CadastrarSabor_FormClosing(object sender, FormClosingEventArgs e)
        {

            // Display a MsgBox asking the user to save changes or abort.
            if (MessageBox.Show(Resources.pageMessage, "Pizzaria do zé", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void CadastrarSabor_Load(object sender, EventArgs e)
        {
            textBoxName.Focus();
        }

        private void CarregaIngredientesCheckedListBox()
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = ingredienteDAO.Buscar(ingrediente);
                // carrega os dados, como objeto, no checkedListBox
                checkedListBoxIngredient.Items.Clear();
                foreach (DataRow row in linhas.Rows)
                {
                    checkedListBoxIngredient.Items.Add(new Ingrediente(int.Parse(row["ID"].ToString()), row["Nome"].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregaEnumListBox()
        {
            //popular listBoxCategoria
            listBoxCategoria.Items.Clear();
            listBoxCategoria.DataSource = Enum.GetValues(typeof(EnumSaborCategoria));
            //popular listBoxTipo
            listBoxTipo.Items.Clear();
            listBoxTipo.DataSource = Enum.GetValues(typeof(EnumSaborTipo));
        }

        private void pictureBoxImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogImagem = new()
            {
                Title = "Imagem do produto",
                Filter = "Images (*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG;*.)|*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG;*.icon;*.JFIF"
            };
            if (openFileDialogImagem.ShowDialog() == DialogResult.OK)
            {
                //pega a imagem escolhida e adiciona na tela
                pictureBoxImagem.Image = Image.FromFile(openFileDialogImagem.FileName);
                //redimensiona a imagem
                pictureBoxImagem.Image = (Image)(new Bitmap(pictureBoxImagem.Image, new Size(130, 98)));
                //ajusta a visualização no tamanho do pictureBoxImagem na tela
                pictureBoxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
