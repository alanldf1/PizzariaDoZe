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
            radioButtonTamanhoPequeno = new RadioButton();
            radioButtonTamanhoMedio = new RadioButton();
            radioButtonTamanhoGrande = new RadioButton();
            radioButtonTamanhoFamilia = new RadioButton();
            checkedListBoxSabores = new CheckedListBox();
            groupBoxTamanhos.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTamanhos
            // 
            groupBoxTamanhos.Controls.Add(radioButtonTamanhoFamilia);
            groupBoxTamanhos.Controls.Add(radioButtonTamanhoGrande);
            groupBoxTamanhos.Controls.Add(radioButtonTamanhoMedio);
            groupBoxTamanhos.Controls.Add(radioButtonTamanhoPequeno);
            groupBoxTamanhos.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxTamanhos.Location = new Point(51, 44);
            groupBoxTamanhos.Name = "groupBoxTamanhos";
            groupBoxTamanhos.Size = new Size(474, 139);
            groupBoxTamanhos.TabIndex = 0;
            groupBoxTamanhos.TabStop = false;
            groupBoxTamanhos.Text = "Tamanhos";
            // 
            // radioButtonTamanhoPequeno
            // 
            radioButtonTamanhoPequeno.AutoSize = true;
            radioButtonTamanhoPequeno.Location = new Point(30, 61);
            radioButtonTamanhoPequeno.Name = "radioButtonTamanhoPequeno";
            radioButtonTamanhoPequeno.Size = new Size(92, 29);
            radioButtonTamanhoPequeno.TabIndex = 1;
            radioButtonTamanhoPequeno.TabStop = true;
            radioButtonTamanhoPequeno.Text = "Pequeno";
            radioButtonTamanhoPequeno.UseVisualStyleBackColor = true;
            radioButtonTamanhoPequeno.CheckedChanged += radioButtonTamanhoPequeno_CheckedChanged;
            // 
            // radioButtonTamanhoMedio
            // 
            radioButtonTamanhoMedio.AutoSize = true;
            radioButtonTamanhoMedio.Location = new Point(158, 61);
            radioButtonTamanhoMedio.Name = "radioButtonTamanhoMedio";
            radioButtonTamanhoMedio.Size = new Size(72, 29);
            radioButtonTamanhoMedio.TabIndex = 1;
            radioButtonTamanhoMedio.TabStop = true;
            radioButtonTamanhoMedio.Text = "Médio";
            radioButtonTamanhoMedio.UseVisualStyleBackColor = true;
            radioButtonTamanhoMedio.CheckedChanged += radioButtonTamanhoPequeno_CheckedChanged;
            // 
            // radioButtonTamanhoGrande
            // 
            radioButtonTamanhoGrande.AutoSize = true;
            radioButtonTamanhoGrande.Location = new Point(268, 61);
            radioButtonTamanhoGrande.Name = "radioButtonTamanhoGrande";
            radioButtonTamanhoGrande.Size = new Size(82, 29);
            radioButtonTamanhoGrande.TabIndex = 1;
            radioButtonTamanhoGrande.TabStop = true;
            radioButtonTamanhoGrande.Text = "Grande";
            radioButtonTamanhoGrande.UseVisualStyleBackColor = true;
            radioButtonTamanhoGrande.CheckedChanged += radioButtonTamanhoPequeno_CheckedChanged;
            // 
            // radioButtonTamanhoFamilia
            // 
            radioButtonTamanhoFamilia.AutoSize = true;
            radioButtonTamanhoFamilia.Location = new Point(377, 61);
            radioButtonTamanhoFamilia.Name = "radioButtonTamanhoFamilia";
            radioButtonTamanhoFamilia.Size = new Size(78, 29);
            radioButtonTamanhoFamilia.TabIndex = 1;
            radioButtonTamanhoFamilia.TabStop = true;
            radioButtonTamanhoFamilia.Text = "Família";
            radioButtonTamanhoFamilia.UseVisualStyleBackColor = true;
            radioButtonTamanhoFamilia.CheckedChanged += radioButtonTamanhoPequeno_CheckedChanged;
            // 
            // checkedListBoxSabores
            // 
            checkedListBoxSabores.FormattingEnabled = true;
            checkedListBoxSabores.Location = new Point(51, 245);
            checkedListBoxSabores.Name = "checkedListBoxSabores";
            checkedListBoxSabores.Size = new Size(474, 130);
            checkedListBoxSabores.TabIndex = 1;
            // 
            // novaPizza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(checkedListBoxSabores);
            Controls.Add(groupBoxTamanhos);
            Name = "novaPizza";
            Size = new Size(614, 570);
            groupBoxTamanhos.ResumeLayout(false);
            groupBoxTamanhos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTamanhos;
        private RadioButton radioButtonTamanhoPequeno;
        private RadioButton radioButtonTamanhoFamilia;
        private RadioButton radioButtonTamanhoGrande;
        private RadioButton radioButtonTamanhoMedio;
        private CheckedListBox checkedListBoxSabores;
    }
}
