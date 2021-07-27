
namespace Proyecto_Estacionamiento
{
    partial class Form5
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
            this.label31 = new System.Windows.Forms.Label();
            this.txtModSalida1 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txtModSalida2 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileModSalida = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label31.Location = new System.Drawing.Point(12, 68);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(92, 26);
            this.label31.TabIndex = 60;
            this.label31.Text = "Modelo:";
            // 
            // txtModSalida1
            // 
            this.txtModSalida1.Location = new System.Drawing.Point(12, 93);
            this.txtModSalida1.Name = "txtModSalida1";
            this.txtModSalida1.Size = new System.Drawing.Size(118, 27);
            this.txtModSalida1.TabIndex = 61;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label32.Location = new System.Drawing.Point(12, 123);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(87, 26);
            this.label32.TabIndex = 62;
            this.label32.Text = "Placas:";
            // 
            // txtModSalida2
            // 
            this.txtModSalida2.Location = new System.Drawing.Point(12, 152);
            this.txtModSalida2.Name = "txtModSalida2";
            this.txtModSalida2.Size = new System.Drawing.Size(118, 27);
            this.txtModSalida2.TabIndex = 63;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(12, 185);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(155, 54);
            this.button9.TabIndex = 64;
            this.button9.Text = "Guardar Cambios  ";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 65;
            this.label1.Text = "Archivo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(379, 27);
            this.textBox1.TabIndex = 66;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(397, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 30);
            this.button1.TabIndex = 67;
            this.button1.Text = "Examinar  ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(397, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 61);
            this.button3.TabIndex = 68;
            this.button3.Text = "Eliminar Archivo de Vehículo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(633, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 54);
            this.button2.TabIndex = 69;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.txtModSalida2);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.txtModSalida1);
            this.Controls.Add(this.label31);
            this.Name = "Form5";
            this.Text = "Modificar Vehículo de salida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtModSalida1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtModSalida2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileModSalida;
    }
}