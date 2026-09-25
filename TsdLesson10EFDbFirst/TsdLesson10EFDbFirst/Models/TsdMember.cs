using System;
using System.Collections.Generic;

namespace TsdLesson10EFDbFirst.Models;

public partial class TsdMember
{
    public long Id { get; set; }

    public string? TsdUserName { get; set; }

    public string? TsdPassword { get; set; }

    public string? TsdFullName { get; set; }

    public string? TsdEmail { get; set; }

    public string? TsdPhone { get; set; }

    public bool? TsdStatus { get; set; }
}
