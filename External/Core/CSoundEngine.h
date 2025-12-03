#include "../s4.h"

#pragma pack(push, 1)
struct CSoundEngine {
    DWORD soundPanning;
    int field_4;
    int field_8;
    int field_C;
    int musicVolume;
    int soundVolume;
    int volumeModifier;
    DWORD* soundMappings;
    DWORD* volumesX;
    DWORD soundCount;
    float volumes[101];
    BYTE field_1BC;
    BYTE gap_1BD[15];
    DWORD field_1CC;
    DWORD field_1D0;
    DWORD* field_1D4;
    void* sndFile;
    DWORD field_1DC;
};
#pragma pack(pop)