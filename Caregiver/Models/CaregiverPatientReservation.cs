﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
using static Caregiver.Enums.Enums;

namespace Caregiver.Models
{
	public class CaregiverPatientReservation
	{
		[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [ForeignKey("Caregiver")]
		public string CaregiverId { get; set; }
		public CaregiverUser Caregiver { get; set; }
		

		[ForeignKey("Patient")]
		public string PatientId { get; set; }
		public PatientUser Patient { get; set; }

		[Required]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        public ReservationStatus Status { get; set; }

		public int totalPrice { get; set; }



    }
}
