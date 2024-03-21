﻿using System.ComponentModel;

namespace OsuSharp.Enums;

/// <summary>
/// An enum representing the type of a beatmapset discussion.
/// <br/><br/>
/// API docs: <a href="https://osu.ppy.sh/docs/index.html#messagetype"/><br/>
/// Source: <a href="https://github.com/ppy/osu-web/blob/master/resources/js/beatmap-discussions/discussion-type.ts"/>
/// </summary>
public enum DiscussionType
{
  /// <summary>
  /// Represents a hype on the beatmapset.
  /// </summary>
  [Description("hype")]
  Hype,

  /// <summary>
  /// Represents a note by the mapper.
  /// </summary>
  [Description("note")]
  MapperNote,

  /// <summary>
  /// Represents a praise for the beatmap(set).
  /// </summary>
  [Description("praise")]
  Praise,

  /// <summary>
  /// Represents a problem that was found on the beatmap(set).
  /// </summary>
  [Description("problem")]
  Problem,

  /// <summary>
  /// Represents a review for the beatmap(set).
  /// </summary>
  [Description("review")]
  Review,

  /// <summary>
  /// Represents a suggestion for the beatmap(set).
  /// </summary>
  [Description("suggestion")]
  Suggestion
}
