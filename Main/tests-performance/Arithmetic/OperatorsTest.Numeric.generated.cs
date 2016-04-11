﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.NUnit;

using JetBrains.Annotations;

using NUnit.Framework;

using IntOp = CodeJam.Arithmetic.Operators<int>;
using NullableDoubleOp = CodeJam.Arithmetic.Operators<double?>;

using static CodeJam.AssemblyWideConfig;

namespace CodeJam.Arithmetic
{
	[TestFixture]
	public class NumOperatorsPerfTest
	{
		private const int _count = 100 * 1000;

		public class IntUnaryMinusCase
		{
			private readonly Func<int, int> _intUnaryMinus = IntOp.UnaryMinus;

			[Benchmark(Baseline = true)]
			[UsedImplicitly]
			public int UnaryMinusBaseline()
			{
				var res = 0;
				for (var i = 0; i < _count; i++)
					res += -42;
				return res;
			}

			[CompetitionBenchmark(5, 15)]
			public int UnaryMinusOperator()
			{
				var res = 0;
				for (var i = 0; i < _count; i++)
					res += _intUnaryMinus(42);
				return res;
			}
		}

		[Test]
		public void IntUnaryMinus() => CompetitionBenchmarkRunner.Run<IntUnaryMinusCase>(RunConfig);

		public class IntOnesComplementCase
		{
			private readonly Func<int, int> _intOnesComplement = IntOp.OnesComplement;

			[Benchmark(Baseline = true)]
			[UsedImplicitly]
			public int OnesComplementBaseline()
			{
				var res = 0;
				for (var i = 0; i < _count; i++)
					res += ~42;
				return res;
			}

			[CompetitionBenchmark(5, 15)]
			public int OnesComplementOperator()
			{
				var res = 0;
				for (var i = 0; i < _count; i++)
					res += _intOnesComplement(42);
				return res;
			}
		}

		[Test]
		public void IntOnesComplement() => CompetitionBenchmarkRunner.Run<IntOnesComplementCase>(RunConfig);

		public class IntPlusCase
		{
			private readonly Func<int, int, int> _intPlus = IntOp.Plus;

			[Benchmark(Baseline = true)]
			[UsedImplicitly]
			public int PlusBaseline()
			{
				var res = 0;
				for (var i = 0; i < _count; i++)
					res += 48 + 54;
				return res;
			}

			[CompetitionBenchmark(5, 15)]
			public int PlusOperator()
			{
				var res = 0;
				for (var i = 0; i < _count; i++)
					res += _intPlus(48, 54);
				return res;
			}
		}

		[Test]
		public void IntPlus() => CompetitionBenchmarkRunner.Run<IntPlusCase>(RunConfig);

		public class NullableDoublePlusCase
		{
			private readonly Func<double?, double?, double?> _doublePlus = NullableDoubleOp.Plus;

			[Benchmark(Baseline = true)]
			[UsedImplicitly]
			public double? PlusBaseline()
			{
				double? res = 0;
				for (var i = 0; i < _count; i++)
					res += 48 + 54;
				return res;
			}

			[CompetitionBenchmark(5, 15)]
			public double? PlusOperator()
			{
				double? res = 0;
				for (var i = 0; i < _count; i++)
					res += _doublePlus(48, 54);
				return res;
			}
		}

		[Test]
		public void NullableDoublePlus() => CompetitionBenchmarkRunner.Run<IntPlusCase>(RunConfig);

		public class IntMinusCase
		{
			private readonly Func<int, int, int> _intMinus = IntOp.Minus;

			[Benchmark(Baseline = true)]
			[UsedImplicitly]
			public int MinusBaseline()
			{
				var res = 0;
				for (var i = 0; i < _count; i++)
					res += 48 - 54;
				return res;
			}

			[CompetitionBenchmark(5, 15)]
			public int MinusOperator()
			{
				var res = 0;
				for (var i = 0; i < _count; i++)
					res += _intMinus(48, 54);
				return res;
			}
		}

