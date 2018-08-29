using CefSharp;
using CefSharp.WinForms;
namespace Wed_Broswer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolbarBackground = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.ToolStrip();
            this.BackArrow = new System.Windows.Forms.ToolStripButton();
            this.ForwardArrow = new System.Windows.Forms.ToolStripButton();
            this.RefreshArrow = new System.Windows.Forms.ToolStripButton();
            this.HomeButton = new System.Windows.Forms.ToolStripButton();
            this.urlBorder = new System.Windows.Forms.Panel();
            this.urlBackground = new System.Windows.Forms.Panel();
            this.URL = new System.Windows.Forms.TextBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.toolbarBackground.SuspendLayout();
            this.Menu.SuspendLayout();
            this.urlBorder.SuspendLayout();
            this.urlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbarBackground
            // 
            this.toolbarBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolbarBackground.Controls.Add(this.Menu);
            this.toolbarBackground.Controls.Add(this.urlBorder);
            this.toolbarBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbarBackground.Location = new System.Drawing.Point(0, 0);
            this.toolbarBackground.Name = "toolbarBackground";
            this.toolbarBackground.Size = new System.Drawing.Size(484, 36);
            this.toolbarBackground.TabIndex = 3;
            // 
            // Menu
            // 
            this.Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Menu.Dock = System.Windows.Forms.DockStyle.None;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackArrow,
            this.ForwardArrow,
            this.RefreshArrow,
            this.HomeButton});
            this.Menu.Location = new System.Drawing.Point(8, 6);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(104, 23);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "Menu";
            // 
            // BackArrow
            // 
            this.BackArrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackArrow.Image = ((System.Drawing.Image)(resources.GetObject("BackArrow.Image")));
            this.BackArrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackArrow.Name = "BackArrow";
            this.BackArrow.Size = new System.Drawing.Size(23, 20);
            this.BackArrow.Text = "Back";
            this.BackArrow.Click += new System.EventHandler(this.BackArrow_Click_1);
            // 
            // ForwardArrow
            // 
            this.ForwardArrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ForwardArrow.Image = ((System.Drawing.Image)(resources.GetObject("ForwardArrow.Image")));
            this.ForwardArrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ForwardArrow.Name = "ForwardArrow";
            this.ForwardArrow.Size = new System.Drawing.Size(23, 20);
            this.ForwardArrow.Text = "Forward";
            this.ForwardArrow.Click += new System.EventHandler(this.ForwardArrow_Click_1);
            // 
            // RefreshArrow
            // 
            this.RefreshArrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshArrow.Image = ((System.Drawing.Image)(resources.GetObject("RefreshArrow.Image")));
            this.RefreshArrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshArrow.Name = "RefreshArrow";
            this.RefreshArrow.Size = new System.Drawing.Size(23, 20);
            this.RefreshArrow.Text = "Refresh";
            this.RefreshArrow.Click += new System.EventHandler(this.RefreshArrow_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(23, 20);
            this.HomeButton.Text = "Home";
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // urlBorder
            // 
            this.urlBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlBorder.BackColor = System.Drawing.Color.Silver;
            this.urlBorder.Controls.Add(this.urlBackground);
            this.urlBorder.ForeColor = System.Drawing.Color.Silver;
            this.urlBorder.Location = new System.Drawing.Point(115, 5);
            this.urlBorder.Name = "urlBorder";
            this.urlBorder.Size = new System.Drawing.Size(334, 26);
            this.urlBorder.TabIndex = 1;
            // 
            // urlBackground
            // 
            this.urlBackground.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlBackground.BackColor = System.Drawing.Color.White;
            this.urlBackground.Controls.Add(this.URL);
            this.urlBackground.ForeColor = System.Drawing.Color.Silver;
            this.urlBackground.Location = new System.Drawing.Point(2, 1);
            this.urlBackground.Name = "urlBackground";
            this.urlBackground.Size = new System.Drawing.Size(332, 24);
            this.urlBackground.TabIndex = 2;
            // 
            // URL
            // 
            this.URL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.URL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.URL.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URL.Location = new System.Drawing.Point(12, 2);
            this.URL.Margin = new System.Windows.Forms.Padding(9);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(312, 19);
            this.URL.TabIndex = 0;
            this.URL.WordWrap = false;
            this.URL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.URL_KeyDown);
            // 
            // Panel
            // 
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 36);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(484, 425);
            this.Panel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.toolbarBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.toolbarBackground.ResumeLayout(false);
            this.toolbarBackground.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.urlBorder.ResumeLayout(false);
            this.urlBackground.ResumeLayout(false);
            this.urlBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toolbarBackground;
        private System.Windows.Forms.Panel urlBorder;
        private System.Windows.Forms.Panel urlBackground;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.ToolStrip Menu;
        private System.Windows.Forms.ToolStripButton BackArrow;
        private System.Windows.Forms.ToolStripButton ForwardArrow;
        private System.Windows.Forms.ToolStripButton RefreshArrow;
        private System.Windows.Forms.ToolStripButton HomeButton;
        private System.Windows.Forms.Panel Panel;
    }
}

