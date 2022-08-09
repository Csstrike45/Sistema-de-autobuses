
namespace CapaPresentacion
{
    partial class CHOFER
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
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.MtbCedula = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtInsertar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(83, 120);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(216, 20);
            this.TxtNombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(80, 165);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(219, 20);
            this.TxtApellido.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(70, 205);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(229, 20);
            this.DtpFecha.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cedula";
            // 
            // MtbCedula
            // 
            this.MtbCedula.Location = new System.Drawing.Point(75, 250);
            this.MtbCedula.Mask = "000-0000000-0";
            this.MtbCedula.Name = "MtbCedula";
            this.MtbCedula.Size = new System.Drawing.Size(224, 20);
            this.MtbCedula.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(384, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(834, 516);
            this.dataGridView1.TabIndex = 8;
            // 
            // BtnVolver
            // 
            this.BtnVolver.Location = new System.Drawing.Point(12, 455);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(125, 65);
            this.BtnVolver.TabIndex = 9;
            this.BtnVolver.Text = "Volver Atras";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(980, 33);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(159, 45);
            this.BtnEliminar.TabIndex = 11;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtInsertar
            // 
            this.BtInsertar.Location = new System.Drawing.Point(723, 33);
            this.BtInsertar.Name = "BtInsertar";
            this.BtInsertar.Size = new System.Drawing.Size(159, 45);
            this.BtInsertar.TabIndex = 12;
            this.BtInsertar.Text = "Insertar";
            this.BtInsertar.UseVisualStyleBackColor = true;
            this.BtInsertar.Click += new System.EventHandler(this.BtInsertar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(83, 46);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(273, 20);
            this.TxtBuscar.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Buscar";
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(476, 33);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(159, 45);
            this.BtnEditar.TabIndex = 15;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            // 
            // CHOFER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 657);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.BtInsertar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MtbCedula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNombre);
            this.Name = "CHOFER";
            this.Text = "CHOFER";
            this.Load += new System.EventHandler(this.CHOFER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MtbCedula;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtInsertar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnEditar;
    }
}