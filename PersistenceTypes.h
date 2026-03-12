#pragma once
#include "CoreMinimal.h"
#include "PersistenceTypes.generated.h"

USTRUCT()
struct FPlayerSaveData
{
    GENERATED_BODY()

    UPROPERTY()
    FUniqueNetIdRepl PlayerId;

    UPROPERTY()
    int32 Gold = 0;
};
