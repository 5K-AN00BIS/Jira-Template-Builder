// Built and designed by Ryan Bachman.
// Ops Commander Team
// Uber Technologies
// July 25, 2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Jira_Template_Builder
{
    class Encode
    {
        public string rawData;

        public static string UrlEncode(string encoded, System.Text.Encoding Enc)
        {
            return encoded;
        }

        public Encode(string jiraSummary, string jengTeam, string jiraDescription, string templateID)
        {
            rawData = "https://jeng.REDACTED.com/secure/CreateIssueDetails!init.jspa?issuetype=10006&summary=" + System.Uri.EscapeUriString(jiraSummary) +
                "&pid=" + jengTeam + "&description=" + System.Uri.EscapeUriString(jiraDescription) + "%0A%0A" +
                System.Uri.EscapeUriString("*Template Identifier (For OC Use Only):* ") + System.Uri.EscapeUriString(templateID);

            Clipboard.SetText(rawData);
            MessageBox.Show("Your template has been built. Press Ctrl+V to paste it where you need!");
        }
    }
}