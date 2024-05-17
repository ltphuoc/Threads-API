using System;
using System.Collections.Generic;

namespace Threads.DataTier.Models;

public partial class Follow
{
    public int FollowId { get; set; }

    public int? FollowerId { get; set; }

    public int? FolloweeId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual User? Followee { get; set; }

    public virtual User? Follower { get; set; }
}
