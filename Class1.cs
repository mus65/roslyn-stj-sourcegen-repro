using System.Text.Json.Serialization;

namespace roslynstjsourcegenrepro;

[JsonSerializable(typeof(TestClass))]
internal partial class TestJsonSerializerContext : JsonSerializerContext;