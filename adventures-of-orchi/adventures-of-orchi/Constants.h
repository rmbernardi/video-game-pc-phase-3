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


#ifndef NUM_GRID_ROWS 
#define NUM_GRID_ROWS 15
#endif // NUM_GRID_ROWS 

#ifndef NUM_GRID_COLUMNS
#define NUM_GRID_COLUMNS 17
#endif // NUM_GRID_COLUMNS

#ifndef WIDTH_INDEX
#define WIDTH_INDEX 0
#endif // WIDTH_INDEX

#ifndef HEIGHT_INDEX
#define HEIGHT_INDEX 1
#endif // HEIGHT_INDEX

#ifndef MARGIN 
#define MARGIN 0.0f
#endif // MARGIN

//#ifndef SHOW_OVERLAY
//#define SHOW_OVERLAY
//#endif // SHOW_OVERLAY

#ifndef USE_CONTROLLER
#define USE_CONTROLLER
#endif // USE_CONTROLLER

//#ifndef CONTROLLER_RENDERER
//#define CONTROLLER_RENDERER
//#endif // CONTROLLER_RENDERER

#ifndef XINPUT_ENUM_TIMEOUT_MS
#define XINPUT_ENUM_TIMEOUT_MS 2000
#endif // XINPUT_ENUM_TIMEOUT_MS

#ifndef LEFT_MARGIN_RATIO
#define LEFT_MARGIN_RATIO 0.2f
#endif // LEFT_MARGIN_RATIO

#ifndef RIGHT_MARGIN_RATIO
#define RIGHT_MARGIN_RATIO 0.2f
#endif // RIGHT_MARGIN_RATIO

// This represents the percentage of the game screen
//	that is traversed per cycle.
#ifndef PLAYER_MOVE_VELOCITY
#define PLAYER_MOVE_VELOCITY 0.0075f	
#endif // PLAYER_MOVE_VELOCITY

#ifndef CENTER
#define CENTER 4
#endif // CENTER

#ifndef NORTH
#define NORTH 0
#endif // NORTH

#ifndef EAST
#define EAST 1
#endif // EAST 

#ifndef SOUTH
#define SOUTH 2
#endif // SOUTH

#ifndef WEST 
#define WEST 3
#endif // WEST

#ifndef DOWNSTAIRS
#define DOWNSTAIRS 9
#endif // DOWNSTAIRS

#ifndef UPSTAIRS
#define UPSTAIRS 10
#endif // UPSTAIRS

// 5 percent of the screen / second.
#ifndef SCROLLING_VELOCITY
#define SCROLLING_VELOCITY 5
#endif // SCROLLING_VELOCITY

#ifndef NUM_HEART_ROWS 
#define NUM_HEART_ROWS 2
#endif // NUM_HEART_ROWS

#ifndef NUM_HEART_COLUMNS
#define NUM_HEART_COLUMNS 10
#endif // NUM_HEART_COLUMN

#ifndef HEART_PANEL_HEIGHT_RATIO
#define HEART_PANEL_HEIGHT_RATIO 0.075f
#endif // HEART_PANEL_RATIO

#ifndef HEART_PANEL_HEIGHT
#define HEART_PANEL_HEIGHT 75.0f
#endif // HEART_PANEL_HEIGHT

#ifndef SECTION_HEADER_FONT_SIZE
#define SECTION_HEADER_FONT_SIZE 30.0f
#endif // SECTION_HEADER_FONT_SIZE

//#ifndef DISPLAY_CONTROLLER_INPUT
//#define DISPLAY_CONTROLLER_INPUT
//#endif // DISPLAY_CONTROLLER_INPUT

#ifndef PI
#define PI 3.14159265
#endif // PI

#ifndef WALKING_THRESHOLD
#define WALKING_THRESHOLD 5000.f
#endif // WALKING_THRESHOLD

