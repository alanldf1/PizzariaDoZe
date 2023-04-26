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
    }
}
