using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Taller1.Models
{
	public class Customer
	{
		[Required]
		[MaxLength(length: 20, ErrorMessage = "Logintud maxima es de 20 caracteres")]
		public string FirstName { get; set; }
		[Required]
		[MaxLength(length: 20, ErrorMessage = "Logintud maxima es de 20 caracteres")]
		public string LastName { get; set; }
		[Required]
		[EmailAddress(ErrorMessage = "Formato no válido")]
		public string Email { get; set; }
		[Required]
		[DataType(DataType.PhoneNumber, ErrorMessage = "Formato no válido")]
		public string Phone { get; set; }

		[DataType(DataType.Password, ErrorMessage = "Formato no válido")]
		public string Password { get; set; }

	}
}
