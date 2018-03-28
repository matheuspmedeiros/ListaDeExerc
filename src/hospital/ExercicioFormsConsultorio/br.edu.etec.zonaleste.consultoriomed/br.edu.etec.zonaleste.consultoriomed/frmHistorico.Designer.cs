namespace br.edu.etec.zonaleste.consultoriomed
{
    partial class frmHistorico
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
            this.groupBoxObsMedicas = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBoxDadosPaciente = new System.Windows.Forms.GroupBox();
            this.lblIdPaciente = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIdConsulta = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBoxObsMedicas.SuspendLayout();
            this.groupBoxDadosPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxObsMedicas
            // 
            this.groupBoxObsMedicas.Controls.Add(this.richTextBox1);
            this.groupBoxObsMedicas.Location = new System.Drawing.Point(26, 206);
            this.groupBoxObsMedicas.Name = "groupBoxObsMedicas";
            this.groupBoxObsMedicas.Size = new System.Drawing.Size(602, 180);
            this.groupBoxObsMedicas.TabIndex = 0;
            this.groupBoxObsMedicas.TabStop = false;
            this.groupBoxObsMedicas.Text = "Observações Médicas:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(14, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(574, 143);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBoxDadosPaciente
            // 
            this.groupBoxDadosPaciente.Controls.Add(this.btnProcurar);
            this.groupBoxDadosPaciente.Controls.Add(this.textBox3);
            this.groupBoxDadosPaciente.Controls.Add(this.textBox2);
            this.groupBoxDadosPaciente.Controls.Add(this.textBox1);
            this.groupBoxDadosPaciente.Controls.Add(this.lblIdConsulta);
            this.groupBoxDadosPaciente.Controls.Add(this.lblNome);
            this.groupBoxDadosPaciente.Controls.Add(this.lblIdPaciente);
            this.groupBoxDadosPaciente.Location = new System.Drawing.Point(26, 12);
            this.groupBoxDadosPaciente.Name = "groupBoxDadosPaciente";
            this.groupBoxDadosPaciente.Size = new System.Drawing.Size(602, 188);
            this.groupBoxDadosPaciente.TabIndex = 1;
            this.groupBoxDadosPaciente.TabStop = false;
            this.groupBoxDadosPaciente.Text = "Dados do Paciente:";
            // 
            // lblIdPaciente
            // 
            this.lblIdPaciente.AutoSize = true;
            this.lblIdPaciente.Location = new System.Drawing.Point(21, 79);
            this.lblIdPaciente.Name = "lblIdPaciente";
            this.lblIdPaciente.Size = new System.Drawing.Size(66, 13);
            this.lblIdPaciente.TabIndex = 0;
            this.lblIdPaciente.Text = "ID Paciente:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(148, 79);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblIdConsulta
            // 
            this.lblIdConsulta.AutoSize = true;
            this.lblIdConsulta.Location = new System.Drawing.Point(21, 25);
            this.lblIdConsulta.Name = "lblIdConsulta";
            this.lblIdConsulta.Size = new System.Drawing.Size(65, 13);
            this.lblIdConsulta.TabIndex = 2;
            this.lblIdConsulta.Text = "ID Consulta:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(151, 95);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(437, 20);
            this.textBox3.TabIndex = 5;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(24, 141);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 6;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(117, 418);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 2;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(269, 418);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(422, 418);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // frmHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 465);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.groupBoxDadosPaciente);
            this.Controls.Add(this.groupBoxObsMedicas);
            this.Name = "frmHistorico";
            this.Text = "Historico de Pacientes";
            this.groupBoxObsMedicas.ResumeLayout(false);
            this.groupBoxDadosPaciente.ResumeLayout(false);
            this.groupBoxDadosPaciente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxObsMedicas;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBoxDadosPaciente;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblIdConsulta;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdPaciente;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnFechar;
    }
}