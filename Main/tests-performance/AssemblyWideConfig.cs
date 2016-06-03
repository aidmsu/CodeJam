﻿using System;

using BenchmarkDotNet.Configs;

using CodeJam.PerfTests.Configs;

using JetBrains.Annotations;

namespace CodeJam
{
	/// <summary>
	/// Use this to run fast but inaccurate measures
	/// OPTIONAL: Updates source files with actual min..max ratio for [CompetitionBenchmark]
	/// </summary>
	[PublicAPI]
	public sealed class AssemblyWideConfig : ReadOnlyCompetitionConfig
	{
		/// <summary>
		/// OPTIONAL: Set AssemblyWideConfig.AnnotateOnRun=true in app.config
		/// to enable auto-annotation of benchmark methods
		/// </summary>
		public static readonly bool AnnotateOnRun = AppSwitch.GetAssemblySwitch(() => AnnotateOnRun);

		/// <summary>
		/// OPTIONAL: Set AssemblyWideConfig.IgnoreAnnotatedLimits=true in app.config
		/// to enable ignoring existing limits on auto-annotation of benchmark methods
		/// </summary>
		public static readonly new bool IgnoreExistingAnnotations = AppSwitch.GetAssemblySwitch(() => IgnoreExistingAnnotations);

		/// <summary>
		/// OPTIONAL: Set AssemblyWideConfig.ReportWarningsAsErrors=true in app.config
		/// to enable reporting warnings as errors.
		/// </summary>
		public static readonly new bool ReportWarningsAsErrors = AppSwitch.GetAssemblySwitch(() => ReportWarningsAsErrors);

		/// <summary>
		/// Instance of the config
		/// </summary>
		public static ICompetitionConfig RunConfig => new AssemblyWideConfig(true);

		/// <summary>
		/// Constructor
		/// </summary>
		[UsedImplicitly]
		public AssemblyWideConfig() : this(false) { }

		/// <summary>
		/// Constructor
		/// </summary>
		public AssemblyWideConfig(bool asRunConfig): base(Create(asRunConfig))
		{
		}

		private static ManualCompetitionConfig Create(bool asRunConfig)
		{
			var result = new ManualCompetitionConfig();

			if (asRunConfig)
				result.Add(DefaultConfig.Instance);

			result.Add(FastRunConfig.Instance);

			result.RerunIfLimitsFailed = true;
			result.ReportWarningsAsErrors = ReportWarningsAsErrors;
			if (AnnotateOnRun)
			{
				result.IgnoreExistingAnnotations = IgnoreExistingAnnotations;
				result.UpdateSourceAnnotations = true;
				result.LogCompetitionLimits = true;
			}

			return result;
		}
	}
}