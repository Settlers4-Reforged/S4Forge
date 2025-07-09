using AutomaticInterface;

using DryIoc;

using Forge.Config;
using Forge.Native;
using Forge.S4.Types;

using System;
using System.Collections.Generic;
using System.Text;

namespace Forge.S4.Game {

    [GenerateAutomaticInterface]
    internal sealed class PlayerApi : IPlayerApi {
        /// <summary>
        /// Returns the current number of players in the active game.
        /// </summary>
        public uint GetNumberOfPlayers() {
            return ModAPI.API.GetNumberOfPlayers();
        }

        /// <summary>
        /// Returns a reference to the player with the specified ID.
        /// </summary>
        /// <param name="id">Should be between 0 and GetNumberOfPlayers()</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public IPlayer GetPlayer(uint id) {
            if (id >= GetNumberOfPlayers()) {
                throw new ArgumentOutOfRangeException(nameof(id), id, "Player ID out of range");
            }

            return DI.Dependencies.Resolve<IPlayer>(serviceKey: id);
        }

        /// <summary>
        /// Gets the local player, which is the player that is currently running the game.
        /// </summary>
        /// <returns></returns>
        public IPlayer GetLocalPlayer() {
            return GetPlayer(GetLocalPlayerId());
        }

        /// <summary>
        /// Gets the ID of the local player.
        /// </summary>
        /// <returns></returns>
        public uint GetLocalPlayerId() {
            return ModAPI.API.GetLocalPlayer();
        }
    }
}
