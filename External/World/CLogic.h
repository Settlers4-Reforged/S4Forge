#pragma once

#include "../s4.h"
#include "./CEffects.h"

class CLogic {
public:
    int field_4;
    int field_8;
    BYTE gap_C[4];
    int field_10;
    int field_14;
    int field_18;
    char field_1C;
    BYTE gap_1D[3];
    void* FutureEvents;
    CEffects* Effects;
    int field_28;
    int field_2C;
    int field_30;
    int field_34;
    int field_38;

    virtual BYTE* dtor(); // at 0xF2580
};
