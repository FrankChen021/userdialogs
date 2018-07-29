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
                currentInstance = currentInstance ?? new UserDialogsImpl();
                return currentInstance;
            }
            set => currentInstance = value;
        }
    }
}
