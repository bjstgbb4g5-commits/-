using UnrealBuildTool;

public class PlayerRegistrySubsystem : ModuleRules
{
    public PlayerRegistrySubsystem(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(
            new string[] { "Core","CoreUObject","Engine","NetCore","ReplicationGraph","OnlineSubsystem","OnlineSubsystemUtils" }
        );
    }
}
