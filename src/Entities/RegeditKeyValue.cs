// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

using Microsoft.Win32;

namespace WindowsCursorSwitcher.Entities
{
    internal class RegeditKeyValue(string key, object? value, RegistryValueKind registryValueKind)
    {
        public string Key { get; set; } = key;

        public object? Value { get; set; } = value;

        public RegistryValueKind RegistryValueKind { get; set; } = registryValueKind;
    }
}
