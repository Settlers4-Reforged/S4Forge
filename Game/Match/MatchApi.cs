using AutomaticInterface;

using Forge.Native;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forge.Game.Match {
    [GenerateAutomaticInterface]
    internal class MatchApi : IMatchApi {
        private readonly IGameValues gameValues;

        public MatchApi(IGameValues gameValues) {
            this.gameValues = gameValues;
        }

        public bool InGame => gameValues.ReadValue(0xD69220, @default: 0) != 0;
        public bool Paused => gameValues.ReadValue(0x1064385, @default: 0) != 0;

        public int GameTime => gameValues.ReadValue(0xE66B14, @default: 0);
        public int Tick => 0; //TODO

        public int Difficulty => gameValues.ReadValue(0xE987EC, @default: 0);
    }
}
