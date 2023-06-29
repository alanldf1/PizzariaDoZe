namespace PizzariaDoZe
{
    partial class novaPizza
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxTamanhos = new GroupBox();
            radioButtonTamanhoFamilia = new RadioButton();
            radioButtonTamanhoGrande = new RadioButton();
            radioButtonTamanhoMedio = new RadioButton();
            radioButtonTamanhoPequeno = new RadioButton();
            checkedListBoxSabores = new CheckedListBox();
            labelSabores = new Label();
            groupBoxPizza = new GroupBox();
            groupBoxTamanhos.SuspendLayout();
            groupBoxPizza.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTamanhos
            // 
            groupBoxTamanhos.Controls.Add(radioButtonTamanhoFamilia);
            groupBoxTamanhos.Controls.Add(radioButtonTamanhoGrande);
            groupBoxTamanhos.Controls.Add(radioButtonTamanhoMedio);
            groupBoxTamanhos.Controls.Add(radioButtonTamanhoPequeno);
            groupBoxTamanhos.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxTamanhos.Location = new Point(49, 26);
            groupBoxTamanhos.Name = "groupBoxTamanhos";
            groupBoxTamanhos.Size = new Size(474, 81);
            groupBoxTamanhos.TabIndex = 0;
            groupBoxTamanhos.TabStop = false;
            groupBoxTamanhos.Text = "Tamanhos";
            // 
            // radioButtonTamanhoFamilia
            // 
            radioButtonTamanhoFamilia.AutoSize = true;
            radioButtonTamanhoFamilia.Location = new Point(370, 35);
            radioButtonTamanhoFamilia.Name = "radioButtonTamanhoFamilia";
            radioButtonTamanhoFamilia.Size = new Size(78, 29);
            radioButtonTamanhoFamilia.TabIndex = 1;
            radioButtonTamanhoFamilia.TabStop = true;
            radioButtonTamanhoFamilia.Text = "Família";
            radioButtonTamanhoFamilia.UseVisualStyleBackColor = true;
            // 
            // radioButtonTamanhoGrande
            // 
            radioButtonTamanhoGrande.AutoSize = true;
            radioButtonTamanhoGrande.Location = new Point(261, 35);
            radioButtonTamanhoGrande.Name = "radioButtonTamanhoGrande";
            radioButtonTamanhoGrande.Size = new Size(82, 29);
            radioButtonTamanhoGrande.TabIndex = 1;
            radioButtonTamanhoGrande.TabStop = true;
            radioButtonTamanhoGrande.Text = "Grande";
            radioButtonTamanhoGrande.UseVisualStyleBackColor = true;
            // 
            // radioButtonTamanhoMedio
            // 
            radioButtonTamanhoMedio.AutoSize = true;
            radioButtonTamanhoMedio.Location = new Point(151, 35);
            radioButtonTamanhoMedio.Name = "radioButtonTamanhoMedio";
            radioButtonTamanhoMedio.Size = new Size(72, 29);
            radioButtonTamanhoMedio.TabIndex = 1;
            radioButtonTamanhoMedio.TabStop = true;
            radioButtonTamanhoMedio.Text = "Médio";
            radioButtonTamanhoMedio.UseVisualStyleBackColor = true;
            // 
            // radioButtonTamanhoPequeno
            // 
            radioButtonTamanhoPequeno.AutoSize = true;
            radioButtonTamanhoPequeno.Location = new Point(23, 35);
            radioButtonTamanhoPequeno.Name = "radioButtonTamanhoPequeno";
            radioButtonTamanhoPequeno.Size = new Size(92, 29);
            radioButtonTamanhoPequeno.TabIndex = 1;
            radioButtonTamanhoPequeno.TabStop = true;
            radioButtonTamanhoPequeno.Text = "Pequeno";
            radioButtonTamanhoPequeno.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxSabores
            // 
            checkedListBoxSabores.FormattingEnabled = true;
            checkedListBoxSabores.Location = new Point(49, 160);
            checkedListBoxSabores.Name = "checkedListBoxSabores";
            checkedListBoxSabores.Size = new Size(474, 112);
            checkedListBoxSabores.TabIndex = 1;
            checkedListBoxSabores.ItemCheck += checkedListBoxSabores_ItemCheck;
            // 
            // labelSabores
            // 
            labelSabores.AutoSize = true;
            labelSabores.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelSabores.Location = new Point(49, 125);
            labelSabores.Name = "labelSabores";
            labelSabores.Size = new Size(68, 25);
            labelSabores.TabIndex = 2;
            labelSabores.Text = "Sabores";
            // 
            // groupBoxPizza
            // 
            groupBoxPizza.Controls.Add(labelSabores);
            groupBoxPizza.Controls.Add(groupBoxTamanhos);
            groupBoxPizza.Controls.Add(checkedListBoxSabores);
            groupBoxPizza.Location = new Point(10, 9);
            groupBoxPizza.Margin = new Padding(3, 2, 3, 2);
            groupBoxPizza.Name = "groupBoxPizza";
            groupBoxPizza.Padding = new Padding(3, 2, 3, 2);
            groupBoxPizza.Size = new Size(578, 416);
            groupBoxPizza.TabIndex = 3;
            groupBoxPizza.TabStop = false;
            groupBoxPizza.Text = "Pizza";
            // 
            // novaPizza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxPizza);
            Name = "novaPizza";
            Size = new Size(607, 437);
            groupBoxTamanhos.ResumeLayout(false);
            groupBoxTamanhos.PerformLayout();
            groupBoxPizza.ResumeLayout(false);
            groupBoxPizza.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTamanhos;
        private RadioButton radioButtonTamanhoPequeno;
        private RadioButton radioButtonTamanhoFamilia;
        private RadioButton radioButtonTamanhoGrande;
        private RadioButton radioButtonTamanhoMedio;
        private CheckedListBox checkedListBoxSabores;
        private Label labelSabores;
        private GroupBox groupBoxPizza;
    }
}
