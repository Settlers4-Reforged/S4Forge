using Forge.Game.UI;
using Forge.Game.UI.Native;
using Forge.Native.DirectX;

using System;
using System.Runtime.InteropServices;

namespace Forge.Game.Core {
    #region Delegates

    public unsafe delegate void GameFrameCallback(IDirectDrawSurface7* surface, int pillarBoxWidth);
    public delegate void MapInitCallback();
    public unsafe delegate void MouseCallbackUnsafe(uint mouseButton, uint x, uint y, uint msgId, S4UIElement* uiElement);
    public delegate void MouseCallback(uint mouseButton, uint x, uint y, uint msgId, S4UIElement? uiElement);
    public delegate void SettlerSendCallback(uint position, uint command);
    public delegate void TickCallback(uint tick, bool hasEvent, bool isDelayed);
    public delegate void LuaOpenCallback();
    public delegate void DrawEntityCallback(S4EntityDrawParams parameter, bool discard);
    public delegate void SurfaceDrawCallback(nint bltParams, bool discard);
    public delegate void EntityCallback(ushort entity, ushort cause);
    public unsafe delegate void UIElementDrawCallbackUnsafe(S4UIElementDrawParams bltParams, S4UIElement* uiElement, bool discard);
    public delegate void SurfaceClearCallback(nint bltParams, bool discard);
    #endregion

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct S4EntityDrawParams {
        public nint caller;
        public nint /*<word>*/ imagePalette;
        public nint /*<byte>*/ imageData;
        public int imageWidth;
        public int imageHeight;
        public int destX;
        public int destY;
        public int destClippingOffsetY;
        public nint /*<word>*/ subSurface;
        public bool imageHighRes;
        public int destWidth;
        public int destHeight;
        public int surfaceWidth;
        public int surfaceHeight;
        public int stride;
        public int zoomFactor;
        public nint /*<word>*/ surface;
        public bool isFogOfWar;
        public short settlerId;
        public short spriteId;
        public nint /*<HDC>*/ destinationDc;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct S4UIElementDrawParams {
        public int surfaceWidth;
        public int surfaceHeight;
        public short activeGFXCollection;
        public short elementContainerId;
        public short x;
        public short y;
        public short xOffset;
        public short yOffset;
        public short width;
        public short height;
        public short mainTexture;
        public short valueLink;
        public short buttonPressedTexture;
        public short tooltipLink;
        public short tooltipLinkExtra;
        public UIElementTypes elementType;
        public UIElementEffects effects; //When == 8 -> hide text
        //public enum where the first 4 bits define which font style to use and last 4 bits define effects (Like pressed etc)
        public UIElementTextStyle textStyle;
        public short showTexture;
        public short backTexture;
        public nint text;
        public nint tooltipText;
        public nint tooltipExtraText;
    }
}
