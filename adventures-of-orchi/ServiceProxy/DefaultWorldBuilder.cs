﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
AddEdgeCommand = 0
AddForestCommand = 1
AddGrassCommand = 2 
AddRockCommand = 3
AddStairsCommand = 4
AddStoneWallCommand = 5
AddTreeCommand = 6
AddWaterCommand = 7
DeclareCaveCommand = 8
DeclareDungeonCommand = 9
DeclareLandCommand = 10
DeclareLotCommand = 11
DeclareWorldCommand = 12
*/
namespace ServiceProxy
{
    public sealed class DefaultWorldBuilder
    {
        public IEnumerable<BuildCommand> Build()
        {
            LinkedList<BuildCommand> commands =
                new LinkedList<BuildCommand>();

            commands.AddLast(new DeclareWorldCommand("Default"));

            commands.AddLast(new DeclareLandCommand("Outside", 5, 5));

            commands.AddLast(new DeclareDungeonCommand("Dungeon1", 5, 5));
            commands.AddLast(new DeclareDungeonCommand("Dungeon2", 5, 5));
            commands.AddLast(new DeclareDungeonCommand("Dungeon3", 5, 5));
            commands.AddLast(new DeclareDungeonCommand("Dungeon4", 5, 5));
            commands.AddLast(new DeclareDungeonCommand("Dungeon5", 5, 5));
            commands.AddLast(new DeclareDungeonCommand("Dungeon6", 5, 5));
            commands.AddLast(new DeclareDungeonCommand("Dungeon7", 5, 5));

            commands.AddLast(new DeclareCaveCommand("CaveGetFirstSword", 1, 1));
            commands.AddLast(new DeclareCaveCommand("Cave1", 5, 5));
            commands.AddLast(new DeclareCaveCommand("Cave2", 5, 5));
            commands.AddLast(new DeclareCaveCommand("Cave3", 5, 5));



            BuildScreen0(commands);
            BuildScreen1(commands);
            BuildScreen2(commands);
            BuildScreen3(commands);
            BuildScreen4(commands);
            BuildScreen5(commands);
            BuildScreen6(commands);
            BuildScreen7(commands);
            BuildScreen8(commands);
            BuildScreen9(commands);
            BuildScreen10(commands);
            BuildScreen11(commands);
            BuildScreen12(commands);
            BuildScreen13(commands);
            BuildScreen14(commands);
            BuildScreen15(commands);
            BuildScreen16(commands);
            BuildScreen17(commands);
            BuildScreen18(commands);
            BuildScreen19(commands);
            BuildScreen20(commands);
            BuildScreen21(commands);
            BuildScreen22(commands);
            BuildScreen23(commands);
            BuildScreen24(commands);

            BuildScreen25(commands);

            //SemanticCheckCommands(commands);
            return commands;
        }

