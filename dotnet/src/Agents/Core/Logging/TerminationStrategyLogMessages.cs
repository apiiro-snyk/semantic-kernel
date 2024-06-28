﻿// Copyright (c) Microsoft. All rights reserved.
using System;
using Microsoft.Extensions.Logging;

namespace Microsoft.SemanticKernel.Agents.Chat;

#pragma warning disable SYSLIB1006 // Multiple logging methods cannot use the same event id within a class

/// <summary>
/// Extensions for logging <see cref="TerminationStrategy"/> invocations.
/// </summary>
/// <remarks>
/// This extension uses the <see cref="LoggerMessageAttribute"/> to
/// generate logging code at compile time to achieve optimized code.
/// </remarks>
internal static partial class TerminationStrategyLogMessages
{
    /// <summary>
    /// Logs <see cref="TerminationStrategy"/> evaluting criteria (started).
    /// </summary>
    [LoggerMessage(
        EventId = 0,
        Level = LogLevel.Debug,
        Message = "[{MethodName}] Evaluating termination for agent {AgentType}: {AgentId}.")]
    public static partial void LogTerminationStrategyEvaluatingCriteria(
        this ILogger logger,
        string methodName,
        Type agentType,
        string agentId);

    /// <summary>
    /// Logs <see cref="TerminationStrategy"/> agent out of scope.
    /// </summary>
    [LoggerMessage(
        EventId = 0,
        Level = LogLevel.Debug,
        Message = "[{MethodName}] {AgentType} agent out of scope for termination: {AgentId}.")]
    public static partial void LogTerminationStrategyAgentOutOfScope(
        this ILogger logger,
        string methodName,
        Type agentType,
        string agentId);

    /// <summary>
    /// Logs <see cref="TerminationStrategy"/> evaluted criteria (complete).
    /// </summary>
    [LoggerMessage(
        EventId = 0,
        Level = LogLevel.Information,
        Message = "[{MethodName}] Evaluated termination for agent {AgentType}: {AgentId} - {TerminationResult}")]
    public static partial void LogTerminationStrategyEvaluatedCriteria(
        this ILogger logger,
        string methodName,
        Type agentType,
        string agentId,
        bool terminationResult);
}
