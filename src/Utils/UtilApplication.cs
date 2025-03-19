using System.Security.Principal;

namespace WindowsCursorSwitcher.Utils
{
    internal class UtilApplication
    {
        public static bool IsRunAsAdministrator()
            => new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
    }
}
