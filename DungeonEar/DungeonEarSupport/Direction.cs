using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonEar {
    public enum Direction {

        North = 0,
        East = 1,
        South = 2,
        West = 3

    }

    public enum Action {

        MoveNorth,
        MoveEast,
        MoveSouth,
        MoveWest,


        Exit,
        Back,
        Unknown,
        Move
    }
}
