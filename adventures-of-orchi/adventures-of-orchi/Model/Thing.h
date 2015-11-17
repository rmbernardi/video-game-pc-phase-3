#pragma once
#include "Immovable.h"

using namespace Platform;

class Thing : public Immovable
{
public:
	Thing(
		float2 pfLocationRatio,
		float fRotationInRadians,
		float2 pfDimensions,
		bool bIsVisible,
		bool bIsActionable,
		bool bIsCollidable,
		const shared_ptr<DeviceResources>& deviceResources)
		: Immovable(
			pfLocationRatio,
			fRotationInRadians,
			pfDimensions,
			bIsVisible,
			bIsActionable,
			bIsCollidable,
			deviceResources)
	{

	}

protected:

private:
};