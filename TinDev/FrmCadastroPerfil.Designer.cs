
namespace TinDev
{
    partial class FrmCadastroPerfil
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
            this.grpPerfilUsuario = new System.Windows.Forms.GroupBox();
            this.rdbDesenvolvedor = new System.Windows.Forms.RadioButton();
            this.rdbContratante = new System.Windows.Forms.RadioButton();
            this.pnlGeral = new System.Windows.Forms.Panel();
            this.pnlPerfilDev = new System.Windows.Forms.Panel();
            this.mtxTelefoneDev = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbApresentacaoDev = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCadastrarDev = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbInfra = new System.Windows.Forms.RadioButton();
            this.rdbFullStack = new System.Windows.Forms.RadioButton();
            this.rdbBackEnd = new System.Windows.Forms.RadioButton();
            this.rdbFrontEnd = new System.Windows.Forms.RadioButton();
            this.txbSenhaDev = new System.Windows.Forms.TextBox();
            this.txbUsuarioDev = new System.Windows.Forms.TextBox();
            this.txbEmailDev = new System.Windows.Forms.TextBox();
            this.txbNomeDev = new System.Windows.Forms.TextBox();
            this.pnlPerfilContratante = new System.Windows.Forms.Panel();
            this.btnCancelarContratante = new System.Windows.Forms.Button();
            this.btnCadastrarContratante = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txbSenhaContratante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbUsuarioContratante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbEmailContratante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNomeEmpresaContratante = new System.Windows.Forms.TextBox();
            this.grpPerfilUsuario.SuspendLayout();
            this.pnlGeral.SuspendLayout();
            this.pnlPerfilDev.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlPerfilContratante.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPerfilUsuario
            // 
            this.grpPerfilUsuario.Controls.Add(this.rdbDesenvolvedor);
            this.grpPerfilUsuario.Controls.Add(this.rdbContratante);
            this.grpPerfilUsuario.Location = new System.Drawing.Point(12, 12);
            this.grpPerfilUsuario.Name = "grpPerfilUsuario";
            this.grpPerfilUsuario.Size = new System.Drawing.Size(420, 73);
            this.grpPerfilUsuario.TabIndex = 0;
            this.grpPerfilUsuario.TabStop = false;
            this.grpPerfilUsuario.Text = "Qual é o seu perfil de usuário ?";
            this.grpPerfilUsuario.Enter += new System.EventHandler(this.groupBox1_Enter);
            this.grpPerfilUsuario.MouseCaptureChanged += new System.EventHandler(this.grpPerfilUsuario_MouseCaptureChanged);
            // 
            // rdbDesenvolvedor
            // 
            this.rdbDesenvolvedor.AutoSize = true;
            this.rdbDesenvolvedor.Location = new System.Drawing.Point(19, 48);
            this.rdbDesenvolvedor.Name = "rdbDesenvolvedor";
            this.rdbDesenvolvedor.Size = new System.Drawing.Size(158, 19);
            this.rdbDesenvolvedor.TabIndex = 1;
            this.rdbDesenvolvedor.TabStop = true;
            this.rdbDesenvolvedor.Text = "Sou um profissional de TI";
            this.rdbDesenvolvedor.UseVisualStyleBackColor = true;
            this.rdbDesenvolvedor.Click += new System.EventHandler(this.rdbDesenvolvedor_Click);
            // 
            // rdbContratante
            // 
            this.rdbContratante.AutoSize = true;
            this.rdbContratante.Location = new System.Drawing.Point(19, 23);
            this.rdbContratante.Name = "rdbContratante";
            this.rdbContratante.Size = new System.Drawing.Size(380, 19);
            this.rdbContratante.TabIndex = 0;
            this.rdbContratante.TabStop = true;
            this.rdbContratante.Text = "Estou a procura de Profissionais de TI para resolver minha demanda";
            this.rdbContratante.UseVisualStyleBackColor = true;
            this.rdbContratante.Click += new System.EventHandler(this.rdbColaborador_Click);
            // 
            // pnlGeral
            // 
            this.pnlGeral.Controls.Add(this.pnlPerfilDev);
            this.pnlGeral.Controls.Add(this.pnlPerfilContratante);
            this.pnlGeral.Location = new System.Drawing.Point(12, 91);
            this.pnlGeral.Name = "pnlGeral";
            this.pnlGeral.Size = new System.Drawing.Size(1214, 701);
            this.pnlGeral.TabIndex = 3;
            // 
            // pnlPerfilDev
            // 
            this.pnlPerfilDev.BackColor = System.Drawing.SystemColors.Control;
            this.pnlPerfilDev.Controls.Add(this.mtxTelefoneDev);
            this.pnlPerfilDev.Controls.Add(this.label10);
            this.pnlPerfilDev.Controls.Add(this.label9);
            this.pnlPerfilDev.Controls.Add(this.label8);
            this.pnlPerfilDev.Controls.Add(this.label7);
            this.pnlPerfilDev.Controls.Add(this.label6);
            this.pnlPerfilDev.Controls.Add(this.label2);
            this.pnlPerfilDev.Controls.Add(this.rtbApresentacaoDev);
            this.pnlPerfilDev.Controls.Add(this.button1);
            this.pnlPerfilDev.Controls.Add(this.btnCadastrarDev);
            this.pnlPerfilDev.Controls.Add(this.groupBox1);
            this.pnlPerfilDev.Controls.Add(this.txbSenhaDev);
            this.pnlPerfilDev.Controls.Add(this.txbUsuarioDev);
            this.pnlPerfilDev.Controls.Add(this.txbEmailDev);
            this.pnlPerfilDev.Controls.Add(this.txbNomeDev);
            this.pnlPerfilDev.Location = new System.Drawing.Point(461, 39);
            this.pnlPerfilDev.Name = "pnlPerfilDev";
            this.pnlPerfilDev.Size = new System.Drawing.Size(578, 567);
            this.pnlPerfilDev.TabIndex = 4;
            this.pnlPerfilDev.Visible = false;
            // 
            // mtxTelefoneDev
            // 
            this.mtxTelefoneDev.Location = new System.Drawing.Point(21, 110);
            this.mtxTelefoneDev.Mask = "(99)99999-9999";
            this.mtxTelefoneDev.Name = "mtxTelefoneDev";
            this.mtxTelefoneDev.Size = new System.Drawing.Size(193, 23);
            this.mtxTelefoneDev.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Texto de apresentação";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Telefone de contato";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Email de contato";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Usuário";
            // 
            // rtbApresentacaoDev
            // 
            this.rtbApresentacaoDev.Location = new System.Drawing.Point(21, 264);
            this.rtbApresentacaoDev.Name = "rtbApresentacaoDev";
            this.rtbApresentacaoDev.Size = new System.Drawing.Size(540, 263);
            this.rtbApresentacaoDev.TabIndex = 12;
            this.rtbApresentacaoDev.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarDev
            // 
            this.btnCadastrarDev.Location = new System.Drawing.Point(391, 533);
            this.btnCadastrarDev.Name = "btnCadastrarDev";
            this.btnCadastrarDev.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarDev.TabIndex = 10;
            this.btnCadastrarDev.Text = "Cadastrar";
            this.btnCadastrarDev.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbInfra);
            this.groupBox1.Controls.Add(this.rdbFullStack);
            this.groupBox1.Controls.Add(this.rdbBackEnd);
            this.groupBox1.Controls.Add(this.rdbFrontEnd);
            this.groupBox1.Location = new System.Drawing.Point(374, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 147);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perfil de desenvolvimento";
            // 
            // rdbInfra
            // 
            this.rdbInfra.AutoSize = true;
            this.rdbInfra.Location = new System.Drawing.Point(6, 99);
            this.rdbInfra.Name = "rdbInfra";
            this.rdbInfra.Size = new System.Drawing.Size(132, 19);
            this.rdbInfra.TabIndex = 3;
            this.rdbInfra.TabStop = true;
            this.rdbInfra.Text = "Infraestrutura/Redes";
            this.rdbInfra.UseVisualStyleBackColor = true;
            // 
            // rdbFullStack
            // 
            this.rdbFullStack.AutoSize = true;
            this.rdbFullStack.Location = new System.Drawing.Point(6, 74);
            this.rdbFullStack.Name = "rdbFullStack";
            this.rdbFullStack.Size = new System.Drawing.Size(72, 19);
            this.rdbFullStack.TabIndex = 2;
            this.rdbFullStack.TabStop = true;
            this.rdbFullStack.Text = "FullStack";
            this.rdbFullStack.UseVisualStyleBackColor = true;
            // 
            // rdbBackEnd
            // 
            this.rdbBackEnd.AutoSize = true;
            this.rdbBackEnd.Location = new System.Drawing.Point(6, 49);
            this.rdbBackEnd.Name = "rdbBackEnd";
            this.rdbBackEnd.Size = new System.Drawing.Size(70, 19);
            this.rdbBackEnd.TabIndex = 1;
            this.rdbBackEnd.TabStop = true;
            this.rdbBackEnd.Text = "BackEnd";
            this.rdbBackEnd.UseVisualStyleBackColor = true;
            // 
            // rdbFrontEnd
            // 
            this.rdbFrontEnd.AutoSize = true;
            this.rdbFrontEnd.Checked = true;
            this.rdbFrontEnd.Location = new System.Drawing.Point(6, 24);
            this.rdbFrontEnd.Name = "rdbFrontEnd";
            this.rdbFrontEnd.Size = new System.Drawing.Size(73, 19);
            this.rdbFrontEnd.TabIndex = 0;
            this.rdbFrontEnd.TabStop = true;
            this.rdbFrontEnd.Text = "FrontEnd";
            this.rdbFrontEnd.UseVisualStyleBackColor = true;
            // 
            // txbSenhaDev
            // 
            this.txbSenhaDev.Location = new System.Drawing.Point(21, 201);
            this.txbSenhaDev.Name = "txbSenhaDev";
            this.txbSenhaDev.Size = new System.Drawing.Size(193, 23);
            this.txbSenhaDev.TabIndex = 4;
            this.txbSenhaDev.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // txbUsuarioDev
            // 
            this.txbUsuarioDev.Location = new System.Drawing.Point(21, 156);
            this.txbUsuarioDev.Name = "txbUsuarioDev";
            this.txbUsuarioDev.Size = new System.Drawing.Size(193, 23);
            this.txbUsuarioDev.TabIndex = 3;
            // 
            // txbEmailDev
            // 
            this.txbEmailDev.Location = new System.Drawing.Point(21, 66);
            this.txbEmailDev.Name = "txbEmailDev";
            this.txbEmailDev.Size = new System.Drawing.Size(281, 23);
            this.txbEmailDev.TabIndex = 1;
            // 
            // txbNomeDev
            // 
            this.txbNomeDev.Location = new System.Drawing.Point(21, 22);
            this.txbNomeDev.Name = "txbNomeDev";
            this.txbNomeDev.Size = new System.Drawing.Size(281, 23);
            this.txbNomeDev.TabIndex = 0;
            // 
            // pnlPerfilContratante
            // 
            this.pnlPerfilContratante.BackColor = System.Drawing.SystemColors.Control;
            this.pnlPerfilContratante.Controls.Add(this.btnCancelarContratante);
            this.pnlPerfilContratante.Controls.Add(this.btnCadastrarContratante);
            this.pnlPerfilContratante.Controls.Add(this.label5);
            this.pnlPerfilContratante.Controls.Add(this.txbSenhaContratante);
            this.pnlPerfilContratante.Controls.Add(this.label4);
            this.pnlPerfilContratante.Controls.Add(this.txbUsuarioContratante);
            this.pnlPerfilContratante.Controls.Add(this.label3);
            this.pnlPerfilContratante.Controls.Add(this.txbEmailContratante);
            this.pnlPerfilContratante.Controls.Add(this.label1);
            this.pnlPerfilContratante.Controls.Add(this.txbNomeEmpresaContratante);
            this.pnlPerfilContratante.Location = new System.Drawing.Point(19, 18);
            this.pnlPerfilContratante.Name = "pnlPerfilContratante";
            this.pnlPerfilContratante.Size = new System.Drawing.Size(315, 459);
            this.pnlPerfilContratante.TabIndex = 3;
            this.pnlPerfilContratante.Visible = false;
            // 
            // btnCancelarContratante
            // 
            this.btnCancelarContratante.Location = new System.Drawing.Point(200, 342);
            this.btnCancelarContratante.Name = "btnCancelarContratante";
            this.btnCancelarContratante.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarContratante.TabIndex = 9;
            this.btnCancelarContratante.Text = "Cancelar";
            this.btnCancelarContratante.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarContratante
            // 
            this.btnCadastrarContratante.Location = new System.Drawing.Point(53, 343);
            this.btnCadastrarContratante.Name = "btnCadastrarContratante";
            this.btnCadastrarContratante.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarContratante.TabIndex = 8;
            this.btnCadastrarContratante.Text = "Cadastrar";
            this.btnCadastrarContratante.UseVisualStyleBackColor = true;
            this.btnCadastrarContratante.Click += new System.EventHandler(this.btnCadastrarContratante_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Senha";
            // 
            // txbSenhaContratante
            // 
            this.txbSenhaContratante.Location = new System.Drawing.Point(53, 275);
            this.txbSenhaContratante.Name = "txbSenhaContratante";
            this.txbSenhaContratante.Size = new System.Drawing.Size(209, 23);
            this.txbSenhaContratante.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Usuário";
            // 
            // txbUsuarioContratante
            // 
            this.txbUsuarioContratante.Location = new System.Drawing.Point(53, 202);
            this.txbUsuarioContratante.Name = "txbUsuarioContratante";
            this.txbUsuarioContratante.Size = new System.Drawing.Size(209, 23);
            this.txbUsuarioContratante.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email de contato";
            // 
            // txbEmailContratante
            // 
            this.txbEmailContratante.Location = new System.Drawing.Point(53, 137);
            this.txbEmailContratante.Name = "txbEmailContratante";
            this.txbEmailContratante.Size = new System.Drawing.Size(209, 23);
            this.txbEmailContratante.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da empresa";
            // 
            // txbNomeEmpresaContratante
            // 
            this.txbNomeEmpresaContratante.Location = new System.Drawing.Point(53, 78);
            this.txbNomeEmpresaContratante.Name = "txbNomeEmpresaContratante";
            this.txbNomeEmpresaContratante.Size = new System.Drawing.Size(209, 23);
            this.txbNomeEmpresaContratante.TabIndex = 0;
            // 
            // FrmCadastroPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 829);
            this.Controls.Add(this.grpPerfilUsuario);
            this.Controls.Add(this.pnlGeral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Shown += new System.EventHandler(this.FrmCadastroPerfil_Shown);
            this.grpPerfilUsuario.ResumeLayout(false);
            this.grpPerfilUsuario.PerformLayout();
            this.pnlGeral.ResumeLayout(false);
            this.pnlPerfilDev.ResumeLayout(false);
            this.pnlPerfilDev.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlPerfilContratante.ResumeLayout(false);
            this.pnlPerfilContratante.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPerfilUsuario;
        private System.Windows.Forms.RadioButton rdbDesenvolvedor;
        private System.Windows.Forms.RadioButton rdbContratante;
        private System.Windows.Forms.Panel pnlGeral;
        private System.Windows.Forms.Panel pnlPerfilDev;
        private System.Windows.Forms.Panel pnlPerfilContratante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbSenhaContratante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbUsuarioContratante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbEmailContratante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNomeEmpresaContratante;
        private System.Windows.Forms.Button btnCancelarContratante;
        private System.Windows.Forms.Button btnRegistrarContratante;
        private System.Windows.Forms.TextBox txbSenhaDev;
        private System.Windows.Forms.TextBox txbUsuarioDev;
        private System.Windows.Forms.TextBox txbEmailDev;
        private System.Windows.Forms.TextBox txbNomeDev;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbInfra;
        private System.Windows.Forms.RadioButton rdbFullStack;
        private System.Windows.Forms.RadioButton rdbBackEnd;
        private System.Windows.Forms.RadioButton rdbFrontEnd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCadastrarDev;
        private System.Windows.Forms.RichTextBox rtbApresentacaoDev;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxTelefoneDev;
        private System.Windows.Forms.Button btnCadastrarContratante;
    }
}