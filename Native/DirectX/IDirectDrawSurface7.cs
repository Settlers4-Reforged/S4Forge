using Forge.Native;
using Forge.Native.Helpers;
using System;
using System.Runtime.CompilerServices;

namespace Forge.Native.DirectX
{
    // Struct Size: 0x4
    public unsafe partial struct IDirectDrawSurface7 : IDirectDrawSurface7.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] IntPtr riid, [NativeTypeName("LPVOID *")] void** ppvObj)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr, void**, int>)(lpVtbl[0]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), riid, ppvObj);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, uint>)(lpVtbl[1]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, uint>)(lpVtbl[2]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int AddAttachedSurface([NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IDirectDrawSurface7*, int>)(lpVtbl[3]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int AddOverlayDirtyRect([NativeTypeName("LPRECT")] IntPtr param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr, int>)(lpVtbl[4]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Blt([NativeTypeName("LPRECT")] IntPtr param0, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param1, [NativeTypeName("LPRECT")] IntPtr param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPDDBLTFX")] IntPtr param4)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr, IDirectDrawSurface7*, IntPtr, uint, IntPtr, int>)(lpVtbl[5]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int BltBatch([NativeTypeName("LPDDBLTBATCH")] IntPtr param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr, uint, uint, int>)(lpVtbl[6]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int BltFast([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param2, [NativeTypeName("LPRECT")] IntPtr param3, [NativeTypeName("DWORD")] uint param4)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, uint, uint, IDirectDrawSurface7*, IntPtr, uint, int>)(lpVtbl[7]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteAttachedSurface([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, uint, IDirectDrawSurface7*, int>)(lpVtbl[8]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int EnumAttachedSurfaces([NativeTypeName("LPVOID")] void* param0, [NativeTypeName("LPDDENUMSURFACESCALLBACK7")] delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr, void*, int> param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, void*, delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr, void*, int>, int>)(lpVtbl[9]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int EnumOverlayZOrders([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("LPDDENUMSURFACESCALLBACK7")] delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr, void*, int> param2)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, uint, void*, delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr, void*, int>, int>)(lpVtbl[10]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int Flip([NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param0, [NativeTypeName("DWORD")] uint param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IDirectDrawSurface7*, uint, int>)(lpVtbl[11]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetAttachedSurface([NativeTypeName("LPDDSCAPS2")] IntPtr param0, [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr, IDirectDrawSurface7**, int>)(lpVtbl[12]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetBltStatus([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, uint, int>)(lpVtbl[13]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetCaps([NativeTypeName("LPDDSCAPS2")] IntPtr param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr, int>)(lpVtbl[14]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int GetClipper([NativeTypeName("LPDIRECTDRAWCLIPPER *")] IntPtr* param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr*, int>)(lpVtbl[15]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int GetColorKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDCOLORKEY")] IntPtr param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, uint, IntPtr, int>)(lpVtbl[16]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int GetDC([NativeTypeName("HDC *")] IntPtr* param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr*, int>)(lpVtbl[17]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int GetFlipStatus([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, uint, int>)(lpVtbl[18]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int GetOverlayPosition([NativeTypeName("LPLONG")] int* param0, [NativeTypeName("LPLONG")] int* param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, int*, int*, int>)(lpVtbl[19]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int GetPalette([NativeTypeName("LPDIRECTDRAWPALETTE *")] IntPtr* param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr*, int>)(lpVtbl[20]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("LPDDPIXELFORMAT")] IntPtr param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr, int>)(lpVtbl[21]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int GetSurfaceDesc([NativeTypeName("LPDDSURFACEDESC2")] IntPtr param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr, int>)(lpVtbl[22]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("LPDIRECTDRAW")] IntPtr param0, [NativeTypeName("LPDDSURFACEDESC2")] IntPtr param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr, IntPtr, int>)(lpVtbl[23]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int IsLost()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, int>)(lpVtbl[24]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int Lock([NativeTypeName("LPRECT")] IntPtr param0, [NativeTypeName("LPDDSURFACEDESC2")] IntPtr param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("HANDLE")] void* param3)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr, IntPtr, uint, void*, int>)(lpVtbl[25]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseDC([NativeTypeName("HDC")] IntPtr param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr, int>)(lpVtbl[26]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int Restore()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, int>)(lpVtbl[27]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int SetClipper([NativeTypeName("LPDIRECTDRAWCLIPPER")] IntPtr param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr, int>)(lpVtbl[28]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int SetColorKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDCOLORKEY")] IntPtr param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, uint, IntPtr, int>)(lpVtbl[29]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int SetOverlayPosition([NativeTypeName("LONG")] int param0, [NativeTypeName("LONG")] int param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, int, int, int>)(lpVtbl[30]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int SetPalette([NativeTypeName("LPDIRECTDRAWPALETTE")] IntPtr param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr, int>)(lpVtbl[31]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int Unlock([NativeTypeName("LPRECT")] IntPtr param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr, int>)(lpVtbl[32]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateOverlay([NativeTypeName("LPRECT")] IntPtr param0, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param1, [NativeTypeName("LPRECT")] IntPtr param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPDDOVERLAYFX")] IntPtr param4)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr, IDirectDrawSurface7*, IntPtr, uint, IntPtr, int>)(lpVtbl[33]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateOverlayDisplay([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, uint, int>)(lpVtbl[34]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateOverlayZOrder([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, uint, IDirectDrawSurface7*, int>)(lpVtbl[35]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int GetDDInterface([NativeTypeName("LPVOID *")] void** param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, void**, int>)(lpVtbl[36]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int PageLock([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, uint, int>)(lpVtbl[37]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int PageUnlock([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, uint, int>)(lpVtbl[38]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int SetSurfaceDesc([NativeTypeName("LPDDSURFACEDESC2")] IntPtr param0, [NativeTypeName("DWORD")] uint param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr, uint, int>)(lpVtbl[39]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] IntPtr param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr, void*, uint, uint, int>)(lpVtbl[40]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] IntPtr param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("LPDWORD")] uint* param2)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr, void*, uint*, int>)(lpVtbl[41]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int FreePrivateData([NativeTypeName("const GUID &")] IntPtr param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, IntPtr, int>)(lpVtbl[42]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int GetUniquenessValue([NativeTypeName("LPDWORD")] uint* param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, uint*, int>)(lpVtbl[43]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int ChangeUniquenessValue()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, int>)(lpVtbl[44]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int SetPriority([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, uint, int>)(lpVtbl[45]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int GetPriority([NativeTypeName("LPDWORD")] uint* param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, uint*, int>)(lpVtbl[46]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int SetLOD([NativeTypeName("DWORD")] uint param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, uint, int>)(lpVtbl[47]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int GetLOD([NativeTypeName("LPDWORD")] uint* param0)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectDrawSurface7*, uint*, int>)(lpVtbl[48]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
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
            int AddAttachedSurface([NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param0);

            [VtblIndex(4)]
            [return: NativeTypeName("HRESULT")]
            int AddOverlayDirtyRect([NativeTypeName("LPRECT")] IntPtr param0);

            [VtblIndex(5)]
            [return: NativeTypeName("HRESULT")]
            int Blt([NativeTypeName("LPRECT")] IntPtr param0, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param1, [NativeTypeName("LPRECT")] IntPtr param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPDDBLTFX")] IntPtr param4);

            [VtblIndex(6)]
            [return: NativeTypeName("HRESULT")]
            int BltBatch([NativeTypeName("LPDDBLTBATCH")] IntPtr param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2);

            [VtblIndex(7)]
            [return: NativeTypeName("HRESULT")]
            int BltFast([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param2, [NativeTypeName("LPRECT")] IntPtr param3, [NativeTypeName("DWORD")] uint param4);

            [VtblIndex(8)]
            [return: NativeTypeName("HRESULT")]
            int DeleteAttachedSurface([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param1);

            [VtblIndex(11)]
            [return: NativeTypeName("HRESULT")]
            int Flip([NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param0, [NativeTypeName("DWORD")] uint param1);

            [VtblIndex(12)]
            [return: NativeTypeName("HRESULT")]
            int GetAttachedSurface([NativeTypeName("LPDDSCAPS2")] IntPtr param0, [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** param1);

            [VtblIndex(13)]
            [return: NativeTypeName("HRESULT")]
            int GetBltStatus([NativeTypeName("DWORD")] uint param0);

            [VtblIndex(14)]
            [return: NativeTypeName("HRESULT")]
            int GetCaps([NativeTypeName("LPDDSCAPS2")] IntPtr param0);

            [VtblIndex(15)]
            [return: NativeTypeName("HRESULT")]
            int GetClipper([NativeTypeName("LPDIRECTDRAWCLIPPER *")] IntPtr* param0);

            [VtblIndex(16)]
            [return: NativeTypeName("HRESULT")]
            int GetColorKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDCOLORKEY")] IntPtr param1);

            [VtblIndex(17)]
            [return: NativeTypeName("HRESULT")]
            int GetDC([NativeTypeName("HDC *")] IntPtr* param0);

            [VtblIndex(18)]
            [return: NativeTypeName("HRESULT")]
            int GetFlipStatus([NativeTypeName("DWORD")] uint param0);

            [VtblIndex(19)]
            [return: NativeTypeName("HRESULT")]
            int GetOverlayPosition([NativeTypeName("LPLONG")] int* param0, [NativeTypeName("LPLONG")] int* param1);

            [VtblIndex(20)]
            [return: NativeTypeName("HRESULT")]
            int GetPalette([NativeTypeName("LPDIRECTDRAWPALETTE *")] IntPtr* param0);

            [VtblIndex(21)]
            [return: NativeTypeName("HRESULT")]
            int GetPixelFormat([NativeTypeName("LPDDPIXELFORMAT")] IntPtr param0);

            [VtblIndex(22)]
            [return: NativeTypeName("HRESULT")]
            int GetSurfaceDesc([NativeTypeName("LPDDSURFACEDESC2")] IntPtr param0);

            [VtblIndex(23)]
            [return: NativeTypeName("HRESULT")]
            int Initialize([NativeTypeName("LPDIRECTDRAW")] IntPtr param0, [NativeTypeName("LPDDSURFACEDESC2")] IntPtr param1);

            [VtblIndex(24)]
            [return: NativeTypeName("HRESULT")]
            int IsLost();

            [VtblIndex(25)]
            [return: NativeTypeName("HRESULT")]
            int Lock([NativeTypeName("LPRECT")] IntPtr param0, [NativeTypeName("LPDDSURFACEDESC2")] IntPtr param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("HANDLE")] void* param3);

            [VtblIndex(26)]
            [return: NativeTypeName("HRESULT")]
            int ReleaseDC([NativeTypeName("HDC")] IntPtr param0);

            [VtblIndex(27)]
            [return: NativeTypeName("HRESULT")]
            int Restore();

            [VtblIndex(28)]
            [return: NativeTypeName("HRESULT")]
            int SetClipper([NativeTypeName("LPDIRECTDRAWCLIPPER")] IntPtr param0);

            [VtblIndex(29)]
            [return: NativeTypeName("HRESULT")]
            int SetColorKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDCOLORKEY")] IntPtr param1);

            [VtblIndex(30)]
            [return: NativeTypeName("HRESULT")]
            int SetOverlayPosition([NativeTypeName("LONG")] int param0, [NativeTypeName("LONG")] int param1);

            [VtblIndex(31)]
            [return: NativeTypeName("HRESULT")]
            int SetPalette([NativeTypeName("LPDIRECTDRAWPALETTE")] IntPtr param0);

            [VtblIndex(32)]
            [return: NativeTypeName("HRESULT")]
            int Unlock([NativeTypeName("LPRECT")] IntPtr param0);

            [VtblIndex(33)]
            [return: NativeTypeName("HRESULT")]
            int UpdateOverlay([NativeTypeName("LPRECT")] IntPtr param0, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param1, [NativeTypeName("LPRECT")] IntPtr param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPDDOVERLAYFX")] IntPtr param4);

            [VtblIndex(34)]
            [return: NativeTypeName("HRESULT")]
            int UpdateOverlayDisplay([NativeTypeName("DWORD")] uint param0);

            [VtblIndex(35)]
            [return: NativeTypeName("HRESULT")]
            int UpdateOverlayZOrder([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param1);

            [VtblIndex(36)]
            [return: NativeTypeName("HRESULT")]
            int GetDDInterface([NativeTypeName("LPVOID *")] void** param0);

            [VtblIndex(37)]
            [return: NativeTypeName("HRESULT")]
            int PageLock([NativeTypeName("DWORD")] uint param0);

            [VtblIndex(38)]
            [return: NativeTypeName("HRESULT")]
            int PageUnlock([NativeTypeName("DWORD")] uint param0);

            [VtblIndex(39)]
            [return: NativeTypeName("HRESULT")]
            int SetSurfaceDesc([NativeTypeName("LPDDSURFACEDESC2")] IntPtr param0, [NativeTypeName("DWORD")] uint param1);

            [VtblIndex(40)]
            [return: NativeTypeName("HRESULT")]
            int SetPrivateData([NativeTypeName("const GUID &")] IntPtr param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3);

            [VtblIndex(41)]
            [return: NativeTypeName("HRESULT")]
            int GetPrivateData([NativeTypeName("const GUID &")] IntPtr param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("LPDWORD")] uint* param2);

            [VtblIndex(42)]
            [return: NativeTypeName("HRESULT")]
            int FreePrivateData([NativeTypeName("const GUID &")] IntPtr param0);

            [VtblIndex(43)]
            [return: NativeTypeName("HRESULT")]
            int GetUniquenessValue([NativeTypeName("LPDWORD")] uint* param0);

            [VtblIndex(44)]
            [return: NativeTypeName("HRESULT")]
            int ChangeUniquenessValue();

            [VtblIndex(45)]
            [return: NativeTypeName("HRESULT")]
            int SetPriority([NativeTypeName("DWORD")] uint param0);

            [VtblIndex(46)]
            [return: NativeTypeName("HRESULT")]
            int GetPriority([NativeTypeName("LPDWORD")] uint* param0);

            [VtblIndex(47)]
            [return: NativeTypeName("HRESULT")]
            int SetLOD([NativeTypeName("DWORD")] uint param0);

            [VtblIndex(48)]
            [return: NativeTypeName("HRESULT")]
            int GetLOD([NativeTypeName("LPDWORD")] uint* param0);
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

            [NativeTypeName("HRESULT (LPDIRECTDRAWSURFACE7) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IDirectDrawSurface7*, int> AddAttachedSurface;

            [NativeTypeName("HRESULT (LPRECT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, int> AddOverlayDirtyRect;

            [NativeTypeName("HRESULT (LPRECT, LPDIRECTDRAWSURFACE7, LPRECT, DWORD, LPDDBLTFX) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, IDirectDrawSurface7*, IntPtr, uint, IntPtr, int> Blt;

            [NativeTypeName("HRESULT (LPDDBLTBATCH, DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, uint, uint, int> BltBatch;

            [NativeTypeName("HRESULT (DWORD, DWORD, LPDIRECTDRAWSURFACE7, LPRECT, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, uint, IDirectDrawSurface7*, IntPtr, uint, int> BltFast;

            [NativeTypeName("HRESULT (DWORD, LPDIRECTDRAWSURFACE7) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, IDirectDrawSurface7*, int> DeleteAttachedSurface;

            [NativeTypeName("HRESULT (LPVOID, LPDDENUMSURFACESCALLBACK7) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, void*, delegate* unmanaged[Stdcall]<TSelf*, IntPtr, void*, int>, int> EnumAttachedSurfaces;

            [NativeTypeName("HRESULT (DWORD, LPVOID, LPDDENUMSURFACESCALLBACK7) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, void*, delegate* unmanaged[Stdcall]<TSelf*, IntPtr, void*, int>, int> EnumOverlayZOrders;

            [NativeTypeName("HRESULT (LPDIRECTDRAWSURFACE7, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IDirectDrawSurface7*, uint, int> Flip;

            [NativeTypeName("HRESULT (LPDDSCAPS2, LPDIRECTDRAWSURFACE7 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, IDirectDrawSurface7**, int> GetAttachedSurface;

            [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, int> GetBltStatus;

            [NativeTypeName("HRESULT (LPDDSCAPS2) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, int> GetCaps;

            [NativeTypeName("HRESULT (LPDIRECTDRAWCLIPPER *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr*, int> GetClipper;

            [NativeTypeName("HRESULT (DWORD, LPDDCOLORKEY) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, IntPtr, int> GetColorKey;

            [NativeTypeName("HRESULT (HDC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr*, int> GetDC;

            [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, int> GetFlipStatus;

            [NativeTypeName("HRESULT (LPLONG, LPLONG) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int*, int*, int> GetOverlayPosition;

            [NativeTypeName("HRESULT (LPDIRECTDRAWPALETTE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr*, int> GetPalette;

            [NativeTypeName("HRESULT (LPDDPIXELFORMAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, int> GetPixelFormat;

            [NativeTypeName("HRESULT (LPDDSURFACEDESC2) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, int> GetSurfaceDesc;

            [NativeTypeName("HRESULT (LPDIRECTDRAW, LPDDSURFACEDESC2) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, IntPtr, int> Initialize;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int> IsLost;

            [NativeTypeName("HRESULT (LPRECT, LPDDSURFACEDESC2, DWORD, HANDLE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, IntPtr, uint, void*, int> Lock;

            [NativeTypeName("HRESULT (HDC) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, int> ReleaseDC;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int> Restore;

            [NativeTypeName("HRESULT (LPDIRECTDRAWCLIPPER) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, int> SetClipper;

            [NativeTypeName("HRESULT (DWORD, LPDDCOLORKEY) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, IntPtr, int> SetColorKey;

            [NativeTypeName("HRESULT (LONG, LONG) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int, int, int> SetOverlayPosition;

            [NativeTypeName("HRESULT (LPDIRECTDRAWPALETTE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, int> SetPalette;

            [NativeTypeName("HRESULT (LPRECT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, int> Unlock;

            [NativeTypeName("HRESULT (LPRECT, LPDIRECTDRAWSURFACE7, LPRECT, DWORD, LPDDOVERLAYFX) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, IDirectDrawSurface7*, IntPtr, uint, IntPtr, int> UpdateOverlay;

            [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, int> UpdateOverlayDisplay;

            [NativeTypeName("HRESULT (DWORD, LPDIRECTDRAWSURFACE7) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, IDirectDrawSurface7*, int> UpdateOverlayZOrder;

            [NativeTypeName("HRESULT (LPVOID *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, void**, int> GetDDInterface;

            [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, int> PageLock;

            [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, int> PageUnlock;

            [NativeTypeName("HRESULT (LPDDSURFACEDESC2, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, uint, int> SetSurfaceDesc;

            [NativeTypeName("HRESULT (const GUID &, LPVOID, DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, void*, uint, uint, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, LPVOID, LPDWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, void*, uint*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, int> FreePrivateData;

            [NativeTypeName("HRESULT (LPDWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint*, int> GetUniquenessValue;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int> ChangeUniquenessValue;

            [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, int> SetPriority;

            [NativeTypeName("HRESULT (LPDWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint*, int> GetPriority;

            [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, int> SetLOD;

            [NativeTypeName("HRESULT (LPDWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint*, int> GetLOD;
        }
    }
}
