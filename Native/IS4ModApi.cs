using Forge.Game.Events.Native;
using Forge.Native;

using System;
using System.Text;

using unsafe BOOL = System.Boolean;
using unsafe BYTE = System.Byte;
using unsafe DWORD = System.UInt32;
using unsafe HMODULE = void*;
using unsafe HRESULT = System.Int32;
using unsafe HWND = void*;
using unsafe LPINT = int*;
using unsafe LPS4UIELEMENT = System.IntPtr;
using unsafe LPSTR = System.Text.StringBuilder;
using unsafe LPVOID = void*;
using unsafe S4CUSTOMUI = void*;

using unsafe S4HOOK = System.UInt32;
using unsafe SIZE_T = System.UInt32;
using unsafe WORD = System.UInt16;

namespace Forge.Native {
    public unsafe delegate HRESULT S4FrameCallback(IntPtr lpSurface, DWORD pillarboxWidth, LPVOID lpReserved);
    public unsafe delegate HRESULT S4MapInitCallback(LPVOID lpReserved0, LPVOID lpReserved1);
    public unsafe delegate HRESULT S4MouseCallback(DWORD dwMouseButton, DWORD iX, DWORD iY, DWORD dwMsgId, HWND hwnd, IntPtr lpUiElement);
    public unsafe delegate HRESULT S4SettlerSendCallback(DWORD dwPosition, MovementType dwCommand, LPVOID lpReserved);
    public unsafe delegate HRESULT S4TickCallback(DWORD dwTick, BOOL bHasEvent, BOOL bIsDelayed);
    public unsafe delegate HRESULT S4LuaOpenCallback();
    public unsafe delegate BOOL S4BltCallback(IntPtr param, BOOL discard);
    public unsafe delegate BOOL S4GuiBltCallback(IntPtr param, BOOL discard);
    public unsafe delegate HRESULT S4EntityCallback(WORD entity, int cause);
    public unsafe delegate HRESULT S4GuiDrawCallback(IntPtr entity, BOOL discard);
    public unsafe delegate HRESULT S4GuiClearCallback(IntPtr entity, BOOL discard);
    public unsafe delegate IntPtr S4WndProc(IntPtr hWnd, uint msg, UIntPtr wParam, UIntPtr lParam); // common WndProc signature

    [Obsolete("Use native Forge implementation instead")]
    public unsafe interface IS4ModApi {
        /** Hooks/Observers **/
        void RemoveListener(S4HOOK hook);
        S4HOOK AddFrameListener(S4FrameCallback callback);
        S4HOOK AddUIFrameListener(S4FrameCallback callback, int gui);
        S4HOOK AddMapInitListener(S4MapInitCallback callback);
        S4HOOK AddMouseListener(S4MouseCallback callback);
        S4HOOK AddSettlerSendListener(S4SettlerSendCallback callback);
        S4HOOK AddTickListener(S4TickCallback callback);
        S4HOOK AddLuaOpenListener(S4LuaOpenCallback callback);
        S4HOOK AddBltListener(S4BltCallback callback);
        S4HOOK AddEntityListener(S4EntityCallback callback);
        S4HOOK AddGuiBltListener(S4GuiBltCallback callback);
        S4HOOK AddGuiClearListener(S4GuiClearCallback callback);
        S4HOOK AddGuiElementBltListener(S4GuiDrawCallback callback);

        /** WndProc **/
        S4HOOK AddWndProc(S4WndProc callback);

        /** Event Engine **/
        byte PostToMessageQueue(void* eventEngine, CEvent* evt);
        CEvent* CreateS4Event(CEvent* evt, uint a2, uint a3, uint a4, sbyte a5);
        CEvent* CreateS4UIEvent(CEvent* evt, uint a2, uint a3, uint a4, byte a5, uint a6, short a7);

        /** ISettlers4Api methods **/
        void* GetDebugData(void* a, void* b);
        DWORD GetLastError();

        /** Misc helper functions **/
        [Obsolete("Use native implementation instead")]
        int GetMD5OfModule(HMODULE module, string outBuffer, SIZE_T sz) { return 0; }
        BOOL IsEdition(S4Edition edition);
        HWND GetHwnd();

        /** Settlers 4 functions **/
        int GetHoveringUiElement(LPS4UIELEMENT element); // HRESULT -> int; element as IntPtr to struct
        BOOL GetEntitiesCount(out WORD counter);

        [Obsolete("Use UX-Engine implementation instead")]
        BOOL IsCurrentlyOnScreen(int gui);

