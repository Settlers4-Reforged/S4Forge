using AutomaticInterface;

using Forge.Config;
using Forge.Game.Config;
using Forge.Game.Config.Native;
using Forge.Game.World.Native;
using Forge.Native;
using Forge.S4.Game;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forge.Game.Core {

    [GenerateAutomaticInterface]
    internal unsafe sealed class SoundApi : ISoundApi {
        IGameValues gameValues;
        IConfigApi configApi;
        CSoundEngine* soundEngine => gameValues.ReadReference<CSoundEngine>(0x10540C4);

        CConfigVarInt* MusicEnabledConfig;
        CConfigVarInt* SoundEnabledConfig;

        CConfigVarInt* MusicVolumeConfig;
        CConfigVarInt* SoundVolumeConfig;

        public SoundApi(IGameValues gameValues, IConfigApi configApi) {
            this.gameValues = gameValues;
            this.configApi = configApi;

            MusicEnabledConfig = configApi.GetConfigByName<CConfigVarInt>("GAMESETTINGS", "MusicEnabled");
            SoundEnabledConfig = configApi.GetConfigByName<CConfigVarInt>("GAMESETTINGS", "SoundFXEnabled");

            MusicVolumeConfig = configApi.GetConfigByName<CConfigVarInt>("GAMESETTINGS", "MusicVolume");
            SoundVolumeConfig = configApi.GetConfigByName<CConfigVarInt>("GAMESETTINGS", "SoundFXVolume");
        }

        /// <summary>
        /// Play a sound from the game's sound library.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="volume">A value between 0 and 100</param>
        /// <param name="panning">A value between -1 and 1, where 0 is center, -1 left and </param>
        public void PlaySound(int id, int volume = 100, float panning = 0) {
            // Panning seems to be from 0 to 127, with 64 being center
            int nativePanning = (int)((panning + 1) * 64);
            nativePanning = Math.Clamp(nativePanning, 0, 127);

            unsafe {

                var PlaySoundFuncPtr = gameValues.AddressAsPointer<nint>(0x10C390);
                ((delegate* unmanaged[Thiscall]<CSoundEngine*, uint/* id*/, int /*volume*/, int /*panning*/, CSoundEngine* /*unused*/, char /*invokeCallback*/, int>)PlaySoundFuncPtr)(soundEngine, (uint)id, volume, nativePanning, soundEngine, (char)0);
            }
        }

        /// <summary>
        /// Whether music is enabled.
        /// </summary>
        public bool MusicEnabled => MusicEnabledConfig->GetInt() != 0;
        /// <summary>
        /// Whether sound effects are enabled.
        /// </summary>
        public bool SoundEnabled => SoundEnabledConfig->GetInt() != 0;

        /// <summary>
        /// The music volume, from 0 to 100. If set to 0, music is disabled.
        /// </summary>
        public int MusicVolume {
            get => MusicEnabled ? 0 : MusicVolumeConfig->GetInt();
            set {
                MusicEnabledConfig->SetIntValue(value == 0 ? 0 : 1);
                MusicVolumeConfig->SetIntValue(value);

                //SetMusicVolume(this, volume)
                ((delegate* unmanaged[Thiscall]<CSoundEngine*, int, void>)gameValues.AddressAsPointer<nint>(0x10C4A0))(soundEngine, value);
            }
        }

        /// <summary>
        /// The sound (effects like chirping, etc.) volume, from 0 to 100. If set to 0, sound is disabled.
        /// </summary>
        public int SoundVolume {
            get => SoundEnabled ? 0 : SoundVolumeConfig->GetInt();
            set {
                SoundEnabledConfig->SetIntValue(value == 0 ? 0 : 1);
                SoundVolumeConfig->SetIntValue(value);

                //SetSoundVolume(this, volume)
                ((delegate* unmanaged[Thiscall]<CSoundEngine*, int, void>)gameValues.AddressAsPointer<nint>(0x10C500))(soundEngine, value);
            }
        }
    }
}

/*


void *GetCurrentSoundInfo() {
	return *reinterpret_cast<void**>(S4_Main + 0x10540C4);
}

int S4Hook::GetMusicVolume() {
	return *MusicVolume;
}

void S4Hook::SetMusicVolume(int volume) {
	DWORD S4SetMusicVol = S4_Main + 0x10C4A0;
	void* SoundInfo = GetCurrentSoundInfo();

	*MusicVolume = volume;

	if(*MusicToggle == 0)
		volume = 0;

	__asm {
		mov ecx, SoundInfo
		push volume
		call S4SetMusicVol
	}
}

int S4Hook::GetMusicEnabled() {
	return *MusicToggle;
}

void S4Hook::ToggleMusic(bool enabled) {
	*MusicToggle = enabled;
	SetMusicVolume(*MusicVolume);
}

int S4Hook::GetSoundVolume() {
	return *SoundVolume;
}

void S4Hook::SetSoundVolume(int volume) {
	DWORD S4SetSoundVol = S4_Main + 0x10C500;
	void* SoundInfo = GetCurrentSoundInfo();

	*SoundVolume = volume;

	if (*SoundToggle == 0)
		volume = 0;

	__asm {
		mov ecx, SoundInfo
		push volume
		call S4SetSoundVol
	}
}

int S4Hook::GetSoundEnabled() {
	return *SoundToggle;
}

void S4Hook::ToggleSound(bool enabled) {
	*SoundToggle = enabled;
	SetSoundVolume(*SoundVolume);
}

void S4Hook::PlaySound(int id) {
	DWORD GlobalMusic = *(DWORD*)(S4_Main + 0x10540C4);

	__asm {
		mov esi, 0
		mov ecx, GlobalMusic
		push 0
		push GlobalMusic
		push dword ptr [ecx]
		push 0x64
		push id
		call PlayS4Sound
	}
}
*/