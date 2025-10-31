
struct wstring {
    union {
        __int16* text;
        __int16 buffer[8];
    } storage; // (1)
    int size;
    int capacity;
};
