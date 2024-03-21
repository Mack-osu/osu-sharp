﻿using Newtonsoft.Json;
using OsuSharp.Enums;

namespace OsuSharp.Models.Users;

/// <summary>
/// Represents a group the user is in.
/// <br/><br/>
/// API docs: <a href="https://osu.ppy.sh/docs/index.html#usergroup"/><br/>
/// Source: <a href="https://github.com/ppy/osu-web/blob/master/resources/js/interfaces/user-group-json.ts"/>
/// </summary>
public class Group
{
  /// <summary>
  /// The hex colour of this group.
  /// </summary>
  [JsonProperty("colour")]
  public string? Colour { get; private set; }

  /// <summary>
  /// The description of this group.
  /// </summary>
  [JsonProperty("description")]
  public GroupDescription? Description { get; private set; }

  /// <summary>
  /// TODO: what is this?
  /// </summary>
  [JsonProperty("has_listing")]
  public bool HasListing { get; private set; }

  /// <summary>
  /// TODO: what is this?
  /// </summary>
  [JsonProperty("has_playmodes")]
  public bool HasPlaymodes { get; private set; }

  /// <summary>
  /// The ID of this group.
  /// </summary>
  [JsonProperty("id")]
  public int Id { get; private set; }

  /// <summary>
  /// The unique identifier of this group.
  /// </summary>
  [JsonProperty("identifier")]
  public string Identifier { get; private set; } = default!;

  /// <summary>
  /// Bool whether this group is a probationary group (e.g. probationary beatmap nominators).
  /// </summary>
  [JsonProperty("is_probationary")]
  public bool IsProbationary { get; private set; }

  /// <summary>
  /// The name of this group.
  /// </summary>
  [JsonProperty("name")]
  public string Name { get; private set; } = default!;

  /// <summary>
  /// The short name of this group.
  /// </summary>
  [JsonProperty("short_name")]
  public string ShortName { get; private set; } = default!;

  /// <summary>
  /// The rulesets this group is specific to.
  /// </summary>
  [JsonProperty("playmodes")]
  public Ruleset[] PlayModes { get; private set; } = default!;
}
