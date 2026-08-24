using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FastColoredTextBoxNS
{
    internal partial class FindPanel : UserControl
    {
        public bool firstSearch = true;
        Place startPlace;

        FastColoredTextBox tb
        {
            get { return Parent as FastColoredTextBox; }
        }

        public FindPanel()
        {
            InitializeComponent();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            FindNext();
        }

        private void FindNext()
        {
            try
            {
                string pattern = tbFind.Text;
                RegexOptions opt = ((tb.FindSettings & FindSettings.MatchCase) != 0) ? RegexOptions.None : RegexOptions.IgnoreCase;
                if ((tb.FindSettings & FindSettings.Regex) == 0)
                    pattern = Regex.Replace(pattern, FastColoredTextBox.RegexSpecSymbolsPattern, "\\$0");
                if ((tb.FindSettings & FindSettings.MatchWholeWord) != 0)
                    pattern = "\\b" + pattern + "\\b";
                //
                Range range = tb.Selection.Clone();
                range.Normalize();
                //
                if (firstSearch)
                {
                    startPlace = range.Start;
                    firstSearch = false;
                }
                //
                range.Start = range.End;
                if (range.Start >= startPlace)
                    range.End = new Place(tb.GetLineLength(tb.LinesCount - 1), tb.LinesCount - 1);
                else
                    range.End = startPlace;
                //
                foreach (var r in range.GetRanges(pattern, opt))
                {
                    tb.Selection = r;
                    tb.DoSelectionVisible();
                    tb.Invalidate();
                    return;
                }
                //
                if (range.Start >= startPlace && startPlace > Place.Empty)
                {
                    tb.Selection.Start = new Place(0, 0);
                    FindNext();
                    return;
                }
                MessageBox.Show("Not found");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                FindNext();
                e.Handled = true;
                return;
            }
            if (e.KeyChar == '\x1b')
            {
                Hide();
                e.Handled = true;
                tb.OnResize();
                tb.needRecalc = true;
                return;
            }
            firstSearch = true;
        }
    }
}
