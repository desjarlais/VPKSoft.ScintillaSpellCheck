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

namespace VPKSoft.ScintillaSpellCheck
{
    /// <summary>
    /// Event arguments for the ignore word, add a word to dictionary and replace word events.
    /// Implements the <see cref="System.EventArgs" />
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public class WordHandleEventArgs: EventArgs
    {
        /// <summary>
        /// Gets or sets the word which is either requested to be ignored or to be requested to be added to the dictionary.
        /// </summary>
        public string Word { get; set; }

        /// <summary>
        /// Gets or set the word the user chose to replace with a <seealso cref="WordTo"/>
        /// </summary>
        public string WordFrom { get; set; }

        /// <summary>
        /// Gets or set a word the user is replaced the misspelled ford to.
        /// </summary>
        public string WordTo { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to add the word to the ignore list.
        /// </summary>
        public bool AddToIgnore { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to add the word to the dictionary.
        /// </summary>
        public bool AddToDictionary { get; set; }

        /// <summary>
        /// Gets or set a value indicating whether the event in question is a user initiated word correct.
        /// </summary>
        public bool IsWordReplace { get; set; }

        /// <summary>
        /// Gets the <see cref="ScintillaSpellCheck"/> instance which raised the event.
        /// </summary>
        public ScintillaSpellCheck ScintillaSpellCheck { get; internal set; }
    }
}
