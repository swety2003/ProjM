using MyWidgets.SDK;
using MyWidgets.SDK.Core.SideBar;
using Projm.Controls;
using System;
using System.Collections.Generic;

namespace ProjM
{
    public class PluginInfo : IPlugin
    {
        public Version version { get; } = new Version();
        public string url { get; } = "";
        public string author { get; } = "";


        public PluginInfo()
        {
        }

        public static List<SideBarItemInfo> sbis { get; } = new List<SideBarItemInfo>()
        {
            //DevTest.info
            ProjManager.info

        };



        public string name => "��Ŀ������";



        public IEnumerable<object> GetAllTypeInfo()
        {
            return sbis;
        }
    }
}
