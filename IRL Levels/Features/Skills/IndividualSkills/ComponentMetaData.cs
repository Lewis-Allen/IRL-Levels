namespace IRL_Levels.Features.Skills.IndividualSkills;

public class ComponentMetaData
{
    public required Type Type { get; init; }
    public required string Name { get; init; }
    public Dictionary<string, object> Parameters { get; } = [];
}
