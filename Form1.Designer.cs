
namespace CalculadoradeFiguras
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLadoCuadrado = new System.Windows.Forms.TextBox();
            this.btnCalcularCuadrado = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPerimetroCuadrado = new System.Windows.Forms.TextBox();
            this.txtAreaCuadrado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBaseRectangulo = new System.Windows.Forms.TextBox();
            this.txtAlturaRectangulo = new System.Windows.Forms.TextBox();
            this.btnCalcularRectangulo = new System.Windows.Forms.Button();
            this.txtAreaRectangulo = new System.Windows.Forms.TextBox();
            this.txtPerimetroRectangulo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAreaTriangulo = new System.Windows.Forms.TextBox();
            this.txtPerimetroTriangulo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCalcularTriangulo = new System.Windows.Forms.Button();
            this.txtAlturaTriangulo = new System.Windows.Forms.TextBox();
            this.txtBaseTriangulo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAreaCuadrado);
            this.groupBox1.Controls.Add(this.txtPerimetroCuadrado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCalcularCuadrado);
            this.groupBox1.Controls.Add(this.txtLadoCuadrado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(-7, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 456);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuadrado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAreaRectangulo);
            this.groupBox2.Controls.Add(this.txtPerimetroRectangulo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnCalcularRectangulo);
            this.groupBox2.Controls.Add(this.txtAlturaRectangulo);
            this.groupBox2.Controls.Add(this.txtBaseRectangulo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(269, -3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 456);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rectángulo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAreaTriangulo);
            this.groupBox3.Controls.Add(this.txtPerimetroTriangulo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnCalcularTriangulo);
            this.groupBox3.Controls.Add(this.txtAlturaTriangulo);
            this.groupBox3.Controls.Add(this.txtBaseTriangulo);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(537, -3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 456);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Triángulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado:";
            // 
            // txtLadoCuadrado
            // 
            this.txtLadoCuadrado.Location = new System.Drawing.Point(33, 90);
            this.txtLadoCuadrado.Name = "txtLadoCuadrado";
            this.txtLadoCuadrado.Size = new System.Drawing.Size(100, 22);
            this.txtLadoCuadrado.TabIndex = 1;
            // 
            // btnCalcularCuadrado
            // 
            this.btnCalcularCuadrado.Location = new System.Drawing.Point(58, 178);
            this.btnCalcularCuadrado.Name = "btnCalcularCuadrado";
            this.btnCalcularCuadrado.Size = new System.Drawing.Size(98, 23);
            this.btnCalcularCuadrado.TabIndex = 2;
            this.btnCalcularCuadrado.Text = "Calcular";
            this.btnCalcularCuadrado.UseVisualStyleBackColor = true;
            this.btnCalcularCuadrado.Click += new System.EventHandler(this.btnCalcularCuadrado_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Perímetro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Área";
            // 
            // txtPerimetroCuadrado
            // 
            this.txtPerimetroCuadrado.Location = new System.Drawing.Point(110, 253);
            this.txtPerimetroCuadrado.Name = "txtPerimetroCuadrado";
            this.txtPerimetroCuadrado.Size = new System.Drawing.Size(100, 22);
            this.txtPerimetroCuadrado.TabIndex = 5;
            // 
            // txtAreaCuadrado
            // 
            this.txtAreaCuadrado.Location = new System.Drawing.Point(110, 292);
            this.txtAreaCuadrado.Name = "txtAreaCuadrado";
            this.txtAreaCuadrado.Size = new System.Drawing.Size(100, 22);
            this.txtAreaCuadrado.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Base:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Altura:";
            // 
            // txtBaseRectangulo
            // 
            this.txtBaseRectangulo.Location = new System.Drawing.Point(81, 55);
            this.txtBaseRectangulo.Name = "txtBaseRectangulo";
            this.txtBaseRectangulo.Size = new System.Drawing.Size(100, 22);
            this.txtBaseRectangulo.TabIndex = 3;
            // 
            // txtAlturaRectangulo
            // 
            this.txtAlturaRectangulo.Location = new System.Drawing.Point(91, 112);
            this.txtAlturaRectangulo.Name = "txtAlturaRectangulo";
            this.txtAlturaRectangulo.Size = new System.Drawing.Size(100, 22);
            this.txtAlturaRectangulo.TabIndex = 4;
            // 
            // btnCalcularRectangulo
            // 
            this.btnCalcularRectangulo.Location = new System.Drawing.Point(68, 178);
            this.btnCalcularRectangulo.Name = "btnCalcularRectangulo";
            this.btnCalcularRectangulo.Size = new System.Drawing.Size(98, 23);
            this.btnCalcularRectangulo.TabIndex = 5;
            this.btnCalcularRectangulo.Text = "Calcular";
            this.btnCalcularRectangulo.UseVisualStyleBackColor = true;
            this.btnCalcularRectangulo.Click += new System.EventHandler(this.btnCalcularRectangulo_Click);
            // 
            // txtAreaRectangulo
            // 
            this.txtAreaRectangulo.Location = new System.Drawing.Point(109, 289);
            this.txtAreaRectangulo.Name = "txtAreaRectangulo";
            this.txtAreaRectangulo.Size = new System.Drawing.Size(100, 22);
            this.txtAreaRectangulo.TabIndex = 10;
            // 
            // txtPerimetroRectangulo
            // 
            this.txtPerimetroRectangulo.Location = new System.Drawing.Point(109, 250);
            this.txtPerimetroRectangulo.Name = "txtPerimetroRectangulo";
            this.txtPerimetroRectangulo.Size = new System.Drawing.Size(100, 22);
            this.txtPerimetroRectangulo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Área";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Perímetro";
            // 
            // txtAreaTriangulo
            // 
            this.txtAreaTriangulo.Location = new System.Drawing.Point(117, 289);
            this.txtAreaTriangulo.Name = "txtAreaTriangulo";
            this.txtAreaTriangulo.Size = new System.Drawing.Size(100, 22);
            this.txtAreaTriangulo.TabIndex = 19;
            // 
            // txtPerimetroTriangulo
            // 
            this.txtPerimetroTriangulo.Location = new System.Drawing.Point(117, 250);
            this.txtPerimetroTriangulo.Name = "txtPerimetroTriangulo";
            this.txtPerimetroTriangulo.Size = new System.Drawing.Size(100, 22);
            this.txtPerimetroTriangulo.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Área";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Perímetro";
            // 
            // btnCalcularTriangulo
            // 
            this.btnCalcularTriangulo.Location = new System.Drawing.Point(76, 178);
            this.btnCalcularTriangulo.Name = "btnCalcularTriangulo";
            this.btnCalcularTriangulo.Size = new System.Drawing.Size(98, 23);
            this.btnCalcularTriangulo.TabIndex = 15;
            this.btnCalcularTriangulo.Text = "Calcular";
            this.btnCalcularTriangulo.UseVisualStyleBackColor = true;
            this.btnCalcularTriangulo.Click += new System.EventHandler(this.btnCalcularTriangulo_Click);
            // 
            // txtAlturaTriangulo
            // 
            this.txtAlturaTriangulo.Location = new System.Drawing.Point(99, 112);
            this.txtAlturaTriangulo.Name = "txtAlturaTriangulo";
            this.txtAlturaTriangulo.Size = new System.Drawing.Size(100, 22);
            this.txtAlturaTriangulo.TabIndex = 14;
            // 
            // txtBaseTriangulo
            // 
            this.txtBaseTriangulo.Location = new System.Drawing.Point(89, 55);
            this.txtBaseTriangulo.Name = "txtBaseTriangulo";
            this.txtBaseTriangulo.Size = new System.Drawing.Size(100, 22);
            this.txtBaseTriangulo.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Altura:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Base:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAreaCuadrado;
        private System.Windows.Forms.TextBox txtPerimetroCuadrado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcularCuadrado;
        private System.Windows.Forms.TextBox txtLadoCuadrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAreaRectangulo;
        private System.Windows.Forms.TextBox txtPerimetroRectangulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalcularRectangulo;
        private System.Windows.Forms.TextBox txtAlturaRectangulo;
        private System.Windows.Forms.TextBox txtBaseRectangulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAreaTriangulo;
        private System.Windows.Forms.TextBox txtPerimetroTriangulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCalcularTriangulo;
        private System.Windows.Forms.TextBox txtAlturaTriangulo;
        private System.Windows.Forms.TextBox txtBaseTriangulo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

