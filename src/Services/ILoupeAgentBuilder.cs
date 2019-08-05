﻿using System.Diagnostics;
using System.Security.Principal;
using Gibraltar.Monitor;

namespace Loupe.Agent.Core.Services
{
    /// <summary>
    /// Interface for the fluent Loupe Agent builder.
    /// </summary>
    public interface ILoupeAgentBuilder
    {
        /// <summary>
        /// Adds a <see cref="DiagnosticSource"/> listener.
        /// </summary>
        /// <typeparam name="T">The type of the listener, which must implement <see cref="ILoupeDiagnosticListener"/>.</typeparam>
        /// <returns>The builder instance.</returns>
        ILoupeAgentBuilder AddListener<T>() where T : class, ILoupeDiagnosticListener;

        /// <summary>
        /// Adds a <see cref="ILoupeMonitor" /> monitor.
        /// </summary>
        /// <typeparam name="T">The type of the monitor, which must implement <see cref="ILoupeMonitor"/>.</typeparam>
        /// <returns>The builder instance.</returns>
        ILoupeAgentBuilder AddMonitor<T>() where T : class, ILoupeMonitor;

        /// <summary>
        /// Adds a <see cref="ILoupeFilter" />  filter.
        /// </summary>
        /// <typeparam name="T">The type of the filter, which must implement <see cref="ILoupeFilter" />.</typeparam>
        /// <returns>The builder instance.</returns>
        ILoupeAgentBuilder AddFilter<T>() where T : class, ILoupeFilter;

        /// <summary>
        /// Specify the <see cref="IPrincipal"/> resolver for the current application.
        /// </summary>
        /// <typeparam name="T">The type of the resolver, which must implement <see cref="IPrincipalResolver" />.</typeparam>
        /// <returns>The builder instance.</returns>
        ILoupeAgentBuilder AddPrincipalResolver<T>() where T : class, IPrincipalResolver;

        /// <summary>
        /// Specify the Application User Resolver for the current application.
        /// </summary>
        /// <typeparam name="T">The type of the resolver, which must implement <see cref="IApplicationUserResolver" />.</typeparam>
        /// <returns>The builder instance.</returns>
        ILoupeAgentBuilder AddApplicationUserResolver<T>() where T : class, IApplicationUserResolver;
    }
}