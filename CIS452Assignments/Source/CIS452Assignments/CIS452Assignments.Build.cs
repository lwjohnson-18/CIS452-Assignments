// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CIS452Assignments : ModuleRules
{
	public CIS452Assignments(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "EnhancedInput" });
	}
}
