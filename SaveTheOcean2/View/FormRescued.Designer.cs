namespace SaveTheOcean2
{
    partial class FormRescued
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRescued));
            butt_back = new Button();
            dtvw_rescued = new DataGridView();
            lbl_Rescued = new Label();
            lbl_RescuredId = new Label();
            lbl_IdRescued = new Label();
            cmbBox_idrescured = new ComboBox();
            butt_filter = new Button();
            lbl_error = new Label();
            IdRescuedProvider = new ErrorProvider(components);
            butt_Clear = new Button();
            ((System.ComponentModel.ISupportInitialize)dtvw_rescued).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IdRescuedProvider).BeginInit();
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
            // dtvw_rescued
            // 
            dtvw_rescued.AllowUserToAddRows = false;
            dtvw_rescued.AllowUserToDeleteRows = false;
            dtvw_rescued.AllowUserToOrderColumns = true;
            dtvw_rescued.AllowUserToResizeColumns = false;
            dtvw_rescued.AllowUserToResizeRows = false;
            dtvw_rescued.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvw_rescued.Location = new Point(12, 57);
            dtvw_rescued.Name = "dtvw_rescued";
            dtvw_rescued.ReadOnly = true;
            dtvw_rescued.Size = new Size(776, 293);
            dtvw_rescued.TabIndex = 1;
            // 
            // lbl_Rescued
            // 
            lbl_Rescued.AutoSize = true;
            lbl_Rescued.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Rescued.Location = new Point(269, 9);
            lbl_Rescued.Name = "lbl_Rescued";
            lbl_Rescued.Size = new Size(277, 45);
            lbl_Rescued.TabIndex = 9;
            lbl_Rescued.Text = "Llista dels rescats";
            // 
            // lbl_RescuredId
            // 
            lbl_RescuredId.AutoSize = true;
            lbl_RescuredId.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_RescuredId.Location = new Point(164, 364);
            lbl_RescuredId.Name = "lbl_RescuredId";
            lbl_RescuredId.Size = new Size(316, 25);
            lbl_RescuredId.TabIndex = 10;
            lbl_RescuredId.Text = "Filtrar per Número rescat/ID Rescat";
            // 
            // lbl_IdRescued
            // 
            lbl_IdRescued.AutoSize = true;
            lbl_IdRescued.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold);
            lbl_IdRescued.Location = new Point(169, 408);
            lbl_IdRescued.Name = "lbl_IdRescued";
            lbl_IdRescued.Size = new Size(132, 23);
            lbl_IdRescued.TabIndex = 12;
            lbl_IdRescued.Text = "Numero Rescat:";
            // 
            // cmbBox_idrescured
            // 
            cmbBox_idrescured.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBox_idrescured.FormattingEnabled = true;
            cmbBox_idrescured.Location = new Point(307, 408);
            cmbBox_idrescured.Name = "cmbBox_idrescured";
            cmbBox_idrescured.Size = new Size(170, 23);
            cmbBox_idrescured.TabIndex = 13;
            cmbBox_idrescured.Validating += cmbBox_idrescured_Validating;
            // 
            // butt_filter
            // 
            butt_filter.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            butt_filter.Location = new Point(504, 391);
            butt_filter.Name = "butt_filter";
            butt_filter.Size = new Size(92, 49);
            butt_filter.TabIndex = 14;
            butt_filter.Text = "Filtrar";
            butt_filter.UseVisualStyleBackColor = true;
            butt_filter.Click += butt_filter_Click;
            // 
            // lbl_error
            // 
            lbl_error.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_error.Location = new Point(269, 127);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(277, 111);
            lbl_error.TabIndex = 15;
            lbl_error.Text = "Msg_error";
            lbl_error.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IdRescuedProvider
            // 
            IdRescuedProvider.ContainerControl = this;
            // 
            // butt_Clear
            // 
            butt_Clear.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            butt_Clear.Location = new Point(638, 389);
            butt_Clear.Name = "butt_Clear";
            butt_Clear.Size = new Size(150, 49);
            butt_Clear.TabIndex = 16;
            butt_Clear.Text = "Esborrar filtre";
            butt_Clear.UseVisualStyleBackColor = true;
            butt_Clear.Click += butt_Clear_Click;
            // 
            // FormRescued
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(800, 450);
            Controls.Add(butt_Clear);
            Controls.Add(lbl_error);
            Controls.Add(butt_filter);
            Controls.Add(cmbBox_idrescured);
            Controls.Add(lbl_IdRescued);
            Controls.Add(lbl_RescuredId);
            Controls.Add(lbl_Rescued);
            Controls.Add(dtvw_rescued);
            Controls.Add(butt_back);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormRescued";
            Text = "FormRescued";
            ((System.ComponentModel.ISupportInitialize)dtvw_rescued).EndInit();
            ((System.ComponentModel.ISupportInitialize)IdRescuedProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butt_back;
        private DataGridView dtvw_rescued;
        private Label lbl_Rescued;
        private Label lbl_RescuredId;
        private Label lbl_IdRescued;
        private ComboBox cmbBox_idrescured;
        private Button butt_filter;
        private Label lbl_error;
        private ErrorProvider IdRescuedProvider;
        private Button butt_Clear;
    }
}