		[Test]
		public void IntMinus() => CompetitionBenchmarkRunner.Run<IntMinusCase>(RunConfig);

		public class NullableDoubleMinusCase
		{
			private readonly Func<double?, double?, double?> _doubleMinus = NullableDoubleOp.Minus;

			[Benchmark(Baseline = true)]
			[UsedImplicitly]
			public double? MinusBaseline()
			{
				double? res = 0;
				for (var i = 0; i < _count; i++)
					res += 48 - 54;
				return res;
			}

			[CompetitionBenchmark(5, 15)]
			public double? MinusOperator()
			{
				double? res = 0;
				for (var i = 0; i < _count; i++)
					res += _doubleMinus(48, 54);
				return res;
			}
		}

		[Test]
		public void NullableDoubleMinus() => CompetitionBenchmarkRunner.Run<IntMinusCase>(RunConfig);

		public class IntMulCase
		{
			private readonly Func<int, int, int> _intMul = IntOp.Mul;

			[Benchmark(Baseline = true)]
			[UsedImplicitly]
			public int MulBaseline()
			{
				var res = 0;
				for (var i = 0; i < _count; i++)
					res += 48 * 54;
				return res;
			}

			[CompetitionBenchmark(5, 15)]
			public int MulOperator()
			{
				var res = 0;
				for (var i = 0; i < _count; i++)
					res += _intMul(48, 54);
				return res;
			}
		}

		[Test]
		public void IntMul() => CompetitionBenchmarkRunner.Run<IntMulCase>(RunConfig);

		public class NullableDoubleMulCase
		{
			private readonly Func<double?, double?, double?> _doubleMul = NullableDoubleOp.Mul;

			[Benchmark(Baseline = true)]
			[UsedImplicitly]
			public double? MulBaseline()
			{
				double? res = 0;
				for (var i = 0; i < _count; i++)
					res += 48 * 54;
				return res;
			}

			[CompetitionBenchmark(5, 15)]
			public double? MulOperator()
			{
				double? res = 0;
				for (var i = 0; i < _count; i++)
					res += _doubleMul(48, 54);
				return res;
			}
		}

		[Test]
		public void NullableDoubleMul() => CompetitionBenchmarkRunner.Run<IntMulCase>(RunConfig);

		public class IntDivCase
		{
			private readonly Func<int, int, int> _intDiv = IntOp.Div;

			[Benchmark(Baseline = true)]
			[UsedImplicitly]
			public int DivBaseline()
			{
				var res = 0;
				for (var i = 0; i < _count; i++)
					res += 48 / 54;
				return res;
			}

			[CompetitionBenchmark(5, 15)]
			public int DivOperator()
			{
				var res = 0;
				for (var i = 0; i < _count; i++)
					res += _intDiv(48, 54);
				return res;
			}
		}

		[Test]
		public void IntDiv() => CompetitionBenchmarkRunner.Run<IntDivCase>(RunConfig);

		public class NullableDoubleDivCase
		{
			private readonly Func<double?, double?, double?> _doubleDiv = NullableDoubleOp.Div;

			[Benchmark(Baseline = true)]
			[UsedImplicitly]
			public double? DivBaseline()
			{
				double? res = 0;
				for (var i = 0; i < _count; i++)
					res += 48 / 54;
				return res;
			}

			[CompetitionBenchmark(5, 15)]
			public double? DivOperator()
			{
				double? res = 0;
				for (var i = 0; i < _count; i++)
					res += _doubleDiv(48, 54);
				return res;
			}
		}

		[Test]
		public void NullableDoubleDiv() => CompetitionBenchmarkRunner.Run<IntDivCase>(RunConfig);

		public class IntModuloCase
		{
			private readonly Func<int, int, int> _intModulo = IntOp.Modulo;

			[Benchmark(Baseline = true)]
			[UsedImplicitly]
			public int ModuloBaseline()
			{
				var res = 0;
				for (var i = 0; i < _count; i++)
					res += 48 % 54;
				return res;
			}

