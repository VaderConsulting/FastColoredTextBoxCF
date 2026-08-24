using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace TesterNS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            fastColoredTextBox1.Text = @"    #region Char

    /// <summary>
    /// Char and style
    /// </summary>
    struct Char
    {
        public char c;
        public StyleIndex style;

        public Char(char c)
        {
            this.c = c;
            style = StyleIndex.None;
        }
    }
    #endregion";
            //move caret to start text
            fastColoredTextBox1.Selection.Start = Place.Empty;
            fastColoredTextBox1.DoCaretVisible();
            fastColoredTextBox1.IsChanged = false;
            fastColoredTextBox1.ClearUndo();
        }
    }
}