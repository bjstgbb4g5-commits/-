using UnrealBuildTool;

public class MMOReplicationGraph : ModuleRules
{
    public MMOReplicationGraph(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(
            new string[] { "Core","CoreUObject","Engine","NetCore","ReplicationGraph","OnlineSubsystem","OnlineSubsystemUtils" }
        );
    }
}
