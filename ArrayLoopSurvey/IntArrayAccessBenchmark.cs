using BenchmarkDotNet.Attributes;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ArrayLoopSurvey
{
	[CsvExporter]
	[DisassemblyDiagnoser]
	public class IntArrayAccessBenchmark
	{
		[Params(1_000, 1_000_000, 1_000_000_000)]
		public int ArraySize;
		private int[] _array;

		[IterationSetup]
		public void IterationSetup()
		{
			_array = Enumerable.Range(0, ArraySize).ToArray();
		}

		[Benchmark]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int IntSumFor() => IntSumFor(_array);

		private int IntSumFor(int[] array)
		{
			int accum = 0;
			for (int i = 0; i < array.Length; i++) accum += array[i];
			return accum;
		}

		[Benchmark]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int IntSumForeach() => IntSumFor(_array);


		private int IntSumForeach(int[] array)
		{
			int accum = 0;
			foreach (var i in array) accum += i;
			return accum;
		}













	}
}
