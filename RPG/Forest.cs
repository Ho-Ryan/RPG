using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Forest
    {
        /// <summary>
        /// Commence un event
        /// </summary>
        /// <param name="eventWatcher">Label</param>
        public static void EnterForest(Label eventWatcher, KeyEventArgs e)
        {
            eventWatcher.Text += ("Vous aller dans la forêt\n");

        }
    }
}
