
namespace Proyecto_Estacionamiento
{
    partial class Form4
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
            this.label28 = new System.Windows.Forms.Label();
            this.txtModIngreso1 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtModIngreso2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileArchivoMod = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label28.Location = new System.Drawing.Point(12, 68);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(92, 26);
            this.label28.TabIndex = 53;
            this.label28.Text = "Modelo:";
            // 
            // txtModIngreso1
            // 
            this.txtModIngreso1.Location = new System.Drawing.Point(12, 97);
            this.txtModIngreso1.Name = "txtModIngreso1";
            this.txtModIngreso1.Size = new System.Drawing.Size(118, 27);
            this.txtModIngreso1.TabIndex = 54;
            this.txtModIngreso1.TextChanged += new System.EventHandler(this.txtModIngreso1_TextChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label29.Location = new System.Drawing.Point(12, 127);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(87, 26);
            this.label29.TabIndex = 55;
            this.label29.Text = "Placas:";
            // 
            // txtModIngreso2
            // 
            this.txtModIngreso2.Location = new System.Drawing.Point(12, 156);
            this.txtModIngreso2.Name = "txtModIngreso2";
            this.txtModIngreso2.Size = new System.Drawing.Size(118, 27);
            this.txtModIngreso2.TabIndex = 56;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(12, 189);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(155, 54);
            this.button6.TabIndex = 57;
            this.button6.Text = "Guardar Cambios  ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 58;
            this.label1.Text = "Archivo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(379, 27);
            this.textBox1.TabIndex = 59;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(397, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 30);
            this.button1.TabIndex = 60;
            this.button1.Text = "Examinar  ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(633, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 54);
            this.button2.TabIndex = 61;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(397, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 61);
            this.button3.TabIndex = 62;
            this.button3.Text = "Eliminar Archivo de Vehículo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txtModIngreso2);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.txtModIngreso1);
            this.Controls.Add(this.label28);
            this.Name = "Form4";
            this.Text = "Modificar Archivo ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtModIngreso1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtModIngreso2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileArchivoMod;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}