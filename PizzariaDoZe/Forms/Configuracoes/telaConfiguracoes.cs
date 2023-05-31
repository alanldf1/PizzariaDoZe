using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.Forms.Configuracoes
{
#pragma warning disable CS1591 // O comentário XML ausente não foi encontrado para o tipo ou membro visível publicamente

    public partial class telaConfiguracoes : Form
    {
#pragma warning disable CS1591 // O comentário XML ausente não foi encontrado para o tipo ou membro visível publicamente
        public telaConfiguracoes()
        {
            InitializeComponent();

            Funcoes.EventoFocoCampos(this);
            this.ActiveControl = comboBoxLanguage;

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            // busca os dados com nome BD
            ConnectionStringSettings connectionStringSettings =
            ConfigurationManager.ConnectionStrings["BD"];
            // obtém o providerName e atualiza em tela
            //comboBoxProvider.Text = connectionStringSettings.ProviderName;
            String? selectedProvider = connectionStringSettings.ProviderName;
            comboBoxProvider.SelectedItem = selectedProvider;
            // obtém a connectionString e atualiza em tela
            textBoxStringDeConexao.Text = connectionStringSettings.ConnectionString;
        }

        /// <summary>
        /// Vai salvar a linguagem escolhida no comboBox e o se o checkBox estiver selecionado ele reinicia o app e altera a linguagem
        /// </summary>
        /// <param name="sender">Botão clicado</param>
        /// <param name="e"></param>
        private void ButtonSalvarLinguagem_Click(object sender, EventArgs e)
        {
            //abre o arquivo local como leitura/escrita e salva as alterações em ProjetoPastelariaDoZe_2023.dll.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("mainLanguage");
            config.AppSettings.Settings.Add("mainLanguage", comboBoxLanguage.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            Close();
            _ = MessageBox.Show("Idioma/região alterada com sucesso! Reinicie a aplicação para aplicar o novo Idioma/região!");
            if (checkBoxApplyNow.Checked)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Ao carregar a tela ele deixa a linguagem atual selecionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void telaConfiguracoes_Load(object sender, EventArgs e)
        {
            String? selectedLanguage = (ConfigurationManager.AppSettings.Get("mainLanguage") is not null) ? ConfigurationManager.AppSettings.Get("mainLanguage") : "";
            comboBoxLanguage.SelectedItem = selectedLanguage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveBd_Click(object sender, EventArgs e)
        {
            //abre o arquivo local como leitura/escrita - ControleEstoqueDoZe.exe.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //altera os valores de provider e da connectionStrings com nome BD
            config.ConnectionStrings.ConnectionStrings["BD"].ProviderName = comboBoxProvider.Text;
            config.ConnectionStrings.ConnectionStrings["BD"].ConnectionString = textBoxStringDeConexao.Text;
            //salva as alterações
            config.Save(ConfigurationSaveMode.Modified, true);
            //recarrega os dados da seção especificada
            ConfigurationManager.RefreshSection("connectionStrings");
            ConfigurationManager.RefreshSection("providerName");

            //fecha a tela
            Close();
            //dispara msg para usuário
            _ = MessageBox.Show("Dados alterados com sucesso!");
        }
    }
}
