
namespace TinDev
{
    partial class FrmNotificacoesDev
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotificacoesDev));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnNotificacoes = new System.Windows.Forms.Button();
            this.dtgNotificacao = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNotificacao)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // btnNotificacoes
            // 
            this.btnNotificacoes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNotificacoes.Location = new System.Drawing.Point(30, 69);
            this.btnNotificacoes.Name = "btnNotificacoes";
            this.btnNotificacoes.Size = new System.Drawing.Size(81, 24);
            this.btnNotificacoes.TabIndex = 0;
            this.btnNotificacoes.Text = "Atualizar";
            this.btnNotificacoes.UseVisualStyleBackColor = true;
            this.btnNotificacoes.Click += new System.EventHandler(this.Atualizar_Notificacoes);
            // 
            // dtgNotificacao
            // 
            this.dtgNotificacao.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgNotificacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgNotificacao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgNotificacao.ColumnHeadersHeight = 40;
            this.dtgNotificacao.GridColor = System.Drawing.SystemColors.Control;
            this.dtgNotificacao.Location = new System.Drawing.Point(30, 108);
            this.dtgNotificacao.Name = "dtgNotificacao";
            this.dtgNotificacao.RowTemplate.Height = 25;
            this.dtgNotificacao.Size = new System.Drawing.Size(743, 309);
            this.dtgNotificacao.TabIndex = 1;
            this.dtgNotificacao.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgNotificacao_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(681, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "TinDev";
            // 
            // FrmNotificacoesDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgNotificacao);
            this.Controls.Add(this.btnNotificacoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNotificacoesDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificações";
            this.Shown += new System.EventHandler(this.FrmNotificacoesDev_Shown);
            this.Resize += new System.EventHandler(this.FrmNotificacoesDev_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNotificacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnNotificacoes;
        private System.Windows.Forms.DataGridView dtgNotificacao;
        private System.Windows.Forms.Label label1;
    }
}