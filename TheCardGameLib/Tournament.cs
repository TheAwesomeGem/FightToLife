using System.Collections.Generic;

namespace TheCardGameLib
{
    public interface Tournament
    {
        public List<Match> Matches { get; }
    }
}