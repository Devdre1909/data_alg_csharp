using System;

namespace GameMap
{
  public static class TerrainEnumExtension
  {
    public static ConsoleColor GetColor(this TerrainEnum terrain)
    {
      switch (terrain)
      {
        case TerrainEnum.GRASS: return ConsoleColor.Green;
        case TerrainEnum.SAND: return ConsoleColor.Yellow;
        case TerrainEnum.WATER: return ConsoleColor.Blue;
        case TerrainEnum.WALL: return ConsoleColor.DarkGray;
        default: return ConsoleColor.DarkGray;
      }
    }

    public static char GetChar(this TerrainEnum terrain)
    {
      switch (terrain)
      {
        case TerrainEnum.GRASS: return '\u201c';
        case TerrainEnum.SAND: return '\u25cb';
        case TerrainEnum.WATER: return '\u2248';
        default: return '\u25cf';
      }
    }

  }

}