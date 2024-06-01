namespace Proyecto_Final_Semestre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1_buscar = new System.Windows.Forms.Button();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_fecha_estreno = new System.Windows.Forms.Label();
            this.label_duracion = new System.Windows.Forms.Label();
            this.label_categoria = new System.Windows.Forms.Label();
            this.label_Presupuesto = new System.Windows.Forms.Label();
            this.label_clasificacion = new System.Windows.Forms.Label();
            this.textBox1_duracion = new System.Windows.Forms.TextBox();
            this.textBox1_categoria = new System.Windows.Forms.TextBox();
            this.textBox1_presupuesto = new System.Windows.Forms.TextBox();
            this.textBox1_clasificacion = new System.Windows.Forms.TextBox();
            this.button1_cargar = new System.Windows.Forms.Button();
            this.button1_agregar = new System.Windows.Forms.Button();
            this.button1_actualizar = new System.Windows.Forms.Button();
            this.button1_borrar = new System.Windows.Forms.Button();
            this.dataGridView1_tabla = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1_fecha_estreno = new System.Windows.Forms.DateTimePicker();
            this.comboBox1_categoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_buscar
            // 
            this.button1_buscar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1_buscar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_buscar.Location = new System.Drawing.Point(131, 282);
            this.button1_buscar.Name = "button1_buscar";
            this.button1_buscar.Size = new System.Drawing.Size(113, 34);
            this.button1_buscar.TabIndex = 0;
            this.button1_buscar.Text = "Buscar por ID";
            this.button1_buscar.UseVisualStyleBackColor = false;
            this.button1_buscar.Click += new System.EventHandler(this.button1_buscar_Click);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label_id.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_id.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(341, 17);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(27, 22);
            this.label_id.TabIndex = 1;
            this.label_id.Text = "ID:";
            this.label_id.Click += new System.EventHandler(this.label_id_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_id.Location = new System.Drawing.Point(465, 19);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(240, 20);
            this.textBox_id.TabIndex = 2;
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_nombre.Location = new System.Drawing.Point(465, 47);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(240, 20);
            this.textBox_nombre.TabIndex = 3;
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label_nombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_nombre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.Location = new System.Drawing.Point(339, 47);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(60, 22);
            this.label_nombre.TabIndex = 4;
            this.label_nombre.Text = "Nombre:";
            // 
            // label_fecha_estreno
            // 
            this.label_fecha_estreno.AutoSize = true;
            this.label_fecha_estreno.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label_fecha_estreno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_fecha_estreno.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha_estreno.Location = new System.Drawing.Point(341, 73);
            this.label_fecha_estreno.Name = "label_fecha_estreno";
            this.label_fecha_estreno.Size = new System.Drawing.Size(118, 22);
            this.label_fecha_estreno.TabIndex = 5;
            this.label_fecha_estreno.Text = "Fecha de Estreno:";
            // 
            // label_duracion
            // 
            this.label_duracion.AutoSize = true;
            this.label_duracion.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label_duracion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_duracion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_duracion.Location = new System.Drawing.Point(341, 99);
            this.label_duracion.Name = "label_duracion";
            this.label_duracion.Size = new System.Drawing.Size(66, 22);
            this.label_duracion.TabIndex = 6;
            this.label_duracion.Text = "Duración:";
            // 
            // label_categoria
            // 
            this.label_categoria.AutoSize = true;
            this.label_categoria.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label_categoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_categoria.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_categoria.Location = new System.Drawing.Point(344, 125);
            this.label_categoria.Name = "label_categoria";
            this.label_categoria.Size = new System.Drawing.Size(71, 22);
            this.label_categoria.TabIndex = 7;
            this.label_categoria.Text = "Categoría:";
            // 
            // label_Presupuesto
            // 
            this.label_Presupuesto.AutoSize = true;
            this.label_Presupuesto.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label_Presupuesto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Presupuesto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Presupuesto.Location = new System.Drawing.Point(344, 152);
            this.label_Presupuesto.Name = "label_Presupuesto";
            this.label_Presupuesto.Size = new System.Drawing.Size(88, 22);
            this.label_Presupuesto.TabIndex = 8;
            this.label_Presupuesto.Text = "Presupuesto:";
            // 
            // label_clasificacion
            // 
            this.label_clasificacion.AutoSize = true;
            this.label_clasificacion.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label_clasificacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_clasificacion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_clasificacion.Location = new System.Drawing.Point(344, 178);
            this.label_clasificacion.Name = "label_clasificacion";
            this.label_clasificacion.Size = new System.Drawing.Size(89, 22);
            this.label_clasificacion.TabIndex = 9;
            this.label_clasificacion.Text = "Clasificación:";
            // 
            // textBox1_duracion
            // 
            this.textBox1_duracion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1_duracion.Location = new System.Drawing.Point(465, 99);
            this.textBox1_duracion.Name = "textBox1_duracion";
            this.textBox1_duracion.Size = new System.Drawing.Size(240, 20);
            this.textBox1_duracion.TabIndex = 11;
            // 
            // textBox1_categoria
            // 
            this.textBox1_categoria.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1_categoria.Location = new System.Drawing.Point(465, 125);
            this.textBox1_categoria.Name = "textBox1_categoria";
            this.textBox1_categoria.Size = new System.Drawing.Size(240, 20);
            this.textBox1_categoria.TabIndex = 12;
            this.textBox1_categoria.TextChanged += new System.EventHandler(this.textBox1_categoria_TextChanged);
            // 
            // textBox1_presupuesto
            // 
            this.textBox1_presupuesto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1_presupuesto.Location = new System.Drawing.Point(465, 152);
            this.textBox1_presupuesto.Name = "textBox1_presupuesto";
            this.textBox1_presupuesto.Size = new System.Drawing.Size(240, 20);
            this.textBox1_presupuesto.TabIndex = 13;
            // 
            // textBox1_clasificacion
            // 
            this.textBox1_clasificacion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1_clasificacion.Location = new System.Drawing.Point(465, 178);
            this.textBox1_clasificacion.Name = "textBox1_clasificacion";
            this.textBox1_clasificacion.ReadOnly = true;
            this.textBox1_clasificacion.Size = new System.Drawing.Size(240, 20);
            this.textBox1_clasificacion.TabIndex = 14;
            // 
            // button1_cargar
            // 
            this.button1_cargar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1_cargar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_cargar.Location = new System.Drawing.Point(12, 282);
            this.button1_cargar.Name = "button1_cargar";
            this.button1_cargar.Size = new System.Drawing.Size(113, 34);
            this.button1_cargar.TabIndex = 15;
            this.button1_cargar.Text = "Cargar";
            this.button1_cargar.UseVisualStyleBackColor = false;
            this.button1_cargar.Click += new System.EventHandler(this.button1_cargar_Click);
            // 
            // button1_agregar
            // 
            this.button1_agregar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1_agregar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_agregar.Location = new System.Drawing.Point(250, 282);
            this.button1_agregar.Name = "button1_agregar";
            this.button1_agregar.Size = new System.Drawing.Size(113, 34);
            this.button1_agregar.TabIndex = 16;
            this.button1_agregar.Text = "Agregar";
            this.button1_agregar.UseVisualStyleBackColor = false;
            this.button1_agregar.Click += new System.EventHandler(this.button1_agregar_Click);
            // 
            // button1_actualizar
            // 
            this.button1_actualizar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1_actualizar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_actualizar.Location = new System.Drawing.Point(488, 282);
            this.button1_actualizar.Name = "button1_actualizar";
            this.button1_actualizar.Size = new System.Drawing.Size(113, 34);
            this.button1_actualizar.TabIndex = 17;
            this.button1_actualizar.Text = "Actualizar";
            this.button1_actualizar.UseVisualStyleBackColor = false;
            this.button1_actualizar.Click += new System.EventHandler(this.button1_actualizar_Click);
            // 
            // button1_borrar
            // 
            this.button1_borrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1_borrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_borrar.Location = new System.Drawing.Point(369, 282);
            this.button1_borrar.Name = "button1_borrar";
            this.button1_borrar.Size = new System.Drawing.Size(113, 34);
            this.button1_borrar.TabIndex = 18;
            this.button1_borrar.Text = "Borrar";
            this.button1_borrar.UseVisualStyleBackColor = false;
            this.button1_borrar.Click += new System.EventHandler(this.button1_borrar_Click);
            // 
            // dataGridView1_tabla
            // 
            this.dataGridView1_tabla.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_tabla.Location = new System.Drawing.Point(3, 322);
            this.dataGridView1_tabla.Name = "dataGridView1_tabla";
            this.dataGridView1_tabla.Size = new System.Drawing.Size(721, 144);
            this.dataGridView1_tabla.TabIndex = 19;
            // 
            // dateTimePicker1_fecha_estreno
            // 
            this.dateTimePicker1_fecha_estreno.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dateTimePicker1_fecha_estreno.Location = new System.Drawing.Point(465, 72);
            this.dateTimePicker1_fecha_estreno.Name = "dateTimePicker1_fecha_estreno";
            this.dateTimePicker1_fecha_estreno.Size = new System.Drawing.Size(240, 20);
            this.dateTimePicker1_fecha_estreno.TabIndex = 20;
            // 
            // comboBox1_categoria
            // 
            this.comboBox1_categoria.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1_categoria.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1_categoria.FormattingEnabled = true;
            this.comboBox1_categoria.Location = new System.Drawing.Point(465, 204);
            this.comboBox1_categoria.Name = "comboBox1_categoria";
            this.comboBox1_categoria.Size = new System.Drawing.Size(121, 24);
            this.comboBox1_categoria.TabIndex = 21;
            this.comboBox1_categoria.Text = "Calificación";
            this.comboBox1_categoria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_categoria_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(727, 478);
            this.Controls.Add(this.comboBox1_categoria);
            this.Controls.Add(this.dateTimePicker1_fecha_estreno);
            this.Controls.Add(this.dataGridView1_tabla);
            this.Controls.Add(this.button1_borrar);
            this.Controls.Add(this.button1_actualizar);
            this.Controls.Add(this.button1_agregar);
            this.Controls.Add(this.button1_cargar);
            this.Controls.Add(this.textBox1_clasificacion);
            this.Controls.Add(this.textBox1_presupuesto);
            this.Controls.Add(this.textBox1_categoria);
            this.Controls.Add(this.textBox1_duracion);
            this.Controls.Add(this.label_clasificacion);
            this.Controls.Add(this.label_Presupuesto);
            this.Controls.Add(this.label_categoria);
            this.Controls.Add(this.label_duracion);
            this.Controls.Add(this.label_fecha_estreno);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.button1_buscar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_buscar;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_fecha_estreno;
        private System.Windows.Forms.Label label_duracion;
        private System.Windows.Forms.Label label_categoria;
        private System.Windows.Forms.Label label_Presupuesto;
        private System.Windows.Forms.Label label_clasificacion;
        private System.Windows.Forms.TextBox textBox1_duracion;
        private System.Windows.Forms.TextBox textBox1_categoria;
        private System.Windows.Forms.TextBox textBox1_presupuesto;
        private System.Windows.Forms.TextBox textBox1_clasificacion;
        private System.Windows.Forms.Button button1_cargar;
        private System.Windows.Forms.Button button1_agregar;
        private System.Windows.Forms.Button button1_actualizar;
        private System.Windows.Forms.Button button1_borrar;
        private System.Windows.Forms.DataGridView dataGridView1_tabla;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_fecha_estreno;
        private System.Windows.Forms.ComboBox comboBox1_categoria;
    }
}

