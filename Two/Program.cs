using System.Text.Json;
using System.Text.Json.Serialization;
using One;

var foo = new Foo(NationalId.From("1234567890"));
Console.WriteLine(
	JsonSerializer.Serialize(
		foo,
		new JsonSerializerOptions { WriteIndented = true }
	)
);

Console.WriteLine(
	JsonSerializer.Serialize(
		foo,
		JsonContext.Default.Options
	)
);

public record Foo(
	NationalId NationalId
);

[JsonSerializable(typeof(Foo))]
[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.KebabCaseLower)]
public partial class JsonContext : JsonSerializerContext;
