﻿namespace SandcastleBuilder.Package.PropertyPages
{
    partial class Help1WebsitePropertiesPageControl
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
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help1WebsitePropertiesPageControl));
            this.epNotes = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkBinaryTOC = new System.Windows.Forms.CheckBox();
            this.dividerLabel1 = new SandcastleBuilder.Utils.Controls.DividerLabel();
            this.dividerLabel2 = new SandcastleBuilder.Utils.Controls.DividerLabel();
            this.chkIncludeFavorites = new System.Windows.Forms.CheckBox();
            this.cboHtmlSdkLinkType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboWebsiteSdkLinkType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dividerLabel3 = new SandcastleBuilder.Utils.Controls.DividerLabel();
            this.chkAppendMDFileExt = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.epNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // epNotes
            // 
            this.epNotes.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epNotes.ContainerControl = this;
            this.epNotes.Icon = ((System.Drawing.Icon)(resources.GetObject("epNotes.Icon")));
            // 
            // chkBinaryTOC
            // 
            this.chkBinaryTOC.AutoSize = true;
            this.chkBinaryTOC.Checked = true;
            this.chkBinaryTOC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBinaryTOC.Location = new System.Drawing.Point(256, 86);
            this.chkBinaryTOC.Name = "chkBinaryTOC";
            this.chkBinaryTOC.Size = new System.Drawing.Size(382, 24);
            this.chkBinaryTOC.TabIndex = 3;
            this.chkBinaryTOC.Tag = "BinaryTOC";
            this.chkBinaryTOC.Text = "Create a binary table of contents to reduce load time";
            this.chkBinaryTOC.UseVisualStyleBackColor = true;
            // 
            // dividerLabel1
            // 
            this.dividerLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dividerLabel1.Location = new System.Drawing.Point(3, 7);
            this.dividerLabel1.Name = "dividerLabel1";
            this.dividerLabel1.Size = new System.Drawing.Size(719, 26);
            this.dividerLabel1.TabIndex = 0;
            this.dividerLabel1.Text = "HTML Help 1 (CHM)";
            // 
            // dividerLabel2
            // 
            this.dividerLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dividerLabel2.Location = new System.Drawing.Point(3, 168);
            this.dividerLabel2.Name = "dividerLabel2";
            this.dividerLabel2.Size = new System.Drawing.Size(719, 26);
            this.dividerLabel2.TabIndex = 5;
            this.dividerLabel2.Text = "Website (HTML/ASP.NET) / Open XML (DOCX)";
            // 
            // chkIncludeFavorites
            // 
            this.chkIncludeFavorites.AutoSize = true;
            this.chkIncludeFavorites.Location = new System.Drawing.Point(256, 121);
            this.chkIncludeFavorites.Name = "chkIncludeFavorites";
            this.chkIncludeFavorites.Size = new System.Drawing.Size(345, 24);
            this.chkIncludeFavorites.TabIndex = 4;
            this.chkIncludeFavorites.Tag = "IncludeFavorites";
            this.chkIncludeFavorites.Text = "Include a Favorites tab in the compiled help file";
            this.chkIncludeFavorites.UseVisualStyleBackColor = true;
            // 
            // cboHtmlSdkLinkType
            // 
            this.cboHtmlSdkLinkType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHtmlSdkLinkType.FormattingEnabled = true;
            this.cboHtmlSdkLinkType.Location = new System.Drawing.Point(256, 47);
            this.cboHtmlSdkLinkType.MaxDropDownItems = 16;
            this.cboHtmlSdkLinkType.Name = "cboHtmlSdkLinkType";
            this.cboHtmlSdkLinkType.Size = new System.Drawing.Size(340, 28);
            this.cboHtmlSdkLinkType.TabIndex = 2;
            this.cboHtmlSdkLinkType.Tag = "HtmlSdkLinkType";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(52, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Help &1 SDK link type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboWebsiteSdkLinkType
            // 
            this.cboWebsiteSdkLinkType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWebsiteSdkLinkType.FormattingEnabled = true;
            this.cboWebsiteSdkLinkType.Location = new System.Drawing.Point(342, 207);
            this.cboWebsiteSdkLinkType.MaxDropDownItems = 16;
            this.cboWebsiteSdkLinkType.Name = "cboWebsiteSdkLinkType";
            this.cboWebsiteSdkLinkType.Size = new System.Drawing.Size(340, 28);
            this.cboWebsiteSdkLinkType.TabIndex = 7;
            this.cboWebsiteSdkLinkType.Tag = "WebsiteSdkLinkType";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(29, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "We&bsite/Open XML SDK link type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dividerLabel3
            // 
            this.dividerLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dividerLabel3.Location = new System.Drawing.Point(3, 253);
            this.dividerLabel3.Name = "dividerLabel3";
            this.dividerLabel3.Size = new System.Drawing.Size(719, 26);
            this.dividerLabel3.TabIndex = 8;
            this.dividerLabel3.Text = "Markdown";
            // 
            // chkAppendMDFileExt
            // 
            this.chkAppendMDFileExt.AutoSize = true;
            this.chkAppendMDFileExt.Location = new System.Drawing.Point(111, 282);
            this.chkAppendMDFileExt.Name = "chkAppendMDFileExt";
            this.chkAppendMDFileExt.Size = new System.Drawing.Size(437, 24);
            this.chkAppendMDFileExt.TabIndex = 9;
            this.chkAppendMDFileExt.Tag = "AppendMarkdownFileExtensionsToUrls";
            this.chkAppendMDFileExt.Text = "Include the \'.md\' filename extension on markdown topic URLs";
            this.chkAppendMDFileExt.UseVisualStyleBackColor = true;
            // 
            // Help1WebsitePropertiesPageControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.chkAppendMDFileExt);
            this.Controls.Add(this.dividerLabel3);
            this.Controls.Add(this.cboWebsiteSdkLinkType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboHtmlSdkLinkType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkIncludeFavorites);
            this.Controls.Add(this.dividerLabel2);
            this.Controls.Add(this.dividerLabel1);
            this.Controls.Add(this.chkBinaryTOC);
            this.MinimumSize = new System.Drawing.Size(725, 250);
            this.Name = "Help1WebsitePropertiesPageControl";
            this.Size = new System.Drawing.Size(725, 323);
            ((System.ComponentModel.ISupportInitialize)(this.epNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider epNotes;
        private System.Windows.Forms.CheckBox chkIncludeFavorites;
        private Utils.Controls.DividerLabel dividerLabel2;
        private Utils.Controls.DividerLabel dividerLabel1;
        private System.Windows.Forms.CheckBox chkBinaryTOC;
        private System.Windows.Forms.ComboBox cboHtmlSdkLinkType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboWebsiteSdkLinkType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkAppendMDFileExt;
        private Utils.Controls.DividerLabel dividerLabel3;
    }
}
