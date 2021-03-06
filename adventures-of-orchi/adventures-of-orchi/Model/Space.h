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
#include "pch.h"
#include "..\Constants.h"
#include "..\Common\DeviceResources.h"
#include "Renderable.h"
#include "Action.h"

using namespace BasicSprites;
using namespace std;
using namespace Platform;

class Space
{
public:
	Space() {};

	Space(
		float2 fLocationRatio,
		float fRotationInRadians,
		float2 fDimensionsRatio,
		bool bIsVisible,
		bool bIsActionable,
		bool bIsCollidable,
		ServiceProxy::BuildCommand ^ pCommand,
		const shared_ptr<DeviceResources>& deviceResources);

	~Space();

	float2 GetLocationRatio();
	float2 GetDimensionsRatio();

	// Only used by the sword
	void SetLocationRatio(float2 fLocationRatio) { m_fLocationRatio = fLocationRatio; }

	float CalculateDistance(Space * space);
	float CalculateDistance(Space * space, XMFLOAT3 * vecDifferential);

	vector<Space *> DetectCollisions() {}

	void Render(
		ComPtr<ID3D11RenderTargetView> renderTargetView,
		float2 fWindowDimensions,
		float2 fScaleDimensions,
		float dpi);

	//virtual int Act(GameRenderer *, World *)
	//{
	//	return 0;
	//}

	// "Rotate" connotes turning away from the 
	//	current angle. 
	void TurnTowards(float fRadians) 
	{ 
		m_fRotationInRadians = fRadians; 
	}

	uint8_t * GetPixels()
	{
		return m_pRenderable->GetPixels();
	}

	int * GetTextureDimensions()
	{
		return m_pRenderable->GetTextureDimensions();
	}

	void SetVisibility(bool bIsVisible) { m_bIsVisible = bIsVisible; }
	bool GetVisibility() { return m_bIsVisible; }

	virtual bool IsOverlapping(Space * pOther)
	{
		float fDistance = this->CalculateDistance(pOther);

#ifdef _DEBUG
		char buffer[64];
		sprintf_s(buffer, "Distance = %f\n", fDistance);
		OutputDebugStringA(buffer);
#endif // _DEBUG

		return (fDistance < DEFAULT_OVERLAPPING_DISTANCE);
	}

	ServiceProxy::BuildCommand ^ GetBuildCommand()
	{
		return m_pCommand;
	}

//	virtual Space * Select(uint64 bitMask) = 0;

protected:
	Renderable * m_pRenderable;
	
	// ***************************************************
	// Ratio relative to the entire screen, not just the grid.
	// 
	// Ex: If screen dimensions are 1920 x 1080.
	//   LEFT_MARGIN_RATIO = 0.2
	//   RIGHT_MARGIN_RATIO = 0.2
	//   TOP_MARGIN_RATIO = 0.0
	//   BOTTOM_MARGIN_RATIO = 0.0
	//   NUM_GRID_COLUMNS = 17
	//   NUM_GRID_ROWS = 15
	// 
	// If Space is located at grid location (0,0).
	// 
	// Then, m_fLocationRatio for this space is at
	//   (.2176, 0.0333333).
	// 
	// Relative to the Grid is .0176.
	// However, relative to the entire screen is .2176
	//	due to the LEFT_MARGIN_RATIO.
	// ***************************************************
	float2 m_fLocationRatio;

	float m_fRotationInRadians;

	// Ratio relative to the entire screen, not just the grid.
	float2 m_fDimensionsRatio;

	bool m_bIsVisible;
	bool m_bIsActionable;
	bool m_bIsCollidable;

	shared_ptr<DeviceResources> m_deviceResources;

	// Instead of doing deep copies, store the
	//	build command. This is okay as long
	//	as build commands are stateless????
	ServiceProxy::BuildCommand ^ m_pCommand;

private:
	uint64 uId;

};