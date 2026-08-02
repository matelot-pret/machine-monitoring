using System;
using System.Collections.Generic;
using System.Text;

namespace configApp
{
    public class ScreenManager
    {
        private readonly List<UserControl> listScreens;


        /// <summary>
        /// Stores the screens, hides them all, shows them when asked
        /// </summary>
        /// <param name="list"> the screens to manage(one or more)</param>
        public ScreenManager(params UserControl[] list)
        {
            listScreens = new List<UserControl>(list);

            foreach(Control panel in list)
            {
                panel.Visible = false;
            }
            listScreens[0].Visible = true;
        }

        /// <summary>
        /// hides every managed screen then shows the given one
        /// </summary>
        /// <param name="panel"> the screen to show</param>
        /// <note>panel must not be null</note>
        public void Show(Control panel)
        {
            foreach (Control p in listScreens)
            {
                p.Visible = false;
            }
            panel.Visible = true;
        }
    }
}
