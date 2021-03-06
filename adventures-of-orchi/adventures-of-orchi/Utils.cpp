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
#include "pch.h"
#include "Utils.h"
#include "Grid.h"
#include "Constants.h"
#include "..\Model\Space.h"

using namespace std;

void Utils::ConvertRatioToGridLocations(Grid grid, float2 fLocationRatio, int * column, int * row)
{
	float fHorizontalUnits =
		(float)TOTAL_GRID_DIVISIONS / (float)grid.GetNumColumns();

	float fVerticalUnits =
		(float)TOTAL_GRID_DIVISIONS / (float)grid.GetNumRows();

	int nHorizontalLocation =
		(int)(fLocationRatio.x * (float)TOTAL_GRID_DIVISIONS) / fHorizontalUnits;

	int nVerticalLocation =
		(int)(fLocationRatio.y * (float)TOTAL_GRID_DIVISIONS) / fVerticalUnits;

	*column = nHorizontalLocation;
	*row = nVerticalLocation;
}

void Utils::InsertionSortI(int values[], int length)
{
	int j, temp;

	for (int i = 0; i < length; i++)
	{
		j = i;

		while (j > 0 && values[j] < values[j - 1])
		{
			temp = values[j];
			values[j] = values[j - 1];
			values[j - 1] = temp;
			j--;
		}
	}
}

// To easily allow for resizing, this should return ratios.
// The return values are relative to the entire screen.
//	Thus, 0.f = left edge of the screen.
//			1.f = right edge of the screen.
/*
void Utils::CalculateSquareCenter(
	float screenWidth,
	float screenHeight,
	int column,
	int row,
	float * x,
	float * y)
{
	float rowHeight = CalculateSquareHeightRatio(screenHeight);
	float columnWidth = CalculateSquareWidthRatio(screenWidth);

	*x = (screenWidth * LEFT_MARGIN_RATIO) + MARGIN + (columnWidth * column) + (columnWidth / 2.0f);
	*y = MARGIN + (rowHeight * row) + (rowHeight / 2.0f);

	*x /= screenWidth;
	*y /= screenHeight;
}
*/
void Utils::CalculateSquareCenter(
	float screenWidth,
	float screenHeight,
	int column,
	int row,
	float * x,
	float * y)
{
	float gridWidth = screenWidth -
		(screenWidth * LEFT_MARGIN_RATIO) -
		(screenWidth * RIGHT_MARGIN_RATIO);

	float rowHeight = (screenHeight - 2.0f * MARGIN) / NUM_GRID_ROWS;
	float columnWidth = (gridWidth - 2.0f * MARGIN) / NUM_GRID_COLUMNS;

	*x = (screenWidth * LEFT_MARGIN_RATIO) + MARGIN + (columnWidth * column) + (columnWidth / 2.0f);
	*y = MARGIN + (rowHeight * row) + (rowHeight / 2.0f);

	*x /= screenWidth;
	*y /= screenHeight;
}

/*
void Utils::CalculateSquareOrigin(
	float fScreenWidth,
	float fScreenHeight,
	int nColumn,
	int nRow,
	float * fXRatio,
	float * fYRatio)
{
	float rowHeight = CalculateSquareHeight(fScreenHeight);
	float columnWidth = CalculateSquareWidth(fScreenWidth);

	*fXRatio = ((fScreenWidth * LEFT_MARGIN_RATIO) + MARGIN + (columnWidth * (float)nColumn)) / fScreenWidth;
	*fYRatio = (MARGIN + (rowHeight * (float)nRow)) / fScreenHeight;
}
*/

float Utils::CalculateSquareHeightRatio(float fScreenHeight)
{
	float fGridHeight =
		fScreenHeight * (1.0f - TOP_MARGIN_RATIO - BOTTOM_MARGIN_RATIO);

	float fSquareRawHeight = fGridHeight / (float)NUM_GRID_ROWS;

	return fSquareRawHeight / fScreenHeight;
}

