﻿using System.Net.Http;
namespace D2L {
	public static partial class _D2LServicesCore_Extensions {
		// TODO: move to D2L.Services.Core.Extensions and make public? Downsides: people shouldn't have to use this.
		internal static InterfaceType GetDependency<InterfaceType>(
			this HttpRequestMessage @this
		) {
			return @this.GetDependencyScope().Get<InterfaceType>();
		}
	}
}