#ifndef RUNNING_THRESHOLD
#define RUNNING_THRESHOLD 30000.f
#endif // RUNNING_THRESHOLD

#ifndef TOTAL_GRID_DIVISIONS
#define TOTAL_GRID_DIVISIONS 1000
#endif // TOTAL_GRID_DIVISIONS

#ifndef HORIZONTAL_AXIS
#define HORIZONTAL_AXIS 0
#endif // HORIZONTAL_AXIS

#ifndef VERTICAL_AXIS
#define VERTICAL_AXIS 1
#endif // VERTICAL_AXIS

#ifndef NUM_DIMENSIONS
#define NUM_DIMENSIONS 2
#endif // NUM_DIMENSIONS

#ifndef TREE_SPRITE
#define TREE_SPRITE 0
#endif // TREE_SPRITE

#ifndef ROCK_SPRITE
#define ROCK_SPRITE 1
#endif // ROCK_SPRITE

#ifndef WATER_SPRITE
#define WATER_SPRITE 2
#endif // WATER_SPRITE

#ifndef GRASS_SPRITE
#define GRASS_SPRITE 3
#endif // GRASS_SPRITE

#ifndef NO_INTERSECTION
#define NO_INTERSECTION 0
#endif // NO_INTERSECTION

#ifndef INTERSECTION
#define INTERSECTION 1
#endif // INTERSECTION

#ifndef COLLISION
#define COLLISION 2
#endif // COLLISION

#ifndef INTERSECTION_LEFT
#define INTERSECTION_LEFT 0
#endif // INTERSECTION_LEFT

#ifndef INTERSECTION_RIGHT
#define INTERSECTION_RIGHT 1
#endif // INTERSECTION_RIGHT

#ifndef INTERSECTION_TOP
#define INTERSECTION_TOP 2
#endif // INTERSECTION_TOP

#ifndef INTERSECTION_BOTTOM
#define INTERSECTION_BOTTOM 3
#endif // INTERSECTION_BOTTOM



#ifndef NUM_RENDER_TARGETS 
#define NUM_RENDER_TARGETS 3
#endif // NUM_RENDER_TARGETS

#ifndef DEFAULT_BACK_BUFFER
#define DEFAULT_BACK_BUFFER 0 
#endif // DEFAULT_BACK_BUFFER

#ifndef WIDE_BACK_BUFFER
#define WIDE_BACK_BUFFER 1
#endif // WIDE_BACK_BUFFER

#ifndef TALL_BACK_BUFFER
#define TALL_BACK_BUFFER 2
#endif // TALL_BACK_BUFFER

#ifndef DEVICE_CONTEXT_2D
#define DEVICE_CONTEXT_2D m_deviceResources->GetD2DDeviceContext()
#endif // DEVICE_CONTEXT_2D

#ifndef DEVICE_2D
#define DEVICE_2D m_deviceResources->GetD2DDeviceContext()
#endif // DEVICE_2D

#ifndef DEVICE_CONTEXT_3D
#define DEVICE_CONTEXT_3D m_deviceResources->GetD3DDeviceContext()
#endif // DEVICE_CONTEXT_3D

#ifndef DEVICE_3D
#define DEVICE_3D m_deviceResources->GetD3DDevice()
#endif // DEVICE_3D


#ifndef NUM_LAYERS
#define NUM_LAYERS 6
#endif // NUM_LAYERS

#ifndef LAYER_PLAYERS
#define LAYER_PLAYERS 0
#endif // LAYER_PLAYERS

#ifndef LAYER_MOVABLES
#define LAYER_MOVABLES 1
#endif // LAYER_MOVABLES

#ifndef LAYER_PORTALS
#define LAYER_PORTALS 2
#endif // LAYER_PORTALS

#ifndef LAYER_COLLIDABLES
#define LAYER_COLLIDABLES 3
#endif // LAYER_COLLIDABLES

