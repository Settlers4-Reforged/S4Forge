using AutomaticInterface;

using Forge.Config;
using Forge.Game.Events.Native;
using Forge.Native;
using Forge.S4.Game;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forge.Game.Events {

    [GenerateAutomaticInterface]
    internal sealed class EventApi : IEventApi {
        readonly IS4ModApi modApi;
        readonly IGameValues gameValues;

        public EventApi(IS4ModApi modApi, IGameValues gameValues) {
            this.modApi = modApi;
            this.gameValues = gameValues;
        }

        private unsafe void* EventManager => (void*)gameValues.ReadValue<int>(0x106B11C);

        public void SendEvent(EventType type, uint wparam, uint lparam, sbyte unknown) {
            unsafe {
                CEvent newEvent;
                CEvent* s4event = modApi.CreateS4Event(&newEvent, (uint)type, wparam, lparam, unknown);
                modApi.PostToMessageQueue(EventManager, s4event);
            }
        }
    }
}
