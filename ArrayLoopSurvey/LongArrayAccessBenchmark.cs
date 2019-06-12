using BenchmarkDotNet.Attributes;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ArrayLoopSurvey
{
	[CsvExporter]
	public class LongArrayAccessBenchmark
	{
		private readonly long[] _array = Enumerable.Range(0, 900_000_000).Select(i => (long) i).ToArray();

		[Benchmark]
		public long LongSumFor()
		{
			long accum = 0;
			for (int i = 0; i < _array.Length; i++) accum += _array[i];
			return accum;
		}

		[Benchmark]
		public long LongSumForeach()
		{
			long accum = 0;
			foreach (long i in _array) accum += i;
			return accum;
		}
	}
}