float Utils::CalculateSquareWidthRatio(float fScreenWidth)
{
	float fGridWidth = 
		fScreenWidth * (1.0f - LEFT_MARGIN_RATIO - RIGHT_MARGIN_RATIO);

	float fSquareRawWidth = fGridWidth / (float)NUM_GRID_COLUMNS;

	return fSquareRawWidth / fScreenWidth;
}

void Utils::ConvertScreenRatioToGridRatio(
	float2 fPoint_screen_ratio,
	float * x,
	float * y)
{
	// globalPt.x is relative then entire width of the screen.
	//	Need to subtract the left margin before converting to 
	//	the correct Grid location.
	*x = (fPoint_screen_ratio.x - LEFT_MARGIN_RATIO) / (1.0f - LEFT_MARGIN_RATIO - RIGHT_MARGIN_RATIO);
	*y = (fPoint_screen_ratio.y - TOP_MARGIN_RATIO) / (1.0f - TOP_MARGIN_RATIO - BOTTOM_MARGIN_RATIO);
}

void Utils::ConvertGridRatioToScreenRatio(
	float2 fPoint_grid_ratio, 
	Grid * pGrid,
	float * x, 
	float * y)
{
	float2 fPoint_screen_px
	{
		(fPoint_grid_ratio.x * pGrid->GetGridWidth()) + (pGrid->GetWindowWidth() * LEFT_MARGIN_RATIO),
		(fPoint_grid_ratio.y * pGrid->GetGridHeight()) + (pGrid->GetWindowHeight() * TOP_MARGIN_RATIO)
	};

	*x = fPoint_screen_px.x / pGrid->GetWindowWidth();
	*y = fPoint_screen_px.y / pGrid->GetWindowHeight();
}

void Utils::ConvertGridRatioToGridPixels(float2 fPoint_grid_ratio, Grid * pGrid, float * x, float * y)
{
	*x = fPoint_grid_ratio.x * pGrid->GetGridWidth();
	*y = fPoint_grid_ratio.y * pGrid->GetGridHeight();
}


void Utils::InsertionSortF(float values[], int length)
{
	int j, temp;

	for (int i = 0; i < length; i++)
	{
		j = i;

		while (j > 0 && values[j] < values[j - 1])
		{
			temp = values[j];
			values[j] = values[j - 1];
			values[j - 1] = temp;
			j--;
		}
	}
}

float Utils::GetMinValue(vector<float> values, int * index)
{
	float retVal = 99999999.f;

	vector<float>::const_iterator iterator;
	int counter = 0;

	for (iterator = values.begin(); iterator != values.end(); iterator++)
	{
		if ((*iterator) < retVal)
		{
			retVal = *iterator;
			*index = counter;
		}

		counter++;
	}

	return retVal;
}

float Utils::CalculateDistance(
	float2 p1, float2 p2)
{
	float deltaX = fabs(p1.x - p2.x);
	float deltaY = fabs(p1.y - p2.y);

	return sqrt((deltaX * deltaX) + (deltaY * deltaY));
}

boolean Utils::IsPointInPolygon(D2D1_POINT_2F pt, vector<D2D1_POINT_2F> * polygon)
{
	return
		((pt.x > polygon->at(UPPER_LEFT).x) && (pt.y > polygon->at(UPPER_LEFT).y)) &&
		((pt.x < polygon->at(UPPER_RIGHT).x) && (pt.y > polygon->at(UPPER_RIGHT).y)) &&
		((pt.x < polygon->at(LOWER_RIGHT).x) && (pt.y < polygon->at(LOWER_RIGHT).y)) &&
		((pt.x > polygon->at(LOWER_LEFT).x) && (pt.y < polygon->at(LOWER_LEFT).y));
}

