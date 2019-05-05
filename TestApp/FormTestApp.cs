#region License
/*
MIT License

Copyright(c) 2019 Petteri Kautonen

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion

using System;
using System.IO;
using System.Windows.Forms;
using VPKSoft.ScintillaSpellCheck;

namespace TestApp
{
    public partial class FormTestApp : Form
    {
        public FormTestApp()
        {
            InitializeComponent();
        }

        private void MnuOpen_Click(object sender, EventArgs e)
        {
            if (odAnyFile.ShowDialog() == DialogResult.OK)
            {
                scintilla.Text = File.ReadAllText(odAnyFile.FileName);
            }
        }

        private void MnuSpellCheck_Click(object sender, EventArgs e)
        {
            //scintilla.ContextMenuStrip = cmsTest; // comment this in case not needed for testing..

            ScintillaSpellCheck spellCheck = new ScintillaSpellCheck(scintilla,
                @"C:\Files\GitHub\dictionaries\en\en_US.dic", @"C:\Files\GitHub\dictionaries\en\en_US.aff");

            spellCheck.ToExistingMenu = false;
            spellCheck.ShowIgnoreMenu = true;
            spellCheck.ShowAddToDictionaryMenu = true;

            spellCheck.SpellCheckScintilla();
        }
    }
}
