namespace AppEstudiantesCRUD
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsOpenXml = new System.Windows.Forms.ToolStripButton();
            this.tsAddUser = new System.Windows.Forms.ToolStripButton();
            this.tsSearchUser = new System.Windows.Forms.ToolStripButton();
            this.tsEditUser = new System.Windows.Forms.ToolStripButton();
            this.tsDeleteUser = new System.Windows.Forms.ToolStripButton();
            this.tsSaveXML = new System.Windows.Forms.ToolStripButton();
            this.tsRecoverUser = new System.Windows.Forms.ToolStripButton();
            this.tsExitApp = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCorreoIn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNota1In = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNota2In = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNota3In = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNota4In = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgTablaDAtos = new System.Windows.Forms.DataGridView();
            this.errorM = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgTablaDAtosEliminados = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTablaDAtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorM)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTablaDAtosEliminados)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOpenXml,
            this.tsAddUser,
            this.tsSearchUser,
            this.tsEditUser,
            this.tsDeleteUser,
            this.tsExitApp,
            this.tsSaveXML,
            this.tsRecoverUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(20, 20, 20, 5);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(8);
            this.toolStrip1.Size = new System.Drawing.Size(787, 125);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsOpenXml
            // 
            this.tsOpenXml.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsOpenXml.Image = ((System.Drawing.Image)(resources.GetObject("tsOpenXml.Image")));
            this.tsOpenXml.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsOpenXml.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOpenXml.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.tsOpenXml.Name = "tsOpenXml";
            this.tsOpenXml.Padding = new System.Windows.Forms.Padding(5);
            this.tsOpenXml.Size = new System.Drawing.Size(94, 94);
            this.tsOpenXml.Text = "tsOpenFile";
            this.tsOpenXml.ToolTipText = "Abrir XML";
            this.tsOpenXml.Visible = false;
            this.tsOpenXml.Click += new System.EventHandler(this.tsOpenXml_Click);
            // 
            // tsAddUser
            // 
            this.tsAddUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAddUser.Image = ((System.Drawing.Image)(resources.GetObject("tsAddUser.Image")));
            this.tsAddUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsAddUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAddUser.Name = "tsAddUser";
            this.tsAddUser.Size = new System.Drawing.Size(84, 106);
            this.tsAddUser.Text = "tsAgregarUsuario";
            this.tsAddUser.ToolTipText = "Nuevo estudiante";
            this.tsAddUser.Click += new System.EventHandler(this.tsAddUser_Click);
            // 
            // tsSearchUser
            // 
            this.tsSearchUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSearchUser.Image = ((System.Drawing.Image)(resources.GetObject("tsSearchUser.Image")));
            this.tsSearchUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsSearchUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSearchUser.Name = "tsSearchUser";
            this.tsSearchUser.Size = new System.Drawing.Size(84, 106);
            this.tsSearchUser.Text = "tsSearchUser";
            this.tsSearchUser.ToolTipText = "Buscar estudiante";
            this.tsSearchUser.Click += new System.EventHandler(this.tsSearchUser_Click);
            // 
            // tsEditUser
            // 
            this.tsEditUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEditUser.Enabled = false;
            this.tsEditUser.Image = ((System.Drawing.Image)(resources.GetObject("tsEditUser.Image")));
            this.tsEditUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsEditUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEditUser.Name = "tsEditUser";
            this.tsEditUser.Size = new System.Drawing.Size(84, 106);
            this.tsEditUser.Text = "tsEditUser";
            this.tsEditUser.ToolTipText = "Editar datos estudiante";
            this.tsEditUser.Click += new System.EventHandler(this.tsEditUser_Click);
            // 
            // tsDeleteUser
            // 
            this.tsDeleteUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDeleteUser.Enabled = false;
            this.tsDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("tsDeleteUser.Image")));
            this.tsDeleteUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsDeleteUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeleteUser.Name = "tsDeleteUser";
            this.tsDeleteUser.Size = new System.Drawing.Size(84, 106);
            this.tsDeleteUser.Text = "tsDelete";
            this.tsDeleteUser.ToolTipText = "Borrar datos estudiante";
            this.tsDeleteUser.Click += new System.EventHandler(this.tsDeleteUser_Click);
            // 
            // tsSaveXML
            // 
            this.tsSaveXML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSaveXML.Image = ((System.Drawing.Image)(resources.GetObject("tsSaveXML.Image")));
            this.tsSaveXML.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsSaveXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSaveXML.Name = "tsSaveXML";
            this.tsSaveXML.Size = new System.Drawing.Size(84, 106);
            this.tsSaveXML.Text = "tsSaveFile";
            this.tsSaveXML.ToolTipText = "Guardar archivo XML";
            this.tsSaveXML.Click += new System.EventHandler(this.tsSaveXML_Click);
            // 
            // tsRecoverUser
            // 
            this.tsRecoverUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsRecoverUser.Image = ((System.Drawing.Image)(resources.GetObject("tsRecoverUser.Image")));
            this.tsRecoverUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsRecoverUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRecoverUser.Name = "tsRecoverUser";
            this.tsRecoverUser.Size = new System.Drawing.Size(76, 106);
            this.tsRecoverUser.Text = "tsRecuperarUsuario";
            this.tsRecoverUser.ToolTipText = "Recuperar usuario";
            this.tsRecoverUser.Click += new System.EventHandler(this.tsRecoverUser_Click);
            // 
            // tsExitApp
            // 
            this.tsExitApp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsExitApp.Image = ((System.Drawing.Image)(resources.GetObject("tsExitApp.Image")));
            this.tsExitApp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsExitApp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsExitApp.Name = "tsExitApp";
            this.tsExitApp.Size = new System.Drawing.Size(84, 106);
            this.tsExitApp.Text = "tsExitApp";
            this.tsExitApp.ToolTipText = "Salir de la aplicacion";
            this.tsExitApp.Click += new System.EventHandler(this.tsExitApp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // txtCodigoIn
            // 
            this.txtCodigoIn.Location = new System.Drawing.Point(632, 180);
            this.txtCodigoIn.Name = "txtCodigoIn";
            this.txtCodigoIn.Size = new System.Drawing.Size(117, 30);
            this.txtCodigoIn.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datos estudiante";
            // 
            // txtNombreIn
            // 
            this.txtNombreIn.Location = new System.Drawing.Point(115, 248);
            this.txtNombreIn.Name = "txtNombreIn";
            this.txtNombreIn.Size = new System.Drawing.Size(634, 30);
            this.txtNombreIn.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // txtCorreoIn
            // 
            this.txtCorreoIn.Location = new System.Drawing.Point(115, 294);
            this.txtCorreoIn.Name = "txtCorreoIn";
            this.txtCorreoIn.Size = new System.Drawing.Size(634, 30);
            this.txtCorreoIn.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Correo";
            // 
            // txtNota1In
            // 
            this.txtNota1In.Location = new System.Drawing.Point(115, 348);
            this.txtNota1In.Name = "txtNota1In";
            this.txtNota1In.Size = new System.Drawing.Size(65, 30);
            this.txtNota1In.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nota 1";
            // 
            // txtNota2In
            // 
            this.txtNota2In.Location = new System.Drawing.Point(296, 348);
            this.txtNota2In.Name = "txtNota2In";
            this.txtNota2In.Size = new System.Drawing.Size(65, 30);
            this.txtNota2In.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nota 2";
            // 
            // txtNota3In
            // 
            this.txtNota3In.Location = new System.Drawing.Point(491, 347);
            this.txtNota3In.Name = "txtNota3In";
            this.txtNota3In.Size = new System.Drawing.Size(65, 30);
            this.txtNota3In.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nota 3";
            // 
            // txtNota4In
            // 
            this.txtNota4In.Location = new System.Drawing.Point(684, 347);
            this.txtNota4In.Name = "txtNota4In";
            this.txtNota4In.Size = new System.Drawing.Size(65, 30);
            this.txtNota4In.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(588, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nota 4";
            // 
            // dgTablaDAtos
            // 
            this.dgTablaDAtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTablaDAtos.Location = new System.Drawing.Point(9, 16);
            this.dgTablaDAtos.Name = "dgTablaDAtos";
            this.dgTablaDAtos.RowHeadersWidth = 51;
            this.dgTablaDAtos.RowTemplate.Height = 24;
            this.dgTablaDAtos.Size = new System.Drawing.Size(725, 191);
            this.dgTablaDAtos.TabIndex = 16;
            // 
            // errorM
            // 
            this.errorM.ContainerControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 395);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 261);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgTablaDAtos);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(755, 223);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Estudiantes activos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgTablaDAtosEliminados);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(755, 223);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Estudiantes eliminados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgTablaDAtosEliminados
            // 
            this.dgTablaDAtosEliminados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTablaDAtosEliminados.Location = new System.Drawing.Point(15, 16);
            this.dgTablaDAtosEliminados.Name = "dgTablaDAtosEliminados";
            this.dgTablaDAtosEliminados.RowHeadersWidth = 51;
            this.dgTablaDAtosEliminados.RowTemplate.Height = 24;
            this.dgTablaDAtosEliminados.Size = new System.Drawing.Size(725, 191);
            this.dgTablaDAtosEliminados.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 703);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtNota4In);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNota3In);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNota2In);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNota1In);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCorreoIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTablaDAtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorM)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTablaDAtosEliminados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsOpenXml;
        private System.Windows.Forms.ToolStripButton tsAddUser;
        private System.Windows.Forms.ToolStripButton tsSearchUser;
        private System.Windows.Forms.ToolStripButton tsEditUser;
        private System.Windows.Forms.ToolStripButton tsDeleteUser;
        private System.Windows.Forms.ToolStripButton tsSaveXML;
        private System.Windows.Forms.ToolStripButton tsExitApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCorreoIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNota1In;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNota2In;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNota3In;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNota4In;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgTablaDAtos;
        private System.Windows.Forms.ErrorProvider errorM;
        private System.Windows.Forms.ToolStripButton tsRecoverUser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgTablaDAtosEliminados;
    }
}

