namespace Game.Core
{

  public enum LogLevel
  {
    DEBUG,

    INFO,

    WARNING,

    ERROR
  }
  #region Characters
  public enum ECharacterAnimation
  {
    idle_down,
    idle_up,
    idle_right,
    idle_left,
    turn_up,
    turn_right,
    turn_left,
    turn_down,
    walk_down,
    walk_up,
    walk_right,
    walk_left,

  }
  #endregion

  #region levels

  public enum LevelName
  {

    small_town,
    small_town_greens_house,
    small_town_purples_house,
    small_town_pokemon_center,
    small_town_cave,

  }

  public enum LevelGroup
  {
    SPAWNPOINTS,

    SCENETRIGGERS,
  }




  #endregion
}