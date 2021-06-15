
namespace analisadorLexicoProfe
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TOKEN_LEXEMA = new System.Windows.Forms.DataGridView();
            this.txtformula = new System.Windows.Forms.RichTextBox();
            this.AnalisisLexico = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.LimpiarTabla = new System.Windows.Forms.Button();
            this.TOKEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LEXEMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TOKEN_LEXEMA)).BeginInit();
            this.SuspendLayout();
            // 
            // TOKEN_LEXEMA
            // 
            this.TOKEN_LEXEMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TOKEN_LEXEMA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TOKEN,
            this.LEXEMA});
            this.TOKEN_LEXEMA.Location = new System.Drawing.Point(423, 12);
            this.TOKEN_LEXEMA.Name = "TOKEN_LEXEMA";
            this.TOKEN_LEXEMA.Size = new System.Drawing.Size(336, 345);
            this.TOKEN_LEXEMA.TabIndex = 0;
            this.TOKEN_LEXEMA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TOKEN_LEXEMA_CellContentClick);
            // 
            // txtformula
            // 
            this.txtformula.Location = new System.Drawing.Point(25, 12);
            this.txtformula.Name = "txtformula";
            this.txtformula.Size = new System.Drawing.Size(366, 345);
            this.txtformula.TabIndex = 1;
            this.txtformula.Text = "";
            // 
            // AnalisisLexico
            // 
            this.AnalisisLexico.Location = new System.Drawing.Point(43, 389);
            this.AnalisisLexico.Name = "AnalisisLexico";
            this.AnalisisLexico.Size = new System.Drawing.Size(133, 23);
            this.AnalisisLexico.TabIndex = 2;
            this.AnalisisLexico.Text = "Analisis Lexico";
            this.AnalisisLexico.UseVisualStyleBackColor = true;
            this.AnalisisLexico.Click += new System.EventHandler(this.AnalisisLexico_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(371, 389);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 3;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // LimpiarTabla
            // 
            this.LimpiarTabla.Location = new System.Drawing.Point(654, 389);
            this.LimpiarTabla.Name = "LimpiarTabla";
            this.LimpiarTabla.Size = new System.Drawing.Size(105, 23);
            this.LimpiarTabla.TabIndex = 4;
            this.LimpiarTabla.Text = "Limpiar Tabla";
            this.LimpiarTabla.UseVisualStyleBackColor = true;
            this.LimpiarTabla.Click += new System.EventHandler(this.LimpiarTabla_Click);
            // 
            // TOKEN
            // 
            this.TOKEN.HeaderText = "TOKEN";
            this.TOKEN.Name = "TOKEN";
            this.TOKEN.ReadOnly = true;
            // 
            // LEXEMA
            // 
            this.LEXEMA.HeaderText = "LEXEMA";
            this.LEXEMA.Name = "LEXEMA";
            this.LEXEMA.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LimpiarTabla);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.AnalisisLexico);
            this.Controls.Add(this.txtformula);
            this.Controls.Add(this.TOKEN_LEXEMA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TOKEN_LEXEMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TOKEN_LEXEMA;
        private System.Windows.Forms.RichTextBox txtformula;
        private System.Windows.Forms.Button AnalisisLexico;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button LimpiarTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOKEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn LEXEMA;
    }
}