#ifndef LAYER_BACKGROUND
#define LAYER_BACKGROUND 4
#endif // LAYER_BACKGROUND 

#ifndef LAYER_2D
#define LAYER_2D 5
#endif // LAYER_2D




#ifndef ADD_EDGE_COMMAND
#define ADD_EDGE_COMMAND 0
#endif // ADD_EDGE_COMMAND

#ifndef ADD_FOREST_COMMAND
#define ADD_FOREST_COMMAND 1
#endif // ADD_FOREST_COMMAND

#ifndef ADD_GRASS_COMMAND
#define ADD_GRASS_COMMAND 2
#endif // ADD_GRASS_COMMAND

#ifndef ADD_ROCK_COMMAND
#define ADD_ROCK_COMMAND 3
#endif // ADD_ROCK_COMMAND

#ifndef ADD_STAIRS_COMMAND
#define ADD_STAIRS_COMMAND 4
#endif // ADD_STAIRS_COMMAND

#ifndef ADD_STONEWALL_COMMAND
#define ADD_STONEWALL_COMMAND 5
#endif // ADD_STONEWALL_COMMAND

#ifndef ADD_TREE_COMMAND
#define ADD_TREE_COMMAND 6
#endif // ADD_TREE_COMMAND

#ifndef ADD_WATER_COMMAND
#define ADD_WATER_COMMAND 7
#endif // ADD_WATER_COMMAND

#ifndef DECLARE_CAVE_COMMAND
#define DECLARE_CAVE_COMMAND 8
#endif // DECLARE_CAVE_COMMAND

#ifndef DECLARE_DUNGEON_COMMAND
#define DECLARE_DUNGEON_COMMAND 9
#endif // DECLARE_SCREEN_COMMAND

#ifndef DECLARE_LAND_COMMAND
#define DECLARE_LAND_COMMAND 10
#endif // DECLARE_LAND_COMMAND

#ifndef DECLARE_LOT_COMMAND
#define DECLARE_LOT_COMMAND 11
#endif // DECLARE_LOT_COMMAND

#ifndef DECLARE_WORLD_COMMAND
#define DECLARE_WORLD_COMMAND 12
#endif // DECLARE_WORLD_COMMAND





#ifndef USE_PORTALS
#define USE_PORTALS
#endif // USE_PORTALS

#ifndef RENDER_DIAGNOSTICS
#define RENDER_DIAGNOSTICS
#endif // RENDER_DIAGNOSTICS

#ifndef BUTTON_SIZE_RATIO
#define BUTTON_SIZE_RATIO 0.025f
#endif // BUTTON_RATIO

#ifndef BUTTON_OFFSET_RATIO
#define BUTTON_OFFSET_RATIO 0.05f
#endif // BUTTON_OFFSET_RATIO

#ifndef INFO_PANEL_HEIGHT_CONSTANT
#define INFO_PANEL_HEIGHT_CONSTANT 5.0f
#endif // INFO_PANEL_HEIGHT_CONSTANT

#ifndef TOUCH_CONTROLS_MIDPOINT_HEIGHT
#define TOUCH_CONTROLS_MIDPOINT_HEIGHT 0.75f
#endif // TOUCH_CONTROLS_MIDPOINT_HEIGHT

#ifndef LANDSCAPE 
#define LANDSCAPE 0
#endif // LANDSCAPE

#ifndef PORTRAIT
#define PORTRAIT 1
#endif // PORTRAIT

#ifndef INFO_PANEL_TOP_SPACING_CONSTANT
#define INFO_PANEL_TOP_SPACING_CONSTANT 0.0325f
#endif // INFO_PANEL_TOP_SPACING_CONSTANT

#ifndef INFO_PANEL_BOTTOM_SPACING_CONSTANT
#define INFO_PANEL_BOTTOM_SPACING_CONSTANT 0.025f
#endif // INFO_PANEL_BOTTOM_SPACING_CONSTANT

