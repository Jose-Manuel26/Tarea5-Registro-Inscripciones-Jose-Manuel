namespace Registro_Inscripciones
{
    partial class rInscripciones
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
            this.errpNumerico = new System.Windows.Forms.ErrorProvider(this.components);
            this.errpCampoVacio = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txInscripcionID = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btConsulta = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.Nombreslabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errpNumerico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpCampoVacio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "EstudianteId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 300);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Observaciones";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 138);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(288, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // txEstudianteID
            // 
            this.txEstudianteID.Location = new System.Drawing.Point(149, 177);
            this.txEstudianteID.Margin = new System.Windows.Forms.Padding(4);
            this.txEstudianteID.Name = "txEstudianteID";
            this.txEstudianteID.Size = new System.Drawing.Size(58, 22);
            this.txEstudianteID.TabIndex = 7;
            // 
            // txMonto
            // 
            this.txMonto.Location = new System.Drawing.Point(149, 214);
            this.txMonto.Margin = new System.Windows.Forms.Padding(4);
            this.txMonto.Name = "txMonto";
            this.txMonto.Size = new System.Drawing.Size(288, 22);
            this.txMonto.TabIndex = 8;
            // 
            // txBalance
            // 
            this.txBalance.Location = new System.Drawing.Point(149, 255);
            this.txBalance.Margin = new System.Windows.Forms.Padding(4);
            this.txBalance.Name = "txBalance";
            this.txBalance.Size = new System.Drawing.Size(288, 22);
            this.txBalance.TabIndex = 9;
            // 
            // txObservacion
            // 
            this.txObservacion.Location = new System.Drawing.Point(149, 296);
            this.txObservacion.Margin = new System.Windows.Forms.Padding(4);
            this.txObservacion.Multiline = true;
            this.txObservacion.Name = "txObservacion";
            this.txObservacion.Size = new System.Drawing.Size(288, 96);
            this.txObservacion.TabIndex = 10;
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
            this.label6.Location = new System.Drawing.Point(37, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "InscripcionID";
            // 
            // txInscripcionID
            // 
            this.txInscripcionID.Location = new System.Drawing.Point(149, 80);
            this.txInscripcionID.Margin = new System.Windows.Forms.Padding(4);
            this.txInscripcionID.Name = "txInscripcionID";
            this.txInscripcionID.Size = new System.Drawing.Size(132, 22);
            this.txInscripcionID.TabIndex = 18;
            // 
            // btBuscar
            // 
            this.btBuscar.Image = global::Registro_Inscripciones.Properties.Resources.Find_32;
            this.btBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBuscar.Location = new System.Drawing.Point(289, 66);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(148, 50);
            this.btBuscar.TabIndex = 19;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btConsulta
            // 
            this.btConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConsulta.Location = new System.Drawing.Point(40, 13);
            this.btConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(242, 29);
            this.btConsulta.TabIndex = 16;
            this.btConsulta.Text = "Consulta";
            this.btConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btConsulta.UseVisualStyleBackColor = true;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Image = global::Registro_Inscripciones.Properties.Resources.Save_32;
            this.btGuardar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btGuardar.Location = new System.Drawing.Point(206, 423);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(105, 57);
            this.btGuardar.TabIndex = 15;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Image = global::Registro_Inscripciones.Properties.Resources.Delete_32;
            this.btEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEliminar.Location = new System.Drawing.Point(332, 423);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(105, 57);
            this.btEliminar.TabIndex = 13;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // Nombreslabel
            // 
            this.Nombreslabel.AutoSize = true;
            this.Nombreslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombreslabel.Location = new System.Drawing.Point(286, 177);
            this.Nombreslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nombreslabel.Name = "Nombreslabel";
            this.Nombreslabel.Size = new System.Drawing.Size(72, 17);
            this.Nombreslabel.TabIndex = 1;
            this.Nombreslabel.Text = "Nombres";
            // 
            // button1
            // 
            this.button1.Image = global::Registro_Inscripciones.Properties.Resources.Find_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(215, 160);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 50);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(93, 423);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 57);
            this.button2.TabIndex = 21;
            this.button2.Text = "Nuevo";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // rInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 505);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txInscripcionID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btConsulta);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.txObservacion);
            this.Controls.Add(this.txBalance);
            this.Controls.Add(this.txMonto);
            this.Controls.Add(this.txEstudianteID);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nombreslabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "rInscripciones";
            this.Text = "Registro de Inscripciones";
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
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.ErrorProvider errpNumerico;
        private System.Windows.Forms.ErrorProvider errpCampoVacio;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox txInscripcionID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Nombreslabel;
        private System.Windows.Forms.Button button2;
    }
}

