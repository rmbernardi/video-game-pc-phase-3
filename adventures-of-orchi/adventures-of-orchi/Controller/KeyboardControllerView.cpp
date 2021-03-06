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
#include "KeyboardControllerView.h"

void KeyboardControllerView::HandleKeystroke(
	Player * pPlayer, 
	int nCollisionState, 
	String ^ args,
	float fVelocity,
	int * lpnHeading)
{
	if (args == "P")
	{
		// Pause
	}
	else if (args->Equals("Left"))
	{
		pPlayer->MoveWest(fVelocity);
		*lpnHeading = WEST;
	}
	else if (args->Equals("Down"))
	{
		pPlayer->MoveSouth(fVelocity);
		*lpnHeading = SOUTH;
	}
	else if (args->Equals("Right"))
	{
		pPlayer->MoveEast(fVelocity);
		*lpnHeading = EAST;
	}
	else if (args->Equals("Up"))
	{
		pPlayer->MoveNorth(fVelocity);
		*lpnHeading = NORTH;
	}
}

void KeyboardControllerView::OnInput(
	Character * pCharacter,
	KeyEventArgs^ args,
	float2 fHitPoint)
{

}