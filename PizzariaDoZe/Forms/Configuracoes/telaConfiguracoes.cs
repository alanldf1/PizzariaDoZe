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
    public partial class telaConfiguracoes : Form
    {
        public telaConfiguracoes()
        {
            InitializeComponent();
        }
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

        private void telaConfiguracoes_Load(object sender, EventArgs e)
        {
            String? selectedLanguage = (ConfigurationManager.AppSettings.Get("mainLanguage") is not null) ? ConfigurationManager.AppSettings.Get("mainLanguage") : "";
            comboBoxLanguage.SelectedItem = selectedLanguage;
        }
    }
}
