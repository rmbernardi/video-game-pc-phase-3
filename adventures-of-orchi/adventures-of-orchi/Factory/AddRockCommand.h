/*
	Copyright 2016 Richard Bernardino

	Licensed under the Apache License, Version 2.0 (the "License");
	you may not use this file except in compliance with the License.
	You may obtain a copy of the License at

	http://www.apache.org/licenses/LICENSE-2.0

	Unless required by applicable law or agreed to in writing, software
	distributed under the License is distributed on an "AS IS" BASIS,
	WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
	See the License for the specific language governing permissions and
	limitations under the License.
*/
#pragma once
#include "BuildCommand.h"
#include "..\Model\Rock.h"
#include "..\Utils.h"
#include "..\Model\World.h"

class AddRockCommand : public BuildCommand
{
public:
	void Process(
		World ** pWorld,
		float2 fScreenDimensions,
		ServiceProxy::BuildCommand ^ command,
		Subdivision ** pSubdivision,
		const shared_ptr<DeviceResources>& deviceResources)
	{
		float x;
		float y;

		Utils::CalculateSquareCenter(
			fScreenDimensions.x,
			fScreenDimensions.y,
			((ServiceProxy::AddRockCommand ^)command)->X,
			((ServiceProxy::AddRockCommand ^)command)->Y,
			&x,
			&y);

		(*pSubdivision)->Set(LAYER_COLLIDABLES,
			new Rock(
				float2(x, y),
				0.f,
				float2
				{
					Utils::CalculateSquareWidthRatio(fScreenDimensions.x),
					Utils::CalculateSquareHeightRatio(fScreenDimensions.y)
				},
				true,
				command,
				deviceResources));
	}

protected:

private:
};
