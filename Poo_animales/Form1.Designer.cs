
namespace Poo_animales
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombreA = new System.Windows.Forms.TextBox();
            this.edadA = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metodoA = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.respuesta1 = new System.Windows.Forms.Label();
            this.respuesta2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tipoAnimal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nombreA
            // 
            this.nombreA.Location = new System.Drawing.Point(147, 92);
            this.nombreA.Name = "nombreA";
            this.nombreA.Size = new System.Drawing.Size(100, 23);
            this.nombreA.TabIndex = 0;
            // 
            // edadA
            // 
            this.edadA.Location = new System.Drawing.Point(147, 130);
            this.edadA.Name = "edadA";
            this.edadA.Size = new System.Drawing.Size(100, 23);
            this.edadA.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "crear animal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Edad:";
            // 
            // metodoA
            // 
            this.metodoA.FormattingEnabled = true;
            this.metodoA.Items.AddRange(new object[] {
            "Comer",
            "Caminar"});
            this.metodoA.Location = new System.Drawing.Point(147, 168);
            this.metodoA.Name = "metodoA";
            this.metodoA.Size = new System.Drawing.Size(121, 23);
            this.metodoA.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datos";
            // 
            // respuesta1
            // 
            this.respuesta1.AutoSize = true;
            this.respuesta1.Location = new System.Drawing.Point(509, 256);
            this.respuesta1.Name = "respuesta1";
            this.respuesta1.Size = new System.Drawing.Size(33, 15);
            this.respuesta1.TabIndex = 7;
            this.respuesta1.Text = "text1";
            // 
            // respuesta2
            // 
            this.respuesta2.AutoSize = true;
            this.respuesta2.Location = new System.Drawing.Point(509, 284);
            this.respuesta2.Name = "respuesta2";
            this.respuesta2.Size = new System.Drawing.Size(40, 15);
            this.respuesta2.TabIndex = 8;
            this.respuesta2.Text = "texto2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Registro de datos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Metodo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "tipo animal";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tipoAnimal
            // 
            this.tipoAnimal.FormattingEnabled = true;
            this.tipoAnimal.Items.AddRange(new object[] {
            "Herbivoro",
            "Carnivoro"});
            this.tipoAnimal.Location = new System.Drawing.Point(147, 206);
            this.tipoAnimal.Name = "tipoAnimal";
            this.tipoAnimal.Size = new System.Drawing.Size(121, 23);
            this.tipoAnimal.TabIndex = 11;
            this.tipoAnimal.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tipoAnimal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.respuesta2);
            this.Controls.Add(this.respuesta1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.metodoA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edadA);
            this.Controls.Add(this.nombreA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreA;
        private System.Windows.Forms.TextBox edadA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox metodoA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label respuesta1;
        private System.Windows.Forms.Label respuesta2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tipoAnimal;
    }
}

