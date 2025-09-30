using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace System.Numerics {
    public struct VectorInt4 {
        public int X;
        public int Y;
        public int Z;
        public int W;
        public VectorInt4(int x, int y, int z, int w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
        public override string ToString() {
            return $"({X}, {Y}, {Z}, {W})";
        }
    }
}

namespace Forge.Native.DirectX {
    public unsafe partial struct IDirectDrawSurface7 {
        public unsafe void* GetNativeSurface9() {
            return (void*)(((int*)(Unsafe.AsPointer(ref this)))[43]);
        }

        public unsafe IDirect3DDevice9* GetNativeDevice9() {
            void* direct3D9Surface = GetNativeSurface9();
            if (direct3D9Surface == null) return null;
            void** direct3D9SurfaceVTable = *(void***)direct3D9Surface;
            var GetDevice = ((delegate* unmanaged[Stdcall]<void*, void*, int>)(direct3D9SurfaceVTable[3]));

            void* device;
            int hresult = GetDevice(direct3D9Surface, &device);
            if (hresult < 0) return null;
            return (IDirect3DDevice9*)device;
        }

        public unsafe void* GetNativeDirect3D9() {
            IDirect3DDevice9* d3dDevice = GetNativeDevice9();
            if (d3dDevice == null) return null;

            void* d3d;
            int hresult = d3dDevice->GetDirect3D(&d3d);
            if (hresult < 0) return null;
            return d3d;
        }

        // Cache for default S4 state:
        static void* defaultVertexShader = null;
        static void* defaultPixelShader = null;
        static uint defaultMinFilter, defaultMagFilter;
        static void* mainRenderTarget = null;

        const int D3DSAMP_MAGFILTER = 5;
        const int D3DSAMP_MINFILTER = 6;
        const int D3DFVF_XYZ = 0x002;
        const int D3DFVF_DIFFUSE = 0x040;
        const int D3DFVF_TEX1 = 0x100;
        const int D3DSAMP_ADDRESSU = 1;
        const int D3DSAMP_ADDRESSV = 2;
        const int D3DTADDRESS_CLAMP = 3;
        const int D3DRS_SEPARATEALPHABLENDENABLE = 206;

        const int D3DTS_WORLD = 256;
        const int D3DTS_VIEW = 2;
        const int D3DTS_PROJECTION = 3;
        const int D3DTS_TEXTURE0 = 16;

        const int D3DRS_ZENABLE = 7;
        const int D3DRS_CULLMODE = 22;
        const int D3DRS_LIGHTING = 137;
        const int D3DZB_FALSE = 0;
        const int D3DCULL_NONE = 1;
        const int D3DTSS_COLOROP = 1;
        const int D3DTOP_MODULATE = 4;
        const int D3DTSS_COLORARG1 = 2;
        const int D3DTA_TEXTURE = 2;
        const int D3DTSS_COLORARG2 = 3;
        const int D3DTA_DIFFUSE = 0;
        const int D3DTSS_ALPHAOP = 4;
        const int D3DTSS_ALPHAARG1 = 5;
        const int D3DTSS_ALPHAARG2 = 6;
        const int D3DTOP_DISABLE = 1;


        public unsafe void ResetD3D() {
            //D3DPERF_BeginEvent(0xff00ff, L"Cleanup SDL");

            IDirect3DDevice9* d3dDevice = GetNativeDevice9();

            // Not resetting will prevent any rendering
            d3dDevice->SetVertexShader(defaultVertexShader);
            d3dDevice->SetPixelShader(defaultPixelShader);

            //TODO: find a way to actually have linear+ filtering as it can drastically improve the look of the game
            // Not resetting will lead to "smearing" in the terrain engine
            d3dDevice->SetSamplerState(0, D3DSAMP_MINFILTER, defaultMinFilter);
            // Not resetting will break the color keying for e.g. the chat
            d3dDevice->SetSamplerState(0, D3DSAMP_MAGFILTER, defaultMinFilter);

            //D3DPERF_EndEvent();

            //D3DPERF_EndEvent(); //SDL RENDER
        }

        public unsafe void RestoreMainRenderTarget() {
            IDirect3DDevice9* d3dDevice = GetNativeDevice9();
            d3dDevice->SetRenderTarget(0, mainRenderTarget);
            return;
        }


        public unsafe void PrepareD3D() {
            IDirect3DDevice9* d3dDevice = GetNativeDevice9();

            //D3DPERF_SetMarker(0xffff00, L"Start SDL Render");

            //D3DPERF_BeginEvent(0xff00ff, L"SDL Render");
            //D3DPERF_BeginEvent(0xff00ff, L"Prepare SDL");

            // Fetch previous state:
            uint _defaultMinFilter, _defaultMagFilter;
            d3dDevice->GetSamplerState(0, D3DSAMP_MINFILTER, &_defaultMinFilter);
            d3dDevice->GetSamplerState(0, D3DSAMP_MAGFILTER, &_defaultMagFilter);
            d3dDevice->SetSamplerState(0, D3DSAMP_ADDRESSU, D3DTADDRESS_CLAMP);
            d3dDevice->SetSamplerState(0, D3DSAMP_ADDRESSV, D3DTADDRESS_CLAMP);
            defaultMinFilter = _defaultMinFilter;
            defaultMagFilter = _defaultMagFilter;

            void* _defaultPixelShader;
            d3dDevice->GetPixelShader(&_defaultPixelShader);
            defaultPixelShader = _defaultPixelShader;

            // Reset state to a SDL compatible state
            d3dDevice->SetPixelShader(null);
            d3dDevice->SetTexture(0, null);
            d3dDevice->SetTexture(1, null);
            d3dDevice->SetTexture(2, null);
            d3dDevice->SetFVF(D3DFVF_XYZ | D3DFVF_DIFFUSE | D3DFVF_TEX1);

            void* _defaultVertexShader;
            d3dDevice->GetVertexShader(&_defaultVertexShader);
            defaultVertexShader = _defaultVertexShader;
            d3dDevice->SetVertexShader(null);
            d3dDevice->SetRenderState(D3DRS_ZENABLE, D3DZB_FALSE);
            d3dDevice->SetRenderState(D3DRS_CULLMODE, D3DCULL_NONE);
            d3dDevice->SetRenderState(D3DRS_LIGHTING, 0);

            // Enable color modulation by diffuse color
            d3dDevice->SetTextureStageState(0, D3DTSS_COLOROP,
                D3DTOP_MODULATE);
            d3dDevice->SetTextureStageState(0, D3DTSS_COLORARG1,
                D3DTA_TEXTURE);
            d3dDevice->SetTextureStageState(0, D3DTSS_COLORARG2,
                D3DTA_DIFFUSE);

            // Enable alpha modulation by diffuse alpha
            d3dDevice->SetTextureStageState(0, D3DTSS_ALPHAOP,
                D3DTOP_MODULATE);
            d3dDevice->SetTextureStageState(0, D3DTSS_ALPHAARG1,
                D3DTA_TEXTURE);
            d3dDevice->SetTextureStageState(0, D3DTSS_ALPHAARG2,
                D3DTA_DIFFUSE);

            // Disable second texture stage, since we're done
            d3dDevice->SetTextureStageState(1, D3DTSS_COLOROP,
                D3DTOP_DISABLE);
            d3dDevice->SetTextureStageState(1, D3DTSS_ALPHAOP,
                D3DTOP_DISABLE);

            // Enable separate alpha blend function, if possible
            d3dDevice->SetRenderState(D3DRS_SEPARATEALPHABLENDENABLE, 1);

            // Set an identity world and view matrix
            Matrix4x4 matrix = new Matrix4x4(
                1, 0, 0, 0,
                0, 1, 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1);
            d3dDevice->SetTransform(D3DTS_WORLD, &matrix);
            d3dDevice->SetTransform(D3DTS_VIEW, &matrix);
            d3dDevice->SetTransform(D3DTS_PROJECTION, &matrix);
            d3dDevice->SetTransform(D3DTS_TEXTURE0, &matrix); // Texture matrix for Tooltips change in game, this reverts it to identity

            void* renderTarget;
            d3dDevice->GetRenderTarget(0, &renderTarget);
            mainRenderTarget = renderTarget;

            //D3DPERF_EndEvent();
        }
    }
}
