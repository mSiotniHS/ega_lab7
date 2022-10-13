namespace ega_lab7;

public struct Item
{
	public int Value { get; }
	public int Weight { get; }

	public Item(int value, int weight)
	{
		Value = value;
		Weight = weight;
	}

	public override string ToString()
	{
		return $"(Value: {Value}, Weight: {Weight})";
	}
}
