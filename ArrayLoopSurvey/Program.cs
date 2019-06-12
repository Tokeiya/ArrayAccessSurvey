using System;
using System.IO;
using System.IO.Compression;
using BenchmarkDotNet.Running;

namespace ArrayLoopSurvey
{
	class Program
	{
		static void Main(string[] args)
		{
			BenchmarkRunner.Run<IntArrayAccessBenchmark>();

			var fileName = $"{DateTimeOffset.Now.Ticks}.zip";

			ZipFile.CreateFromDirectory("./BenchmarkDotNet.Artifacts", fileName);

			Console.WriteLine($"");
			Console.WriteLine($"");


			Console.ForegroundColor = ConsoleColor.White;

			Console.WriteLine($"{Environment.CurrentDirectory}\\{fileName}を作成しました。\n" +
			                  $"恐れ入りますが、このファイルを、https://github.com/Tokeiya/ArrayAccessSurvey/issues \n" +
			                  $"まで投稿して下さい。\n" +
			                  $"(NewIssueを作成して頂き、コメント欄に当該ファイルをドラッグ&ドロップして下さい。)");
		}
	}
}

