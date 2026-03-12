#pragma once
#include "CoreMinimal.h"
#include "PartyTypes.generated.h"

UENUM(BlueprintType)
enum class EPartyRole : uint8
{
    Member,
    Assistant,
    Leader
};
