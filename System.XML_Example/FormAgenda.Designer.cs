namespace System.XML_Example
{
    partial class FormAgenda
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFoneResidencial = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.pnlIncluir = new System.Windows.Forms.Panel();
            this.pnlAlterar = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFoneComercial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFoneCelular = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRemoverFiltro = new System.Windows.Forms.Button();
            this.pnlIncluir.SuspendLayout();
            this.pnlAlterar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fone Residencial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome";
            // 
            // txtFoneResidencial
            // 
            this.txtFoneResidencial.Location = new System.Drawing.Point(12, 81);
            this.txtFoneResidencial.Name = "txtFoneResidencial";
            this.txtFoneResidencial.Size = new System.Drawing.Size(107, 20);
            this.txtFoneResidencial.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(107, 20);
            this.txtNome.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(3, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Incluir";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(323, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(420, 238);
            this.listBox1.TabIndex = 11;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(667, 259);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(584, 259);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 13;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // pnlIncluir
            // 
            this.pnlIncluir.Controls.Add(this.btnSalvar);
            this.pnlIncluir.Location = new System.Drawing.Point(12, 227);
            this.pnlIncluir.Name = "pnlIncluir";
            this.pnlIncluir.Size = new System.Drawing.Size(99, 32);
            this.pnlIncluir.TabIndex = 14;
            // 
            // pnlAlterar
            // 
            this.pnlAlterar.Controls.Add(this.btnCancelar);
            this.pnlAlterar.Controls.Add(this.btnAlterar);
            this.pnlAlterar.Location = new System.Drawing.Point(12, 226);
            this.pnlAlterar.Name = "pnlAlterar";
            this.pnlAlterar.Size = new System.Drawing.Size(166, 32);
            this.pnlAlterar.TabIndex = 15;
            this.pnlAlterar.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(81, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(0, 3);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(145, 31);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Observações";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(12, 199);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(271, 20);
            this.txtObs.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fone Comercial";
            // 
            // txtFoneComercial
            // 
            this.txtFoneComercial.Location = new System.Drawing.Point(12, 120);
            this.txtFoneComercial.Name = "txtFoneComercial";
            this.txtFoneComercial.Size = new System.Drawing.Size(107, 20);
            this.txtFoneComercial.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Celular";
            // 
            // txtFoneCelular
            // 
            this.txtFoneCelular.Location = new System.Drawing.Point(12, 159);
            this.txtFoneCelular.Name = "txtFoneCelular";
            this.txtFoneCelular.Size = new System.Drawing.Size(107, 20);
            this.txtFoneCelular.TabIndex = 21;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(208, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRemoverFiltro
            // 
            this.btnRemoverFiltro.Location = new System.Drawing.Point(466, 258);
            this.btnRemoverFiltro.Name = "btnRemoverFiltro";
            this.btnRemoverFiltro.Size = new System.Drawing.Size(112, 23);
            this.btnRemoverFiltro.TabIndex = 24;
            this.btnRemoverFiltro.Text = "Remover Filtro";
            this.btnRemoverFiltro.UseVisualStyleBackColor = true;
            this.btnRemoverFiltro.Visible = false;
            this.btnRemoverFiltro.Click += new System.EventHandler(this.btnRemoverFiltro_Click);
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 304);
            this.Controls.Add(this.btnRemoverFiltro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFoneCelular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFoneComercial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.pnlAlterar);
            this.Controls.Add(this.pnlIncluir);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFoneResidencial);
            this.Controls.Add(this.txtNome);
            this.Name = "FormAgenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.FormAgenda_Load);
            this.pnlIncluir.ResumeLayout(false);
            this.pnlAlterar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.Label label2;
        private Windows.Forms.Label label1;
        private Windows.Forms.TextBox txtFoneResidencial;
        private Windows.Forms.TextBox txtNome;
        private Windows.Forms.Button btnSalvar;
        private Windows.Forms.ListBox listBox1;
        private Windows.Forms.Button btnDelete;
        private Windows.Forms.Button btnSelecionar;
        private Windows.Forms.Panel pnlIncluir;
        private Windows.Forms.Panel pnlAlterar;
        private Windows.Forms.Button btnCancelar;
        private Windows.Forms.Button btnAlterar;
        private Windows.Forms.Label lblId;
        private Windows.Forms.Label label3;
        private Windows.Forms.TextBox txtObs;
        private Windows.Forms.Label label4;
        private Windows.Forms.TextBox txtFoneComercial;
        private Windows.Forms.Label label5;
        private Windows.Forms.TextBox txtFoneCelular;
        private Windows.Forms.Button btnBuscar;
        private Windows.Forms.Button btnRemoverFiltro;
    }
}