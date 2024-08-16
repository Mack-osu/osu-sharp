﻿using Newtonsoft.Json;
using OsuSharp.Converters;
using OsuSharp.Enums;

namespace OsuSharp.Models.Users;

/// <summary>
/// Represents the statistics of a user.
/// <br/><br/>
/// API docs: <a href="https://osu.ppy.sh/docs/index.html#userstatistics"/><br/>
/// Source: <a href="https://github.com/ppy/osu-web/blob/master/resources/js/interfaces/user-statistics-json.ts"/>
/// </summary>
public class UserStatistics
{
  /// <summary>
  /// The amount of total 100 hit judgements the user has.
  /// </summary>
  [JsonProperty("count100")]
  public int Count100 { get; private set; }

  /// <summary>
  /// The amount of total 300 hit judgements the user has.
  /// </summary>
  [JsonProperty("count300")]
  public int Count300 { get; private set; }

  /// <summary>
  /// The amount of total 50 hit judgements the user has.
  /// </summary>
  [JsonProperty("count50")]
  public int Count50 { get; private set; }

  /// <summary>
  /// The amount of total misses the user has.
  /// </summary>
  [JsonProperty("count_miss")]
  public int Misses { get; private set; }

  /// <summary>
  /// The country rank of the user. This may be null.
  /// </summary>
  [JsonProperty("country_rank")]
  public int? CountryRank { get; private set; }

  /// <summary>
  /// The global rank of the user. This may be null.
  /// </summary>
  [JsonProperty("global_rank")]
  public int? GlobalRank { get; private set; }

  /// <summary>
  /// TODO: what is this?
  /// </summary>
  [JsonProperty("global_rank_exp")]
  public int? GlobalRankExp { get; private set; }

  /// <summary>
  /// The amount of times the user achieved the XH, X, SH, S and A grades.
  /// TODO: ADD THIS BACK
  /// </summary>
  //[JsonProperty("grade_counts")]
  //public Dictionary<Grade, int> Grades { get; private set; } = default!;

  /// <summary>
  /// The overall accuracy of the user.
  /// </summary>
  [JsonProperty("hit_accuracy")]
  public float Accuracy { get; private set; }

  /// <summary>
  /// TODO: what is this? can user statistics be ranked and unranked?
  /// </summary>
  public bool IsRanked { get; private set; }

  /// <summary>
  /// The level of the user.
  /// </summary>
  [JsonProperty("level")]
  public Level Level { get; private set; } = default!;

  /// <summary>
  /// The highest combo the user has ever achieved.
  /// </summary>
  [JsonProperty("maximum_combo")]
  public int MaxCombo { get; private set; }

  /// <summary>
  /// The total playcount of the user.
  /// </summary>
  [JsonProperty("play_count")]
  public int PlayCount { get; private set; }

  /// <summary>
  /// The total playtime of the user, in seconds.
  /// </summary>
  [JsonProperty("play_time")]
  public int PlayTime { get; private set; }

  /// <summary>
  /// The total performance points the user has.
  /// </summary>
  [JsonProperty("pp")]
  public float PP { get; private set; }

  /// <summary>
  /// TODO: what is this?
  /// </summary>
  [JsonProperty("pp_exp")]
  public float PPExp { get; private set; }

  /// <summary>
  /// The total ranked score the user has.
  /// </summary>
  [JsonProperty("ranked_score")]
  public long RankedScore { get; private set; }

  /// <summary>
  /// The total score the user has.
  /// </summary>
  [JsonProperty("total_score")]
  public long TotalScore { get; private set; }
}
