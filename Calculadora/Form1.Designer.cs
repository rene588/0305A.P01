namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gradoscent = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.resultado2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resu1 = new System.Windows.Forms.TextBox();
            this.resu2 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.res2 = new System.Windows.Forms.TextBox();
            this.num3 = new System.Windows.Forms.TextBox();
            this.res1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "grados centigrados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "grados fahrenheit";
            // 
            // gradoscent
            // 
            this.gradoscent.Location = new System.Drawing.Point(168, 31);
            this.gradoscent.Name = "gradoscent";
            this.gradoscent.Size = new System.Drawing.Size(63, 20);
            this.gradoscent.TabIndex = 2;
            this.gradoscent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gradoscent.TextChanged += new System.EventHandler(this.gradoscent_TextChanged);
            // 
            // resultado
            // 
            this.resultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.resultado.ForeColor = System.Drawing.Color.Blue;
            this.resultado.Location = new System.Drawing.Point(168, 57);
            this.resultado.Name = "resultado";
            this.resultado.ReadOnly = true;
            this.resultado.Size = new System.Drawing.Size(63, 20);
            this.resultado.TabIndex = 3;
            this.resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "convertir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultado2
            // 
            this.resultado2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.resultado2.ForeColor = System.Drawing.Color.Blue;
            this.resultado2.Location = new System.Drawing.Point(168, 83);
            this.resultado2.Name = "resultado2";
            this.resultado2.ReadOnly = true;
            this.resultado2.Size = new System.Drawing.Size(63, 20);
            this.resultado2.TabIndex = 5;
            this.resultado2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "grados kelvin";
            // 
            // resu1
            // 
            this.resu1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.resu1.ForeColor = System.Drawing.Color.Blue;
            this.resu1.Location = new System.Drawing.Point(237, 31);
            this.resu1.Name = "resu1";
            this.resu1.ReadOnly = true;
            this.resu1.Size = new System.Drawing.Size(74, 20);
            this.resu1.TabIndex = 7;
            this.resu1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resu2
            // 
            this.resu2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.resu2.ForeColor = System.Drawing.Color.Blue;
            this.resu2.Location = new System.Drawing.Point(237, 82);
            this.resu2.Name = "resu2";
            this.resu2.ReadOnly = true;
            this.resu2.Size = new System.Drawing.Size(74, 20);
            this.resu2.TabIndex = 8;
            this.resu2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(237, 57);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(74, 20);
            this.num2.TabIndex = 9;
            this.num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // res2
            // 
            this.res2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.res2.ForeColor = System.Drawing.Color.Blue;
            this.res2.Location = new System.Drawing.Point(317, 58);
            this.res2.Name = "res2";
            this.res2.ReadOnly = true;
            this.res2.Size = new System.Drawing.Size(74, 20);
            this.res2.TabIndex = 12;
            this.res2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(317, 83);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(74, 20);
            this.num3.TabIndex = 11;
            this.num3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // res1
            // 
            this.res1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.res1.ForeColor = System.Drawing.Color.Blue;
            this.res1.Location = new System.Drawing.Point(317, 32);
            this.res1.Name = "res1";
            this.res1.ReadOnly = true;
            this.res1.Size = new System.Drawing.Size(74, 20);
            this.res1.TabIndex = 10;
            this.res1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 172);
            this.Controls.Add(this.res2);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.res1);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.resu2);
            this.Controls.Add(this.resu1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultado2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.gradoscent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gradoscent;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox resultado2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resu1;
        private System.Windows.Forms.TextBox resu2;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox res2;
        private System.Windows.Forms.TextBox num3;
        private System.Windows.Forms.TextBox res1;
    }
}

