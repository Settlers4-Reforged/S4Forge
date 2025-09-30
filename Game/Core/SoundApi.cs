using AutomaticInterface;

using Forge.Config;
using Forge.Native;
using Forge.S4.Game;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forge.Game.Core {

    [GenerateAutomaticInterface]
    internal sealed class SoundApi : ISoundApi {
        IS4ModApi modApi;

        public SoundApi(IS4ModApi modApi) {
            this.modApi = modApi;
        }

        public void PlaySound(int id) {
            modApi.PlaySound(id);
        }

        /// <summary>
        /// The music volume, from 0 to 100. If set to 0, music is disabled.
        /// </summary>
        public int MusicVolume {
            get => modApi.GetMusicEnabled() == 0 ? 0 : modApi.GetMusicVolume();
            set {
                if (value == 0) {
                    modApi.ToggleMusic(false);
                } else {
                    modApi.ToggleMusic(false);
                    modApi.SetMusicVolume(value);
                }
            }
        }

        /// <summary>
        /// The sound (effects like chirping, etc.) volume, from 0 to 100. If set to 0, sound is disabled.
        /// </summary>
        public int SoundVolume {
            get => modApi.GetSoundEnabled() == 0 ? 0 : modApi.GetSoundVolume();
            set {
                if (value == 0) {
                    modApi.ToggleSound(false);
                } else {
                    modApi.ToggleSound(false);
                    modApi.SetSoundVolume(value);
                }
            }
        }
    }
}
