using System;
using System.Reflection;

[assembly: AssemblyTitle("Acr.UserDialogs")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Acr.UserDialogs")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

namespace Acr.UserDialogs
{
    public class UserDialogs
    {
        static IUserDialogs currentInstance;
        public static IUserDialogs Instance
        {
            get
            {
                if (currentInstance == null)
                    throw new ArgumentException("[Acr.UserDialogs] This is the bait library, not the platform library.  You must install the nuget package in your main executable/application project");

                return currentInstance;
            }
            set => currentInstance = value;
        }
    }
}
