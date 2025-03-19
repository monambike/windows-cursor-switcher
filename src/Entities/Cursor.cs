// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

using WindowsCursorSwitcher.Entities;

internal class Cursor(SystemCursor systemCursor, string path)
{
    public SystemCursor SystemCursor { get; set; } = systemCursor;

    public string Path { get; set; } = path;
}