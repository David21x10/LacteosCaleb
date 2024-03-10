namespace LacteosCaleb
{
    partial class Categoria
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
            this.label3 = new System.Windows.Forms.Label();
            this.AÑADIR = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgcategoria = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbuscarcategoria = new System.Windows.Forms.TextBox();
            this.TxtUsuarioLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgcategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 337);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "ELIMINAR";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AÑADIR
            // 
            this.AÑADIR.AutoSize = true;
            this.AÑADIR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AÑADIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AÑADIR.Location = new System.Drawing.Point(95, 337);
            this.AÑADIR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AÑADIR.Name = "AÑADIR";
            this.AÑADIR.Size = new System.Drawing.Size(57, 15);
            this.AÑADIR.TabIndex = 28;
            this.AÑADIR.Text = "AÑADIR";
            this.AÑADIR.Click += new System.EventHandler(this.AÑADIR_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(347, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 38);
            this.button1.TabIndex = 27;
            this.button1.Text = "MENU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgcategoria
            // 
            this.dtgcategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgcategoria.Location = new System.Drawing.Point(94, 84);
            this.dtgcategoria.Margin = new System.Windows.Forms.Padding(2);
            this.dtgcategoria.Name = "dtgcategoria";
            this.dtgcategoria.RowHeadersWidth = 62;
            this.dtgcategoria.RowTemplate.Height = 28;
            this.dtgcategoria.Size = new System.Drawing.Size(314, 241);
            this.dtgcategoria.TabIndex = 26;
            this.dtgcategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgcategoria_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(417, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Nombre";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(547, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 20);
            this.textBox2.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(417, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Identificador";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(547, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(14, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = "Buscar";
            // 
            // txtbuscarcategoria
            // 
            this.txtbuscarcategoria.Location = new System.Drawing.Point(94, 64);
            this.txtbuscarcategoria.Name = "txtbuscarcategoria";
            this.txtbuscarcategoria.Size = new System.Drawing.Size(314, 20);
            this.txtbuscarcategoria.TabIndex = 40;
            this.txtbuscarcategoria.TextChanged += new System.EventHandler(this.txtbuscarcategoria_TextChanged);
            // 
            // TxtUsuarioLabel
            // 
            this.TxtUsuarioLabel.AutoSize = true;
            this.TxtUsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuarioLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtUsuarioLabel.Location = new System.Drawing.Point(641, 21);
            this.TxtUsuarioLabel.Name = "TxtUsuarioLabel";
            this.TxtUsuarioLabel.Size = new System.Drawing.Size(14, 20);
            this.TxtUsuarioLabel.TabIndex = 65;
            this.TxtUsuarioLabel.Text = ".";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(609, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(15, 20);
            this.dateTimePicker1.TabIndex = 64;
            this.dateTimePicker1.Visible = false;
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(740, 404);
            this.Controls.Add(this.TxtUsuarioLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtbuscarcategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AÑADIR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgcategoria);
            this.Name = "Categoria";
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.Categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgcategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AÑADIR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgcategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbuscarcategoria;
        private System.Windows.Forms.Label TxtUsuarioLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}