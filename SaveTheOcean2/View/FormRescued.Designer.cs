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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRescued));
            butt_back = new Button();
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
            // FormRescued
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(butt_back);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormRescued";
            Text = "FormRescued";
            ResumeLayout(false);
        }

        #endregion

        private Button butt_back;
    }
}