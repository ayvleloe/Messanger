namespace Messanger
{
    partial class Menu
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.FlowLayoutPanelSMS = new System.Windows.Forms.FlowLayoutPanel();
            this.TextBoxTippen = new System.Windows.Forms.TextBox();
            this.ButtonSendenMenu = new System.Windows.Forms.Button();
            this.FlowLayoutPanelChats = new System.Windows.Forms.FlowLayoutPanel();
            this.TextBoxSuchNachBenutzer = new System.Windows.Forms.TextBox();
            this.ButtonSuchNachBenutzer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FlowLayoutPanelSMS
            // 
            this.FlowLayoutPanelSMS.Location = new System.Drawing.Point(201, 42);
            this.FlowLayoutPanelSMS.Name = "FlowLayoutPanelSMS";
            this.FlowLayoutPanelSMS.Size = new System.Drawing.Size(527, 607);
            this.FlowLayoutPanelSMS.TabIndex = 0;
            // 
            // TextBoxTippen
            // 
            this.TextBoxTippen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTippen.Location = new System.Drawing.Point(201, 654);
            this.TextBoxTippen.Name = "TextBoxTippen";
            this.TextBoxTippen.Size = new System.Drawing.Size(466, 44);
            this.TextBoxTippen.TabIndex = 1;
            // 
            // ButtonSendenMenu
            // 
            this.ButtonSendenMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSendenMenu.Location = new System.Drawing.Point(673, 654);
            this.ButtonSendenMenu.Name = "ButtonSendenMenu";
            this.ButtonSendenMenu.Size = new System.Drawing.Size(55, 44);
            this.ButtonSendenMenu.TabIndex = 2;
            this.ButtonSendenMenu.Text = "Senden";
            this.ButtonSendenMenu.UseVisualStyleBackColor = true;
            this.ButtonSendenMenu.Click += new System.EventHandler(this.ButtonSendenMenu_Click);
            // 
            // FlowLayoutPanelChats
            // 
            this.FlowLayoutPanelChats.Location = new System.Drawing.Point(3, 42);
            this.FlowLayoutPanelChats.Name = "FlowLayoutPanelChats";
            this.FlowLayoutPanelChats.Size = new System.Drawing.Size(195, 658);
            this.FlowLayoutPanelChats.TabIndex = 3;
            // 
            // TextBoxSuchNachBenutzer
            // 
            this.TextBoxSuchNachBenutzer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSuchNachBenutzer.Location = new System.Drawing.Point(3, 10);
            this.TextBoxSuchNachBenutzer.Name = "TextBoxSuchNachBenutzer";
            this.TextBoxSuchNachBenutzer.Size = new System.Drawing.Size(169, 26);
            this.TextBoxSuchNachBenutzer.TabIndex = 4;
            // 
            // ButtonSuchNachBenutzer
            // 
            this.ButtonSuchNachBenutzer.Location = new System.Drawing.Point(168, 10);
            this.ButtonSuchNachBenutzer.Name = "ButtonSuchNachBenutzer";
            this.ButtonSuchNachBenutzer.Size = new System.Drawing.Size(30, 26);
            this.ButtonSuchNachBenutzer.TabIndex = 5;
            this.ButtonSuchNachBenutzer.Text = "x";
            this.ButtonSuchNachBenutzer.UseVisualStyleBackColor = true;
            this.ButtonSuchNachBenutzer.Click += new System.EventHandler(this.ButtonSuchNachBenutzer_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonSuchNachBenutzer);
            this.Controls.Add(this.TextBoxSuchNachBenutzer);
            this.Controls.Add(this.FlowLayoutPanelChats);
            this.Controls.Add(this.ButtonSendenMenu);
            this.Controls.Add(this.TextBoxTippen);
            this.Controls.Add(this.FlowLayoutPanelSMS);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(928, 701);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelSMS;
        private System.Windows.Forms.TextBox TextBoxTippen;
        private System.Windows.Forms.Button ButtonSendenMenu;
        private System.Windows.Forms.TextBox TextBoxSuchNachBenutzer;
        private System.Windows.Forms.Button ButtonSuchNachBenutzer;
        public System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelChats;
    }
}
