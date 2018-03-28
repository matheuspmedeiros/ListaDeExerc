namespace br.edu.etec.zonaleste.consultoriomed
{
    partial class frmCadEspecialidadeMed
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblId_Especialidade = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbId_especialidade = new System.Windows.Forms.TextBox();
            this.txbEspecialidade = new System.Windows.Forms.TextBox();
            this.lblListaEspecialidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(118, 239);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(258, 239);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(398, 239);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(54, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(495, 147);
            this.listBox1.TabIndex = 3;
            // 
            // lblId_Especialidade
            // 
            this.lblId_Especialidade.AutoSize = true;
            this.lblId_Especialidade.Location = new System.Drawing.Point(51, 9);
            this.lblId_Especialidade.Name = "lblId_Especialidade";
            this.lblId_Especialidade.Size = new System.Drawing.Size(90, 13);
            this.lblId_Especialidade.TabIndex = 4;
            this.lblId_Especialidade.Text = "ID Especialidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Especialidade:";
            // 
            // txbId_especialidade
            // 
            this.txbId_especialidade.Location = new System.Drawing.Point(54, 25);
            this.txbId_especialidade.Name = "txbId_especialidade";
            this.txbId_especialidade.Size = new System.Drawing.Size(100, 20);
            this.txbId_especialidade.TabIndex = 6;
            // 
            // txbEspecialidade
            // 
            this.txbEspecialidade.Location = new System.Drawing.Point(164, 25);
            this.txbEspecialidade.Name = "txbEspecialidade";
            this.txbEspecialidade.Size = new System.Drawing.Size(385, 20);
            this.txbEspecialidade.TabIndex = 7;
            // 
            // lblListaEspecialidade
            // 
            this.lblListaEspecialidade.AutoSize = true;
            this.lblListaEspecialidade.Location = new System.Drawing.Point(51, 48);
            this.lblListaEspecialidade.Name = "lblListaEspecialidade";
            this.lblListaEspecialidade.Size = new System.Drawing.Size(121, 13);
            this.lblListaEspecialidade.TabIndex = 8;
            this.lblListaEspecialidade.Text = "Lista de Especialidades:";
            // 
            // frmCadEspecialidadeMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 283);
            this.Controls.Add(this.lblListaEspecialidade);
            this.Controls.Add(this.txbEspecialidade);
            this.Controls.Add(this.txbId_especialidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblId_Especialidade);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Name = "frmCadEspecialidadeMed";
            this.Text = "Cadastro de Especialidades Médicas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadEspecialidadeMed_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblId_Especialidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbId_especialidade;
        private System.Windows.Forms.TextBox txbEspecialidade;
        private System.Windows.Forms.Label lblListaEspecialidade;
    }
}