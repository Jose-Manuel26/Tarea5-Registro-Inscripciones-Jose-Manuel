﻿namespace Registro_Inscripciones.Consultas
{
    partial class cInscripciones
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filterCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btMostrar = new System.Windows.Forms.Button();
            this.txValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subCombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(468, 166);
            this.dataGridView1.TabIndex = 0;
            // 
            // filterCombobox
            // 
            this.filterCombobox.FormattingEnabled = true;
            this.filterCombobox.Items.AddRange(new object[] {
            "InscripcionID",
            "Fecha",
            "EstudianteID",
            "Monto",
            "Balance",
            "Observaciones"});
            this.filterCombobox.Location = new System.Drawing.Point(12, 59);
            this.filterCombobox.Name = "filterCombobox";
            this.filterCombobox.Size = new System.Drawing.Size(121, 21);
            this.filterCombobox.TabIndex = 1;
            this.filterCombobox.SelectedIndexChanged += new System.EventHandler(this.filterCombobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtro de datos";
            // 
            // btMostrar
            // 
            this.btMostrar.Location = new System.Drawing.Point(16, 277);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(79, 32);
            this.btMostrar.TabIndex = 3;
            this.btMostrar.Text = "Mostrar";
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // txValor
            // 
            this.txValor.Location = new System.Drawing.Point(294, 60);
            this.txValor.Name = "txValor";
            this.txValor.Size = new System.Drawing.Size(186, 20);
            this.txValor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar";
            // 
            // subCombobox
            // 
            this.subCombobox.FormattingEnabled = true;
            this.subCombobox.Items.AddRange(new object[] {
            "Dia",
            "Mes",
            "Año"});
            this.subCombobox.Location = new System.Drawing.Point(140, 59);
            this.subCombobox.Name = "subCombobox";
            this.subCombobox.Size = new System.Drawing.Size(56, 21);
            this.subCombobox.TabIndex = 6;
            // 
            // cInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 321);
            this.Controls.Add(this.subCombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txValor);
            this.Controls.Add(this.btMostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterCombobox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "cInscripciones";
            this.Text = "Consulta de Inscripciones";
            this.Load += new System.EventHandler(this.cInscripciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox filterCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.TextBox txValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox subCombobox;
    }
}