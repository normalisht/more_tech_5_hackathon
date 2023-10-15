using UnrealBuildTool;

public class more_tech_5Target : TargetRules
{
	public more_tech_5Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("more_tech_5");
	}
}
