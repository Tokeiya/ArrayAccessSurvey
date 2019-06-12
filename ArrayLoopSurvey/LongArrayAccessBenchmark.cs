using BenchmarkDotNet.Attributes;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ArrayLoopSurvey
{
	[CsvExporter]
	public class LongArrayAccessBenchmark
	{
		private readonly long[] _array = Enumerable.Range(0, 1_000_000_000).Select(i => (long) i).ToArray();


		[Benchmark]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public long LongSumFor()
		{
			return LongSumFor(_array);
		}

		private long LongSumFor(long[] array)
		{
			long accum = 0;
			for (int i = 0; i < array.Length; i++) accum += array[i];
			return accum;
		}

		[Benchmark]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public long LongSumForeach() => LongSumForeach(_array);

		private long LongSumForeach(long[] array)
		{
			long accum = 0;
			foreach (long i in array) accum += i;
			return accum;
		}
	}
}
