using System;
using System.Collections.Generic;

namespace Threads.DataTier.Models;

public partial class Post
{
    public int PostId { get; set; }

    public int? UserId { get; set; }

    public string? Content { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Like> Likes { get; set; } = new List<Like>();

    public virtual ICollection<Medium> Media { get; set; } = new List<Medium>();

    public virtual ICollection<Repost> Reposts { get; set; } = new List<Repost>();

    public virtual ICollection<Savedpost> Savedposts { get; set; } = new List<Savedpost>();

    public virtual User? User { get; set; }
}
