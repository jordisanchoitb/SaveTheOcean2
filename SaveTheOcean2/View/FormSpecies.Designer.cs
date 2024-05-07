namespace SaveTheOcean2
{
    partial class FormSpecies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSpecies));
            butt_back = new Button();
            butt_modify = new Button();
            butt_add = new Button();
            lbl_species = new Label();
            SuspendLayout();
            // 
            // butt_back
            // 
            butt_back.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butt_back.Location = new Point(12, 392);
            butt_back.Name = "butt_back";
            butt_back.Size = new Size(111, 46);
            butt_back.TabIndex = 0;
            butt_back.Text = "Enrere";
            butt_back.UseVisualStyleBackColor = true;
            butt_back.Click += butt_back_Click;
            // 
            // butt_modify
            // 
            butt_modify.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butt_modify.Location = new Point(224, 210);
            butt_modify.Name = "butt_modify";
            butt_modify.Size = new Size(118, 65);
            butt_modify.TabIndex = 6;
            butt_modify.Text = "Modificar especie";
            butt_modify.UseVisualStyleBackColor = true;
            butt_modify.Click += butt_modify_Click;
            // 
            // butt_add
            // 
            butt_add.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butt_add.Location = new Point(448, 210);
            butt_add.Name = "butt_add";
            butt_add.Size = new Size(118, 65);
            butt_add.TabIndex = 7;
            butt_add.Text = "Afegir especie";
            butt_add.UseVisualStyleBackColor = true;
            butt_add.Click += butt_add_Click;
            // 
            // lbl_species
            // 
            lbl_species.AutoSize = true;
            lbl_species.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_species.Location = new Point(224, 33);
            lbl_species.Name = "lbl_species";
            lbl_species.Size = new Size(342, 45);
            lbl_species.TabIndex = 8;
            lbl_species.Text = "Especies que vols fer?";
            // 
            // FormSpecies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_species);
            Controls.Add(butt_add);
            Controls.Add(butt_modify);
            Controls.Add(butt_back);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormSpecies";
            Text = "FormEspecie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butt_back;
        private Button butt_modify;
        private Button butt_add;
        private Label lbl_species;
    }
}