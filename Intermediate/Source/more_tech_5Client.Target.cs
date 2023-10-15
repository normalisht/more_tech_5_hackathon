using UnrealBuildTool;

public class more_tech_5ClientTarget : TargetRules
{
	public more_tech_5ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("more_tech_5");
	}
}
