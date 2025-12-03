using Forge.Native;
using Forge.Native.Helpers;
using System;
using System.Runtime.CompilerServices;

namespace Forge.Native.DirectX
{
    // Struct Size: 0x4
    public unsafe partial struct IDirectDraw7 : IDirectDraw7.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] IntPtr riid, [NativeTypeName("LPVOID *")] void** ppvObj)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, IntPtr, void**, int>)(lpVtbl[0]))((IDirectDraw7*)Unsafe.AsPointer(ref this), riid, ppvObj);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, uint>)(lpVtbl[1]))((IDirectDraw7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, uint>)(lpVtbl[2]))((IDirectDraw7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Compact()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, int>)(lpVtbl[3]))((IDirectDraw7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int CreateClipper([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWCLIPPER *")] IntPtr* param1, [NativeTypeName("IUnknown*")] IntPtr param2)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, uint, IntPtr*, IntPtr, int>)(lpVtbl[4]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePalette([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPPALETTEENTRY")] IntPtr param1, [NativeTypeName("LPDIRECTDRAWPALETTE *")] IntPtr* param2, [NativeTypeName("IUnknown*")] IntPtr param3)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, uint, IntPtr, IntPtr*, IntPtr, int>)(lpVtbl[5]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSurface([NativeTypeName("LPDDSURFACEDESC2")] IntPtr param0, [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** param1, [NativeTypeName("IUnknown*")] IntPtr param2)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, IntPtr, IDirectDrawSurface7**, IntPtr, int>)(lpVtbl[6]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int DuplicateSurface([NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param0, [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, IDirectDrawSurface7*, IDirectDrawSurface7**, int>)(lpVtbl[7]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int EnumDisplayModes([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDSURFACEDESC2")] IntPtr param1, [NativeTypeName("LPVOID")] void* param2, [NativeTypeName("LPDDENUMMODESCALLBACK2")] delegate* unmanaged[Stdcall]<IntPtr, void*, int> param3)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, uint, IntPtr, void*, delegate* unmanaged[Stdcall]<IntPtr, void*, int>, int>)(lpVtbl[8]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int EnumSurfaces([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDSURFACEDESC2")] IntPtr param1, [NativeTypeName("LPVOID")] void* param2, [NativeTypeName("LPDDENUMSURFACESCALLBACK7")] delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr, void*, int> param3)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, uint, IntPtr, void*, delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr, void*, int>, int>)(lpVtbl[9]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int FlipToGDISurface()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, int>)(lpVtbl[10]))((IDirectDraw7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetCaps([NativeTypeName("LPDDCAPS")] IntPtr param0, [NativeTypeName("LPDDCAPS")] IntPtr param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, IntPtr, IntPtr, int>)(lpVtbl[11]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayMode([NativeTypeName("LPDDSURFACEDESC2")] IntPtr param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, IntPtr, int>)(lpVtbl[12]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetFourCCCodes([NativeTypeName("LPDWORD")] uint* param0, [NativeTypeName("LPDWORD")] uint* param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, uint*, uint*, int>)(lpVtbl[13]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetGDISurface([NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, IDirectDrawSurface7**, int>)(lpVtbl[14]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int GetMonitorFrequency([NativeTypeName("LPDWORD")] uint* param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, uint*, int>)(lpVtbl[15]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int GetScanLine([NativeTypeName("LPDWORD")] uint* param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, uint*, int>)(lpVtbl[16]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int GetVerticalBlankStatus([NativeTypeName("LPBOOL")] int* param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, int*, int>)(lpVtbl[17]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("GUID *")] IntPtr param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, IntPtr, int>)(lpVtbl[18]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int RestoreDisplayMode()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, int>)(lpVtbl[19]))((IDirectDraw7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int SetCooperativeLevel([NativeTypeName("HWND")] IntPtr param0, [NativeTypeName("DWORD")] uint param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, IntPtr, uint, int>)(lpVtbl[20]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int SetDisplayMode([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("DWORD")] uint param4)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, uint, uint, uint, uint, uint, int>)(lpVtbl[21]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int WaitForVerticalBlank([NativeTypeName("DWORD")] uint param0, [NativeTypeName("HANDLE")] void* param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, uint, void*, int>)(lpVtbl[22]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int GetAvailableVidMem([NativeTypeName("LPDDSCAPS2")] IntPtr param0, [NativeTypeName("LPDWORD")] uint* param1, [NativeTypeName("LPDWORD")] uint* param2)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, IntPtr, uint*, uint*, int>)(lpVtbl[23]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int GetSurfaceFromDC([NativeTypeName("HDC")] IntPtr param0, [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, IntPtr, IDirectDrawSurface7**, int>)(lpVtbl[24]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int RestoreAllSurfaces()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, int>)(lpVtbl[25]))((IDirectDraw7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int TestCooperativeLevel()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, int>)(lpVtbl[26]))((IDirectDraw7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceIdentifier([NativeTypeName("LPDDDEVICEIDENTIFIER2")] IntPtr param0, [NativeTypeName("DWORD")] uint param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, IntPtr, uint, int>)(lpVtbl[27]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int StartModeTest([NativeTypeName("LPSIZE")] IntPtr param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, IntPtr, uint, uint, int>)(lpVtbl[28]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int EvaluateMode([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD *")] uint* param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDraw7*, uint, uint*, int>)(lpVtbl[29]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        public interface Interface
        {
            [VtblIndex(0)]
            [return: NativeTypeName("HRESULT")]
            int QueryInterface([NativeTypeName("const IID &")] IntPtr riid, [NativeTypeName("LPVOID *")] void** ppvObj);

            [VtblIndex(1)]
            [return: NativeTypeName("ULONG")]
            uint AddRef();

            [VtblIndex(2)]
            [return: NativeTypeName("ULONG")]
            uint Release();

            [VtblIndex(3)]
            [return: NativeTypeName("HRESULT")]
            int Compact();

            [VtblIndex(4)]
            [return: NativeTypeName("HRESULT")]
            int CreateClipper([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWCLIPPER *")] IntPtr* param1, [NativeTypeName("IUnknown*")] IntPtr param2);

            [VtblIndex(5)]
            [return: NativeTypeName("HRESULT")]
            int CreatePalette([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPPALETTEENTRY")] IntPtr param1, [NativeTypeName("LPDIRECTDRAWPALETTE *")] IntPtr* param2, [NativeTypeName("IUnknown*")] IntPtr param3);

            [VtblIndex(6)]
            [return: NativeTypeName("HRESULT")]
            int CreateSurface([NativeTypeName("LPDDSURFACEDESC2")] IntPtr param0, [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** param1, [NativeTypeName("IUnknown*")] IntPtr param2);

            [VtblIndex(7)]
            [return: NativeTypeName("HRESULT")]
            int DuplicateSurface([NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param0, [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** param1);

            [VtblIndex(10)]
            [return: NativeTypeName("HRESULT")]
            int FlipToGDISurface();

            [VtblIndex(11)]
            [return: NativeTypeName("HRESULT")]
            int GetCaps([NativeTypeName("LPDDCAPS")] IntPtr param0, [NativeTypeName("LPDDCAPS")] IntPtr param1);

            [VtblIndex(12)]
            [return: NativeTypeName("HRESULT")]
            int GetDisplayMode([NativeTypeName("LPDDSURFACEDESC2")] IntPtr param0);

            [VtblIndex(13)]
            [return: NativeTypeName("HRESULT")]
            int GetFourCCCodes([NativeTypeName("LPDWORD")] uint* param0, [NativeTypeName("LPDWORD")] uint* param1);

            [VtblIndex(14)]
            [return: NativeTypeName("HRESULT")]
            int GetGDISurface([NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** param0);

            [VtblIndex(15)]
            [return: NativeTypeName("HRESULT")]
            int GetMonitorFrequency([NativeTypeName("LPDWORD")] uint* param0);

            [VtblIndex(16)]
            [return: NativeTypeName("HRESULT")]
            int GetScanLine([NativeTypeName("LPDWORD")] uint* param0);

            [VtblIndex(17)]
            [return: NativeTypeName("HRESULT")]
            int GetVerticalBlankStatus([NativeTypeName("LPBOOL")] int* param0);

            [VtblIndex(18)]
            [return: NativeTypeName("HRESULT")]
            int Initialize([NativeTypeName("GUID *")] IntPtr param0);

            [VtblIndex(19)]
            [return: NativeTypeName("HRESULT")]
            int RestoreDisplayMode();

            [VtblIndex(20)]
            [return: NativeTypeName("HRESULT")]
            int SetCooperativeLevel([NativeTypeName("HWND")] IntPtr param0, [NativeTypeName("DWORD")] uint param1);

            [VtblIndex(21)]
            [return: NativeTypeName("HRESULT")]
            int SetDisplayMode([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("DWORD")] uint param4);

            [VtblIndex(22)]
            [return: NativeTypeName("HRESULT")]
            int WaitForVerticalBlank([NativeTypeName("DWORD")] uint param0, [NativeTypeName("HANDLE")] void* param1);

            [VtblIndex(23)]
            [return: NativeTypeName("HRESULT")]
            int GetAvailableVidMem([NativeTypeName("LPDDSCAPS2")] IntPtr param0, [NativeTypeName("LPDWORD")] uint* param1, [NativeTypeName("LPDWORD")] uint* param2);

            [VtblIndex(24)]
            [return: NativeTypeName("HRESULT")]
            int GetSurfaceFromDC([NativeTypeName("HDC")] IntPtr param0, [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** param1);

            [VtblIndex(25)]
            [return: NativeTypeName("HRESULT")]
            int RestoreAllSurfaces();

            [VtblIndex(26)]
            [return: NativeTypeName("HRESULT")]
            int TestCooperativeLevel();

            [VtblIndex(27)]
            [return: NativeTypeName("HRESULT")]
            int GetDeviceIdentifier([NativeTypeName("LPDDDEVICEIDENTIFIER2")] IntPtr param0, [NativeTypeName("DWORD")] uint param1);

            [VtblIndex(28)]
            [return: NativeTypeName("HRESULT")]
            int StartModeTest([NativeTypeName("LPSIZE")] IntPtr param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2);

            [VtblIndex(29)]
            [return: NativeTypeName("HRESULT")]
            int EvaluateMode([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD *")] uint* param1);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, LPVOID *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int> Compact;

            [NativeTypeName("HRESULT (DWORD, LPDIRECTDRAWCLIPPER *, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, IntPtr*, IntPtr, int> CreateClipper;

            [NativeTypeName("HRESULT (DWORD, LPPALETTEENTRY, LPDIRECTDRAWPALETTE *, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, IntPtr, IntPtr*, IntPtr, int> CreatePalette;

            [NativeTypeName("HRESULT (LPDDSURFACEDESC2, LPDIRECTDRAWSURFACE7 *, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, IDirectDrawSurface7**, IntPtr, int> CreateSurface;

            [NativeTypeName("HRESULT (LPDIRECTDRAWSURFACE7, LPDIRECTDRAWSURFACE7 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IDirectDrawSurface7*, IDirectDrawSurface7**, int> DuplicateSurface;

            [NativeTypeName("HRESULT (DWORD, LPDDSURFACEDESC2, LPVOID, LPDDENUMMODESCALLBACK2) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, IntPtr, void*, delegate* unmanaged[Stdcall]<IntPtr, void*, int>, int> EnumDisplayModes;

            [NativeTypeName("HRESULT (DWORD, LPDDSURFACEDESC2, LPVOID, LPDDENUMSURFACESCALLBACK7) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, IntPtr, void*, delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr, void*, int>, int> EnumSurfaces;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int> FlipToGDISurface;

            [NativeTypeName("HRESULT (LPDDCAPS, LPDDCAPS) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, IntPtr, int> GetCaps;

            [NativeTypeName("HRESULT (LPDDSURFACEDESC2) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, int> GetDisplayMode;

            [NativeTypeName("HRESULT (LPDWORD, LPDWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint*, uint*, int> GetFourCCCodes;

            [NativeTypeName("HRESULT (LPDIRECTDRAWSURFACE7 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IDirectDrawSurface7**, int> GetGDISurface;

            [NativeTypeName("HRESULT (LPDWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint*, int> GetMonitorFrequency;

            [NativeTypeName("HRESULT (LPDWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint*, int> GetScanLine;

            [NativeTypeName("HRESULT (LPBOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int*, int> GetVerticalBlankStatus;

            [NativeTypeName("HRESULT (GUID *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, int> Initialize;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int> RestoreDisplayMode;

            [NativeTypeName("HRESULT (HWND, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, uint, int> SetCooperativeLevel;

            [NativeTypeName("HRESULT (DWORD, DWORD, DWORD, DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, uint, uint, uint, uint, int> SetDisplayMode;

            [NativeTypeName("HRESULT (DWORD, HANDLE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, void*, int> WaitForVerticalBlank;

            [NativeTypeName("HRESULT (LPDDSCAPS2, LPDWORD, LPDWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, uint*, uint*, int> GetAvailableVidMem;

            [NativeTypeName("HRESULT (HDC, LPDIRECTDRAWSURFACE7 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, IDirectDrawSurface7**, int> GetSurfaceFromDC;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int> RestoreAllSurfaces;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int> TestCooperativeLevel;

            [NativeTypeName("HRESULT (LPDDDEVICEIDENTIFIER2, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, uint, int> GetDeviceIdentifier;

            [NativeTypeName("HRESULT (LPSIZE, DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, uint, uint, int> StartModeTest;

            [NativeTypeName("HRESULT (DWORD, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, uint*, int> EvaluateMode;
        }
    }
}
