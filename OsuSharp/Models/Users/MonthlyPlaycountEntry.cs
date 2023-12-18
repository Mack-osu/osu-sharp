﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuSharp.Models.Users;

/// <summary>
/// Represents an entry in the monthly playcount of a user.
/// <br/><br/>
/// API docs: <a href="https://osu.ppy.sh/docs/index.html#usermonthlyplaycount"/><br/>
/// Source: <a href="https://github.com/ppy/osu-web/blob/master/resources/js/interfaces/user-monthly-playcount-json.ts"/>
/// </summary>
public class MonthlyPlaycountEntry
{
  /// <summary>
  /// The amount of plays this month.
  /// </summary>
  [JsonProperty("count")]
  public int Count { get; private set; }

  /// <summary>
  /// The datetime at which this month started.
  /// </summary>
  [JsonProperty("start_date")]
  public DateTimeOffset? StartDate { get; private set; }
}
