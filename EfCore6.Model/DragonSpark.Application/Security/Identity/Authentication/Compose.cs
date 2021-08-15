﻿using DragonSpark.Application.Security.Identity.Claims.Compile;
using DragonSpark.Compose;
using DragonSpark.Model.Operations;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace DragonSpark.Application.Security.Identity.Authentication
{
	sealed class Compose : IResulting<Composition?>
	{
		readonly IHttpContextAccessor _accessor;
		readonly ICurrentKnownClaims  _claims;
		readonly ApplicationClaims    _state;

		public Compose(IHttpContextAccessor accessor, ICurrentKnownClaims claims)
			: this(accessor, claims, ApplicationClaims.Default) {}

		public Compose(IHttpContextAccessor accessor, ICurrentKnownClaims claims, ApplicationClaims state)
		{
			_accessor = accessor;
			_claims   = claims;
			_state    = state;
		}

		public async ValueTask<Composition?> Get()
		{
			var authentication = await _accessor.HttpContext.Verify()
			                                    .AuthenticateAsync(IdentityConstants.ApplicationScheme)
			                                    .ConfigureAwait(false);
			var identity = authentication.Principal;
			var result = identity != null
				             ? new(authentication.Properties,
				                   _claims.Get().Open().Union(_state.Get(identity).Open()).ToArray())
				             : default(Composition?);
			return result;
		}
	}
}