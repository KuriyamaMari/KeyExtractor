using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KeyExtractor
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.toolStripStatusLabel1.Text = "";
            this.statusStrip1.Refresh();
        }

        /// <summary>
        /// Extracts the keys from string.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        private List<string> ExtractKeysFromString(string source)
        {
            MatchCollection m = Regex.Matches(source, "([0-9A-Z]{5})(?:\\-[0-9A-Z]{5}){2,3}",
                  RegexOptions.IgnoreCase | RegexOptions.Singleline);
            List<string> result = new List<string>();
            if (m.Count > 0)
            {
                foreach (Match v in m)
                {
                    result.Add(v.Value);
                }
            }
            return result;
        }

        /// <summary>
        /// Extracts the keys and copy to clipboard.
        /// </summary>
        private void ExtractKeysFromClipBoardAndCopyToClipboard()
        {
            string plainText;
            plainText = Clipboard.GetText();

            List<string> listStrKeys = ExtractKeysFromString(plainText);
            if (listStrKeys.Count > 0)
            {
                string strKeys = string.Join(Environment.NewLine, listStrKeys.ToArray());
                try
                {
                    Clipboard.SetText(strKeys);
                    UpdateToolStripStatusLabel(string.Format("{0} keys have been copied to clipboard", listStrKeys.Count));
                }
                catch
                {
                    MessageBox.Show(strKeys, "Ctrl+C to copy");
                }
            }
            else
            {
                UpdateToolStripStatusLabel(string.Format("No keys have been found."));
            }
        }

        /// <summary>
        /// Updates the tool strip status label.
        /// </summary>
        /// <param name="text">The text.</param>
        private void UpdateToolStripStatusLabel(string text)
        {
            this.toolStripStatusLabel1.Text = text;
            this.statusStrip1.Refresh();
        }

        /// <summary>
        /// Handles the Click event of the buttonExtractKeys control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonExtractKeys_Click(object sender, EventArgs e)
        {
            ExtractKeysFromClipBoardAndCopyToClipboard();
        }
    }
}