			[CompetitionBenchmark(5, 15)]
			public int ModuloOperator()
			{
				var res = 0;
				for (var i = 0; i < _count; i++)
					res += _intModulo(48, 54);
				return res;
			}
		}

		[Test]
		public void IntModulo() => CompetitionBenchmarkRunner.Run<IntModuloCase>(RunConfig);

		public class IntXorCase
		{
			private readonly Func<int, int, int> _intXor = IntOp.Xor;

			[Benchmark(Baseline = true)]
			[UsedImplicitly]
			public int XorBaseline()
			{
				var res = 0;
				for (var i = 0; i < _count; i++)
					res += 48 ^ 54;
				return res;
			}

			[CompetitionBenchmark(5, 15)]
			public int XorOperator()
			{
				var res = 0;
				for (var i = 0; i < _count; i++)
					res += _intXor(48, 54);
				return res;
			}
		}

		[Test]
		public void IntXor() => CompetitionBenchmarkRunner.Run<IntXorCase>(RunConfig);

		public class IntBitwiseAndCase
		{
			private readonly Func<int, int, int> _intBitwiseAnd = IntOp.BitwiseAnd;

			[Benchmark(Baseline = true)]
			[UsedImplicitly]
			public int BitwiseAndBaseline()
			{
				var res = 0;
				for (var i = 0; i < _count; i++)
					res += 48 & 54;
				return res;
			}

			[CompetitionBenchmark(5, 15)]
			public int BitwiseAndOperator()
			{
				var res = 0;
				for (var i = 0; i < _count; i++)
					res += _intBitwiseAnd(48, 54);
				return res;
			}
		}

		[Test]
		public void IntBitwiseAnd() => CompetitionBenchmarkRunner.Run<IntBitwiseAndCase>(RunConfig);

		public class IntBitwiseOrCase
		{
			private readonly Func<int, int, int> _intBitwiseOr = IntOp.BitwiseOr;

			[Benchmark(Baseline = true)]
			[UsedImplicitly]
			public int BitwiseOrBaseline()
			{
				var res = 0;
				for (var i = 0; i < _count; i++)
					res += 48 | 54;
				return res;
			}

			[CompetitionBenchmark(5, 15)]
			public int BitwiseOrOperator()
			{
				var res = 0;
				for (var i = 0; i < _count; i++)
					res += _intBitwiseOr(48, 54);
				return res;
			}
		}

		[Test]
		public void IntBitwiseOr() => CompetitionBenchmarkRunner.Run<IntBitwiseOrCase>(RunConfig);

		public class IntLeftShiftCase
		{
			private readonly Func<int, int, int> _intLeftShift = IntOp.LeftShift;

			[Benchmark(Baseline = true)]
			[UsedImplicitly]
			public int LeftShiftBaseline()
			{
				var res = 0;
				for (var i = 0; i < _count; i++)
					res += 48 << 54;
				return res;
			}

			[CompetitionBenchmark(5, 15)]
			public int LeftShiftOperator()
			{
				var res = 0;
				for (var i = 0; i < _count; i++)
					res += _intLeftShift(48, 54);
				return res;
			}
		}

		[Test]
		public void IntLeftShift() => CompetitionBenchmarkRunner.Run<IntLeftShiftCase>(RunConfig);

		public class IntRightShiftCase
		{
			private readonly Func<int, int, int> _intRightShift = IntOp.RightShift;

			[Benchmark(Baseline = true)]
			[UsedImplicitly]
			public int RightShiftBaseline()
			{
				var res = 0;
				for (var i = 0; i < _count; i++)
					res += 48 >> 54;
				return res;
			}

			[CompetitionBenchmark(5, 15)]
			public int RightShiftOperator()
			{
				var res = 0;
				for (var i = 0; i < _count; i++)
					res += _intRightShift(48, 54);
				return res;
			}
		}

		[Test]
		public void IntRightShift() => CompetitionBenchmarkRunner.Run<IntRightShiftCase>(RunConfig);

	}
}