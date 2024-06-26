﻿using System.ComponentModel.DataAnnotations;
using static Caregiver.Enums.Enums;

namespace Caregiver.Models
{
	public class CaregiverUser : User
	{
		public string Bio { get; set; } = string.Empty;

		public string Country { get; set; } = string.Empty;


		public string City { get; set; }

		public string CareerLevel { get; set; }
		public int YearsOfExperience { get; set; }

		public string JobTitle { get; set; }

		public string JobLocationLookingFor { get; set; }

		public int PricePerDay { get; set; }

		public byte[] Resume { get; set; }
        public byte[] Photo { get; set; }


        public byte[] CriminalRecords { get; set; }

		public bool IsAccepted { get; set; } = false;
		public bool IsFormCompleted { get; set; } = false;


		public ICollection<CaregiverPatientReservation> Reservations { get; set; } = null;
	}
}
