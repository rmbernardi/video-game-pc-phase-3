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
#include "..\pch.h"

class SpriteUtils
{
public:
	static uint8_t * ReadPixels(
		ID3D11DeviceContext2 * context,
		ID3D11Device2 * device,
		ID3D11Texture2D * texture,
		int * dimensions);

protected:

private:
};
