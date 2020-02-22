using System.Collections.Generic;
using System.Collections.Immutable;

namespace TheCardGameLib
{
    public interface CommandFactory
    {
        IImmutableDictionary<string, GameCommand> GameCommands { get; }
    }
}