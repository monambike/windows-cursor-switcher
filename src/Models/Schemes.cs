﻿// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

using WindowsCursorSwitcher.Utils;

namespace WindowsCursorSwitcher.Models
{
    internal class Schemes
    {
        private void CreateNewCursorSchemeForCurrentUser(string scheme)
        {
            UtilRegedit.ModifyKeyValue(scheme, "paths");

            //CreateRegistry(RegeditSchemesPath);
        }

        private void AddAndSaveToSettings()
        {

        }

        private void ChangePaths()
        {

        }
    }
}
