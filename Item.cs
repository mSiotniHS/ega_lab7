namespace ega_lab7;

public readonly struct Item
{
	public int Value { get; }
	public int Weight { get; }

	public Item(int value, int weight)
	{
		Value = value;
		Weight = weight;
	}

	public override string ToString() => $"(Value: {Value}, Weight: {Weight})";
}
