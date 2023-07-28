namespace TP7GalloRodrigoNicolas
{
    partial class VerEmpleados
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgListaEmpleados = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Casado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoBussinessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtNombreCompletoFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBussinessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "SISTEMA EMPLEADOS";
            // 
            // dgListaEmpleados
            // 
            this.dgListaEmpleados.AllowUserToAddRows = false;
            this.dgListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NombreCompleto,
            this.DNI,
            this.Edad,
            this.Casado,
            this.Salario,
            this.BtnEditar,
            this.BtnEliminar});
            this.dgListaEmpleados.Location = new System.Drawing.Point(15, 121);
            this.dgListaEmpleados.Name = "dgListaEmpleados";
            this.dgListaEmpleados.Size = new System.Drawing.Size(845, 459);
            this.dgListaEmpleados.TabIndex = 21;
            this.dgListaEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaEmpleados_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.DataPropertyName = "NombreCompleto";
            this.NombreCompleto.HeaderText = "NombreCompleto";
            this.NombreCompleto.Name = "NombreCompleto";
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "DNI";
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Edad
            // 
            this.Edad.DataPropertyName = "Edad";
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // Casado
            // 
            this.Casado.DataPropertyName = "Casado";
            this.Casado.HeaderText = "Casado";
            this.Casado.Name = "Casado";
            // 
            // Salario
            // 
            this.Salario.DataPropertyName = "Salario";
            this.Salario.HeaderText = "Salario";
            this.Salario.Name = "Salario";
            // 
            // BtnEditar
            // 
            this.BtnEditar.HeaderText = "Editar";
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.ToolTipText = "Editar";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.HeaderText = "Eliminar";
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.ToolTipText = "Eliminar";
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataSource = typeof(TP7GalloRodrigoNicolasEntities.Empleado);
            // 
            // empleadoBussinessBindingSource
            // 
            this.empleadoBussinessBindingSource.DataSource = typeof(TP7GalloRodrigoNicolasBussiness.EmpleadoBussiness);
            // 
            // empleadoBindingSource1
            // 
            this.empleadoBindingSource1.DataSource = typeof(TP7GalloRodrigoNicolasEntities.Empleado);
            // 
            // txtNombreCompletoFiltro
            // 
            this.txtNombreCompletoFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCompletoFiltro.Location = new System.Drawing.Point(15, 84);
            this.txtNombreCompletoFiltro.Name = "txtNombreCompletoFiltro";
            this.txtNombreCompletoFiltro.Size = new System.Drawing.Size(612, 31);
            this.txtNombreCompletoFiltro.TabIndex = 22;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(642, 84);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(218, 31);
            this.btnFiltrar.TabIndex = 23;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // VerEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 592);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtNombreCompletoFiltro);
            this.Controls.Add(this.dgListaEmpleados);
            this.Controls.Add(this.label1);
            this.Name = "VerEmpleados";
            this.Text = "VerEmpleadoscs";
            this.Load += new System.EventHandler(this.VerEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBussinessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private System.Windows.Forms.BindingSource empleadoBussinessBindingSource;
        private System.Windows.Forms.BindingSource empleadoBindingSource1;
        private System.Windows.Forms.DataGridView dgListaEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Casado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEliminar;
        private System.Windows.Forms.TextBox txtNombreCompletoFiltro;
        private System.Windows.Forms.Button btnFiltrar;
    }
}