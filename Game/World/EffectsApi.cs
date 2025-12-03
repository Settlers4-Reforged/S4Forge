using AutomaticInterface;

using Forge.Game.World.Native;
using Forge.Native;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forge.Game.World {
    [GenerateAutomaticInterface]
    internal class EffectsApi : IEffectsApi {
        private IGameValues gameValues;

        public EffectsApi(IGameValues gameValues) {
            this.gameValues = gameValues;
        }

        public void AddEffect(uint effectId, uint soundId, uint x, uint y, uint durationTicks, int delay = 0, byte effectType = 0, bool globalSound = false) {
            unsafe {
                CLogic* logic = gameValues.ReadReference<CLogic>(0x10540D0);
                CEffects* effects = logic->Effects;
                effects->AddEffect((int)effectId, (int)soundId, (int)x, (int)y, delay, (int)durationTicks, effectType);
            }
        }
    }
}
