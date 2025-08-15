using AutomaticInterface;

using Forge.Config;
using Forge.S4.Game;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Forge.Game.Core {

    [GenerateAutomaticInterface]
    internal sealed class GfxEngineApi : IGfxEngineApi {
        public GfxEngineApi() {

        }

        Vector2 ConvertMapPositionToWorldScreenOffsets(Vector2 mapPosition) {
            throw new NotImplementedException();
        }
    }
}
