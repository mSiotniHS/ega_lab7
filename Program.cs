using System;
using System.Collections.Generic;
using System.Linq;

namespace ega_lab7;

internal static class Program
{
	private static void Main()
	{
		var items = new Item[]
		{
			new(7, 4),
			new(5, 2),
			new(3, 1),
			new(6, 5),
			new(2, 1),
			new(1, 2),
			new(4, 3),
			new(8, 6),
			new(3, 2),
			new(2, 3),
			new(10, 7),
			new(9,9),
			new(6, 6),
			new(3, 5),
			new(5, 4)
		};
		const int capacity = 30;

		var solution = GreedyMethod.FindSolution(items, capacity).ToList();

		var formattedSolution = string.Join(" ", GreedyMethod.ToIntList(solution));
		var solutionValue = SolutionValue(solution, items);
		Console.WriteLine($"Решение: [{formattedSolution}], ценность: {solutionValue}");
	}

	private static int SolutionValue(IReadOnlyList<bool> solution, IEnumerable<Item> items) =>
		items.Where((_, i) => solution[i]).Sum(t => t.Value);
}
