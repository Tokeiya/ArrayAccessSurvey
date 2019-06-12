using BenchmarkDotNet.Attributes;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ArrayLoopSurvey
{
	[ShortRunJob]
	[CsvExporter]
	public class IntArrayAccessBenchmark
	{
		private readonly int[] _array = Enumerable.Range(0, 1_000_000_000).ToArray();


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
