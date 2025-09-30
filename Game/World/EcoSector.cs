using AutomaticInterface;

using Forge.Config;
using Forge.Game.Core;
using Forge.Native;
using Forge.S4.Game;
using Forge.S4.Types;

namespace Forge.Game.World {

    [GenerateAutomaticInterface]
    internal class EcoSector(uint id) : IEcoSector {
        private IS4ModApi modApi = DI.Resolve<IS4ModApi>();

        //TODO: maybe cache eco sector objects

        public uint Id { get; protected set; } = id;

        public IPlayer Owner => DI.Resolve<IPlayerApi>().GetPlayer(0);// TODO: fetch "owner" of EcoSector

        public bool ChangeGoodDistribution(GoodType good, BuildingType building, float percent) {
            //TODO: fetch "owner" of EcoSector to set as player id
            return modApi.ChangeGoodDistribution(good, building, (int)(percent * 100), Id, Owner.Id);
        }

        public bool ChangeGoodPriority(GoodType good, int priority) {
            //TODO: fetch "owner" of EcoSector to set as player id
            return modApi.ChangeGoodPriority(good, priority, Id, Owner.Id);
        }
    }
}
