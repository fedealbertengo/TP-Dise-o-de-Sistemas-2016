﻿using System;

namespace Trabajo_práctico
{
    partial class f12_AltaPuesto
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
            this.cbCompetencias = new System.Windows.Forms.ComboBox();
            this.tbPonderacion = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dgvCaracteristicas = new System.Windows.Forms.DataGridView();
            this.Competencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pond = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnDatos = new System.Windows.Forms.Panel();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbEmpresa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.pnMovForm = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteristicas)).BeginInit();
            this.pnDatos.SuspendLayout();
            this.pnMovForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCompetencias
            // 
            this.cbCompetencias.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbCompetencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompetencias.FormattingEnabled = true;
            this.cbCompetencias.Location = new System.Drawing.Point(57, 303);
            this.cbCompetencias.Margin = new System.Windows.Forms.Padding(4);
            this.cbCompetencias.Name = "cbCompetencias";
            this.cbCompetencias.Size = new System.Drawing.Size(160, 24);
            this.cbCompetencias.TabIndex = 1;
            this.cbCompetencias.SelectedIndexChanged += new System.EventHandler(this.cbCompetencias_SelectedIndexChanged);
            // 
            // tbPonderacion
            // 
            this.tbPonderacion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbPonderacion.Location = new System.Drawing.Point(249, 354);
            this.tbPonderacion.Margin = new System.Windows.Forms.Padding(4);
            this.tbPonderacion.MaxLength = 2;
            this.tbPonderacion.Name = "tbPonderacion";
            this.tbPonderacion.Size = new System.Drawing.Size(48, 22);
            this.tbPonderacion.TabIndex = 2;
            this.tbPonderacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPonderacion_KeyPress);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 559);
            this.splitter1.TabIndex = 12;
            this.splitter1.TabStop = false;
            // 
            // dgvCaracteristicas
            // 
            this.dgvCaracteristicas.AllowUserToAddRows = false;
            this.dgvCaracteristicas.AllowUserToDeleteRows = false;
            this.dgvCaracteristicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaracteristicas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Competencia,
            this.Pond});
            this.dgvCaracteristicas.Location = new System.Drawing.Point(389, 331);
            this.dgvCaracteristicas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCaracteristicas.Name = "dgvCaracteristicas";
            this.dgvCaracteristicas.ReadOnly = true;
            this.dgvCaracteristicas.Size = new System.Drawing.Size(581, 105);
            this.dgvCaracteristicas.TabIndex = 6;
            this.dgvCaracteristicas.TabStop = false;
            // 
            // Competencia
            // 
            this.Competencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Competencia.HeaderText = "Competencia";
            this.Competencia.Name = "Competencia";
            this.Competencia.ReadOnly = true;
            // 
            // Pond
            // 
            this.Pond.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pond.HeaderText = "Pond";
            this.Pond.Name = "Pond";
            this.Pond.ReadOnly = true;
            // 
            // pnDatos
            // 
            this.pnDatos.BackColor = System.Drawing.Color.Transparent;
            this.pnDatos.BackgroundImage = global::CPresentación.Properties.Resources.Fondo1;
            this.pnDatos.Controls.Add(this.tbNombre);
            this.pnDatos.Controls.Add(this.tbCodigo);
            this.pnDatos.Controls.Add(this.tbDescripcion);
            this.pnDatos.Controls.Add(this.label11);
            this.pnDatos.Controls.Add(this.label9);
            this.pnDatos.Controls.Add(this.tbEmpresa);
            this.pnDatos.Controls.Add(this.label10);
            this.pnDatos.Controls.Add(this.label12);
            this.pnDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.pnDatos.Location = new System.Drawing.Point(51, 95);
            this.pnDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnDatos.Name = "pnDatos";
            this.pnDatos.Size = new System.Drawing.Size(900, 149);
            this.pnDatos.TabIndex = 0;
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbNombre.Location = new System.Drawing.Point(336, 37);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombre.MaxLength = 50;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(461, 27);
            this.tbNombre.TabIndex = 1;
            // 
            // tbCodigo
            // 
            this.tbCodigo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbCodigo.Location = new System.Drawing.Point(235, 7);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCodigo.MaxLength = 20;
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(563, 27);
            this.tbCodigo.TabIndex = 0;
            this.tbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigo_KeyPress);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbDescripcion.Location = new System.Drawing.Point(273, 96);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDescripcion.MaxLength = 500;
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(524, 48);
            this.tbDescripcion.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(157, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 24);
            this.label11.TabIndex = 6;
            this.label11.Text = "Descripción";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(157, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "Empresa";
            // 
            // tbEmpresa
            // 
            this.tbEmpresa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbEmpresa.Location = new System.Drawing.Point(249, 66);
            this.tbEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmpresa.MaxLength = 20;
            this.tbEmpresa.Name = "tbEmpresa";
            this.tbEmpresa.Size = new System.Drawing.Size(548, 27);
            this.tbEmpresa.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(157, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 24);
            this.label10.TabIndex = 4;
            this.label10.Text = "Código";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(157, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 24);
            this.label12.TabIndex = 4;
            this.label12.Text = "Nombre del Puesto";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(4, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(980, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(380, 30);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(220, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Alta Puesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(53, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Característica del puesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(53, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ponderación";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.White;
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnCargar.FlatAppearance.BorderSize = 3;
            this.btnCargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCargar.Location = new System.Drawing.Point(341, 340);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(40, 39);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = ">";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.Color.White;
            this.btnSacar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSacar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnSacar.FlatAppearance.BorderSize = 3;
            this.btnSacar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnSacar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnSacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSacar.Location = new System.Drawing.Point(341, 383);
            this.btnSacar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(40, 39);
            this.btnSacar.TabIndex = 4;
            this.btnSacar.Text = "<";
            this.btnSacar.UseVisualStyleBackColor = false;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // pnMovForm
            // 
            this.pnMovForm.BackColor = System.Drawing.Color.Transparent;
            this.pnMovForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnMovForm.Controls.Add(this.btnCancelar);
            this.pnMovForm.Controls.Add(this.btnAceptar);
            this.pnMovForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMovForm.Location = new System.Drawing.Point(251, 500);
            this.pnMovForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnMovForm.Name = "pnMovForm";
            this.pnMovForm.Size = new System.Drawing.Size(500, 50);
            this.pnMovForm.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnCancelar.FlatAppearance.BorderSize = 3;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(69, 5);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(149, 39);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.White;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAceptar.FlatAppearance.BorderSize = 3;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(280, 5);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(149, 39);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // errorProv
            // 
            this.errorProv.BlinkRate = 0;
            this.errorProv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProv.ContainerControl = this;
            // 
            // f12_AltaPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(108)))), ((int)(((byte)(179)))));
            this.BackgroundImage = global::CPresentación.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(984, 559);
            this.Controls.Add(this.pnMovForm);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnDatos);
            this.Controls.Add(this.dgvCaracteristicas);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tbPonderacion);
            this.Controls.Add(this.cbCompetencias);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1002, 606);
            this.MinimumSize = new System.Drawing.Size(1002, 606);
            this.Name = "f12_AltaPuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.f12_AltaPuesto_FormClosed);
            this.Load += new System.EventHandler(this.f11_AltaPuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteristicas)).EndInit();
            this.pnDatos.ResumeLayout(false);
            this.pnDatos.PerformLayout();
            this.pnMovForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void tbNombre_KeyPress(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.ComboBox cbCompetencias;
        private System.Windows.Forms.TextBox tbPonderacion;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dgvCaracteristicas;
        private System.Windows.Forms.Panel pnDatos;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbEmpresa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Competencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pond;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Panel pnMovForm;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.ErrorProvider errorProv;
    }
}