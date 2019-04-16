﻿
// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1051:Do not declare visible instance fields", Justification = "Critical issues only", Scope = "member", Target = "~F:DataX.Config.LivyClient.LivyHttpResult.Content")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1051:Do not declare visible instance fields", Justification = "Critical issues only", Scope = "member", Target = "~F:DataX.Config.LivyClient.LivyHttpResult.IsSuccess")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1051:Do not declare visible instance fields", Justification = "Critical issues only", Scope = "member", Target = "~F:DataX.Config.LivyClient.LivyHttpResult.StatusCode")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.LivyClient.LivyClient.CallLivyService(DataX.Config.LivyClient.HttpMethod,System.String,System.String)~System.Threading.Tasks.Task{DataX.Config.LivyClient.LivyHttpResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.LivyClient.LivyClient.GetJobInfo(Newtonsoft.Json.Linq.JToken)~System.Threading.Tasks.Task{DataX.Config.SparkJobSyncResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.LivyClient.LivyClient.GetJobs~System.Threading.Tasks.Task{DataX.Config.SparkJobSyncResult[]}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1305:The behavior of 'int.ToString()' could vary based on the current user's locale settings. Replace this call in 'LivyClient.ParseLivyBatchResult(LivyBatchResult)' with a call to 'int.ToString(IFormatProvider)'.", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.LivyClient.LivyClient.ParseLivyBatchResult(DataX.Config.LivyClient.LivyBatchResult)~DataX.Config.SparkJobSyncResult")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1307:The behavior of 'string.Replace(string, string)' could vary based on the current user's locale settings. Replace this call in 'DataX.Config.LivyClient.LivyClient.ParseLivyBatchResult(DataX.Config.LivyClient.LivyBatchResult)' with a call to 'string.Replace(string, string, System.StringComparison)'.", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.LivyClient.LivyClient.ParseLivyBatchResult(DataX.Config.LivyClient.LivyBatchResult)~DataX.Config.SparkJobSyncResult")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.LivyClient.LivyClient.StopJob(Newtonsoft.Json.Linq.JToken)~System.Threading.Tasks.Task{DataX.Config.SparkJobSyncResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.LivyClient.LivyClient.SubmitJob(Newtonsoft.Json.Linq.JToken)~System.Threading.Tasks.Task{DataX.Config.SparkJobSyncResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.LivyClient.LivyHttpClient.ExecuteHttpRequest(DataX.Config.LivyClient.HttpMethod,System.Uri,System.String)~System.Threading.Tasks.Task{DataX.Config.LivyClient.LivyHttpResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "Critical issues only", Scope = "member", Target = "~P:DataX.Config.LivyClient.LivyBatchesResult.Sessions")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2227:Change 'AppInfo' to be read-only by removing the property setter.", Justification = "Critical issues only", Scope = "member", Target = "~P:DataX.Config.LivyClient.LivyBatchResult.AppInfo")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "Critical issues only", Scope = "member", Target = "~P:DataX.Config.LivyClient.LivyBatchResult.Log")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1724:The type name LivyClient conflicts in whole or in part with the namespace name 'DataX.Config.LivyClient'. Change either name to eliminate the conflict.", Justification = "Critical issues only", Scope = "type", Target = "~T:DataX.Config.LivyClient.LivyClient")]
