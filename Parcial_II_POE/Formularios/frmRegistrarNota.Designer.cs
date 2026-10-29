namespace Parcial_II_POE.Formularios
{
    partial class frmRegistrarNota
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.cmbEstudiante = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.lblTipoNota = new System.Windows.Forms.Label();
            this.cmbTipoNota = new System.Windows.Forms.ComboBox();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.txtLaboratorio = new System.Windows.Forms.TextBox();
            this.lblParcial = new System.Windows.Forms.Label();
            this.txtParcial = new System.Windows.Forms.TextBox();
            this.lblAsistencia = new System.Windows.Forms.Label();
            this.txtAsistencia = new System.Windows.Forms.TextBox();
            this.lblNotaFinal = new System.Windows.Forms.Label();
            this.lblNotaFinalValor = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante.Location = new System.Drawing.Point(20, 28);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(84, 16);
            this.lblEstudiante.TabIndex = 15;
            this.lblEstudiante.Text = "Estudiante:";
            // 
            // cmbEstudiante
            // 
            this.cmbEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstudiante.FormattingEnabled = true;
            this.cmbEstudiante.Location = new System.Drawing.Point(141, 25);
            this.cmbEstudiante.Name = "cmbEstudiante";
            this.cmbEstudiante.Size = new System.Drawing.Size(260, 24);
            this.cmbEstudiante.TabIndex = 0;
            this.cmbEstudiante.SelectedIndexChanged += new System.EventHandler(this.cmbEstudiante_SelectedIndexChanged);
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(20, 68);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(63, 16);
            this.lblMateria.TabIndex = 14;
            this.lblMateria.Text = "Materia:";
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(141, 65);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(260, 24);
            this.cmbMateria.TabIndex = 1;
            this.cmbMateria.SelectedIndexChanged += new System.EventHandler(this.cmbMateria_SelectedIndexChanged);
            // 
            // lblTipoNota
            // 
            this.lblTipoNota.AutoSize = true;
            this.lblTipoNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoNota.Location = new System.Drawing.Point(20, 108);
            this.lblTipoNota.Name = "lblTipoNota";
            this.lblTipoNota.Size = new System.Drawing.Size(119, 16);
            this.lblTipoNota.TabIndex = 13;
            this.lblTipoNota.Text = "Nota a registrar:";
            // 
            // cmbTipoNota
            // 
            this.cmbTipoNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoNota.FormattingEnabled = true;
            this.cmbTipoNota.Location = new System.Drawing.Point(141, 105);
            this.cmbTipoNota.Name = "cmbTipoNota";
            this.cmbTipoNota.Size = new System.Drawing.Size(260, 24);
            this.cmbTipoNota.TabIndex = 2;
            this.cmbTipoNota.SelectedIndexChanged += new System.EventHandler(this.cmbTipoNota_SelectedIndexChanged);
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaboratorio.Location = new System.Drawing.Point(479, 28);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(134, 16);
            this.lblLaboratorio.TabIndex = 12;
            this.lblLaboratorio.Text = "Laboratorio (50%):";
            // 
            // txtLaboratorio
            // 
            this.txtLaboratorio.Location = new System.Drawing.Point(628, 22);
            this.txtLaboratorio.MaxLength = 5;
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.ReadOnly = true;
            this.txtLaboratorio.Size = new System.Drawing.Size(100, 22);
            this.txtLaboratorio.TabIndex = 3;
            this.txtLaboratorio.TextChanged += new System.EventHandler(this.txtNota_TextChanged);
            this.txtLaboratorio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            // 
            // lblParcial
            // 
            this.lblParcial.AutoSize = true;
            this.lblParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcial.Location = new System.Drawing.Point(479, 65);
            this.lblParcial.Name = "lblParcial";
            this.lblParcial.Size = new System.Drawing.Size(103, 16);
            this.lblParcial.TabIndex = 11;
            this.lblParcial.Text = "Parcial (40%):";
            // 
            // txtParcial
            // 
            this.txtParcial.Location = new System.Drawing.Point(628, 65);
            this.txtParcial.MaxLength = 5;
            this.txtParcial.Name = "txtParcial";
            this.txtParcial.ReadOnly = true;
            this.txtParcial.Size = new System.Drawing.Size(100, 22);
            this.txtParcial.TabIndex = 4;
            this.txtParcial.TextChanged += new System.EventHandler(this.txtNota_TextChanged);
            this.txtParcial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            // 
            // lblAsistencia
            // 
            this.lblAsistencia.AutoSize = true;
            this.lblAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistencia.Location = new System.Drawing.Point(479, 105);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.Size = new System.Drawing.Size(126, 16);
            this.lblAsistencia.TabIndex = 10;
            this.lblAsistencia.Text = "Asistencia (10%):";
            // 
            // txtAsistencia
            // 
            this.txtAsistencia.Location = new System.Drawing.Point(628, 102);
            this.txtAsistencia.MaxLength = 5;
            this.txtAsistencia.Name = "txtAsistencia";
            this.txtAsistencia.ReadOnly = true;
            this.txtAsistencia.Size = new System.Drawing.Size(100, 22);
            this.txtAsistencia.TabIndex = 5;
            this.txtAsistencia.TextChanged += new System.EventHandler(this.txtNota_TextChanged);
            this.txtAsistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            // 
            // lblNotaFinal
            // 
            this.lblNotaFinal.AutoSize = true;
            this.lblNotaFinal.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaFinal.Location = new System.Drawing.Point(450, 164);
            this.lblNotaFinal.Name = "lblNotaFinal";
            this.lblNotaFinal.Size = new System.Drawing.Size(96, 22);
            this.lblNotaFinal.TabIndex = 9;
            this.lblNotaFinal.Text = "Nota final:";
            // 
            // lblNotaFinalValor
            // 
            this.lblNotaFinalValor.AutoSize = true;
            this.lblNotaFinalValor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblNotaFinalValor.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaFinalValor.Location = new System.Drawing.Point(556, 164);
            this.lblNotaFinalValor.Name = "lblNotaFinalValor";
            this.lblNotaFinalValor.Size = new System.Drawing.Size(41, 20);
            this.lblNotaFinalValor.TabIndex = 8;
            this.lblNotaFinalValor.Text = "0.00";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(270, 155);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 39);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.AllowUserToAddRows = false;
            this.dgvRegistro.AllowUserToDeleteRows = false;
            this.dgvRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegistro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.Location = new System.Drawing.Point(20, 200);
            this.dgvRegistro.MultiSelect = false;
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.ReadOnly = true;
            this.dgvRegistro.RowHeadersWidth = 51;
            this.dgvRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistro.Size = new System.Drawing.Size(740, 340);
            this.dgvRegistro.TabIndex = 7;
            this.dgvRegistro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistro_CellDoubleClick);
            // 
            // frmRegistrarNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 560);
            this.Controls.Add(this.dgvRegistro);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblNotaFinalValor);
            this.Controls.Add(this.lblNotaFinal);
            this.Controls.Add(this.txtAsistencia);
            this.Controls.Add(this.lblAsistencia);
            this.Controls.Add(this.txtParcial);
            this.Controls.Add(this.lblParcial);
            this.Controls.Add(this.txtLaboratorio);
            this.Controls.Add(this.lblLaboratorio);
            this.Controls.Add(this.cmbTipoNota);
            this.Controls.Add(this.lblTipoNota);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.cmbEstudiante);
            this.Controls.Add(this.lblEstudiante);
            this.KeyPreview = true;
            this.Name = "frmRegistrarNota";
            this.Text = "Registrar Nota";
            this.Load += new System.EventHandler(this.frmRegistrarNota_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRegistrarNota_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.ComboBox cmbEstudiante;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.Label lblTipoNota;
        private System.Windows.Forms.ComboBox cmbTipoNota;
        private System.Windows.Forms.Label lblLaboratorio;
        private System.Windows.Forms.TextBox txtLaboratorio;
        private System.Windows.Forms.Label lblParcial;
        private System.Windows.Forms.TextBox txtParcial;
        private System.Windows.Forms.Label lblAsistencia;
        private System.Windows.Forms.TextBox txtAsistencia;
        private System.Windows.Forms.Label lblNotaFinal;
        private System.Windows.Forms.Label lblNotaFinalValor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvRegistro;
    }
}
