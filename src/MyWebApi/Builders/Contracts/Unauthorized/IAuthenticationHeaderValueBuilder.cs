﻿// MyWebApi - ASP.NET Web API Fluent Testing Framework
// Copyright (C) 2015 Ivaylo Kenov.
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see http://www.gnu.org/licenses/.

namespace MyWebApi.Builders.Contracts.Unauthorized
{
    /// <summary>
    /// Used for building mocked AuthenticationHeaderValue scheme.
    /// </summary>
    public interface IAuthenticationHeaderValueBuilder
    {
        /// <summary>
        /// Sets scheme to the built authentication header value with the provided AuthenticationScheme enumeration.
        /// </summary>
        /// <param name="scheme">Enumeration with default authentication header schemes.</param>
        /// <returns>Authentication header value parameter builder.</returns>
        IAuthenticationHeaderValueParameterBuilder WithScheme(AuthenticationScheme scheme);

        /// <summary>
        /// Sets scheme to the built authentication header value with the provided string.
        /// </summary>
        /// <param name="scheme">Authentication header scheme as string.</param>
        /// <returns>Authentication header value parameter builder.</returns>
        IAuthenticationHeaderValueParameterBuilder WithScheme(string scheme);
    }
}
