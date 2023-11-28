using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej3_editor_expresion_regular
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbSalida.Clear();

            string texto = tbEntrada.Text;
            string patron = tbExpresionRegular.Text;

            try
            {
                if (rbMath.Checked == true)
                {

                    Match m = Regex.Match(texto, patron);
                    if (rbMatches.Checked == true)
                    {
                        if (m.Success == false)
                        {
                            tbSalida.Text = "no hay coincidencia para: " + texto;
                        }

                        while (m.Success)
                        {
                            tbSalida.Text += $"{m.ToString(),20}:{m.Index,10}\n";
                            m = m.NextMatch();
                        }
                    }
                    if (rbGroups.Checked == true)
                    {
                        if (m.Success == false)
                        {
                            tbSalida.Text = "no hay grupos";
                        }

                        while (m.Success)
                        {
                            for (int n = 1; n < m.Groups.Count; n++)
                            {
                                tbSalida.Text += m.Groups[n].Value + " ; ";
                            }
                            tbSalida.Text += "\r\n";
                            m = m.NextMatch();
                        }
                    }
                }
                else if (rbSplit.Checked == true)
                {

                    string[] lista = Regex.Split(texto, patron);
                    foreach (string campo in lista)
                    {
                        tbSalida.Text += campo + "\r\n";
                    }
                }
            }
            catch (Exception ex)
            {
                tbSalida.Text = $"error:{ex.Message}|{ex.StackTrace}";
            }
        }

        private void rbMath_CheckedChanged(object sender, EventArgs e)
        {
            gbMath.Enabled = rbMath.Checked;
        }
    }
}
