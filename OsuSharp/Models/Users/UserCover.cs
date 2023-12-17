﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuSharp.Models.Users;

/// <summary>
/// Represents the cover of a user.
/// <br/><br/>
/// API docs: Not documented, refer to source<br/>
/// Source: <a href="https://github.com/ppy/osu-web/blob/master/resources/js/interfaces/user-cover-json.ts"/>
/// </summary>
public class UserCover
{
  /// <summary>
  /// TODO: what is the difference to normal url?
  /// </summary>
  [JsonProperty("custom_url")]
  public string? CustomUrl { get; private set; }

  /// <summary>
  /// TODO: what is this? The Id of one of the preset covers?
  /// </summary>
  [JsonProperty("id")]
  public string? Id { get; private set; }

  /// <summary>
  /// The URL to the cover image.
  /// </summary>
  [JsonProperty("url")]
  public string Url { get; private set; } = default!;
}
