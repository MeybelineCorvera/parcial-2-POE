namespace Parcial_II_POE.Formularios
{
    partial class frmRegistrarNotaCmd
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
            this.lblEstudianteValor = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblMateriaValor = new System.Windows.Forms.Label();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.txtLaboratorio = new System.Windows.Forms.TextBox();
            this.lblParcial = new System.Windows.Forms.Label();
            this.txtParcial = new System.Windows.Forms.TextBox();
            this.lblAsistencia = new System.Windows.Forms.Label();
            this.txtAsistencia = new System.Windows.Forms.TextBox();
            this.lblNotaFinal = new System.Windows.Forms.Label();
            this.lblNotaFinalValor = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante.Location = new System.Drawing.Point(20, 25);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(84, 16);
            this.lblEstudiante.TabIndex = 13;
            this.lblEstudiante.Text = "Estudiante:";
            // 
            // lblEstudianteValor
            // 
            this.lblEstudianteValor.AutoEllipsis = true;
            this.lblEstudianteValor.Location = new System.Drawing.Point(120, 25);
            this.lblEstudianteValor.Name = "lblEstudianteValor";
            this.lblEstudianteValor.Size = new System.Drawing.Size(420, 20);
            this.lblEstudianteValor.TabIndex = 12;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(20, 55);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(63, 16);
            this.lblMateria.TabIndex = 11;
            this.lblMateria.Text = "Materia:";
            // 
            // lblMateriaValor
            // 
            this.lblMateriaValor.AutoEllipsis = true;
            this.lblMateriaValor.Location = new System.Drawing.Point(120, 55);
            this.lblMateriaValor.Name = "lblMateriaValor";
            this.lblMateriaValor.Size = new System.Drawing.Size(420, 20);
            this.lblMateriaValor.TabIndex = 10;
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaboratorio.Location = new System.Drawing.Point(20, 100);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(134, 16);
            this.lblLaboratorio.TabIndex = 9;
            this.lblLaboratorio.Text = "Laboratorio (50%):";
            // 
            // txtLaboratorio
            // 
            this.txtLaboratorio.Location = new System.Drawing.Point(170, 97);
            this.txtLaboratorio.MaxLength = 5;
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.Size = new System.Drawing.Size(100, 22);
            this.txtLaboratorio.TabIndex = 0;
            this.txtLaboratorio.TextChanged += new System.EventHandler(this.txtNota_TextChanged);
            this.txtLaboratorio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            // 
            // lblParcial
            // 
            this.lblParcial.AutoSize = true;
            this.lblParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcial.Location = new System.Drawing.Point(20, 140);
            this.lblParcial.Name = "lblParcial";
            this.lblParcial.Size = new System.Drawing.Size(103, 16);
            this.lblParcial.TabIndex = 8;
            this.lblParcial.Text = "Parcial (40%):";
            // 
            // txtParcial
            // 
            this.txtParcial.Location = new System.Drawing.Point(170, 137);
            this.txtParcial.MaxLength = 5;
            this.txtParcial.Name = "txtParcial";
            this.txtParcial.Size = new System.Drawing.Size(100, 22);
            this.txtParcial.TabIndex = 1;
            this.txtParcial.TextChanged += new System.EventHandler(this.txtNota_TextChanged);
            this.txtParcial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            // 
            // lblAsistencia
            // 
            this.lblAsistencia.AutoSize = true;
            this.lblAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistencia.Location = new System.Drawing.Point(20, 180);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.Size = new System.Drawing.Size(126, 16);
            this.lblAsistencia.TabIndex = 7;
            this.lblAsistencia.Text = "Asistencia (10%):";
            // 
            // txtAsistencia
            // 
            this.txtAsistencia.Location = new System.Drawing.Point(170, 177);
            this.txtAsistencia.MaxLength = 5;
            this.txtAsistencia.Name = "txtAsistencia";
            this.txtAsistencia.Size = new System.Drawing.Size(100, 22);
            this.txtAsistencia.TabIndex = 2;
            this.txtAsistencia.TextChanged += new System.EventHandler(this.txtNota_TextChanged);
            this.txtAsistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            // 
            // lblNotaFinal
            // 
            this.lblNotaFinal.AutoSize = true;
            this.lblNotaFinal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaFinal.Location = new System.Drawing.Point(19, 234);
            this.lblNotaFinal.Name = "lblNotaFinal";
            this.lblNotaFinal.Size = new System.Drawing.Size(92, 20);
            this.lblNotaFinal.TabIndex = 6;
            this.lblNotaFinal.Text = "Nota final:";
            // 
            // lblNotaFinalValor
            // 
            this.lblNotaFinalValor.AutoSize = true;
            this.lblNotaFinalValor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblNotaFinalValor.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaFinalValor.Location = new System.Drawing.Point(166, 234);
            this.lblNotaFinalValor.Name = "lblNotaFinalValor";
            this.lblNotaFinalValor.Size = new System.Drawing.Size(41, 20);
            this.lblNotaFinalValor.TabIndex = 5;
            this.lblNotaFinalValor.Text = "0.00";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(153, 286);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 41);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(289, 286);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 41);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmRegistrarNotaCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 382);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblNotaFinalValor);
            this.Controls.Add(this.lblNotaFinal);
            this.Controls.Add(this.txtAsistencia);
            this.Controls.Add(this.lblAsistencia);
            this.Controls.Add(this.txtParcial);
            this.Controls.Add(this.lblParcial);
            this.Controls.Add(this.txtLaboratorio);
            this.Controls.Add(this.lblLaboratorio);
            this.Controls.Add(this.lblMateriaValor);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblEstudianteValor);
            this.Controls.Add(this.lblEstudiante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistrarNotaCmd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Nota";
            this.Load += new System.EventHandler(this.frmRegistrarNotaCmd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.Label lblEstudianteValor;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblMateriaValor;
        private System.Windows.Forms.Label lblLaboratorio;
        private System.Windows.Forms.TextBox txtLaboratorio;
        private System.Windows.Forms.Label lblParcial;
        private System.Windows.Forms.TextBox txtParcial;
        private System.Windows.Forms.Label lblAsistencia;
        private System.Windows.Forms.TextBox txtAsistencia;
        private System.Windows.Forms.Label lblNotaFinal;
        private System.Windows.Forms.Label lblNotaFinalValor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
