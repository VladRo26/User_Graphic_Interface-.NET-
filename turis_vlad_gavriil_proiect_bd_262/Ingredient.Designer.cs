
namespace turis_vlad_gavriil_proiect_bd_262
{
    partial class Ingredient
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
            this.IDIngredient = new System.Windows.Forms.Label();
            this.FurnizorID = new System.Windows.Forms.Label();
            this.text_IDIngredient = new System.Windows.Forms.TextBox();
            this.text_Nume = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nume = new System.Windows.Forms.Label();
            this.text_FurnizorID = new System.Windows.Forms.TextBox();
            this.INSERT_CLIENT = new System.Windows.Forms.Button();
            this.Update_Ingredient = new System.Windows.Forms.Button();
            this.delete_Ingredient = new System.Windows.Forms.Button();
            this.RESET_Ingredient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // IDIngredient
            // 
            this.IDIngredient.AutoSize = true;
            this.IDIngredient.Location = new System.Drawing.Point(69, 105);
            this.IDIngredient.Name = "IDIngredient";
            this.IDIngredient.Size = new System.Drawing.Size(65, 13);
            this.IDIngredient.TabIndex = 0;
            this.IDIngredient.Text = "IDIngredient";
            // 
            // FurnizorID
            // 
            this.FurnizorID.AutoSize = true;
            this.FurnizorID.Location = new System.Drawing.Point(69, 199);
            this.FurnizorID.Name = "FurnizorID";
            this.FurnizorID.Size = new System.Drawing.Size(55, 13);
            this.FurnizorID.TabIndex = 1;
            this.FurnizorID.Text = "FurnizorID";
            this.FurnizorID.Click += new System.EventHandler(this.label2_Click);
            // 
            // text_IDIngredient
            // 
            this.text_IDIngredient.Location = new System.Drawing.Point(174, 105);
            this.text_IDIngredient.Name = "text_IDIngredient";
            this.text_IDIngredient.Size = new System.Drawing.Size(100, 20);
            this.text_IDIngredient.TabIndex = 2;
            // 
            // text_Nume
            // 
            this.text_Nume.Location = new System.Drawing.Point(174, 150);
            this.text_Nume.Name = "text_Nume";
            this.text_Nume.Size = new System.Drawing.Size(100, 20);
            this.text_Nume.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(505, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 192);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Nume
            // 
            this.Nume.AutoSize = true;
            this.Nume.Location = new System.Drawing.Point(69, 150);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(35, 13);
            this.Nume.TabIndex = 5;
            this.Nume.Text = "Nume";
            // 
            // text_FurnizorID
            // 
            this.text_FurnizorID.Location = new System.Drawing.Point(174, 199);
            this.text_FurnizorID.Name = "text_FurnizorID";
            this.text_FurnizorID.Size = new System.Drawing.Size(100, 20);
            this.text_FurnizorID.TabIndex = 6;
            // 
            // INSERT_CLIENT
            // 
            this.INSERT_CLIENT.Location = new System.Drawing.Point(49, 285);
            this.INSERT_CLIENT.Name = "INSERT_CLIENT";
            this.INSERT_CLIENT.Size = new System.Drawing.Size(75, 23);
            this.INSERT_CLIENT.TabIndex = 15;
            this.INSERT_CLIENT.Text = "INSERT";
            this.INSERT_CLIENT.UseVisualStyleBackColor = true;
            this.INSERT_CLIENT.Click += new System.EventHandler(this.INSERT_CLIENT_Click);
            // 
            // Update_Ingredient
            // 
            this.Update_Ingredient.Location = new System.Drawing.Point(174, 285);
            this.Update_Ingredient.Name = "Update_Ingredient";
            this.Update_Ingredient.Size = new System.Drawing.Size(75, 23);
            this.Update_Ingredient.TabIndex = 16;
            this.Update_Ingredient.Text = "UPDATE";
            this.Update_Ingredient.UseVisualStyleBackColor = true;
            this.Update_Ingredient.Click += new System.EventHandler(this.Update_Ingredient_Click);
            // 
            // delete_Ingredient
            // 
            this.delete_Ingredient.Location = new System.Drawing.Point(292, 285);
            this.delete_Ingredient.Name = "delete_Ingredient";
            this.delete_Ingredient.Size = new System.Drawing.Size(75, 23);
            this.delete_Ingredient.TabIndex = 17;
            this.delete_Ingredient.Text = "DELETE";
            this.delete_Ingredient.UseVisualStyleBackColor = true;
            this.delete_Ingredient.Click += new System.EventHandler(this.delete_Ingredient_Click);
            // 
            // RESET_Ingredient
            // 
            this.RESET_Ingredient.Location = new System.Drawing.Point(415, 285);
            this.RESET_Ingredient.Name = "RESET_Ingredient";
            this.RESET_Ingredient.Size = new System.Drawing.Size(84, 23);
            this.RESET_Ingredient.TabIndex = 20;
            this.RESET_Ingredient.Text = "RESET";
            this.RESET_Ingredient.UseVisualStyleBackColor = true;
            this.RESET_Ingredient.Click += new System.EventHandler(this.RESET_Ingredient_Click);
            // 
            // Ingredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 502);
            this.Controls.Add(this.RESET_Ingredient);
            this.Controls.Add(this.delete_Ingredient);
            this.Controls.Add(this.Update_Ingredient);
            this.Controls.Add(this.INSERT_CLIENT);
            this.Controls.Add(this.text_FurnizorID);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.text_Nume);
            this.Controls.Add(this.text_IDIngredient);
            this.Controls.Add(this.FurnizorID);
            this.Controls.Add(this.IDIngredient);
            this.Name = "Ingredient";
            this.Text = "INGREDIENT";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDIngredient;
        private System.Windows.Forms.Label FurnizorID;
        private System.Windows.Forms.TextBox text_IDIngredient;
        private System.Windows.Forms.TextBox text_Nume;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.TextBox text_FurnizorID;
        private System.Windows.Forms.Button INSERT_CLIENT;
        private System.Windows.Forms.Button Update_Ingredient;
        private System.Windows.Forms.Button delete_Ingredient;
        private System.Windows.Forms.Button RESET_Ingredient;
    }
}