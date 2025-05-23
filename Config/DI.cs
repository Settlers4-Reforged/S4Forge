﻿using DryIoc;

using Forge.Notifications;
using Forge.S4.Callbacks;
using Forge.S4.Managers;

using System;
using System.Collections.Generic;
using System.Text;

namespace Forge.Config {
    public static class DI {
        public static Container Dependencies { get; private set; } = new Container(rules => rules.WithFuncAndLazyWithoutRegistration());

        public static T Resolve<T>() {
            // This helper method skips the need for a "using DryIoc;" statement in every file that uses this DI method
            return Dependencies.Resolve<T>();
        }

        static DI() {
        }

        /// <summary>
        /// Reset the DI container. This is *only* for testing purposes!
        /// <br/>
        /// <b>Using this in production code will break Forge.</b>
        /// </summary>
        public static void Reset() {
            Dependencies.Dispose();
            Dependencies = new Container(rules => rules.WithFuncAndLazyWithoutRegistration());
        }

        public static void RegisterDefaultDependencies(S4Forge forge) {
            Dependencies.RegisterInstanceMany(forge);
            Dependencies.Register<ICallbacks, Callbacks>(Reuse.Singleton);
            ApiManager.RegisterDependencies();
            NotificationsService.RegisterDependencies();
        }
    }
}
