using DryIoc;

using Forge.Game.Config;
using Forge.Game.Core;
using Forge.Game.Events;
using Forge.Game.Match;
using Forge.Game.World;
using Forge.Game.World.Entities;
using Forge.Native;
using Forge.S4.Types;

using System;
using System.Collections.Generic;
using System.Text;

namespace Forge.Config {
    internal class ApiManager(
#pragma warning disable CS9113 // Parameter is unread.
        IEntityApi EntityApi,
        IEventApi EventApi,
        IGfxEngineApi GfxEngineApi,
        IPlayerApi PlayerApi,
        ISoundApi SoundApi,
        IConfigApi ConfigApi) {
#pragma warning restore CS9113 // Parameter is unread.

        public static void ResolveDependencies() {
            DI.Dependencies.Register<ApiManager>(Reuse.Singleton);
            DI.Resolve<ApiManager>();
        }

        public static void RegisterDependencies() {
            DI.Dependencies.Register<IEntityApi, EntityApi>(Reuse.Singleton);
            DI.Dependencies.Register<IMatchApi, MatchApi>(Reuse.Singleton);
            DI.Dependencies.Register<IEventApi, EventApi>(Reuse.Singleton);
            DI.Dependencies.Register<IEffectsApi, EffectsApi>(Reuse.Singleton);
            DI.Dependencies.Register<IGfxEngineApi, GfxEngineApi>(Reuse.Singleton);
            DI.Dependencies.Register<IPlayerApi, PlayerApi>(Reuse.Singleton);
            DI.Dependencies.Register<ISoundApi, SoundApi>(Reuse.Singleton);
            DI.Dependencies.Register<IConfigApi, ConfigApi>(Reuse.Singleton);

            DI.Dependencies.Register<IMap, Map>();
        }
    }
}
