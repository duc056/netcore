using System;
using System.Collections.Generic;

namespace Tsd2410900028_exam.Models;

public partial class TsdStudent
{
    public int Id { get; set; }

    public string TsdName { get; set; } = null!;

    public bool TsdGender { get; set; }

    public DateOnly? TsdBirthDay { get; set; }

    public string? TsdEmail { get; set; }

    public string? TsdPhone { get; set; }

    public bool TsdActive { get; set; }
}
