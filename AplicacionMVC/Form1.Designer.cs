namespace AplicacionMVC
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dbempresa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnacimiento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.btnconectar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbempresa)).BeginInit();
            this.SuspendLayout();
            // 
            // dbempresa
            // 
            this.dbempresa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dbempresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbempresa.Location = new System.Drawing.Point(13, 277);
            this.dbempresa.Name = "dbempresa";
            this.dbempresa.Size = new System.Drawing.Size(240, 161);
            this.dbempresa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese la cedula del empleado";
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(81, 44);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(100, 20);
            this.txtcedula.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese el nombre del empleado";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(81, 83);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese la fecha de nacimiento del empleado";
            // 
            // txtnacimiento
            // 
            this.txtnacimiento.Location = new System.Drawing.Point(81, 161);
            this.txtnacimiento.Name = "txtnacimiento";
            this.txtnacimiento.Size = new System.Drawing.Size(100, 20);
            this.txtnacimiento.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ingrese el cargo del empleado";
            // 
            // btnguardar
            // 
            this.btnguardar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnguardar.Location = new System.Drawing.Point(16, 226);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.ForeColor = System.Drawing.Color.Red;
            this.btneliminar.Location = new System.Drawing.Point(97, 226);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 9;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnactualizar.Location = new System.Drawing.Point(178, 226);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(75, 23);
            this.btnactualizar.TabIndex = 10;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // txtcargo
            // 
            this.txtcargo.Location = new System.Drawing.Point(81, 200);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(100, 20);
            this.txtcargo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ingrese el apellido del empleado";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(81, 122);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 20);
            this.txtapellido.TabIndex = 13;
            // 
            // btnconectar
            // 
            this.btnconectar.ForeColor = System.Drawing.Color.Blue;
            this.btnconectar.Location = new System.Drawing.Point(97, 252);
            this.btnconectar.Name = "btnconectar";
            this.btnconectar.Size = new System.Drawing.Size(75, 23);
            this.btnconectar.TabIndex = 14;
            this.btnconectar.Text = "Conectar";
            this.btnconectar.UseVisualStyleBackColor = true;
            this.btnconectar.Click += new System.EventHandler(this.btnconectar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 450);
            this.Controls.Add(this.btnconectar);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcargo);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnacimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbempresa);
            this.Name = "Form1";
            this.Text = "BDEmpresa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbempresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbempresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnacimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Button btnconectar;
    }
}

