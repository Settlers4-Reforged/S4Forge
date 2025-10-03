# S4Forge - A Modding API for Settlers 4
S4Forge is a modding API for Settlers 4.
It allows you to create mods (here called modules) for Settlers 4 in .Net.
This includes, but is not limited to:
- Native access to game values and pointers
- Abstracted managed interfaces to interact with the game state
- Automated update checking and mod management
- Custom user interfaces (via a [UX-Engine](https://github.com/Settlers4-Reforged/S4Forge.UX-Engine))

## S4Forge Engines
S4Forge Engines are independent parts of S4Forge that can be used to further interact with Settlers 4.
They are not required to use S4Forge, but they can be used to simplify certain tasks.

To use a S4Forge Engine, add a reference to the corresponding NuGet package.

- [UX-Engine](https://github.com/Settlers4-Reforged/S4Forge.UX-Engine): The UX-Engine allows you to control anything thats related to the user interface of Settlers 4. This includes creating custom UI, playing sounds, modifying the games UI, etc..
- [Multiplayer-Engine]() (Coming soon): A wrapper around the multiplayer API of Settlers 4. Allows for custom network events and more. Also handles UPlay integrations.

## NuGet
S4Forge and all of its engines are available as a NuGet packages!

tldr: add the following to your `.csproj` file:
```xml
<ItemGroup>
    <PackageReference Include="S4Forge" Version="VERSION" />
</ItemGroup>
```
> Remember to replace `VERSION` with the latest version!

or search for S4Forge in the NuGet package manager.

## How to use
### Creating a mod for Settlers 4 with S4Forge
In the world of S4Forge, there are modules (`IModule`) and plugins (`IPlugin`).
A module is the entrypoint of your mod. It is responsible for initializing your mod and registering your plugins.
The module itself should not contain any mod logic, but rather just be a bootstrapper for your mod.
A plugin is where the actual mod logic goes. You can have multiple plugins per module.
Plugins are can derive from various plugin interfaces, provided by S4Forge and it's engines.
They serve then a specific purpose, for example:
- `IPluginMap`: A plugin that is called when a map is loaded, or other map-related events happen
- `IPluginScene`: A plugin that provides methods for assisted UI creation

Let's say you create a mod for a tourament, that changes various parts of the game to facilitate some custom rules.
You would create a new class library project, add a reference to the S4Forge NuGet package and create a class that implements `IModule`:
```csharp
using Forge.Engine;

public class CustomTournament : IModule {
    public string Name => "Custom Tournament Mod";

    public void Initialize(Container injector) {
        injector.Register<IPluginMap, TournamentMapPlugin>(Reuse.Singleton);
    }
}
```

This module registers a plugin that implements `IPluginMap`:
```csharp
using Forge.Engine;

public class TournamentMapPlugin : IPluginMap {
    public void OnMapLoaded(IMap map) {
        // Modify the map to fit the tournament rules
    }
}

```


## Interacting with the various S4Forge components
Most of the APIs are provided with the dependency injection system (DI).
This project uses DryIoc exposed via the `Forge.Config.DI` static class.
It's encouraged to register your own classes and dependencies in the DI system, for easy testing and also for enabling other mods to use your components.

You can register your own classes for example like this:
```csharp
Forge.Config.DI.Dependencies.Register<IMyInterface, MyClass>(Reuse.Singleton);
```
It's recommended to read the [DryIoc documentation](https://github.com/dadhi/DryIoc/blob/master/docs/DryIoc.Docs/Home.md)

This DI system can then be used to resolve dependencies in your classes like either of these methods:
```csharp
using Forge.Config;
using Forge.Game.World;

public class MyMod {
    private readonly IPlayerApi game;
    public MyMod(IPlayerApi playerApi) { // Access via constructor injection
        this.playerApi = playerApi;

        var map = DI.Resolve<IMapApi>(); // Access via static DI resolver
    }
}
```

## Components of S4Forge
S4Forge is split into different sections that handle different parts of the modding API.

- `Forge.Logging`: A centralized logging API.
- `Forge.Game`: The API for accessing, modifying and interacting with Settlers 4
- `Forge.I18n`: A collection of helper classes for handling different languages - especially useful for UI mods
- `Forge.Native`: Various helper classes for interacting with the native game code (pointers, patching, windows API)
- `Forge.External`: The S4 C++ definition files, that generate the managed bindings for `Forge.Native`

## License
S4Forge is licensed under GNU General Public License v3.0.
