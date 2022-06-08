using UnrealBuildTool;

public class SBLP2Target : TargetRules
{
	public SBLP2Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("SBLP2");
	}
}
