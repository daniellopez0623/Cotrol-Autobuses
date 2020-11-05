namespace Capa_Presentacion
{
    partial class FrmRutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRutas));
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdChofer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdAuto = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEdiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscae = new System.Windows.Forms.Button();
            this.dataGridViewRutas = new System.Windows.Forms.DataGridView();
            this.comboBoxRutas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(388, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 71;
            this.label7.Text = "CODIGO";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(392, 149);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(119, 29);
            this.txtID.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(837, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 23);
            this.label6.TabIndex = 69;
            this.label6.Text = "CODIGO CHOFER";
            // 
            // txtIdChofer
            // 
            this.txtIdChofer.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdChofer.Location = new System.Drawing.Point(841, 149);
            this.txtIdChofer.Name = "txtIdChofer";
            this.txtIdChofer.Size = new System.Drawing.Size(171, 29);
            this.txtIdChofer.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1060, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 23);
            this.label4.TabIndex = 67;
            this.label4.Text = "CODIGO AUTOBUS";
            // 
            // txtIdAuto
            // 
            this.txtIdAuto.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAuto.Location = new System.Drawing.Point(1057, 149);
            this.txtIdAuto.Name = "txtIdAuto";
            this.txtIdAuto.Size = new System.Drawing.Size(171, 29);
            this.txtIdAuto.TabIndex = 66;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(64, 626);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(210, 41);
            this.btnEliminar.TabIndex = 65;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEdiar
            // 
            this.btnEdiar.BackColor = System.Drawing.Color.White;
            this.btnEdiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdiar.Location = new System.Drawing.Point(62, 462);
            this.btnEdiar.Name = "btnEdiar";
            this.btnEdiar.Size = new System.Drawing.Size(212, 40);
            this.btnEdiar.TabIndex = 64;
            this.btnEdiar.Text = "EDITAR";
            this.btnEdiar.UseVisualStyleBackColor = false;
            this.btnEdiar.Click += new System.EventHandler(this.btnEdiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(62, 379);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(212, 40);
            this.btnGuardar.TabIndex = 62;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscae
            // 
            this.btnBuscae.BackColor = System.Drawing.Color.White;
            this.btnBuscae.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscae.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscae.Location = new System.Drawing.Point(64, 547);
            this.btnBuscae.Name = "btnBuscae";
            this.btnBuscae.Size = new System.Drawing.Size(210, 41);
            this.btnBuscae.TabIndex = 63;
            this.btnBuscae.Text = "BUSCAR";
            this.btnBuscae.UseVisualStyleBackColor = false;
            this.btnBuscae.Click += new System.EventHandler(this.btnBuscae_Click);
            // 
            // dataGridViewRutas
            // 
            this.dataGridViewRutas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRutas.Location = new System.Drawing.Point(378, 273);
            this.dataGridViewRutas.Name = "dataGridViewRutas";
            this.dataGridViewRutas.RowHeadersWidth = 51;
            this.dataGridViewRutas.RowTemplate.Height = 24;
            this.dataGridViewRutas.Size = new System.Drawing.Size(1022, 415);
            this.dataGridViewRutas.TabIndex = 61;
            // 
            // comboBoxRutas
            // 
            this.comboBoxRutas.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRutas.FormattingEnabled = true;
            this.comboBoxRutas.Items.AddRange(new object[] {
            "VILLA MELLA",
            "SABANA LARGA",
            "LAS CHARLES",
            "LA CHURCHILL",
            "PUENTE JUAN PABLO"});
            this.comboBoxRutas.Location = new System.Drawing.Point(547, 147);
            this.comboBoxRutas.Name = "comboBoxRutas";
            this.comboBoxRutas.Size = new System.Drawing.Size(256, 31);
            this.comboBoxRutas.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(543, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 74;
            this.label1.Text = "RUTAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(124, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 37);
            this.label2.TabIndex = 75;
            this.label2.Text = "RUTAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1431, 831);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxRutas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdChofer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdAuto);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEdiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBuscae);
            this.Controls.Add(this.dataGridViewRutas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRutas";
            this.Text = "FrmRutas";
            this.Load += new System.EventHandler(this.FrmRutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdChofer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdAuto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEdiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscae;
        private System.Windows.Forms.DataGridView dataGridViewRutas;
        private System.Windows.Forms.ComboBox comboBoxRutas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}