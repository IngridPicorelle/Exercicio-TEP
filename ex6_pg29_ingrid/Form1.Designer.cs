namespace ex6_pg29_gustavo_20
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
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_Horas = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_horas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(12, 9);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(43, 13);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Codigo:";
            this.lbl_codigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Horas
            // 
            this.lbl_Horas.AutoSize = true;
            this.lbl_Horas.Location = new System.Drawing.Point(12, 61);
            this.lbl_Horas.Name = "lbl_Horas";
            this.lbl_Horas.Size = new System.Drawing.Size(100, 13);
            this.lbl_Horas.TabIndex = 1;
            this.lbl_Horas.Text = "Horas Trabalhadas:";
            this.lbl_Horas.Click += new System.EventHandler(this.lbl_Horas_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(28, 118);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 2;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(15, 25);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 3;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            // 
            // txt_horas
            // 
            this.txt_horas.Location = new System.Drawing.Point(15, 77);
            this.txt_horas.Name = "txt_horas";
            this.txt_horas.Size = new System.Drawing.Size(100, 20);
            this.txt_horas.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(135, 151);
            this.Controls.Add(this.txt_horas);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lbl_Horas);
            this.Controls.Add(this.lbl_codigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_Horas;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_horas;
    }
}

