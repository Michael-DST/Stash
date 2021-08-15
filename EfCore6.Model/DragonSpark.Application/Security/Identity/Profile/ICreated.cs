﻿using DragonSpark.Model.Operations;
using Microsoft.AspNetCore.Identity;

namespace DragonSpark.Application.Security.Identity.Profile
{
	public interface ICreated<T> : ISelecting<Login<T>, IdentityResult> {}
}