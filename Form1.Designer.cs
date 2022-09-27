
namespace WebBrowser
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
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.btnAlto = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnIr = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.wbNavegar = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(38, 27);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(29, 23);
            this.btnAtras.TabIndex = 0;
            this.btnAtras.Text = "<-";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(73, 27);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(29, 23);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.Text = "->";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(108, 27);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(30, 25);
            this.btnRecargar.TabIndex = 2;
            this.btnRecargar.Text = "R";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // btnAlto
            // 
            this.btnAlto.Location = new System.Drawing.Point(144, 27);
            this.btnAlto.Name = "btnAlto";
            this.btnAlto.Size = new System.Drawing.Size(30, 25);
            this.btnAlto.TabIndex = 3;
            this.btnAlto.Text = "S";
            this.btnAlto.UseVisualStyleBackColor = true;
            this.btnAlto.Click += new System.EventHandler(this.btnAlto_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(180, 27);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(30, 25);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "H";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnIr
            // 
            this.btnIr.Location = new System.Drawing.Point(733, 27);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(30, 25);
            this.btnIr.TabIndex = 5;
            this.btnIr.Text = "IR";
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(217, 29);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(510, 20);
            this.txtURL.TabIndex = 6;
            // 
            // wbNavegar
            // 
            this.wbNavegar.Location = new System.Drawing.Point(2, 57);
            this.wbNavegar.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbNavegar.Name = "wbNavegar";
            this.wbNavegar.Size = new System.Drawing.Size(957, 560);
            this.wbNavegar.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 617);
            this.Controls.Add(this.wbNavegar);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAlto);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAtras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btnAlto;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.WebBrowser wbNavegar;
    }
}

