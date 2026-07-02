using System;
using System.Collections.Generic;
using System.Text;

namespace configApp
{
    public class PanelManager
    {
        private List<Panel> listPanels;


        /*
         * constructor takes a list of panels, can also take one panel*/
        public PanelManager(params Panel[] list)
        {
            listPanels = new List<Panel>(list);

            foreach(Panel panel in list)
            {
                panel.Visible = false;
            }
            listPanels[0].Visible = true;
        }

        /*
         * Show a panel
         * param panel : the panel to hide 
         * the panel object mustn't be null
         */
        public void Show(Panel panel)
        {
            foreach (Panel p in listPanels)
            {
                p.Visible = false;
            }
            panel.Visible = true;
        }
    }
}
