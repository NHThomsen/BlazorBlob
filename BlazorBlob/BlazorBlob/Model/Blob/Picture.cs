﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorBlob;

public partial class Picture
{
    [Key]
    public int Id { get; set; }

    [Required]
    [Column("Picture")]
    public byte[] Picture1 { get; set; }
}