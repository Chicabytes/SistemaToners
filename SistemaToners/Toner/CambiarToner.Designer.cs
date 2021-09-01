
namespace SistemaToners
{
    partial class CambiarToner
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
            this.label1 = new System.Windows.Forms.Label();
            this.LabelArea = new System.Windows.Forms.Label();
            this.LabelImpresora = new System.Windows.Forms.Label();
            this.Contador = new System.Windows.Forms.Label();
            this.TBContador = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.Label();
            this.TBaja = new System.Windows.Forms.Label();
            this.BoxBaja = new System.Windows.Forms.ComboBox();
            this.TAlta = new System.Windows.Forms.Label();
            this.BoxAlta = new System.Windows.Forms.ComboBox();
            this.BotonGuardar = new System.Windows.Forms.Button();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.fechaCambio = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Se cambiara el toner de la impresora";
            // 
            // LabelArea
            // 
            this.LabelArea.AutoSize = true;
            this.LabelArea.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelArea.Location = new System.Drawing.Point(12, 35);
            this.LabelArea.Name = "LabelArea";
            this.LabelArea.Size = new System.Drawing.Size(34, 15);
            this.LabelArea.TabIndex = 1;
            this.LabelArea.Text = "Area:";
            // 
            // LabelImpresora
            // 
            this.LabelImpresora.AutoSize = true;
            this.LabelImpresora.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelImpresora.Location = new System.Drawing.Point(12, 63);
            this.LabelImpresora.Name = "LabelImpresora";
            this.LabelImpresora.Size = new System.Drawing.Size(67, 15);
            this.LabelImpresora.TabIndex = 2;
            this.LabelImpresora.Text = "Impresora: ";
            // 
            // Contador
            // 
            this.Contador.AutoSize = true;
            this.Contador.Location = new System.Drawing.Point(12, 93);
            this.Contador.Name = "Contador";
            this.Contador.Size = new System.Drawing.Size(57, 15);
            this.Contador.TabIndex = 3;
            this.Contador.Text = "Contador";
            // 
            // TBContador
            // 
            this.TBContador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBContador.Location = new System.Drawing.Point(75, 90);
            this.TBContador.Name = "TBContador";
            this.TBContador.Size = new System.Drawing.Size(100, 23);
            this.TBContador.TabIndex = 4;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(12, 125);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(97, 15);
            this.Fecha.TabIndex = 5;
            this.Fecha.Text = "Fecha de cambio";
            // 
            // TBaja
            // 
            this.TBaja.AutoSize = true;
            this.TBaja.Location = new System.Drawing.Point(12, 151);
            this.TBaja.Name = "TBaja";
            this.TBaja.Size = new System.Drawing.Size(64, 15);
            this.TBaja.TabIndex = 7;
            this.TBaja.Text = "Toner Baja:";
            // 
            // BoxBaja
            // 
            this.BoxBaja.FormattingEnabled = true;
            this.BoxBaja.Location = new System.Drawing.Point(82, 148);
            this.BoxBaja.Name = "BoxBaja";
            this.BoxBaja.Size = new System.Drawing.Size(121, 23);
            this.BoxBaja.TabIndex = 8;
            // 
            // TAlta
            // 
            this.TAlta.AutoSize = true;
            this.TAlta.Location = new System.Drawing.Point(13, 180);
            this.TAlta.Name = "TAlta";
            this.TAlta.Size = new System.Drawing.Size(63, 15);
            this.TAlta.TabIndex = 9;
            this.TAlta.Text = "Toner Alta:";
            // 
            // BoxAlta
            // 
            this.BoxAlta.FormattingEnabled = true;
            this.BoxAlta.Location = new System.Drawing.Point(82, 177);
            this.BoxAlta.Name = "BoxAlta";
            this.BoxAlta.Size = new System.Drawing.Size(121, 23);
            this.BoxAlta.TabIndex = 10;
            // 
            // BotonGuardar
            // 
            this.BotonGuardar.Location = new System.Drawing.Point(12, 223);
            this.BotonGuardar.Name = "BotonGuardar";
            this.BotonGuardar.Size = new System.Drawing.Size(75, 23);
            this.BotonGuardar.TabIndex = 11;
            this.BotonGuardar.Text = "Guardar";
            this.BotonGuardar.UseVisualStyleBackColor = true;
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(100, 223);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(75, 23);
            this.BotonCancelar.TabIndex = 12;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            // 
            // fechaCambio
            // 
            this.fechaCambio.CustomFormat = "";
            this.fechaCambio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaCambio.Location = new System.Drawing.Point(115, 119);
            this.fechaCambio.Name = "fechaCambio";
            this.fechaCambio.Size = new System.Drawing.Size(156, 23);
            this.fechaCambio.TabIndex = 6;
            // 
            // CambiarToner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 256);
            this.Controls.Add(this.fechaCambio);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonGuardar);
            this.Controls.Add(this.BoxAlta);
            this.Controls.Add(this.TAlta);
            this.Controls.Add(this.BoxBaja);
            this.Controls.Add(this.TBaja);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.TBContador);
            this.Controls.Add(this.Contador);
            this.Controls.Add(this.LabelImpresora);
            this.Controls.Add(this.LabelArea);
            this.Controls.Add(this.label1);
            this.Name = "CambiarToner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Toner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelArea;
        private System.Windows.Forms.Label LabelImpresora;
        private System.Windows.Forms.Label Contador;
        private System.Windows.Forms.TextBox TBContador;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label TBaja;
        private System.Windows.Forms.ComboBox BoxBaja;
        private System.Windows.Forms.Label TAlta;
        private System.Windows.Forms.ComboBox BoxAlta;
        private System.Windows.Forms.Button BotonGuardar;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.DateTimePicker fechaCambio;
    }
}