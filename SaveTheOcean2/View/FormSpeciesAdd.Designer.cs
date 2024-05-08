namespace SaveTheOcean2.View
{
    partial class FormSpeciesAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSpeciesAdd));
            butt_back = new Button();
            lbl_AddSpecie = new Label();
            lbl_introduce = new Label();
            lbl_Name = new Label();
            lbl_specie = new Label();
            lbl_SuperFamily = new Label();
            lbl_WeightAprox = new Label();
            cmbBox_SuperFamily = new ComboBox();
            txtBox_Specie = new TextBox();
            txtBox_Name = new TextBox();
            txtBox_WeightAprox = new TextBox();
            NameProvider = new ErrorProvider(components);
            SpecieProvider = new ErrorProvider(components);
            SuperFamilyProvider = new ErrorProvider(components);
            WeightAproxProvider = new ErrorProvider(components);
            butt_Add = new Button();
            ((System.ComponentModel.ISupportInitialize)NameProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpecieProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SuperFamilyProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WeightAproxProvider).BeginInit();
            SuspendLayout();
            // 
            // butt_back
            // 
            butt_back.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butt_back.Location = new Point(12, 392);
            butt_back.Name = "butt_back";
            butt_back.Size = new Size(111, 46);
            butt_back.TabIndex = 1;
            butt_back.Text = "Enrere";
            butt_back.UseVisualStyleBackColor = true;
            butt_back.Click += butt_back_Click;
            // 
            // lbl_AddSpecie
            // 
            lbl_AddSpecie.AutoSize = true;
            lbl_AddSpecie.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_AddSpecie.Location = new Point(12, 9);
            lbl_AddSpecie.Name = "lbl_AddSpecie";
            lbl_AddSpecie.Size = new Size(443, 45);
            lbl_AddSpecie.TabIndex = 2;
            lbl_AddSpecie.Text = "Vols afegir una nova espècie";
            // 
            // lbl_introduce
            // 
            lbl_introduce.AutoSize = true;
            lbl_introduce.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_introduce.Location = new Point(21, 70);
            lbl_introduce.Name = "lbl_introduce";
            lbl_introduce.Size = new Size(295, 21);
            lbl_introduce.TabIndex = 3;
            lbl_introduce.Text = "Introdueix las dades de la nova espècie";
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            lbl_Name.Location = new Point(21, 121);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(57, 23);
            lbl_Name.TabIndex = 4;
            lbl_Name.Text = "Nom: ";
            // 
            // lbl_specie
            // 
            lbl_specie.AutoSize = true;
            lbl_specie.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            lbl_specie.Location = new Point(21, 168);
            lbl_specie.Name = "lbl_specie";
            lbl_specie.Size = new Size(75, 23);
            lbl_specie.TabIndex = 5;
            lbl_specie.Text = "Espècie: ";
            // 
            // lbl_SuperFamily
            // 
            lbl_SuperFamily.AutoSize = true;
            lbl_SuperFamily.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            lbl_SuperFamily.Location = new Point(21, 217);
            lbl_SuperFamily.Name = "lbl_SuperFamily";
            lbl_SuperFamily.Size = new Size(116, 23);
            lbl_SuperFamily.TabIndex = 6;
            lbl_SuperFamily.Text = "Super Família:";
            // 
            // lbl_WeightAprox
            // 
            lbl_WeightAprox.AutoSize = true;
            lbl_WeightAprox.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            lbl_WeightAprox.Location = new Point(21, 270);
            lbl_WeightAprox.Name = "lbl_WeightAprox";
            lbl_WeightAprox.Size = new Size(127, 23);
            lbl_WeightAprox.TabIndex = 7;
            lbl_WeightAprox.Text = "Pes aproximat: ";
            // 
            // cmbBox_SuperFamily
            // 
            cmbBox_SuperFamily.DataSource = resources.GetObject("cmbBox_SuperFamily.DataSource");
            cmbBox_SuperFamily.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBox_SuperFamily.FormattingEnabled = true;
            cmbBox_SuperFamily.Location = new Point(143, 217);
            cmbBox_SuperFamily.Name = "cmbBox_SuperFamily";
            cmbBox_SuperFamily.Size = new Size(121, 23);
            cmbBox_SuperFamily.TabIndex = 8;
            cmbBox_SuperFamily.Validating += cmbBox_SuperFamily_Validating;
            // 
            // txtBox_Specie
            // 
            txtBox_Specie.Location = new Point(102, 168);
            txtBox_Specie.Name = "txtBox_Specie";
            txtBox_Specie.Size = new Size(162, 23);
            txtBox_Specie.TabIndex = 9;
            txtBox_Specie.Validating += txtBox_Specie_Validating;
            // 
            // txtBox_Name
            // 
            txtBox_Name.Location = new Point(84, 121);
            txtBox_Name.Name = "txtBox_Name";
            txtBox_Name.Size = new Size(180, 23);
            txtBox_Name.TabIndex = 10;
            txtBox_Name.Validating += txtBox_Name_Validating;
            // 
            // txtBox_WeightAprox
            // 
            txtBox_WeightAprox.Location = new Point(143, 270);
            txtBox_WeightAprox.Name = "txtBox_WeightAprox";
            txtBox_WeightAprox.Size = new Size(121, 23);
            txtBox_WeightAprox.TabIndex = 11;
            txtBox_WeightAprox.Validating += txtBox_WeightAprox_Validating;
            // 
            // NameProvider
            // 
            NameProvider.ContainerControl = this;
            // 
            // SpecieProvider
            // 
            SpecieProvider.ContainerControl = this;
            // 
            // SuperFamilyProvider
            // 
            SuperFamilyProvider.ContainerControl = this;
            // 
            // WeightAproxProvider
            // 
            WeightAproxProvider.ContainerControl = this;
            // 
            // butt_Add
            // 
            butt_Add.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butt_Add.Location = new Point(396, 168);
            butt_Add.Name = "butt_Add";
            butt_Add.Size = new Size(138, 72);
            butt_Add.TabIndex = 12;
            butt_Add.Text = "Afegir espècie";
            butt_Add.UseVisualStyleBackColor = true;
            butt_Add.Click += butt_Add_Click;
            // 
            // FormSpeciesAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(800, 450);
            Controls.Add(butt_Add);
            Controls.Add(txtBox_WeightAprox);
            Controls.Add(txtBox_Name);
            Controls.Add(txtBox_Specie);
            Controls.Add(cmbBox_SuperFamily);
            Controls.Add(lbl_WeightAprox);
            Controls.Add(lbl_SuperFamily);
            Controls.Add(lbl_specie);
            Controls.Add(lbl_Name);
            Controls.Add(lbl_introduce);
            Controls.Add(lbl_AddSpecie);
            Controls.Add(butt_back);
            Name = "FormSpeciesAdd";
            Text = "FormSpeciesAdd";
            Load += FormSpeciesAdd_Load;
            ((System.ComponentModel.ISupportInitialize)NameProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpecieProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)SuperFamilyProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)WeightAproxProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butt_back;
        private Label lbl_AddSpecie;
        private Label lbl_introduce;
        private Label lbl_Name;
        private Label lbl_specie;
        private Label lbl_SuperFamily;
        private Label lbl_WeightAprox;
        private ComboBox cmbBox_SuperFamily;
        private TextBox txtBox_Specie;
        private TextBox txtBox_Name;
        private TextBox txtBox_WeightAprox;
        private ErrorProvider NameProvider;
        private ErrorProvider SpecieProvider;
        private ErrorProvider SuperFamilyProvider;
        private ErrorProvider WeightAproxProvider;
        private Button butt_Add;
    }
}