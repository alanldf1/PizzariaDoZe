using System.ComponentModel;
namespace PizzariaDoZe
{
    internal class Funcoes
    {
        /// <summary>
        /// De forma recursiva, varre todos os componentes do Control informado, executando o método ApplyResources em cada um dos componentes localizados.
        /// O ApplyResources realiza a leitura do satellite assembly, ou seja, do arquivo de resource que foi ativo conforme o idioma escolhido pelo usuário,
        /// e com base no nome do campo ajusta todos os parâmetros contidos no resource para aquele campo, por exemplo Text, Font, Size, PasswordChar, Location etc.
        /// O objetivo principal aqui é ajustar o Control, por exemplo o Form, para o Idioma e Cultura escolhido pelo usuário.
        /// Deve possuir, em Properties, um arquivo de resources para cada idioma desejado, devendo ser alimentado na coluna nome o nome do campo e a propriedade que deseja ajustar.
        /// Por exemplo, em cadeias de caracteres labelLogin.Text, em outros textBoxSenha.PasswordChar, ou seja, todas as propriedades podem ser ajustadas conforme o idioma e região em uso.
        /// </summary>
        /// <param name="container">Informar o container inicial, geralmente this para pegar todos os campos da tela, ou então, por exemplo, o nome de um panel ou usercontrol.</param>
        public static void AjustaResourcesControl(Control container)
        {
            foreach (Control c in container.Controls)
            {
                AjustaResourcesControl(c);
                ComponentResourceManager resources = new(typeof(Properties.Resources));
                resources.ApplyResources(c, c.Name);
            }
        }
    }
}