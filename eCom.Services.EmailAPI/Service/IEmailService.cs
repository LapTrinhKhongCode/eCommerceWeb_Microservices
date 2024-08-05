﻿using eCom.Services.EmailAPI.Models.DTO;

namespace eCom.Services.EmailAPI.Service
{
	public interface IEmailService
	{
		Task EmailCartAndLog(CartDTO cartDTO);
		Task RegisterUserEmailAndLog(string email);
	}
}
