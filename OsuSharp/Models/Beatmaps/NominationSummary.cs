﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuSharp.Models.Beatmaps;

/// <summary>
/// Represents the nomination progress of a beatmapset.
/// <br/><br/>
/// API docs: <a href="https://osu.ppy.sh/docs/index.html#beatmapsetextended"/><br/>
/// Source: <a href="https://github.com/ppy/osu-web/blob/master/resources/js/interfaces/beatmapset-extended-json.ts"/>
/// </summary>
public class NominationSummary
{
    /// <summary>
    /// The amount of nominations this beatmapset currently has.
    /// </summary>
    [JsonProperty("current")]
    public int Current { get; private set; }

    /// <summary>
    /// The amount nominations the beatmapset requires to be qualified for ranking.
    /// </summary>
    [JsonProperty("required")]
    public int Required { get; private set; }
}
