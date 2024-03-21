﻿using Newtonsoft.Json;

namespace OsuSharp.Models.Users;

/// <summary>
/// Represents the highest rank of an osu! user with it's date.
/// <br/><br/>
/// API docs: <a href="https://osu.ppy.sh/docs/index.html#user-rankhighest"/><br/>
/// Source: <a href="https://github.com/ppy/osu-web/blob/master/resources/js/interfaces/rank-highest-json.ts"/>
/// </summary>
public class HighestRank
{
  /// <summary>
  /// The highest rank the user achieved.
  /// </summary>
  [JsonProperty("rank")]
  public int Rank { get; private set; }

  /// <summary>
  /// The datetime at which the user achieved the highest rank.
  /// </summary>
  [JsonProperty("updated_at")]
  public DateTimeOffset UpdatedAt { get; private set; }
}
