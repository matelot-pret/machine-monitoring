using System;
using System.Collections.Generic;
using System.Text;

namespace configApp
{
    public class ScreenManager
    {
        private readonly List<UserControl> listScreens;


        /*
         * constructor takes a list of panels, can also take one panel*/
        public ScreenManager(params UserControl[] list)
        {
            listScreens = new List<UserControl>(list);

            foreach(Control panel in list)
            {
                panel.Visible = false;
            }
            listScreens[0].Visible = true;
        }

        /*
         * Show a panel
         * param panel : the panel to hide 
         * the panel object mustn't be null
         */
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
