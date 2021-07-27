
namespace Proyecto_Estacionamiento
{
    partial class Form7
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVehiculos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlacas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 32);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(109, 27);
            this.txtID.TabIndex = 1;
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.AllowUserToAddRows = false;
            this.dgvVehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Location = new System.Drawing.Point(12, 250);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.RowHeadersWidth = 51;
            this.dgvVehiculos.RowTemplate.Height = 29;
            this.dgvVehiculos.Size = new System.Drawing.Size(602, 188);
            this.dgvVehiculos.TabIndex = 2;
            this.dgvVehiculos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vehículo:";
            // 
            // txtVehiculos
            // 
            this.txtVehiculos.Location = new System.Drawing.Point(12, 85);
            this.txtVehiculos.Name = "txtVehiculos";
            this.txtVehiculos.Size = new System.Drawing.Size(109, 27);
            this.txtVehiculos.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Placas:";
            // 
            // txtPlacas
            // 
            this.txtPlacas.Location = new System.Drawing.Point(12, 138);
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(109, 27);
            this.txtPlacas.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Color:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(12, 191);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(109, 27);
            this.txtColor.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Proyecto_Estacionamiento.Properties.Resources._285657_floppy_guardar_save_icon;
            this.btnAgregar.Location = new System.Drawing.Point(217, 23);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(156, 77);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::Proyecto_Estacionamiento.Properties.Resources._1564525_arrow_load_refresh_reload_icon;
            this.btnModificar.Location = new System.Drawing.Point(217, 115);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(156, 73);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::Proyecto_Estacionamiento.Properties.Resources._2462966_delete_eliminate_garbage_litter_recycle_icon;
            this.btnBorrar.Location = new System.Drawing.Point(441, 23);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(156, 77);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Proyecto_Estacionamiento.Properties.Resources._728918_cancel_error_exit_fault_alert_icon;
            this.btnCancelar.Location = new System.Drawing.Point(441, 115);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(156, 73);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(328, 194);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(164, 29);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar Celdas";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPlacas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVehiculos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvVehiculos);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Base de datos del estacionamiento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVehiculos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlacas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}