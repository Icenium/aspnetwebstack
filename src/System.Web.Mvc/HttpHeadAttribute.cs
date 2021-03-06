﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace System.Web.Mvc
{
    /// <summary>
    /// Specifies that an action supports the HEAD HTTP method.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public sealed class HttpHeadAttribute : HttpVerbAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpHeadAttribute" /> class.
        /// </summary>
        public HttpHeadAttribute()
            : base(HttpVerbs.Head)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpHeadAttribute" /> class.
        /// </summary>
        /// <param name="routeTemplate">The route template describing the URI pattern to match against.</param>
        public HttpHeadAttribute(string routeTemplate)
            : base(HttpVerbs.Head, routeTemplate)
        {
        }
    }
}
