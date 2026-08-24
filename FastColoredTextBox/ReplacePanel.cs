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
    internal partial class ReplacePanel : UserControl
    {
        public bool firstSearch = true;
        Place startPlace;

        public ReplacePanel()
        {
            InitializeComponent();
        }

        FastColoredTextBox tb
        {
            get { return Parent as FastColoredTextBox; }
        }

        private void btFindNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Find())
                    MessageBox.Show("Not found");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        List<Range> FindAll()
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
            range.Start = range.End;
            range.End = new Place(tb.GetLineLength(tb.LinesCount - 1), tb.LinesCount - 1);
            //
            List<Range> list = new List<Range>();
            foreach (var r in range.GetRanges(pattern, opt))
                list.Add(r);

            return list;
        }

        bool Find()
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
                tb.Selection.Start = r.Start;
                tb.Selection.End = r.End;
                tb.DoSelectionVisible();
                tb.Invalidate();
                return true;
            }
            if (range.Start >= startPlace && startPlace > Place.Empty)
            {
                tb.Selection.Start = new Place(0, 0);
                return Find();
            }
            return false;
        }

        private void tbFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btFindNext_Click(sender, null);
                return;
            }
            if (e.KeyChar == '\x1b')
            {
                Hide();
                tb.OnResize();
                tb.needRecalc = true;
                return;
            }

            firstSearch = true;
        }

        private void btReplace_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb.SelectionLength != 0)
                    tb.InsertText(tbReplace.Text);
                btFindNext_Click(sender, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btReplaceAll_Click(object sender, EventArgs e)
        {
            try
            {
                tb.Selection.BeginUpdate();
                tb.Selection.Start = new Place(0, 0);
                //search
                var ranges = FindAll();
                //replace
                if (ranges.Count > 0)
                {
                    tb.manager.ExecuteCommand(new ReplaceTextCommand(tb, ranges, tbReplace.Text));
                    tb.Selection.Start = new Place(0, 0);
                }
                //
                tb.Invalidate();
                MessageBox.Show(ranges.Count + " occurrence(s) replaced");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            tb.Selection.EndUpdate();
        }
    }
}
