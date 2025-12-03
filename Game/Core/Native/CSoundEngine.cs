using Forge.Native;
using Forge.Native.Helpers;
using System.Runtime.InteropServices;

namespace Forge.Native
{
    // Struct Size: 0x1E0
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct CSoundEngine
    {
        [NativeInheritance(nameof(CSoundEngine))]
        [NativeTypeName("DWORD")]
        public uint soundPanning;

        [NativeInheritance(nameof(CSoundEngine))]
        public int field_4;

        [NativeInheritance(nameof(CSoundEngine))]
        public int field_8;

        [NativeInheritance(nameof(CSoundEngine))]
        public int field_C;

        [NativeInheritance(nameof(CSoundEngine))]
        public int musicVolume;

        [NativeInheritance(nameof(CSoundEngine))]
        public int soundVolume;

        [NativeInheritance(nameof(CSoundEngine))]
        public int volumeModifier;

        [NativeInheritance(nameof(CSoundEngine))]
        [NativeTypeName("DWORD *")]
        public uint* soundMappings;

        [NativeInheritance(nameof(CSoundEngine))]
        [NativeTypeName("DWORD *")]
        public uint* volumesX;

        [NativeInheritance(nameof(CSoundEngine))]
        [NativeTypeName("DWORD")]
        public uint soundCount;

        [NativeInheritance(nameof(CSoundEngine))]
        [NativeTypeName("float[101]")]
        public fixed float volumes[101];

        [NativeInheritance(nameof(CSoundEngine))]
        public byte field_1BC;

        [NativeInheritance(nameof(CSoundEngine))]
        [NativeTypeName("BYTE[15]")]
        public fixed byte gap_1BD[15];

        [NativeInheritance(nameof(CSoundEngine))]
        [NativeTypeName("DWORD")]
        public uint field_1CC;

        [NativeInheritance(nameof(CSoundEngine))]
        [NativeTypeName("DWORD")]
        public uint field_1D0;

        [NativeInheritance(nameof(CSoundEngine))]
        [NativeTypeName("DWORD *")]
        public uint* field_1D4;

        [NativeInheritance(nameof(CSoundEngine))]
        public void* sndFile;

        [NativeInheritance(nameof(CSoundEngine))]
        [NativeTypeName("DWORD")]
        public uint field_1DC;
    }
}
