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
            groupBoxTamanhos.Location = new Point(56, 34);
            groupBoxTamanhos.Margin = new Padding(3, 4, 3, 4);
            groupBoxTamanhos.Name = "groupBoxTamanhos";
            groupBoxTamanhos.Padding = new Padding(3, 4, 3, 4);
            groupBoxTamanhos.Size = new Size(542, 185);
            groupBoxTamanhos.TabIndex = 0;
            groupBoxTamanhos.TabStop = false;
            groupBoxTamanhos.Text = "Tamanhos";
            // 
            // radioButtonTamanhoFamilia
            // 
            radioButtonTamanhoFamilia.AutoSize = true;
            radioButtonTamanhoFamilia.Location = new Point(431, 81);
            radioButtonTamanhoFamilia.Margin = new Padding(3, 4, 3, 4);
            radioButtonTamanhoFamilia.Name = "radioButtonTamanhoFamilia";
            radioButtonTamanhoFamilia.Size = new Size(95, 34);
            radioButtonTamanhoFamilia.TabIndex = 1;
            radioButtonTamanhoFamilia.TabStop = true;
            radioButtonTamanhoFamilia.Text = "Família";
            radioButtonTamanhoFamilia.UseVisualStyleBackColor = true;
            radioButtonTamanhoFamilia.CheckedChanged += radioButtonTamanhoPequeno_CheckedChanged;
            // 
            // radioButtonTamanhoGrande
            // 
            radioButtonTamanhoGrande.AutoSize = true;
            radioButtonTamanhoGrande.Location = new Point(306, 81);
            radioButtonTamanhoGrande.Margin = new Padding(3, 4, 3, 4);
            radioButtonTamanhoGrande.Name = "radioButtonTamanhoGrande";
            radioButtonTamanhoGrande.Size = new Size(97, 34);
            radioButtonTamanhoGrande.TabIndex = 1;
            radioButtonTamanhoGrande.TabStop = true;
            radioButtonTamanhoGrande.Text = "Grande";
            radioButtonTamanhoGrande.UseVisualStyleBackColor = true;
            radioButtonTamanhoGrande.CheckedChanged += radioButtonTamanhoPequeno_CheckedChanged;
            // 
            // radioButtonTamanhoMedio
            // 
            radioButtonTamanhoMedio.AutoSize = true;
            radioButtonTamanhoMedio.Location = new Point(181, 81);
            radioButtonTamanhoMedio.Margin = new Padding(3, 4, 3, 4);
            radioButtonTamanhoMedio.Name = "radioButtonTamanhoMedio";
            radioButtonTamanhoMedio.Size = new Size(86, 34);
            radioButtonTamanhoMedio.TabIndex = 1;
            radioButtonTamanhoMedio.TabStop = true;
            radioButtonTamanhoMedio.Text = "Médio";
            radioButtonTamanhoMedio.UseVisualStyleBackColor = true;
            radioButtonTamanhoMedio.CheckedChanged += radioButtonTamanhoPequeno_CheckedChanged;
            // 
            // radioButtonTamanhoPequeno
            // 
            radioButtonTamanhoPequeno.AutoSize = true;
            radioButtonTamanhoPequeno.Location = new Point(34, 81);
            radioButtonTamanhoPequeno.Margin = new Padding(3, 4, 3, 4);
            radioButtonTamanhoPequeno.Name = "radioButtonTamanhoPequeno";
            radioButtonTamanhoPequeno.Size = new Size(110, 34);
            radioButtonTamanhoPequeno.TabIndex = 1;
            radioButtonTamanhoPequeno.TabStop = true;
            radioButtonTamanhoPequeno.Text = "Pequeno";
            radioButtonTamanhoPequeno.UseVisualStyleBackColor = true;
            radioButtonTamanhoPequeno.CheckedChanged += radioButtonTamanhoPequeno_CheckedChanged;
            // 
            // checkedListBoxSabores
            // 
            checkedListBoxSabores.FormattingEnabled = true;
            checkedListBoxSabores.Location = new Point(56, 302);
            checkedListBoxSabores.Margin = new Padding(3, 4, 3, 4);
            checkedListBoxSabores.Name = "checkedListBoxSabores";
            checkedListBoxSabores.Size = new Size(541, 158);
            checkedListBoxSabores.TabIndex = 1;
            // 
            // labelSabores
            // 
            labelSabores.AutoSize = true;
            labelSabores.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelSabores.Location = new Point(56, 255);
            labelSabores.Name = "labelSabores";
            labelSabores.Size = new Size(82, 30);
            labelSabores.TabIndex = 2;
            labelSabores.Text = "Sabores";
            // 
            // groupBoxPizza
            // 
            groupBoxPizza.Controls.Add(labelSabores);
            groupBoxPizza.Controls.Add(groupBoxTamanhos);
            groupBoxPizza.Controls.Add(checkedListBoxSabores);
            groupBoxPizza.Location = new Point(12, 12);
            groupBoxPizza.Name = "groupBoxPizza";
            groupBoxPizza.Size = new Size(661, 484);
            groupBoxPizza.TabIndex = 3;
            groupBoxPizza.TabStop = false;
            groupBoxPizza.Text = "Pizza";
            // 
            // novaPizza
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxPizza);
            Margin = new Padding(3, 4, 3, 4);
            Name = "novaPizza";
            Size = new Size(694, 508);
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
