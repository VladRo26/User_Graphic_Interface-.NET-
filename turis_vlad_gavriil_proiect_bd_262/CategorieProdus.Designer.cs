
namespace turis_vlad_gavriil_proiect_bd_262
{
    partial class CategorieProdus
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
            this.IDCategorieProdus = new System.Windows.Forms.Label();
            this.Nume = new System.Windows.Forms.Label();
            this.text_IDCategorie = new System.Windows.Forms.TextBox();
            this.text_Nume = new System.Windows.Forms.TextBox();
            this.INSERT_CLIENT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Update_Ingredient = new System.Windows.Forms.Button();
            this.delete_Ingredient = new System.Windows.Forms.Button();
            this.RESET_Ingredient = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // IDCategorieProdus
            // 
            this.IDCategorieProdus.AutoSize = true;
            this.IDCategorieProdus.Location = new System.Drawing.Point(51, 72);
            this.IDCategorieProdus.Name = "IDCategorieProdus";
            this.IDCategorieProdus.Size = new System.Drawing.Size(96, 13);
            this.IDCategorieProdus.TabIndex = 0;
            this.IDCategorieProdus.Text = "IDCategorieProdus";
            this.IDCategorieProdus.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nume
            // 
            this.Nume.AutoSize = true;
            this.Nume.Location = new System.Drawing.Point(51, 121);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(35, 13);
            this.Nume.TabIndex = 1;
            this.Nume.Text = "Nume";
            // 
            // text_IDCategorie
            // 
            this.text_IDCategorie.Location = new System.Drawing.Point(200, 69);
            this.text_IDCategorie.Name = "text_IDCategorie";
            this.text_IDCategorie.Size = new System.Drawing.Size(100, 20);
            this.text_IDCategorie.TabIndex = 3;
            // 
            // text_Nume
            // 
            this.text_Nume.Location = new System.Drawing.Point(200, 121);
            this.text_Nume.Name = "text_Nume";
            this.text_Nume.Size = new System.Drawing.Size(100, 20);
            this.text_Nume.TabIndex = 4;
            // 
            // INSERT_CLIENT
            // 
            this.INSERT_CLIENT.Location = new System.Drawing.Point(49, 285);
            this.INSERT_CLIENT.Name = "INSERT_CLIENT";
            this.INSERT_CLIENT.Size = new System.Drawing.Size(75, 23);
            this.INSERT_CLIENT.TabIndex = 15;
            this.INSERT_CLIENT.Text = "INSERT";
            this.INSERT_CLIENT.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Update_Ingredient
            // 
            this.Update_Ingredient.Location = new System.Drawing.Point(175, 229);
            this.Update_Ingredient.Name = "Update_Ingredient";
            this.Update_Ingredient.Size = new System.Drawing.Size(75, 23);
            this.Update_Ingredient.TabIndex = 17;
            this.Update_Ingredient.Text = "UPDATE";
            this.Update_Ingredient.UseVisualStyleBackColor = true;
            this.Update_Ingredient.Click += new System.EventHandler(this.Update_Ingredient_Click);
            // 
            // delete_Ingredient
            // 
            this.delete_Ingredient.Location = new System.Drawing.Point(306, 229);
            this.delete_Ingredient.Name = "delete_Ingredient";
            this.delete_Ingredient.Size = new System.Drawing.Size(75, 23);
            this.delete_Ingredient.TabIndex = 18;
            this.delete_Ingredient.Text = "DELETE";
            this.delete_Ingredient.UseVisualStyleBackColor = true;
            this.delete_Ingredient.Click += new System.EventHandler(this.delete_Ingredient_Click);
            // 
            // RESET_Ingredient
            // 
            this.RESET_Ingredient.Location = new System.Drawing.Point(421, 229);
            this.RESET_Ingredient.Name = "RESET_Ingredient";
            this.RESET_Ingredient.Size = new System.Drawing.Size(84, 23);
            this.RESET_Ingredient.TabIndex = 21;
            this.RESET_Ingredient.Text = "RESET";
            this.RESET_Ingredient.UseVisualStyleBackColor = true;
            this.RESET_Ingredient.Click += new System.EventHandler(this.RESET_Ingredient_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(563, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 248);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // CategorieProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 505);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RESET_Ingredient);
            this.Controls.Add(this.delete_Ingredient);
            this.Controls.Add(this.Update_Ingredient);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_Nume);
            this.Controls.Add(this.text_IDCategorie);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.IDCategorieProdus);
            this.Name = "CategorieProdus";
            this.Text = "CATEGORIEPRODUS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDCategorieProdus;
        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.TextBox text_IDCategorie;
        private System.Windows.Forms.TextBox text_Nume;
        private System.Windows.Forms.Button INSERT_CLIENT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Update_Ingredient;
        private System.Windows.Forms.Button delete_Ingredient;
        private System.Windows.Forms.Button RESET_Ingredient;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}