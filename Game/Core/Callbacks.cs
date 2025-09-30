using Forge.Game.UI.Native;
using Forge.Native;
using Forge.Native.DirectX;

using System.Runtime.InteropServices;

namespace Forge.Game.Core {
    public interface ICallbacks {

        #region Initializations

        /// <summary>
        /// Event that is called when the map is initialized.
        /// </summary>
        public event MapInitCallback? OnMapInit;

        /// <summary>
        /// Event that is called when a map script is opened.
        /// </summary>
        public event LuaOpenCallback? OnLuaOpen;

        #endregion

        #region Interaction

        /// <summary>
        /// Event that is called when the mouse is clicked.
        /// </summary>
        public event MouseCallback? OnMouse;
        /// <summary>
        /// Event that is called when the mouse is clicked.
        /// UI element pointer to game memory is passed.
        /// </summary>
        public event MouseCallbackUnsafe? OnMouseUnsafe;

        #endregion

        #region InGameEvents

        /// <summary>
        /// Event that is called when a settler move command is sent.
        /// </summary>
        public event SettlerSendCallback? OnSettlerSend;

        /// <summary>
        /// Event that is called every tick.
        /// </summary>
        public event TickCallback? OnTick;

        /// <summary>
        /// Event that is called when an entity is spawned or destructed.
        /// </summary>
        public event EntityCallback? OnEntity;

        #endregion

        #region Rendering
        /// <summary>
        /// Event that is called every frame.
        /// </summary>
        public event GameFrameCallback? OnFrame;

        /// <summary>
        /// Event that is called when any "in-world" element is drawn.
        /// </summary>
        public event DrawEntityCallback? OnDrawEntity;

        /// <summary>
        /// Event that is called when a gui surface is drawn onto the screen.
        /// </summary>
        public event SurfaceDrawCallback? OnSurfaceDraw;

        /// <summary>
        /// Event that is called when a gui element is drawn onto a gui surface.
        /// UI element pointer to game memory is passed.
        /// </summary>
        public event UIElementDrawCallbackUnsafe? OnUIElementDrawUnsafe;

        /// <summary>
        /// Event that is called when a gui surface is cleared.
        /// </summary>
        public event SurfaceClearCallback? OnSurfaceClear;

        #endregion
    }

#pragma warning disable CS0067
    public class TestCallbacks : ICallbacks {
        public event MapInitCallback? OnMapInit;
        public event LuaOpenCallback? OnLuaOpen;
        public event MouseCallback? OnMouse;
        public event MouseCallbackUnsafe? OnMouseUnsafe;
        public event SettlerSendCallback? OnSettlerSend;
        public event TickCallback? OnTick;
        public event EntityCallback? OnEntity;
        public event GameFrameCallback? OnFrame;
        public event DrawEntityCallback? OnDrawEntity;
        public event SurfaceDrawCallback? OnSurfaceDraw;
        public event UIElementDrawCallbackUnsafe? OnUIElementDrawUnsafe;
        public event SurfaceClearCallback? OnSurfaceClear;
    }

    public class Callbacks : ICallbacks {
        public event MapInitCallback? OnMapInit;
        public event LuaOpenCallback? OnLuaOpen;
        public event MouseCallback? OnMouse;
        public event MouseCallbackUnsafe? OnMouseUnsafe;
        public event SettlerSendCallback? OnSettlerSend;
        public event TickCallback? OnTick;
        public event EntityCallback? OnEntity;
        public event GameFrameCallback? OnFrame;
        public event DrawEntityCallback? OnDrawEntity;
        public event SurfaceDrawCallback? OnSurfaceDraw;
        public event UIElementDrawCallbackUnsafe? OnUIElementDrawUnsafe;
        public event SurfaceClearCallback? OnSurfaceClear;
#pragma warning restore CS0067

        public unsafe Callbacks(IS4ModApi modApi, IGameValues gameValues) {
            modApi.AddFrameListener((surface, width, reserved) => {
                IDirectDrawSurface7* directDrawSurface = (IDirectDrawSurface7*)surface;

                OnFrame?.Invoke(directDrawSurface, (int)width);
                //once reserved is no longer unused, add new version of OnFrame

                return 0;
            });

            modApi.AddMapInitListener((reserved0, reserved1) => {
                OnMapInit?.Invoke();
                //once reserved0 or reserved1 is no longer unused, add new version of OnMapInit

                return 0;
            });

            modApi.AddMouseListener((mouseButton, x, y, msgId, hwnd, uiElement) => {
                OnMouse?.Invoke(mouseButton, x, y, msgId, uiElement.ToPointer() == null ? null : Marshal.PtrToStructure<S4UIElement>(new nint(uiElement)));
                OnMouseUnsafe?.Invoke(mouseButton, x, y, msgId, (S4UIElement*)uiElement);

                return 0;
            });

            modApi.AddSettlerSendListener((position, command, reserved) => {
                OnSettlerSend?.Invoke(position, (uint)command);
                //once reserved is no longer unused, add new version of OnSettlerSend

                return 0;
            });

            modApi.AddTickListener((tick, hasEvent, isDelayed) => {
                OnTick?.Invoke(tick, hasEvent, isDelayed);

                return 0;
            });

            modApi.AddLuaOpenListener(() => {
                OnLuaOpen?.Invoke();

                return 0;
            });

            modApi.AddBltListener((bltParams, discard) => {
                OnDrawEntity?.Invoke(Marshal.PtrToStructure<S4EntityDrawParams>(new nint(bltParams)), discard);

                return false;
            });

            modApi.AddGuiBltListener((bltParams, discard) => {
                OnSurfaceDraw?.Invoke(new nint(bltParams), discard);

                return false;
            });

            modApi.AddEntityListener((entity, cause) => {
                OnEntity?.Invoke(entity, (ushort)cause);

                return 0;
            });

            modApi.AddGuiElementBltListener((bltParams, discard) => {
                var param = Marshal.PtrToStructure<S4UIElementDrawParams>(new nint(bltParams));

                S4UIElement* uiElement = gameValues.GetUIElementFromIndexUnsafe(param.elementContainerId, param.valueLink);
                OnUIElementDrawUnsafe?.Invoke(param, uiElement, discard);

                return 0;
            });

            modApi.AddGuiClearListener((bltParams, discard) => {
                OnSurfaceClear?.Invoke(new nint(bltParams), discard);

                return 0;
            });


        }
    }
}
