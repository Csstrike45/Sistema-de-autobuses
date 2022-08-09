
namespace CapaPresentacion
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
            this.BtnChofer = new System.Windows.Forms.Button();
            this.BtnAutobus = new System.Windows.Forms.Button();
            this.BtnViaje = new System.Windows.Forms.Button();
            this.BtnRuta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnChofer
            // 
            this.BtnChofer.Location = new System.Drawing.Point(356, 130);
            this.BtnChofer.Name = "BtnChofer";
            this.BtnChofer.Size = new System.Drawing.Size(92, 44);
            this.BtnChofer.TabIndex = 0;
            this.BtnChofer.Text = "Chofer";
            this.BtnChofer.UseVisualStyleBackColor = true;
            this.BtnChofer.Click += new System.EventHandler(this.BtnChofer_Click);
            // 
            // BtnAutobus
            // 
            this.BtnAutobus.Location = new System.Drawing.Point(497, 130);
            this.BtnAutobus.Name = "BtnAutobus";
            this.BtnAutobus.Size = new System.Drawing.Size(88, 44);
            this.BtnAutobus.TabIndex = 1;
            this.BtnAutobus.Text = "Autobus";
            this.BtnAutobus.UseVisualStyleBackColor = true;
            this.BtnAutobus.Click += new System.EventHandler(this.BtnAutobus_Click);
            // 
            // BtnViaje
            // 
            this.BtnViaje.Location = new System.Drawing.Point(497, 215);
            this.BtnViaje.Name = "BtnViaje";
            this.BtnViaje.Size = new System.Drawing.Size(88, 43);
            this.BtnViaje.TabIndex = 2;
            this.BtnViaje.Text = "Viaje";
            this.BtnViaje.UseVisualStyleBackColor = true;
            this.BtnViaje.Click += new System.EventHandler(this.BtnViaje_Click);
            // 
            // BtnRuta
            // 
            this.BtnRuta.Location = new System.Drawing.Point(356, 215);
            this.BtnRuta.Name = "BtnRuta";
            this.BtnRuta.Size = new System.Drawing.Size(88, 43);
            this.BtnRuta.TabIndex = 3;
            this.BtnRuta.Text = "Ruta";
            this.BtnRuta.UseVisualStyleBackColor = true;
            this.BtnRuta.Click += new System.EventHandler(this.BtnRuta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.BtnRuta);
            this.Controls.Add(this.BtnViaje);
            this.Controls.Add(this.BtnAutobus);
            this.Controls.Add(this.BtnChofer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnChofer;
        private System.Windows.Forms.Button BtnAutobus;
        private System.Windows.Forms.Button BtnViaje;
        private System.Windows.Forms.Button BtnRuta;
    }
}

