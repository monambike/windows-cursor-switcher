// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

using Microsoft.Win32;


namespace WindowsCursorSwitcher.Utils
{
    internal static class UtilRegedit
    {
        internal static string RegeditCursorSchemesPath => @"Computer\HKEY_CURRENT_USER\Control Panel\Cursors\Schemes";

        internal static void ModifyKeyValue(string keyName, string keyValue)
        {
            using RegistryKey? registryKey = Registry.LocalMachine.OpenSubKey(RegeditCursorSchemesPath, true);

            if (registryKey != null)
            {
                registryKey.SetValue(keyName, keyValue, RegistryValueKind.String);
                registryKey.Close();
            }
        }

        internal static void Add()
        {
            string schemaName = string.Empty;
            
            string schemaPaths = string.Empty;

            ModifyKeyValue(schemaName, schemaPaths);
        }
    }
}
