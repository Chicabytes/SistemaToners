
namespace SistemaToners
{
    partial class nuevoToner
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
            this.SelecImpresora = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TonerAnterior = new System.Windows.Forms.Label();
            this.NTonerNum = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Numero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelecImpresora
            // 
            this.SelecImpresora.AutoSize = true;
            this.SelecImpresora.Location = new System.Drawing.Point(12, 9);
            this.SelecImpresora.Name = "SelecImpresora";
            this.SelecImpresora.Size = new System.Drawing.Size(191, 15);
            this.SelecImpresora.TabIndex = 0;
            this.SelecImpresora.Text = "Seleccione el modelo de impresora";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(209, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // TonerAnterior
            // 
            this.TonerAnterior.AutoSize = true;
            this.TonerAnterior.Location = new System.Drawing.Point(12, 37);
            this.TonerAnterior.Name = "TonerAnterior";
            this.TonerAnterior.Size = new System.Drawing.Size(100, 15);
            this.TonerAnterior.TabIndex = 2;
            this.TonerAnterior.Text = "Toner anterior N° ";
            // 
            // NTonerNum
            // 
            this.NTonerNum.AutoSize = true;
            this.NTonerNum.Location = new System.Drawing.Point(12, 65);
            this.NTonerNum.Name = "NTonerNum";
            this.NTonerNum.Size = new System.Drawing.Size(91, 15);
            this.NTonerNum.TabIndex = 3;
            this.NTonerNum.Text = "Nuevo Toner N°";
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(12, 194);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 24);
            this.Guardar.TabIndex = 4;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(93, 195);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 5;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Numero.Location = new System.Drawing.Point(156, 109);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(24, 37);
            this.Numero.TabIndex = 6;
            this.Numero.Text = " ";
            // 
            // nuevoToner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 230);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.NTonerNum);
            this.Controls.Add(this.TonerAnterior);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SelecImpresora);
            this.Name = "nuevoToner";
            this.Text = "Nuevo Toner";
            this.Load += new System.EventHandler(this.r_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelecImpresora;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label TonerAnterior;
        private System.Windows.Forms.Label NTonerNum;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label Numero;
    }
}