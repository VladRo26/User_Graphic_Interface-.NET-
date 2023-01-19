
namespace turis_vlad_gavriil_proiect_bd_262
{
    partial class UnitateMasura
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
            this.IDUnitateMasura = new System.Windows.Forms.Label();
            this.Nume = new System.Windows.Forms.Label();
            this.textIDNume = new System.Windows.Forms.TextBox();
            this.text_IDunitate = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Update_Ingredient = new System.Windows.Forms.Button();
            this.delete_Ingredient = new System.Windows.Forms.Button();
            this.RESET_Ingredient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // IDUnitateMasura
            // 
            this.IDUnitateMasura.AutoSize = true;
            this.IDUnitateMasura.Location = new System.Drawing.Point(63, 95);
            this.IDUnitateMasura.Name = "IDUnitateMasura";
            this.IDUnitateMasura.Size = new System.Drawing.Size(87, 13);
            this.IDUnitateMasura.TabIndex = 0;
            this.IDUnitateMasura.Text = "IDUnitateMasura";
            // 
            // Nume
            // 
            this.Nume.AutoSize = true;
            this.Nume.Location = new System.Drawing.Point(63, 142);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(35, 13);
            this.Nume.TabIndex = 1;
            this.Nume.Text = "Nume";
            // 
            // textIDNume
            // 
            this.textIDNume.Location = new System.Drawing.Point(160, 139);
            this.textIDNume.Name = "textIDNume";
            this.textIDNume.Size = new System.Drawing.Size(100, 20);
            this.textIDNume.TabIndex = 2;
            // 
            // text_IDunitate
            // 
            this.text_IDunitate.Location = new System.Drawing.Point(160, 95);
            this.text_IDunitate.Name = "text_IDunitate";
            this.text_IDunitate.Size = new System.Drawing.Size(100, 20);
            this.text_IDunitate.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(551, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(421, 293);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Update_Ingredient
            // 
            this.Update_Ingredient.Location = new System.Drawing.Point(137, 251);
            this.Update_Ingredient.Name = "Update_Ingredient";
            this.Update_Ingredient.Size = new System.Drawing.Size(75, 23);
            this.Update_Ingredient.TabIndex = 18;
            this.Update_Ingredient.Text = "UPDATE";
            this.Update_Ingredient.UseVisualStyleBackColor = true;
            this.Update_Ingredient.Click += new System.EventHandler(this.Update_Ingredient_Click);
            // 
            // delete_Ingredient
            // 
            this.delete_Ingredient.Location = new System.Drawing.Point(255, 251);
            this.delete_Ingredient.Name = "delete_Ingredient";
            this.delete_Ingredient.Size = new System.Drawing.Size(75, 23);
            this.delete_Ingredient.TabIndex = 19;
            this.delete_Ingredient.Text = "DELETE";
            this.delete_Ingredient.UseVisualStyleBackColor = true;
            this.delete_Ingredient.Click += new System.EventHandler(this.delete_Ingredient_Click);
            // 
            // RESET_Ingredient
            // 
            this.RESET_Ingredient.Location = new System.Drawing.Point(376, 251);
            this.RESET_Ingredient.Name = "RESET_Ingredient";
            this.RESET_Ingredient.Size = new System.Drawing.Size(84, 23);
            this.RESET_Ingredient.TabIndex = 22;
            this.RESET_Ingredient.Text = "RESET";
            this.RESET_Ingredient.UseVisualStyleBackColor = true;
            this.RESET_Ingredient.Click += new System.EventHandler(this.RESET_Ingredient_Click);
            // 
            // UnitateMasura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.RESET_Ingredient);
            this.Controls.Add(this.delete_Ingredient);
            this.Controls.Add(this.Update_Ingredient);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.text_IDunitate);
            this.Controls.Add(this.textIDNume);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.IDUnitateMasura);
            this.Name = "UnitateMasura";
            this.Text = "UNITATEMASURA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDUnitateMasura;
        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.TextBox textIDNume;
        private System.Windows.Forms.TextBox text_IDunitate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Update_Ingredient;
        private System.Windows.Forms.Button delete_Ingredient;
        private System.Windows.Forms.Button RESET_Ingredient;
    }
}