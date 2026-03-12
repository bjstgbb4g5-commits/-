using UnrealBuildTool;

public class PersistenceSystemCore : ModuleRules
{
    public PersistenceSystemCore(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(
            new string[] { "Core","CoreUObject","Engine","NetCore","ReplicationGraph","OnlineSubsystem","OnlineSubsystemUtils" }
        );
    }
}
