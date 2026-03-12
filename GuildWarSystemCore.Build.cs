using UnrealBuildTool;

public class GuildWarSystemCore : ModuleRules
{
    public GuildWarSystemCore(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(
            new string[] { "Core","CoreUObject","Engine","NetCore","ReplicationGraph","OnlineSubsystem","OnlineSubsystemUtils" }
        );
    }
}
