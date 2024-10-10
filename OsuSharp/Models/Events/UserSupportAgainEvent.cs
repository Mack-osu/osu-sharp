﻿using Newtonsoft.Json;

namespace OsuSharp.Models.Events;

/// <summary>
/// Represents an event when a user supports osu! for the second time and onwards.
/// <br/><br/>
/// API docs: <a href="https://osu.ppy.sh/docs/index.html#event-type"/><br/>
/// Source: <a href="https://github.com/ppy/osu-web/blob/master/resources/js/interfaces/event-json.ts"/>
/// </summary>
public class UserSupportAgainEvent : Event
{
  /// <summary>
  /// The user who supported osu!.
  /// </summary>
  [JsonProperty("user")]
  public EventUser User { get; private set; } = default!;
}
