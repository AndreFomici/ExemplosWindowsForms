namespace Registro_de_pessoas
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudIdade = new System.Windows.Forms.NumericUpDown();
            this.txtTelefone = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoFeminino = new System.Windows.Forms.RadioButton();
            this.rdoMasculino = new System.Windows.Forms.RadioButton();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdade)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(159, 199);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(100, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Idade:";
            // 
            // nudIdade
            // 
            this.nudIdade.Location = new System.Drawing.Point(100, 61);
            this.nudIdade.Maximum = new decimal(new int[] {
            140,
            0,
            0,
            0});
            this.nudIdade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIdade.Name = "nudIdade";
            this.nudIdade.Size = new System.Drawing.Size(100, 20);
            this.nudIdade.TabIndex = 5;
            this.nudIdade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtTelefone
            // 
            this.txtTelefone.AutoSize = true;
            this.txtTelefone.Location = new System.Drawing.Point(24, 96);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(52, 13);
            this.txtTelefone.TabIndex = 6;
            this.txtTelefone.Text = "Telefone:";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(100, 93);
            this.mskTelefone.Mask = "(99)00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(100, 20);
            this.mskTelefone.TabIndex = 7;
            this.mskTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoFeminino);
            this.groupBox1.Controls.Add(this.rdoMasculino);
            this.groupBox1.Location = new System.Drawing.Point(27, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 87);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rdoFeminino
            // 
            this.rdoFeminino.AutoSize = true;
            this.rdoFeminino.Checked = true;
            this.rdoFeminino.Location = new System.Drawing.Point(6, 54);
            this.rdoFeminino.Name = "rdoFeminino";
            this.rdoFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdoFeminino.TabIndex = 1;
            this.rdoFeminino.TabStop = true;
            this.rdoFeminino.Text = "Feminino";
            this.rdoFeminino.UseVisualStyleBackColor = true;
            // 
            // rdoMasculino
            // 
            this.rdoMasculino.AutoSize = true;
            this.rdoMasculino.Location = new System.Drawing.Point(7, 31);
            this.rdoMasculino.Name = "rdoMasculino";
            this.rdoMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdoMasculino.TabIndex = 0;
            this.rdoMasculino.Text = "Masculino";
            this.rdoMasculino.UseVisualStyleBackColor = true;
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(12, 246);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.Size = new System.Drawing.Size(228, 192);
            this.dgvRegistros.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 450);
            this.Controls.Add(this.dgvRegistros);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.nudIdade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudIdade)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudIdade;
        private System.Windows.Forms.Label txtTelefone;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoFeminino;
        private System.Windows.Forms.RadioButton rdoMasculino;
        private System.Windows.Forms.DataGridView dgvRegistros;
    }
}

