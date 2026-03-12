#pragma once
#include "CoreMinimal.h"
#include "GuildWarTypes.generated.h"

UENUM(BlueprintType)
enum class EGuildWarState : uint8
{
    Declared,
    Active,
    Finished,
    Cancelled
};
