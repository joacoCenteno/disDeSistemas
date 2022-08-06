namespace Ejercicio_5
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblUno = new System.Windows.Forms.Label();
            this.lblDos = new System.Windows.Forms.Label();
            this.lblTres = new System.Windows.Forms.Label();
            this.lblCuatro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = " Mostrar impares (1-100)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUno
            // 
            this.lblUno.AutoSize = true;
            this.lblUno.Location = new System.Drawing.Point(14, 61);
            this.lblUno.Name = "lblUno";
            this.lblUno.Size = new System.Drawing.Size(0, 11);
            this.lblUno.TabIndex = 1;
            // 
            // lblDos
            // 
            this.lblDos.AutoSize = true;
            this.lblDos.Location = new System.Drawing.Point(13, 94);
            this.lblDos.Name = "lblDos";
            this.lblDos.Size = new System.Drawing.Size(0, 11);
            this.lblDos.TabIndex = 2;
            // 
            // lblTres
            // 
            this.lblTres.AutoSize = true;
            this.lblTres.Location = new System.Drawing.Point(13, 123);
            this.lblTres.Name = "lblTres";
            this.lblTres.Size = new System.Drawing.Size(0, 11);
            this.lblTres.TabIndex = 3;
            // 
            // lblCuatro
            // 
            this.lblCuatro.AutoSize = true;
            this.lblCuatro.Location = new System.Drawing.Point(13, 152);
            this.lblCuatro.Name = "lblCuatro";
            this.lblCuatro.Size = new System.Drawing.Size(0, 11);
            this.lblCuatro.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 222);
            this.Controls.Add(this.lblCuatro);
            this.Controls.Add(this.lblTres);
            this.Controls.Add(this.lblDos);
            this.Controls.Add(this.lblUno);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblUno;
        private System.Windows.Forms.Label lblDos;
        private System.Windows.Forms.Label lblTres;
        private System.Windows.Forms.Label lblCuatro;
    }
}

