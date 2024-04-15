﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuSharp.Models.Forum;

/// <summary>
/// Represents a poll in a <see cref="ForumTopic"/>.
/// <br/><br/>
/// API docs: <a href="https://osu.ppy.sh/docs/index.html#forum-topic-poll"/>
/// Source: <a href="https://github.com/ppy/osu-web/blob/master/app/Transformers/Forum/PollTransformer.php"/>
/// </summary>
public class Poll
{
  /// <summary>
  /// Bool whether changing your vote is allowed.
  /// </summary>
  [JsonProperty("allow_vote_change")]
  public bool AllowVoteChange { get; private set; }

  /// <summary>
  /// The datetime at which the poll ended. This will be null if the poll has not ended yet.
  /// </summary>
  [JsonProperty("ended_at")]
  public DateTimeOffset? EndedAt { get; private set; }

  /// <summary>
  /// Bool whether the results of the poll are hidden until the poll ends.
  /// </summary>
  [JsonProperty("hide_incomplete_results")]
  public bool HideIncompleteResults { get; private set; }

  /// <summary>
  /// The datetime at which the poll was last voted on. This will be null if the poll has not been voted on.
  /// </summary>
  [JsonProperty("last_vote_at")]
  public DateTimeOffset? LastVoteAt { get; private set; }

  /// <summary>
  /// The amount of votes a single user can cast.
  /// </summary>
  [JsonProperty("max_votes")]
  public int MaxVotes { get; private set; }

  /// <summary>
  /// The options for this poll.
  /// </summary>
  [JsonProperty("options")]
  public PollOption[] Options { get; private set; } = default!;

  /// <summary>
  /// The datetime at which this poll started.
  /// </summary>
  [JsonProperty("started_at")]
  public DateTimeOffset StartedAt { get; private set; }

  /// <summary>
  /// The title of this poll.
  /// </summary>
  [JsonProperty("title")]
  public PollText Title { get; private set; } = default!;

  /// <summary>
  /// The total amount of votes this poll has received.
  /// </summary>
  [JsonProperty("total_vote_count")]
  public int TotalVotes { get; private set; }
}
