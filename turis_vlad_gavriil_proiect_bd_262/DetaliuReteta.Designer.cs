
namespace turis_vlad_gavriil_proiect_bd_262
{
    partial class DetaliuReteta
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
            this.iddetret = new System.Windows.Forms.Label();
            this.idreteta = new System.Windows.Forms.Label();
            this.idingredient = new System.Windows.Forms.Label();
            this.cantiate = new System.Windows.Forms.Label();
            this.idunitate = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Update_Ingredient = new System.Windows.Forms.Button();
            this.delete_Ingredient = new System.Windows.Forms.Button();
            this.RESET_Ingredient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // iddetret
            // 
            this.iddetret.AutoSize = true;
            this.iddetret.Location = new System.Drawing.Point(45, 43);
            this.iddetret.Name = "iddetret";
            this.iddetret.Size = new System.Drawing.Size(83, 13);
            this.iddetret.TabIndex = 0;
            this.iddetret.Text = "IDDetaliuReteta";
            // 
            // idreteta
            // 
            this.idreteta.AutoSize = true;
            this.idreteta.Location = new System.Drawing.Point(45, 82);
            this.idreteta.Name = "idreteta";
            this.idreteta.Size = new System.Drawing.Size(50, 13);
            this.idreteta.TabIndex = 1;
            this.idreteta.Text = "IDReteta";
            this.idreteta.Click += new System.EventHandler(this.label2_Click);
            // 
            // idingredient
            // 
            this.idingredient.AutoSize = true;
            this.idingredient.Location = new System.Drawing.Point(45, 120);
            this.idingredient.Name = "idingredient";
            this.idingredient.Size = new System.Drawing.Size(65, 13);
            this.idingredient.TabIndex = 2;
            this.idingredient.Text = "IDIngredient";
            // 
            // cantiate
            // 
            this.cantiate.AutoSize = true;
            this.cantiate.Location = new System.Drawing.Point(45, 165);
            this.cantiate.Name = "cantiate";
            this.cantiate.Size = new System.Drawing.Size(46, 13);
            this.cantiate.TabIndex = 3;
            this.cantiate.Text = "Cantiate";
            // 
            // idunitate
            // 
            this.idunitate.AutoSize = true;
            this.idunitate.Location = new System.Drawing.Point(45, 208);
            this.idunitate.Name = "idunitate";
            this.idunitate.Size = new System.Drawing.Size(87, 13);
            this.idunitate.TabIndex = 4;
            this.idunitate.Text = "IDUnitateMasura";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(144, 158);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(144, 205);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(456, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 269);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Update_Ingredient
            // 
            this.Update_Ingredient.Location = new System.Drawing.Point(126, 292);
            this.Update_Ingredient.Name = "Update_Ingredient";
            this.Update_Ingredient.Size = new System.Drawing.Size(75, 23);
            this.Update_Ingredient.TabIndex = 20;
            this.Update_Ingredient.Text = "UPDATE";
            this.Update_Ingredient.UseVisualStyleBackColor = true;
            this.Update_Ingredient.Click += new System.EventHandler(this.Update_Ingredient_Click);
            // 
            // delete_Ingredient
            // 
            this.delete_Ingredient.Location = new System.Drawing.Point(234, 292);
            this.delete_Ingredient.Name = "delete_Ingredient";
            this.delete_Ingredient.Size = new System.Drawing.Size(75, 23);
            this.delete_Ingredient.TabIndex = 21;
            this.delete_Ingredient.Text = "DELETE";
            this.delete_Ingredient.UseVisualStyleBackColor = true;
            this.delete_Ingredient.Click += new System.EventHandler(this.delete_Ingredient_Click);
            // 
            // RESET_Ingredient
            // 
            this.RESET_Ingredient.Location = new System.Drawing.Point(343, 292);
            this.RESET_Ingredient.Name = "RESET_Ingredient";
            this.RESET_Ingredient.Size = new System.Drawing.Size(84, 23);
            this.RESET_Ingredient.TabIndex = 24;
            this.RESET_Ingredient.Text = "RESET";
            this.RESET_Ingredient.UseVisualStyleBackColor = true;
            this.RESET_Ingredient.Click += new System.EventHandler(this.RESET_Ingredient_Click);
            // 
            // DetaliuReteta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 450);
            this.Controls.Add(this.RESET_Ingredient);
            this.Controls.Add(this.delete_Ingredient);
            this.Controls.Add(this.Update_Ingredient);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.idunitate);
            this.Controls.Add(this.cantiate);
            this.Controls.Add(this.idingredient);
            this.Controls.Add(this.idreteta);
            this.Controls.Add(this.iddetret);
            this.Name = "DetaliuReteta";
            this.Text = "DETALIURETETA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label iddetret;
        private System.Windows.Forms.Label idreteta;
        private System.Windows.Forms.Label idingredient;
        private System.Windows.Forms.Label cantiate;
        private System.Windows.Forms.Label idunitate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Update_Ingredient;
        private System.Windows.Forms.Button delete_Ingredient;
        private System.Windows.Forms.Button RESET_Ingredient;
    }
}