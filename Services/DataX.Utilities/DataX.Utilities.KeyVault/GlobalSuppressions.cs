﻿
// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1054:Change the type of parameter secretUri of method KeyVault.GetSecretFromKeyvault(string) from string to System.Uri, or provide an overload to KeyVault.GetSecretFromKeyvault(string) that allows secretUri to be passed as a System.Uri object.", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Utilities.KeyVault.KeyVault.GetSecretFromKeyvault(System.String)~System.String")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1054:Change the type of parameter secretUri of method KeyVault.SaveSecretToKeyvault(string, string) from string to System.Uri, or provide an overload to KeyVault.SaveSecretToKeyvault(string, string) that allows secretUri to be passed as a System.Uri object.", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Utilities.KeyVault.KeyVault.SaveSecretToKeyvault(System.String,System.String)~System.String")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Utilities.KeyVault.KeyVaultManager.DeleteSecretAsync(System.String,System.String)~System.Threading.Tasks.Task{DataX.Contract.ApiResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Utilities.KeyVault.KeyVaultManager.GetAndDeleteSecretsAsync(System.String,System.String)~System.Threading.Tasks.Task{DataX.Contract.ApiResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1307:The behavior of 'string.StartsWith(string)' could vary based on the current user's locale settings. Replace this call in 'DataX.Utilities.KeyVault.KeyVaultManager.GetAndDeleteSecretsAsync(string, string)' with a call to 'string.StartsWith(string, System.StringComparison)'.", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Utilities.KeyVault.KeyVaultManager.GetAndDeleteSecretsAsync(System.String,System.String)~System.Threading.Tasks.Task{DataX.Contract.ApiResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1822:Member GetKeyVaultSecretUrl does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Utilities.KeyVault.KeyVaultManager.GetKeyVaultSecretUrl(System.String)~System.String")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Utilities.KeyVault.KeyVaultManager.GetSecretStringAsync(System.String,System.String)~System.Threading.Tasks.Task{System.String}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Utilities.KeyVault.KeyVaultManager.SaveSecretStringAsync(System.String,System.String,System.String)~System.Threading.Tasks.Task{System.String}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Utilities.KeyVault.KeyVaultUtility.GetSecretFromKeyvault(System.String,System.String)~System.Threading.Tasks.Task{System.String}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Utilities.KeyVault.KeyVaultUtility.GetSecretFromKeyVaultAsync(System.String,System.String)~System.Threading.Tasks.Task{DataX.Contract.ApiResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Utilities.KeyVault.KeyVaultUtility.GetSecretsAndDeleteSecretsFromKeyVault(System.String,System.String)~System.Threading.Tasks.Task{System.String}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Utilities.KeyVault.KeyVaultUtility.GetSecretsAndDeleteSecretsFromKeyVaultAsync(System.String,System.String)~System.Threading.Tasks.Task{DataX.Contract.ApiResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Utilities.KeyVault.KeyVaultUtility.SaveSecretToKeyValutAsync(System.String,System.String,System.String)~System.Threading.Tasks.Task{DataX.Contract.ApiResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Utilities.KeyVault.KeyVaultUtility.SaveSecretToKeyvault(System.String,System.String,System.String)~System.Threading.Tasks.Task{System.String}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1724:The type name KeyVault conflicts in whole or in part with the namespace name 'DataX.Utilities.KeyVault'. Change either name to eliminate the conflict.", Justification = "Critical issues only", Scope = "type", Target = "~T:DataX.Utilities.KeyVault.KeyVault")]
