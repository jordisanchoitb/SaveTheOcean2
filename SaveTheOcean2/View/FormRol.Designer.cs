namespace SaveTheOcean2
{
    partial class FormRol
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRol));
            lbl_TextRol = new Label();
            butt_tecnic = new Button();
            butt_veterinari = new Button();
            lbl_name = new Label();
            txtBoxName = new TextBox();
            NameProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)NameProvider).BeginInit();
            SuspendLayout();
            // 
            // lbl_TextRol
            // 
            lbl_TextRol.AutoSize = true;
            lbl_TextRol.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_TextRol.Location = new Point(322, 195);
            lbl_TextRol.Name = "lbl_TextRol";
            lbl_TextRol.Size = new Size(127, 25);
            lbl_TextRol.TabIndex = 0;
            lbl_TextRol.Text = "Que vols ser?";
            // 
            // butt_tecnic
            // 
            butt_tecnic.Enabled = false;
            butt_tecnic.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butt_tecnic.Location = new Point(165, 262);
            butt_tecnic.Name = "butt_tecnic";
            butt_tecnic.Size = new Size(151, 55);
            butt_tecnic.TabIndex = 1;
            butt_tecnic.Text = "Tècnic (45 XP)";
            butt_tecnic.UseVisualStyleBackColor = true;
            butt_tecnic.Click += butt_tecnic_Click;
            // 
            // butt_veterinari
            // 
            butt_veterinari.Enabled = false;
            butt_veterinari.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butt_veterinari.Location = new Point(440, 262);
            butt_veterinari.Name = "butt_veterinari";
            butt_veterinari.Size = new Size(179, 55);
            butt_veterinari.TabIndex = 2;
            butt_veterinari.Text = "Veterinari (80 XP)";
            butt_veterinari.UseVisualStyleBackColor = true;
            butt_veterinari.Click += butt_veterinari_Click;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_name.Location = new Point(309, 79);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(153, 25);
            lbl_name.TabIndex = 3;
            lbl_name.Text = "Posa el teu nom";
            // 
            // txtBoxName
            // 
            txtBoxName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxName.Location = new Point(309, 123);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(153, 33);
            txtBoxName.TabIndex = 4;
            txtBoxName.TextChanged += txtBoxName_TextChanged;
            txtBoxName.Validating += txtBoxName_Validating;
            // 
            // NameProvider
            // 
            NameProvider.ContainerControl = this;
            // 
            // FormRol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBoxName);
            Controls.Add(lbl_name);
            Controls.Add(butt_veterinari);
            Controls.Add(butt_tecnic);
            Controls.Add(lbl_TextRol);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormRol";
            Text = "FormRol";
            ((System.ComponentModel.ISupportInitialize)NameProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_TextRol;
        private Button butt_tecnic;
        private Button butt_veterinari;
        private Label lbl_name;
        private TextBox txtBoxName;
        private ErrorProvider NameProvider;
    }
}