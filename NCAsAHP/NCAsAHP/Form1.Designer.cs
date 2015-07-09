namespace NCAsAHP
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patienttoWaitingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialistAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(407, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patienttoWaitingListToolStripMenuItem,
            this.prescriptionToolStripMenuItem,
            this.specialistAppointmentToolStripMenuItem});
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.formToolStripMenuItem.Text = "Form";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // patienttoWaitingListToolStripMenuItem
            // 
            this.patienttoWaitingListToolStripMenuItem.Name = "patienttoWaitingListToolStripMenuItem";
            this.patienttoWaitingListToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.patienttoWaitingListToolStripMenuItem.Text = "PatienttoWaitingList";
            this.patienttoWaitingListToolStripMenuItem.Click += new System.EventHandler(this.patienttoWaitingListToolStripMenuItem_Click);
            // 
            // prescriptionToolStripMenuItem
            // 
            this.prescriptionToolStripMenuItem.Name = "prescriptionToolStripMenuItem";
            this.prescriptionToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.prescriptionToolStripMenuItem.Text = "Prescription";
            this.prescriptionToolStripMenuItem.Click += new System.EventHandler(this.prescriptionToolStripMenuItem_Click);
            // 
            // specialistAppointmentToolStripMenuItem
            // 
            this.specialistAppointmentToolStripMenuItem.Name = "specialistAppointmentToolStripMenuItem";
            this.specialistAppointmentToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.specialistAppointmentToolStripMenuItem.Text = "SpecialistAppointment";
            this.specialistAppointmentToolStripMenuItem.Click += new System.EventHandler(this.specialistAppointmentToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Nardin Company as a Healthcare Provider";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patienttoWaitingListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialistAppointmentToolStripMenuItem;
    }
}

