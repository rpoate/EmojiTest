﻿namespace EmojiTest
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
            this.components = new System.ComponentModel.Container();
            this.htmlEditControl1 = new Zoople.HTMLEditControl();
            this.SuspendLayout();
            // 
            // htmlEditControl1
            // 
            this.htmlEditControl1.AcceptsReturn = true;
            this.htmlEditControl1.BaseURL = null;
            this.htmlEditControl1.CleanMSWordHTMLOnPaste = true;
            this.htmlEditControl1.CodeEditor.Enabled = true;
            this.htmlEditControl1.CodeEditor.Font = new System.Drawing.Font("Courier New", 10F);
            this.htmlEditControl1.CodeEditor.Locked = false;
            this.htmlEditControl1.CodeEditor.TabWidth = 720;
            this.htmlEditControl1.CodeEditor.WordWrap = false;
            this.htmlEditControl1.CSSText = null;
            this.htmlEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlEditControl1.DocumentHTML = null;
            this.htmlEditControl1.EnableInlineSpelling = false;
            this.htmlEditControl1.FontSizesList = null;
            this.htmlEditControl1.FontsList = null;
            this.htmlEditControl1.HiddenButtons = null;
            this.htmlEditControl1.ImageStorageLocation = null;
            this.htmlEditControl1.InCodeView = false;
            this.htmlEditControl1.IndentAmount = 2;
            this.htmlEditControl1.IndentsUseBlockuote = false;
            this.htmlEditControl1.LanguageFile = null;
            this.htmlEditControl1.LicenceActivationKey = null;
            this.htmlEditControl1.LicenceKey = null;
            this.htmlEditControl1.LicenceKeyInlineSpelling = null;
            this.htmlEditControl1.Location = new System.Drawing.Point(0, 0);
            this.htmlEditControl1.Name = "htmlEditControl1";
            this.htmlEditControl1.Size = new System.Drawing.Size(800, 450);
            this.htmlEditControl1.TabIndex = 0;
            this.htmlEditControl1.ToolstripImageScalingSize = new System.Drawing.Size(16, 16);
            this.htmlEditControl1.UseParagraphAsDefault = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.htmlEditControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Zoople.HTMLEditControl htmlEditControl1;
    }
}

