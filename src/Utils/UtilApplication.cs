// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

using System.Security.Principal;

namespace WindowsCursorSwitcher.Utils
{
    internal static class UtilApplication
    {
        internal static bool IsRunAsAdministrator()
            => new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);

        internal static void ValidateIfRunAsAdministrator()
        {
            if (!IsRunAsAdministrator())
            {

                var dialogResult =
                    MessageBox.Show(
                        $@"The app needs to be run in administrator mode in order to change the ""Windows Variables"" and change the cursors."
                        + Environment.NewLine
                        + "Right Click the Executable > Properties > Shortcut > Advanced > Run as Administrator",
                        "Administrator Privileges Required",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.OK) Application.Exit();
            }
        }
    }
}
