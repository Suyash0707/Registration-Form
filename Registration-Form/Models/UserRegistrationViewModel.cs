using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Registration_Form.Models
{
	public class UserRegistrationViewModel
	{
		public int Id { get; set; }
		[Required]
		[EmailAddress]
		[Remote(action: "IsEmailIdValid", controller: "Home")]
		public string? Email { get; set; }
		[Required]
		public string? FirstName { get; set; }
		[Required]
		public string? LastName { get; set; }

		public int? GendersId { get; set; }
		[Required]
		[RegularExpression(@"^[(]?\d{3}[)]?[- ]?\d{3}[- ]?\d{4}$", ErrorMessage = "Invalid Mobile Number")]
		public string? MobileNumber { get; set; }
		[Required]
		[StringLength(15, MinimumLength = 6)]
		public string? Password { get; set; }
		[Compare("Password", ErrorMessage ="Password doesn't Match!")]
		public String? ConfirmPassword { get; set; }

		public string? AdharNumber { get; set; }
	}
}
