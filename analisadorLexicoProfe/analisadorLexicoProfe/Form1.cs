using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace analisadorLexicoProfe
{
    public partial class Form1 : Form
    {
        Lexico Analiza_lexico = new Lexico();
        public Form1()
        {
            InitializeComponent();
        }

        private void AnalisisLexico_Click(object sender, EventArgs e)
        {
            Analiza_lexico.Inicia();
            Analiza_lexico.Analiza(txtformula.Text);
            TOKEN_LEXEMA.Rows.Clear();

            if (Analiza_lexico.NoTokens > 0)
                TOKEN_LEXEMA.Rows.Add(Analiza_lexico.NoTokens);

            for(int i = 0; i < Analiza_lexico.NoTokens; i++)
            {
                TOKEN_LEXEMA.Rows[i].Cells[0].Value = Analiza_lexico.Token[i];
                TOKEN_LEXEMA.Rows[i].Cells[1].Value = Analiza_lexico.Lexema[i];
            }
        }

        private void LimpiarTabla_Click(object sender, EventArgs e)
        {
            TOKEN_LEXEMA.Rows.Clear();
            txtformula.Text = "";
            txtformula.Focus(); 
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TOKEN_LEXEMA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}