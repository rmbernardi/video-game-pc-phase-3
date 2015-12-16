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
#include "Thing.h"
#include "Texture.h"

class StoneWall : public Thing
{
public:
	StoneWall(
		float2 pfLocationRatio,
		float fRotationInRadians,
		float2 pfDimensions,
		bool bIsVisible,
		const shared_ptr<DeviceResources>& deviceResources) :
		Thing(
			pfLocationRatio,
			fRotationInRadians,
			pfDimensions,
			true,
			false,
			true,
			deviceResources)
	{
		m_pRenderable = new Texture("stonewall.dds", deviceResources);
	}

protected:

private:
};