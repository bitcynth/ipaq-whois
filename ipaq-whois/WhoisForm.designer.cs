namespace WHOIS
{
    partial class WHOIS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.queryText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.outputPanel = new System.Windows.Forms.Panel();
            this.outputText = new System.Windows.Forms.TextBox();
            this.outputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // queryText
            // 
            this.queryText.Location = new System.Drawing.Point(4, 4);
            this.queryText.Name = "queryText";
            this.queryText.Size = new System.Drawing.Size(155, 21);
            this.queryText.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputPanel
            // 
            this.outputPanel.AutoScroll = true;
            this.outputPanel.Controls.Add(this.outputText);
            this.outputPanel.Location = new System.Drawing.Point(4, 32);
            this.outputPanel.Name = "outputPanel";
            this.outputPanel.Size = new System.Drawing.Size(233, 233);
            // 
            // outputText
            // 
            this.outputText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.outputText.Location = new System.Drawing.Point(0, 0);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputText.Size = new System.Drawing.Size(233, 236);
            this.outputText.TabIndex = 0;
            this.outputText.Text = "Output";
            // 
            // WHOIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.outputPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.queryText);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "WHOIS";
            this.Text = "WHOIS Cynthia.re";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.outputPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox queryText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel outputPanel;
        private System.Windows.Forms.TextBox outputText;
    }
}

