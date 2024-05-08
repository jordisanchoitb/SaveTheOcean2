namespace SaveTheOcean2.View
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            lbl_playerInfo = new Label();
            lbl_msgRescat = new Label();
            lbl_choose = new Label();
            butt_heal = new Button();
            butt_move = new Button();
            butt_gomenu = new Button();
            lbl_msgxp = new Label();
            dtvw_tablerescued = new DataGridView();
            idNumber = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Superfamily = new DataGridViewTextBoxColumn();
            GradeAfectation = new DataGridViewTextBoxColumn();
            Location = new DataGridViewTextBoxColumn();
            dtvw_tablesheetrescued = new DataGridView();
            NameView = new DataGridViewTextBoxColumn();
            Superfamily2 = new DataGridViewTextBoxColumn();
            Specie = new DataGridViewTextBoxColumn();
            WeightAprox = new DataGridViewTextBoxColumn();
            lbl_msgtreatment = new Label();
            ((System.ComponentModel.ISupportInitialize)dtvw_tablerescued).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtvw_tablesheetrescued).BeginInit();
            SuspendLayout();
            // 
            // lbl_playerInfo
            // 
            lbl_playerInfo.AutoSize = true;
            lbl_playerInfo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_playerInfo.Location = new Point(12, 9);
            lbl_playerInfo.Name = "lbl_playerInfo";
            lbl_playerInfo.Size = new Size(83, 25);
            lbl_playerInfo.TabIndex = 0;
            lbl_playerInfo.Text = "textinfo";
            // 
            // lbl_msgRescat
            // 
            lbl_msgRescat.AutoSize = true;
            lbl_msgRescat.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_msgRescat.Location = new Point(12, 60);
            lbl_msgRescat.Name = "lbl_msgRescat";
            lbl_msgRescat.Size = new Size(103, 25);
            lbl_msgRescat.TabIndex = 1;
            lbl_msgRescat.Text = "msgRescat";
            // 
            // lbl_choose
            // 
            lbl_choose.AutoSize = true;
            lbl_choose.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_choose.Location = new Point(256, 279);
            lbl_choose.Name = "lbl_choose";
            lbl_choose.Size = new Size(108, 25);
            lbl_choose.TabIndex = 4;
            lbl_choose.Text = "msgchoose";
            // 
            // butt_heal
            // 
            butt_heal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butt_heal.Location = new Point(402, 324);
            butt_heal.Name = "butt_heal";
            butt_heal.Size = new Size(118, 65);
            butt_heal.TabIndex = 5;
            butt_heal.Text = "Curar-la";
            butt_heal.UseVisualStyleBackColor = true;
            butt_heal.Click += butt_heal_Click;
            // 
            // butt_move
            // 
            butt_move.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butt_move.Location = new Point(602, 324);
            butt_move.Name = "butt_move";
            butt_move.Size = new Size(134, 65);
            butt_move.TabIndex = 6;
            butt_move.Text = "Traslladar-la";
            butt_move.UseVisualStyleBackColor = true;
            butt_move.Click += butt_move_Click;
            // 
            // butt_gomenu
            // 
            butt_gomenu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butt_gomenu.Location = new Point(487, 324);
            butt_gomenu.Name = "butt_gomenu";
            butt_gomenu.Size = new Size(118, 65);
            butt_gomenu.TabIndex = 7;
            butt_gomenu.Text = "Tornar al menu";
            butt_gomenu.UseVisualStyleBackColor = true;
            butt_gomenu.Visible = false;
            butt_gomenu.Click += butt_gomenu_Click;
            // 
            // lbl_msgxp
            // 
            lbl_msgxp.AutoSize = true;
            lbl_msgxp.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_msgxp.Location = new Point(256, 221);
            lbl_msgxp.Name = "lbl_msgxp";
            lbl_msgxp.Size = new Size(69, 25);
            lbl_msgxp.TabIndex = 9;
            lbl_msgxp.Text = "msgxp";
            lbl_msgxp.Visible = false;
            // 
            // dtvw_tablerescued
            // 
            dtvw_tablerescued.AllowUserToAddRows = false;
            dtvw_tablerescued.AllowUserToDeleteRows = false;
            dtvw_tablerescued.AllowUserToResizeColumns = false;
            dtvw_tablerescued.AllowUserToResizeRows = false;
            dtvw_tablerescued.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvw_tablerescued.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvw_tablerescued.Columns.AddRange(new DataGridViewColumn[] { idNumber, Date, Superfamily, GradeAfectation, Location });
            dtvw_tablerescued.Location = new Point(14, 103);
            dtvw_tablerescued.Name = "dtvw_tablerescued";
            dtvw_tablerescued.ReadOnly = true;
            dtvw_tablerescued.RowHeadersVisible = false;
            dtvw_tablerescued.RowHeadersWidth = 45;
            dtvw_tablerescued.Size = new Size(517, 88);
            dtvw_tablerescued.TabIndex = 10;
            // 
            // idNumber
            // 
            idNumber.HeaderText = "Rescat";
            idNumber.Name = "idNumber";
            idNumber.ReadOnly = true;
            // 
            // Date
            // 
            Date.HeaderText = "Data rescat";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // Superfamily
            // 
            Superfamily.HeaderText = "Superfamília";
            Superfamily.Name = "Superfamily";
            Superfamily.ReadOnly = true;
            // 
            // GradeAfectation
            // 
            GradeAfectation.HeaderText = "GA";
            GradeAfectation.Name = "GradeAfectation";
            GradeAfectation.ReadOnly = true;
            // 
            // Location
            // 
            Location.HeaderText = "Localització";
            Location.Name = "Location";
            Location.ReadOnly = true;
            // 
            // dtvw_tablesheetrescued
            // 
            dtvw_tablesheetrescued.AllowUserToAddRows = false;
            dtvw_tablesheetrescued.AllowUserToDeleteRows = false;
            dtvw_tablesheetrescued.AllowUserToResizeColumns = false;
            dtvw_tablesheetrescued.AllowUserToResizeRows = false;
            dtvw_tablesheetrescued.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvw_tablesheetrescued.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvw_tablesheetrescued.Columns.AddRange(new DataGridViewColumn[] { NameView, Superfamily2, Specie, WeightAprox });
            dtvw_tablesheetrescued.Location = new Point(579, 103);
            dtvw_tablesheetrescued.Name = "dtvw_tablesheetrescued";
            dtvw_tablesheetrescued.ReadOnly = true;
            dtvw_tablesheetrescued.RowHeadersVisible = false;
            dtvw_tablesheetrescued.Size = new Size(523, 88);
            dtvw_tablesheetrescued.TabIndex = 11;
            // 
            // NameView
            // 
            NameView.HeaderText = "Nom";
            NameView.Name = "NameView";
            NameView.ReadOnly = true;
            // 
            // Superfamily2
            // 
            Superfamily2.HeaderText = "Superfamília";
            Superfamily2.Name = "Superfamily2";
            Superfamily2.ReadOnly = true;
            // 
            // Specie
            // 
            Specie.HeaderText = "Espècie";
            Specie.Name = "Specie";
            Specie.ReadOnly = true;
            // 
            // WeightAprox
            // 
            WeightAprox.HeaderText = "Pes aproximat";
            WeightAprox.Name = "WeightAprox";
            WeightAprox.ReadOnly = true;
            // 
            // lbl_msgtreatment
            // 
            lbl_msgtreatment.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_msgtreatment.Location = new Point(14, 125);
            lbl_msgtreatment.Name = "lbl_msgtreatment";
            lbl_msgtreatment.Size = new Size(1088, 96);
            lbl_msgtreatment.TabIndex = 8;
            lbl_msgtreatment.Text = "msgTreatment";
            lbl_msgtreatment.Visible = false;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1127, 402);
            Controls.Add(lbl_msgxp);
            Controls.Add(lbl_msgtreatment);
            Controls.Add(butt_gomenu);
            Controls.Add(butt_move);
            Controls.Add(butt_heal);
            Controls.Add(lbl_choose);
            Controls.Add(lbl_msgRescat);
            Controls.Add(lbl_playerInfo);
            Controls.Add(dtvw_tablerescued);
            Controls.Add(dtvw_tablesheetrescued);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormGame";
            Text = "FormGame";
            ((System.ComponentModel.ISupportInitialize)dtvw_tablerescued).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtvw_tablesheetrescued).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_playerInfo;
        private Label lbl_msgRescat;
        private Label lbl_choose;
        private Button butt_heal;
        private Button butt_move;
        private Button butt_gomenu;
        private Label lbl_msgxp;
        private DataGridView dtvw_tablerescued;
        private DataGridView dtvw_tablesheetrescued;
        private DataGridViewTextBoxColumn idNumber;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Superfamily;
        private DataGridViewTextBoxColumn GradeAfectation;
        private DataGridViewTextBoxColumn Location;
        private DataGridViewTextBoxColumn NameView;
        private DataGridViewTextBoxColumn Superfamily2;
        private DataGridViewTextBoxColumn Specie;
        private DataGridViewTextBoxColumn WeightAprox;
        private Label lbl_msgtreatment;
    }
}