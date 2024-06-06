using Vogen;

namespace One;

[ValueObject<string>]
public readonly partial struct NationalId
{
	private static Validation Validate(string input)
	{
		if (input.Length != 10)
			return Validation.Invalid("A national ID must be 10 digits.");

		return Validation.Ok;
	}
}
