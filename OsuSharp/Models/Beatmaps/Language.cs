﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuSharp.Models.Beatmaps;

/// <summary>
/// Represents the language of a beatmapset.
/// <br/><br/>
/// API docs: <a href="https://osu.ppy.sh/docs/index.html#beatmapset"/><br/>
/// Source: <a href="https://github.com/ppy/osu-web/blob/master/resources/js/interfaces/language-json.ts"/>
/// </summary>
public class Language
{
  /// <summary>
  /// The ID of this language. This may be null.
  /// </summary>
  public int? Id { get; internal set; }

  /// <summary>
  /// The name of this language.
  /// </summary>
  public string Name { get; internal set; } = default!;
}
