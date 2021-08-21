
namespace SistemaToners
{
    partial class Sistoners
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tonerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoTonerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarTonerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tonerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.impresoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaImpresoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarImpresoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaImpresorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LabAreaGest = new System.Windows.Forms.Label();
            this.CombArea = new System.Windows.Forms.ComboBox();
            this.LabGestPuesto = new System.Windows.Forms.Label();
            this.ComboPuesto = new System.Windows.Forms.ComboBox();
            this.LabGestImpre = new System.Windows.Forms.Label();
            this.Gestion = new System.Windows.Forms.Panel();
            this.CambioToner = new System.Windows.Forms.Button();
            this.LabelNumToner = new System.Windows.Forms.Label();
            this.LabelCambio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelModeloToner = new System.Windows.Forms.Label();
            this.CombImpresora = new System.Windows.Forms.ComboBox();
            this.NuevaImpresora = new System.Windows.Forms.Panel();
            this.Cancelar = new System.Windows.Forms.Button();
            this.numIp = new System.Windows.Forms.TextBox();
            this.NiP = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.RadioButton();
            this.USB = new System.Windows.Forms.RadioButton();
            this.observacion = new System.Windows.Forms.TextBox();
            this.CartuchoContinuo = new System.Windows.Forms.RadioButton();
            this.Toner = new System.Windows.Forms.RadioButton();
            this.Guardar = new System.Windows.Forms.Button();
            this.obs = new System.Windows.Forms.Label();
            this.TipoConexion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TTinta = new System.Windows.Forms.Label();
            this.CombMarca = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CombPuesto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            this.Gestion.SuspendLayout();
            this.NuevaImpresora.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.tonerToolStripMenuItem,
            this.impresoraToolStripMenuItem,
            this.areaToolStripMenuItem,
            this.toolStripMenuItem1});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(289, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestionToolStripMenuItem.Text = "Gestion";
            this.gestionToolStripMenuItem.Click += new System.EventHandler(this.gestionToolStripMenuItem_Click);
            // 
            // tonerToolStripMenuItem
            // 
            this.tonerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoTonerToolStripMenuItem,
            this.editarTonerToolStripMenuItem,
            this.tonerToolStripMenuItem1});
            this.tonerToolStripMenuItem.Name = "tonerToolStripMenuItem";
            this.tonerToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.tonerToolStripMenuItem.Text = "Toner";
            // 
            // nuevoTonerToolStripMenuItem
            // 
            this.nuevoTonerToolStripMenuItem.Name = "nuevoTonerToolStripMenuItem";
            this.nuevoTonerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoTonerToolStripMenuItem.Text = "Nuevo toner";
            // 
            // editarTonerToolStripMenuItem
            // 
            this.editarTonerToolStripMenuItem.Name = "editarTonerToolStripMenuItem";
            this.editarTonerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarTonerToolStripMenuItem.Text = "Editar Toner";
            // 
            // tonerToolStripMenuItem1
            // 
            this.tonerToolStripMenuItem1.Name = "tonerToolStripMenuItem1";
            this.tonerToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.tonerToolStripMenuItem1.Text = "Lista Toners";
            this.tonerToolStripMenuItem1.Click += new System.EventHandler(this.tonerToolStripMenuItem1_Click);
            // 
            // impresoraToolStripMenuItem
            // 
            this.impresoraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaImpresoraToolStripMenuItem,
            this.editarImpresoraToolStripMenuItem,
            this.listaImpresorasToolStripMenuItem});
            this.impresoraToolStripMenuItem.Name = "impresoraToolStripMenuItem";
            this.impresoraToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.impresoraToolStripMenuItem.Text = "Impresora";
            // 
            // nuevaImpresoraToolStripMenuItem
            // 
            this.nuevaImpresoraToolStripMenuItem.Name = "nuevaImpresoraToolStripMenuItem";
            this.nuevaImpresoraToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.nuevaImpresoraToolStripMenuItem.Text = "Nueva Impresora";
            this.nuevaImpresoraToolStripMenuItem.Click += new System.EventHandler(this.nuevaImpresoraToolStripMenuItem_Click);
            // 
            // editarImpresoraToolStripMenuItem
            // 
            this.editarImpresoraToolStripMenuItem.Name = "editarImpresoraToolStripMenuItem";
            this.editarImpresoraToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.editarImpresoraToolStripMenuItem.Text = "Editar Impresora";
            // 
            // listaImpresorasToolStripMenuItem
            // 
            this.listaImpresorasToolStripMenuItem.Name = "listaImpresorasToolStripMenuItem";
            this.listaImpresorasToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.listaImpresorasToolStripMenuItem.Text = "Lista Impresoras";
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.areaToolStripMenuItem1,
            this.editarPuestoToolStripMenuItem});
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.areaToolStripMenuItem.Text = "Area";
            // 
            // areaToolStripMenuItem1
            // 
            this.areaToolStripMenuItem1.Name = "areaToolStripMenuItem1";
            this.areaToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.areaToolStripMenuItem1.Text = "Nueva area";
            // 
            // editarPuestoToolStripMenuItem
            // 
            this.editarPuestoToolStripMenuItem.Name = "editarPuestoToolStripMenuItem";
            this.editarPuestoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.editarPuestoToolStripMenuItem.Text = "Editar Puesto";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // LabAreaGest
            // 
            this.LabAreaGest.AutoSize = true;
            this.LabAreaGest.Location = new System.Drawing.Point(3, 14);
            this.LabAreaGest.Name = "LabAreaGest";
            this.LabAreaGest.Size = new System.Drawing.Size(100, 15);
            this.LabAreaGest.TabIndex = 0;
            this.LabAreaGest.Text = "Seleccione el area";
            // 
            // CombArea
            // 
            this.CombArea.FormattingEnabled = true;
            this.CombArea.Location = new System.Drawing.Point(123, 11);
            this.CombArea.Name = "CombArea";
            this.CombArea.Size = new System.Drawing.Size(121, 23);
            this.CombArea.TabIndex = 3;
            // 
            // LabGestPuesto
            // 
            this.LabGestPuesto.AutoSize = true;
            this.LabGestPuesto.Location = new System.Drawing.Point(3, 43);
            this.LabGestPuesto.Name = "LabGestPuesto";
            this.LabGestPuesto.Size = new System.Drawing.Size(114, 15);
            this.LabGestPuesto.TabIndex = 4;
            this.LabGestPuesto.Text = "Seleccione el puesto";
            // 
            // ComboPuesto
            // 
            this.ComboPuesto.FormattingEnabled = true;
            this.ComboPuesto.Location = new System.Drawing.Point(123, 40);
            this.ComboPuesto.Name = "ComboPuesto";
            this.ComboPuesto.Size = new System.Drawing.Size(121, 23);
            this.ComboPuesto.TabIndex = 5;
            // 
            // LabGestImpre
            // 
            this.LabGestImpre.AutoSize = true;
            this.LabGestImpre.Location = new System.Drawing.Point(3, 72);
            this.LabGestImpre.Name = "LabGestImpre";
            this.LabGestImpre.Size = new System.Drawing.Size(96, 15);
            this.LabGestImpre.TabIndex = 6;
            this.LabGestImpre.Text = "Elija la Impresora";
            // 
            // Gestion
            // 
            this.Gestion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Gestion.Controls.Add(this.CambioToner);
            this.Gestion.Controls.Add(this.LabelNumToner);
            this.Gestion.Controls.Add(this.LabelCambio);
            this.Gestion.Controls.Add(this.label1);
            this.Gestion.Controls.Add(this.LabelModeloToner);
            this.Gestion.Controls.Add(this.CombImpresora);
            this.Gestion.Controls.Add(this.LabGestImpre);
            this.Gestion.Controls.Add(this.ComboPuesto);
            this.Gestion.Controls.Add(this.LabGestPuesto);
            this.Gestion.Controls.Add(this.CombArea);
            this.Gestion.Controls.Add(this.LabAreaGest);
            this.Gestion.Location = new System.Drawing.Point(12, 24);
            this.Gestion.Name = "Gestion";
            this.Gestion.Size = new System.Drawing.Size(265, 368);
            this.Gestion.TabIndex = 1;
            // 
            // CambioToner
            // 
            this.CambioToner.Location = new System.Drawing.Point(3, 177);
            this.CambioToner.Name = "CambioToner";
            this.CambioToner.Size = new System.Drawing.Size(109, 23);
            this.CambioToner.TabIndex = 12;
            this.CambioToner.Text = "Cambiar Toner";
            this.CambioToner.UseVisualStyleBackColor = true;
            this.CambioToner.Click += new System.EventHandler(this.CambioToner_Click);
            // 
            // LabelNumToner
            // 
            this.LabelNumToner.AutoSize = true;
            this.LabelNumToner.Location = new System.Drawing.Point(3, 154);
            this.LabelNumToner.Name = "LabelNumToner";
            this.LabelNumToner.Size = new System.Drawing.Size(124, 15);
            this.LabelNumToner.TabIndex = 11;
            this.LabelNumToner.Text = "El toner es el numero: ";
            // 
            // LabelCambio
            // 
            this.LabelCambio.AutoSize = true;
            this.LabelCambio.Location = new System.Drawing.Point(3, 130);
            this.LabelCambio.Name = "LabelCambio";
            this.LabelCambio.Size = new System.Drawing.Size(123, 15);
            this.LabelCambio.TabIndex = 10;
            this.LabelCambio.Text = "El ultimo cambio fue: ";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 119);
            this.label1.MaximumSize = new System.Drawing.Size(0, 2);
            this.label1.MinimumSize = new System.Drawing.Size(0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 2);
            this.label1.TabIndex = 9;
            // 
            // LabelModeloToner
            // 
            this.LabelModeloToner.AutoSize = true;
            this.LabelModeloToner.Location = new System.Drawing.Point(3, 105);
            this.LabelModeloToner.Name = "LabelModeloToner";
            this.LabelModeloToner.Size = new System.Drawing.Size(127, 15);
            this.LabelModeloToner.TabIndex = 8;
            this.LabelModeloToner.Text = "El modelo de toner es: ";
            // 
            // CombImpresora
            // 
            this.CombImpresora.FormattingEnabled = true;
            this.CombImpresora.Location = new System.Drawing.Point(123, 69);
            this.CombImpresora.Name = "CombImpresora";
            this.CombImpresora.Size = new System.Drawing.Size(121, 23);
            this.CombImpresora.TabIndex = 7;
            // 
            // NuevaImpresora
            // 
            this.NuevaImpresora.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NuevaImpresora.Controls.Add(this.Cancelar);
            this.NuevaImpresora.Controls.Add(this.numIp);
            this.NuevaImpresora.Controls.Add(this.NiP);
            this.NuevaImpresora.Controls.Add(this.IP);
            this.NuevaImpresora.Controls.Add(this.USB);
            this.NuevaImpresora.Controls.Add(this.observacion);
            this.NuevaImpresora.Controls.Add(this.CartuchoContinuo);
            this.NuevaImpresora.Controls.Add(this.Toner);
            this.NuevaImpresora.Controls.Add(this.Guardar);
            this.NuevaImpresora.Controls.Add(this.obs);
            this.NuevaImpresora.Controls.Add(this.TipoConexion);
            this.NuevaImpresora.Controls.Add(this.label4);
            this.NuevaImpresora.Controls.Add(this.TTinta);
            this.NuevaImpresora.Controls.Add(this.CombMarca);
            this.NuevaImpresora.Controls.Add(this.label6);
            this.NuevaImpresora.Controls.Add(this.CombPuesto);
            this.NuevaImpresora.Controls.Add(this.label7);
            this.NuevaImpresora.Controls.Add(this.comboBox4);
            this.NuevaImpresora.Controls.Add(this.label8);
            this.NuevaImpresora.Location = new System.Drawing.Point(12, 24);
            this.NuevaImpresora.Name = "NuevaImpresora";
            this.NuevaImpresora.Size = new System.Drawing.Size(265, 368);
            this.NuevaImpresora.TabIndex = 13;
            this.NuevaImpresora.Visible = false;
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(122, 338);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(109, 23);
            this.Cancelar.TabIndex = 20;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // numIp
            // 
            this.numIp.Location = new System.Drawing.Point(123, 293);
            this.numIp.Name = "numIp";
            this.numIp.Size = new System.Drawing.Size(121, 23);
            this.numIp.TabIndex = 19;
            // 
            // NiP
            // 
            this.NiP.AutoSize = true;
            this.NiP.Location = new System.Drawing.Point(7, 296);
            this.NiP.Name = "NiP";
            this.NiP.Size = new System.Drawing.Size(80, 15);
            this.NiP.TabIndex = 18;
            this.NiP.Text = "Numero de IP";
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.Location = new System.Drawing.Point(18, 274);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(35, 19);
            this.IP.TabIndex = 17;
            this.IP.TabStop = true;
            this.IP.Text = "IP";
            this.IP.UseVisualStyleBackColor = true;
            // 
            // USB
            // 
            this.USB.AutoSize = true;
            this.USB.Location = new System.Drawing.Point(18, 249);
            this.USB.Name = "USB";
            this.USB.Size = new System.Drawing.Size(46, 19);
            this.USB.TabIndex = 16;
            this.USB.TabStop = true;
            this.USB.Text = "USB";
            this.USB.UseVisualStyleBackColor = true;
            // 
            // observacion
            // 
            this.observacion.Location = new System.Drawing.Point(7, 195);
            this.observacion.Name = "observacion";
            this.observacion.Size = new System.Drawing.Size(237, 23);
            this.observacion.TabIndex = 15;
            // 
            // CartuchoContinuo
            // 
            this.CartuchoContinuo.AutoSize = true;
            this.CartuchoContinuo.Location = new System.Drawing.Point(18, 148);
            this.CartuchoContinuo.Name = "CartuchoContinuo";
            this.CartuchoContinuo.Size = new System.Drawing.Size(129, 19);
            this.CartuchoContinuo.TabIndex = 14;
            this.CartuchoContinuo.TabStop = true;
            this.CartuchoContinuo.Text = "Cartucho/Continuo";
            this.CartuchoContinuo.UseVisualStyleBackColor = true;
            // 
            // Toner
            // 
            this.Toner.AutoSize = true;
            this.Toner.Location = new System.Drawing.Point(18, 123);
            this.Toner.Name = "Toner";
            this.Toner.Size = new System.Drawing.Size(54, 19);
            this.Toner.TabIndex = 13;
            this.Toner.TabStop = true;
            this.Toner.Text = "Toner";
            this.Toner.UseVisualStyleBackColor = true;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(7, 338);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(109, 23);
            this.Guardar.TabIndex = 12;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            // 
            // obs
            // 
            this.obs.AutoSize = true;
            this.obs.Location = new System.Drawing.Point(3, 177);
            this.obs.Name = "obs";
            this.obs.Size = new System.Drawing.Size(73, 15);
            this.obs.TabIndex = 11;
            this.obs.Text = "Observacion";
            // 
            // TipoConexion
            // 
            this.TipoConexion.AutoSize = true;
            this.TipoConexion.Location = new System.Drawing.Point(7, 231);
            this.TipoConexion.Name = "TipoConexion";
            this.TipoConexion.Size = new System.Drawing.Size(98, 15);
            this.TipoConexion.TabIndex = 10;
            this.TipoConexion.Text = "Tipo de conexion";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(0, 119);
            this.label4.MaximumSize = new System.Drawing.Size(0, 2);
            this.label4.MinimumSize = new System.Drawing.Size(0, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 2);
            this.label4.TabIndex = 9;
            // 
            // TTinta
            // 
            this.TTinta.AutoSize = true;
            this.TTinta.Location = new System.Drawing.Point(3, 105);
            this.TTinta.Name = "TTinta";
            this.TTinta.Size = new System.Drawing.Size(73, 15);
            this.TTinta.TabIndex = 8;
            this.TTinta.Text = "Tipo de tinta";
            // 
            // CombMarca
            // 
            this.CombMarca.FormattingEnabled = true;
            this.CombMarca.Location = new System.Drawing.Point(123, 69);
            this.CombMarca.Name = "CombMarca";
            this.CombMarca.Size = new System.Drawing.Size(121, 23);
            this.CombMarca.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Seleccione la marca";
            // 
            // CombPuesto
            // 
            this.CombPuesto.FormattingEnabled = true;
            this.CombPuesto.Location = new System.Drawing.Point(123, 40);
            this.CombPuesto.Name = "CombPuesto";
            this.CombPuesto.Size = new System.Drawing.Size(121, 23);
            this.CombPuesto.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Seleccione el puesto";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(123, 11);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 23);
            this.comboBox4.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Seleccione el area";
            // 
            // Sistoners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 408);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.NuevaImpresora);
            this.Controls.Add(this.Gestion);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Sistoners";
            this.Text = "Sistema de Toners";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.Gestion.ResumeLayout(false);
            this.Gestion.PerformLayout();
            this.NuevaImpresora.ResumeLayout(false);
            this.NuevaImpresora.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tonerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoTonerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impresoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaImpresoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarImpresoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarTonerToolStripMenuItem;
        private System.Windows.Forms.Label LabAreaGest;
        private System.Windows.Forms.ComboBox CombArea;
        private System.Windows.Forms.Label LabGestPuesto;
        private System.Windows.Forms.ComboBox ComboPuesto;
        private System.Windows.Forms.Label LabGestImpre;
        private System.Windows.Forms.Panel Gestion;
        private System.Windows.Forms.Label LabelModeloToner;
        private System.Windows.Forms.ComboBox CombImpresora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelNumToner;
        private System.Windows.Forms.Label LabelCambio;
        private System.Windows.Forms.Button CambioToner;
        private System.Windows.Forms.ToolStripMenuItem tonerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaImpresorasToolStripMenuItem;
        private System.Windows.Forms.Panel NuevaImpresora;
        private System.Windows.Forms.RadioButton CartuchoContinuo;
        private System.Windows.Forms.RadioButton Toner;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label obs;
        private System.Windows.Forms.Label TipoConexion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TTinta;
        private System.Windows.Forms.ComboBox CombMarca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CombPuesto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox observacion;
        private System.Windows.Forms.Label NiP;
        private System.Windows.Forms.RadioButton IP;
        private System.Windows.Forms.RadioButton USB;
        private System.Windows.Forms.ToolStripMenuItem editarPuestoToolStripMenuItem;
        private System.Windows.Forms.TextBox numIp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button Cancelar;
    }
}

