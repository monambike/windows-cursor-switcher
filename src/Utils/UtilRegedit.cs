// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

using Microsoft.Win32;
using WindowsCursorSwitcher.Entities;


namespace WindowsCursorSwitcher.Utils
{
    internal static class UtilRegedit
    {
        internal static string RegeditCursorSchemesPath => @"Control Panel\Cursors\Schemes";

        internal static void ModifyKeyValue(string keyName, string keyValue)
        {
            try
            {
                using RegistryKey? registryKey = Registry.CurrentUser.OpenSubKey(RegeditCursorSchemesPath, true);

                if (registryKey != null)
                {
                    registryKey.SetValue(keyName, keyValue, RegistryValueKind.String);
                    registryKey.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An exception occurred: {ex.Message} while trying to modify key values from Windows Registry Editor (regedit).");
                throw;
            }
        }

        internal static List<RegeditKeyValue> ReadKeyValues()
        {
            try
            {
                using RegistryKey? registryKey = Registry.CurrentUser.OpenSubKey(RegeditCursorSchemesPath);

                if (registryKey != null)
                {
                    string[] registryKeyValueNames = registryKey.GetValueNames();


                    List<RegeditKeyValue> regeditKeyValues = [];
                    foreach (var registryKeyValueName in registryKeyValueNames)
                    {
                        var regeditKeyValue = new RegeditKeyValue(registryKeyValueName, registryKey.GetValue(registryKeyValueName), registryKey.GetValueKind(registryKeyValueName));
                        regeditKeyValues.Add(regeditKeyValue);
                    }

                    return regeditKeyValues;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An exception occurred: {ex.Message} while trying to read key values from Windows Registry Editor (regedit).");
                throw;
            }
            return [];
        }
    }
}
