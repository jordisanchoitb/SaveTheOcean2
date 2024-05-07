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
            lbl_TableRescat = new Label();
            lbl_FitxaRescat = new Label();
            lbl_choose = new Label();
            butt_heal = new Button();
            butt_move = new Button();
            butt_gomenu = new Button();
            lbl_msgtreatment = new Label();
            lbl_msgxp = new Label();
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
            // lbl_TableRescat
            // 
            lbl_TableRescat.AutoSize = true;
            lbl_TableRescat.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_TableRescat.Location = new Point(12, 117);
            lbl_TableRescat.Name = "lbl_TableRescat";
            lbl_TableRescat.Size = new Size(125, 23);
            lbl_TableRescat.TabIndex = 2;
            lbl_TableRescat.Text = "msgtablerescat";
            // 
            // lbl_FitxaRescat
            // 
            lbl_FitxaRescat.AutoSize = true;
            lbl_FitxaRescat.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_FitxaRescat.Location = new Point(579, 117);
            lbl_FitxaRescat.Name = "lbl_FitxaRescat";
            lbl_FitxaRescat.Size = new Size(121, 23);
            lbl_FitxaRescat.TabIndex = 3;
            lbl_FitxaRescat.Text = "msgfitxarescat";
            // 
            // lbl_choose
            // 
            lbl_choose.AutoSize = true;
            lbl_choose.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_choose.Location = new Point(260, 276);
            lbl_choose.Name = "lbl_choose";
            lbl_choose.Size = new Size(108, 25);
            lbl_choose.TabIndex = 4;
            lbl_choose.Text = "msgchoose";
            // 
            // butt_heal
            // 
            butt_heal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butt_heal.Location = new Point(411, 352);
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
            butt_move.Location = new Point(611, 352);
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
            butt_gomenu.Location = new Point(556, 352);
            butt_gomenu.Name = "butt_gomenu";
            butt_gomenu.Size = new Size(118, 65);
            butt_gomenu.TabIndex = 7;
            butt_gomenu.Text = "Tornar al menu";
            butt_gomenu.UseVisualStyleBackColor = true;
            butt_gomenu.Visible = false;
            butt_gomenu.Click += butt_gomenu_Click;
            // 
            // lbl_msgtreatment
            // 
            lbl_msgtreatment.AutoSize = true;
            lbl_msgtreatment.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_msgtreatment.Location = new Point(12, 140);
            lbl_msgtreatment.Name = "lbl_msgtreatment";
            lbl_msgtreatment.Size = new Size(135, 25);
            lbl_msgtreatment.TabIndex = 8;
            lbl_msgtreatment.Text = "msgTreatment";
            lbl_msgtreatment.Visible = false;
            // 
            // lbl_msgxp
            // 
            lbl_msgxp.AutoSize = true;
            lbl_msgxp.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_msgxp.Location = new Point(277, 210);
            lbl_msgxp.Name = "lbl_msgxp";
            lbl_msgxp.Size = new Size(69, 25);
            lbl_msgxp.TabIndex = 9;
            lbl_msgxp.Text = "msgxp";
            lbl_msgxp.Visible = false;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1149, 450);
            Controls.Add(lbl_msgxp);
            Controls.Add(lbl_msgtreatment);
            Controls.Add(butt_gomenu);
            Controls.Add(butt_move);
            Controls.Add(butt_heal);
            Controls.Add(lbl_choose);
            Controls.Add(lbl_FitxaRescat);
            Controls.Add(lbl_TableRescat);
            Controls.Add(lbl_msgRescat);
            Controls.Add(lbl_playerInfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormGame";
            Text = "FormGame";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_playerInfo;
        private Label lbl_msgRescat;
        private Label lbl_TableRescat;
        private Label lbl_FitxaRescat;
        private Label lbl_choose;
        private Button butt_heal;
        private Button butt_move;
        private Button butt_gomenu;
        private Label lbl_msgtreatment;
        private Label lbl_msgxp;
    }
}