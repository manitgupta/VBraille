﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Mouse
{
    public static class VirtualKeyboard
    {
        [DllImport("user32.dll")]
        static extern uint keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        public static void KeyDown(System.Windows.Forms.Keys key)
        {
            keybd_event((byte)key, 0, 0, 0);
        }

        public static void KeyUp(System.Windows.Forms.Keys key)
        {
            keybd_event((byte)key, 0, 0x7F, 0);
        }
    }
}