        EntityClass EntityGetClass(WORD entity);
        BOOL GetEntities(System.UInt32[] entities, SIZE_T size); // DWORD* entities
        BOOL EntityGetPosition(WORD entity, out int x, out int y); // LPINT -> out int
        BOOL EntityGetDirection(WORD entity, out uint dir); // LPlong -> out uint
        BOOL EntityGetHealth(WORD entity, out uint health);
        BOOL EntityGetMaxHealth(WORD entity, out uint maxHealth);
        BOOL EntityGetTribe(WORD entity, out Tribe tribe);
        BOOL EntityTreeGetType(WORD entity, out TreeType tree);
        BOOL EntityPileGetType(WORD entity, out GoodType good);
        BOOL EntityDecoGetType(WORD entity, out uint deco);
        BOOL EntityPileGetAmount(WORD entity, out uint amount);
        BOOL EntitySettlerGetType(WORD entity, out SettlerType settler);
        BOOL EntityVehicleGetType(WORD entity, out VehicleType vehicle);
        BOOL EntityAnimalGetType(WORD entity, out AnimalType animal);
        BOOL EntityBuildingGetType(WORD entity, out BuildingType building);
        BOOL EntityStoneGetLevel(WORD entity, out uint level);
        BOOL EntityGetRole(WORD entity, out void** role); // LPVOID* -> IntPtr
        BOOL EntityGetRoleClass(WORD entity, out EntityRole role);
        BOOL EntityGetOwner(WORD entity, out uint player);

        BOOL ClearSelection();
        BOOL GetSelection(ushort[] outSelection, SIZE_T outlen, out SIZE_T selectionCount); // PWORD out, SIZE_T outlen, PSIZE_T selectionCount
        BOOL RemoveSelection(ushort[] settlers, SIZE_T settlerslen, out SIZE_T removedCount);
        DWORD SetMaxSelection(DWORD maxSelection);
        DWORD GetMaxSelection();
        BOOL StartBuildingPlacement(BuildingType building);
        DWORD GetGameTime();

        /** Landscape functions **/
        DWORD LandscapeGetHeight(int x, int y);
        GroundType LandscapeGetType(int x, int y); // named S4_GROUND_ENUM in original; mapping to resource enum placeholder
        BOOL LandscapeIsPond(int x, int y);
        BOOL LandscapeIsDarkLand(int x, int y);
        BOOL LandscapeIsDarkLandBorder(int x, int y);
        DWORD LandscapeGetFogOfWar(int x, int y);
        BOOL LandscapeIsFoundingStone(int x, int y);
        ResourceType LandscapeGetResource(int x, int y);
        BOOL LandscapeSetResource(int x, int y, ResourceType res);
        DWORD LandscapeGetObject(int x, int y);
        DWORD LandscapeGetOwner(int x, int y);
        DWORD LandscapeGetEcoSector(int x, int y);
        BOOL LandscapeIsOccupied(int x, int y);

        /** Settlers 4 NetEvents functions **/
        BOOL SendWarriors(int x, int y, MovementType mode, ushort[] warriors, SIZE_T countOfWarriors, DWORD player);
        BOOL BuildBuilding(BuildingType buildingType, int x, int y, DWORD player);
        BOOL CrushBuilding(DWORD building, DWORD player);
        BOOL ToggleBuildingPriority(DWORD building, DWORD player);
        BOOL ToggleBuildingHalt(DWORD building, DWORD player);
        BOOL SetBuildingWorkarea(DWORD building, int x, int y, DWORD player);
        BOOL SetBuildingProduction(DWORD building, GoodType good, int amount, DWORD player);
        BOOL SetBuildingProductionPercentMode(DWORD building, BOOL enable, DWORD player);
        BOOL SetBuildingProductionPercentage(DWORD building, byte swords, byte bows, byte armors, byte racespecialweapons, DWORD player);
        BOOL CastSpell(DWORD priest, DWORD spell, int x, int y, DWORD player);
        BOOL GarrisonWarriors(DWORD building, DWORD player);
        BOOL UnGarrisonWarriors(DWORD building, int column, BOOL bowman, DWORD player);
        BOOL ChangeGoodDistribution(GoodType good, BuildingType building, int percent, DWORD ecosector, DWORD player);
        BOOL ChangeGoodPriority(GoodType good, int offset, DWORD ecosector, DWORD player);
        BOOL RecruitWarriors(DWORD building, SettlerType unit, int amount, DWORD player);
        BOOL RecruitVehicle(DWORD building, VehicleType unit, int amount, DWORD player);
        BOOL SetTradingRoute(DWORD sourceBuilding, DWORD destinationBuilding, DWORD player);
        BOOL TradeGood(DWORD building, GoodType good, int amount, DWORD player);
        BOOL StoreGood(DWORD building, GoodType good, BOOL enable, DWORD player);