#ifndef TEXTURE_SCALE_FACTOR
#define TEXTURE_SCALE_FACTOR 1.0f
#endif // TEXTURE_SCALE_FACTOR

#ifndef DEFAULT_OVERLAPPING_DISTANCE
#define DEFAULT_OVERLAPPING_DISTANCE 0.075f
#endif // DEFAULT_OVERLAPPING_DISTANCE

#ifndef DUNGEON_LINE_WIDTH
#define DUNGEON_LINE_WIDTH 4.0f
#endif // DUNGEON_LINE_WIDTH

#ifndef EDGE_RATIO
#define EDGE_RATIO 0.1f
#endif // EDGE_RATIO

#ifndef UPPER_LEFT
#define UPPER_LEFT 0 
#endif // UPPER_LEFT 

#ifndef UPPER_RIGHT
#define UPPER_RIGHT 1
#endif // UPPER_RIGHT 

#ifndef LOWER_RIGHT
#define LOWER_RIGHT 2
#endif // LOWER_RIGHT

#ifndef LOWER_LEFT
#define LOWER_LEFT 3
#endif // LOWER_LEFT 

#ifndef SKIP_RATIO
#define SKIP_RATIO 0.05f
#endif // SKIP_RATIO

#ifndef ADD_EDGE_COMMAND
#define ADD_EDGE_COMMAND 0
#endif // ADD_EDGE_COMMAND

#ifndef ADD_FOREST_COMMAND
#define ADD_FOREST_COMMAND 1
#endif // ADD_FOREST_COMMAND

#ifndef ADD_GRASS_COMMAND
#define ADD_GRASS_COMMAND 2
#endif // ADD_GRASS_COMMAND

#ifndef ADD_ROCK_COMMAND
#define ADD_ROCK_COMMAND 3
#endif // ADD_ROCK_COMMAND

#ifndef ADD_STAIRS_COMMAND
#define ADD_STAIRS_COMMAND 4
#endif // ADD_STAIRS_COMMAND

#ifndef ADD_STONEWALL_COMMAND
#define ADD_STONEWALL_COMMAND 5
#endif // ADD_STONEWALL_COMMAND

#ifndef ADD_TREE_COMMAND
#define ADD_TREE_COMMAND 6
#endif // ADD_TREE_COMMAND

#ifndef ADD_WATER_COMMAND
#define ADD_WATER_COMMAND 7
#endif // ADD_WATER_COMMAND

#ifndef ADD_CAVE_COMMAND
#define ADD_CAVE_COMMAND 8
#endif // ADD_CAVE_COMMAND

#ifndef DECLARE_DUNGEON_COMMAND
#define DECLARE_DUNGEON_COMMAND 9
#endif // DECLARE_DUNGEON_COMMAND

#ifndef DECLARE_LAND_COMMAND
#define DECLARE_LAND_COMMAND 10
#endif // DECLARE_LAND_COMMAND

#ifndef DECLARE_LOT_COMMAND
#define DECLARE_LOT_COMMAND 11
#endif // DECLARE_LOT_COMMAND

#ifndef DECLARE_WORLD_COMMAND
#define DECLARE_WORLD_COMMAND 12
#endif // DECLARE_WORLD_COMMAND

#ifndef ADD_BORDER_COMMAND
#define ADD_BORDER_COMMAND 13
#endif // ADD_BORDER_COMMAND

#ifndef DECLARE_OVERLAY_COMMAND
#define DECLARE_OVERLAY_COMMAND 14
#endif // DECLARE_OVERLAY_COMMAND

#ifndef END_OVERLAY_COMMAND
#define END_OVERLAY_COMMAND 15
#endif // END_OVERLAY_COMMAND

#ifndef APPLY_OVERLAY_COMMAND
#define APPLY_OVERLAY_COMMAND 16
#endif // APPLY_OVERLAY_COMMAND
