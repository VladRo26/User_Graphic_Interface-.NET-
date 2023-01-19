
namespace turis_vlad_gavriil_proiect_bd_262
{
    partial class Produs
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.Update_Ingredient = new System.Windows.Forms.Button();
            this.delete_Ingredient = new System.Windows.Forms.Button();
            this.RESET_Ingredient = new System.Windows.Forms.Button();
            this.textDataFinal = new System.Windows.Forms.TextBox();
            this.textDataComerci = new System.Windows.Forms.TextBox();
            this.textPretVanzare = new System.Windows.Forms.TextBox();
            this.textCostProd = new System.Windows.Forms.TextBox();
            this.text_Nume = new System.Windows.Forms.TextBox();
            this.text_IDProd = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IDProdus";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CostProductie";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "PretVanzare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "IDCategorieProdus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "InceputDataComercializare";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "SfarsitDataComercializare";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(622, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 295);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(346, 265);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(346, 305);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 9;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Update_Ingredient
            // 
            this.Update_Ingredient.Location = new System.Drawing.Point(197, 363);
            this.Update_Ingredient.Name = "Update_Ingredient";
            this.Update_Ingredient.Size = new System.Drawing.Size(75, 23);
            this.Update_Ingredient.TabIndex = 19;
            this.Update_Ingredient.Text = "UPDATE";
            this.Update_Ingredient.UseVisualStyleBackColor = true;
            this.Update_Ingredient.Click += new System.EventHandler(this.Update_Ingredient_Click);
            // 
            // delete_Ingredient
            // 
            this.delete_Ingredient.Location = new System.Drawing.Point(322, 363);
            this.delete_Ingredient.Name = "delete_Ingredient";
            this.delete_Ingredient.Size = new System.Drawing.Size(75, 23);
            this.delete_Ingredient.TabIndex = 20;
            this.delete_Ingredient.Text = "DELETE";
            this.delete_Ingredient.UseVisualStyleBackColor = true;
            this.delete_Ingredient.Click += new System.EventHandler(this.delete_Ingredient_Click);
            // 
            // RESET_Ingredient
            // 
            this.RESET_Ingredient.Location = new System.Drawing.Point(462, 363);
            this.RESET_Ingredient.Name = "RESET_Ingredient";
            this.RESET_Ingredient.Size = new System.Drawing.Size(84, 23);
            this.RESET_Ingredient.TabIndex = 23;
            this.RESET_Ingredient.Text = "RESET";
            this.RESET_Ingredient.UseVisualStyleBackColor = true;
            this.RESET_Ingredient.Click += new System.EventHandler(this.RESET_Ingredient_Click);
            // 
            // textDataFinal
            // 
            this.textDataFinal.Location = new System.Drawing.Point(172, 312);
            this.textDataFinal.Name = "textDataFinal";
            this.textDataFinal.Size = new System.Drawing.Size(100, 20);
            this.textDataFinal.TabIndex = 24;
            this.textDataFinal.TextChanged += new System.EventHandler(this.textDataFinal_TextChanged);
            // 
            // textDataComerci
            // 
            this.textDataComerci.Location = new System.Drawing.Point(172, 262);
            this.textDataComerci.Name = "textDataComerci";
            this.textDataComerci.Size = new System.Drawing.Size(100, 20);
            this.textDataComerci.TabIndex = 25;
            // 
            // textPretVanzare
            // 
            this.textPretVanzare.Location = new System.Drawing.Point(172, 195);
            this.textPretVanzare.Name = "textPretVanzare";
            this.textPretVanzare.Size = new System.Drawing.Size(100, 20);
            this.textPretVanzare.TabIndex = 27;
            // 
            // textCostProd
            // 
            this.textCostProd.Location = new System.Drawing.Point(172, 158);
            this.textCostProd.Name = "textCostProd";
            this.textCostProd.Size = new System.Drawing.Size(100, 20);
            this.textCostProd.TabIndex = 28;
            // 
            // text_Nume
            // 
            this.text_Nume.Location = new System.Drawing.Point(172, 118);
            this.text_Nume.Name = "text_Nume";
            this.text_Nume.Size = new System.Drawing.Size(100, 20);
            this.text_Nume.TabIndex = 29;
            // 
            // text_IDProd
            // 
            this.text_IDProd.Location = new System.Drawing.Point(172, 78);
            this.text_IDProd.Name = "text_IDProd";
            this.text_IDProd.Size = new System.Drawing.Size(100, 20);
            this.text_IDProd.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 31;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Produs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 476);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.text_IDProd);
            this.Controls.Add(this.text_Nume);
            this.Controls.Add(this.textCostProd);
            this.Controls.Add(this.textPretVanzare);
            this.Controls.Add(this.textDataComerci);
            this.Controls.Add(this.textDataFinal);
            this.Controls.Add(this.RESET_Ingredient);
            this.Controls.Add(this.delete_Ingredient);
            this.Controls.Add(this.Update_Ingredient);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Produs";
            this.Text = "PRODUS";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Update_Ingredient;
        private System.Windows.Forms.Button delete_Ingredient;
        private System.Windows.Forms.Button RESET_Ingredient;
        private System.Windows.Forms.TextBox textDataFinal;
        private System.Windows.Forms.TextBox textDataComerci;
        private System.Windows.Forms.TextBox textPretVanzare;
        private System.Windows.Forms.TextBox textCostProd;
        private System.Windows.Forms.TextBox text_Nume;
        private System.Windows.Forms.TextBox text_IDProd;
        private System.Windows.Forms.TextBox textBox1;
    }
}