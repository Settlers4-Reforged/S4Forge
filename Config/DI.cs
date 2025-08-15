using DryIoc;

using Forge.Game.Core;
using Forge.Notifications;

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
    }
}
