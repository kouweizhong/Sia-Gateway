﻿
// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage(
    "Design",
    "CA1032:Implement standard exception constructors",
    Justification = "Custom exception types with rigid usage requirements",
    Scope = "module")]

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage(
    "Naming",
    "CA1707:Identifiers should not contain underscores",
    Justification = "Test methods are more readable with underscores",
    Scope = "module"
)]
