﻿using Caregiver.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Caregiver.Repositories.IRepository
{
	public interface IUserRepo
	{
		Task<UserManagerResponse> ChangePassword(EditPasswordDTO model);
		Task<string> ForgotPassword( string email);
		Task<string> UpdateForgottenPassword(string id, string resetToken, string newPassword);
		Task<UserManagerResponse> RegisterUserAsync(RegisterPatientDTO model);

		Task<UserManagerResponse> RegisterCaregiverAsync(RegisterCaregiverDTO model);

		Task<UserManagerResponse> FormCaregiverAsync(FormCaregiverDTO model );
		Task<UserManagerResponse> FilesCaregiverAsync(FilesCaregiverDTO model, HttpRequest Request);


		Task<LoginResDTO> LoginAsync(LoginReqDTO loginReqDTO);

        Task<UserManagerResponse> PersonalDetailsAsync(PersonalDetailsDTO model);

		Task<UserManagerResponse> LogoutAsync();

		Task<string> ContactUs(ContactUsDTO dto);



	}
}
