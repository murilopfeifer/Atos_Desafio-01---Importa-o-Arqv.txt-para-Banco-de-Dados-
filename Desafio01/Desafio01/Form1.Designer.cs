
namespace Desafio01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_readtxt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_mostraalunos = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_LookPeAl = new System.Windows.Forms.Button();
            this.btn_todos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_readtxt
            // 
            this.btn_readtxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_readtxt.ForeColor = System.Drawing.Color.Black;
            this.btn_readtxt.Location = new System.Drawing.Point(41, 73);
            this.btn_readtxt.Name = "btn_readtxt";
            this.btn_readtxt.Size = new System.Drawing.Size(158, 51);
            this.btn_readtxt.TabIndex = 0;
            this.btn_readtxt.Text = "Carregar Arquivo";
            this.btn_readtxt.UseVisualStyleBackColor = true;
            this.btn_readtxt.Click += new System.EventHandler(this.btn_readtxt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(216, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1364, 365);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_mostraalunos
            // 
            this.btn_mostraalunos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_mostraalunos.Location = new System.Drawing.Point(38, 225);
            this.btn_mostraalunos.Name = "btn_mostraalunos";
            this.btn_mostraalunos.Size = new System.Drawing.Size(158, 23);
            this.btn_mostraalunos.TabIndex = 3;
            this.btn_mostraalunos.Text = "Exibir Alunos";
            this.btn_mostraalunos.UseVisualStyleBackColor = true;
            this.btn_mostraalunos.Click += new System.EventHandler(this.btn_mostraalunos_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(41, 130);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(158, 23);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "Reset Carregamento";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_LookPeAl
            // 
            this.btn_LookPeAl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_LookPeAl.Location = new System.Drawing.Point(38, 196);
            this.btn_LookPeAl.Name = "btn_LookPeAl";
            this.btn_LookPeAl.Size = new System.Drawing.Size(158, 23);
            this.btn_LookPeAl.TabIndex = 4;
            this.btn_LookPeAl.Text = "Exibir Pessoas";
            this.btn_LookPeAl.UseVisualStyleBackColor = true;
            this.btn_LookPeAl.Click += new System.EventHandler(this.btn_LookPeAl_Click);
            // 
            // btn_todos
            // 
            this.btn_todos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_todos.Location = new System.Drawing.Point(38, 255);
            this.btn_todos.Name = "btn_todos";
            this.btn_todos.Size = new System.Drawing.Size(158, 23);
            this.btn_todos.TabIndex = 3;
            this.btn_todos.Text = "Exibir Todos";
            this.btn_todos.UseVisualStyleBackColor = true;
            this.btn_todos.Click += new System.EventHandler(this.btn_todos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(41, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Importação e Consultas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1679, 476);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_LookPeAl);
            this.Controls.Add(this.btn_todos);
            this.Controls.Add(this.btn_mostraalunos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_readtxt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_readtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_mostraalunos;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_LookPeAl;
        private System.Windows.Forms.Button btn_todos;
        private System.Windows.Forms.Label label1;
    }
}

