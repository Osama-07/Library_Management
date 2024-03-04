using LibraryBusiness;
using System.Reflection;
using Util;

namespace Library_Management.Global
{
    public class clsGlobal
    {
        private static string _SourceName = Assembly.GetExecutingAssembly().GetName().Name;
        private static string _Location = Assembly.GetExecutingAssembly().Location; // 
        private static string _DestinationFolder = @"G:\Library_Management_Images\"; // folder for save books images.

        public static clsUsers CurrentUser 
        { 
            get
            {
                return clsUsers.FindByUser_ID(2);
            }
        }

        public clsUtil Util = new clsUtil(_SourceName, _Location, _DestinationFolder);
    }
}
