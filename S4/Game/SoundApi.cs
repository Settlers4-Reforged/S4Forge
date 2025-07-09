using AutomaticInterface;

using Forge.Config;
using Forge.Native;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forge.S4.Game {

    [GenerateAutomaticInterface]
    internal sealed class SoundApi : ISoundApi {
        public void PlaySound(int id) {
            ModAPI.API.PlaySound(id);
        }

        /// <summary>
        /// The music volume, from 0 to 100. If set to 0, music is disabled.
        /// </summary>
        public int MusicVolume {
            get => ModAPI.API.GetMusicEnabled() == 0 ? 0 : ModAPI.API.GetMusicVolume();
            set {
                if (value == 0) {
                    ModAPI.API.ToggleMusic(false);
                } else {
                    ModAPI.API.ToggleMusic(false);
                    ModAPI.API.SetMusicVolume(value);
                }
            }
        }

        /// <summary>
        /// The sound (effects like chirping, etc.) volume, from 0 to 100. If set to 0, sound is disabled.
        /// </summary>
        public int SoundVolume {
            get => ModAPI.API.GetSoundEnabled() == 0 ? 0 : ModAPI.API.GetSoundVolume();
            set {
                if (value == 0) {
                    ModAPI.API.ToggleSound(false);
                } else {
                    ModAPI.API.ToggleSound(false);
                    ModAPI.API.SetSoundVolume(value);
                }
            }
        }
    }
}
