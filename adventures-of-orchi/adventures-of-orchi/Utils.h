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
#include "Grid.h"
#include "Constants.h"
#include "..\Model\Space.h"

using namespace std;
using namespace DirectX;

class Utils
{
public:

	static void ConvertRatioToGridLocations(Grid grid, float2 fLocationRatio, int * column, int * row);

	static void InsertionSortI(int values[], int length);

	// To easily allow for resizing, this should return ratios.
	// The return values are relative to the entire screen.
	//	Thus, 0.f = left edge of the screen.
	//			1.f = right edge of the screen.
	static void CalculateSquareCenter(
		float screenWidth,
		float screenHeight,
		int column,
		int row,
		float * x,
		float * y);

	static void ConvertScreenRatioToGridRatio(float2 fPoint_screen_ratio, float * x, float * y);
	static void ConvertGridRatioToScreenRatio(float2 fPoint_grid_ratio, Grid * pGrid, float * x, float * y);
	static void ConvertGridRatioToGridPixels(float2 fPoint_grid_ratio, Grid * pGrid, float * x, float * y);

	static void InsertionSortF(float values[], int length);
	static float GetMinValue(vector<float> values, int * index);

	static float CalculateDistance(float2 pt, float2 p2);

	static float CalculateSquareHeightRatio(float screenHeight);
	static float CalculateSquareWidthRatio(float screenWidth);

	static boolean IsPointInPolygon(D2D1_POINT_2F pt, vector<D2D1_POINT_2F> * polygon);

	static bool AreOverlapping(Space * s1, Space * s2);
	static bool AreOverlapping(D2D1_RECT_F * pRect, Space * pSpace);

	static int CalculatePixelDistance(
		float2 fLocationRatio1,
		float2 fLocationRatio2,
		float2 fScreenDimensions);

	static float2 UnitPixelToRatio(float2 fScreenDimensions);

	static bool IsPointInEllipse(
		float2 fPoint,
		float2 fEllipseCenter,
		float2 fEllipseDimensions);

	static bool IsPointInRectangle(
		float2 fPoint,
		float2 fRectangleCenter,
		float2 fRectangleDimensions);
};
