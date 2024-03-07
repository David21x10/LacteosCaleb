namespace LacteosCaleb
{
    partial class FrmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.label1 = new System.Windows.Forms.Label();
            this.dtginvent = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.AÑADIR = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbuscarproducto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtginvent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(58, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // dtginvent
            // 
            this.dtginvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtginvent.Location = new System.Drawing.Point(11, 110);
            this.dtginvent.Margin = new System.Windows.Forms.Padding(2);
            this.dtginvent.Name = "dtginvent";
            this.dtginvent.RowHeadersWidth = 62;
            this.dtginvent.RowTemplate.Height = 28;
            this.dtginvent.Size = new System.Drawing.Size(606, 168);
            this.dtginvent.TabIndex = 1;
            this.dtginvent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(556, 284);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "MENU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AÑADIR
            // 
            this.AÑADIR.AutoSize = true;
            this.AÑADIR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AÑADIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AÑADIR.Location = new System.Drawing.Point(11, 294);
            this.AÑADIR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AÑADIR.Name = "AÑADIR";
            this.AÑADIR.Size = new System.Drawing.Size(57, 15);
            this.AÑADIR.TabIndex = 23;
            this.AÑADIR.Text = "AÑADIR";
            this.AÑADIR.Click += new System.EventHandler(this.AÑADIR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 294);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "EDITAR";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "ELIMINAR";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(622, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Identificador";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(752, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(622, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Nombre";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(752, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(274, 20);
            this.textBox2.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(622, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Descripcion";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(752, 202);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(274, 107);
            this.textBox3.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(622, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Precio";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(752, 327);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(274, 20);
            this.textBox4.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(622, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Categoria";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(752, 410);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(274, 20);
            this.textBox6.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(622, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Estado";
            // 
            // txtbuscarproducto
            // 
            this.txtbuscarproducto.Location = new System.Drawing.Point(105, 25);
            this.txtbuscarproducto.Name = "txtbuscarproducto";
            this.txtbuscarproducto.Size = new System.Drawing.Size(352, 20);
            this.txtbuscarproducto.TabIndex = 38;
            this.txtbuscarproducto.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(25, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "Buscar";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(752, 370);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 40;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1038, 443);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtbuscarproducto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AÑADIR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtginvent);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtginvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtginvent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label AÑADIR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbuscarproducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}