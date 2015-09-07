﻿namespace MyWebApi.Builders.Contracts.Base
{
    using System;
    using System.Web.Http;

    /// <summary>
    /// Base interface for all test builders.
    /// </summary>
    public interface IBaseTestBuilder
    {
        /// <summary>
        /// Gets the action name which will be tested.
        /// </summary>
        /// <returns>Action name to be tested.</returns>
        string AndProvideTheActionName();

        /// <summary>
        /// Gets the controller on which the action is tested.
        /// </summary>
        /// <returns>ASP.NET Web API controller on which the action is tested.</returns>
        ApiController AndProvideTheController();

        /// <summary>
        /// Gets the thrown exception in the tested action.
        /// </summary>
        /// <returns>The exception instance or null, if no exception was caught.</returns>
        Exception AndProvideTheCaughtException();
    }
}