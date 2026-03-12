using UnrealBuildTool;

public class PartySystemCore : ModuleRules
{
    public PartySystemCore(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(
            new string[] { "Core","CoreUObject","Engine","NetCore","ReplicationGraph","OnlineSubsystem","OnlineSubsystemUtils" }
        );
    }
}
