// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

using Microsoft.Win32;
using static WindowsCursorSwitcher.MainForm;


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
            catch (Exception ex)  //just for demonstration...it's always best to handle specific exceptions
            {
                Console.WriteLine($"An exception occurred: {ex.Message} while trying to modify key values from Windows Registry Editor (regedit).");
                throw;
            }
        }

        internal class RegeditKeyValue(string key, object? value, RegistryValueKind registryValueKind)
        {
            public string Key { get; set; } = key;

            public object? Value { get; set; } = value;

            public RegistryValueKind RegistryValueKind { get; set; } = registryValueKind;
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
                        RegeditKeyValue regeditKeyValue = new(registryKeyValueName, registryKey.GetValue(registryKeyValueName), registryKey.GetValueKind(registryKeyValueName));
                        regeditKeyValues.Add(regeditKeyValue);
                    }

                    return regeditKeyValues;
                }
            }
            catch (Exception ex)  //just for demonstration...it's always best to handle specific exceptions
            {
                Console.WriteLine($"An exception occurred: {ex.Message} while trying to read key values from Windows Registry Editor (regedit).");
                throw;
            }
            return [];
        }
    }
}
