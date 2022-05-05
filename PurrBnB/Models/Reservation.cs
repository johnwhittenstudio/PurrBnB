using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PurrBnB.Models
{
  public class Reservation
  {
    public Reservation()
    {
      this.JoinEntities2 = new HashSet<DwellingReservation>();
    }

    public int ReservationId { get; set; }
    public string ReservationName { get; set; }

    public int TotalNights { get; set; }
    public int DwellingId { get; set; }

    public virtual ApplicationUser ApplicationUser {get; set; } 
    public virtual ICollection<DwellingReservation> JoinEntities2 {get; set; } 

  }
}