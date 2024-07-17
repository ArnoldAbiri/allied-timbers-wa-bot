﻿using System;

namespace AlliedTimbers.Models;

public class Promotion
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; } = DateTime.Now.Date;
    public DateTime EndDate { get; set; }
}