using System;

namespace ConsoleApplication1.classes
{
    abstract class WebsitePage
    {
        public abstract string TabLocator { get; }
        public string basePageUrl { get { return "URL/wpapps/"; }  }
        public string tabsNavigationRow { get { return "tabsNavigationRow"; } }

        public WebsitePage() 
        {
        }

        public T OpenTab<T>(T Tab) where T: WebsitePage
        {
            Console.WriteLine($"******this.GetType()*************** {this.GetType()} *********************");
            Console.WriteLine($"*******Tab.GetType()************** {Tab.GetType()} *********************");
            Console.WriteLine($"*********thisLinkLocator************tabLinkLocator = {this.TabLocator} *********************");
            Console.WriteLine($"*********tabLinkLocator************tabLinkLocator = {Tab.TabLocator} *********************");

            return (T)Activator.CreateInstance(typeof(T));
        }
    }
}
