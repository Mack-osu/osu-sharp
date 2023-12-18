﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuSharp.Models.Users;

/// <summary>
/// Represents an achievement of a user.
/// <br/><br/>
/// API docs: Not documented, refer to source<br/>
/// Source: <a href="https://github.com/ppy/osu-web/blob/master/resources/js/interfaces/user-achievement-json.ts"/>
/// </summary>
public class Achievement
{
  /// <summary>
  /// The datetime at which this achievement was achieved.
  /// </summary>
  [JsonProperty("achieved_at")]
  public DateTimeOffset AchievedAt { get; private set; }

  /// <summary>
  /// The ID of the achievement.
  /// </summary>
  [JsonProperty("achievement_id")]
  public int AchievementId { get; private set; }
}
