// Copyright(c) 2024 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

using Microsoft.Win32;

namespace WindowsCursorSwitcher.Utils
{
    internal static class UtilRegedit
    {
        internal static string RegeditSchemesPath => @"Computer\HKEY_CURRENT_USER\Control Panel\Cursors\Schemes";

        internal static void ModifyKeyValue(string keyName, string keyValue)
        {
            using RegistryKey? registryKey = Registry.LocalMachine.OpenSubKey(RegeditSchemesPath, true);

            if (registryKey != null)
            {
                registryKey.SetValue(keyName, keyValue, RegistryValueKind.String);
                registryKey.Close();
            }
        }
    }
}