// This is a two-pass algorithm. 
//	First, check if all the edge points
//	are within the Other.  
//	Then check if any point of the Other is
//	within the Edge.
// By my convention, m_pLocationRatio for the Player
//	is defined as the centroid of the space.
bool Utils::AreOverlapping(Space * s1, Space * s2)
{
	vector<D2D1_POINT_2F> edgeBounds;
	vector<D2D1_POINT_2F> otherBounds;

	edgeBounds.push_back(
		D2D1_POINT_2F
	{
		s1->GetLocationRatio().x - (s1->GetDimensionsRatio().x / 2.0f),
		s1->GetLocationRatio().y - (s1->GetDimensionsRatio().y / 2.0f)
	});

	edgeBounds.push_back(
		D2D1_POINT_2F
	{
		s1->GetLocationRatio().x + (s1->GetDimensionsRatio().x / 2.0f),
		s1->GetLocationRatio().y - (s1->GetDimensionsRatio().y / 2.0f)
	});

	edgeBounds.push_back(
		D2D1_POINT_2F
	{
		s1->GetLocationRatio().x + (s1->GetDimensionsRatio().x / 2.0f),
		s1->GetLocationRatio().y + (s1->GetDimensionsRatio().y / 2.0f)
	});

	edgeBounds.push_back(
		D2D1_POINT_2F
	{
		s1->GetLocationRatio().x - (s1->GetDimensionsRatio().x / 2.0f),
		s1->GetLocationRatio().y + s1->GetDimensionsRatio().y
	});

	otherBounds.push_back(
		D2D1_POINT_2F
	{
		s2->GetLocationRatio().x - (s2->GetDimensionsRatio().x / 2.0f),
		s2->GetLocationRatio().y - (s2->GetDimensionsRatio().y / 2.0f)
	});

	otherBounds.push_back(
		D2D1_POINT_2F
	{
		s2->GetLocationRatio().x + (s2->GetDimensionsRatio().x / 2.0f),
		s2->GetLocationRatio().y - (s2->GetDimensionsRatio().y / 2.0f)
	});

	otherBounds.push_back(
		D2D1_POINT_2F
	{
		s2->GetLocationRatio().x + (s2->GetDimensionsRatio().x / 2.0f),
		s2->GetLocationRatio().y + (s2->GetDimensionsRatio().y / 2.0f)
	});

	otherBounds.push_back(
		D2D1_POINT_2F
	{
		s2->GetLocationRatio().x - (s2->GetDimensionsRatio().x / 2.0f),
		s2->GetLocationRatio().y + (s2->GetDimensionsRatio().y / 2.0f)
	});

	vector<D2D1_POINT_2F>::const_iterator iterator;

	for (iterator = edgeBounds.begin();
	iterator != edgeBounds.end();
		iterator++)
	{
		if (Utils::IsPointInPolygon(*(iterator), &otherBounds))
		{
			return true;
		}
	}

	for (iterator = otherBounds.begin();
	iterator != otherBounds.end();
		iterator++)
	{
		if (Utils::IsPointInPolygon(*(iterator), &edgeBounds))
		{
			return true;
		}
	}

	return false;
}

