﻿namespace DLEDotNet.Editor.Layouts.Vertical
{
    partial class VerticalPreferencesMisc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.prefsExpertmodeCheckBox = new System.Windows.Forms.CheckBox();
            this.prefsSplashscreenCheckBox = new System.Windows.Forms.CheckBox();
            this.prefsPlayerTextBox = new System.Windows.Forms.TextBox();
            this.prefsUsetexcolorsCheckBox = new System.Windows.Forms.CheckBox();
            this.alignableGroupBoxVerbosity = new DLEDotNet.Editor.AlignableGroupBox();
            this.alignableGroupBoxPlayerProfile = new DLEDotNet.Editor.AlignableGroupBox();
            this.alignableGroupBoxFaceLightSettings = new DLEDotNet.Editor.AlignableGroupBox();
            this.alignableGroupBox1 = new DLEDotNet.Editor.AlignableGroupBox();
            this.buttonImportINI = new System.Windows.Forms.Button();
            this.buttonExportXML = new System.Windows.Forms.Button();
            this.buttonImportXML = new System.Windows.Forms.Button();
            this.buttonResetDefaults = new System.Windows.Forms.Button();
            this.alignableGroupBoxVerbosity.SuspendLayout();
            this.alignableGroupBoxPlayerProfile.SuspendLayout();
            this.alignableGroupBoxFaceLightSettings.SuspendLayout();
            this.alignableGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prefsExpertmodeCheckBox
            // 
            this.prefsExpertmodeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.prefsExpertmodeCheckBox.Location = new System.Drawing.Point(12, 21);
            this.prefsExpertmodeCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.prefsExpertmodeCheckBox.Name = "prefsExpertmodeCheckBox";
            this.prefsExpertmodeCheckBox.Size = new System.Drawing.Size(220, 18);
            this.prefsExpertmodeCheckBox.TabIndex = 0;
            this.prefsExpertmodeCheckBox.Text = "stop askin\' those questions all the time! ;-)";
            // 
            // prefsSplashscreenCheckBox
            // 
            this.prefsSplashscreenCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.prefsSplashscreenCheckBox.Location = new System.Drawing.Point(12, 41);
            this.prefsSplashscreenCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.prefsSplashscreenCheckBox.Name = "prefsSplashscreenCheckBox";
            this.prefsSplashscreenCheckBox.Size = new System.Drawing.Size(206, 18);
            this.prefsSplashscreenCheckBox.TabIndex = 1;
            this.prefsSplashscreenCheckBox.Text = "show splash screen on program start";
            // 
            // prefsPlayerTextBox
            // 
            this.prefsPlayerTextBox.Location = new System.Drawing.Point(6, 28);
            this.prefsPlayerTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.prefsPlayerTextBox.Name = "prefsPlayerTextBox";
            this.prefsPlayerTextBox.Size = new System.Drawing.Size(94, 20);
            this.prefsPlayerTextBox.TabIndex = 0;
            this.prefsPlayerTextBox.TabStop = false;
            this.prefsPlayerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prefsUsetexcolorsCheckBox
            // 
            this.prefsUsetexcolorsCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.prefsUsetexcolorsCheckBox.Location = new System.Drawing.Point(14, 29);
            this.prefsUsetexcolorsCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.prefsUsetexcolorsCheckBox.Name = "prefsUsetexcolorsCheckBox";
            this.prefsUsetexcolorsCheckBox.Size = new System.Drawing.Size(87, 16);
            this.prefsUsetexcolorsCheckBox.TabIndex = 0;
            this.prefsUsetexcolorsCheckBox.Text = "apply globally";
            // 
            // alignableGroupBoxVerbosity
            // 
            this.alignableGroupBoxVerbosity.Controls.Add(this.prefsExpertmodeCheckBox);
            this.alignableGroupBoxVerbosity.Controls.Add(this.prefsSplashscreenCheckBox);
            this.alignableGroupBoxVerbosity.Location = new System.Drawing.Point(32, 75);
            this.alignableGroupBoxVerbosity.Margin = new System.Windows.Forms.Padding(0);
            this.alignableGroupBoxVerbosity.Name = "alignableGroupBoxVerbosity";
            this.alignableGroupBoxVerbosity.Padding = new System.Windows.Forms.Padding(0);
            this.alignableGroupBoxVerbosity.Size = new System.Drawing.Size(236, 67);
            this.alignableGroupBoxVerbosity.TabIndex = 0;
            this.alignableGroupBoxVerbosity.TabStop = false;
            this.alignableGroupBoxVerbosity.Text = "Verbosity";
            // 
            // alignableGroupBoxPlayerProfile
            // 
            this.alignableGroupBoxPlayerProfile.Controls.Add(this.prefsPlayerTextBox);
            this.alignableGroupBoxPlayerProfile.Location = new System.Drawing.Point(33, 5);
            this.alignableGroupBoxPlayerProfile.Margin = new System.Windows.Forms.Padding(0);
            this.alignableGroupBoxPlayerProfile.Name = "alignableGroupBoxPlayerProfile";
            this.alignableGroupBoxPlayerProfile.Padding = new System.Windows.Forms.Padding(0);
            this.alignableGroupBoxPlayerProfile.Size = new System.Drawing.Size(114, 67);
            this.alignableGroupBoxPlayerProfile.TabIndex = 1;
            this.alignableGroupBoxPlayerProfile.TabStop = false;
            this.alignableGroupBoxPlayerProfile.Text = "player profile";
            // 
            // alignableGroupBoxFaceLightSettings
            // 
            this.alignableGroupBoxFaceLightSettings.Controls.Add(this.prefsUsetexcolorsCheckBox);
            this.alignableGroupBoxFaceLightSettings.Location = new System.Drawing.Point(153, 5);
            this.alignableGroupBoxFaceLightSettings.Margin = new System.Windows.Forms.Padding(0);
            this.alignableGroupBoxFaceLightSettings.Name = "alignableGroupBoxFaceLightSettings";
            this.alignableGroupBoxFaceLightSettings.Padding = new System.Windows.Forms.Padding(0);
            this.alignableGroupBoxFaceLightSettings.Size = new System.Drawing.Size(114, 67);
            this.alignableGroupBoxFaceLightSettings.TabIndex = 2;
            this.alignableGroupBoxFaceLightSettings.TabStop = false;
            this.alignableGroupBoxFaceLightSettings.Text = "face light settings";
            // 
            // alignableGroupBox1
            // 
            this.alignableGroupBox1.Controls.Add(this.buttonResetDefaults);
            this.alignableGroupBox1.Controls.Add(this.buttonImportINI);
            this.alignableGroupBox1.Controls.Add(this.buttonExportXML);
            this.alignableGroupBox1.Controls.Add(this.buttonImportXML);
            this.alignableGroupBox1.Location = new System.Drawing.Point(32, 250);
            this.alignableGroupBox1.Name = "alignableGroupBox1";
            this.alignableGroupBox1.Size = new System.Drawing.Size(235, 88);
            this.alignableGroupBox1.TabIndex = 5;
            this.alignableGroupBox1.TabStop = false;
            this.alignableGroupBox1.Text = "setting management";
            // 
            // buttonImportINI
            // 
            this.buttonImportINI.Location = new System.Drawing.Point(9, 53);
            this.buttonImportINI.Name = "buttonImportINI";
            this.buttonImportINI.Size = new System.Drawing.Size(106, 23);
            this.buttonImportINI.TabIndex = 5;
            this.buttonImportINI.Text = "Import DLE.INI";
            this.buttonImportINI.UseVisualStyleBackColor = true;
            // 
            // buttonExportXML
            // 
            this.buttonExportXML.Location = new System.Drawing.Point(120, 26);
            this.buttonExportXML.Name = "buttonExportXML";
            this.buttonExportXML.Size = new System.Drawing.Size(106, 23);
            this.buttonExportXML.TabIndex = 4;
            this.buttonExportXML.Text = "Export settings";
            this.buttonExportXML.UseVisualStyleBackColor = true;
            // 
            // buttonImportXML
            // 
            this.buttonImportXML.Location = new System.Drawing.Point(9, 26);
            this.buttonImportXML.Name = "buttonImportXML";
            this.buttonImportXML.Size = new System.Drawing.Size(106, 23);
            this.buttonImportXML.TabIndex = 3;
            this.buttonImportXML.Text = "Import settings";
            this.buttonImportXML.UseVisualStyleBackColor = true;
            // 
            // buttonResetDefaults
            // 
            this.buttonResetDefaults.Location = new System.Drawing.Point(120, 53);
            this.buttonResetDefaults.Name = "buttonResetDefaults";
            this.buttonResetDefaults.Size = new System.Drawing.Size(106, 23);
            this.buttonResetDefaults.TabIndex = 7;
            this.buttonResetDefaults.Text = "Reset defaults";
            this.buttonResetDefaults.UseVisualStyleBackColor = true;
            // 
            // VerticalPreferencesMisc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.alignableGroupBox1);
            this.Controls.Add(this.alignableGroupBoxVerbosity);
            this.Controls.Add(this.alignableGroupBoxPlayerProfile);
            this.Controls.Add(this.alignableGroupBoxFaceLightSettings);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VerticalPreferencesMisc";
            this.Size = new System.Drawing.Size(300, 341);
            this.alignableGroupBoxVerbosity.ResumeLayout(false);
            this.alignableGroupBoxPlayerProfile.ResumeLayout(false);
            this.alignableGroupBoxPlayerProfile.PerformLayout();
            this.alignableGroupBoxFaceLightSettings.ResumeLayout(false);
            this.alignableGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox prefsExpertmodeCheckBox;
        private System.Windows.Forms.CheckBox prefsSplashscreenCheckBox;
        private System.Windows.Forms.TextBox prefsPlayerTextBox;
        private System.Windows.Forms.CheckBox prefsUsetexcolorsCheckBox;
        private AlignableGroupBox alignableGroupBoxVerbosity;
        private AlignableGroupBox alignableGroupBoxPlayerProfile;
        private AlignableGroupBox alignableGroupBoxFaceLightSettings;
        private AlignableGroupBox alignableGroupBox1;
        private System.Windows.Forms.Button buttonImportINI;
        private System.Windows.Forms.Button buttonExportXML;
        private System.Windows.Forms.Button buttonImportXML;
        private System.Windows.Forms.Button buttonResetDefaults;
    }
}
