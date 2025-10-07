using AutomaticInterface;

using Forge.Config;
using Forge.Game.UI.Native;

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
        /// <summary>
        /// Reads a value of the specified type from the given memory address.
        /// </summary>
        /// <typeparam name="T">The type of the value to read. Must be an unmanaged type.</typeparam>
        /// <param name="address">The memory address from which to read the value. This can be an absolute or relative address.</param>
        /// <param name="relative">A boolean indicating whether the <paramref name="address"/> is relative. If <see langword="true"/>, the
        /// address is treated as relative; otherwise, it is treated as absolute.  The default is <see langword="true"/>.
        /// </param>
        /// <param name="default">The default value to return if the address is null.</param>
        /// <returns>The value of type <typeparamref name="T"/> read from the specified address, or the <paramref name="default"/> value if the address is null.</returns>
        T ReadValue<T>(int address, bool relative = true, T @default = default(T)) where T : unmanaged;
        /// <summary>
        /// Converts the specified memory address to a pointer.
        /// </summary>
        /// <remarks>The caller is responsible for ensuring that the memory address is valid and that it
        /// points to a region of memory compatible with the specified type <typeparamref name="T"/>. Using an
        /// invalid or incompatible address may result in undefined behavior.</remarks>
        /// <typeparam name="T">The unmanaged type to which the memory address will be cast.</typeparam>
        /// <param name="address">The memory address to convert. This can be an absolute or relative address.</param>
        /// <param name="relative">A value indicating whether the <paramref name="address"/> is relative to a base address. If <see langword="true"/>,
        /// the address is treated as relative; otherwise, it is treated as absolute.</param>
        /// <returns>A pointer of type <typeparamref name="T"/> that represents the specified memory address.</returns>
        T* AddressAsPointer<T>(int address, bool relative = true) where T : unmanaged;

        uint SetProtect(int address, uint size, uint newProtect, bool relative = true);

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
            unsafe {
                T* value = AddressAsPointer<T>(address, relative);

                if (value == null) {
                    return @default;
                }

                return *value;
            }
        }

        public unsafe T* AddressAsPointer<T>(int address, bool relative = true) where T : unmanaged {
            return (T*)(address + (relative ? S4_Main : 0));
        }

        public uint SetProtect(int address, uint size, uint newProtect, bool relative = true) {
            return Kernel32.VirtualProtect(address + (relative ? S4_Main : 0), size, newProtect, out uint oldProtect) ? oldProtect : 0;
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
