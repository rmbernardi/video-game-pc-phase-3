﻿/*
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

#include "Sprites\BasicSprites.h"
#include "Sprites\SimpleSprites.h"
#include "Sprites\BasicLoader.h"
#include "IDeviceNotify.h"

using namespace Microsoft::WRL;
using namespace Platform;

// Controls all the DirectX device resources.
class DeviceResources
{
public:
	DeviceResources();
	void SetSwapChainPanel(Windows::UI::Xaml::Controls::SwapChainPanel^ panel);
	void SetLogicalSize(Windows::Foundation::Size logicalSize);
	void SetCurrentOrientation(Windows::Graphics::Display::DisplayOrientations currentOrientation);
	void SetDpi(float dpi);
	float GetDpi() { return m_dpi; }
	void SetCompositionScale(float compositionScaleX, float compositionScaleY);
	void ValidateDevice();
	void HandleDeviceLost();
	void RegisterDeviceNotify(IDeviceNotify* deviceNotify);
	void Trim();
	void Present();
	void Reset();

	// Device Accessors.
	Windows::Foundation::Size GetOutputSize() const					{ return m_outputSize; }
	Windows::Foundation::Size GetLogicalSize() const				{ return m_logicalSize; }

	// D3D Accessors.
	ID3D11Device2*			GetD3DDevice() const					{ return m_d3dDevice.Get(); }
	ID3D11DeviceContext2*	GetD3DDeviceContext() const				{ return m_d3dContext.Get(); }
	IDXGISwapChain1*		GetSwapChain() const					{ return m_swapChain.Get(); }
	D3D_FEATURE_LEVEL		GetDeviceFeatureLevel() const			{ return m_d3dFeatureLevel; }
	ID3D11RenderTargetView*	GetBackBufferRenderTargetView() const	{ return m_d3dRenderTargetView.Get(); }
	ID3D11DepthStencilView* GetDepthStencilView() const				{ return m_d3dDepthStencilView.Get(); }
	D3D11_VIEWPORT			GetScreenViewport() const				{ return m_screenViewport; }
	DirectX::XMFLOAT4X4		GetOrientationTransform3D() const		{ return m_orientationTransform3D; }

	// D2D Accessors.
	ID2D1Factory2*			GetD2DFactory() const					{ return m_d2dFactory.Get(); }
	ID2D1Device1*			GetD2DDevice() const					{ return m_d2dDevice.Get(); }
	ID2D1DeviceContext1*	GetD2DDeviceContext() const				{ return m_d2dContext.Get(); }
	ID2D1Bitmap1*			GetD2DTargetBitmap() const				{ return m_d2dTargetBitmap.Get(); }
	IDWriteFactory2*		GetDWriteFactory() const				{ return m_dwriteFactory.Get();	 }
	IWICImagingFactory2*	GetWicImagingFactory() const			{ return m_wicFactory.Get(); }
	D2D1::Matrix3x2F		GetOrientationTransform2D() const		{ return m_orientationTransform2D; }


//	private:
	void CreateDeviceIndependentResources();
	void CreateDeviceResources();
	void CreateBrushes();

	void CreateWindowSizeDependentResources();
	DXGI_MODE_ROTATION ComputeDisplayRotation();

	// Direct3D objects.
	ComPtr<ID3D11Device2>			m_d3dDevice;
	ComPtr<ID3D11DeviceContext2>	m_d3dContext;
	ComPtr<IDXGISwapChain1>			m_swapChain;

	// Direct3D rendering objects. Required for 3D.
	ComPtr<ID3D11RenderTargetView>	m_d3dRenderTargetView;
	ComPtr<ID3D11DepthStencilView>	m_d3dDepthStencilView;
	D3D11_VIEWPORT									m_screenViewport;

	// Direct2D drawing components.
	ComPtr<ID2D1Factory2>		m_d2dFactory;
	ComPtr<ID2D1Device1>		m_d2dDevice;
	ComPtr<ID2D1DeviceContext1>	m_d2dContext;
	ComPtr<ID2D1Bitmap1>		m_d2dTargetBitmap;

	// DirectWrite drawing components.
	ComPtr<IDWriteFactory2>		m_dwriteFactory;
	ComPtr<IWICImagingFactory2>	m_wicFactory;

	// Cached reference to the XAML panel.
	Windows::UI::Xaml::Controls::SwapChainPanel^    m_swapChainPanel;

	// Cached device properties.
	D3D_FEATURE_LEVEL								m_d3dFeatureLevel;
	Windows::Foundation::Size						m_d3dRenderTargetSize;
	Windows::Foundation::Size						m_outputSize;
	Windows::Foundation::Size						m_logicalSize;
	Windows::Graphics::Display::DisplayOrientations	m_nativeOrientation;
	Windows::Graphics::Display::DisplayOrientations	m_currentOrientation;
	float											m_dpi;
	float											m_compositionScaleX;
	float											m_compositionScaleY;

	// Transforms used for display orientation.
	D2D1::Matrix3x2F	m_orientationTransform2D;
	DirectX::XMFLOAT4X4	m_orientationTransform3D;

	// The IDeviceNotify can be held directly as it owns the DeviceResources.
	IDeviceNotify* m_deviceNotify;

	ComPtr<IDWriteTextFormat>                       m_textFormat;
	ComPtr<ID2D1PathGeometry>                       m_pathGeometry;
	ComPtr<ID2D1PathGeometry>                       m_objectGeometry;

	std::map<String ^, ID2D1SolidColorBrush *>		m_mapBrushes;
	std::map<String ^, ID2D1SolidColorBrush *> GetBrushes() { return m_mapBrushes; }
};