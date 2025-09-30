using Forge.Native;
using Forge.Native.Helpers;
using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Forge.Native.DirectX
{
    public unsafe partial struct IDirect3DDevice9 : IDirect3DDevice9.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] IntPtr riid, void** ppvObj)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IntPtr, void**, int>)(lpVtbl[0]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), riid, ppvObj);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint>)(lpVtbl[1]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint>)(lpVtbl[2]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int TestCooperativeLevel()
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, int>)(lpVtbl[3]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public uint GetAvailableTextureMem()
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint>)(lpVtbl[4]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int EvictManagedResources()
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, int>)(lpVtbl[5]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetDirect3D([NativeTypeName("IDirect3D9 **")] void** ppD3D9)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, void**, int>)(lpVtbl[6]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), ppD3D9);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceCaps([NativeTypeName("D3DCAPS9 *")] IntPtr pCaps)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IntPtr, int>)(lpVtbl[7]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pCaps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayMode(uint iSwapChain, [NativeTypeName("D3DDISPLAYMODE *")] IntPtr pMode)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IntPtr, int>)(lpVtbl[8]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), iSwapChain, pMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetCreationParameters([NativeTypeName("D3DDEVICE_CREATION_PARAMETERS *")] IntPtr pParameters)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IntPtr, int>)(lpVtbl[9]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int SetCursorProperties(uint XHotSpot, uint YHotSpot, [NativeTypeName("IDirect3DSurface9*")] void* pCursorBitmap)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, void*, int>)(lpVtbl[10]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), XHotSpot, YHotSpot, pCursorBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public void SetCursorPosition(int X, int Y, [NativeTypeName("DWORD")] uint Flags)
        {
            ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, int, int, uint, void>)(lpVtbl[11]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), X, Y, Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("BOOL")]
        public int ShowCursor([NativeTypeName("BOOL")] int bShow)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, int, int>)(lpVtbl[12]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), bShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int CreateAdditionalSwapChain([NativeTypeName("D3DPRESENT_PARAMETERS *")] IntPtr pPresentationParameters, [NativeTypeName("IDirect3DSwapChain9 **")] void** pSwapChain)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IntPtr, void**, int>)(lpVtbl[13]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pPresentationParameters, pSwapChain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetSwapChain(uint iSwapChain, [NativeTypeName("IDirect3DSwapChain9 **")] void** pSwapChain)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, void**, int>)(lpVtbl[14]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), iSwapChain, pSwapChain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public uint GetNumberOfSwapChains()
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint>)(lpVtbl[15]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int Reset([NativeTypeName("D3DPRESENT_PARAMETERS *")] IntPtr pPresentationParameters)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IntPtr, int>)(lpVtbl[16]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pPresentationParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int Present([NativeTypeName("const RECT *")] VectorInt4* pSourceRect, [NativeTypeName("const RECT *")] VectorInt4* pDestRect, [NativeTypeName("HWND")] IntPtr hDestWindowOverride, [NativeTypeName("const RGNDATA *")] IntPtr pDirtyRegion)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, VectorInt4*, VectorInt4*, IntPtr, IntPtr, int>)(lpVtbl[17]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int GetBackBuffer(uint iSwapChain, uint iBackBuffer, [NativeTypeName("D3DBACKBUFFER_TYPE")] int Type, [NativeTypeName("IDirect3DSurface9 **")] void** ppBackBuffer)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, int, void**, int>)(lpVtbl[18]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), iSwapChain, iBackBuffer, Type, ppBackBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int GetRasterStatus(uint iSwapChain, [NativeTypeName("D3DRASTER_STATUS *")] IntPtr pRasterStatus)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IntPtr, int>)(lpVtbl[19]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), iSwapChain, pRasterStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int SetDialogBoxMode([NativeTypeName("BOOL")] int bEnableDialogs)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, int, int>)(lpVtbl[20]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), bEnableDialogs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public void SetGammaRamp(uint iSwapChain, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("const D3DGAMMARAMP *")] IntPtr pRamp)
        {
            ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, IntPtr, void>)(lpVtbl[21]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), iSwapChain, Flags, pRamp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public void GetGammaRamp(uint iSwapChain, [NativeTypeName("D3DGAMMARAMP *")] IntPtr pRamp)
        {
            ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IntPtr, void>)(lpVtbl[22]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), iSwapChain, pRamp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTexture(uint Width, uint Height, uint Levels, [NativeTypeName("DWORD")] uint Usage, [NativeTypeName("D3DFORMAT")] int Format, [NativeTypeName("D3DPOOL")] int Pool, [NativeTypeName("IDirect3DTexture9 **")] void** ppTexture, [NativeTypeName("HANDLE *")] void** pSharedHandle)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, uint, uint, int, int, void**, void**, int>)(lpVtbl[23]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Width, Height, Levels, Usage, Format, Pool, ppTexture, pSharedHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, [NativeTypeName("DWORD")] uint Usage, [NativeTypeName("D3DFORMAT")] int Format, [NativeTypeName("D3DPOOL")] int Pool, [NativeTypeName("IDirect3DVolumeTexture9 **")] void** ppVolumeTexture, [NativeTypeName("HANDLE *")] void** pSharedHandle)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, uint, uint, uint, int, int, void**, void**, int>)(lpVtbl[24]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexture, pSharedHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCubeTexture(uint EdgeLength, uint Levels, [NativeTypeName("DWORD")] uint Usage, [NativeTypeName("D3DFORMAT")] int Format, [NativeTypeName("D3DPOOL")] int Pool, [NativeTypeName("IDirect3DCubeTexture9 **")] void** ppCubeTexture, [NativeTypeName("HANDLE *")] void** pSharedHandle)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, uint, int, int, void**, void**, int>)(lpVtbl[25]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), EdgeLength, Levels, Usage, Format, Pool, ppCubeTexture, pSharedHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVertexBuffer(uint Length, [NativeTypeName("DWORD")] uint Usage, [NativeTypeName("DWORD")] uint FVF, [NativeTypeName("D3DPOOL")] int Pool, [NativeTypeName("IDirect3DVertexBuffer9 **")] void** ppVertexBuffer, [NativeTypeName("HANDLE *")] void** pSharedHandle)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, uint, int, void**, void**, int>)(lpVtbl[26]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Length, Usage, FVF, Pool, ppVertexBuffer, pSharedHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int CreateIndexBuffer(uint Length, [NativeTypeName("DWORD")] uint Usage, [NativeTypeName("D3DFORMAT")] int Format, [NativeTypeName("D3DPOOL")] int Pool, [NativeTypeName("IDirect3DIndexBuffer9 **")] void** ppIndexBuffer, [NativeTypeName("HANDLE *")] void** pSharedHandle)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, int, int, void**, void**, int>)(lpVtbl[27]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Length, Usage, Format, Pool, ppIndexBuffer, pSharedHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRenderTarget(uint Width, uint Height, [NativeTypeName("D3DFORMAT")] int Format, [NativeTypeName("D3DMULTISAMPLE_TYPE")] int MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] int Lockable, [NativeTypeName("IDirect3DSurface9 **")] void** ppSurface, [NativeTypeName("HANDLE *")] void** pSharedHandle)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, int, int, uint, int, void**, void**, int>)(lpVtbl[28]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDepthStencilSurface(uint Width, uint Height, [NativeTypeName("D3DFORMAT")] int Format, [NativeTypeName("D3DMULTISAMPLE_TYPE")] int MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] int Discard, [NativeTypeName("IDirect3DSurface9 **")] void** ppSurface, [NativeTypeName("HANDLE *")] void** pSharedHandle)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, int, int, uint, int, void**, void**, int>)(lpVtbl[29]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateSurface([NativeTypeName("IDirect3DSurface9*")] void* pSourceSurface, [NativeTypeName("const RECT *")] VectorInt4* pSourceRect, [NativeTypeName("IDirect3DSurface9*")] void* pDestinationSurface, [NativeTypeName("const POINT *")] Vector2* pDestPoint)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, void*, VectorInt4*, void*, Vector2*, int>)(lpVtbl[30]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pSourceSurface, pSourceRect, pDestinationSurface, pDestPoint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateTexture([NativeTypeName("IDirect3DBaseTexture9*")] void* pSourceTexture, [NativeTypeName("IDirect3DBaseTexture9*")] void* pDestinationTexture)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, void*, void*, int>)(lpVtbl[31]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pSourceTexture, pDestinationTexture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int GetRenderTargetData([NativeTypeName("IDirect3DSurface9*")] void* pRenderTarget, [NativeTypeName("IDirect3DSurface9*")] void* pDestSurface)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, void*, void*, int>)(lpVtbl[32]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pRenderTarget, pDestSurface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrontBufferData(uint iSwapChain, [NativeTypeName("IDirect3DSurface9*")] void* pDestSurface)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, void*, int>)(lpVtbl[33]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), iSwapChain, pDestSurface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int StretchRect([NativeTypeName("IDirect3DSurface9*")] void* pSourceSurface, [NativeTypeName("const RECT *")] VectorInt4* pSourceRect, [NativeTypeName("IDirect3DSurface9*")] void* pDestSurface, [NativeTypeName("const RECT *")] VectorInt4* pDestRect, [NativeTypeName("D3DTEXTUREFILTERTYPE")] int Filter)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, void*, VectorInt4*, void*, VectorInt4*, int, int>)(lpVtbl[34]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pSourceSurface, pSourceRect, pDestSurface, pDestRect, Filter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int ColorFill([NativeTypeName("IDirect3DSurface9*")] void* pSurface, [NativeTypeName("const RECT *")] VectorInt4* pRect, [NativeTypeName("D3DCOLOR")] uint color)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, void*, VectorInt4*, uint, int>)(lpVtbl[35]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pSurface, pRect, color);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int CreateOffscreenPlainSurface(uint Width, uint Height, [NativeTypeName("D3DFORMAT")] int Format, [NativeTypeName("D3DPOOL")] int Pool, [NativeTypeName("IDirect3DSurface9 **")] void** ppSurface, [NativeTypeName("HANDLE *")] void** pSharedHandle)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, int, int, void**, void**, int>)(lpVtbl[36]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Width, Height, Format, Pool, ppSurface, pSharedHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int SetRenderTarget([NativeTypeName("DWORD")] uint RenderTargetIndex, [NativeTypeName("IDirect3DSurface9*")] void* pRenderTarget)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, void*, int>)(lpVtbl[37]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), RenderTargetIndex, pRenderTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int GetRenderTarget([NativeTypeName("DWORD")] uint RenderTargetIndex, [NativeTypeName("IDirect3DSurface9 **")] void** ppRenderTarget)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, void**, int>)(lpVtbl[38]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), RenderTargetIndex, ppRenderTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int SetDepthStencilSurface([NativeTypeName("IDirect3DSurface9*")] void* pNewZStencil)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, void*, int>)(lpVtbl[39]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pNewZStencil);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int GetDepthStencilSurface([NativeTypeName("IDirect3DSurface9 **")] void** ppZStencilSurface)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, void**, int>)(lpVtbl[40]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), ppZStencilSurface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int BeginScene()
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, int>)(lpVtbl[41]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int EndScene()
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, int>)(lpVtbl[42]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int Clear([NativeTypeName("DWORD")] uint Count, [NativeTypeName("const D3DRECT *")] VectorInt4* pRects, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("D3DCOLOR")] uint Color, float Z, [NativeTypeName("DWORD")] uint Stencil)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, VectorInt4*, uint, uint, float, uint, int>)(lpVtbl[43]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Count, pRects, Flags, Color, Z, Stencil);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int SetTransform([NativeTypeName("D3DTRANSFORMSTATETYPE")] int State, [NativeTypeName("const D3DMATRIX *")] Matrix4x4* pMatrix)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, int, Matrix4x4*, int>)(lpVtbl[44]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), State, pMatrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int GetTransform([NativeTypeName("D3DTRANSFORMSTATETYPE")] int State, [NativeTypeName("D3DMATRIX *")] Matrix4x4* pMatrix)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, int, Matrix4x4*, int>)(lpVtbl[45]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), State, pMatrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int MultiplyTransform([NativeTypeName("D3DTRANSFORMSTATETYPE")] int param0, [NativeTypeName("const D3DMATRIX *")] Matrix4x4* param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, int, Matrix4x4*, int>)(lpVtbl[46]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int SetViewport([NativeTypeName("const D3DVIEWPORT9 *")] void* pViewport)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, void*, int>)(lpVtbl[47]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pViewport);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int GetViewport([NativeTypeName("D3DVIEWPORT9 *")] void* pViewport)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, void*, int>)(lpVtbl[48]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pViewport);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int SetMaterial([NativeTypeName("const D3DMATERIAL9 *")] void* pMaterial)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, void*, int>)(lpVtbl[49]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pMaterial);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int GetMaterial([NativeTypeName("D3DMATERIAL9 *")] void* pMaterial)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, void*, int>)(lpVtbl[50]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pMaterial);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int SetLight([NativeTypeName("DWORD")] uint Index, [NativeTypeName("const D3DLIGHT9 *")] void* param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, void*, int>)(lpVtbl[51]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Index, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int GetLight([NativeTypeName("DWORD")] uint Index, [NativeTypeName("D3DLIGHT9 *")] void* param1)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, void*, int>)(lpVtbl[52]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Index, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int LightEnable([NativeTypeName("DWORD")] uint Index, [NativeTypeName("BOOL")] int Enable)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int, int>)(lpVtbl[53]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Index, Enable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int GetLightEnable([NativeTypeName("DWORD")] uint Index, [NativeTypeName("BOOL *")] int* pEnable)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, int>)(lpVtbl[54]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Index, pEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int SetClipPlane([NativeTypeName("DWORD")] uint Index, [NativeTypeName("const float *")] float* pPlane)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, int>)(lpVtbl[55]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Index, pPlane);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int GetClipPlane([NativeTypeName("DWORD")] uint Index, float* pPlane)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, int>)(lpVtbl[56]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Index, pPlane);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int SetRenderState([NativeTypeName("D3DRENDERSTATETYPE")] int State, [NativeTypeName("DWORD")] uint Value)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, int, uint, int>)(lpVtbl[57]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), State, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int GetRenderState([NativeTypeName("D3DRENDERSTATETYPE")] int State, [NativeTypeName("DWORD *")] uint* pValue)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, int, uint*, int>)(lpVtbl[58]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), State, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int CreateStateBlock([NativeTypeName("D3DSTATEBLOCKTYPE")] int Type, [NativeTypeName("IDirect3DStateBlock9 **")] void** ppSB)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, int, void**, int>)(lpVtbl[59]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Type, ppSB);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int BeginStateBlock()
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, int>)(lpVtbl[60]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int EndStateBlock([NativeTypeName("IDirect3DStateBlock9 **")] void** ppSB)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, void**, int>)(lpVtbl[61]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), ppSB);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int SetClipStatus([NativeTypeName("const D3DCLIPSTATUS9 *")] IntPtr pClipStatus)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IntPtr, int>)(lpVtbl[62]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pClipStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        public int GetClipStatus([NativeTypeName("D3DCLIPSTATUS9 *")] IntPtr pClipStatus)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IntPtr, int>)(lpVtbl[63]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pClipStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        public int GetTexture([NativeTypeName("DWORD")] uint Stage, [NativeTypeName("IDirect3DBaseTexture9 **")] void** ppTexture)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, void**, int>)(lpVtbl[64]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Stage, ppTexture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        [return: NativeTypeName("HRESULT")]
        public int SetTexture([NativeTypeName("DWORD")] uint Stage, [NativeTypeName("IDirect3DBaseTexture9*")] void* pTexture)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, void*, int>)(lpVtbl[65]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Stage, pTexture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        [return: NativeTypeName("HRESULT")]
        public int GetTextureStageState([NativeTypeName("DWORD")] uint Stage, [NativeTypeName("D3DTEXTURESTAGESTATETYPE")] int Type, [NativeTypeName("DWORD *")] uint* pValue)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int, uint*, int>)(lpVtbl[66]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Stage, Type, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        [return: NativeTypeName("HRESULT")]
        public int SetTextureStageState([NativeTypeName("DWORD")] uint Stage, [NativeTypeName("D3DTEXTURESTAGESTATETYPE")] int Type, [NativeTypeName("DWORD")] uint Value)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int, uint, int>)(lpVtbl[67]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Stage, Type, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        [return: NativeTypeName("HRESULT")]
        public int GetSamplerState([NativeTypeName("DWORD")] uint Sampler, [NativeTypeName("D3DSAMPLERSTATETYPE")] int Type, [NativeTypeName("DWORD *")] uint* pValue)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int, uint*, int>)(lpVtbl[68]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Sampler, Type, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        [return: NativeTypeName("HRESULT")]
        public int SetSamplerState([NativeTypeName("DWORD")] uint Sampler, [NativeTypeName("D3DSAMPLERSTATETYPE")] int Type, [NativeTypeName("DWORD")] uint Value)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int, uint, int>)(lpVtbl[69]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Sampler, Type, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        [return: NativeTypeName("HRESULT")]
        public int ValidateDevice([NativeTypeName("DWORD *")] uint* pNumPasses)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint*, int>)(lpVtbl[70]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pNumPasses);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        [return: NativeTypeName("HRESULT")]
        public int SetPaletteEntries(uint PaletteNumber, [NativeTypeName("const PALETTEENTRY *")] IntPtr pEntries)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IntPtr, int>)(lpVtbl[71]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), PaletteNumber, pEntries);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        [return: NativeTypeName("HRESULT")]
        public int GetPaletteEntries(uint PaletteNumber, [NativeTypeName("PALETTEENTRY *")] IntPtr pEntries)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, IntPtr, int>)(lpVtbl[72]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), PaletteNumber, pEntries);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        [return: NativeTypeName("HRESULT")]
        public int SetCurrentTexturePalette(uint PaletteNumber)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int>)(lpVtbl[73]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), PaletteNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentTexturePalette(uint* PaletteNumber)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint*, int>)(lpVtbl[74]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), PaletteNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        [return: NativeTypeName("HRESULT")]
        public int SetScissorRect([NativeTypeName("const RECT *")] VectorInt4* pRect)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, VectorInt4*, int>)(lpVtbl[75]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        [return: NativeTypeName("HRESULT")]
        public int GetScissorRect([NativeTypeName("RECT *")] VectorInt4* pRect)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, VectorInt4*, int>)(lpVtbl[76]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        [return: NativeTypeName("HRESULT")]
        public int SetSoftwareVertexProcessing([NativeTypeName("BOOL")] int bSoftware)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, int, int>)(lpVtbl[77]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), bSoftware);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        [return: NativeTypeName("BOOL")]
        public int GetSoftwareVertexProcessing()
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, int>)(lpVtbl[78]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        [return: NativeTypeName("HRESULT")]
        public int SetNPatchMode(float nSegments)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, float, int>)(lpVtbl[79]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), nSegments);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        public float GetNPatchMode()
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, float>)(lpVtbl[80]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        [return: NativeTypeName("HRESULT")]
        public int DrawPrimitive([NativeTypeName("D3DPRIMITIVETYPE")] int PrimitiveType, uint StartVertex, uint PrimitiveCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, int, uint, uint, int>)(lpVtbl[81]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), PrimitiveType, StartVertex, PrimitiveCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        [return: NativeTypeName("HRESULT")]
        public int DrawIndexedPrimitive([NativeTypeName("D3DPRIMITIVETYPE")] int param0, int BaseVertexIndex, uint MinVertexIndex, uint NumVertices, uint startIndex, uint primCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, int, int, uint, uint, uint, uint, int>)(lpVtbl[82]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), param0, BaseVertexIndex, MinVertexIndex, NumVertices, startIndex, primCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        [return: NativeTypeName("HRESULT")]
        public int DrawPrimitiveUP([NativeTypeName("D3DPRIMITIVETYPE")] int PrimitiveType, uint PrimitiveCount, [NativeTypeName("const void *")] void* pVertexStreamZeroData, uint VertexStreamZeroStride)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, int, uint, void*, uint, int>)(lpVtbl[83]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), PrimitiveType, PrimitiveCount, pVertexStreamZeroData, VertexStreamZeroStride);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        [return: NativeTypeName("HRESULT")]
        public int DrawIndexedPrimitiveUP([NativeTypeName("D3DPRIMITIVETYPE")] int PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, [NativeTypeName("const void *")] void* pIndexData, [NativeTypeName("D3DFORMAT")] int IndexDataFormat, [NativeTypeName("const void *")] void* pVertexStreamZeroData, uint VertexStreamZeroStride)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, int, uint, uint, uint, void*, int, void*, uint, int>)(lpVtbl[84]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexData, IndexDataFormat, pVertexStreamZeroData, VertexStreamZeroStride);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessVertices(uint SrcStartIndex, uint DestIndex, uint VertexCount, [NativeTypeName("IDirect3DVertexBuffer9*")] void* pDestBuffer, [NativeTypeName("IDirect3DVertexDeclaration9*")] void* pVertexDecl, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, uint, void*, void*, uint, int>)(lpVtbl[85]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), SrcStartIndex, DestIndex, VertexCount, pDestBuffer, pVertexDecl, Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVertexDeclaration([NativeTypeName("const D3DVERTEXELEMENT9 *")] IntPtr pVertexElements, [NativeTypeName("IDirect3DVertexDeclaration9 **")] void** ppDecl)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, IntPtr, void**, int>)(lpVtbl[86]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pVertexElements, ppDecl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        [return: NativeTypeName("HRESULT")]
        public int SetVertexDeclaration([NativeTypeName("IDirect3DVertexDeclaration9*")] void* pDecl)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, void*, int>)(lpVtbl[87]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pDecl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        [return: NativeTypeName("HRESULT")]
        public int GetVertexDeclaration([NativeTypeName("IDirect3DVertexDeclaration9 **")] void** ppDecl)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, void**, int>)(lpVtbl[88]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), ppDecl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        [return: NativeTypeName("HRESULT")]
        public int SetFVF([NativeTypeName("DWORD")] uint FVF)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int>)(lpVtbl[89]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), FVF);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        [return: NativeTypeName("HRESULT")]
        public int GetFVF([NativeTypeName("DWORD *")] uint* pFVF)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint*, int>)(lpVtbl[90]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pFVF);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        [return: NativeTypeName("HRESULT")]
        public int CreateVertexShader([NativeTypeName("const DWORD *")] uint* pFunction, [NativeTypeName("IDirect3DVertexShader9 **")] void** ppShader)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint*, void**, int>)(lpVtbl[91]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pFunction, ppShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        [return: NativeTypeName("HRESULT")]
        public int SetVertexShader([NativeTypeName("IDirect3DVertexShader9*")] void* pShader)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, void*, int>)(lpVtbl[92]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        [return: NativeTypeName("HRESULT")]
        public int GetVertexShader([NativeTypeName("IDirect3DVertexShader9 **")] void** ppShader)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, void**, int>)(lpVtbl[93]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), ppShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(94)]
        [return: NativeTypeName("HRESULT")]
        public int SetVertexShaderConstantF(uint StartRegister, [NativeTypeName("const float *")] float* pConstantData, uint Vector4fCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, uint, int>)(lpVtbl[94]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4fCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(95)]
        [return: NativeTypeName("HRESULT")]
        public int GetVertexShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, uint, int>)(lpVtbl[95]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4fCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(96)]
        [return: NativeTypeName("HRESULT")]
        public int SetVertexShaderConstantI(uint StartRegister, [NativeTypeName("const int *")] int* pConstantData, uint Vector4iCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, uint, int>)(lpVtbl[96]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4iCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(97)]
        [return: NativeTypeName("HRESULT")]
        public int GetVertexShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, uint, int>)(lpVtbl[97]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4iCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(98)]
        [return: NativeTypeName("HRESULT")]
        public int SetVertexShaderConstantB(uint StartRegister, [NativeTypeName("const BOOL *")] int* pConstantData, uint BoolCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, uint, int>)(lpVtbl[98]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, BoolCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(99)]
        [return: NativeTypeName("HRESULT")]
        public int GetVertexShaderConstantB(uint StartRegister, [NativeTypeName("BOOL *")] int* pConstantData, uint BoolCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, uint, int>)(lpVtbl[99]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, BoolCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(100)]
        [return: NativeTypeName("HRESULT")]
        public int SetStreamSource(uint StreamNumber, [NativeTypeName("IDirect3DVertexBuffer9*")] void* pStreamData, uint OffsetInBytes, uint Stride)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, void*, uint, uint, int>)(lpVtbl[100]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StreamNumber, pStreamData, OffsetInBytes, Stride);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(101)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamSource(uint StreamNumber, [NativeTypeName("IDirect3DVertexBuffer9 **")] void** ppStreamData, uint* pOffsetInBytes, uint* pStride)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, void**, uint*, uint*, int>)(lpVtbl[101]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StreamNumber, ppStreamData, pOffsetInBytes, pStride);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(102)]
        [return: NativeTypeName("HRESULT")]
        public int SetStreamSourceFreq(uint StreamNumber, uint Setting)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint, int>)(lpVtbl[102]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StreamNumber, Setting);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(103)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamSourceFreq(uint StreamNumber, uint* pSetting)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, uint*, int>)(lpVtbl[103]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StreamNumber, pSetting);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(104)]
        [return: NativeTypeName("HRESULT")]
        public int SetIndices([NativeTypeName("IDirect3DIndexBuffer9*")] void* pIndexData)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, void*, int>)(lpVtbl[104]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pIndexData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(105)]
        [return: NativeTypeName("HRESULT")]
        public int GetIndices([NativeTypeName("IDirect3DIndexBuffer9 **")] void** ppIndexData)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, void**, int>)(lpVtbl[105]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), ppIndexData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(106)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePixelShader([NativeTypeName("const DWORD *")] uint* pFunction, [NativeTypeName("IDirect3DPixelShader9 **")] void** ppShader)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint*, void**, int>)(lpVtbl[106]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pFunction, ppShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(107)]
        [return: NativeTypeName("HRESULT")]
        public int SetPixelShader([NativeTypeName("IDirect3DPixelShader9*")] void* pShader)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, void*, int>)(lpVtbl[107]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(108)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelShader([NativeTypeName("IDirect3DPixelShader9 **")] void** ppShader)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, void**, int>)(lpVtbl[108]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), ppShader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(109)]
        [return: NativeTypeName("HRESULT")]
        public int SetPixelShaderConstantF(uint StartRegister, [NativeTypeName("const float *")] float* pConstantData, uint Vector4fCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, uint, int>)(lpVtbl[109]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4fCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(110)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, uint, int>)(lpVtbl[110]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4fCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(111)]
        [return: NativeTypeName("HRESULT")]
        public int SetPixelShaderConstantI(uint StartRegister, [NativeTypeName("const int *")] int* pConstantData, uint Vector4iCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, uint, int>)(lpVtbl[111]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4iCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(112)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, uint, int>)(lpVtbl[112]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4iCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(113)]
        [return: NativeTypeName("HRESULT")]
        public int SetPixelShaderConstantB(uint StartRegister, [NativeTypeName("const BOOL *")] int* pConstantData, uint BoolCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, uint, int>)(lpVtbl[113]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, BoolCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(114)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelShaderConstantB(uint StartRegister, [NativeTypeName("BOOL *")] int* pConstantData, uint BoolCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int*, uint, int>)(lpVtbl[114]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, BoolCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(115)]
        [return: NativeTypeName("HRESULT")]
        public int DrawRectPatch(uint Handle, [NativeTypeName("const float *")] float* pNumSegs, [NativeTypeName("const D3DRECTPATCH_INFO *")] IntPtr pRectPatchInfo)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, IntPtr, int>)(lpVtbl[115]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Handle, pNumSegs, pRectPatchInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(116)]
        [return: NativeTypeName("HRESULT")]
        public int DrawTriPatch(uint Handle, [NativeTypeName("const float *")] float* pNumSegs, [NativeTypeName("const D3DTRIPATCH_INFO *")] IntPtr pTriPatchInfo)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, float*, IntPtr, int>)(lpVtbl[116]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Handle, pNumSegs, pTriPatchInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(117)]
        [return: NativeTypeName("HRESULT")]
        public int DeletePatch(uint Handle)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, uint, int>)(lpVtbl[117]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Handle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(118)]
        [return: NativeTypeName("HRESULT")]
        public int CreateQuery([NativeTypeName("D3DQUERYTYPE")] int Type, [NativeTypeName("IDirect3DQuery9 **")] void** ppQuery)
        {
            return ((delegate* unmanaged[Stdcall]<IDirect3DDevice9*, int, void**, int>)(lpVtbl[118]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Type, ppQuery);
        }

        public interface Interface
        {
            [VtblIndex(0)]
            [return: NativeTypeName("HRESULT")]
            int QueryInterface([NativeTypeName("const IID &")] IntPtr riid, void** ppvObj);

            [VtblIndex(1)]
            [return: NativeTypeName("ULONG")]
            uint AddRef();

            [VtblIndex(2)]
            [return: NativeTypeName("ULONG")]
            uint Release();

            [VtblIndex(3)]
            [return: NativeTypeName("HRESULT")]
            int TestCooperativeLevel();

            [VtblIndex(4)]
            uint GetAvailableTextureMem();

            [VtblIndex(5)]
            [return: NativeTypeName("HRESULT")]
            int EvictManagedResources();

            [VtblIndex(6)]
            [return: NativeTypeName("HRESULT")]
            int GetDirect3D([NativeTypeName("IDirect3D9 **")] void** ppD3D9);

            [VtblIndex(7)]
            [return: NativeTypeName("HRESULT")]
            int GetDeviceCaps([NativeTypeName("D3DCAPS9 *")] IntPtr pCaps);

            [VtblIndex(8)]
            [return: NativeTypeName("HRESULT")]
            int GetDisplayMode(uint iSwapChain, [NativeTypeName("D3DDISPLAYMODE *")] IntPtr pMode);

            [VtblIndex(9)]
            [return: NativeTypeName("HRESULT")]
            int GetCreationParameters([NativeTypeName("D3DDEVICE_CREATION_PARAMETERS *")] IntPtr pParameters);

            [VtblIndex(10)]
            [return: NativeTypeName("HRESULT")]
            int SetCursorProperties(uint XHotSpot, uint YHotSpot, [NativeTypeName("IDirect3DSurface9*")] void* pCursorBitmap);

            [VtblIndex(11)]
            void SetCursorPosition(int X, int Y, [NativeTypeName("DWORD")] uint Flags);

            [VtblIndex(12)]
            [return: NativeTypeName("BOOL")]
            int ShowCursor([NativeTypeName("BOOL")] int bShow);

            [VtblIndex(13)]
            [return: NativeTypeName("HRESULT")]
            int CreateAdditionalSwapChain([NativeTypeName("D3DPRESENT_PARAMETERS *")] IntPtr pPresentationParameters, [NativeTypeName("IDirect3DSwapChain9 **")] void** pSwapChain);

            [VtblIndex(14)]
            [return: NativeTypeName("HRESULT")]
            int GetSwapChain(uint iSwapChain, [NativeTypeName("IDirect3DSwapChain9 **")] void** pSwapChain);

            [VtblIndex(15)]
            uint GetNumberOfSwapChains();

            [VtblIndex(16)]
            [return: NativeTypeName("HRESULT")]
            int Reset([NativeTypeName("D3DPRESENT_PARAMETERS *")] IntPtr pPresentationParameters);

            [VtblIndex(17)]
            [return: NativeTypeName("HRESULT")]
            int Present([NativeTypeName("const RECT *")] VectorInt4* pSourceRect, [NativeTypeName("const RECT *")] VectorInt4* pDestRect, [NativeTypeName("HWND")] IntPtr hDestWindowOverride, [NativeTypeName("const RGNDATA *")] IntPtr pDirtyRegion);

            [VtblIndex(18)]
            [return: NativeTypeName("HRESULT")]
            int GetBackBuffer(uint iSwapChain, uint iBackBuffer, [NativeTypeName("D3DBACKBUFFER_TYPE")] int Type, [NativeTypeName("IDirect3DSurface9 **")] void** ppBackBuffer);

            [VtblIndex(19)]
            [return: NativeTypeName("HRESULT")]
            int GetRasterStatus(uint iSwapChain, [NativeTypeName("D3DRASTER_STATUS *")] IntPtr pRasterStatus);

            [VtblIndex(20)]
            [return: NativeTypeName("HRESULT")]
            int SetDialogBoxMode([NativeTypeName("BOOL")] int bEnableDialogs);

            [VtblIndex(21)]
            void SetGammaRamp(uint iSwapChain, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("const D3DGAMMARAMP *")] IntPtr pRamp);

            [VtblIndex(22)]
            void GetGammaRamp(uint iSwapChain, [NativeTypeName("D3DGAMMARAMP *")] IntPtr pRamp);

            [VtblIndex(23)]
            [return: NativeTypeName("HRESULT")]
            int CreateTexture(uint Width, uint Height, uint Levels, [NativeTypeName("DWORD")] uint Usage, [NativeTypeName("D3DFORMAT")] int Format, [NativeTypeName("D3DPOOL")] int Pool, [NativeTypeName("IDirect3DTexture9 **")] void** ppTexture, [NativeTypeName("HANDLE *")] void** pSharedHandle);

            [VtblIndex(24)]
            [return: NativeTypeName("HRESULT")]
            int CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, [NativeTypeName("DWORD")] uint Usage, [NativeTypeName("D3DFORMAT")] int Format, [NativeTypeName("D3DPOOL")] int Pool, [NativeTypeName("IDirect3DVolumeTexture9 **")] void** ppVolumeTexture, [NativeTypeName("HANDLE *")] void** pSharedHandle);

            [VtblIndex(25)]
            [return: NativeTypeName("HRESULT")]
            int CreateCubeTexture(uint EdgeLength, uint Levels, [NativeTypeName("DWORD")] uint Usage, [NativeTypeName("D3DFORMAT")] int Format, [NativeTypeName("D3DPOOL")] int Pool, [NativeTypeName("IDirect3DCubeTexture9 **")] void** ppCubeTexture, [NativeTypeName("HANDLE *")] void** pSharedHandle);

            [VtblIndex(26)]
            [return: NativeTypeName("HRESULT")]
            int CreateVertexBuffer(uint Length, [NativeTypeName("DWORD")] uint Usage, [NativeTypeName("DWORD")] uint FVF, [NativeTypeName("D3DPOOL")] int Pool, [NativeTypeName("IDirect3DVertexBuffer9 **")] void** ppVertexBuffer, [NativeTypeName("HANDLE *")] void** pSharedHandle);

            [VtblIndex(27)]
            [return: NativeTypeName("HRESULT")]
            int CreateIndexBuffer(uint Length, [NativeTypeName("DWORD")] uint Usage, [NativeTypeName("D3DFORMAT")] int Format, [NativeTypeName("D3DPOOL")] int Pool, [NativeTypeName("IDirect3DIndexBuffer9 **")] void** ppIndexBuffer, [NativeTypeName("HANDLE *")] void** pSharedHandle);

            [VtblIndex(28)]
            [return: NativeTypeName("HRESULT")]
            int CreateRenderTarget(uint Width, uint Height, [NativeTypeName("D3DFORMAT")] int Format, [NativeTypeName("D3DMULTISAMPLE_TYPE")] int MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] int Lockable, [NativeTypeName("IDirect3DSurface9 **")] void** ppSurface, [NativeTypeName("HANDLE *")] void** pSharedHandle);

            [VtblIndex(29)]
            [return: NativeTypeName("HRESULT")]
            int CreateDepthStencilSurface(uint Width, uint Height, [NativeTypeName("D3DFORMAT")] int Format, [NativeTypeName("D3DMULTISAMPLE_TYPE")] int MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, [NativeTypeName("BOOL")] int Discard, [NativeTypeName("IDirect3DSurface9 **")] void** ppSurface, [NativeTypeName("HANDLE *")] void** pSharedHandle);

            [VtblIndex(30)]
            [return: NativeTypeName("HRESULT")]
            int UpdateSurface([NativeTypeName("IDirect3DSurface9*")] void* pSourceSurface, [NativeTypeName("const RECT *")] VectorInt4* pSourceRect, [NativeTypeName("IDirect3DSurface9*")] void* pDestinationSurface, [NativeTypeName("const POINT *")] Vector2* pDestPoint);

            [VtblIndex(31)]
            [return: NativeTypeName("HRESULT")]
            int UpdateTexture([NativeTypeName("IDirect3DBaseTexture9*")] void* pSourceTexture, [NativeTypeName("IDirect3DBaseTexture9*")] void* pDestinationTexture);

            [VtblIndex(32)]
            [return: NativeTypeName("HRESULT")]
            int GetRenderTargetData([NativeTypeName("IDirect3DSurface9*")] void* pRenderTarget, [NativeTypeName("IDirect3DSurface9*")] void* pDestSurface);

            [VtblIndex(33)]
            [return: NativeTypeName("HRESULT")]
            int GetFrontBufferData(uint iSwapChain, [NativeTypeName("IDirect3DSurface9*")] void* pDestSurface);

            [VtblIndex(34)]
            [return: NativeTypeName("HRESULT")]
            int StretchRect([NativeTypeName("IDirect3DSurface9*")] void* pSourceSurface, [NativeTypeName("const RECT *")] VectorInt4* pSourceRect, [NativeTypeName("IDirect3DSurface9*")] void* pDestSurface, [NativeTypeName("const RECT *")] VectorInt4* pDestRect, [NativeTypeName("D3DTEXTUREFILTERTYPE")] int Filter);

            [VtblIndex(35)]
            [return: NativeTypeName("HRESULT")]
            int ColorFill([NativeTypeName("IDirect3DSurface9*")] void* pSurface, [NativeTypeName("const RECT *")] VectorInt4* pRect, [NativeTypeName("D3DCOLOR")] uint color);

            [VtblIndex(36)]
            [return: NativeTypeName("HRESULT")]
            int CreateOffscreenPlainSurface(uint Width, uint Height, [NativeTypeName("D3DFORMAT")] int Format, [NativeTypeName("D3DPOOL")] int Pool, [NativeTypeName("IDirect3DSurface9 **")] void** ppSurface, [NativeTypeName("HANDLE *")] void** pSharedHandle);

            [VtblIndex(37)]
            [return: NativeTypeName("HRESULT")]
            int SetRenderTarget([NativeTypeName("DWORD")] uint RenderTargetIndex, [NativeTypeName("IDirect3DSurface9*")] void* pRenderTarget);

            [VtblIndex(38)]
            [return: NativeTypeName("HRESULT")]
            int GetRenderTarget([NativeTypeName("DWORD")] uint RenderTargetIndex, [NativeTypeName("IDirect3DSurface9 **")] void** ppRenderTarget);

            [VtblIndex(39)]
            [return: NativeTypeName("HRESULT")]
            int SetDepthStencilSurface([NativeTypeName("IDirect3DSurface9*")] void* pNewZStencil);

            [VtblIndex(40)]
            [return: NativeTypeName("HRESULT")]
            int GetDepthStencilSurface([NativeTypeName("IDirect3DSurface9 **")] void** ppZStencilSurface);

            [VtblIndex(41)]
            [return: NativeTypeName("HRESULT")]
            int BeginScene();

            [VtblIndex(42)]
            [return: NativeTypeName("HRESULT")]
            int EndScene();

            [VtblIndex(43)]
            [return: NativeTypeName("HRESULT")]
            int Clear([NativeTypeName("DWORD")] uint Count, [NativeTypeName("const D3DRECT *")] VectorInt4* pRects, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("D3DCOLOR")] uint Color, float Z, [NativeTypeName("DWORD")] uint Stencil);

            [VtblIndex(44)]
            [return: NativeTypeName("HRESULT")]
            int SetTransform([NativeTypeName("D3DTRANSFORMSTATETYPE")] int State, [NativeTypeName("const D3DMATRIX *")] Matrix4x4* pMatrix);

            [VtblIndex(45)]
            [return: NativeTypeName("HRESULT")]
            int GetTransform([NativeTypeName("D3DTRANSFORMSTATETYPE")] int State, [NativeTypeName("D3DMATRIX *")] Matrix4x4* pMatrix);

            [VtblIndex(46)]
            [return: NativeTypeName("HRESULT")]
            int MultiplyTransform([NativeTypeName("D3DTRANSFORMSTATETYPE")] int param0, [NativeTypeName("const D3DMATRIX *")] Matrix4x4* param1);

            [VtblIndex(47)]
            [return: NativeTypeName("HRESULT")]
            int SetViewport([NativeTypeName("const D3DVIEWPORT9 *")] void* pViewport);

            [VtblIndex(48)]
            [return: NativeTypeName("HRESULT")]
            int GetViewport([NativeTypeName("D3DVIEWPORT9 *")] void* pViewport);

            [VtblIndex(49)]
            [return: NativeTypeName("HRESULT")]
            int SetMaterial([NativeTypeName("const D3DMATERIAL9 *")] void* pMaterial);

            [VtblIndex(50)]
            [return: NativeTypeName("HRESULT")]
            int GetMaterial([NativeTypeName("D3DMATERIAL9 *")] void* pMaterial);

            [VtblIndex(51)]
            [return: NativeTypeName("HRESULT")]
            int SetLight([NativeTypeName("DWORD")] uint Index, [NativeTypeName("const D3DLIGHT9 *")] void* param1);

            [VtblIndex(52)]
            [return: NativeTypeName("HRESULT")]
            int GetLight([NativeTypeName("DWORD")] uint Index, [NativeTypeName("D3DLIGHT9 *")] void* param1);

            [VtblIndex(53)]
            [return: NativeTypeName("HRESULT")]
            int LightEnable([NativeTypeName("DWORD")] uint Index, [NativeTypeName("BOOL")] int Enable);

            [VtblIndex(54)]
            [return: NativeTypeName("HRESULT")]
            int GetLightEnable([NativeTypeName("DWORD")] uint Index, [NativeTypeName("BOOL *")] int* pEnable);

            [VtblIndex(55)]
            [return: NativeTypeName("HRESULT")]
            int SetClipPlane([NativeTypeName("DWORD")] uint Index, [NativeTypeName("const float *")] float* pPlane);

            [VtblIndex(56)]
            [return: NativeTypeName("HRESULT")]
            int GetClipPlane([NativeTypeName("DWORD")] uint Index, float* pPlane);

            [VtblIndex(57)]
            [return: NativeTypeName("HRESULT")]
            int SetRenderState([NativeTypeName("D3DRENDERSTATETYPE")] int State, [NativeTypeName("DWORD")] uint Value);

            [VtblIndex(58)]
            [return: NativeTypeName("HRESULT")]
            int GetRenderState([NativeTypeName("D3DRENDERSTATETYPE")] int State, [NativeTypeName("DWORD *")] uint* pValue);

            [VtblIndex(59)]
            [return: NativeTypeName("HRESULT")]
            int CreateStateBlock([NativeTypeName("D3DSTATEBLOCKTYPE")] int Type, [NativeTypeName("IDirect3DStateBlock9 **")] void** ppSB);

            [VtblIndex(60)]
            [return: NativeTypeName("HRESULT")]
            int BeginStateBlock();

            [VtblIndex(61)]
            [return: NativeTypeName("HRESULT")]
            int EndStateBlock([NativeTypeName("IDirect3DStateBlock9 **")] void** ppSB);

            [VtblIndex(62)]
            [return: NativeTypeName("HRESULT")]
            int SetClipStatus([NativeTypeName("const D3DCLIPSTATUS9 *")] IntPtr pClipStatus);

            [VtblIndex(63)]
            [return: NativeTypeName("HRESULT")]
            int GetClipStatus([NativeTypeName("D3DCLIPSTATUS9 *")] IntPtr pClipStatus);

            [VtblIndex(64)]
            [return: NativeTypeName("HRESULT")]
            int GetTexture([NativeTypeName("DWORD")] uint Stage, [NativeTypeName("IDirect3DBaseTexture9 **")] void** ppTexture);

            [VtblIndex(65)]
            [return: NativeTypeName("HRESULT")]
            int SetTexture([NativeTypeName("DWORD")] uint Stage, [NativeTypeName("IDirect3DBaseTexture9*")] void* pTexture);

            [VtblIndex(66)]
            [return: NativeTypeName("HRESULT")]
            int GetTextureStageState([NativeTypeName("DWORD")] uint Stage, [NativeTypeName("D3DTEXTURESTAGESTATETYPE")] int Type, [NativeTypeName("DWORD *")] uint* pValue);

            [VtblIndex(67)]
            [return: NativeTypeName("HRESULT")]
            int SetTextureStageState([NativeTypeName("DWORD")] uint Stage, [NativeTypeName("D3DTEXTURESTAGESTATETYPE")] int Type, [NativeTypeName("DWORD")] uint Value);

            [VtblIndex(68)]
            [return: NativeTypeName("HRESULT")]
            int GetSamplerState([NativeTypeName("DWORD")] uint Sampler, [NativeTypeName("D3DSAMPLERSTATETYPE")] int Type, [NativeTypeName("DWORD *")] uint* pValue);

            [VtblIndex(69)]
            [return: NativeTypeName("HRESULT")]
            int SetSamplerState([NativeTypeName("DWORD")] uint Sampler, [NativeTypeName("D3DSAMPLERSTATETYPE")] int Type, [NativeTypeName("DWORD")] uint Value);

            [VtblIndex(70)]
            [return: NativeTypeName("HRESULT")]
            int ValidateDevice([NativeTypeName("DWORD *")] uint* pNumPasses);

            [VtblIndex(71)]
            [return: NativeTypeName("HRESULT")]
            int SetPaletteEntries(uint PaletteNumber, [NativeTypeName("const PALETTEENTRY *")] IntPtr pEntries);

            [VtblIndex(72)]
            [return: NativeTypeName("HRESULT")]
            int GetPaletteEntries(uint PaletteNumber, [NativeTypeName("PALETTEENTRY *")] IntPtr pEntries);

            [VtblIndex(73)]
            [return: NativeTypeName("HRESULT")]
            int SetCurrentTexturePalette(uint PaletteNumber);

            [VtblIndex(74)]
            [return: NativeTypeName("HRESULT")]
            int GetCurrentTexturePalette(uint* PaletteNumber);

            [VtblIndex(75)]
            [return: NativeTypeName("HRESULT")]
            int SetScissorRect([NativeTypeName("const RECT *")] VectorInt4* pRect);

            [VtblIndex(76)]
            [return: NativeTypeName("HRESULT")]
            int GetScissorRect([NativeTypeName("RECT *")] VectorInt4* pRect);

            [VtblIndex(77)]
            [return: NativeTypeName("HRESULT")]
            int SetSoftwareVertexProcessing([NativeTypeName("BOOL")] int bSoftware);

            [VtblIndex(78)]
            [return: NativeTypeName("BOOL")]
            int GetSoftwareVertexProcessing();

            [VtblIndex(79)]
            [return: NativeTypeName("HRESULT")]
            int SetNPatchMode(float nSegments);

            [VtblIndex(80)]
            float GetNPatchMode();

            [VtblIndex(81)]
            [return: NativeTypeName("HRESULT")]
            int DrawPrimitive([NativeTypeName("D3DPRIMITIVETYPE")] int PrimitiveType, uint StartVertex, uint PrimitiveCount);

            [VtblIndex(82)]
            [return: NativeTypeName("HRESULT")]
            int DrawIndexedPrimitive([NativeTypeName("D3DPRIMITIVETYPE")] int param0, int BaseVertexIndex, uint MinVertexIndex, uint NumVertices, uint startIndex, uint primCount);

            [VtblIndex(83)]
            [return: NativeTypeName("HRESULT")]
            int DrawPrimitiveUP([NativeTypeName("D3DPRIMITIVETYPE")] int PrimitiveType, uint PrimitiveCount, [NativeTypeName("const void *")] void* pVertexStreamZeroData, uint VertexStreamZeroStride);

            [VtblIndex(84)]
            [return: NativeTypeName("HRESULT")]
            int DrawIndexedPrimitiveUP([NativeTypeName("D3DPRIMITIVETYPE")] int PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, [NativeTypeName("const void *")] void* pIndexData, [NativeTypeName("D3DFORMAT")] int IndexDataFormat, [NativeTypeName("const void *")] void* pVertexStreamZeroData, uint VertexStreamZeroStride);

            [VtblIndex(85)]
            [return: NativeTypeName("HRESULT")]
            int ProcessVertices(uint SrcStartIndex, uint DestIndex, uint VertexCount, [NativeTypeName("IDirect3DVertexBuffer9*")] void* pDestBuffer, [NativeTypeName("IDirect3DVertexDeclaration9*")] void* pVertexDecl, [NativeTypeName("DWORD")] uint Flags);

            [VtblIndex(86)]
            [return: NativeTypeName("HRESULT")]
            int CreateVertexDeclaration([NativeTypeName("const D3DVERTEXELEMENT9 *")] IntPtr pVertexElements, [NativeTypeName("IDirect3DVertexDeclaration9 **")] void** ppDecl);

            [VtblIndex(87)]
            [return: NativeTypeName("HRESULT")]
            int SetVertexDeclaration([NativeTypeName("IDirect3DVertexDeclaration9*")] void* pDecl);

            [VtblIndex(88)]
            [return: NativeTypeName("HRESULT")]
            int GetVertexDeclaration([NativeTypeName("IDirect3DVertexDeclaration9 **")] void** ppDecl);

            [VtblIndex(89)]
            [return: NativeTypeName("HRESULT")]
            int SetFVF([NativeTypeName("DWORD")] uint FVF);

            [VtblIndex(90)]
            [return: NativeTypeName("HRESULT")]
            int GetFVF([NativeTypeName("DWORD *")] uint* pFVF);

            [VtblIndex(91)]
            [return: NativeTypeName("HRESULT")]
            int CreateVertexShader([NativeTypeName("const DWORD *")] uint* pFunction, [NativeTypeName("IDirect3DVertexShader9 **")] void** ppShader);

            [VtblIndex(92)]
            [return: NativeTypeName("HRESULT")]
            int SetVertexShader([NativeTypeName("IDirect3DVertexShader9*")] void* pShader);

            [VtblIndex(93)]
            [return: NativeTypeName("HRESULT")]
            int GetVertexShader([NativeTypeName("IDirect3DVertexShader9 **")] void** ppShader);

            [VtblIndex(94)]
            [return: NativeTypeName("HRESULT")]
            int SetVertexShaderConstantF(uint StartRegister, [NativeTypeName("const float *")] float* pConstantData, uint Vector4fCount);

            [VtblIndex(95)]
            [return: NativeTypeName("HRESULT")]
            int GetVertexShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount);

            [VtblIndex(96)]
            [return: NativeTypeName("HRESULT")]
            int SetVertexShaderConstantI(uint StartRegister, [NativeTypeName("const int *")] int* pConstantData, uint Vector4iCount);

            [VtblIndex(97)]
            [return: NativeTypeName("HRESULT")]
            int GetVertexShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount);

            [VtblIndex(98)]
            [return: NativeTypeName("HRESULT")]
            int SetVertexShaderConstantB(uint StartRegister, [NativeTypeName("const BOOL *")] int* pConstantData, uint BoolCount);

            [VtblIndex(99)]
            [return: NativeTypeName("HRESULT")]
            int GetVertexShaderConstantB(uint StartRegister, [NativeTypeName("BOOL *")] int* pConstantData, uint BoolCount);

            [VtblIndex(100)]
            [return: NativeTypeName("HRESULT")]
            int SetStreamSource(uint StreamNumber, [NativeTypeName("IDirect3DVertexBuffer9*")] void* pStreamData, uint OffsetInBytes, uint Stride);

            [VtblIndex(101)]
            [return: NativeTypeName("HRESULT")]
            int GetStreamSource(uint StreamNumber, [NativeTypeName("IDirect3DVertexBuffer9 **")] void** ppStreamData, uint* pOffsetInBytes, uint* pStride);

            [VtblIndex(102)]
            [return: NativeTypeName("HRESULT")]
            int SetStreamSourceFreq(uint StreamNumber, uint Setting);

            [VtblIndex(103)]
            [return: NativeTypeName("HRESULT")]
            int GetStreamSourceFreq(uint StreamNumber, uint* pSetting);

            [VtblIndex(104)]
            [return: NativeTypeName("HRESULT")]
            int SetIndices([NativeTypeName("IDirect3DIndexBuffer9*")] void* pIndexData);

            [VtblIndex(105)]
            [return: NativeTypeName("HRESULT")]
            int GetIndices([NativeTypeName("IDirect3DIndexBuffer9 **")] void** ppIndexData);

            [VtblIndex(106)]
            [return: NativeTypeName("HRESULT")]
            int CreatePixelShader([NativeTypeName("const DWORD *")] uint* pFunction, [NativeTypeName("IDirect3DPixelShader9 **")] void** ppShader);

            [VtblIndex(107)]
            [return: NativeTypeName("HRESULT")]
            int SetPixelShader([NativeTypeName("IDirect3DPixelShader9*")] void* pShader);

            [VtblIndex(108)]
            [return: NativeTypeName("HRESULT")]
            int GetPixelShader([NativeTypeName("IDirect3DPixelShader9 **")] void** ppShader);

            [VtblIndex(109)]
            [return: NativeTypeName("HRESULT")]
            int SetPixelShaderConstantF(uint StartRegister, [NativeTypeName("const float *")] float* pConstantData, uint Vector4fCount);

            [VtblIndex(110)]
            [return: NativeTypeName("HRESULT")]
            int GetPixelShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount);

            [VtblIndex(111)]
            [return: NativeTypeName("HRESULT")]
            int SetPixelShaderConstantI(uint StartRegister, [NativeTypeName("const int *")] int* pConstantData, uint Vector4iCount);

            [VtblIndex(112)]
            [return: NativeTypeName("HRESULT")]
            int GetPixelShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount);

            [VtblIndex(113)]
            [return: NativeTypeName("HRESULT")]
            int SetPixelShaderConstantB(uint StartRegister, [NativeTypeName("const BOOL *")] int* pConstantData, uint BoolCount);

            [VtblIndex(114)]
            [return: NativeTypeName("HRESULT")]
            int GetPixelShaderConstantB(uint StartRegister, [NativeTypeName("BOOL *")] int* pConstantData, uint BoolCount);

            [VtblIndex(115)]
            [return: NativeTypeName("HRESULT")]
            int DrawRectPatch(uint Handle, [NativeTypeName("const float *")] float* pNumSegs, [NativeTypeName("const D3DRECTPATCH_INFO *")] IntPtr pRectPatchInfo);

            [VtblIndex(116)]
            [return: NativeTypeName("HRESULT")]
            int DrawTriPatch(uint Handle, [NativeTypeName("const float *")] float* pNumSegs, [NativeTypeName("const D3DTRIPATCH_INFO *")] IntPtr pTriPatchInfo);

            [VtblIndex(117)]
            [return: NativeTypeName("HRESULT")]
            int DeletePatch(uint Handle);

            [VtblIndex(118)]
            [return: NativeTypeName("HRESULT")]
            int CreateQuery([NativeTypeName("D3DQUERYTYPE")] int Type, [NativeTypeName("IDirect3DQuery9 **")] void** ppQuery);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int> TestCooperativeLevel;

            [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint> GetAvailableTextureMem;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int> EvictManagedResources;

            [NativeTypeName("HRESULT (IDirect3D9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, void**, int> GetDirect3D;

            [NativeTypeName("HRESULT (D3DCAPS9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, int> GetDeviceCaps;

            [NativeTypeName("HRESULT (UINT, D3DDISPLAYMODE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, IntPtr, int> GetDisplayMode;

            [NativeTypeName("HRESULT (D3DDEVICE_CREATION_PARAMETERS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, int> GetCreationParameters;

            [NativeTypeName("HRESULT (UINT, UINT, IDirect3DSurface9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, uint, void*, int> SetCursorProperties;

            [NativeTypeName("void (int, int, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int, int, uint, void> SetCursorPosition;

            [NativeTypeName("BOOL (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int, int> ShowCursor;

            [NativeTypeName("HRESULT (D3DPRESENT_PARAMETERS *, IDirect3DSwapChain9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, void**, int> CreateAdditionalSwapChain;

            [NativeTypeName("HRESULT (UINT, IDirect3DSwapChain9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, void**, int> GetSwapChain;

            [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint> GetNumberOfSwapChains;

            [NativeTypeName("HRESULT (D3DPRESENT_PARAMETERS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, int> Reset;

            [NativeTypeName("HRESULT (const RECT *, const RECT *, HWND, const RGNDATA *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, VectorInt4*, VectorInt4*, IntPtr, IntPtr, int> Present;

            [NativeTypeName("HRESULT (UINT, UINT, D3DBACKBUFFER_TYPE, IDirect3DSurface9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, uint, int, void**, int> GetBackBuffer;

            [NativeTypeName("HRESULT (UINT, D3DRASTER_STATUS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, IntPtr, int> GetRasterStatus;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int, int> SetDialogBoxMode;

            [NativeTypeName("void (UINT, DWORD, const D3DGAMMARAMP *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, uint, IntPtr, void> SetGammaRamp;

            [NativeTypeName("void (UINT, D3DGAMMARAMP *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, IntPtr, void> GetGammaRamp;

            [NativeTypeName("HRESULT (UINT, UINT, UINT, DWORD, D3DFORMAT, D3DPOOL, IDirect3DTexture9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, uint, uint, uint, int, int, void**, void**, int> CreateTexture;

            [NativeTypeName("HRESULT (UINT, UINT, UINT, UINT, DWORD, D3DFORMAT, D3DPOOL, IDirect3DVolumeTexture9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, uint, uint, uint, uint, int, int, void**, void**, int> CreateVolumeTexture;

            [NativeTypeName("HRESULT (UINT, UINT, DWORD, D3DFORMAT, D3DPOOL, IDirect3DCubeTexture9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, uint, uint, int, int, void**, void**, int> CreateCubeTexture;

            [NativeTypeName("HRESULT (UINT, DWORD, DWORD, D3DPOOL, IDirect3DVertexBuffer9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, uint, uint, int, void**, void**, int> CreateVertexBuffer;

            [NativeTypeName("HRESULT (UINT, DWORD, D3DFORMAT, D3DPOOL, IDirect3DIndexBuffer9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, uint, int, int, void**, void**, int> CreateIndexBuffer;

            [NativeTypeName("HRESULT (UINT, UINT, D3DFORMAT, D3DMULTISAMPLE_TYPE, DWORD, BOOL, IDirect3DSurface9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, uint, int, int, uint, int, void**, void**, int> CreateRenderTarget;

            [NativeTypeName("HRESULT (UINT, UINT, D3DFORMAT, D3DMULTISAMPLE_TYPE, DWORD, BOOL, IDirect3DSurface9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, uint, int, int, uint, int, void**, void**, int> CreateDepthStencilSurface;

            [NativeTypeName("HRESULT (IDirect3DSurface9 *, const RECT *, IDirect3DSurface9 *, const POINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, void*, VectorInt4*, void*, Vector2*, int> UpdateSurface;

            [NativeTypeName("HRESULT (IDirect3DBaseTexture9 *, IDirect3DBaseTexture9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, void*, void*, int> UpdateTexture;

            [NativeTypeName("HRESULT (IDirect3DSurface9 *, IDirect3DSurface9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, void*, void*, int> GetRenderTargetData;

            [NativeTypeName("HRESULT (UINT, IDirect3DSurface9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, void*, int> GetFrontBufferData;

            [NativeTypeName("HRESULT (IDirect3DSurface9 *, const RECT *, IDirect3DSurface9 *, const RECT *, D3DTEXTUREFILTERTYPE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, void*, VectorInt4*, void*, VectorInt4*, int, int> StretchRect;

            [NativeTypeName("HRESULT (IDirect3DSurface9 *, const RECT *, D3DCOLOR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, void*, VectorInt4*, uint, int> ColorFill;

            [NativeTypeName("HRESULT (UINT, UINT, D3DFORMAT, D3DPOOL, IDirect3DSurface9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, uint, int, int, void**, void**, int> CreateOffscreenPlainSurface;

            [NativeTypeName("HRESULT (DWORD, IDirect3DSurface9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, void*, int> SetRenderTarget;

            [NativeTypeName("HRESULT (DWORD, IDirect3DSurface9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, void**, int> GetRenderTarget;

            [NativeTypeName("HRESULT (IDirect3DSurface9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, void*, int> SetDepthStencilSurface;

            [NativeTypeName("HRESULT (IDirect3DSurface9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, void**, int> GetDepthStencilSurface;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int> BeginScene;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int> EndScene;

            [NativeTypeName("HRESULT (DWORD, const D3DRECT *, DWORD, D3DCOLOR, float, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, VectorInt4*, uint, uint, float, uint, int> Clear;

            [NativeTypeName("HRESULT (D3DTRANSFORMSTATETYPE, const D3DMATRIX *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int, Matrix4x4*, int> SetTransform;

            [NativeTypeName("HRESULT (D3DTRANSFORMSTATETYPE, D3DMATRIX *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int, Matrix4x4*, int> GetTransform;

            [NativeTypeName("HRESULT (D3DTRANSFORMSTATETYPE, const D3DMATRIX *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int, Matrix4x4*, int> MultiplyTransform;

            [NativeTypeName("HRESULT (const D3DVIEWPORT9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, void*, int> SetViewport;

            [NativeTypeName("HRESULT (D3DVIEWPORT9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, void*, int> GetViewport;

            [NativeTypeName("HRESULT (const D3DMATERIAL9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, void*, int> SetMaterial;

            [NativeTypeName("HRESULT (D3DMATERIAL9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, void*, int> GetMaterial;

            [NativeTypeName("HRESULT (DWORD, const D3DLIGHT9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, void*, int> SetLight;

            [NativeTypeName("HRESULT (DWORD, D3DLIGHT9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, void*, int> GetLight;

            [NativeTypeName("HRESULT (DWORD, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, int, int> LightEnable;

            [NativeTypeName("HRESULT (DWORD, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, int*, int> GetLightEnable;

            [NativeTypeName("HRESULT (DWORD, const float *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, float*, int> SetClipPlane;

            [NativeTypeName("HRESULT (DWORD, float *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, float*, int> GetClipPlane;

            [NativeTypeName("HRESULT (D3DRENDERSTATETYPE, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int, uint, int> SetRenderState;

            [NativeTypeName("HRESULT (D3DRENDERSTATETYPE, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int, uint*, int> GetRenderState;

            [NativeTypeName("HRESULT (D3DSTATEBLOCKTYPE, IDirect3DStateBlock9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int, void**, int> CreateStateBlock;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int> BeginStateBlock;

            [NativeTypeName("HRESULT (IDirect3DStateBlock9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, void**, int> EndStateBlock;

            [NativeTypeName("HRESULT (const D3DCLIPSTATUS9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, int> SetClipStatus;

            [NativeTypeName("HRESULT (D3DCLIPSTATUS9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, int> GetClipStatus;

            [NativeTypeName("HRESULT (DWORD, IDirect3DBaseTexture9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, void**, int> GetTexture;

            [NativeTypeName("HRESULT (DWORD, IDirect3DBaseTexture9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, void*, int> SetTexture;

            [NativeTypeName("HRESULT (DWORD, D3DTEXTURESTAGESTATETYPE, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, int, uint*, int> GetTextureStageState;

            [NativeTypeName("HRESULT (DWORD, D3DTEXTURESTAGESTATETYPE, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, int, uint, int> SetTextureStageState;

            [NativeTypeName("HRESULT (DWORD, D3DSAMPLERSTATETYPE, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, int, uint*, int> GetSamplerState;

            [NativeTypeName("HRESULT (DWORD, D3DSAMPLERSTATETYPE, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, int, uint, int> SetSamplerState;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint*, int> ValidateDevice;

            [NativeTypeName("HRESULT (UINT, const PALETTEENTRY *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, IntPtr, int> SetPaletteEntries;

            [NativeTypeName("HRESULT (UINT, PALETTEENTRY *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, IntPtr, int> GetPaletteEntries;

            [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, int> SetCurrentTexturePalette;

            [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint*, int> GetCurrentTexturePalette;

            [NativeTypeName("HRESULT (const RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, VectorInt4*, int> SetScissorRect;

            [NativeTypeName("HRESULT (RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, VectorInt4*, int> GetScissorRect;

            [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int, int> SetSoftwareVertexProcessing;

            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int> GetSoftwareVertexProcessing;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, float, int> SetNPatchMode;

            [NativeTypeName("float () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, float> GetNPatchMode;

            [NativeTypeName("HRESULT (D3DPRIMITIVETYPE, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int, uint, uint, int> DrawPrimitive;

            [NativeTypeName("HRESULT (D3DPRIMITIVETYPE, INT, UINT, UINT, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int, int, uint, uint, uint, uint, int> DrawIndexedPrimitive;

            [NativeTypeName("HRESULT (D3DPRIMITIVETYPE, UINT, const void *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int, uint, void*, uint, int> DrawPrimitiveUP;

            [NativeTypeName("HRESULT (D3DPRIMITIVETYPE, UINT, UINT, UINT, const void *, D3DFORMAT, const void *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int, uint, uint, uint, void*, int, void*, uint, int> DrawIndexedPrimitiveUP;

            [NativeTypeName("HRESULT (UINT, UINT, UINT, IDirect3DVertexBuffer9 *, IDirect3DVertexDeclaration9 *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, uint, uint, void*, void*, uint, int> ProcessVertices;

            [NativeTypeName("HRESULT (const D3DVERTEXELEMENT9 *, IDirect3DVertexDeclaration9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, IntPtr, void**, int> CreateVertexDeclaration;

            [NativeTypeName("HRESULT (IDirect3DVertexDeclaration9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, void*, int> SetVertexDeclaration;

            [NativeTypeName("HRESULT (IDirect3DVertexDeclaration9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, void**, int> GetVertexDeclaration;

            [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, int> SetFVF;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint*, int> GetFVF;

            [NativeTypeName("HRESULT (const DWORD *, IDirect3DVertexShader9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint*, void**, int> CreateVertexShader;

            [NativeTypeName("HRESULT (IDirect3DVertexShader9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, void*, int> SetVertexShader;

            [NativeTypeName("HRESULT (IDirect3DVertexShader9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, void**, int> GetVertexShader;

            [NativeTypeName("HRESULT (UINT, const float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, float*, uint, int> SetVertexShaderConstantF;

            [NativeTypeName("HRESULT (UINT, float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, float*, uint, int> GetVertexShaderConstantF;

            [NativeTypeName("HRESULT (UINT, const int *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, int*, uint, int> SetVertexShaderConstantI;

            [NativeTypeName("HRESULT (UINT, int *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, int*, uint, int> GetVertexShaderConstantI;

            [NativeTypeName("HRESULT (UINT, const BOOL *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, int*, uint, int> SetVertexShaderConstantB;

            [NativeTypeName("HRESULT (UINT, BOOL *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, int*, uint, int> GetVertexShaderConstantB;

            [NativeTypeName("HRESULT (UINT, IDirect3DVertexBuffer9 *, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, void*, uint, uint, int> SetStreamSource;

            [NativeTypeName("HRESULT (UINT, IDirect3DVertexBuffer9 **, UINT *, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, void**, uint*, uint*, int> GetStreamSource;

            [NativeTypeName("HRESULT (UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, uint, int> SetStreamSourceFreq;

            [NativeTypeName("HRESULT (UINT, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, uint*, int> GetStreamSourceFreq;

            [NativeTypeName("HRESULT (IDirect3DIndexBuffer9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, void*, int> SetIndices;

            [NativeTypeName("HRESULT (IDirect3DIndexBuffer9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, void**, int> GetIndices;

            [NativeTypeName("HRESULT (const DWORD *, IDirect3DPixelShader9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint*, void**, int> CreatePixelShader;

            [NativeTypeName("HRESULT (IDirect3DPixelShader9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, void*, int> SetPixelShader;

            [NativeTypeName("HRESULT (IDirect3DPixelShader9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, void**, int> GetPixelShader;

            [NativeTypeName("HRESULT (UINT, const float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, float*, uint, int> SetPixelShaderConstantF;

            [NativeTypeName("HRESULT (UINT, float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, float*, uint, int> GetPixelShaderConstantF;

            [NativeTypeName("HRESULT (UINT, const int *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, int*, uint, int> SetPixelShaderConstantI;

            [NativeTypeName("HRESULT (UINT, int *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, int*, uint, int> GetPixelShaderConstantI;

            [NativeTypeName("HRESULT (UINT, const BOOL *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, int*, uint, int> SetPixelShaderConstantB;

            [NativeTypeName("HRESULT (UINT, BOOL *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, int*, uint, int> GetPixelShaderConstantB;

            [NativeTypeName("HRESULT (UINT, const float *, const D3DRECTPATCH_INFO *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, float*, IntPtr, int> DrawRectPatch;

            [NativeTypeName("HRESULT (UINT, const float *, const D3DTRIPATCH_INFO *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, float*, IntPtr, int> DrawTriPatch;

            [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, uint, int> DeletePatch;

            [NativeTypeName("HRESULT (D3DQUERYTYPE, IDirect3DQuery9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged[Stdcall]<TSelf*, int, void**, int> CreateQuery;
        }
    }
}
