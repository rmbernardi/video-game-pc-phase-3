#pragma once
#include "pch.h"
#include "Stack.h"
#include "Region.h"
using namespace std;

class World
{
public:
	World();

	World(String ^ strName)
	{
		m_strName = strName;
	}

	~World();

	void AddRegion(Region * pRegion);

	Region * GetRegion(int id)
	{
		return m_pRegions[id];
	}

	void LoadRegion(int id)
	{
		m_currentRegion = m_pRegions[id];
	}

	Stack * LoadSubdivision(int x, int y)
	{
		return m_currentRegion->LoadSubdivision(x, y);
	}

	// Stairs go to another region.  Think of caves as their own
	//	one room region.
	Region * Go(int regionId);

protected:
	String ^ m_strName;

private:
	map<int, Region *> m_pRegions;
	Region * m_currentRegion;
};
