namespace SaveTheOcean2.View
{
    partial class FormSpeciesModify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSpeciesModify));
            butt_back = new Button();
            butt_Modify = new Button();
            txtBox_WeightAprox = new TextBox();
            txtBox_Name = new TextBox();
            txtBox_Specie = new TextBox();
            cmbBox_SuperFamily = new ComboBox();
            lbl_WeightAprox = new Label();
            lbl_SuperFamily = new Label();
            lbl_specie = new Label();
            lbl_Name = new Label();
            lbl_introduce = new Label();
            lbl_ModifySpecie = new Label();
            dtvw_animals = new DataGridView();
            lbl_introduceId = new Label();
            lbl_Id = new Label();
            cmbBox_Ids = new ComboBox();
            NameProvider = new ErrorProvider(components);
            SpecieProvider = new ErrorProvider(components);
            SuperFamilyProvider = new ErrorProvider(components);
            WeightAproxProvider = new ErrorProvider(components);
            IdProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dtvw_animals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NameProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpecieProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SuperFamilyProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WeightAproxProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IdProvider).BeginInit();
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
            // butt_Modify
            // 
            butt_Modify.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butt_Modify.Location = new Point(552, 366);
            butt_Modify.Name = "butt_Modify";
            butt_Modify.Size = new Size(138, 72);
            butt_Modify.TabIndex = 23;
            butt_Modify.Text = "Modificar espècie";
            butt_Modify.UseVisualStyleBackColor = true;
            butt_Modify.Click += butt_Modify_Click;
            // 
            // txtBox_WeightAprox
            // 
            txtBox_WeightAprox.Location = new Point(622, 323);
            txtBox_WeightAprox.Name = "txtBox_WeightAprox";
            txtBox_WeightAprox.Size = new Size(121, 23);
            txtBox_WeightAprox.TabIndex = 22;
            txtBox_WeightAprox.Validating += txtBox_WeightAprox_Validating;
            // 
            // txtBox_Name
            // 
            txtBox_Name.Location = new Point(563, 185);
            txtBox_Name.Name = "txtBox_Name";
            txtBox_Name.Size = new Size(180, 23);
            txtBox_Name.TabIndex = 21;
            txtBox_Name.Validating += txtBox_Name_Validating;
            // 
            // txtBox_Specie
            // 
            txtBox_Specie.Location = new Point(581, 232);
            txtBox_Specie.Name = "txtBox_Specie";
            txtBox_Specie.Size = new Size(162, 23);
            txtBox_Specie.TabIndex = 20;
            txtBox_Specie.Validating += txtBox_Specie_Validating;
            // 
            // cmbBox_SuperFamily
            // 
            cmbBox_SuperFamily.DataSource = resources.GetObject("cmbBox_SuperFamily.DataSource");
            cmbBox_SuperFamily.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBox_SuperFamily.FormattingEnabled = true;
            cmbBox_SuperFamily.Location = new Point(622, 278);
            cmbBox_SuperFamily.Name = "cmbBox_SuperFamily";
            cmbBox_SuperFamily.Size = new Size(121, 23);
            cmbBox_SuperFamily.TabIndex = 19;
            cmbBox_SuperFamily.Validating += cmbBox_SuperFamily_Validating;
            // 
            // lbl_WeightAprox
            // 
            lbl_WeightAprox.AutoSize = true;
            lbl_WeightAprox.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            lbl_WeightAprox.Location = new Point(500, 323);
            lbl_WeightAprox.Name = "lbl_WeightAprox";
            lbl_WeightAprox.Size = new Size(127, 23);
            lbl_WeightAprox.TabIndex = 18;
            lbl_WeightAprox.Text = "Pes aproximat: ";
            // 
            // lbl_SuperFamily
            // 
            lbl_SuperFamily.AutoSize = true;
            lbl_SuperFamily.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            lbl_SuperFamily.Location = new Point(500, 278);
            lbl_SuperFamily.Name = "lbl_SuperFamily";
            lbl_SuperFamily.Size = new Size(116, 23);
            lbl_SuperFamily.TabIndex = 17;
            lbl_SuperFamily.Text = "Super Família:";
            // 
            // lbl_specie
            // 
            lbl_specie.AutoSize = true;
            lbl_specie.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            lbl_specie.Location = new Point(500, 232);
            lbl_specie.Name = "lbl_specie";
            lbl_specie.Size = new Size(75, 23);
            lbl_specie.TabIndex = 16;
            lbl_specie.Text = "Espècie: ";
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            lbl_Name.Location = new Point(500, 185);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(57, 23);
            lbl_Name.TabIndex = 15;
            lbl_Name.Text = "Nom: ";
            // 
            // lbl_introduce
            // 
            lbl_introduce.AutoSize = true;
            lbl_introduce.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_introduce.Location = new Point(482, 153);
            lbl_introduce.Name = "lbl_introduce";
            lbl_introduce.Size = new Size(295, 21);
            lbl_introduce.TabIndex = 14;
            lbl_introduce.Text = "Introdueix las dades de la nova espècie";
            // 
            // lbl_ModifySpecie
            // 
            lbl_ModifySpecie.AutoSize = true;
            lbl_ModifySpecie.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ModifySpecie.Location = new Point(12, 9);
            lbl_ModifySpecie.Name = "lbl_ModifySpecie";
            lbl_ModifySpecie.Size = new Size(448, 45);
            lbl_ModifySpecie.TabIndex = 13;
            lbl_ModifySpecie.Text = "Quina espècie vols modificar";
            // 
            // dtvw_animals
            // 
            dtvw_animals.AllowUserToAddRows = false;
            dtvw_animals.AllowUserToDeleteRows = false;
            dtvw_animals.AllowUserToResizeColumns = false;
            dtvw_animals.AllowUserToResizeRows = false;
            dtvw_animals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtvw_animals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvw_animals.Location = new Point(21, 66);
            dtvw_animals.Name = "dtvw_animals";
            dtvw_animals.ReadOnly = true;
            dtvw_animals.RowHeadersVisible = false;
            dtvw_animals.Size = new Size(455, 309);
            dtvw_animals.TabIndex = 24;
            dtvw_animals.CellClick += dtvw_animals_CellClick;
            // 
            // lbl_introduceId
            // 
            lbl_introduceId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_introduceId.Location = new Point(482, 66);
            lbl_introduceId.Name = "lbl_introduceId";
            lbl_introduceId.Size = new Size(306, 47);
            lbl_introduceId.TabIndex = 25;
            lbl_introduceId.Text = "Introdueix la id de la espècie que vols modificar";
            // 
            // lbl_Id
            // 
            lbl_Id.AutoSize = true;
            lbl_Id.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            lbl_Id.Location = new Point(552, 114);
            lbl_Id.Name = "lbl_Id";
            lbl_Id.Size = new Size(34, 23);
            lbl_Id.TabIndex = 26;
            lbl_Id.Text = "Id: ";
            // 
            // cmbBox_Ids
            // 
            cmbBox_Ids.DataSource = resources.GetObject("cmbBox_Ids.DataSource");
            cmbBox_Ids.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBox_Ids.FormattingEnabled = true;
            cmbBox_Ids.Location = new Point(592, 116);
            cmbBox_Ids.Name = "cmbBox_Ids";
            cmbBox_Ids.Size = new Size(96, 23);
            cmbBox_Ids.TabIndex = 27;
            cmbBox_Ids.Validating += cmbBox_Ids_Validating;
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
            // IdProvider
            // 
            IdProvider.ContainerControl = this;
            // 
            // FormSpeciesModify
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbBox_Ids);
            Controls.Add(lbl_Id);
            Controls.Add(lbl_introduceId);
            Controls.Add(dtvw_animals);
            Controls.Add(butt_Modify);
            Controls.Add(txtBox_WeightAprox);
            Controls.Add(txtBox_Name);
            Controls.Add(txtBox_Specie);
            Controls.Add(cmbBox_SuperFamily);
            Controls.Add(lbl_WeightAprox);
            Controls.Add(lbl_SuperFamily);
            Controls.Add(lbl_specie);
            Controls.Add(lbl_Name);
            Controls.Add(lbl_introduce);
            Controls.Add(lbl_ModifySpecie);
            Controls.Add(butt_back);
            Name = "FormSpeciesModify";
            Text = "FormSpeciesModify";
            Load += FormSpeciesModify_Load;
            ((System.ComponentModel.ISupportInitialize)dtvw_animals).EndInit();
            ((System.ComponentModel.ISupportInitialize)NameProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpecieProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)SuperFamilyProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)WeightAproxProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)IdProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butt_back;
        private Button butt_Modify;
        private TextBox txtBox_WeightAprox;
        private TextBox txtBox_Name;
        private TextBox txtBox_Specie;
        private ComboBox cmbBox_SuperFamily;
        private Label lbl_WeightAprox;
        private Label lbl_SuperFamily;
        private Label lbl_specie;
        private Label lbl_Name;
        private Label lbl_introduce;
        private Label lbl_ModifySpecie;
        private DataGridView dtvw_animals;
        private Label lbl_introduceId;
        private Label lbl_Id;
        private ComboBox cmbBox_Ids;
        private ErrorProvider NameProvider;
        private ErrorProvider SpecieProvider;
        private ErrorProvider SuperFamilyProvider;
        private ErrorProvider WeightAproxProvider;
        private ErrorProvider IdProvider;
    }
}