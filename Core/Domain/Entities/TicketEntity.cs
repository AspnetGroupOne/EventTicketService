﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Domain.Entities;

[Table("Tickets")]
public class TicketEntity
{
    [Key]
    public int TicketId { get; set; }

    public string EventId { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public string InvoiceId { get; set; } = null!;
    public string TicketCategory { get; set; } = null!;
    public string SeatNumber { get; set; } = null!;
    public int Gate { get; set; }
}
