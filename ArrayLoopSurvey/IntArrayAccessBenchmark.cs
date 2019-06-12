using BenchmarkDotNet.Attributes;
using System.Linq;

namespace ArrayLoopSurvey
{
	[CsvExporter]
	public class IntArrayAccessBenchmark
	{
		private readonly int[] _array = Enumerable.Range(0, 900_000_000).ToArray();

		[Benchmark]
		public int IntSumFor()
		{
			int[] ary = _array;
			int accum = 0;
			for (int i = 0; i < ary.Length; i++) accum += ary[i];
			return accum;
		}


		[Benchmark]
		public int IntSumForeach()
		{
			int accum = 0;
			foreach (var i in _array) accum += i;
			return accum;
		}
	}
}
