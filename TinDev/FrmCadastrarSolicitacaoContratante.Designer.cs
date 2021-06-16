
namespace TinDev
{
    partial class FrmCadastrarSolicitacaoContratante
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
            this.grpSistemas = new System.Windows.Forms.GroupBox();
            this.rdbInfra = new System.Windows.Forms.RadioButton();
            this.rdbNaoInformaContratante = new System.Windows.Forms.RadioButton();
            this.rdbHibrido = new System.Windows.Forms.RadioButton();
            this.rdbFront = new System.Windows.Forms.RadioButton();
            this.rdbBack = new System.Windows.Forms.RadioButton();
            this.grpContratante = new System.Windows.Forms.GroupBox();
            this.rdbInformaContratante = new System.Windows.Forms.RadioButton();
            this.naoInformaContratante = new System.Windows.Forms.RadioButton();
            this.descricaoTrabalho = new System.Windows.Forms.Label();
            this.campoDescricaoTrabalho = new System.Windows.Forms.RichTextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnPublicar = new System.Windows.Forms.Button();
            this.campoTituloTrabalho = new System.Windows.Forms.RichTextBox();
            this.tituloTrabalho = new System.Windows.Forms.Label();
            this.grpSistemas.SuspendLayout();
            this.grpContratante.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSistemas
            // 
            this.grpSistemas.Controls.Add(this.rdbInfra);
            this.grpSistemas.Controls.Add(this.rdbNaoInformaContratante);
            this.grpSistemas.Controls.Add(this.rdbHibrido);
            this.grpSistemas.Controls.Add(this.rdbFront);
            this.grpSistemas.Controls.Add(this.rdbBack);
            this.grpSistemas.Location = new System.Drawing.Point(12, 12);
            this.grpSistemas.Name = "grpSistemas";
            this.grpSistemas.Size = new System.Drawing.Size(420, 156);
            this.grpSistemas.TabIndex = 1;
            this.grpSistemas.TabStop = false;
            this.grpSistemas.Text = "Qual é o tipo de sistema que você está precisando?";
            // 
            // rdbInfra
            // 
            this.rdbInfra.Location = new System.Drawing.Point(6, 131);
            this.rdbInfra.Name = "rdbInfra";
            this.rdbInfra.Size = new System.Drawing.Size(145, 19);
            this.rdbInfra.TabIndex = 4;
            this.rdbInfra.TabStop = true;
            this.rdbInfra.Text = "Infraestrutura / Redes";
            this.rdbInfra.UseVisualStyleBackColor = true;
            // 
            // rdbNaoInformaContratante
            // 
            this.rdbNaoInformaContratante.Checked = true;
            this.rdbNaoInformaContratante.Location = new System.Drawing.Point(6, 31);
            this.rdbNaoInformaContratante.Name = "rdbNaoInformaContratante";
            this.rdbNaoInformaContratante.Size = new System.Drawing.Size(125, 19);
            this.rdbNaoInformaContratante.TabIndex = 0;
            this.rdbNaoInformaContratante.TabStop = true;
            this.rdbNaoInformaContratante.Text = "Não sei informar";
            this.rdbNaoInformaContratante.UseVisualStyleBackColor = true;
            // 
            // rdbHibrido
            // 
            this.rdbHibrido.Location = new System.Drawing.Point(6, 106);
            this.rdbHibrido.Name = "rdbHibrido";
            this.rdbHibrido.Size = new System.Drawing.Size(125, 19);
            this.rdbHibrido.TabIndex = 3;
            this.rdbHibrido.TabStop = true;
            this.rdbHibrido.Text = "Sistema Híbrido";
            this.rdbHibrido.UseVisualStyleBackColor = true;
            // 
            // rdbFront
            // 
            this.rdbFront.Location = new System.Drawing.Point(6, 56);
            this.rdbFront.Name = "rdbFront";
            this.rdbFront.Size = new System.Drawing.Size(125, 19);
            this.rdbFront.TabIndex = 1;
            this.rdbFront.TabStop = true;
            this.rdbFront.Text = "Sistema Front-End ";
            this.rdbFront.UseVisualStyleBackColor = true;
            // 
            // rdbBack
            // 
            this.rdbBack.Location = new System.Drawing.Point(6, 81);
            this.rdbBack.Name = "rdbBack";
            this.rdbBack.Size = new System.Drawing.Size(119, 19);
            this.rdbBack.TabIndex = 2;
            this.rdbBack.TabStop = true;
            this.rdbBack.Text = "Sistema Back-End";
            this.rdbBack.UseVisualStyleBackColor = true;
            // 
            // grpContratante
            // 
            this.grpContratante.Controls.Add(this.rdbInformaContratante);
            this.grpContratante.Controls.Add(this.naoInformaContratante);
            this.grpContratante.Location = new System.Drawing.Point(12, 174);
            this.grpContratante.Name = "grpContratante";
            this.grpContratante.Size = new System.Drawing.Size(422, 82);
            this.grpContratante.TabIndex = 5;
            this.grpContratante.TabStop = false;
            this.grpContratante.Text = "Informar nome do contratante?";
            // 
            // rdbInformaContratante
            // 
            this.rdbInformaContratante.Checked = true;
            this.rdbInformaContratante.Location = new System.Drawing.Point(6, 25);
            this.rdbInformaContratante.Name = "rdbInformaContratante";
            this.rdbInformaContratante.Size = new System.Drawing.Size(125, 19);
            this.rdbInformaContratante.TabIndex = 0;
            this.rdbInformaContratante.TabStop = true;
            this.rdbInformaContratante.Text = "Sim";
            this.rdbInformaContratante.UseVisualStyleBackColor = true;
            // 
            // naoInformaContratante
            // 
            this.naoInformaContratante.Location = new System.Drawing.Point(6, 50);
            this.naoInformaContratante.Name = "naoInformaContratante";
            this.naoInformaContratante.Size = new System.Drawing.Size(125, 19);
            this.naoInformaContratante.TabIndex = 3;
            this.naoInformaContratante.TabStop = true;
            this.naoInformaContratante.Text = "Não";
            this.naoInformaContratante.UseVisualStyleBackColor = true;
            // 
            // descricaoTrabalho
            // 
            this.descricaoTrabalho.AutoSize = true;
            this.descricaoTrabalho.Location = new System.Drawing.Point(9, 321);
            this.descricaoTrabalho.Name = "descricaoTrabalho";
            this.descricaoTrabalho.Size = new System.Drawing.Size(123, 15);
            this.descricaoTrabalho.TabIndex = 20;
            this.descricaoTrabalho.Text = "Descrição do Trabalho";
            // 
            // campoDescricaoTrabalho
            // 
            this.campoDescricaoTrabalho.Location = new System.Drawing.Point(9, 339);
            this.campoDescricaoTrabalho.Name = "campoDescricaoTrabalho";
            this.campoDescricaoTrabalho.Size = new System.Drawing.Size(420, 141);
            this.campoDescricaoTrabalho.TabIndex = 19;
            this.campoDescricaoTrabalho.Text = "";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(94, 486);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(108, 23);
            this.btnEntrar.TabIndex = 21;
            this.btnEntrar.Text = "Voltar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPublicar
            // 
            this.btnPublicar.Location = new System.Drawing.Point(208, 486);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(108, 23);
            this.btnPublicar.TabIndex = 22;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.UseVisualStyleBackColor = true;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // campoTituloTrabalho
            // 
            this.campoTituloTrabalho.Location = new System.Drawing.Point(12, 294);
            this.campoTituloTrabalho.Name = "campoTituloTrabalho";
            this.campoTituloTrabalho.Size = new System.Drawing.Size(417, 24);
            this.campoTituloTrabalho.TabIndex = 23;
            this.campoTituloTrabalho.Text = "";
            // 
            // tituloTrabalho
            // 
            this.tituloTrabalho.AutoSize = true;
            this.tituloTrabalho.Location = new System.Drawing.Point(9, 276);
            this.tituloTrabalho.Name = "tituloTrabalho";
            this.tituloTrabalho.Size = new System.Drawing.Size(102, 15);
            this.tituloTrabalho.TabIndex = 24;
            this.tituloTrabalho.Text = "Título do Trabalho";
            // 
            // FrmCadastrarSolicitacaoContratante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 521);
            this.Controls.Add(this.grpContratante);
            this.Controls.Add(this.tituloTrabalho);
            this.Controls.Add(this.campoTituloTrabalho);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.descricaoTrabalho);
            this.Controls.Add(this.campoDescricaoTrabalho);
            this.Controls.Add(this.grpSistemas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastrarSolicitacaoContratante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Vaga";
            this.grpSistemas.ResumeLayout(false);
            this.grpContratante.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSistemas;
        private System.Windows.Forms.RadioButton rdbFront;
        private System.Windows.Forms.RadioButton rdbBack;
        private System.Windows.Forms.RadioButton rdbHibrido;
        private System.Windows.Forms.RadioButton rdbNaoInformaContratante;
        private System.Windows.Forms.Label descricaoTrabalho;
        private System.Windows.Forms.RichTextBox campoDescricaoTrabalho;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnPublicar;
        private System.Windows.Forms.RichTextBox campoTituloTrabalho;
        private System.Windows.Forms.Label tituloTrabalho;
        private System.Windows.Forms.RadioButton rdbInfra;
        private System.Windows.Forms.GroupBox grpContratante;
        private System.Windows.Forms.RadioButton rdbInformaContratante;
        private System.Windows.Forms.RadioButton naoInformaContratante;
    }
}