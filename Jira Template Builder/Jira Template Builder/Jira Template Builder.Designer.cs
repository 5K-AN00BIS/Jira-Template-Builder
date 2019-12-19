// Built and designed by Ryan Bachman.
// Ops Commander Team
// Uber Technologies
// July 25, 2019

namespace Jira_Template_Builder
{
    partial class JiraTB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JiraTB));
            this.build = new System.Windows.Forms.Button();
            this.JENGIDlabel = new System.Windows.Forms.Label();
            this.teamBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tempID = new System.Windows.Forms.TextBox();
            this.JENGNameLabel = new System.Windows.Forms.Label();
            this.assigneeBox = new System.Windows.Forms.TextBox();
            this.assigneeTT = new System.Windows.Forms.ToolTip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.teamTT = new System.Windows.Forms.ToolTip(this.components);
            this.descTT = new System.Windows.Forms.ToolTip(this.components);
            this.idTT = new System.Windows.Forms.ToolTip(this.components);
            this.tagsTT = new System.Windows.Forms.ToolTip(this.components);
            this.subsTT = new System.Windows.Forms.ToolTip(this.components);
            this.summaryLabel = new System.Windows.Forms.Label();
            this.summaryText = new System.Windows.Forms.TextBox();
            this.APILink = new System.Windows.Forms.LinkLabel();
            this.JENGTeamSearch = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // build
            // 
            this.build.BackColor = System.Drawing.Color.Black;
            this.build.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.build.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.build.Location = new System.Drawing.Point(162, 517);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(473, 62);
            this.build.TabIndex = 0;
            this.build.Text = "Build Template";
            this.build.UseVisualStyleBackColor = false;
            this.build.Click += new System.EventHandler(this.Button1_Click);
            // 
            // JENGIDlabel
            // 
            this.JENGIDlabel.AutoSize = true;
            this.JENGIDlabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JENGIDlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JENGIDlabel.Location = new System.Drawing.Point(12, 196);
            this.JENGIDlabel.Name = "JENGIDlabel";
            this.JENGIDlabel.Size = new System.Drawing.Size(101, 44);
            this.JENGIDlabel.TabIndex = 1;
            this.JENGIDlabel.Text = "JENG Team \r\nID";
            this.JENGIDlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.JENGIDlabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // teamBox
            // 
            this.teamBox.Location = new System.Drawing.Point(117, 211);
            this.teamBox.Name = "teamBox";
            this.teamBox.Size = new System.Drawing.Size(682, 20);
            this.teamBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(117, 251);
            this.descBox.Multiline = true;
            this.descBox.Name = "descBox";
            this.descBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descBox.Size = new System.Drawing.Size(682, 188);
            this.descBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(17, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 44);
            this.label3.TabIndex = 5;
            this.label3.Text = "Template\r\nIdentifier";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // tempID
            // 
            this.tempID.Location = new System.Drawing.Point(117, 454);
            this.tempID.Name = "tempID";
            this.tempID.Size = new System.Drawing.Size(682, 20);
            this.tempID.TabIndex = 6;
            // 
            // JENGNameLabel
            // 
            this.JENGNameLabel.AutoSize = true;
            this.JENGNameLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JENGNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JENGNameLabel.Location = new System.Drawing.Point(12, 140);
            this.JENGNameLabel.Name = "JENGNameLabel";
            this.JENGNameLabel.Size = new System.Drawing.Size(97, 44);
            this.JENGNameLabel.TabIndex = 11;
            this.JENGNameLabel.Text = "JENG Team\r\nName";
            this.JENGNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.JENGNameLabel.Click += new System.EventHandler(this.Label6_Click);
            // 
            // assigneeBox
            // 
            this.assigneeBox.Location = new System.Drawing.Point(117, 154);
            this.assigneeBox.Name = "assigneeBox";
            this.assigneeBox.Size = new System.Drawing.Size(682, 20);
            this.assigneeBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(249, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 39);
            this.label7.TabIndex = 13;
            this.label7.Text = "Jira Template Builder";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(218, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(380, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Pro Tip: Click the label text for more information!";
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.summaryLabel.Location = new System.Drawing.Point(17, 101);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(84, 22);
            this.summaryLabel.TabIndex = 15;
            this.summaryLabel.Text = "Summary";
            this.summaryLabel.Click += new System.EventHandler(this.Label9_Click);
            // 
            // summaryText
            // 
            this.summaryText.Location = new System.Drawing.Point(117, 104);
            this.summaryText.Name = "summaryText";
            this.summaryText.Size = new System.Drawing.Size(682, 20);
            this.summaryText.TabIndex = 16;
            // 
            // APILink
            // 
            this.APILink.AutoSize = true;
            this.APILink.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APILink.Location = new System.Drawing.Point(381, 177);
            this.APILink.Name = "APILink";
            this.APILink.Size = new System.Drawing.Size(140, 26);
            this.APILink.TabIndex = 17;
            this.APILink.TabStop = true;
            this.APILink.Text = "JIRA API Link";
            this.APILink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.APILink_LinkClicked);
            // 
            // JENGTeamSearch
            // 
            this.JENGTeamSearch.AutoSize = true;
            this.JENGTeamSearch.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JENGTeamSearch.Location = new System.Drawing.Point(360, 125);
            this.JENGTeamSearch.Name = "JENGTeamSearch";
            this.JENGTeamSearch.Size = new System.Drawing.Size(183, 26);
            this.JENGTeamSearch.TabIndex = 18;
            this.JENGTeamSearch.TabStop = true;
            this.JENGTeamSearch.Text = "JENG Team Search";
            this.JENGTeamSearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.JENGTeamSearch_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Don\'t forget to add Ops Commander team emails as Watchers!";
            // 
            // JiraTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(811, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JENGTeamSearch);
            this.Controls.Add(this.APILink);
            this.Controls.Add(this.summaryText);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.assigneeBox);
            this.Controls.Add(this.JENGNameLabel);
            this.Controls.Add(this.tempID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teamBox);
            this.Controls.Add(this.JENGIDlabel);
            this.Controls.Add(this.build);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JiraTB";
            this.Text = "Jira Template Builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button build;
        private System.Windows.Forms.Label JENGIDlabel;
        private System.Windows.Forms.TextBox teamBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tempID;
        private System.Windows.Forms.Label JENGNameLabel;
        private System.Windows.Forms.TextBox assigneeBox;
        private System.Windows.Forms.ToolTip assigneeTT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip teamTT;
        private System.Windows.Forms.ToolTip descTT;
        private System.Windows.Forms.ToolTip idTT;
        private System.Windows.Forms.ToolTip tagsTT;
        private System.Windows.Forms.ToolTip subsTT;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.TextBox summaryText;
        private System.Windows.Forms.LinkLabel APILink;
        private System.Windows.Forms.LinkLabel JENGTeamSearch;
        private System.Windows.Forms.Label label1;
    }
}

