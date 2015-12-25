#pragma once
#include "Obstacle.h"
#include "VectorGraphic.h"
#include "..\Wireframe\BorderFrame.h"

class Border : public Obstacle
{
public:
	Border(
		float2 pfLocationRatio,
		float fRotationInRadians,
		float2 pfDimensions,
		ServiceProxy::BuildCommand ^ pCommand,
		const shared_ptr<DeviceResources>& deviceResources) :
		Obstacle(
			pfLocationRatio,
			fRotationInRadians,
			pfDimensions,
#ifdef RENDER_DIAGNOSTICS
			true,
#elif // RENDER_DIAGNOSTICS
			false,
#endif // RENDER_DIAGNOSTICS
			false,
			true,
			pCommand,
			deviceResources)
	{
		m_pRenderable = new VectorGraphic(
			deviceResources,
			new BorderFrame());
	}

protected:

private:
};