bool Utils::AreOverlapping(D2D1_RECT_F * pRect, Space * pSpace)
{
	vector<D2D1_POINT_2F> rectBounds;
	vector<D2D1_POINT_2F> spaceBounds;

	rectBounds.push_back(
		D2D1_POINT_2F
	{
		pRect->left,
		pRect->top
	});

	rectBounds.push_back(
		D2D1_POINT_2F
	{
		pRect->right,
		pRect->top
	});

	rectBounds.push_back(
		D2D1_POINT_2F
	{
		pRect->right,
		pRect->bottom
	});

	rectBounds.push_back(
		D2D1_POINT_2F
	{
		pRect->left,
		pRect->bottom
	});

	spaceBounds.push_back(
		D2D1_POINT_2F
	{
		pSpace->GetLocationRatio().x - (pSpace->GetDimensionsRatio().x / 2.0f),
		pSpace->GetLocationRatio().y - (pSpace->GetDimensionsRatio().y / 2.0f)
	});

	spaceBounds.push_back(
		D2D1_POINT_2F
	{
		pSpace->GetLocationRatio().x + (pSpace->GetDimensionsRatio().x / 2.0f),
		pSpace->GetLocationRatio().y - (pSpace->GetDimensionsRatio().y / 2.0f)
	});

	spaceBounds.push_back(
		D2D1_POINT_2F
	{
		pSpace->GetLocationRatio().x + (pSpace->GetDimensionsRatio().x / 2.0f),
		pSpace->GetLocationRatio().y + (pSpace->GetDimensionsRatio().y / 2.0f)
	});

	spaceBounds.push_back(
		D2D1_POINT_2F
	{
		pSpace->GetLocationRatio().x - (pSpace->GetDimensionsRatio().x / 2.0f),
		pSpace->GetLocationRatio().y + (pSpace->GetDimensionsRatio().y / 2.0f)
	});

	vector<D2D1_POINT_2F>::const_iterator iterator;

	for (iterator = rectBounds.begin();
	iterator != rectBounds.end();
		iterator++)
	{
		if (Utils::IsPointInPolygon(*(iterator), &spaceBounds))
		{
			return true;
		}
	}

	for (iterator = spaceBounds.begin();
	iterator != spaceBounds.end();
		iterator++)
	{
		if (Utils::IsPointInPolygon(*(iterator), &rectBounds))
		{
			return true;
		}
	}

	return false;
}

int Utils::CalculatePixelDistance(
	float2 fLocationRatio1,
	float2 fLocationRatio2,
	float2 fScreenDimensions)
{
	float2 fLocationPixel1 = fLocationRatio1 * fScreenDimensions;
	float2 fLocationPixel2 = fLocationRatio2 * fScreenDimensions;

	float fDeltaX = fabs(fLocationPixel1.x - fLocationPixel2.x);
	float fDeltaY = fabs(fLocationPixel1.y - fLocationPixel2.y);

	double fPixelDistance = sqrt(
		(fDeltaX * fDeltaX) +
		(fDeltaY * fDeltaY));

	return (int)ceil(fPixelDistance);
}

// Convert 1 pixel to a ratio.
float2 Utils::UnitPixelToRatio(float2 fScreenDimensions)
{
	return float2{
		1.0f / fScreenDimensions.x,
		1.0f / fScreenDimensions.y
	};
}

bool Utils::IsPointInEllipse(
	float2 fPoint,
	float2 fEllipseCenter,
	float2 fEllipseDimensions)
{
/*
	float fLeftTerm = 0.0f;
	float fRightTerm = 0.0f;

	if (fEllipseDimensions.x > fEllipseDimensions.y)
	{
		// Ellipse is wide.
		fLeftTerm =
			pow(fPoint.x - fEllipseCenter.x, 2.0) / pow(fEllipseDimensions.x, 2.0);

		fRightTerm =
			pow(fPoint.y - fEllipseCenter.y, 2.0f) / pow(fEllipseDimensions.y, 2.0);
	}
	else
	{
		// Ellipse is tall.
		fLeftTerm =
			pow(fPoint.y - fEllipseCenter.x, 2.0) / pow(fEllipseDimensions.x, 2.0);

		fRightTerm =
			pow(fPoint.x - fEllipseCenter.y, 2.0) / pow(fEllipseDimensions.y, 2.0);
	}

	return (fLeftTerm + fRightTerm <= 1.0f);
*/

	return false;
}

bool Utils::IsPointInRectangle(
	float2 fPoint_grid_px,
	float2 fRectangleCenter_grid_px,
	float2 fRectangleDimensions_grid_px)
{
	return (fPoint_grid_px.x <= fRectangleCenter_grid_px.x + fRectangleDimensions_grid_px.x &&
		fPoint_grid_px.x >= fRectangleCenter_grid_px.x - fRectangleDimensions_grid_px.x &&
		fPoint_grid_px.y >= fRectangleCenter_grid_px.y - fRectangleDimensions_grid_px.y &&
		fPoint_grid_px.y <= fRectangleCenter_grid_px.y + fRectangleDimensions_grid_px.y);
}