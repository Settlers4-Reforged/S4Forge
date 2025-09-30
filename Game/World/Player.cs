using AutomaticInterface;

using DryIoc;

using Forge.Config;
using Forge.Game.Core;
using Forge.Native;
using Forge.S4.Game;

using System;
using System.Collections.Generic;
using System.Text;

namespace Forge.S4.Types {

    public partial interface IPlayer { }

    [GenerateAutomaticInterface]
    internal sealed class Player : IPlayer {
        private const int PlayerCount = 8;
        private readonly IS4ModApi modApi = DI.Resolve<IS4ModApi>();

        internal static void RegisterPlayers() {
            for (uint i = 0; i < PlayerCount; i++) {
                uint id = i;
                DI.Dependencies.Register<IPlayer, Player>(serviceKey: i, made: Made.Of(() => new Player(id)));
            }
        }

        private Player(uint id) => Id = id;

        public uint Id { get; set; }

        public bool IsLocalPlayer => Id == modApi.GetLocalPlayer();

        // TODO: replace with direct memory access
        public int OffensiveFightingStrength => (int)modApi.GetOffenceFightingStrength(Id);

        public Tribe Tribe => (Tribe)modApi.GetPlayerTribe(Id);

        public bool HasLost => modApi.HasPlayerLost(Id);
    }
}
