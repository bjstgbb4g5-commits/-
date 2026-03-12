#pragma once
#include "CoreMinimal.h"
#include "GuildTypes.generated.h"

UENUM(BlueprintType)
enum class EGuildRank : uint8
{
    Recruit,
    Member,
    Veteran,
    Officer,
    Leader,
    GuildMaster
};
