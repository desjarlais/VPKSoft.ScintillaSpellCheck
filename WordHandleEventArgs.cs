using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPKSoft.ScintillaSpellCheck
{
    /// <summary>
    /// Event arguments for the ignore word and add a word to dictionary events.
    /// Implements the <see cref="System.EventArgs" />
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public class WordHandleEventArgs: EventArgs
    {
        /// <summary>
        /// Gets or sets the word which is either requested to be ignored or to be requested to be added to the dictionary.
        /// </summary>
        /// <value>The word.</value>
        public string Word { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to add the word to the ignore list.
        /// </summary>
        public bool AddToIgnore { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to add the word to the dictionary.
        /// </summary>
        public bool AddToDictionary { get; set; }
    }
}
