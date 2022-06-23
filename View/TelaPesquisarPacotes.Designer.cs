
namespace ProjetoAgenciaTI11T.View
{
    partial class TelaPesquisarPacotes
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNome = new System.Windows.Forms.Button();
            this.tbxNomeCli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnImagem = new System.Windows.Forms.Button();
            this.pbxImagem = new System.Windows.Forms.PictureBox();
            this.tbxDestino = new System.Windows.Forms.TextBox();
            this.tbxOrigem = new System.Windows.Forms.TextBox();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCod = new System.Windows.Forms.Button();
            this.tbxCod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpIda = new System.Windows.Forms.DateTimePicker();
            this.dtpVolta = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(306, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar Pacotes";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(765, 367);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewCliente);
            this.tabPage1.Controls.Add(this.btnNome);
            this.tabPage1.Controls.Add(this.tbxNomeCli);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(757, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisar por nome";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nome,
            this.Email,
            this.Foto});
            this.dataGridViewCliente.Location = new System.Drawing.Point(6, 85);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.RowHeadersVisible = false;
            this.dataGridViewCliente.RowTemplate.Height = 25;
            this.dataGridViewCliente.Size = new System.Drawing.Size(745, 248);
            this.dataGridViewCliente.TabIndex = 3;
            // 
            // Código
            // 
            this.Código.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.Width = 60;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Foto
            // 
            this.Foto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Foto.HeaderText = "Foto";
            this.Foto.Name = "Foto";
            // 
            // btnNome
            // 
            this.btnNome.Location = new System.Drawing.Point(685, 36);
            this.btnNome.Name = "btnNome";
            this.btnNome.Size = new System.Drawing.Size(57, 23);
            this.btnNome.TabIndex = 2;
            this.btnNome.Text = "Buscar";
            this.btnNome.UseVisualStyleBackColor = true;
            // 
            // tbxNomeCli
            // 
            this.tbxNomeCli.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxNomeCli.Location = new System.Drawing.Point(194, 32);
            this.tbxNomeCli.Name = "tbxNomeCli";
            this.tbxNomeCli.Size = new System.Drawing.Size(469, 29);
            this.tbxNomeCli.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Digite o nome do cliente:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtbDescricao);
            this.tabPage2.Controls.Add(this.dtpVolta);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dtpIda);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnDeletar);
            this.tabPage2.Controls.Add(this.btnAlterar);
            this.tabPage2.Controls.Add(this.btnImagem);
            this.tabPage2.Controls.Add(this.pbxImagem);
            this.tabPage2.Controls.Add(this.tbxDestino);
            this.tabPage2.Controls.Add(this.tbxOrigem);
            this.tabPage2.Controls.Add(this.tbxValor);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnCod);
            this.tabPage2.Controls.Add(this.tbxCod);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(757, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisar por código";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(397, 301);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 22;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(248, 301);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 21;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnImagem
            // 
            this.btnImagem.Location = new System.Drawing.Point(607, 201);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(100, 23);
            this.btnImagem.TabIndex = 20;
            this.btnImagem.Text = "Buscar Imagem";
            this.btnImagem.UseVisualStyleBackColor = true;
            // 
            // pbxImagem
            // 
            this.pbxImagem.BackColor = System.Drawing.Color.Gray;
            this.pbxImagem.Location = new System.Drawing.Point(607, 91);
            this.pbxImagem.Name = "pbxImagem";
            this.pbxImagem.Size = new System.Drawing.Size(100, 104);
            this.pbxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagem.TabIndex = 19;
            this.pbxImagem.TabStop = false;
            // 
            // tbxDestino
            // 
            this.tbxDestino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxDestino.Location = new System.Drawing.Point(89, 164);
            this.tbxDestino.Name = "tbxDestino";
            this.tbxDestino.Size = new System.Drawing.Size(234, 29);
            this.tbxDestino.TabIndex = 18;
            // 
            // tbxOrigem
            // 
            this.tbxOrigem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxOrigem.Location = new System.Drawing.Point(89, 129);
            this.tbxOrigem.Name = "tbxOrigem";
            this.tbxOrigem.Size = new System.Drawing.Size(234, 29);
            this.tbxOrigem.TabIndex = 17;
            // 
            // tbxValor
            // 
            this.tbxValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxValor.Location = new System.Drawing.Point(89, 91);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(125, 29);
            this.tbxValor.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(17, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Destino:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(17, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Origem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(34, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Valor:";
            // 
            // btnCod
            // 
            this.btnCod.Location = new System.Drawing.Point(520, 36);
            this.btnCod.Name = "btnCod";
            this.btnCod.Size = new System.Drawing.Size(57, 23);
            this.btnCod.TabIndex = 5;
            this.btnCod.Text = "Buscar";
            this.btnCod.UseVisualStyleBackColor = true;
            this.btnCod.Click += new System.EventHandler(this.btnCod_Click);
            // 
            // tbxCod
            // 
            this.tbxCod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxCod.Location = new System.Drawing.Point(194, 32);
            this.tbxCod.Name = "tbxCod";
            this.tbxCod.Size = new System.Drawing.Size(320, 29);
            this.tbxCod.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Digite o nome do código:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(49, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ida:";
            // 
            // dtpIda
            // 
            this.dtpIda.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpIda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpIda.Location = new System.Drawing.Point(89, 203);
            this.dtpIda.Name = "dtpIda";
            this.dtpIda.Size = new System.Drawing.Size(200, 29);
            this.dtpIda.TabIndex = 24;
            // 
            // dtpVolta
            // 
            this.dtpVolta.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpVolta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpVolta.Location = new System.Drawing.Point(89, 238);
            this.dtpVolta.Name = "dtpVolta";
            this.dtpVolta.Size = new System.Drawing.Size(200, 29);
            this.dtpVolta.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(35, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 21);
            this.label8.TabIndex = 25;
            this.label8.Text = "Volta:";
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.Location = new System.Drawing.Point(366, 91);
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.Size = new System.Drawing.Size(211, 176);
            this.rtbDescricao.TabIndex = 27;
            this.rtbDescricao.Text = "";
            // 
            // TelaPesquisarPacotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "TelaPesquisarPacotes";
            this.Text = "TelaPesquisarPacotes";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foto;
        private System.Windows.Forms.Button btnNome;
        private System.Windows.Forms.TextBox tbxNomeCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnImagem;
        private System.Windows.Forms.PictureBox pbxImagem;
        private System.Windows.Forms.TextBox tbxDestino;
        private System.Windows.Forms.TextBox tbxOrigem;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCod;
        private System.Windows.Forms.TextBox tbxCod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpIda;
        private System.Windows.Forms.DateTimePicker dtpVolta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtbDescricao;
    }
}