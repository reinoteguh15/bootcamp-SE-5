namespace DataContractSerialization;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

[DataContract]
public class Car
{
	[DataMember] public int year;
	[DataMember] public string? Brand {get; set;}
	[DataMember] private int _cyllinder = 4;
}
