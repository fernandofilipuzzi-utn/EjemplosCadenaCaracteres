
namespace Ej3_editor_expresion_regular
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.tbEntrada = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbExpresionRegular = new System.Windows.Forms.TextBox();
            this.tbSalida = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbMath = new System.Windows.Forms.GroupBox();
            this.rbGroups = new System.Windows.Forms.RadioButton();
            this.rbMatches = new System.Windows.Forms.RadioButton();
            this.rbSplit = new System.Windows.Forms.RadioButton();
            this.rbMath = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.gbMath.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbEntrada
            // 
            this.tbEntrada.Location = new System.Drawing.Point(20, 22);
            this.tbEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.tbEntrada.Multiline = true;
            this.tbEntrada.Name = "tbEntrada";
            this.tbEntrada.Size = new System.Drawing.Size(825, 127);
            this.tbEntrada.TabIndex = 0;
            this.tbEntrada.Text = "grant_type=password&username=2|1542303961040|examen01&password=password1&client_i" +
    "d=pg0HZdZvOfTJDKgf6YJUnwmA0Ioa";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbExpresionRegular
            // 
            this.tbExpresionRegular.Location = new System.Drawing.Point(20, 192);
            this.tbExpresionRegular.Margin = new System.Windows.Forms.Padding(4);
            this.tbExpresionRegular.Multiline = true;
            this.tbExpresionRegular.Name = "tbExpresionRegular";
            this.tbExpresionRegular.Size = new System.Drawing.Size(829, 152);
            this.tbExpresionRegular.TabIndex = 2;
            this.tbExpresionRegular.Text = "(?:\\b|&)(\\w+)=([^&]+)";
            // 
            // tbSalida
            // 
            this.tbSalida.Location = new System.Drawing.Point(16, 382);
            this.tbSalida.Margin = new System.Windows.Forms.Padding(4);
            this.tbSalida.Multiline = true;
            this.tbSalida.Name = "tbSalida";
            this.tbSalida.ReadOnly = true;
            this.tbSalida.Size = new System.Drawing.Size(829, 136);
            this.tbSalida.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(867, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Actualizar salida";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cadena de entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Expresión regular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 362);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Salida";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbMath);
            this.groupBox1.Controls.Add(this.rbSplit);
            this.groupBox1.Controls.Add(this.rbMath);
            this.groupBox1.Location = new System.Drawing.Point(867, 120);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(198, 199);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // gbMath
            // 
            this.gbMath.Controls.Add(this.rbGroups);
            this.gbMath.Controls.Add(this.rbMatches);
            this.gbMath.Location = new System.Drawing.Point(52, 71);
            this.gbMath.Margin = new System.Windows.Forms.Padding(4);
            this.gbMath.Name = "gbMath";
            this.gbMath.Padding = new System.Windows.Forms.Padding(4);
            this.gbMath.Size = new System.Drawing.Size(138, 84);
            this.gbMath.TabIndex = 9;
            this.gbMath.TabStop = false;
            // 
            // rbGroups
            // 
            this.rbGroups.AutoSize = true;
            this.rbGroups.Location = new System.Drawing.Point(8, 53);
            this.rbGroups.Margin = new System.Windows.Forms.Padding(4);
            this.rbGroups.Name = "rbGroups";
            this.rbGroups.Size = new System.Drawing.Size(122, 21);
            this.rbGroups.TabIndex = 1;
            this.rbGroups.Text = "Mostrar grupos";
            this.rbGroups.UseVisualStyleBackColor = true;
            // 
            // rbMatches
            // 
            this.rbMatches.AutoSize = true;
            this.rbMatches.Checked = true;
            this.rbMatches.Location = new System.Drawing.Point(8, 24);
            this.rbMatches.Margin = new System.Windows.Forms.Padding(4);
            this.rbMatches.Name = "rbMatches";
            this.rbMatches.Size = new System.Drawing.Size(57, 21);
            this.rbMatches.TabIndex = 0;
            this.rbMatches.TabStop = true;
            this.rbMatches.Text = "Math";
            this.rbMatches.UseVisualStyleBackColor = true;
            // 
            // rbSplit
            // 
            this.rbSplit.AutoSize = true;
            this.rbSplit.Location = new System.Drawing.Point(8, 163);
            this.rbSplit.Margin = new System.Windows.Forms.Padding(4);
            this.rbSplit.Name = "rbSplit";
            this.rbSplit.Size = new System.Drawing.Size(53, 21);
            this.rbSplit.TabIndex = 1;
            this.rbSplit.Text = "Split";
            this.rbSplit.UseVisualStyleBackColor = true;
            // 
            // rbMath
            // 
            this.rbMath.AutoSize = true;
            this.rbMath.Checked = true;
            this.rbMath.Location = new System.Drawing.Point(8, 47);
            this.rbMath.Margin = new System.Windows.Forms.Padding(4);
            this.rbMath.Name = "rbMath";
            this.rbMath.Size = new System.Drawing.Size(57, 21);
            this.rbMath.TabIndex = 0;
            this.rbMath.TabStop = true;
            this.rbMath.Text = "Math";
            this.rbMath.UseVisualStyleBackColor = true;
            this.rbMath.CheckedChanged += new System.EventHandler(this.rbMath_CheckedChanged);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 533);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbSalida);
            this.Controls.Add(this.tbExpresionRegular);
            this.Controls.Add(this.tbEntrada);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.Text = "Editor de Expressiones regulares";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbMath.ResumeLayout(false);
            this.gbMath.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEntrada;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbExpresionRegular;
        private System.Windows.Forms.TextBox tbSalida;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSplit;
        private System.Windows.Forms.RadioButton rbMath;
        private System.Windows.Forms.GroupBox gbMath;
        private System.Windows.Forms.RadioButton rbGroups;
        private System.Windows.Forms.RadioButton rbMatches;
    }
}

