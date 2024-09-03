namespace Projeto3Camadas
{
    partial class FrmCadCliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtID = new TextBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            gridView = new DataGridView();
            btnInserir = new Button();
            btnExcluir = new Button();
            btnAlterar = new Button();
            label4 = new Label();
            label5 = new Label();
            txtTelefone = new TextBox();
            txtEndereco = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtFormaPagamento = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 13F);
            txtID.Location = new Point(146, 58);
            txtID.Name = "txtID";
            txtID.Size = new Size(139, 31);
            txtID.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 13F);
            txtNome.Location = new Point(146, 111);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(570, 31);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 13F);
            txtEmail.Location = new Point(146, 222);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(570, 31);
            txtEmail.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(23, 57);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 3;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(23, 111);
            label2.Name = "label2";
            label2.Size = new Size(85, 32);
            label2.TabIndex = 4;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(23, 222);
            label3.Name = "label3";
            label3.Size = new Size(91, 32);
            label3.TabIndex = 5;
            label3.Text = "E-mail:";
            // 
            // gridView
            // 
            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = false;
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView.Location = new Point(23, 341);
            gridView.Name = "gridView";
            gridView.ReadOnly = true;
            gridView.Size = new Size(535, 177);
            gridView.TabIndex = 7;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.Lime;
            btnInserir.Font = new Font("Segoe UI", 14F);
            btnInserir.ForeColor = SystemColors.ControlLightLight;
            btnInserir.Location = new Point(572, 341);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(144, 55);
            btnInserir.TabIndex = 9;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += BtnInserir_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.Font = new Font("Segoe UI", 14F);
            btnExcluir.ForeColor = SystemColors.ControlLightLight;
            btnExcluir.Location = new Point(573, 463);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(146, 55);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Segoe UI", 14F);
            btnAlterar.Location = new Point(572, 402);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(147, 55);
            btnAlterar.TabIndex = 11;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(155, 9);
            label4.Name = "label4";
            label4.Size = new Size(403, 32);
            label4.TabIndex = 12;
            label4.Text = "Brasil Distribuidora Açaizinho";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Yellow;
            label5.Location = new Point(317, 57);
            label5.Name = "label5";
            label5.Size = new Size(111, 32);
            label5.TabIndex = 13;
            label5.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 13F);
            txtTelefone.Location = new Point(434, 58);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(282, 31);
            txtTelefone.TabIndex = 14;
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Segoe UI", 13F);
            txtEndereco.Location = new Point(146, 171);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(570, 31);
            txtEndereco.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Yellow;
            label6.Location = new Point(23, 171);
            label6.Name = "label6";
            label6.Size = new Size(117, 32);
            label6.TabIndex = 16;
            label6.Text = "Endereço:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Yellow;
            label7.Location = new Point(23, 270);
            label7.Name = "label7";
            label7.Size = new Size(247, 32);
            label7.TabIndex = 18;
            label7.Text = "Forma de Pagamento";
            // 
            // txtFormaPagamento
            // 
            txtFormaPagamento.Font = new Font("Segoe UI", 13F);
            txtFormaPagamento.Location = new Point(276, 275);
            txtFormaPagamento.Name = "txtFormaPagamento";
            txtFormaPagamento.Size = new Size(440, 31);
            txtFormaPagamento.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(749, 335);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // FrmCadCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Fuchsia;
            ClientSize = new Size(752, 530);
            Controls.Add(txtFormaPagamento);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtEndereco);
            Controls.Add(txtTelefone);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnAlterar);
            Controls.Add(btnExcluir);
            Controls.Add(btnInserir);
            Controls.Add(gridView);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Controls.Add(pictureBox1);
            Name = "FrmCadCliente";
            Text = "Projeto 3 Camadas";
            Load += FrmCadCliente_Load;
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView gridView;
        private Button btnInserir;
        private Button btnExcluir;
        private Button btnAlterar;
        private Label label4;
        private Label label5;
        private TextBox txtTelefone;
        private TextBox txtEndereco;
        private Label label6;
        private Label label7;
        private TextBox txtFormaPagamento;
        private PictureBox pictureBox1;
    }
}