        private void BuildScreen0(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand("Outside", 0, 0));

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));
            commands.AddLast(new AddTreeCommand(2, 7, 0));
            commands.AddLast(new AddTreeCommand(2, 8, 0));
            commands.AddLast(new AddTreeCommand(2, 9, 0));
            commands.AddLast(new AddTreeCommand(2, 10, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));
            commands.AddLast(new AddTreeCommand(2, 7, 1));
            commands.AddLast(new AddTreeCommand(2, 8, 1));
            commands.AddLast(new AddTreeCommand(2, 9, 1));
            commands.AddLast(new AddTreeCommand(2, 10, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));

            commands.AddLast(new AddTreeCommand(2, 0, 5));
            commands.AddLast(new AddTreeCommand(2, 1, 5));
            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));

            commands.AddLast(new AddTreeCommand(2, 0, 6));
            commands.AddLast(new AddTreeCommand(2, 1, 6));
            commands.AddLast(new AddTreeCommand(2, 2, 6));

            commands.AddLast(new AddTreeCommand(2, 0, 7));
            commands.AddLast(new AddTreeCommand(2, 0, 8));

            commands.AddLast(new AddTreeCommand(2, 1, 7));
            commands.AddLast(new AddTreeCommand(2, 1, 8));



            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(2, 13, 5));
            commands.AddLast(new AddTreeCommand(2, 14, 5));
            commands.AddLast(new AddTreeCommand(2, 15, 5));
            commands.AddLast(new AddTreeCommand(2, 16, 5));


            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));
            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 4, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));
            commands.AddLast(new AddTreeCommand(2, 2, 10));
            commands.AddLast(new AddTreeCommand(2, 3, 10));
            commands.AddLast(new AddTreeCommand(2, 4, 10));
            commands.AddLast(new AddTreeCommand(2, 5, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));
            commands.AddLast(new AddTreeCommand(2, 4, 11));
            commands.AddLast(new AddTreeCommand(2, 5, 11));
            commands.AddLast(new AddTreeCommand(2, 6, 11));

            commands.AddLast(new AddWaterCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));
            commands.AddLast(new AddTreeCommand(2, 4, 12));
            commands.AddLast(new AddTreeCommand(2, 5, 12));
            commands.AddLast(new AddTreeCommand(2, 6, 12));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));


            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));


            commands.AddLast(new AddEdgeCommand(4, 16, 6, 1, 1));
            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 1));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 1));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 5));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 5));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 5));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 5));
        }

        private void BuildScreen1(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(1, 0));

            commands.AddLast(new AddStoneWallCommand(2, 0, 0));
            commands.AddLast(new AddStoneWallCommand(2, 1, 0));
            commands.AddLast(new AddStoneWallCommand(2, 2, 0));
            commands.AddLast(new AddStoneWallCommand(2, 3, 0));
            commands.AddLast(new AddStoneWallCommand(2, 4, 0));
            commands.AddLast(new AddStoneWallCommand(2, 5, 0));
            commands.AddLast(new AddStoneWallCommand(2, 6, 0));
            commands.AddLast(new AddStoneWallCommand(2, 7, 0));
            commands.AddLast(new AddStoneWallCommand(2, 8, 0));
            commands.AddLast(new AddStoneWallCommand(2, 9, 0));
            commands.AddLast(new AddStoneWallCommand(2, 10, 0));
            commands.AddLast(new AddStoneWallCommand(2, 11, 0));
            commands.AddLast(new AddStoneWallCommand(2, 12, 0));
            commands.AddLast(new AddStoneWallCommand(2, 13, 0));
            commands.AddLast(new AddStoneWallCommand(2, 14, 0));
            commands.AddLast(new AddStoneWallCommand(2, 15, 0));
            commands.AddLast(new AddStoneWallCommand(2, 16, 0));

            commands.AddLast(new AddStoneWallCommand(2, 0, 1));
            commands.AddLast(new AddStoneWallCommand(2, 1, 1));
            commands.AddLast(new AddStoneWallCommand(2, 2, 1));
            commands.AddLast(new AddStoneWallCommand(2, 3, 1));
            commands.AddLast(new AddStoneWallCommand(2, 4, 1));
            commands.AddLast(new AddStoneWallCommand(2, 5, 1));
            commands.AddLast(new AddStoneWallCommand(2, 6, 1));
            commands.AddLast(new AddStoneWallCommand(2, 7, 1));
            commands.AddLast(new AddStoneWallCommand(2, 8, 1));
            commands.AddLast(new AddStoneWallCommand(2, 9, 1));
            commands.AddLast(new AddStoneWallCommand(2, 10, 1));
            commands.AddLast(new AddStoneWallCommand(2, 11, 1));
            commands.AddLast(new AddStoneWallCommand(2, 12, 1));
            commands.AddLast(new AddStoneWallCommand(2, 13, 1));
            commands.AddLast(new AddStoneWallCommand(2, 14, 1));
            commands.AddLast(new AddStoneWallCommand(2, 15, 1));
            commands.AddLast(new AddStoneWallCommand(2, 16, 1));

            commands.AddLast(new AddStoneWallCommand(2, 0, 2));
            commands.AddLast(new AddStoneWallCommand(2, 1, 2));
            commands.AddLast(new AddStoneWallCommand(2, 15, 2));
            commands.AddLast(new AddStoneWallCommand(2, 16, 2));

            commands.AddLast(new AddStoneWallCommand(2, 0, 3));
            commands.AddLast(new AddStoneWallCommand(2, 1, 3));
            commands.AddLast(new AddStoneWallCommand(2, 15, 3));
            commands.AddLast(new AddStoneWallCommand(2, 16, 3));

            commands.AddLast(new AddStoneWallCommand(2, 0, 4));
            commands.AddLast(new AddStoneWallCommand(2, 1, 4));
            commands.AddLast(new AddStoneWallCommand(2, 15, 4));
            commands.AddLast(new AddStoneWallCommand(2, 16, 4));

            commands.AddLast(new AddStoneWallCommand(2, 0, 5));
            commands.AddLast(new AddStoneWallCommand(2, 1, 5));
            commands.AddLast(new AddStoneWallCommand(2, 15, 5));
            commands.AddLast(new AddStoneWallCommand(2, 16, 5));


            commands.AddLast(new AddStoneWallCommand(2, 0, 9));
            commands.AddLast(new AddStoneWallCommand(2, 1, 9));
            commands.AddLast(new AddStoneWallCommand(2, 15, 9));
            commands.AddLast(new AddStoneWallCommand(2, 16, 9));

            commands.AddLast(new AddStoneWallCommand(2, 0, 10));
            commands.AddLast(new AddStoneWallCommand(2, 1, 10));
            commands.AddLast(new AddStoneWallCommand(2, 15, 10));
            commands.AddLast(new AddStoneWallCommand(2, 16, 10));

            commands.AddLast(new AddStoneWallCommand(2, 0, 11));
            commands.AddLast(new AddStoneWallCommand(2, 1, 11));
            commands.AddLast(new AddStoneWallCommand(2, 15, 11));
            commands.AddLast(new AddStoneWallCommand(2, 16, 11));

            commands.AddLast(new AddStoneWallCommand(2, 0, 12));
            commands.AddLast(new AddStoneWallCommand(2, 1, 12));
            commands.AddLast(new AddStoneWallCommand(2, 15, 12));
            commands.AddLast(new AddStoneWallCommand(2, 16, 12));

            commands.AddLast(new AddStoneWallCommand(2, 0, 13));
            commands.AddLast(new AddStoneWallCommand(2, 1, 13));
            commands.AddLast(new AddStoneWallCommand(2, 15, 13));
            commands.AddLast(new AddStoneWallCommand(2, 16, 13));



            commands.AddLast(new AddStoneWallCommand(2, 0, 13));
            commands.AddLast(new AddStoneWallCommand(2, 1, 13));
            commands.AddLast(new AddStoneWallCommand(2, 2, 13));
            commands.AddLast(new AddStoneWallCommand(2, 3, 13));
            commands.AddLast(new AddStoneWallCommand(2, 4, 13));
            commands.AddLast(new AddStoneWallCommand(2, 5, 13));
            commands.AddLast(new AddStoneWallCommand(2, 6, 13));
            commands.AddLast(new AddStoneWallCommand(2, 10, 13));
            commands.AddLast(new AddStoneWallCommand(2, 11, 13));
            commands.AddLast(new AddStoneWallCommand(2, 12, 13));
            commands.AddLast(new AddStoneWallCommand(2, 13, 13));
            commands.AddLast(new AddStoneWallCommand(2, 14, 13));
            commands.AddLast(new AddStoneWallCommand(2, 15, 13));

            commands.AddLast(new AddStoneWallCommand(2, 0, 14));
            commands.AddLast(new AddStoneWallCommand(2, 1, 14));
            commands.AddLast(new AddStoneWallCommand(2, 2, 14));
            commands.AddLast(new AddStoneWallCommand(2, 3, 14));
            commands.AddLast(new AddStoneWallCommand(2, 4, 14));
            commands.AddLast(new AddStoneWallCommand(2, 5, 14));
            commands.AddLast(new AddStoneWallCommand(2, 6, 14));
            commands.AddLast(new AddStoneWallCommand(2, 10, 14));
            commands.AddLast(new AddStoneWallCommand(2, 11, 14));
            commands.AddLast(new AddStoneWallCommand(2, 12, 14));
            commands.AddLast(new AddStoneWallCommand(2, 13, 14));
            commands.AddLast(new AddStoneWallCommand(2, 14, 14));
            commands.AddLast(new AddStoneWallCommand(2, 15, 14));

            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 7, 3));
            commands.AddLast(new AddTreeCommand(2, 9, 3));
            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));

            commands.AddLast(new AddTreeCommand(2, 3, 5));
            commands.AddLast(new AddTreeCommand(2, 5, 5));
            commands.AddLast(new AddTreeCommand(2, 7, 5));
            commands.AddLast(new AddTreeCommand(2, 9, 5));
            commands.AddLast(new AddTreeCommand(2, 11, 5));
            commands.AddLast(new AddTreeCommand(2, 13, 5));

            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 5, 9));
            commands.AddLast(new AddTreeCommand(2, 7, 9));
            commands.AddLast(new AddTreeCommand(2, 9, 9));
            commands.AddLast(new AddTreeCommand(2, 11, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));

            commands.AddLast(new AddTreeCommand(2, 3, 11));
            commands.AddLast(new AddTreeCommand(2, 5, 11));
            commands.AddLast(new AddTreeCommand(2, 7, 11));
            commands.AddLast(new AddTreeCommand(2, 9, 11));
            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));



            commands.AddLast(new AddEdgeCommand(4, 0, 6, 3, 0));
            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 0));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 0));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 6));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 6));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 6));

            commands.AddLast(new AddEdgeCommand(4, 16, 6, 1, 2));
            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 2));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 2));
        }

        private void BuildScreen2(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(2, 0));

            commands.AddLast(new AddStoneWallCommand(2, 0, 0));
            commands.AddLast(new AddStoneWallCommand(2, 1, 0));
            commands.AddLast(new AddStoneWallCommand(2, 2, 0));
            commands.AddLast(new AddStoneWallCommand(2, 3, 0));
            commands.AddLast(new AddStoneWallCommand(2, 4, 0));
            commands.AddLast(new AddStoneWallCommand(2, 5, 0));
            commands.AddLast(new AddStoneWallCommand(2, 6, 0));
            commands.AddLast(new AddStoneWallCommand(2, 7, 0));
            commands.AddLast(new AddStoneWallCommand(2, 8, 0));
            commands.AddLast(new AddStoneWallCommand(2, 9, 0));
            commands.AddLast(new AddStoneWallCommand(2, 10, 0));
            commands.AddLast(new AddStoneWallCommand(2, 11, 0));
            commands.AddLast(new AddStoneWallCommand(2, 12, 0));
            commands.AddLast(new AddStoneWallCommand(2, 13, 0));
            commands.AddLast(new AddStoneWallCommand(2, 14, 0));
            commands.AddLast(new AddStoneWallCommand(2, 15, 0));
            commands.AddLast(new AddStoneWallCommand(2, 16, 0));

            commands.AddLast(new AddStoneWallCommand(2, 0, 1));
            commands.AddLast(new AddStoneWallCommand(2, 1, 1));
            commands.AddLast(new AddStoneWallCommand(2, 2, 1));
            commands.AddLast(new AddStoneWallCommand(2, 3, 1));
            commands.AddLast(new AddStoneWallCommand(2, 4, 1));
            commands.AddLast(new AddStoneWallCommand(2, 5, 1));
            commands.AddLast(new AddStoneWallCommand(2, 6, 1));
            commands.AddLast(new AddStoneWallCommand(2, 7, 1));
            commands.AddLast(new AddStoneWallCommand(2, 8, 1));
            commands.AddLast(new AddStoneWallCommand(2, 9, 1));
            commands.AddLast(new AddStoneWallCommand(2, 10, 1));
            commands.AddLast(new AddStoneWallCommand(2, 11, 1));
            commands.AddLast(new AddStoneWallCommand(2, 12, 1));
            commands.AddLast(new AddStoneWallCommand(2, 13, 1));
            commands.AddLast(new AddStoneWallCommand(2, 14, 1));
            commands.AddLast(new AddStoneWallCommand(2, 15, 1));
            commands.AddLast(new AddStoneWallCommand(2, 16, 1));

            commands.AddLast(new AddStoneWallCommand(2, 0, 2));
            commands.AddLast(new AddStoneWallCommand(2, 1, 2));
            commands.AddLast(new AddWaterCommand(2, 15, 2));
            commands.AddLast(new AddWaterCommand(2, 16, 2));

            commands.AddLast(new AddStoneWallCommand(2, 0, 3));
            commands.AddLast(new AddStoneWallCommand(2, 1, 3));
            commands.AddLast(new AddStoneWallCommand(2, 15, 3));
            commands.AddLast(new AddStoneWallCommand(2, 16, 3));

            commands.AddLast(new AddStoneWallCommand(2, 0, 4));
            commands.AddLast(new AddStoneWallCommand(2, 1, 4));
            commands.AddLast(new AddStoneWallCommand(2, 15, 4));
            commands.AddLast(new AddStoneWallCommand(2, 16, 4));

            commands.AddLast(new AddStoneWallCommand(2, 0, 5));
            commands.AddLast(new AddStoneWallCommand(2, 1, 5));
            commands.AddLast(new AddStoneWallCommand(2, 15, 5));
            commands.AddLast(new AddStoneWallCommand(2, 16, 5));

            commands.AddLast(new AddStoneWallCommand(2, 15, 6));
            commands.AddLast(new AddStoneWallCommand(2, 16, 6));

            commands.AddLast(new AddStoneWallCommand(2, 15, 7));
            commands.AddLast(new AddStoneWallCommand(2, 16, 7));

            commands.AddLast(new AddStoneWallCommand(2, 15, 8));
            commands.AddLast(new AddStoneWallCommand(2, 16, 8));


            commands.AddLast(new AddStoneWallCommand(2, 0, 9));
            commands.AddLast(new AddStoneWallCommand(2, 1, 9));
            commands.AddLast(new AddStoneWallCommand(2, 15, 9));
            commands.AddLast(new AddStoneWallCommand(2, 16, 9));

            commands.AddLast(new AddStoneWallCommand(2, 0, 10));
            commands.AddLast(new AddStoneWallCommand(2, 1, 10));
            commands.AddLast(new AddStoneWallCommand(2, 15, 10));
            commands.AddLast(new AddStoneWallCommand(2, 16, 10));

            commands.AddLast(new AddStoneWallCommand(2, 0, 11));
            commands.AddLast(new AddStoneWallCommand(2, 1, 11));
            commands.AddLast(new AddStoneWallCommand(2, 15, 11));
            commands.AddLast(new AddStoneWallCommand(2, 16, 11));

            commands.AddLast(new AddStoneWallCommand(2, 0, 12));
            commands.AddLast(new AddStoneWallCommand(2, 1, 12));
            commands.AddLast(new AddStoneWallCommand(2, 15, 12));
            commands.AddLast(new AddStoneWallCommand(2, 16, 12));

            commands.AddLast(new AddStoneWallCommand(2, 0, 13));
            commands.AddLast(new AddStoneWallCommand(2, 1, 13));
            commands.AddLast(new AddStoneWallCommand(2, 15, 13));
            commands.AddLast(new AddStoneWallCommand(2, 16, 13));



            commands.AddLast(new AddStoneWallCommand(2, 0, 13));
            commands.AddLast(new AddStoneWallCommand(2, 1, 13));
            commands.AddLast(new AddStoneWallCommand(2, 2, 13));
            commands.AddLast(new AddStoneWallCommand(2, 3, 13));
            commands.AddLast(new AddStoneWallCommand(2, 4, 13));
            commands.AddLast(new AddStoneWallCommand(2, 5, 13));
            commands.AddLast(new AddStoneWallCommand(2, 6, 13));
            commands.AddLast(new AddStoneWallCommand(2, 7, 13));
            commands.AddLast(new AddStoneWallCommand(2, 8, 13));
            commands.AddLast(new AddStoneWallCommand(2, 9, 13));
            commands.AddLast(new AddStoneWallCommand(2, 10, 13));
            commands.AddLast(new AddWaterCommand(2, 11, 13));
            commands.AddLast(new AddWaterCommand(2, 12, 13));
            commands.AddLast(new AddWaterCommand(2, 13, 13));
            commands.AddLast(new AddStoneWallCommand(2, 14, 13));
            commands.AddLast(new AddStoneWallCommand(2, 15, 13));

            commands.AddLast(new AddStoneWallCommand(2, 0, 14));
            commands.AddLast(new AddStoneWallCommand(2, 1, 14));
            commands.AddLast(new AddStoneWallCommand(2, 2, 14));
            commands.AddLast(new AddStoneWallCommand(2, 3, 14));
            commands.AddLast(new AddStoneWallCommand(2, 4, 14));
            commands.AddLast(new AddStoneWallCommand(2, 5, 14));
            commands.AddLast(new AddStoneWallCommand(2, 6, 14));
            commands.AddLast(new AddStoneWallCommand(2, 7, 14));
            commands.AddLast(new AddStoneWallCommand(2, 8, 14));
            commands.AddLast(new AddStoneWallCommand(2, 9, 14));
            commands.AddLast(new AddStoneWallCommand(2, 10, 14));
            commands.AddLast(new AddWaterCommand(2, 11, 14));
            commands.AddLast(new AddWaterCommand(2, 12, 14));
            commands.AddLast(new AddWaterCommand(2, 13, 14));
            commands.AddLast(new AddStoneWallCommand(2, 14, 14));
            commands.AddLast(new AddStoneWallCommand(2, 15, 14));
            commands.AddLast(new AddStoneWallCommand(2, 16, 14));




            commands.AddLast(new AddWaterCommand(2, 2, 2));
            commands.AddLast(new AddWaterCommand(2, 3, 2));
            commands.AddLast(new AddWaterCommand(2, 4, 2));
            commands.AddLast(new AddWaterCommand(2, 5, 2));
            commands.AddLast(new AddWaterCommand(2, 6, 2));
            commands.AddLast(new AddWaterCommand(2, 7, 2));
            commands.AddLast(new AddWaterCommand(2, 8, 2));
            commands.AddLast(new AddWaterCommand(2, 9, 2));
            commands.AddLast(new AddWaterCommand(2, 10, 2));
            commands.AddLast(new AddWaterCommand(2, 11, 2));
            commands.AddLast(new AddWaterCommand(2, 12, 2));
            commands.AddLast(new AddWaterCommand(2, 13, 2));
            commands.AddLast(new AddWaterCommand(2, 14, 2));

            commands.AddLast(new AddWaterCommand(2, 2, 3));
            commands.AddLast(new AddWaterCommand(2, 3, 3));
            commands.AddLast(new AddWaterCommand(2, 4, 3));
            commands.AddLast(new AddWaterCommand(2, 5, 3));
            commands.AddLast(new AddWaterCommand(2, 6, 3));
            commands.AddLast(new AddWaterCommand(2, 7, 3));
            commands.AddLast(new AddWaterCommand(2, 8, 3));
            commands.AddLast(new AddWaterCommand(2, 9, 3));
            commands.AddLast(new AddWaterCommand(2, 10, 3));
            commands.AddLast(new AddWaterCommand(2, 11, 3));
            commands.AddLast(new AddWaterCommand(2, 12, 3));
            commands.AddLast(new AddWaterCommand(2, 13, 3));
            commands.AddLast(new AddWaterCommand(2, 14, 3));

            commands.AddLast(new AddWaterCommand(2, 2, 4));
            commands.AddLast(new AddWaterCommand(2, 3, 4));
            commands.AddLast(new AddWaterCommand(2, 4, 4));
            commands.AddLast(new AddWaterCommand(2, 5, 4));
            commands.AddLast(new AddWaterCommand(2, 6, 4));
            commands.AddLast(new AddWaterCommand(2, 7, 4));
            commands.AddLast(new AddWaterCommand(2, 8, 4));
            commands.AddLast(new AddWaterCommand(2, 9, 4));
            commands.AddLast(new AddWaterCommand(2, 10, 4));
            commands.AddLast(new AddWaterCommand(2, 11, 4));
            commands.AddLast(new AddWaterCommand(2, 12, 4));
            commands.AddLast(new AddWaterCommand(2, 13, 4));
            commands.AddLast(new AddWaterCommand(2, 14, 4));

            commands.AddLast(new AddWaterCommand(2, 2, 5));
            commands.AddLast(new AddWaterCommand(2, 3, 5));
            commands.AddLast(new AddWaterCommand(2, 4, 5));
            commands.AddLast(new AddWaterCommand(2, 5, 5));
            commands.AddLast(new AddWaterCommand(2, 6, 5));
            commands.AddLast(new AddWaterCommand(2, 10, 5));
            commands.AddLast(new AddWaterCommand(2, 11, 5));
            commands.AddLast(new AddWaterCommand(2, 12, 5));
            commands.AddLast(new AddWaterCommand(2, 13, 5));
            commands.AddLast(new AddWaterCommand(2, 14, 5));





            commands.AddLast(new AddWaterCommand(2, 2, 9));
            commands.AddLast(new AddWaterCommand(2, 3, 9));
            commands.AddLast(new AddWaterCommand(2, 4, 9));
            commands.AddLast(new AddWaterCommand(2, 5, 9));
            commands.AddLast(new AddWaterCommand(2, 6, 9));
            commands.AddLast(new AddWaterCommand(2, 10, 9));
            commands.AddLast(new AddWaterCommand(2, 11, 9));
            commands.AddLast(new AddWaterCommand(2, 12, 9));
            commands.AddLast(new AddWaterCommand(2, 13, 9));
            commands.AddLast(new AddWaterCommand(2, 14, 9));

            commands.AddLast(new AddWaterCommand(2, 2, 10));
            commands.AddLast(new AddWaterCommand(2, 3, 10));
            commands.AddLast(new AddWaterCommand(2, 4, 10));
            commands.AddLast(new AddWaterCommand(2, 5, 10));
            commands.AddLast(new AddWaterCommand(2, 6, 10));
            commands.AddLast(new AddWaterCommand(2, 7, 10));
            commands.AddLast(new AddWaterCommand(2, 8, 10));
            commands.AddLast(new AddWaterCommand(2, 9, 10));
            commands.AddLast(new AddWaterCommand(2, 10, 10));
            commands.AddLast(new AddWaterCommand(2, 11, 10));
            commands.AddLast(new AddWaterCommand(2, 12, 10));
            commands.AddLast(new AddWaterCommand(2, 13, 10));
            commands.AddLast(new AddWaterCommand(2, 14, 10));

            commands.AddLast(new AddWaterCommand(2, 2, 11));
            commands.AddLast(new AddWaterCommand(2, 3, 11));
            commands.AddLast(new AddWaterCommand(2, 4, 11));
            commands.AddLast(new AddWaterCommand(2, 5, 11));
            commands.AddLast(new AddWaterCommand(2, 6, 11));
            commands.AddLast(new AddWaterCommand(2, 7, 11));
            commands.AddLast(new AddWaterCommand(2, 8, 11));
            commands.AddLast(new AddWaterCommand(2, 9, 11));
            commands.AddLast(new AddWaterCommand(2, 10, 11));
            commands.AddLast(new AddWaterCommand(2, 11, 11));
            commands.AddLast(new AddWaterCommand(2, 12, 11));
            commands.AddLast(new AddWaterCommand(2, 13, 11));
            commands.AddLast(new AddWaterCommand(2, 14, 11));

            commands.AddLast(new AddWaterCommand(2, 2, 12));
            commands.AddLast(new AddWaterCommand(2, 3, 12));
            commands.AddLast(new AddWaterCommand(2, 4, 12));
            commands.AddLast(new AddWaterCommand(2, 5, 12));
            commands.AddLast(new AddWaterCommand(2, 6, 12));
            commands.AddLast(new AddWaterCommand(2, 7, 12));
            commands.AddLast(new AddWaterCommand(2, 8, 12));
            commands.AddLast(new AddWaterCommand(2, 9, 12));
            commands.AddLast(new AddWaterCommand(2, 10, 12));
            commands.AddLast(new AddWaterCommand(2, 11, 12));
            commands.AddLast(new AddWaterCommand(2, 12, 12));
            commands.AddLast(new AddWaterCommand(2, 13, 12));
            commands.AddLast(new AddWaterCommand(2, 14, 12));


            commands.AddLast(new AddRockCommand(2, 0, 6));
            commands.AddLast(new AddRockCommand(2, 1, 6));
            commands.AddLast(new AddRockCommand(2, 2, 6));
            commands.AddLast(new AddRockCommand(2, 3, 6));
            commands.AddLast(new AddRockCommand(2, 4, 6));
            commands.AddLast(new AddRockCommand(2, 5, 6));
            commands.AddLast(new AddRockCommand(2, 6, 6));
            commands.AddLast(new AddRockCommand(2, 7, 5));
            commands.AddLast(new AddRockCommand(2, 8, 5));
            commands.AddLast(new AddRockCommand(2, 9, 5));
            commands.AddLast(new AddRockCommand(2, 10, 6));

            commands.AddLast(new AddRockCommand(2, 10, 7));

            commands.AddLast(new AddRockCommand(2, 0, 8));
            commands.AddLast(new AddRockCommand(2, 1, 8));
            commands.AddLast(new AddRockCommand(2, 2, 8));
            commands.AddLast(new AddRockCommand(2, 3, 8));
            commands.AddLast(new AddRockCommand(2, 4, 8));
            commands.AddLast(new AddRockCommand(2, 5, 8));
            commands.AddLast(new AddRockCommand(2, 6, 8));
            commands.AddLast(new AddRockCommand(2, 7, 9));
            commands.AddLast(new AddRockCommand(2, 8, 9));
            commands.AddLast(new AddRockCommand(2, 9, 9));
            commands.AddLast(new AddRockCommand(2, 10, 8));


            commands.AddLast(new AddWaterCommand(2, 11, 6));
            commands.AddLast(new AddWaterCommand(2, 12, 6));
            commands.AddLast(new AddWaterCommand(2, 13, 6));
            commands.AddLast(new AddWaterCommand(2, 14, 6));

            commands.AddLast(new AddWaterCommand(2, 11, 7));
            commands.AddLast(new AddWaterCommand(2, 12, 7));
            commands.AddLast(new AddWaterCommand(2, 13, 7));
            commands.AddLast(new AddWaterCommand(2, 14, 7));

            commands.AddLast(new AddWaterCommand(2, 11, 8));
            commands.AddLast(new AddWaterCommand(2, 12, 8));
            commands.AddLast(new AddWaterCommand(2, 13, 8));
            commands.AddLast(new AddWaterCommand(2, 14, 8));












            commands.AddLast(new AddEdgeCommand(4, 0, 6, 3, 1));
            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 1));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 1));


        }

        private void BuildScreen3(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(3, 0));

            commands.AddLast(new AddStoneWallCommand(2, 0, 0));
            commands.AddLast(new AddStoneWallCommand(2, 1, 0));
            commands.AddLast(new AddStoneWallCommand(2, 2, 0));
            commands.AddLast(new AddStoneWallCommand(2, 3, 0));
            commands.AddLast(new AddStoneWallCommand(2, 4, 0));
            commands.AddLast(new AddStoneWallCommand(2, 5, 0));
            commands.AddLast(new AddStoneWallCommand(2, 6, 0));
            commands.AddLast(new AddStoneWallCommand(2, 7, 0));
            commands.AddLast(new AddStoneWallCommand(2, 8, 0));
            commands.AddLast(new AddStoneWallCommand(2, 9, 0));
            commands.AddLast(new AddStoneWallCommand(2, 10, 0));
            commands.AddLast(new AddStoneWallCommand(2, 11, 0));
            commands.AddLast(new AddStoneWallCommand(2, 12, 0));
            commands.AddLast(new AddStoneWallCommand(2, 13, 0));
            commands.AddLast(new AddStoneWallCommand(2, 14, 0));
            commands.AddLast(new AddStoneWallCommand(2, 15, 0));
            commands.AddLast(new AddStoneWallCommand(2, 16, 0));

            commands.AddLast(new AddWaterCommand(2, 0, 1));
            commands.AddLast(new AddWaterCommand(2, 1, 1));
            commands.AddLast(new AddWaterCommand(2, 2, 1));
            commands.AddLast(new AddWaterCommand(2, 3, 1));
            commands.AddLast(new AddWaterCommand(2, 4, 1));
            commands.AddLast(new AddWaterCommand(2, 5, 1));
            commands.AddLast(new AddWaterCommand(2, 6, 1));
            commands.AddLast(new AddWaterCommand(2, 7, 1));
            commands.AddLast(new AddWaterCommand(2, 8, 1));
            commands.AddLast(new AddWaterCommand(2, 9, 1));
            commands.AddLast(new AddWaterCommand(2, 10, 1));
            commands.AddLast(new AddWaterCommand(2, 11, 1));
            commands.AddLast(new AddWaterCommand(2, 12, 1));
            commands.AddLast(new AddWaterCommand(2, 13, 1));
            commands.AddLast(new AddWaterCommand(2, 14, 1));
            commands.AddLast(new AddWaterCommand(2, 15, 1));
            commands.AddLast(new AddStoneWallCommand(2, 16, 1));

            commands.AddLast(new AddWaterCommand(2, 0, 2));
            commands.AddLast(new AddWaterCommand(2, 1, 2));
            commands.AddLast(new AddWaterCommand(2, 2, 2));
            commands.AddLast(new AddWaterCommand(2, 3, 2));
            commands.AddLast(new AddWaterCommand(2, 4, 2));
            commands.AddLast(new AddWaterCommand(2, 5, 2));
            commands.AddLast(new AddWaterCommand(2, 6, 2));
            commands.AddLast(new AddWaterCommand(2, 7, 2));
            commands.AddLast(new AddWaterCommand(2, 8, 2));
            commands.AddLast(new AddWaterCommand(2, 9, 2));
            commands.AddLast(new AddWaterCommand(2, 10, 2));
            commands.AddLast(new AddWaterCommand(2, 11, 2));
            commands.AddLast(new AddWaterCommand(2, 12, 2));
            commands.AddLast(new AddWaterCommand(2, 13, 2));
            commands.AddLast(new AddWaterCommand(2, 14, 2));
            commands.AddLast(new AddWaterCommand(2, 15, 2));
            commands.AddLast(new AddStoneWallCommand(2, 16, 2));

            commands.AddLast(new AddStoneWallCommand(2, 0, 3));
            commands.AddLast(new AddStoneWallCommand(2, 1, 3));
            commands.AddLast(new AddStoneWallCommand(2, 2, 3));
            commands.AddLast(new AddStoneWallCommand(2, 3, 3));
            commands.AddLast(new AddStoneWallCommand(2, 4, 3));
            commands.AddLast(new AddStoneWallCommand(2, 5, 3));
            commands.AddLast(new AddStoneWallCommand(2, 6, 3));
            commands.AddLast(new AddStoneWallCommand(2, 7, 3));
            commands.AddLast(new AddStoneWallCommand(2, 8, 3));
            commands.AddLast(new AddStoneWallCommand(2, 9, 3));
            commands.AddLast(new AddStoneWallCommand(2, 10, 3));
            commands.AddLast(new AddStoneWallCommand(2, 11, 3));
            commands.AddLast(new AddStoneWallCommand(2, 12, 3));
            commands.AddLast(new AddWaterCommand(2, 13, 3));
            commands.AddLast(new AddWaterCommand(2, 14, 3));
            commands.AddLast(new AddWaterCommand(2, 15, 3));
            commands.AddLast(new AddStoneWallCommand(2, 16, 3));

            commands.AddLast(new AddStoneWallCommand(2, 0, 4));
            commands.AddLast(new AddStoneWallCommand(2, 1, 4));
            commands.AddLast(new AddStoneWallCommand(2, 2, 4));
            commands.AddLast(new AddStoneWallCommand(2, 3, 4));
            commands.AddLast(new AddStoneWallCommand(2, 4, 4));
            commands.AddLast(new AddStoneWallCommand(2, 5, 4));
            commands.AddLast(new AddStoneWallCommand(2, 6, 4));
            commands.AddLast(new AddStoneWallCommand(2, 7, 4));
            commands.AddLast(new AddStoneWallCommand(2, 8, 4));
            commands.AddLast(new AddStoneWallCommand(2, 9, 4));
            commands.AddLast(new AddStoneWallCommand(2, 10, 4));
            commands.AddLast(new AddStoneWallCommand(2, 11, 4));
            commands.AddLast(new AddStoneWallCommand(2, 12, 4));
            commands.AddLast(new AddStoneWallCommand(2, 13, 4));
            commands.AddLast(new AddWaterCommand(2, 14, 4));
            commands.AddLast(new AddWaterCommand(2, 15, 4));
            commands.AddLast(new AddStoneWallCommand(2, 16, 4));

            commands.AddLast(new AddStoneWallCommand(2, 0, 5));
            commands.AddLast(new AddStoneWallCommand(2, 1, 5));
            commands.AddLast(new AddStoneWallCommand(2, 2, 5));
            commands.AddLast(new AddStoneWallCommand(2, 12, 5));
            commands.AddLast(new AddStoneWallCommand(2, 13, 5));
            commands.AddLast(new AddWaterCommand(2, 14, 5));
            commands.AddLast(new AddWaterCommand(2, 15, 5));
            commands.AddLast(new AddWaterCommand(2, 16, 5));

            commands.AddLast(new AddStoneWallCommand(2, 0, 6));
            commands.AddLast(new AddStoneWallCommand(2, 1, 6));
            commands.AddLast(new AddStoneWallCommand(2, 13, 6));
            commands.AddLast(new AddWaterCommand(2, 14, 6));
            commands.AddLast(new AddWaterCommand(2, 15, 6));
            commands.AddLast(new AddWaterCommand(2, 16, 6));

            commands.AddLast(new AddStoneWallCommand(2, 0, 7));
            commands.AddLast(new AddStoneWallCommand(2, 1, 7));
            commands.AddLast(new AddStoneWallCommand(2, 13, 7));
            commands.AddLast(new AddStoneWallCommand(2, 14, 7));
            commands.AddLast(new AddWaterCommand(2, 15, 7));
            commands.AddLast(new AddWaterCommand(2, 16, 7));

            commands.AddLast(new AddStoneWallCommand(2, 0, 8));
            commands.AddLast(new AddStoneWallCommand(2, 1, 8));
            commands.AddLast(new AddStoneWallCommand(2, 14, 8));
            commands.AddLast(new AddWaterCommand(2, 15, 8));
            commands.AddLast(new AddWaterCommand(2, 16, 8));

            commands.AddLast(new AddStoneWallCommand(2, 0, 9));
            commands.AddLast(new AddStoneWallCommand(2, 14, 9));
            commands.AddLast(new AddStoneWallCommand(2, 15, 9));
            commands.AddLast(new AddStoneWallCommand(2, 16, 9));

            commands.AddLast(new AddStoneWallCommand(2, 0, 10));
            commands.AddLast(new AddStoneWallCommand(2, 15, 10));
            commands.AddLast(new AddStoneWallCommand(2, 16, 10));

            commands.AddLast(new AddStoneWallCommand(2, 0, 11));
            commands.AddLast(new AddStoneWallCommand(2, 16, 11));

            commands.AddLast(new AddStoneWallCommand(2, 0, 12));
            commands.AddLast(new AddStoneWallCommand(2, 1, 12));
            commands.AddLast(new AddStoneWallCommand(2, 16, 12));

            commands.AddLast(new AddStoneWallCommand(2, 0, 13));
            commands.AddLast(new AddStoneWallCommand(2, 1, 13));
            commands.AddLast(new AddStoneWallCommand(2, 2, 13));
            commands.AddLast(new AddStoneWallCommand(2, 15, 13));
            commands.AddLast(new AddStoneWallCommand(2, 16, 13));

            commands.AddLast(new AddStoneWallCommand(2, 0, 14));
            commands.AddLast(new AddStoneWallCommand(2, 1, 14));
            commands.AddLast(new AddStoneWallCommand(2, 2, 14));
            commands.AddLast(new AddStoneWallCommand(2, 3, 14));
            commands.AddLast(new AddStoneWallCommand(2, 4, 14));
            commands.AddLast(new AddStoneWallCommand(2, 5, 14));
            commands.AddLast(new AddStoneWallCommand(2, 6, 14));
            commands.AddLast(new AddStoneWallCommand(2, 11, 14));
            commands.AddLast(new AddStoneWallCommand(2, 12, 14));
            commands.AddLast(new AddStoneWallCommand(2, 13, 14));
            commands.AddLast(new AddStoneWallCommand(2, 14, 14));
            commands.AddLast(new AddStoneWallCommand(2, 15, 14));
            commands.AddLast(new AddStoneWallCommand(2, 16, 14));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 8));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 8));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 8));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 8));

        }

        private void BuildScreen4(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(4, 0));

            commands.AddLast(new AddStoneWallCommand(2, 0, 0));
            commands.AddLast(new AddStoneWallCommand(2, 1, 0));
            commands.AddLast(new AddStoneWallCommand(2, 2, 0));
            commands.AddLast(new AddStoneWallCommand(2, 3, 0));
            commands.AddLast(new AddStoneWallCommand(2, 4, 0));
            commands.AddLast(new AddStoneWallCommand(2, 5, 0));
            commands.AddLast(new AddStoneWallCommand(2, 6, 0));
            commands.AddLast(new AddStoneWallCommand(2, 7, 0));
            commands.AddLast(new AddStoneWallCommand(2, 8, 0));
            commands.AddLast(new AddStoneWallCommand(2, 9, 0));
            commands.AddLast(new AddStoneWallCommand(2, 10, 0));
            commands.AddLast(new AddStoneWallCommand(2, 11, 0));
            commands.AddLast(new AddStoneWallCommand(2, 12, 0));
            commands.AddLast(new AddStoneWallCommand(2, 13, 0));
            commands.AddLast(new AddStoneWallCommand(2, 14, 0));
            commands.AddLast(new AddStoneWallCommand(2, 15, 0));
            commands.AddLast(new AddStoneWallCommand(2, 16, 0));

            commands.AddLast(new AddStoneWallCommand(2, 0, 1));
            commands.AddLast(new AddStoneWallCommand(2, 1, 1));
            commands.AddLast(new AddStoneWallCommand(2, 2, 1));
            commands.AddLast(new AddWaterCommand(2, 3, 1));
            commands.AddLast(new AddWaterCommand(2, 4, 1));
            commands.AddLast(new AddWaterCommand(2, 5, 1));
            commands.AddLast(new AddWaterCommand(2, 6, 1));
            commands.AddLast(new AddWaterCommand(2, 7, 1));
            commands.AddLast(new AddWaterCommand(2, 8, 1));
            commands.AddLast(new AddWaterCommand(2, 9, 1));
            commands.AddLast(new AddWaterCommand(2, 10, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddStoneWallCommand(2, 14, 1));
            commands.AddLast(new AddStoneWallCommand(2, 15, 1));
            commands.AddLast(new AddStoneWallCommand(2, 16, 1));

            commands.AddLast(new AddStoneWallCommand(2, 0, 2));
            commands.AddLast(new AddStoneWallCommand(2, 1, 2));
            commands.AddLast(new AddWaterCommand(2, 2, 2));
            commands.AddLast(new AddWaterCommand(2, 3, 2));
            commands.AddLast(new AddWaterCommand(2, 4, 2));
            commands.AddLast(new AddWaterCommand(2, 5, 2));
            commands.AddLast(new AddWaterCommand(2, 6, 2));
            commands.AddLast(new AddWaterCommand(2, 7, 2));
            commands.AddLast(new AddWaterCommand(2, 8, 2));
            commands.AddLast(new AddWaterCommand(2, 9, 2));
            commands.AddLast(new AddWaterCommand(2, 10, 2));
            commands.AddLast(new AddStoneWallCommand(2, 15, 2));
            commands.AddLast(new AddStoneWallCommand(2, 16, 2));

            commands.AddLast(new AddStoneWallCommand(2, 0, 3));
            commands.AddLast(new AddWaterCommand(2, 1, 3));
            commands.AddLast(new AddWaterCommand(2, 2, 3));
            commands.AddLast(new AddWaterCommand(2, 3, 3));
            commands.AddLast(new AddWaterCommand(2, 4, 3));
            commands.AddLast(new AddWaterCommand(2, 5, 3));
            commands.AddLast(new AddWaterCommand(2, 6, 3));
            commands.AddLast(new AddWaterCommand(2, 7, 3));
            commands.AddLast(new AddWaterCommand(2, 8, 3));
            commands.AddLast(new AddWaterCommand(2, 9, 3));
            commands.AddLast(new AddWaterCommand(2, 10, 3));
            commands.AddLast(new AddWaterCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddStoneWallCommand(2, 16, 3));

            commands.AddLast(new AddStoneWallCommand(2, 0, 4));
            commands.AddLast(new AddWaterCommand(2, 1, 4));
            commands.AddLast(new AddWaterCommand(2, 2, 4));
            commands.AddLast(new AddWaterCommand(2, 3, 4));
            commands.AddLast(new AddWaterCommand(2, 4, 4));
            commands.AddLast(new AddWaterCommand(2, 5, 4));
            commands.AddLast(new AddWaterCommand(2, 6, 4));
            commands.AddLast(new AddWaterCommand(2, 7, 4));
            commands.AddLast(new AddWaterCommand(2, 8, 4));
            commands.AddLast(new AddWaterCommand(2, 9, 4));
            commands.AddLast(new AddWaterCommand(2, 10, 4));
            commands.AddLast(new AddWaterCommand(2, 11, 4));
            commands.AddLast(new AddWaterCommand(2, 12, 4));
            commands.AddLast(new AddRockCommand(2, 13, 4));
            commands.AddLast(new AddStoneWallCommand(2, 16, 4));

            commands.AddLast(new AddWaterCommand(2, 0, 5));
            commands.AddLast(new AddWaterCommand(2, 1, 5));
            commands.AddLast(new AddWaterCommand(2, 2, 5));
            commands.AddLast(new AddWaterCommand(2, 3, 5));
            commands.AddLast(new AddWaterCommand(2, 4, 5));
            commands.AddLast(new AddWaterCommand(2, 5, 5));
            commands.AddLast(new AddWaterCommand(2, 6, 5));
            commands.AddLast(new AddWaterCommand(2, 7, 5));
            commands.AddLast(new AddTreeCommand(2, 9, 5));
            commands.AddLast(new AddWaterCommand(2, 10, 5));
            commands.AddLast(new AddWaterCommand(2, 11, 5));
            commands.AddLast(new AddWaterCommand(2, 12, 5));
            commands.AddLast(new AddWaterCommand(2, 13, 5));
            commands.AddLast(new AddWaterCommand(2, 14, 5));
            commands.AddLast(new AddWaterCommand(2, 15, 5));
            commands.AddLast(new AddStoneWallCommand(2, 16, 5));

            commands.AddLast(new AddWaterCommand(2, 0, 6));
            commands.AddLast(new AddWaterCommand(2, 1, 6));
            commands.AddLast(new AddWaterCommand(2, 2, 6));
            commands.AddLast(new AddWaterCommand(2, 3, 6));
            commands.AddLast(new AddWaterCommand(2, 4, 6));
            commands.AddLast(new AddWaterCommand(2, 5, 6));
            commands.AddLast(new AddRockCommand(2, 6, 6));
            commands.AddLast(new AddWaterCommand(2, 10, 6));
            commands.AddLast(new AddWaterCommand(2, 11, 6));
            commands.AddLast(new AddWaterCommand(2, 12, 6));
            commands.AddLast(new AddWaterCommand(2, 13, 6));
            commands.AddLast(new AddWaterCommand(2, 14, 6));
            commands.AddLast(new AddWaterCommand(2, 15, 6));
            commands.AddLast(new AddStoneWallCommand(2, 16, 6));

            commands.AddLast(new AddWaterCommand(2, 0, 7));
            commands.AddLast(new AddWaterCommand(2, 1, 7));
            commands.AddLast(new AddWaterCommand(2, 2, 7));
            commands.AddLast(new AddWaterCommand(2, 3, 7));
            commands.AddLast(new AddWaterCommand(2, 4, 7));
            commands.AddLast(new AddWaterCommand(2, 5, 7));
            commands.AddLast(new AddWaterCommand(2, 10, 7));
            commands.AddLast(new AddWaterCommand(2, 11, 7));
            commands.AddLast(new AddWaterCommand(2, 12, 7));
            commands.AddLast(new AddWaterCommand(2, 13, 7));
            commands.AddLast(new AddWaterCommand(2, 14, 7));
            commands.AddLast(new AddWaterCommand(2, 15, 7));
            commands.AddLast(new AddStoneWallCommand(2, 16, 7));

            commands.AddLast(new AddWaterCommand(2, 0, 8));
            commands.AddLast(new AddRockCommand(2, 2, 8));
            commands.AddLast(new AddWaterCommand(2, 3, 8));
            commands.AddLast(new AddWaterCommand(2, 4, 8));
            commands.AddLast(new AddWaterCommand(2, 5, 8));
            commands.AddLast(new AddTreeCommand(2, 6, 8));
            commands.AddLast(new AddWaterCommand(2, 9, 8));
            commands.AddLast(new AddWaterCommand(2, 10, 8));
            commands.AddLast(new AddWaterCommand(2, 11, 8));
            commands.AddLast(new AddWaterCommand(2, 12, 8));
            commands.AddLast(new AddWaterCommand(2, 13, 8));
            commands.AddLast(new AddWaterCommand(2, 14, 8));
            commands.AddLast(new AddWaterCommand(2, 15, 8));
            commands.AddLast(new AddStoneWallCommand(2, 16, 8));

            commands.AddLast(new AddStoneWallCommand(2, 0, 9));
            commands.AddLast(new AddWaterCommand(2, 3, 9));
            commands.AddLast(new AddWaterCommand(2, 4, 9));
            commands.AddLast(new AddWaterCommand(2, 5, 9));
            commands.AddLast(new AddWaterCommand(2, 6, 9));
            commands.AddLast(new AddWaterCommand(2, 7, 9));
            commands.AddLast(new AddWaterCommand(2, 8, 9));
            commands.AddLast(new AddWaterCommand(2, 9, 9));
            commands.AddLast(new AddWaterCommand(2, 10, 9));
            commands.AddLast(new AddWaterCommand(2, 11, 9));
            commands.AddLast(new AddWaterCommand(2, 12, 9));
            commands.AddLast(new AddWaterCommand(2, 13, 9));
            commands.AddLast(new AddWaterCommand(2, 14, 9));
            commands.AddLast(new AddWaterCommand(2, 15, 9));
            commands.AddLast(new AddStoneWallCommand(2, 16, 9));

            commands.AddLast(new AddStoneWallCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 3, 10));
            commands.AddLast(new AddWaterCommand(2, 4, 10));
            commands.AddLast(new AddWaterCommand(2, 5, 10));
            commands.AddLast(new AddWaterCommand(2, 6, 10));
            commands.AddLast(new AddWaterCommand(2, 7, 10));
            commands.AddLast(new AddWaterCommand(2, 8, 10));
            commands.AddLast(new AddWaterCommand(2, 9, 10));
            commands.AddLast(new AddWaterCommand(2, 10, 10));
            commands.AddLast(new AddWaterCommand(2, 11, 10));
            commands.AddLast(new AddWaterCommand(2, 12, 10));
            commands.AddLast(new AddWaterCommand(2, 13, 10));
            commands.AddLast(new AddWaterCommand(2, 14, 10));
            commands.AddLast(new AddWaterCommand(2, 15, 10));
            commands.AddLast(new AddStoneWallCommand(2, 16, 10));

            commands.AddLast(new AddStoneWallCommand(2, 0, 11));
            commands.AddLast(new AddWaterCommand(2, 4, 11));
            commands.AddLast(new AddWaterCommand(2, 5, 11));
            commands.AddLast(new AddWaterCommand(2, 6, 11));
            commands.AddLast(new AddWaterCommand(2, 7, 11));
            commands.AddLast(new AddWaterCommand(2, 8, 11));
            commands.AddLast(new AddWaterCommand(2, 9, 11));
            commands.AddLast(new AddWaterCommand(2, 10, 11));
            commands.AddLast(new AddWaterCommand(2, 11, 11));
            commands.AddLast(new AddWaterCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddStoneWallCommand(2, 16, 11));

            commands.AddLast(new AddStoneWallCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddStoneWallCommand(2, 16, 12));

            commands.AddLast(new AddStoneWallCommand(2, 0, 13));
            commands.AddLast(new AddStoneWallCommand(2, 1, 13));
            commands.AddLast(new AddRockCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddStoneWallCommand(2, 16, 13));

            commands.AddLast(new AddStoneWallCommand(2, 0, 14));
            commands.AddLast(new AddStoneWallCommand(2, 1, 14));
            commands.AddLast(new AddStoneWallCommand(2, 2, 14));
            commands.AddLast(new AddStoneWallCommand(2, 3, 14));
            commands.AddLast(new AddStoneWallCommand(2, 4, 14));
            commands.AddLast(new AddStoneWallCommand(2, 5, 14));
            commands.AddLast(new AddStoneWallCommand(2, 6, 14));

            commands.AddLast(new AddStoneWallCommand(2, 11, 14));
            commands.AddLast(new AddStoneWallCommand(2, 12, 14));
            commands.AddLast(new AddStoneWallCommand(2, 13, 14));
            commands.AddLast(new AddStoneWallCommand(2, 14, 14));
            commands.AddLast(new AddStoneWallCommand(2, 15, 14));
            commands.AddLast(new AddStoneWallCommand(2, 16, 14));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 9));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 9));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 9));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 9));

        }

        private void BuildScreen5(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 1));

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));

            commands.AddLast(new AddTreeCommand(2, 0, 5));
            commands.AddLast(new AddTreeCommand(2, 1, 5));
            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));

            commands.AddLast(new AddTreeCommand(2, 0, 6));
            commands.AddLast(new AddTreeCommand(2, 1, 6));
            commands.AddLast(new AddTreeCommand(2, 2, 6));

            commands.AddLast(new AddTreeCommand(2, 0, 7));
            commands.AddLast(new AddTreeCommand(2, 0, 8));



            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(4, 15, 5));
            commands.AddLast(new AddTreeCommand(4, 16, 5));

            commands.AddLast(new AddTreeCommand(4, 15, 6));
            commands.AddLast(new AddTreeCommand(4, 16, 6));


            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));
            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 4, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));
            commands.AddLast(new AddTreeCommand(2, 2, 10));
            commands.AddLast(new AddTreeCommand(2, 3, 10));
            commands.AddLast(new AddTreeCommand(2, 4, 10));
            commands.AddLast(new AddTreeCommand(2, 5, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));
            commands.AddLast(new AddTreeCommand(2, 4, 11));
            commands.AddLast(new AddTreeCommand(2, 5, 11));
            commands.AddLast(new AddTreeCommand(2, 6, 11));

            commands.AddLast(new AddWaterCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));
            commands.AddLast(new AddTreeCommand(2, 4, 12));
            commands.AddLast(new AddTreeCommand(2, 5, 12));
            commands.AddLast(new AddTreeCommand(2, 6, 12));
            commands.AddLast(new AddTreeCommand(2, 7, 12));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));
            commands.AddLast(new AddTreeCommand(2, 7, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));
            commands.AddLast(new AddTreeCommand(2, 7, 14));


            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));


            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 0));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 0));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 0));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 0));

            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 6));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 6));

            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 10));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 10));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 10));
        }

        private void BuildScreen6(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(1, 1));

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddStoneWallCommand(2, 0, 0));
            commands.AddLast(new AddStoneWallCommand(2, 1, 0));
            commands.AddLast(new AddStoneWallCommand(2, 2, 0));
            commands.AddLast(new AddStoneWallCommand(2, 3, 0));
            commands.AddLast(new AddStoneWallCommand(2, 4, 0));
            commands.AddLast(new AddStoneWallCommand(2, 5, 0));
            commands.AddLast(new AddStoneWallCommand(2, 6, 0));

            commands.AddLast(new AddStoneWallCommand(2, 0, 1));
            commands.AddLast(new AddStoneWallCommand(2, 1, 1));
            commands.AddLast(new AddStoneWallCommand(2, 2, 1));
            commands.AddLast(new AddStoneWallCommand(2, 3, 1));
            commands.AddLast(new AddStoneWallCommand(2, 4, 1));
            commands.AddLast(new AddStoneWallCommand(2, 5, 1));
            commands.AddLast(new AddStoneWallCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));

            commands.AddLast(new AddTreeCommand(2, 0, 5));
            commands.AddLast(new AddTreeCommand(2, 1, 5));
            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));

            commands.AddLast(new AddTreeCommand(2, 0, 6));
            commands.AddLast(new AddTreeCommand(2, 1, 6));
            commands.AddLast(new AddTreeCommand(2, 2, 6));


            // Upper-right forest
            commands.AddLast(new AddStoneWallCommand(2, 11, 0));
            commands.AddLast(new AddStoneWallCommand(2, 12, 0));
            commands.AddLast(new AddStoneWallCommand(2, 13, 0));
            commands.AddLast(new AddStoneWallCommand(2, 14, 0));
            commands.AddLast(new AddStoneWallCommand(2, 15, 0));
            commands.AddLast(new AddStoneWallCommand(2, 16, 0));

            commands.AddLast(new AddStoneWallCommand(2, 11, 1));
            commands.AddLast(new AddStoneWallCommand(2, 12, 1));
            commands.AddLast(new AddStoneWallCommand(2, 13, 1));
            commands.AddLast(new AddStoneWallCommand(2, 14, 1));
            commands.AddLast(new AddStoneWallCommand(2, 15, 1));
            commands.AddLast(new AddStoneWallCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(4, 16, 5));
            commands.AddLast(new AddTreeCommand(4, 16, 6));


            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));
            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 4, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));
            commands.AddLast(new AddTreeCommand(2, 2, 10));
            commands.AddLast(new AddTreeCommand(2, 3, 10));
            commands.AddLast(new AddTreeCommand(2, 4, 10));
            commands.AddLast(new AddTreeCommand(2, 5, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));
            commands.AddLast(new AddTreeCommand(2, 4, 11));
            commands.AddLast(new AddTreeCommand(2, 5, 11));
            commands.AddLast(new AddTreeCommand(2, 6, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));
            commands.AddLast(new AddTreeCommand(2, 4, 12));
            commands.AddLast(new AddTreeCommand(2, 5, 12));
            commands.AddLast(new AddTreeCommand(2, 6, 12));
            commands.AddLast(new AddTreeCommand(2, 7, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));
            commands.AddLast(new AddTreeCommand(2, 7, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));
            commands.AddLast(new AddTreeCommand(2, 7, 14));


            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));


            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 11));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 11));


            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 7));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 7));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 7));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 7));

            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 13));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 13));

            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 17));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 17));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 17));
        }

        private void BuildScreen7(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(2, 1));

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddStoneWallCommand(2, 0, 0));
            commands.AddLast(new AddStoneWallCommand(2, 1, 0));
            commands.AddLast(new AddStoneWallCommand(2, 2, 0));
            commands.AddLast(new AddStoneWallCommand(2, 3, 0));
            commands.AddLast(new AddStoneWallCommand(2, 4, 0));
            commands.AddLast(new AddStoneWallCommand(2, 5, 0));
            commands.AddLast(new AddStoneWallCommand(2, 6, 0));
            commands.AddLast(new AddStoneWallCommand(2, 7, 0));
            commands.AddLast(new AddStoneWallCommand(2, 8, 0));
            commands.AddLast(new AddStoneWallCommand(2, 9, 0));
            commands.AddLast(new AddStoneWallCommand(2, 10, 0));
            commands.AddLast(new AddStoneWallCommand(2, 11, 0));
            commands.AddLast(new AddStoneWallCommand(2, 12, 0));
            commands.AddLast(new AddStoneWallCommand(2, 13, 0));
            commands.AddLast(new AddStoneWallCommand(2, 14, 0));
            commands.AddLast(new AddStoneWallCommand(2, 15, 0));
            commands.AddLast(new AddStoneWallCommand(2, 16, 0));

            commands.AddLast(new AddStoneWallCommand(2, 0, 1));
            commands.AddLast(new AddStoneWallCommand(2, 1, 1));
            commands.AddLast(new AddStoneWallCommand(2, 2, 1));
            commands.AddLast(new AddStoneWallCommand(2, 3, 1));
            commands.AddLast(new AddStoneWallCommand(2, 4, 1));
            commands.AddLast(new AddStoneWallCommand(2, 5, 1));
            commands.AddLast(new AddStoneWallCommand(2, 6, 1));
            commands.AddLast(new AddStoneWallCommand(2, 7, 1));
            commands.AddLast(new AddStoneWallCommand(2, 8, 1));
            commands.AddLast(new AddStoneWallCommand(2, 9, 1));
            commands.AddLast(new AddStoneWallCommand(2, 10, 1));
            commands.AddLast(new AddStoneWallCommand(2, 11, 1));
            commands.AddLast(new AddStoneWallCommand(2, 12, 1));
            commands.AddLast(new AddStoneWallCommand(2, 13, 1));
            commands.AddLast(new AddStoneWallCommand(2, 14, 1));
            commands.AddLast(new AddStoneWallCommand(2, 15, 1));
            commands.AddLast(new AddStoneWallCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));
            commands.AddLast(new AddTreeCommand(2, 7, 2));
            commands.AddLast(new AddTreeCommand(2, 8, 2));
            commands.AddLast(new AddTreeCommand(2, 9, 2));
            commands.AddLast(new AddTreeCommand(2, 10, 2));
            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));


            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));

            commands.AddLast(new AddTreeCommand(2, 0, 5));
            commands.AddLast(new AddTreeCommand(2, 1, 5));
            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));

            commands.AddLast(new AddTreeCommand(2, 0, 6));
            commands.AddLast(new AddTreeCommand(2, 1, 6));
            commands.AddLast(new AddTreeCommand(2, 2, 6));



            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));




            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));

            commands.AddLast(new AddTreeCommand(2, 0, 5));
            commands.AddLast(new AddTreeCommand(2, 1, 5));
            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));

            commands.AddLast(new AddTreeCommand(2, 0, 6));
            commands.AddLast(new AddTreeCommand(2, 1, 6));
            commands.AddLast(new AddTreeCommand(2, 2, 6));



            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));
            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 4, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));
            commands.AddLast(new AddTreeCommand(2, 2, 10));
            commands.AddLast(new AddTreeCommand(2, 3, 10));
            commands.AddLast(new AddTreeCommand(2, 4, 10));
            commands.AddLast(new AddTreeCommand(2, 5, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));
            commands.AddLast(new AddTreeCommand(2, 4, 11));
            commands.AddLast(new AddTreeCommand(2, 5, 11));
            commands.AddLast(new AddTreeCommand(2, 6, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));
            commands.AddLast(new AddTreeCommand(2, 4, 12));
            commands.AddLast(new AddTreeCommand(2, 5, 12));
            commands.AddLast(new AddTreeCommand(2, 6, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));


            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));


            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 6));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 6));

            commands.AddLast(new AddEdgeCommand(4, 16, 5, 1, 8));
            commands.AddLast(new AddEdgeCommand(4, 16, 6, 1, 8));
            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 8));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 8));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 12));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 12));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 12));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 12));
        }

        private void BuildScreen8(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(3, 1));

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));




            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(2, 15, 5));
            commands.AddLast(new AddTreeCommand(2, 16, 5));

            commands.AddLast(new AddTreeCommand(2, 15, 6));
            commands.AddLast(new AddTreeCommand(2, 16, 6));


            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));
            commands.AddLast(new AddTreeCommand(2, 2, 10));
            commands.AddLast(new AddTreeCommand(2, 3, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));
            commands.AddLast(new AddTreeCommand(2, 4, 11));
            commands.AddLast(new AddTreeCommand(2, 5, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));
            commands.AddLast(new AddTreeCommand(2, 4, 12));
            commands.AddLast(new AddTreeCommand(2, 5, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));


            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));

            commands.AddLast(new AddEdgeCommand(4, 0, 5, 3, 7));
            commands.AddLast(new AddEdgeCommand(4, 0, 6, 3, 7));
            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 7));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 7));

            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 3));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 3));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 3));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 3));

            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 9));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 9));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 13));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 13));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 13));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 13));
        }

        private void BuildScreen9(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(4, 1));

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));

            commands.AddLast(new AddTreeCommand(2, 0, 5));
            commands.AddLast(new AddTreeCommand(2, 1, 5));
            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));

            commands.AddLast(new AddTreeCommand(2, 0, 6));
            commands.AddLast(new AddTreeCommand(2, 1, 6));
            commands.AddLast(new AddTreeCommand(2, 2, 6));





            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(2, 15, 5));
            commands.AddLast(new AddTreeCommand(2, 16, 5));

            commands.AddLast(new AddTreeCommand(2, 15, 6));
            commands.AddLast(new AddTreeCommand(2, 16, 6));

            commands.AddLast(new AddTreeCommand(2, 15, 7));
            commands.AddLast(new AddTreeCommand(2, 16, 7));

            commands.AddLast(new AddTreeCommand(2, 15, 8));
            commands.AddLast(new AddTreeCommand(2, 16, 8));



            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));
            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 4, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));
            commands.AddLast(new AddTreeCommand(2, 2, 10));
            commands.AddLast(new AddTreeCommand(2, 3, 10));
            commands.AddLast(new AddTreeCommand(2, 4, 10));
            commands.AddLast(new AddTreeCommand(2, 5, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));
            commands.AddLast(new AddTreeCommand(2, 4, 11));
            commands.AddLast(new AddTreeCommand(2, 5, 11));
            commands.AddLast(new AddTreeCommand(2, 6, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));
            commands.AddLast(new AddTreeCommand(2, 4, 12));
            commands.AddLast(new AddTreeCommand(2, 5, 12));
            commands.AddLast(new AddTreeCommand(2, 6, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));



            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));

            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 8));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 8));

            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 4));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 4));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 4));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 4));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 14));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 14));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 14));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 14));
        }

        private void BuildScreen10(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 2));

            commands.AddLast(new AddWaterCommand(2, 0, 0));
            commands.AddLast(new AddWaterCommand(2, 1, 0));
            commands.AddLast(new AddWaterCommand(2, 2, 0));

            commands.AddLast(new AddWaterCommand(2, 0, 1));
            commands.AddLast(new AddWaterCommand(2, 1, 1));
            commands.AddLast(new AddWaterCommand(2, 2, 1));

            commands.AddLast(new AddWaterCommand(2, 0, 2));
            commands.AddLast(new AddWaterCommand(2, 1, 2));
            commands.AddLast(new AddWaterCommand(2, 2, 2));

            commands.AddLast(new AddWaterCommand(2, 0, 3));
            commands.AddLast(new AddWaterCommand(2, 1, 3));
            commands.AddLast(new AddWaterCommand(2, 2, 3));

            commands.AddLast(new AddWaterCommand(2, 0, 4));
            commands.AddLast(new AddWaterCommand(2, 1, 4));
            commands.AddLast(new AddWaterCommand(2, 2, 4));

            commands.AddLast(new AddWaterCommand(2, 0, 5));
            commands.AddLast(new AddWaterCommand(2, 1, 5));
            commands.AddLast(new AddWaterCommand(2, 2, 5));

            commands.AddLast(new AddWaterCommand(2, 0, 6));
            commands.AddLast(new AddWaterCommand(2, 1, 6));
            commands.AddLast(new AddWaterCommand(2, 2, 6));

            commands.AddLast(new AddWaterCommand(2, 0, 7));
            commands.AddLast(new AddWaterCommand(2, 1, 7));
            commands.AddLast(new AddWaterCommand(2, 2, 7));

            commands.AddLast(new AddWaterCommand(2, 0, 8));
            commands.AddLast(new AddWaterCommand(2, 1, 8));
            commands.AddLast(new AddWaterCommand(2, 2, 8));

            commands.AddLast(new AddWaterCommand(2, 0, 9));
            commands.AddLast(new AddWaterCommand(2, 1, 9));
            commands.AddLast(new AddWaterCommand(2, 2, 9));

            commands.AddLast(new AddWaterCommand(2, 0, 10));
            commands.AddLast(new AddWaterCommand(2, 1, 10));
            commands.AddLast(new AddWaterCommand(2, 2, 10));

            commands.AddLast(new AddWaterCommand(2, 0, 11));
            commands.AddLast(new AddWaterCommand(2, 1, 11));
            commands.AddLast(new AddWaterCommand(2, 2, 11));

            commands.AddLast(new AddWaterCommand(2, 0, 12));
            commands.AddLast(new AddWaterCommand(2, 1, 12));
            commands.AddLast(new AddWaterCommand(2, 2, 12));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));

            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));
            commands.AddLast(new AddTreeCommand(2, 7, 0));

            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));

            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));


            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));

            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 5));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 5));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 5));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 5));

            commands.AddLast(new AddEdgeCommand(4, 16, 5, 1, 12));
            commands.AddLast(new AddEdgeCommand(4, 16, 6, 1, 12));
            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 12));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 12));



            commands.AddLast(new AddEdgeCommand(4, 3, 14, 2, 15));
            commands.AddLast(new AddEdgeCommand(4, 4, 14, 2, 15));
            commands.AddLast(new AddEdgeCommand(4, 5, 14, 2, 15));
            commands.AddLast(new AddEdgeCommand(4, 6, 14, 2, 15));
            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 15));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 15));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 15));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 15));


        }

        private void BuildScreen11(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(1, 2));

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));
            commands.AddLast(new AddTreeCommand(2, 7, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));




            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(2, 16, 5));

            commands.AddLast(new AddTreeCommand(2, 16, 6));



            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));


            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));





            commands.AddLast(new AddEdgeCommand(4, 0, 5, 3, 10));
            commands.AddLast(new AddEdgeCommand(4, 0, 6, 3, 10));
            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 10));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 10));

            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 6));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 6));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 6));

            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 12));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 12));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 16));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 16));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 16));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 16));
        }

        private void BuildScreen12(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(2, 2));

            // Upper-left forest. Think Composite!!!
            //            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddGrassCommand(3, 0, 0));

            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddStairsCommand(2, 4, 4, 26));

            commands.AddLast(new AddTreeCommand(2, 0, 5));
            commands.AddLast(new AddTreeCommand(2, 1, 5));
            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));

            commands.AddLast(new AddTreeCommand(2, 0, 6));
            commands.AddLast(new AddTreeCommand(2, 1, 6));
            commands.AddLast(new AddTreeCommand(2, 2, 6));


            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(4, 16, 5));
            commands.AddLast(new AddTreeCommand(4, 16, 6));


            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));
            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 4, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));
            commands.AddLast(new AddTreeCommand(2, 2, 10));
            commands.AddLast(new AddTreeCommand(2, 3, 10));
            commands.AddLast(new AddTreeCommand(2, 4, 10));
            commands.AddLast(new AddTreeCommand(2, 5, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));
            commands.AddLast(new AddTreeCommand(2, 4, 11));
            commands.AddLast(new AddTreeCommand(2, 5, 11));
            commands.AddLast(new AddTreeCommand(2, 6, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));
            commands.AddLast(new AddTreeCommand(2, 4, 12));
            commands.AddLast(new AddTreeCommand(2, 5, 12));
            commands.AddLast(new AddTreeCommand(2, 6, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));


            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));


            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 11));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 11));


            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 7));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 7));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 7));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 7));

            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 13));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 13));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 17));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 17));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 17));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 17));
        }

        private void BuildScreen13(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(3, 2));

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));

            commands.AddLast(new AddTreeCommand(2, 0, 5));
            commands.AddLast(new AddTreeCommand(2, 1, 5));
            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));

            commands.AddLast(new AddTreeCommand(2, 0, 6));
            commands.AddLast(new AddTreeCommand(2, 1, 6));
            commands.AddLast(new AddTreeCommand(2, 2, 6));


            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));


            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));
            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 4, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));
            commands.AddLast(new AddTreeCommand(2, 2, 10));
            commands.AddLast(new AddTreeCommand(2, 3, 10));
            commands.AddLast(new AddTreeCommand(2, 4, 10));
            commands.AddLast(new AddTreeCommand(2, 5, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));
            commands.AddLast(new AddTreeCommand(2, 4, 11));
            commands.AddLast(new AddTreeCommand(2, 5, 11));
            commands.AddLast(new AddTreeCommand(2, 6, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));
            commands.AddLast(new AddTreeCommand(2, 4, 12));
            commands.AddLast(new AddTreeCommand(2, 5, 12));
            commands.AddLast(new AddTreeCommand(2, 6, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));


            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));


            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 16));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 16));

            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 11));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 11));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 11));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 11));

            commands.AddLast(new AddEdgeCommand(4, 16, 5, 1, 14));
            commands.AddLast(new AddEdgeCommand(4, 16, 6, 1, 14));
            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 14));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 14));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 18));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 18));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 18));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 18));
        }

        private void BuildScreen14(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(4, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(2, 16, 5));

            commands.AddLast(new AddTreeCommand(2, 7, 6));
            commands.AddLast(new AddTreeCommand(2, 8, 6));
            commands.AddLast(new AddTreeCommand(2, 9, 6));
            commands.AddLast(new AddTreeCommand(2, 16, 6));

            commands.AddLast(new AddTreeCommand(2, 7, 7));
            commands.AddLast(new AddTreeCommand(2, 9, 7));
            commands.AddLast(new AddTreeCommand(2, 16, 7));

            commands.AddLast(new AddTreeCommand(2, 7, 8));
            commands.AddLast(new AddTreeCommand(2, 8, 8));
            commands.AddLast(new AddTreeCommand(2, 9, 8));
            commands.AddLast(new AddTreeCommand(2, 16, 8));

            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));

            commands.AddLast(new AddEdgeCommand(4, 0, 5, 3, 13));
            commands.AddLast(new AddEdgeCommand(4, 0, 6, 3, 13));
            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 13));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 13));

            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 9));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 9));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 9));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 9));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 19));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 19));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 19));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 19));
        }

        private void BuildScreen15(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 3));

            commands.AddLast(new AddWaterCommand(2, 0, 0));
            commands.AddLast(new AddWaterCommand(2, 1, 0));
            commands.AddLast(new AddWaterCommand(2, 2, 0));

            commands.AddLast(new AddWaterCommand(2, 0, 1));
            commands.AddLast(new AddWaterCommand(2, 1, 1));
            commands.AddLast(new AddWaterCommand(2, 2, 1));

            commands.AddLast(new AddWaterCommand(2, 0, 2));
            commands.AddLast(new AddWaterCommand(2, 1, 2));
            commands.AddLast(new AddWaterCommand(2, 2, 2));

            commands.AddLast(new AddWaterCommand(2, 0, 3));
            commands.AddLast(new AddWaterCommand(2, 1, 3));
            commands.AddLast(new AddWaterCommand(2, 2, 3));

            commands.AddLast(new AddWaterCommand(2, 0, 4));
            commands.AddLast(new AddWaterCommand(2, 1, 4));
            commands.AddLast(new AddWaterCommand(2, 2, 4));
            commands.AddLast(new AddWaterCommand(2, 3, 4));

            commands.AddLast(new AddWaterCommand(2, 0, 5));
            commands.AddLast(new AddWaterCommand(2, 1, 5));
            commands.AddLast(new AddWaterCommand(2, 2, 5));
            commands.AddLast(new AddWaterCommand(2, 3, 5));
            commands.AddLast(new AddWaterCommand(2, 4, 5));

            commands.AddLast(new AddWaterCommand(2, 0, 6));
            commands.AddLast(new AddWaterCommand(2, 1, 6));
            commands.AddLast(new AddWaterCommand(2, 2, 6));
            commands.AddLast(new AddWaterCommand(2, 3, 6));
            commands.AddLast(new AddWaterCommand(2, 4, 6));
            commands.AddLast(new AddWaterCommand(2, 5, 6));

            commands.AddLast(new AddWaterCommand(2, 0, 7));
            commands.AddLast(new AddWaterCommand(2, 1, 7));
            commands.AddLast(new AddWaterCommand(2, 2, 7));
            commands.AddLast(new AddWaterCommand(2, 3, 7));
            commands.AddLast(new AddWaterCommand(2, 4, 7));
            commands.AddLast(new AddWaterCommand(2, 5, 7));
            commands.AddLast(new AddWaterCommand(2, 6, 7));

            commands.AddLast(new AddWaterCommand(2, 0, 8));
            commands.AddLast(new AddWaterCommand(2, 1, 8));
            commands.AddLast(new AddWaterCommand(2, 2, 8));
            commands.AddLast(new AddWaterCommand(2, 3, 8));
            commands.AddLast(new AddWaterCommand(2, 4, 8));
            commands.AddLast(new AddWaterCommand(2, 5, 8));
            commands.AddLast(new AddWaterCommand(2, 6, 8));
            commands.AddLast(new AddWaterCommand(2, 7, 8));

            commands.AddLast(new AddWaterCommand(2, 0, 9));
            commands.AddLast(new AddWaterCommand(2, 1, 9));
            commands.AddLast(new AddWaterCommand(2, 2, 9));
            commands.AddLast(new AddWaterCommand(2, 3, 9));
            commands.AddLast(new AddWaterCommand(2, 4, 9));
            commands.AddLast(new AddWaterCommand(2, 5, 9));
            commands.AddLast(new AddWaterCommand(2, 6, 9));
            commands.AddLast(new AddWaterCommand(2, 7, 9));

            commands.AddLast(new AddWaterCommand(2, 0, 10));
            commands.AddLast(new AddWaterCommand(2, 1, 10));
            commands.AddLast(new AddWaterCommand(2, 2, 10));
            commands.AddLast(new AddWaterCommand(2, 3, 10));
            commands.AddLast(new AddWaterCommand(2, 4, 10));
            commands.AddLast(new AddWaterCommand(2, 5, 10));
            commands.AddLast(new AddWaterCommand(2, 6, 10));
            commands.AddLast(new AddWaterCommand(2, 7, 10));

            commands.AddLast(new AddWaterCommand(2, 0, 11));
            commands.AddLast(new AddWaterCommand(2, 1, 11));
            commands.AddLast(new AddWaterCommand(2, 2, 11));
            commands.AddLast(new AddWaterCommand(2, 3, 11));
            commands.AddLast(new AddWaterCommand(2, 4, 11));
            commands.AddLast(new AddWaterCommand(2, 5, 11));
            commands.AddLast(new AddWaterCommand(2, 6, 11));
            commands.AddLast(new AddWaterCommand(2, 7, 11));

            commands.AddLast(new AddWaterCommand(2, 0, 12));
            commands.AddLast(new AddWaterCommand(2, 1, 12));
            commands.AddLast(new AddWaterCommand(2, 2, 12));
            commands.AddLast(new AddWaterCommand(2, 3, 12));
            commands.AddLast(new AddWaterCommand(2, 4, 12));
            commands.AddLast(new AddWaterCommand(2, 5, 12));
            commands.AddLast(new AddWaterCommand(2, 6, 12));
            commands.AddLast(new AddWaterCommand(2, 7, 12));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));
            commands.AddLast(new AddWaterCommand(2, 3, 13));
            commands.AddLast(new AddWaterCommand(2, 4, 13));
            commands.AddLast(new AddWaterCommand(2, 5, 13));
            commands.AddLast(new AddWaterCommand(2, 6, 13));
            commands.AddLast(new AddWaterCommand(2, 7, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));
            commands.AddLast(new AddWaterCommand(2, 3, 14));
            commands.AddLast(new AddWaterCommand(2, 4, 14));
            commands.AddLast(new AddWaterCommand(2, 5, 14));
            commands.AddLast(new AddWaterCommand(2, 6, 14));
            commands.AddLast(new AddWaterCommand(2, 7, 14));





            commands.AddLast(new AddWaterCommand(2, 0, 6));
            commands.AddLast(new AddWaterCommand(2, 1, 6));
            commands.AddLast(new AddWaterCommand(2, 2, 6));

            commands.AddLast(new AddWaterCommand(2, 0, 7));
            commands.AddLast(new AddWaterCommand(2, 1, 7));
            commands.AddLast(new AddWaterCommand(2, 2, 7));

            commands.AddLast(new AddWaterCommand(2, 0, 8));
            commands.AddLast(new AddWaterCommand(2, 1, 8));
            commands.AddLast(new AddWaterCommand(2, 2, 8));

            commands.AddLast(new AddWaterCommand(2, 0, 9));
            commands.AddLast(new AddWaterCommand(2, 1, 9));
            commands.AddLast(new AddWaterCommand(2, 2, 9));

            commands.AddLast(new AddWaterCommand(2, 0, 10));
            commands.AddLast(new AddWaterCommand(2, 1, 10));
            commands.AddLast(new AddWaterCommand(2, 2, 10));

            commands.AddLast(new AddWaterCommand(2, 0, 11));
            commands.AddLast(new AddWaterCommand(2, 1, 11));
            commands.AddLast(new AddWaterCommand(2, 2, 11));

            commands.AddLast(new AddWaterCommand(2, 0, 12));
            commands.AddLast(new AddWaterCommand(2, 1, 12));
            commands.AddLast(new AddWaterCommand(2, 2, 12));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));

            /*
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));
            commands.AddLast(new AddTreeCommand(2, 7, 0));

            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));

            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            */


            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(2, 15, 5));
            commands.AddLast(new AddTreeCommand(2, 16, 5));

            commands.AddLast(new AddTreeCommand(2, 15, 6));
            commands.AddLast(new AddTreeCommand(2, 16, 6));

            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));

            commands.AddLast(new AddEdgeCommand(4, 3, 0, 0, 10));
            commands.AddLast(new AddEdgeCommand(4, 4, 0, 0, 10));
            commands.AddLast(new AddEdgeCommand(4, 5, 0, 0, 10));
            commands.AddLast(new AddEdgeCommand(4, 6, 0, 0, 10));
            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 10));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 10));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 10));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 10));


            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 16));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 16));

            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 20));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 20));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 20));


        }

        private void BuildScreen16(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(1, 3));

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));

            commands.AddLast(new AddTreeCommand(2, 0, 5));
            commands.AddLast(new AddTreeCommand(2, 1, 5));
            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));

            commands.AddLast(new AddTreeCommand(2, 0, 6));
            commands.AddLast(new AddTreeCommand(2, 1, 6));
            commands.AddLast(new AddTreeCommand(2, 2, 6));


            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(4, 15, 5));
            commands.AddLast(new AddTreeCommand(4, 16, 5));


            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));
            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 4, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));
            commands.AddLast(new AddTreeCommand(2, 2, 10));
            commands.AddLast(new AddTreeCommand(2, 3, 10));
            commands.AddLast(new AddTreeCommand(2, 4, 10));
            commands.AddLast(new AddTreeCommand(2, 5, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));
            commands.AddLast(new AddTreeCommand(2, 4, 11));
            commands.AddLast(new AddTreeCommand(2, 5, 11));
            commands.AddLast(new AddTreeCommand(2, 6, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));
            commands.AddLast(new AddTreeCommand(2, 4, 12));
            commands.AddLast(new AddTreeCommand(2, 5, 12));
            commands.AddLast(new AddTreeCommand(2, 6, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));


            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));


            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 15));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 15));

            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 11));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 11));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 11));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 11));

            commands.AddLast(new AddEdgeCommand(4, 16, 5, 1, 17));
            commands.AddLast(new AddEdgeCommand(4, 16, 6, 1, 17));
            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 17));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 17));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 21));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 21));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 21));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 21));
        }

        private void BuildScreen17(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(2, 3));

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));

            commands.AddLast(new AddTreeCommand(2, 0, 5));
            commands.AddLast(new AddTreeCommand(2, 1, 5));
            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));



            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));


            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));
            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 4, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));
            commands.AddLast(new AddTreeCommand(2, 2, 10));
            commands.AddLast(new AddTreeCommand(2, 3, 10));
            commands.AddLast(new AddTreeCommand(2, 4, 10));
            commands.AddLast(new AddTreeCommand(2, 5, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));
            commands.AddLast(new AddTreeCommand(2, 4, 11));
            commands.AddLast(new AddTreeCommand(2, 5, 11));
            commands.AddLast(new AddTreeCommand(2, 6, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));
            commands.AddLast(new AddTreeCommand(2, 4, 12));
            commands.AddLast(new AddTreeCommand(2, 5, 12));
            commands.AddLast(new AddTreeCommand(2, 6, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));


            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));


            commands.AddLast(new AddEdgeCommand(4, 0, 6, 3, 16));
            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 16));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 16));

            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 12));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 12));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 12));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 12));

            commands.AddLast(new AddEdgeCommand(4, 16, 5, 1, 18));
            commands.AddLast(new AddEdgeCommand(4, 16, 6, 1, 18));
            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 18));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 18));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 22));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 22));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 22));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 22));
        }

        private void BuildScreen18(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(3, 3));

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));



            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));



            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));
            commands.AddLast(new AddTreeCommand(2, 5, 13));
            commands.AddLast(new AddTreeCommand(2, 6, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));
            commands.AddLast(new AddTreeCommand(2, 5, 14));
            commands.AddLast(new AddTreeCommand(2, 6, 14));


            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 12, 9));
            commands.AddLast(new AddTreeCommand(2, 13, 9));
            commands.AddLast(new AddTreeCommand(2, 14, 9));
            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 11, 10));
            commands.AddLast(new AddTreeCommand(2, 12, 10));
            commands.AddLast(new AddTreeCommand(2, 13, 10));
            commands.AddLast(new AddTreeCommand(2, 14, 10));
            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 11, 11));
            commands.AddLast(new AddTreeCommand(2, 12, 11));
            commands.AddLast(new AddTreeCommand(2, 13, 11));
            commands.AddLast(new AddTreeCommand(2, 14, 11));
            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 11, 12));
            commands.AddLast(new AddTreeCommand(2, 12, 12));
            commands.AddLast(new AddTreeCommand(2, 13, 12));
            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 11, 13));
            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 11, 14));
            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));


            commands.AddLast(new AddEdgeCommand(4, 0, 5, 3, 17));
            commands.AddLast(new AddEdgeCommand(4, 0, 6, 3, 17));
            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 17));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 17));

            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 13));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 13));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 13));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 13));

            commands.AddLast(new AddEdgeCommand(4, 16, 4, 1, 19));
            commands.AddLast(new AddEdgeCommand(4, 16, 5, 1, 19));
            commands.AddLast(new AddEdgeCommand(4, 16, 6, 1, 19));
            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 19));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 19));

            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 23));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 23));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 23));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 23));
        }

        private void BuildScreen19(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(4, 3));

            // Upper-left forest. Think Composite!!!
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));



            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(2, 12, 5));
            commands.AddLast(new AddTreeCommand(2, 13, 5));
            commands.AddLast(new AddTreeCommand(2, 14, 5));
            commands.AddLast(new AddTreeCommand(2, 15, 5));
            commands.AddLast(new AddTreeCommand(2, 16, 5));


            // Lower-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 9));
            commands.AddLast(new AddTreeCommand(2, 1, 9));
            commands.AddLast(new AddTreeCommand(2, 2, 9));
            commands.AddLast(new AddTreeCommand(2, 3, 9));
            commands.AddLast(new AddTreeCommand(2, 4, 9));

            commands.AddLast(new AddTreeCommand(2, 0, 10));
            commands.AddLast(new AddTreeCommand(2, 1, 10));
            commands.AddLast(new AddTreeCommand(2, 2, 10));
            commands.AddLast(new AddTreeCommand(2, 3, 10));
            commands.AddLast(new AddTreeCommand(2, 4, 10));

            commands.AddLast(new AddTreeCommand(2, 0, 11));
            commands.AddLast(new AddTreeCommand(2, 1, 11));
            commands.AddLast(new AddTreeCommand(2, 2, 11));
            commands.AddLast(new AddTreeCommand(2, 3, 11));
            commands.AddLast(new AddTreeCommand(2, 4, 11));

            commands.AddLast(new AddTreeCommand(2, 0, 12));
            commands.AddLast(new AddTreeCommand(2, 1, 12));
            commands.AddLast(new AddTreeCommand(2, 2, 12));
            commands.AddLast(new AddTreeCommand(2, 3, 12));
            commands.AddLast(new AddTreeCommand(2, 4, 12));

            commands.AddLast(new AddTreeCommand(2, 0, 13));
            commands.AddLast(new AddTreeCommand(2, 1, 13));
            commands.AddLast(new AddTreeCommand(2, 2, 13));
            commands.AddLast(new AddTreeCommand(2, 3, 13));
            commands.AddLast(new AddTreeCommand(2, 4, 13));

            commands.AddLast(new AddTreeCommand(2, 0, 14));
            commands.AddLast(new AddTreeCommand(2, 1, 14));
            commands.AddLast(new AddTreeCommand(2, 2, 14));
            commands.AddLast(new AddTreeCommand(2, 3, 14));
            commands.AddLast(new AddTreeCommand(2, 4, 14));


            // Lower-right forest
            commands.AddLast(new AddTreeCommand(2, 15, 5));
            commands.AddLast(new AddTreeCommand(2, 16, 5));

            commands.AddLast(new AddTreeCommand(2, 15, 6));
            commands.AddLast(new AddTreeCommand(2, 16, 6));

            commands.AddLast(new AddTreeCommand(2, 15, 7));
            commands.AddLast(new AddTreeCommand(2, 16, 7));

            commands.AddLast(new AddTreeCommand(2, 15, 8));
            commands.AddLast(new AddTreeCommand(2, 16, 8));

            commands.AddLast(new AddTreeCommand(2, 15, 9));
            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 15, 10));
            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 14, 12));
            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 12, 13));
            commands.AddLast(new AddTreeCommand(2, 13, 13));
            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddTreeCommand(2, 12, 14));
            commands.AddLast(new AddTreeCommand(2, 13, 14));
            commands.AddLast(new AddTreeCommand(2, 14, 14));
            commands.AddLast(new AddTreeCommand(2, 15, 14));
            commands.AddLast(new AddTreeCommand(2, 16, 14));

            commands.AddLast(new AddEdgeCommand(4, 0, 5, 3, 18));
            commands.AddLast(new AddEdgeCommand(4, 0, 6, 3, 18));
            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 18));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 18));

            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 14));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 14));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 14));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 14));

            commands.AddLast(new AddEdgeCommand(4, 5, 14, 2, 24));
            commands.AddLast(new AddEdgeCommand(4, 6, 14, 2, 24));
            commands.AddLast(new AddEdgeCommand(4, 7, 14, 2, 24));
            commands.AddLast(new AddEdgeCommand(4, 8, 14, 2, 24));
            commands.AddLast(new AddEdgeCommand(4, 9, 14, 2, 24));
            commands.AddLast(new AddEdgeCommand(4, 10, 14, 2, 24));
            commands.AddLast(new AddEdgeCommand(4, 11, 14, 2, 24));
        }

        private void BuildScreen20(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 4));

            commands.AddLast(new AddWaterCommand(2, 0, 0));
            commands.AddLast(new AddWaterCommand(2, 1, 0));
            commands.AddLast(new AddWaterCommand(2, 2, 0));
            commands.AddLast(new AddWaterCommand(2, 3, 0));
            commands.AddLast(new AddWaterCommand(2, 4, 0));
            commands.AddLast(new AddWaterCommand(2, 5, 0));
            commands.AddLast(new AddWaterCommand(2, 6, 0));
            commands.AddLast(new AddWaterCommand(2, 7, 0));

            commands.AddLast(new AddWaterCommand(2, 0, 1));
            commands.AddLast(new AddWaterCommand(2, 1, 1));
            commands.AddLast(new AddWaterCommand(2, 2, 1));
            commands.AddLast(new AddWaterCommand(2, 3, 1));
            commands.AddLast(new AddWaterCommand(2, 4, 1));
            commands.AddLast(new AddWaterCommand(2, 5, 1));
            commands.AddLast(new AddWaterCommand(2, 6, 1));
            commands.AddLast(new AddWaterCommand(2, 7, 1));

            commands.AddLast(new AddWaterCommand(2, 0, 2));
            commands.AddLast(new AddWaterCommand(2, 1, 2));
            commands.AddLast(new AddWaterCommand(2, 2, 2));
            commands.AddLast(new AddWaterCommand(2, 3, 2));
            commands.AddLast(new AddWaterCommand(2, 4, 2));
            commands.AddLast(new AddWaterCommand(2, 5, 2));
            commands.AddLast(new AddWaterCommand(2, 6, 2));
            commands.AddLast(new AddWaterCommand(2, 7, 2));

            commands.AddLast(new AddWaterCommand(2, 0, 3));
            commands.AddLast(new AddWaterCommand(2, 1, 3));
            commands.AddLast(new AddWaterCommand(2, 2, 3));
            commands.AddLast(new AddWaterCommand(2, 3, 3));
            commands.AddLast(new AddWaterCommand(2, 4, 3));
            commands.AddLast(new AddWaterCommand(2, 5, 3));
            commands.AddLast(new AddWaterCommand(2, 6, 3));
            commands.AddLast(new AddWaterCommand(2, 7, 3));

            commands.AddLast(new AddWaterCommand(2, 0, 4));
            commands.AddLast(new AddWaterCommand(2, 1, 4));
            commands.AddLast(new AddWaterCommand(2, 2, 4));
            commands.AddLast(new AddWaterCommand(2, 3, 4));
            commands.AddLast(new AddWaterCommand(2, 4, 4));
            commands.AddLast(new AddWaterCommand(2, 5, 4));
            commands.AddLast(new AddWaterCommand(2, 6, 4));
            commands.AddLast(new AddWaterCommand(2, 7, 4));

            commands.AddLast(new AddWaterCommand(2, 0, 5));
            commands.AddLast(new AddWaterCommand(2, 1, 5));
            commands.AddLast(new AddWaterCommand(2, 2, 5));
            commands.AddLast(new AddWaterCommand(2, 3, 5));
            commands.AddLast(new AddWaterCommand(2, 4, 5));
            commands.AddLast(new AddWaterCommand(2, 5, 5));
            commands.AddLast(new AddWaterCommand(2, 6, 5));
            commands.AddLast(new AddWaterCommand(2, 7, 5));

            commands.AddLast(new AddWaterCommand(2, 0, 6));
            commands.AddLast(new AddWaterCommand(2, 1, 6));
            commands.AddLast(new AddWaterCommand(2, 2, 6));
            commands.AddLast(new AddWaterCommand(2, 3, 6));
            commands.AddLast(new AddWaterCommand(2, 4, 6));
            commands.AddLast(new AddWaterCommand(2, 5, 6));
            commands.AddLast(new AddWaterCommand(2, 6, 6));
            commands.AddLast(new AddWaterCommand(2, 7, 6));

            commands.AddLast(new AddWaterCommand(2, 0, 7));
            commands.AddLast(new AddWaterCommand(2, 1, 7));
            commands.AddLast(new AddWaterCommand(2, 2, 7));
            commands.AddLast(new AddWaterCommand(2, 3, 7));
            commands.AddLast(new AddWaterCommand(2, 4, 7));
            commands.AddLast(new AddWaterCommand(2, 5, 7));
            commands.AddLast(new AddWaterCommand(2, 6, 7));
            commands.AddLast(new AddWaterCommand(2, 7, 7));

            commands.AddLast(new AddWaterCommand(2, 0, 8));
            commands.AddLast(new AddWaterCommand(2, 1, 8));
            commands.AddLast(new AddWaterCommand(2, 2, 8));
            commands.AddLast(new AddWaterCommand(2, 3, 8));
            commands.AddLast(new AddWaterCommand(2, 4, 8));
            commands.AddLast(new AddWaterCommand(2, 5, 8));
            commands.AddLast(new AddWaterCommand(2, 6, 8));
            commands.AddLast(new AddWaterCommand(2, 7, 8));




            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));



            commands.AddLast(new AddWaterCommand(2, 0, 9));
            commands.AddLast(new AddWaterCommand(2, 1, 9));
            commands.AddLast(new AddWaterCommand(2, 2, 9));
            commands.AddLast(new AddWaterCommand(2, 3, 9));
            commands.AddLast(new AddWaterCommand(2, 4, 9));
            commands.AddLast(new AddWaterCommand(2, 5, 9));
            commands.AddLast(new AddWaterCommand(2, 6, 9));
            commands.AddLast(new AddWaterCommand(2, 7, 9));
            commands.AddLast(new AddWaterCommand(2, 8, 9));
            commands.AddLast(new AddWaterCommand(2, 9, 9));
            commands.AddLast(new AddWaterCommand(2, 10, 9));
            commands.AddLast(new AddWaterCommand(2, 11, 9));
            commands.AddLast(new AddWaterCommand(2, 12, 9));
            commands.AddLast(new AddWaterCommand(2, 13, 9));
            commands.AddLast(new AddWaterCommand(2, 14, 9));
            commands.AddLast(new AddWaterCommand(2, 15, 9));
            commands.AddLast(new AddWaterCommand(2, 16, 9));

            commands.AddLast(new AddWaterCommand(2, 0, 10));
            commands.AddLast(new AddWaterCommand(2, 1, 10));
            commands.AddLast(new AddWaterCommand(2, 2, 10));
            commands.AddLast(new AddWaterCommand(2, 3, 10));
            commands.AddLast(new AddWaterCommand(2, 4, 10));
            commands.AddLast(new AddWaterCommand(2, 5, 10));
            commands.AddLast(new AddWaterCommand(2, 6, 10));
            commands.AddLast(new AddWaterCommand(2, 7, 10));
            commands.AddLast(new AddWaterCommand(2, 8, 10));
            commands.AddLast(new AddWaterCommand(2, 9, 10));
            commands.AddLast(new AddWaterCommand(2, 10, 10));
            commands.AddLast(new AddWaterCommand(2, 11, 10));
            commands.AddLast(new AddWaterCommand(2, 12, 10));
            commands.AddLast(new AddWaterCommand(2, 13, 10));
            commands.AddLast(new AddWaterCommand(2, 14, 10));
            commands.AddLast(new AddWaterCommand(2, 15, 10));
            commands.AddLast(new AddWaterCommand(2, 16, 10));

            commands.AddLast(new AddWaterCommand(2, 0, 11));
            commands.AddLast(new AddWaterCommand(2, 1, 11));
            commands.AddLast(new AddWaterCommand(2, 2, 11));
            commands.AddLast(new AddWaterCommand(2, 3, 11));
            commands.AddLast(new AddWaterCommand(2, 4, 11));
            commands.AddLast(new AddWaterCommand(2, 5, 11));
            commands.AddLast(new AddWaterCommand(2, 6, 11));
            commands.AddLast(new AddWaterCommand(2, 7, 11));
            commands.AddLast(new AddWaterCommand(2, 8, 11));
            commands.AddLast(new AddWaterCommand(2, 9, 11));
            commands.AddLast(new AddWaterCommand(2, 10, 11));
            commands.AddLast(new AddWaterCommand(2, 11, 11));
            commands.AddLast(new AddWaterCommand(2, 12, 11));
            commands.AddLast(new AddWaterCommand(2, 13, 11));
            commands.AddLast(new AddWaterCommand(2, 14, 11));
            commands.AddLast(new AddWaterCommand(2, 15, 11));
            commands.AddLast(new AddWaterCommand(2, 16, 11));



            commands.AddLast(new AddWaterCommand(2, 0, 12));
            commands.AddLast(new AddWaterCommand(2, 1, 12));
            commands.AddLast(new AddWaterCommand(2, 2, 12));
            commands.AddLast(new AddWaterCommand(2, 3, 12));
            commands.AddLast(new AddWaterCommand(2, 4, 12));
            commands.AddLast(new AddWaterCommand(2, 5, 12));
            commands.AddLast(new AddWaterCommand(2, 6, 12));
            commands.AddLast(new AddWaterCommand(2, 7, 12));
            commands.AddLast(new AddWaterCommand(2, 8, 12));
            commands.AddLast(new AddWaterCommand(2, 9, 12));
            commands.AddLast(new AddWaterCommand(2, 10, 12));
            commands.AddLast(new AddWaterCommand(2, 11, 12));
            commands.AddLast(new AddWaterCommand(2, 12, 12));
            commands.AddLast(new AddWaterCommand(2, 13, 12));
            commands.AddLast(new AddWaterCommand(2, 14, 12));
            commands.AddLast(new AddWaterCommand(2, 15, 12));
            commands.AddLast(new AddWaterCommand(2, 16, 12));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));
            commands.AddLast(new AddWaterCommand(2, 3, 13));
            commands.AddLast(new AddWaterCommand(2, 4, 13));
            commands.AddLast(new AddWaterCommand(2, 5, 13));
            commands.AddLast(new AddWaterCommand(2, 6, 13));
            commands.AddLast(new AddWaterCommand(2, 7, 13));
            commands.AddLast(new AddWaterCommand(2, 8, 13));
            commands.AddLast(new AddWaterCommand(2, 9, 13));
            commands.AddLast(new AddWaterCommand(2, 10, 13));
            commands.AddLast(new AddWaterCommand(2, 11, 13));
            commands.AddLast(new AddWaterCommand(2, 12, 13));
            commands.AddLast(new AddWaterCommand(2, 13, 13));
            commands.AddLast(new AddWaterCommand(2, 14, 13));
            commands.AddLast(new AddWaterCommand(2, 15, 13));
            commands.AddLast(new AddWaterCommand(2, 16, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));
            commands.AddLast(new AddWaterCommand(2, 3, 14));
            commands.AddLast(new AddWaterCommand(2, 4, 14));
            commands.AddLast(new AddWaterCommand(2, 5, 14));
            commands.AddLast(new AddWaterCommand(2, 6, 14));
            commands.AddLast(new AddWaterCommand(2, 7, 14));
            commands.AddLast(new AddWaterCommand(2, 8, 14));
            commands.AddLast(new AddWaterCommand(2, 9, 14));
            commands.AddLast(new AddWaterCommand(2, 10, 14));
            commands.AddLast(new AddWaterCommand(2, 11, 14));
            commands.AddLast(new AddWaterCommand(2, 12, 14));
            commands.AddLast(new AddWaterCommand(2, 13, 14));
            commands.AddLast(new AddWaterCommand(2, 14, 14));
            commands.AddLast(new AddWaterCommand(2, 15, 14));
            commands.AddLast(new AddWaterCommand(2, 16, 14));



            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 15));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 15));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 15));

            commands.AddLast(new AddEdgeCommand(4, 16, 5, 1, 21));
            commands.AddLast(new AddEdgeCommand(4, 16, 6, 1, 21));
            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 21));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 21));

        }

        private void BuildScreen21(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(1, 4));

            // Upper-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));

            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));

            commands.AddLast(new AddTreeCommand(2, 2, 6));


            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));




            commands.AddLast(new AddWaterCommand(2, 0, 9));
            commands.AddLast(new AddWaterCommand(2, 1, 9));
            commands.AddLast(new AddWaterCommand(2, 2, 9));
            commands.AddLast(new AddWaterCommand(2, 3, 9));
            commands.AddLast(new AddWaterCommand(2, 4, 9));
            commands.AddLast(new AddWaterCommand(2, 5, 9));
            commands.AddLast(new AddWaterCommand(2, 6, 9));
            commands.AddLast(new AddWaterCommand(2, 7, 9));
            commands.AddLast(new AddWaterCommand(2, 8, 9));
            commands.AddLast(new AddWaterCommand(2, 9, 9));
            commands.AddLast(new AddWaterCommand(2, 10, 9));
            commands.AddLast(new AddWaterCommand(2, 11, 9));
            commands.AddLast(new AddWaterCommand(2, 12, 9));
            commands.AddLast(new AddWaterCommand(2, 13, 9));
            commands.AddLast(new AddWaterCommand(2, 14, 9));
            commands.AddLast(new AddWaterCommand(2, 15, 9));
            commands.AddLast(new AddWaterCommand(2, 16, 9));

            commands.AddLast(new AddWaterCommand(2, 0, 10));
            commands.AddLast(new AddWaterCommand(2, 1, 10));
            commands.AddLast(new AddWaterCommand(2, 2, 10));
            commands.AddLast(new AddWaterCommand(2, 3, 10));
            commands.AddLast(new AddWaterCommand(2, 4, 10));
            commands.AddLast(new AddWaterCommand(2, 5, 10));
            commands.AddLast(new AddWaterCommand(2, 6, 10));
            commands.AddLast(new AddWaterCommand(2, 7, 10));
            commands.AddLast(new AddWaterCommand(2, 8, 10));
            commands.AddLast(new AddWaterCommand(2, 9, 10));
            commands.AddLast(new AddWaterCommand(2, 10, 10));
            commands.AddLast(new AddWaterCommand(2, 11, 10));
            commands.AddLast(new AddWaterCommand(2, 12, 10));
            commands.AddLast(new AddWaterCommand(2, 13, 10));
            commands.AddLast(new AddWaterCommand(2, 14, 10));
            commands.AddLast(new AddWaterCommand(2, 15, 10));
            commands.AddLast(new AddWaterCommand(2, 16, 10));

            commands.AddLast(new AddWaterCommand(2, 0, 11));
            commands.AddLast(new AddWaterCommand(2, 1, 11));
            commands.AddLast(new AddWaterCommand(2, 2, 11));
            commands.AddLast(new AddWaterCommand(2, 3, 11));
            commands.AddLast(new AddWaterCommand(2, 4, 11));
            commands.AddLast(new AddWaterCommand(2, 5, 11));
            commands.AddLast(new AddWaterCommand(2, 6, 11));
            commands.AddLast(new AddWaterCommand(2, 7, 11));
            commands.AddLast(new AddWaterCommand(2, 8, 11));
            commands.AddLast(new AddWaterCommand(2, 9, 11));
            commands.AddLast(new AddWaterCommand(2, 10, 11));
            commands.AddLast(new AddWaterCommand(2, 11, 11));
            commands.AddLast(new AddWaterCommand(2, 12, 11));
            commands.AddLast(new AddWaterCommand(2, 13, 11));
            commands.AddLast(new AddWaterCommand(2, 14, 11));
            commands.AddLast(new AddWaterCommand(2, 15, 11));
            commands.AddLast(new AddWaterCommand(2, 16, 11));



            commands.AddLast(new AddWaterCommand(2, 0, 12));
            commands.AddLast(new AddWaterCommand(2, 1, 12));
            commands.AddLast(new AddWaterCommand(2, 2, 12));
            commands.AddLast(new AddWaterCommand(2, 3, 12));
            commands.AddLast(new AddWaterCommand(2, 4, 12));
            commands.AddLast(new AddWaterCommand(2, 5, 12));
            commands.AddLast(new AddWaterCommand(2, 6, 12));
            commands.AddLast(new AddWaterCommand(2, 7, 12));
            commands.AddLast(new AddWaterCommand(2, 8, 12));
            commands.AddLast(new AddWaterCommand(2, 9, 12));
            commands.AddLast(new AddWaterCommand(2, 10, 12));
            commands.AddLast(new AddWaterCommand(2, 11, 12));
            commands.AddLast(new AddWaterCommand(2, 12, 12));
            commands.AddLast(new AddWaterCommand(2, 13, 12));
            commands.AddLast(new AddWaterCommand(2, 14, 12));
            commands.AddLast(new AddWaterCommand(2, 15, 12));
            commands.AddLast(new AddWaterCommand(2, 16, 12));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));
            commands.AddLast(new AddWaterCommand(2, 3, 13));
            commands.AddLast(new AddWaterCommand(2, 4, 13));
            commands.AddLast(new AddWaterCommand(2, 5, 13));
            commands.AddLast(new AddWaterCommand(2, 6, 13));
            commands.AddLast(new AddWaterCommand(2, 7, 13));
            commands.AddLast(new AddWaterCommand(2, 8, 13));
            commands.AddLast(new AddWaterCommand(2, 9, 13));
            commands.AddLast(new AddWaterCommand(2, 10, 13));
            commands.AddLast(new AddWaterCommand(2, 11, 13));
            commands.AddLast(new AddWaterCommand(2, 12, 13));
            commands.AddLast(new AddWaterCommand(2, 13, 13));
            commands.AddLast(new AddWaterCommand(2, 14, 13));
            commands.AddLast(new AddWaterCommand(2, 15, 13));
            commands.AddLast(new AddWaterCommand(2, 16, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));
            commands.AddLast(new AddWaterCommand(2, 3, 14));
            commands.AddLast(new AddWaterCommand(2, 4, 14));
            commands.AddLast(new AddWaterCommand(2, 5, 14));
            commands.AddLast(new AddWaterCommand(2, 6, 14));
            commands.AddLast(new AddWaterCommand(2, 7, 14));
            commands.AddLast(new AddWaterCommand(2, 8, 14));
            commands.AddLast(new AddWaterCommand(2, 9, 14));
            commands.AddLast(new AddWaterCommand(2, 10, 14));
            commands.AddLast(new AddWaterCommand(2, 11, 14));
            commands.AddLast(new AddWaterCommand(2, 12, 14));
            commands.AddLast(new AddWaterCommand(2, 13, 14));
            commands.AddLast(new AddWaterCommand(2, 14, 14));
            commands.AddLast(new AddWaterCommand(2, 15, 14));
            commands.AddLast(new AddWaterCommand(2, 16, 14));

            commands.AddLast(new AddEdgeCommand(4, 0, 5, 3, 20));
            commands.AddLast(new AddEdgeCommand(4, 0, 6, 3, 20));
            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 20));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 20));

            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 16));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 16));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 16));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 16));

            commands.AddLast(new AddEdgeCommand(4, 16, 5, 1, 22));
            commands.AddLast(new AddEdgeCommand(4, 16, 6, 1, 22));
            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 22));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 22));

        }

        private void BuildScreen22(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(2, 4));

            // Upper-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));
            commands.AddLast(new AddTreeCommand(2, 5, 2));
            commands.AddLast(new AddTreeCommand(2, 6, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));
            commands.AddLast(new AddTreeCommand(2, 5, 3));
            commands.AddLast(new AddTreeCommand(2, 6, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));

            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));






            commands.AddLast(new AddWaterCommand(2, 0, 9));
            commands.AddLast(new AddWaterCommand(2, 1, 9));
            commands.AddLast(new AddWaterCommand(2, 2, 9));
            commands.AddLast(new AddWaterCommand(2, 3, 9));

            commands.AddLast(new AddWaterCommand(2, 0, 10));
            commands.AddLast(new AddWaterCommand(2, 1, 10));
            commands.AddLast(new AddWaterCommand(2, 2, 10));
            commands.AddLast(new AddWaterCommand(2, 3, 10));

            commands.AddLast(new AddWaterCommand(2, 0, 11));
            commands.AddLast(new AddWaterCommand(2, 1, 11));
            commands.AddLast(new AddWaterCommand(2, 2, 11));
            commands.AddLast(new AddWaterCommand(2, 3, 11));

            commands.AddLast(new AddWaterCommand(2, 13, 9));
            commands.AddLast(new AddWaterCommand(2, 14, 9));
            commands.AddLast(new AddWaterCommand(2, 15, 9));
            commands.AddLast(new AddWaterCommand(2, 16, 9));

            commands.AddLast(new AddWaterCommand(2, 13, 10));
            commands.AddLast(new AddWaterCommand(2, 14, 10));
            commands.AddLast(new AddWaterCommand(2, 15, 10));
            commands.AddLast(new AddWaterCommand(2, 16, 10));

            commands.AddLast(new AddWaterCommand(2, 13, 11));
            commands.AddLast(new AddWaterCommand(2, 14, 11));
            commands.AddLast(new AddWaterCommand(2, 15, 11));
            commands.AddLast(new AddWaterCommand(2, 16, 11));


            commands.AddLast(new AddWaterCommand(2, 0, 12));
            commands.AddLast(new AddWaterCommand(2, 1, 12));
            commands.AddLast(new AddWaterCommand(2, 2, 12));
            commands.AddLast(new AddWaterCommand(2, 3, 12));
            commands.AddLast(new AddWaterCommand(2, 4, 12));
            commands.AddLast(new AddWaterCommand(2, 5, 12));
            commands.AddLast(new AddWaterCommand(2, 6, 12));
            commands.AddLast(new AddWaterCommand(2, 7, 12));
            commands.AddLast(new AddWaterCommand(2, 8, 12));
            commands.AddLast(new AddWaterCommand(2, 9, 12));
            commands.AddLast(new AddWaterCommand(2, 10, 12));
            commands.AddLast(new AddWaterCommand(2, 11, 12));
            commands.AddLast(new AddWaterCommand(2, 12, 12));
            commands.AddLast(new AddWaterCommand(2, 13, 12));
            commands.AddLast(new AddWaterCommand(2, 14, 12));
            commands.AddLast(new AddWaterCommand(2, 15, 12));
            commands.AddLast(new AddWaterCommand(2, 16, 12));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));
            commands.AddLast(new AddWaterCommand(2, 3, 13));
            commands.AddLast(new AddWaterCommand(2, 4, 13));
            commands.AddLast(new AddWaterCommand(2, 5, 13));
            commands.AddLast(new AddWaterCommand(2, 6, 13));
            commands.AddLast(new AddWaterCommand(2, 7, 13));
            commands.AddLast(new AddWaterCommand(2, 8, 13));
            commands.AddLast(new AddWaterCommand(2, 9, 13));
            commands.AddLast(new AddWaterCommand(2, 10, 13));
            commands.AddLast(new AddWaterCommand(2, 11, 13));
            commands.AddLast(new AddWaterCommand(2, 12, 13));
            commands.AddLast(new AddWaterCommand(2, 13, 13));
            commands.AddLast(new AddWaterCommand(2, 14, 13));
            commands.AddLast(new AddWaterCommand(2, 15, 13));
            commands.AddLast(new AddWaterCommand(2, 16, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));
            commands.AddLast(new AddWaterCommand(2, 3, 14));
            commands.AddLast(new AddWaterCommand(2, 4, 14));
            commands.AddLast(new AddWaterCommand(2, 5, 14));
            commands.AddLast(new AddWaterCommand(2, 6, 14));
            commands.AddLast(new AddWaterCommand(2, 7, 14));
            commands.AddLast(new AddWaterCommand(2, 8, 14));
            commands.AddLast(new AddWaterCommand(2, 9, 14));
            commands.AddLast(new AddWaterCommand(2, 10, 14));
            commands.AddLast(new AddWaterCommand(2, 11, 14));
            commands.AddLast(new AddWaterCommand(2, 12, 14));
            commands.AddLast(new AddWaterCommand(2, 13, 14));
            commands.AddLast(new AddWaterCommand(2, 14, 14));
            commands.AddLast(new AddWaterCommand(2, 15, 14));
            commands.AddLast(new AddWaterCommand(2, 16, 14));


            commands.AddLast(new AddEdgeCommand(4, 0, 5, 3, 21));
            commands.AddLast(new AddEdgeCommand(4, 0, 6, 3, 21));
            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 21));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 21));

            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 17));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 17));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 17));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 17));

            commands.AddLast(new AddEdgeCommand(4, 16, 5, 1, 23));
            commands.AddLast(new AddEdgeCommand(4, 16, 6, 1, 23));
            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 23));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 23));

        }

        private void BuildScreen23(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(3, 4));

            // Upper-left forest
            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));
            commands.AddLast(new AddTreeCommand(2, 5, 0));
            commands.AddLast(new AddTreeCommand(2, 6, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));
            commands.AddLast(new AddTreeCommand(2, 5, 1));
            commands.AddLast(new AddTreeCommand(2, 6, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));


            // Upper-right forest
            commands.AddLast(new AddTreeCommand(2, 11, 0));
            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 11, 1));
            commands.AddLast(new AddTreeCommand(2, 12, 1));
            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 11, 2));
            commands.AddLast(new AddTreeCommand(2, 12, 2));
            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 11, 3));
            commands.AddLast(new AddTreeCommand(2, 12, 3));
            commands.AddLast(new AddTreeCommand(2, 13, 3));
            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 12, 4));
            commands.AddLast(new AddTreeCommand(2, 13, 4));
            commands.AddLast(new AddTreeCommand(2, 14, 4));
            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(2, 12, 5));
            commands.AddLast(new AddTreeCommand(2, 13, 5));
            commands.AddLast(new AddTreeCommand(2, 14, 5));
            commands.AddLast(new AddTreeCommand(2, 15, 5));
            commands.AddLast(new AddTreeCommand(2, 16, 5));


            commands.AddLast(new AddWaterCommand(2, 0, 9));
            commands.AddLast(new AddWaterCommand(2, 0, 10));
            commands.AddLast(new AddWaterCommand(2, 0, 11));
            commands.AddLast(new AddWaterCommand(2, 0, 12));
            commands.AddLast(new AddWaterCommand(2, 0, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));
            commands.AddLast(new AddWaterCommand(2, 3, 13));
            commands.AddLast(new AddWaterCommand(2, 4, 13));
            commands.AddLast(new AddWaterCommand(2, 5, 13));
            commands.AddLast(new AddWaterCommand(2, 6, 13));
            commands.AddLast(new AddWaterCommand(2, 7, 13));
            commands.AddLast(new AddWaterCommand(2, 8, 13));
            commands.AddLast(new AddWaterCommand(2, 9, 13));
            commands.AddLast(new AddWaterCommand(2, 10, 13));
            commands.AddLast(new AddWaterCommand(2, 11, 13));
            commands.AddLast(new AddWaterCommand(2, 12, 13));
            commands.AddLast(new AddWaterCommand(2, 13, 13));
            commands.AddLast(new AddWaterCommand(2, 14, 13));
            commands.AddLast(new AddWaterCommand(2, 15, 13));
            commands.AddLast(new AddWaterCommand(2, 16, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));
            commands.AddLast(new AddWaterCommand(2, 3, 14));
            commands.AddLast(new AddWaterCommand(2, 4, 14));
            commands.AddLast(new AddWaterCommand(2, 5, 14));
            commands.AddLast(new AddWaterCommand(2, 6, 14));
            commands.AddLast(new AddWaterCommand(2, 7, 14));
            commands.AddLast(new AddWaterCommand(2, 8, 14));
            commands.AddLast(new AddWaterCommand(2, 9, 14));
            commands.AddLast(new AddWaterCommand(2, 10, 14));
            commands.AddLast(new AddWaterCommand(2, 11, 14));
            commands.AddLast(new AddWaterCommand(2, 12, 14));
            commands.AddLast(new AddWaterCommand(2, 13, 14));
            commands.AddLast(new AddWaterCommand(2, 14, 14));
            commands.AddLast(new AddWaterCommand(2, 15, 14));
            commands.AddLast(new AddWaterCommand(2, 16, 14));



            commands.AddLast(new AddEdgeCommand(4, 0, 5, 3, 22));
            commands.AddLast(new AddEdgeCommand(4, 0, 6, 3, 22));
            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 22));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 22));

            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 18));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 18));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 18));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 18));

            commands.AddLast(new AddEdgeCommand(4, 16, 5, 1, 24));
            commands.AddLast(new AddEdgeCommand(4, 16, 6, 1, 24));
            commands.AddLast(new AddEdgeCommand(4, 16, 7, 1, 24));
            commands.AddLast(new AddEdgeCommand(4, 16, 8, 1, 24));
            commands.AddLast(new AddEdgeCommand(4, 16, 9, 1, 24));
            commands.AddLast(new AddEdgeCommand(4, 16, 10, 1, 24));
            commands.AddLast(new AddEdgeCommand(4, 16, 11, 1, 24));
            commands.AddLast(new AddEdgeCommand(4, 16, 12, 1, 24));
        }

        private void BuildScreen24(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(4, 4));

            commands.AddLast(new AddTreeCommand(2, 0, 0));
            commands.AddLast(new AddTreeCommand(2, 1, 0));
            commands.AddLast(new AddTreeCommand(2, 2, 0));
            commands.AddLast(new AddTreeCommand(2, 3, 0));
            commands.AddLast(new AddTreeCommand(2, 4, 0));

            commands.AddLast(new AddTreeCommand(2, 0, 1));
            commands.AddLast(new AddTreeCommand(2, 1, 1));
            commands.AddLast(new AddTreeCommand(2, 2, 1));
            commands.AddLast(new AddTreeCommand(2, 3, 1));
            commands.AddLast(new AddTreeCommand(2, 4, 1));

            commands.AddLast(new AddTreeCommand(2, 0, 2));
            commands.AddLast(new AddTreeCommand(2, 1, 2));
            commands.AddLast(new AddTreeCommand(2, 2, 2));
            commands.AddLast(new AddTreeCommand(2, 3, 2));
            commands.AddLast(new AddTreeCommand(2, 4, 2));

            commands.AddLast(new AddTreeCommand(2, 0, 3));
            commands.AddLast(new AddTreeCommand(2, 1, 3));
            commands.AddLast(new AddTreeCommand(2, 2, 3));
            commands.AddLast(new AddTreeCommand(2, 3, 3));
            commands.AddLast(new AddTreeCommand(2, 4, 3));

            commands.AddLast(new AddTreeCommand(2, 0, 4));
            commands.AddLast(new AddTreeCommand(2, 1, 4));
            commands.AddLast(new AddTreeCommand(2, 2, 4));
            commands.AddLast(new AddTreeCommand(2, 3, 4));
            commands.AddLast(new AddTreeCommand(2, 4, 4));

            commands.AddLast(new AddTreeCommand(2, 2, 5));
            commands.AddLast(new AddTreeCommand(2, 3, 5));

            commands.AddLast(new AddTreeCommand(2, 12, 0));
            commands.AddLast(new AddTreeCommand(2, 13, 0));
            commands.AddLast(new AddTreeCommand(2, 14, 0));
            commands.AddLast(new AddTreeCommand(2, 15, 0));
            commands.AddLast(new AddTreeCommand(2, 16, 0));

            commands.AddLast(new AddTreeCommand(2, 13, 1));
            commands.AddLast(new AddTreeCommand(2, 14, 1));
            commands.AddLast(new AddTreeCommand(2, 15, 1));
            commands.AddLast(new AddTreeCommand(2, 16, 1));

            commands.AddLast(new AddTreeCommand(2, 13, 2));
            commands.AddLast(new AddTreeCommand(2, 14, 2));
            commands.AddLast(new AddTreeCommand(2, 15, 2));
            commands.AddLast(new AddTreeCommand(2, 16, 2));

            commands.AddLast(new AddTreeCommand(2, 14, 3));
            commands.AddLast(new AddTreeCommand(2, 15, 3));
            commands.AddLast(new AddTreeCommand(2, 16, 3));

            commands.AddLast(new AddTreeCommand(2, 15, 4));
            commands.AddLast(new AddTreeCommand(2, 16, 4));

            commands.AddLast(new AddTreeCommand(2, 16, 5));

            commands.AddLast(new AddTreeCommand(2, 16, 6));

            commands.AddLast(new AddTreeCommand(2, 16, 7));

            commands.AddLast(new AddTreeCommand(2, 16, 8));

            commands.AddLast(new AddTreeCommand(2, 16, 9));

            commands.AddLast(new AddTreeCommand(2, 16, 10));

            commands.AddLast(new AddTreeCommand(2, 15, 11));
            commands.AddLast(new AddTreeCommand(2, 16, 11));

            commands.AddLast(new AddTreeCommand(2, 15, 12));
            commands.AddLast(new AddTreeCommand(2, 16, 12));

            commands.AddLast(new AddTreeCommand(2, 14, 13));
            commands.AddLast(new AddTreeCommand(2, 15, 13));
            commands.AddLast(new AddTreeCommand(2, 16, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 13));
            commands.AddLast(new AddWaterCommand(2, 1, 13));
            commands.AddLast(new AddWaterCommand(2, 2, 13));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));

            commands.AddLast(new AddWaterCommand(2, 0, 14));
            commands.AddLast(new AddWaterCommand(2, 1, 14));
            commands.AddLast(new AddWaterCommand(2, 2, 14));
            commands.AddLast(new AddWaterCommand(2, 3, 14));
            commands.AddLast(new AddWaterCommand(2, 4, 14));
            commands.AddLast(new AddWaterCommand(2, 5, 14));
            commands.AddLast(new AddWaterCommand(2, 6, 14));
            commands.AddLast(new AddWaterCommand(2, 7, 14));
            commands.AddLast(new AddWaterCommand(2, 8, 14));
            commands.AddLast(new AddWaterCommand(2, 9, 14));
            commands.AddLast(new AddWaterCommand(2, 10, 14));
            commands.AddLast(new AddWaterCommand(2, 11, 14));
            commands.AddLast(new AddWaterCommand(2, 12, 14));
            commands.AddLast(new AddWaterCommand(2, 13, 14));
            commands.AddLast(new AddWaterCommand(2, 14, 14));
            commands.AddLast(new AddWaterCommand(2, 15, 14));
            commands.AddLast(new AddWaterCommand(2, 16, 14));

            commands.AddLast(new AddEdgeCommand(4, 0, 5, 3, 23));
            commands.AddLast(new AddEdgeCommand(4, 0, 6, 3, 23));
            commands.AddLast(new AddEdgeCommand(4, 0, 7, 3, 23));
            commands.AddLast(new AddEdgeCommand(4, 0, 8, 3, 23));
            commands.AddLast(new AddEdgeCommand(4, 0, 9, 3, 23));
            commands.AddLast(new AddEdgeCommand(4, 0, 10, 3, 23));
            commands.AddLast(new AddEdgeCommand(4, 0, 11, 3, 23));
            commands.AddLast(new AddEdgeCommand(4, 0, 12, 3, 23));

            commands.AddLast(new AddEdgeCommand(4, 5, 0, 0, 19));
            commands.AddLast(new AddEdgeCommand(4, 6, 0, 0, 19));
            commands.AddLast(new AddEdgeCommand(4, 7, 0, 0, 19));
            commands.AddLast(new AddEdgeCommand(4, 8, 0, 0, 19));
            commands.AddLast(new AddEdgeCommand(4, 9, 0, 0, 19));
            commands.AddLast(new AddEdgeCommand(4, 10, 0, 0, 19));
            commands.AddLast(new AddEdgeCommand(4, 11, 0, 0, 19));
        }

        private void BuildScreen25(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand());
        }
    }
}
