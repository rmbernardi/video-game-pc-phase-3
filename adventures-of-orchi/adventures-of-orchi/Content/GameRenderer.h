﻿#pragma once

#include "..\Common\DeviceResources.h"
#include "ShaderStructures.h"
#include "..\Common\StepTimer.h"
#include "Grid.h"
#include "Model\Player.h"
#include "..\Collision\BroadCollisionStrategy.h"
#include "..\Collision\NarrowCollisionStrategy.h"
#include "Model\Stack.h"
#include "..\Collision\PortalCollisionStrategy.h"
#include "..\Model\World.h"
#include "Model\Sword.h"
#include "..\InfoPanel\LifePanel.h"
#include "..\InfoPanel\MapPanel.h"
#include "..\InfoPanel\ButtonsPanel.h"
#include "..\InfoPanel\PackPanel.h"
#include "..\InfoPanel\InventoryPanel.h"
#include "..\InfoPanel\InfoPanel.h"
#include "..\Controller\XBoxOneControllerView.h"
#include "..\Factory\WorldFactory.h"

using namespace Windows::UI::Core;
using namespace std;
using namespace Microsoft::WRL;
using namespace DX;
using namespace Windows::UI::ViewManagement;
using namespace Windows::Graphics::Display;

// This sample renderer instantiates a basic rendering pipeline.
class GameRenderer
{
public:
	GameRenderer(const std::shared_ptr<DeviceResources>& deviceResources, CoreWindow ^ window);
	void OnPointerPressed(ResolutionScale fResolutionScale, float fX, float fY);
	void OnPointerReleased();
	void CreateDeviceDependentResources();
	void CreateWindowSizeDependentResources();
	void ReleaseDeviceDependentResources();
	int Update(DX::StepTimer const& timer);
	void Render();

	void OnKeyDown(KeyEventArgs ^ args);
	void OnSizeChanged(
		WindowSizeChangedEventArgs ^ args,
		UserInteractionMode uiMode);

	void RenderButtonTouchControls();
	void RenderDirectionalTouchControls();

	Grid grid;

	void DrawLeftMargin();
	void DrawRightMargin();

	void SetUserInteractionMode(UserInteractionMode uiMode);
private:
	// TODO: Move these to Sword.
	void ThrowSword(int nDirection);
	void UpdateSword();

	Platform::Agile<CoreWindow> m_window;

	// Cached pointer to device resources.
	std::shared_ptr<DeviceResources> m_deviceResources;

	// Direct3D resources for cube geometry.
	ComPtr<ID3D11InputLayout>	m_inputLayout;
	ComPtr<ID3D11Buffer>		m_vertexBuffer;
	ComPtr<ID3D11Buffer>		m_indexBuffer;
	ComPtr<ID3D11VertexShader>	m_vertexShader;
	ComPtr<ID3D11PixelShader>	m_pixelShader;
	ComPtr<ID3D11Buffer>		m_constantBuffer;

	// System resources for cube geometry.
	ModelViewProjectionConstantBuffer	m_constantBufferData;
	uint32	m_indexCount;

	// Variables used with the rendering loop.
	float	m_degreesPerSecond;

	Stack * m_pCurrentStack;

	void RenderSpaces2D();
	void RenderSpaces3D();

	Player * m_pPlayer;
	Sword * m_pSword;

	float m_fWindowWidth;
	float m_fWindowHeight;

	void DrawSpriteIntersection();
	int m_nCollisionState;

	int m_nCollidedSpriteColumn;
	int m_nCollidedSpriteRow;

	bool m_bSpriteCollisionDetected;

	BroadCollisionStrategy * m_broadCollisionDetectionStrategy;
	NarrowCollisionStrategy * m_pNarrowCollisionDetectionStrategy;
	PortalCollisionStrategy * m_pPortalCollisionDetectionStrategy;

	list<Space *> * m_pCollided;
	void HighlightRegion(int column, int row, ComPtr<ID2D1SolidColorBrush> brush);
	void HighlightRegion(int * pLocation, ComPtr<ID2D1SolidColorBrush> brush);

	DWRITE_TEXT_RANGE m_textRange;

	World * m_pWorld;
	Region * m_pRegion;
	WorldFactory m_worldFactory;

#ifdef RENDER_DIAGNOSTICS
	vector<D2D1_RECT_F> m_collidedRects;
	vector<int> m_collidedRectStatuses;
#endif // RENDER_DIAGNOSTICS

	int m_nSwordDirection;
	LifePanel m_lifePanel;
	MapPanel m_mapPanel;
	ButtonsPanel m_buttonsPanel;
	PackPanel m_packPanel;
	InventoryPanel m_inventoryPanel;

	vector<InfoPanel *> * m_infoPanels;

	XBoxOneControllerView xboxController;
	UserInteractionMode m_uiMode;

	// TODO: Use function pointers:
	bool CheckNorthButton(float2 fHitPoint);
	bool CheckEastButton(float2 fHitPoint);
	bool CheckSouthButton(float2 fHitPoint);
	bool CheckWestButton(float2 fHitPoint);

	bool m_bNorthButtonPressed;
	bool m_bEastButtonPressed;
	bool m_bSouthButtonPressed;
	bool m_bWestButtonPressed;

	bool CheckYButton(float2 fHitPoint);
	bool CheckBButton(float2 fHitPoint);
	bool CheckAButton(float2 fHitPoint);
	bool CheckXButton(float2 fHitPoint);

	bool m_bYButtonPressed;
	bool m_bBButtonPressed;
	bool m_bAButtonPressed;
	bool m_bXButtonPressed;


	// TODO: 
	int m_nOrientation;
};

