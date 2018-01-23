namespace Registro_Inscripciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txEstudianteID = new System.Windows.Forms.TextBox();
            this.txMonto = new System.Windows.Forms.TextBox();
            this.txBalance = new System.Windows.Forms.TextBox();
            this.txObservacion = new System.Windows.Forms.TextBox();
            this.btModificar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btConsulta = new System.Windows.Forms.Button();
            this.errpNumerico = new System.Windows.Forms.ErrorProvider(this.components);
            this.errpCampoVacio = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txInscripcionID = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errpNumerico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpCampoVacio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "EstudianteId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Observaciones";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePicker1.Location = new System.Drawing.Point(97, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // txEstudianteID
            // 
            this.txEstudianteID.Location = new System.Drawing.Point(97, 100);
            this.txEstudianteID.Name = "txEstudianteID";
            this.txEstudianteID.Size = new System.Drawing.Size(217, 20);
            this.txEstudianteID.TabIndex = 7;
            this.txEstudianteID.TextChanged += new System.EventHandler(this.txEstudianteID_TextChanged);
            // 
            // txMonto
            // 
            this.txMonto.Location = new System.Drawing.Point(97, 130);
            this.txMonto.Name = "txMonto";
            this.txMonto.Size = new System.Drawing.Size(217, 20);
            this.txMonto.TabIndex = 8;
            this.txMonto.TextChanged += new System.EventHandler(this.txMonto_TextChanged);
            // 
            // txBalance
            // 
            this.txBalance.Location = new System.Drawing.Point(97, 163);
            this.txBalance.Name = "txBalance";
            this.txBalance.Size = new System.Drawing.Size(217, 20);
            this.txBalance.TabIndex = 9;
            this.txBalance.TextChanged += new System.EventHandler(this.txBalance_TextChanged);
            // 
            // txObservacion
            // 
            this.txObservacion.Location = new System.Drawing.Point(97, 197);
            this.txObservacion.Multiline = true;
            this.txObservacion.Name = "txObservacion";
            this.txObservacion.Size = new System.Drawing.Size(217, 79);
            this.txObservacion.TabIndex = 10;
            this.txObservacion.TextChanged += new System.EventHandler(this.txObservacion_TextChanged);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(235, 303);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(79, 55);
            this.btModificar.TabIndex = 12;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(362, 303);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(79, 55);
            this.btEliminar.TabIndex = 13;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(97, 303);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(79, 55);
            this.btGuardar.TabIndex = 15;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btConsulta
            // 
            this.btConsulta.Location = new System.Drawing.Point(380, 68);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(79, 55);
            this.btConsulta.TabIndex = 16;
            this.btConsulta.Text = "Consulta";
            this.btConsulta.UseVisualStyleBackColor = true;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // errpNumerico
            // 
            this.errpNumerico.ContainerControl = this;
            // 
            // errpCampoVacio
            // 
            this.errpCampoVacio.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "InscripcionID";
            // 
            // txInscripcionID
            // 
            this.txInscripcionID.Location = new System.Drawing.Point(97, 21);
            this.txInscripcionID.Name = "txInscripcionID";
            this.txInscripcionID.Size = new System.Drawing.Size(100, 20);
            this.txInscripcionID.TabIndex = 18;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(216, 21);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(56, 21);
            this.btBuscar.TabIndex = 19;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 410);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txInscripcionID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btConsulta);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.txObservacion);
            this.Controls.Add(this.txBalance);
            this.Controls.Add(this.txMonto);
            this.Controls.Add(this.txEstudianteID);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Registro de Inscripciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errpNumerico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpCampoVacio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txEstudianteID;
        private System.Windows.Forms.TextBox txMonto;
        private System.Windows.Forms.TextBox txBalance;
        private System.Windows.Forms.TextBox txObservacion;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.ErrorProvider errpNumerico;
        private System.Windows.Forms.ErrorProvider errpCampoVacio;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox txInscripcionID;
        private System.Windows.Forms.Label label6;
    }
}

