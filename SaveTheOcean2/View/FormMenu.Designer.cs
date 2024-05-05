namespace SaveTheOcean2
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            lblTitle = new Label();
            butt_start = new Button();
            butt_close = new Button();
            butt_rescued = new Button();
            butt_species = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(268, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(247, 118);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Benvingut a Save the ocean";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // butt_start
            // 
            butt_start.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butt_start.Location = new Point(164, 175);
            butt_start.Name = "butt_start";
            butt_start.Size = new Size(118, 55);
            butt_start.TabIndex = 1;
            butt_start.Text = "Jugar";
            butt_start.UseVisualStyleBackColor = true;
            butt_start.Click += butt_start_Click;
            // 
            // butt_close
            // 
            butt_close.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butt_close.Location = new Point(164, 303);
            butt_close.Name = "butt_close";
            butt_close.Size = new Size(118, 55);
            butt_close.TabIndex = 2;
            butt_close.Text = "Sortir";
            butt_close.UseVisualStyleBackColor = true;
            butt_close.Click += butt_close_Click;
            // 
            // butt_rescued
            // 
            butt_rescued.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butt_rescued.Location = new Point(495, 303);
            butt_rescued.Name = "butt_rescued";
            butt_rescued.Size = new Size(118, 55);
            butt_rescued.TabIndex = 3;
            butt_rescued.Text = "Rescats";
            butt_rescued.UseVisualStyleBackColor = true;
            butt_rescued.Click += butt_rescued_Click;
            // 
            // butt_species
            // 
            butt_species.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butt_species.Location = new Point(495, 175);
            butt_species.Name = "butt_species";
            butt_species.Size = new Size(118, 55);
            butt_species.TabIndex = 4;
            butt_species.Text = "Especies";
            butt_species.UseVisualStyleBackColor = true;
            butt_species.Click += butt_species_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(butt_species);
            Controls.Add(butt_rescued);
            Controls.Add(butt_close);
            Controls.Add(butt_start);
            Controls.Add(lblTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMenu";
            Text = "Save the ocean!! 2";
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Button butt_start;
        private Button butt_close;
        private Button butt_rescued;
        private Button butt_species;
    }
}
