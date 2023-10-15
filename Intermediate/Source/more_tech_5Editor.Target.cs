using UnrealBuildTool;

public class more_tech_5EditorTarget : TargetRules
{
	public more_tech_5EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("more_tech_5");
	}
}
