using UnrealBuildTool;

public class more_tech_5ServerTarget : TargetRules
{
	public more_tech_5ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("more_tech_5");
	}
}
