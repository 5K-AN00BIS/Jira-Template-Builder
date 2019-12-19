// Built and designed by Ryan Bachman.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Jira_Template_Builder
{
    public partial class JiraTB : Form
    {
        public string title;
        public string phid;
        public string assignee;
        public string description;
        public string identifier;
        public string tags;
        public string subscribers;

        public JiraTB()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Called when the Build Template button is clicked. Handles the URL building and encoding.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            title = summaryText.Text;
            phid = teamBox.Text;
            assignee = assigneeBox.Text;
            description = descBox.Text;
            identifier = tempID.Text;

            Encode enc = new Encode(title, phid, description, identifier);
        }

        // Displays a message box on how to use the Title box.
        private void Label9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Summary will be the Jira name. Please write something to summarize the issue but still be descriptive.", "Summary");
        }

        // Displays a message box on how to use the Phab Team box.
        private void Label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click the API search using the link above. Find the id field and copy the number into this text box.", "JENG Team ID");
        }

        // Displays a message box on how to use the Assignee box.
        private void Label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Type in the team name from the parentheses using the search link above.", "JENG Team Name");
        }

        // Displays a message box on how to use the Description box.
        private void Label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paste Description you want to use. It's easier to build and you can see the preview in Jira. Bold is surrounded by single * on each side.", "Description");
        }

        // Displays a message box on how to use the Template Identifier box.
        private void Label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter it like this: BUG - 1 (You want the spaces on each end of the dash).", "Template Identifier");
        }

        // Displays a message box on how to use the Subscribers box.
        private void Label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can add watchers here by email address.", "Watchers");
        }

        private void APILink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string apiSearch = @"https://jeng.REDACTED.com/rest/api/2/project/";
            Process.Start(apiSearch + assigneeBox.Text);
        }

        private void JENGTeamSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"https://jeng.REDACTED.com/secure/CreateIssue!default.jspa");
        }
    }
}