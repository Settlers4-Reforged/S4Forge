using AutomaticInterface;

using Forge.Native;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Forge.S4.Game {

    /// <summary>
    /// An interface for accessing window-related functionality.
    /// 
    /// Fetching the screen size and listening for changes in the screen size.
    /// </summary>
    public partial interface IWindowApi { }

    [GenerateAutomaticInterface]
    internal sealed class WindowApi : IWindowApi {
        readonly IGameValues gameValues;
        public WindowApi(IGameValues gameValues) {
            this.gameValues = gameValues;

            User32.AddWndProc(EventHandler);
        }

        private bool EventHandler(WndProcMsg msg, UIntPtr wParam, UIntPtr lParam) {
            if (msg == WndProcMsg.WM_SIZE) {
                ScreenSizeChanged?.Invoke(GetScreenSize());
            }

            return false;
        }

        public Vector2 GetScreenSize() {
            User32.GetClientRect(gameValues.Hwnd, out User32.Rect rect);

            return new Vector2(rect.Z - rect.X, rect.W - rect.Y);
        }

        public event Action<Vector2> ScreenSizeChanged;
    }
}
