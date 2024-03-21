﻿namespace OsuSharp.Models.Beatmaps;

/// <summary>
/// Represents the genre of a beatmapset.
/// <br/><br/>
/// API docs: <a href="https://osu.ppy.sh/docs/index.html#beatmapset"/><br/>
/// Source: <a href="https://github.com/ppy/osu-web/blob/master/resources/js/interfaces/genre-json.ts"/>
/// </summary>
public class Genre
{
  /// <summary>
  /// The ID of this genre. This may be null.
  /// </summary>
  public int? Id { get; internal set; }

  /// <summary>
  /// The name of this genre.
  /// </summary>
  public string Name { get; internal set; } = default!;
}
