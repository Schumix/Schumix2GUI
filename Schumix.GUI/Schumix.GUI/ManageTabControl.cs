using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schumix.GUI
{
    class ManageTabControl
    {
        public static MainForm form;

        public ManageTabControl()
        {
            
        }

        ~ManageTabControl()
        {

        }

        /// <summary>
        /// Ha a bot új szobába lép, akkor egy új fület add hozzá
        /// </summary>
        /// <param name="channelName">A fül szövege</param>
        public static void OnJoin(string channelName)
        {
            form.tabControl.TabPages.Add(channelName);
        }

        public static void OnPart(string channelName)
        {
            form.tabControl.TabPages.Add(channelName);
        }
    }
}
