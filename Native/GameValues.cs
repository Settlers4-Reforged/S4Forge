using AutomaticInterface;

using Forge.Config;
using Forge.Game.UI.Native;
using Forge.UX.Native;

using System;
using System.Runtime.InteropServices;

namespace Forge.Native {
    public unsafe partial interface IGameValues {
        /// <summary>
        /// Main window hwnd handle
        /// </summary>
        nint Hwnd { get; }
        /// <summary>
        /// Pointer to the module base of S4_Main.exe
        /// </summary>
        int S4_Main { get; }

        T ReadValue<T>(int address, bool relative = true, T @default = default(T)) where T : unmanaged;
        T* GetPointer<T>(int address, bool relative = true) where T : unmanaged;

        string? ReadStringFromUITable(int id);
        nint GetStringUITableAddress(int id);

        /// <summary>
        /// Creates a copy to a UI Element from a container
        /// </summary>
        /// <param name="container"></param>
        /// <param name="valueLink"></param>
        /// <returns></returns>
        S4UIElement? GetUIElementFromIndex(int container, int valueLink);
        S4UIElement* GetUIElementFromIndexUnsafe(int container, int valueLink);
        S4UIElement*[] GetAllUIElementsFromIndexUnsafe(int container);

    }

    public class GameValues : IGameValues {
        private readonly IS4ModApi modApi;
        public GameValues(IS4ModApi modApi) {
            this.modApi = modApi;

            S4_Main = Kernel32.GetModuleHandleA(nint.Zero);
        }

        public nint Hwnd {
            get {
                unsafe {
                    return new nint(modApi.GetHwnd());
                }
            }
        }

        public int S4_Main { get; private set; }

        public T ReadValue<T>(int address, bool relative = true, T @default = default) where T : unmanaged {
            int pointer = address + (relative ? S4_Main : 0);

            unsafe {
                T* value = (T*)new nint(pointer).ToPointer();

                if (value == null) {
                    return @default;
                }

                return *value;
            }
        }

        public unsafe T* GetPointer<T>(int address, bool relative = true) where T : unmanaged {
            return (T*)(address + (relative ? S4_Main : 0));
        }

        public string? ReadStringFromUITable(int id) {
            const int uiStringTable = 0x1065218;
            int address = S4_Main + uiStringTable + id * 300;

            return Marshal.PtrToStringAnsi(new nint(address));
        }
        public nint GetStringUITableAddress(int id) {
            const int uiStringTable = 0x1065218;
            int address = S4_Main + uiStringTable + id * 300;

            return new nint(address);
        }


        /// <summary>
        /// Creates a copy to a UI Element from a container
        /// </summary>
        /// <param name="container"></param>
        /// <param name="valueLink"></param>
        /// <returns></returns>
        public S4UIElement? GetUIElementFromIndex(int container, int valueLink) {
            unsafe {
                var element = GetUIElementFromIndexUnsafe(container, valueLink);
                return element == null ? null : *element;
            }
        }

        public unsafe S4UIElement* GetUIElementFromIndexUnsafe(int container, int valueLink) {
            int UIMenus = ReadValue<int>(0x1064C94);


            int containerOffset = ReadValue<int>(UIMenus + (container + 4) * 4, false);
            int elementsOffset = ReadValue<int>(containerOffset + UIMenus, false);
            short elementCount = ReadValue<short>(containerOffset + UIMenus + 12, false);
            S4UIElement* elementArrayPointer =
                (S4UIElement*)new nint(containerOffset + UIMenus + 16).ToPointer();

            int i = 0;
            while (valueLink != elementArrayPointer->valueLink) {
                i++;
                elementArrayPointer++;

                if (i >= elementCount)
                    return null;
            }

            return elementArrayPointer;
        }

        public unsafe S4UIElement*[] GetAllUIElementsFromIndexUnsafe(int container) {
            int UIMenus = ReadValue<int>(0x1064C94);


            int containerOffset = ReadValue<int>(UIMenus + (container + 4) * 4, false);
            int elementsOffset = ReadValue<int>(containerOffset + UIMenus, false);
            short elementCount = ReadValue<short>(containerOffset + UIMenus + 12, false);
            S4UIElement* elementArrayPointer =
                (S4UIElement*)new nint(containerOffset + UIMenus + 16).ToPointer();

            S4UIElement*[] elements = new S4UIElement*[elementCount];

            int i = 0;
            while (i < elementCount) {
                elements[i] = elementArrayPointer;

                i++;
                elementArrayPointer++;
            }

            return elements;
        }
    }
}