        /** S4 Scripting **/
        DWORD GetLocalPlayer();
        DWORD BuildingsAdd(BuildingType building, int x, int y, DWORD player);
        DWORD BuildingsAmount(BuildingType building, DWORD status, DWORD player);
        BOOL BuildingsCrush(DWORD building);
        BOOL BuildingsDelete(DWORD building, DWORD mode);
        BOOL BuildingsExistsBuildingInArea(BuildingType building, int x, int y, int r, DWORD status, DWORD player);
        DWORD BuildingsGetFirstBuilding(BuildingType building, DWORD player);
        DWORD BuildingsGetInhabitantAmount(DWORD building, DWORD player);
        DWORD BuildingsGetTarget(DWORD building);
        BOOL BuildingsIsSelected(BuildingType building);
        DWORD DarkTribeAddManakopter(int x, int y, DWORD player);
        BOOL DarkTribeFlyTo(int x, int y);
        BOOL AIActivate(DWORD player, BOOL activate);
        BOOL MakeDark(int x, int y);
        BOOL MakeGreen(int x, int y);
        DWORD EffectsAdd(DWORD effect, DWORD sound, int x, int y, DWORD delay);
        DWORD ArePlayerAreasConnected(int x1, int y1, DWORD player2, int x2, int y2, DWORD player);
        BOOL GameDefaultGameEndCheck();
        BOOL DisableLastNPlayersInStatistic(DWORD n);
        BOOL EnableLandExploredCheck();
        BOOL FindAnyUnit(int x, int y, int r, DWORD player);
        DWORD GetAmountOfTreesInArea(int x, int y, int r);
        DWORD GetDifficulty();
        DWORD GetNumberOfSquaresWithDarkLand(DWORD player);
        DWORD GetOffenceFightingStrength(DWORD player);
        BOOL HasPlayerLost(DWORD player);
        BOOL IsAlmostAllLandExplored(DWORD player);
        BOOL IsAreaDarkLand(int x, int y, int r);
        BOOL IsAreaGreen(int x, int y, int r);
        BOOL IsAreaOwned(int x, int y, int r, DWORD player);
        DWORD GetNumberOfPlayers();
        Tribe GetPlayerTribe(DWORD player);
        BOOL ResetFogging();
        BOOL SetAlliesDontRevealFog(BOOL enable);
        BOOL SetFightingStrength(DWORD strength, DWORD player);
        BOOL ShowClock(DWORD seconds);
        DWORD Time();
        DWORD GoodsAddPileEx(GoodType good, DWORD amount, int x, int y);
        DWORD GoodsAmount(GoodType good, DWORD player);
        DWORD GoodsDelete(GoodType good, int x, int y, int r);
        DWORD GoodsGetAmountInArea(GoodType good, int x, int y, int r, DWORD player);
        DWORD MagicCastSpell(Tribe tribe, SpellType spell, int x, int y, DWORD player);
        BOOL MagicIncreaseMana(int amount, DWORD player);
        DWORD MapAddDecoObject(DWORD obj, int x, int y);
        BOOL MapDeleteDecoObject(int x, int y, int r);
        DWORD MapSize();
        BOOL MapPointIsOnScreen(int x, int y);
        BOOL MapSetScreenPos(int x, int y);
        BOOL SettlersAdd(SettlerType settler, int amount, int x, int y, DWORD player);
        BOOL SettlersAddToFerry(DWORD ferry, SettlerType settler, int amount);
        DWORD SettlersAmount(SettlerType settler, DWORD player);
        DWORD SettlersAmountInArea(SettlerType settler, int x, int y, int r, DWORD player);
        BOOL SettlersIsSelected(SettlerType settler, int amount);
        BOOL SettlersKillSelectableSettlers(SettlerType settler, int x, int y, int r, BOOL animation, DWORD player);
        DWORD SettlersProductionAmount(SettlerType settler);
        BOOL SettlersSetHealthInArea(SettlerType settler, int x, int y, int r, DWORD health, DWORD player);
        DWORD StatisticBuildingsCaptured(DWORD player);
        DWORD StatisticGoodsProduced(DWORD player);
        DWORD StatisticLandOwnedByPlayer(DWORD player);
        DWORD StatisticManaCollected(DWORD player);
        DWORD StatisticMushroomFarmsDestroyed(DWORD player);
        DWORD StatisticServantsFreed(DWORD player);
        DWORD StatisticSpellsCast(DWORD player);
        DWORD StatisticUnitsDestroyed(DWORD player);
        BOOL ClearMarker();
        BOOL DeleteWorldCursor();
        BOOL PressButton(DWORD dialog, DWORD control);
        BOOL RevealWorldMap(BOOL enable);
        BOOL SelectNextBuilding(BuildingType building);
        BOOL SetMarker(int x, int y);
        BOOL SetWorldCursor(int x, int y);
        BOOL SetZoom(int zoom);
        DWORD VehiclesAdd(VehicleType vehicle, DWORD direction, DWORD ammo, DWORD commands, int x, int y, DWORD player);
        BOOL VehiclesAddWheelerToFerry(DWORD ferry, VehicleType vehicle);
        DWORD VehiclesAmount(VehicleType vehicle, DWORD player);
        DWORD VehiclesAmountInArea(VehicleType vehicle, int x, int y, int r, DWORD player);
        DWORD VehiclesGetFerryCargoInArea(int x, int y, int r, DWORD player);
        DWORD VehiclesGetHealth(int x, int y);
        BOOL VehiclesIsSelected(VehicleType vehicle, int amount);
        BOOL VehiclesKill(VehicleType vehicle, int x, int y, int r, DWORD player);
        BOOL SetGround(int x, int y, int r, DWORD ground);
        BOOL ShowTextMessage([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPStr)] string message, DWORD icon, DWORD reserved);
        BOOL SoundPlay(SoundType sound, void* reserved, void* reserved2);
    }
}