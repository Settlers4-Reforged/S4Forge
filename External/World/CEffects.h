#pragma once

#include "CBBObject.h"
#include "IS4ChunkObject.h"

#pragma pack(push, 1)
struct __attribute__((packed)) CEffectGroup
{
  BYTE type;
  BYTE effectId;
  BYTE soundId;
  BYTE field_3;
  WORD field_4;
  BYTE frameCount;
  BYTE field_7;
  char* startTick;
  int field_C;
  __int64 pos;
  float screenOffsetX;
  float screenOffsetY;
  BYTE gap_20[20];
  int(__thiscall* callback)(CEffectGroup* _this, int a2, unsigned int a3);
  DWORD field_38;
};
#pragma pack(pop)

class IGfxEffects {
    virtual int sub_E3310(signed int a2, signed int a3, signed int a4, signed int a5, signed int a6); ///< -> 000E3310, args: 0x14
    virtual int sub_E33B0(int); ///< -> 000E33B0, args: 0x4
    virtual BYTE* sub_E3580(); ///< -> 000E3580, args: 0x0
    virtual int sub_E3650(); ///< -> 000E3650, args: 0x0
    virtual void AddEffect(int effectId, int soundId, int x, int y, int delay, int duration, int effectType); ///< -> 000E3A80, args: 0x1C
    virtual int sub_E3C80(int, char, int, int, int, int); ///< -> 000E3C80, args: 0x18
    virtual int sub_E3B20(int, int, int, int, int, int); ///< -> 000E3B20, args: 0x18
    virtual int sub_E3B90(int, int, int); ///< -> 000E3B90, args: 0xC
    virtual int sub_E3C10(unsigned int, char, __int64, char, int); ///< -> 000E3C10, args: 0x18
    virtual char sub_E3D00(int); ///< -> 000E3D00, args: 0x4
    virtual int sub_E3D60(unsigned int, float, float); ///< -> 000E3D60, args: 0xC
    virtual int sub_E3DC0(int, unsigned int); ///< -> 000E3DC0, args: 0x8
    virtual int sub_E3E50(int); ///< -> 000E3E50, args: 0x4
    virtual DWORD* sub_E3E70(int, DWORD*, DWORD*, DWORD*, DWORD*); ///< -> 000E3E70, args: 0x14
    virtual int sub_E3F20(int, int); ///< -> 000E3F20, args: 0x8
    virtual int sub_E3F70(int, float, unsigned int, float); ///< -> 000E3F70, args: 0x10
    virtual int sub_E3FC0(int); ///< -> 000E3FC0, args: 0x4
    virtual int sub_E4000(int, int); ///< -> 000E4000, args: 0x8
    virtual int sub_E4070(int); ///< -> 000E4070, args: 0x4
    virtual int sub_E4050(int, int); ///< -> 000E4050, args: 0x8
    virtual int sub_E4090(char, int, char); ///< -> 000E4090, args: 0xC
    virtual int sub_E4110(int, int, int); ///< -> 000E4110, args: 0xC
    virtual char sub_E4160(int); ///< -> 000E4160, args: 0x4
    virtual char sub_E41E0(int); ///< -> 000E41E0, args: 0x4
    virtual int sub_E4230(); ///< -> 000E4230, args: 0x0
    virtual int sub_E3810(int);      ///< -> 000E3810, args: 0x4
};

class IEffects : public IGfxEffects, public IS4ChunkObject {
    
};

#pragma pack(push, 1)
class CEffects : public IEffects, public CBBObject {
public:
    // CEffects_vtbl* __vftable /*VFT*/;
    // CEffects_CBBObject_vtbl* __vftable_4;
    // CEffects_IS4ChunkObject_vtbl* __vftable_8;
    DWORD field_C;
    DWORD field_10;
    DWORD field_14;
    DWORD field_18;
    DWORD field_1C;
    DWORD field_20;
    DWORD field_24;
    DWORD field_28;
    DWORD field_2C;
    WORD field_30[64];
    BYTE gap_B0[8192];
    BYTE field_20B0[8448];
    CEffectGroup effectGroups[4096];
    BYTE field_401B0[16384];
    int field_441B0;
    int field_441B4;
    BYTE field_441B8;
    BYTE gap_441B9[463];
};
#pragma pack(pop)
