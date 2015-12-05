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

            // Could specify color in the region then let
            //  individual subdivisions override, if need to.
            commands.AddLast(new DeclareLandCommand(0, 5, 5, 2, 2));

            commands.AddLast(new DeclareDungeonCommand(1, 5, 7, 2, 6));
            commands.AddLast(new DeclareDungeonCommand(2, 6, 7, 3, 4));
            commands.AddLast(new DeclareDungeonCommand(3, 7, 5, 3, 1));
            commands.AddLast(new DeclareDungeonCommand(4, 7, 7, 3, 3));
            commands.AddLast(new DeclareDungeonCommand(5, 9, 10, 5, 7));
            //commands.AddLast(new DeclareDungeonCommand("Dungeon6", 5, 5));
            //commands.AddLast(new DeclareDungeonCommand("Dungeon7", 5, 5));

            //commands.AddLast(new DeclareCaveCommand("CaveGetFirstSword", 1, 1));
            //commands.AddLast(new DeclareCaveCommand("Cave1", 5, 5));
            //commands.AddLast(new DeclareCaveCommand("Cave2", 5, 5));
            //commands.AddLast(new DeclareCaveCommand("Cave3", 5, 5));



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

            // Dungeon 1
            BuildScreen25(commands);
            BuildScreen26(commands);
            BuildScreen27(commands);
            BuildScreen28(commands);
            BuildScreen29(commands);
            BuildScreen30(commands);
            BuildScreen32(commands);
            BuildScreen33(commands);

            BuildScreen35(commands);
            BuildScreen39(commands);
            BuildScreen40(commands);

            BuildScreen43(commands);
            BuildScreen44(commands);
            BuildScreen45(commands);

            BuildScreen48(commands);
            BuildScreen53(commands);

            // Dungeon 2
            BuildScreen54(commands);
            BuildScreen55(commands);
            BuildScreen56(commands);
            BuildScreen58(commands);

            BuildScreen60(commands);
            BuildScreen62(commands);
            BuildScreen64(commands);

            BuildScreen66(commands);
            BuildScreen67(commands);
            BuildScreen68(commands);
            BuildScreen69(commands);
            BuildScreen70(commands);
            BuildScreen71(commands);

            BuildScreen74(commands);
            BuildScreen76(commands);

            BuildScreen79(commands);
            BuildScreen80(commands);
            BuildScreen81(commands);
            BuildScreen82(commands);

            BuildScreen88(commands);

            BuildScreen94(commands);


            // Dungeon 3
            BuildScreen101(commands);
            BuildScreen105(commands);

            BuildScreen107(commands);
            BuildScreen108(commands);
            BuildScreen109(commands);
            BuildScreen110(commands);
            BuildScreen111(commands);
            BuildScreen112(commands);
            BuildScreen113(commands);

            BuildScreen114(commands);
            BuildScreen116(commands);
            BuildScreen118(commands);
            BuildScreen120(commands);

            BuildScreen121(commands);
            BuildScreen122(commands);
            BuildScreen123(commands);
            BuildScreen124(commands);
            BuildScreen125(commands);
            BuildScreen126(commands);
            BuildScreen127(commands);

            BuildScreen129(commands);
            BuildScreen133(commands);

            // Dungeon 4
            BuildScreen140(commands);

            BuildScreen141(commands);
            BuildScreen142(commands);
            BuildScreen143(commands);

            BuildScreen144(commands);
            BuildScreen145(commands);
            BuildScreen146(commands);
            BuildScreen147(commands);
            BuildScreen148(commands);

            BuildScreen149(commands);
            BuildScreen150(commands);
            BuildScreen151(commands);
            BuildScreen152(commands);
            BuildScreen153(commands);
            BuildScreen154(commands);

            BuildScreen155(commands);
            BuildScreen156(commands);
            BuildScreen157(commands);
            BuildScreen158(commands);

            BuildScreen159(commands);
            BuildScreen160(commands);
            BuildScreen161(commands);
            BuildScreen162(commands);

            BuildScreen163(commands);
            BuildScreen164(commands);

            // Dungeon 5
            BuildScreen200(commands);

            BuildScreen201(commands);

            BuildScreen202(commands);
            BuildScreen203(commands);
            BuildScreen204(commands);
            BuildScreen205(commands);

            BuildScreen206(commands);
            BuildScreen207(commands);
            BuildScreen208(commands);
            BuildScreen209(commands);
            BuildScreen210(commands);
            BuildScreen211(commands);
            BuildScreen212(commands);

            BuildScreen213(commands);
            BuildScreen214(commands);
            BuildScreen215(commands);

            BuildScreen216(commands);
            BuildScreen217(commands);
            BuildScreen218(commands);
            BuildScreen219(commands);
            BuildScreen220(commands);
            BuildScreen221(commands);
            BuildScreen222(commands);

            BuildScreen223(commands);
            BuildScreen224(commands);

            BuildScreen225(commands);
            BuildScreen226(commands);

            BuildScreen227(commands);
            BuildScreen228(commands);

            BuildScreen229(commands);













            //SemanticCheckCommands(commands);
            return commands;
        }

        private void BuildScreen0(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareLotCommand(0, 0, 0, 222, 184, 135));

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

            commands.AddLast(new AddStairsCommand(2, 4, 7, 2));



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
            commands.AddLast(new DeclareLotCommand(0, 1, 0, 222, 184, 135));

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
            commands.AddLast(new DeclareLotCommand(0, 2, 0, 222, 184, 135));

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
            commands.AddLast(new DeclareLotCommand(0, 3, 0, 222, 184, 135));

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
            commands.AddLast(new DeclareLotCommand(0, 4, 0, 222, 184, 135));

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
            commands.AddLast(new DeclareLotCommand(0, 0, 1, 222, 184, 135));

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
            commands.AddLast(new DeclareLotCommand(0, 1, 1, 222, 184, 135));

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
            commands.AddLast(new DeclareLotCommand(0, 2, 1, 222, 184, 135));

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
            commands.AddLast(new DeclareLotCommand(0, 3, 1, 222, 184, 135));

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

            commands.AddLast(new AddStairsCommand(2, 14, 2, 4));


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
            commands.AddLast(new DeclareLotCommand(0, 4, 1, 222, 184, 135));

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
            commands.AddLast(new DeclareLotCommand(0, 0, 2, 222, 184, 135));

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
            commands.AddLast(new DeclareLotCommand(0, 1, 2, 222, 184, 135));

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
            commands.AddLast(new DeclareLotCommand(0, 2, 2, 222, 184, 135));

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
            commands.AddLast(new AddStairsCommand(2, 4, 4, 5));

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
            commands.AddLast(new DeclareLotCommand(0, 3, 2, 222, 184, 135));

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
            commands.AddLast(new DeclareLotCommand(0, 4, 2, 222, 184, 135));

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
            commands.AddLast(new DeclareLotCommand(0, 0, 3, 222, 184, 135));

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
            commands.AddLast(new DeclareLotCommand(0, 1, 3, 222, 184, 135));

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
            commands.AddLast(new DeclareLotCommand(0, 2, 3, 222, 184, 135));

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
            commands.AddLast(new DeclareLotCommand(0, 3, 3, 222, 184, 135));

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
            commands.AddLast(new DeclareLotCommand(0, 4, 3, 222, 184, 135));

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
            commands.AddLast(new DeclareLotCommand(0, 0, 4, 222, 184, 135));

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
            commands.AddLast(new DeclareLotCommand(0, 1, 4, 222, 184, 135));

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
            commands.AddLast(new AddStairsCommand(2, 4, 3, 3));
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
            commands.AddLast(new DeclareLotCommand(0, 2, 4, 222, 184, 135));

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
            commands.AddLast(new DeclareLotCommand(0, 3, 4, 222, 184, 135));

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
            commands.AddLast(new DeclareLotCommand(0, 4, 4, 222, 184, 135));

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
            commands.AddLast(new DeclareCaveCommand(1, 2, 6, 104, 133, 195));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 28));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 28));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 28));
        }

        private void BuildScreen26(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 0, 5, 104, 133, 195));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 27));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 27));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 27));
        }

        private void BuildScreen27(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 1, 5, 104, 133, 195));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 26));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 26));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 26));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 28));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 28));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 28));
        }

        private void BuildScreen28(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 2, 5, 104, 133, 195));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 32));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 32));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 32));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 29));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 29));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 29));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 25));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 25));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 25));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 27));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 27));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 27));
        }

        private void BuildScreen29(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 3, 5, 104, 133, 195));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 32));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 32));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 32));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 30));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 30));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 30));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 25));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 25));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 25));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 28));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 28));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 28));

        }

        private void BuildScreen30(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 4, 5, 104, 133, 195));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 35));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 35));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 35));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 30));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 30));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 30));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 25));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 25));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 25));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 29));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 29));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 29));

        }

        private void BuildScreen32(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 1, 4, 104, 133, 195));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 35));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 35));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 35));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 33));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 33));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 33));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 25));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 25));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 25));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 29));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 29));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 29));
        }

        private void BuildScreen33(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 2, 4, 104, 133, 195));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 35));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 35));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 35));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 33));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 33));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 33));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 28));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 28));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 28));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 32));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 32));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 32));
        }

        private void BuildScreen35(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 4, 4, 104, 133, 195));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 40));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 40));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 40));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 33));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 33));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 33));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 30));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 30));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 30));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 32));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 32));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 32));
        }

        private void BuildScreen39(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 3, 3, 104, 133, 195));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 40));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 40));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 40));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 40));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 40));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 40));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 30));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 30));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 30));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 32));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 32));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 32));
        }

        private void BuildScreen40(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 4, 3, 104, 133, 195));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 40));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 40));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 40));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 33));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 33));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 33));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 35));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 35));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 35));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 39));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 39));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 39));
        }

        private void BuildScreen43(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 2, 2, 104, 133, 195));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 48));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 48));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 48));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 44));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 44));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 44));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 35));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 35));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 35));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 39));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 39));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 39));
        }

        private void BuildScreen44(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 3, 2, 104, 133, 195));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 45));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 45));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 45));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 45));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 45));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 39));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 39));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 39));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 43));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 43));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 43));
        }

        private void BuildScreen45(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 4, 2, 104, 133, 195));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 45));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 45));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 45));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 45));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 45));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 45));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 39));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 39));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 39));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 44));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 44));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 44));
        }

        private void BuildScreen48(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 2, 1, 104, 133, 195));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 53));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 53));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 53));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 45));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 45));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 43));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 43));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 43));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 44));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 44));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 44));
        }

        private void BuildScreen53(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(1, 2, 0, 104, 133, 195));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 53));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 53));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 53));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 45));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 45));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 48));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 48));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 48));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 44));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 44));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 44));
        }

        private void BuildScreen54(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 0, 6, 65, 182, 73));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 60));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 60));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 60));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 55));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 55));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 55));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 48));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 48));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 48));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 44));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 44));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 44));
        }

        private void BuildScreen55(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 1, 6, 65, 182, 73));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 60));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 60));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 60));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 56));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 56));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 56));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 48));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 48));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 48));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 54));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 54));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 54));
        }

        private void BuildScreen56(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 2, 6, 65, 182, 73));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 62));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 62));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 62));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 56));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 56));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 56));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 48));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 48));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 48));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 55));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 55));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 55));
        }

        private void BuildScreen58(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 4, 6, 65, 182, 73));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 64));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 64));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 64));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 56));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 56));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 56));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 48));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 48));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 48));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 55));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 55));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 55));
        }

        private void BuildScreen60(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 0, 5, 65, 182, 73));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 66));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 66));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 66));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 56));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 56));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 56));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 54));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 54));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 54));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 55));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 55));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 55));
        }

        private void BuildScreen62(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 2, 5, 65, 182, 73));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 68));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 68));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 68));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 56));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 56));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 56));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 56));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 56));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 56));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 55));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 55));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 55));
        }

        private void BuildScreen64(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 4, 5, 65, 182, 73));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 70));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 70));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 70));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 56));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 56));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 56));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 58));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 58));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 58));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 55));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 55));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 55));
        }

        private void BuildScreen66(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 0, 4, 65, 182, 73));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 70));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 70));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 70));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 56));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 56));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 56));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 60));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 60));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 60));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 55));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 55));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 55));
        }

        private void BuildScreen67(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 1, 4, 65, 182, 73));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 70));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 70));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 70));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 68));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 68));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 68));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 60));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 60));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 60));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 55));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 55));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 55));
        }

        private void BuildScreen68(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 2, 4, 65, 182, 73));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 70));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 70));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 70));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 69));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 69));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 69));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 62));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 62));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 62));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 67));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 67));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 67));
        }

        private void BuildScreen69(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 3, 4, 65, 182, 73));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 70));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 70));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 70));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 70));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 70));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 70));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 60));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 60));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 60));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 68));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 68));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 68));
        }

        private void BuildScreen70(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 4, 4, 65, 182, 73));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 76));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 76));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 76));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 71));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 71));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 71));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 64));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 64));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 64));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 69));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 69));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 69));
        }

        private void BuildScreen71(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 5, 4, 65, 182, 73));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 70));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 70));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 70));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 71));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 71));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 71));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 60));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 60));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 60));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 70));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 70));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 70));
        }

        private void BuildScreen74(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 2, 3, 65, 182, 73));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 80));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 80));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 80));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 71));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 71));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 71));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 60));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 60));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 60));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 70));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 70));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 70));
        }

        private void BuildScreen76(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 4, 3, 65, 182, 73));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 82));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 82));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 82));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 71));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 71));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 71));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 76));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 76));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 76));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 70));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 70));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 70));
        }

        private void BuildScreen79(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 1, 2, 65, 182, 73));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 82));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 82));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 82));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 80));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 80));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 80));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 76));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 76));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 76));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 70));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 70));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 70));
        }

        private void BuildScreen80(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 2, 2, 65, 182, 73));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 82));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 82));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 82));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 81));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 81));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 81));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 74));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 74));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 74));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 79));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 79));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 79));
        }

        private void BuildScreen81(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 3, 2, 65, 182, 73));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 82));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 82));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 82));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 82));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 82));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 82));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 74));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 74));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 74));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 80));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 80));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 80));
        }

        private void BuildScreen82(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 4, 2, 65, 182, 73));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 88));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 88));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 88));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 83));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 83));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 83));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 76));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 76));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 76));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 81));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 81));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 81));
        }

        private void BuildScreen88(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 4, 1, 65, 182, 73));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 94));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 94));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 94));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 83));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 83));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 83));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 82));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 82));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 82));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 81));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 81));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 81));
        }

        private void BuildScreen94(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(2, 4, 0, 65, 182, 73));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 88));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 88));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 88));
        }

        private void BuildScreen101(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 1, 4, 200, 205, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 108));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 108));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 108));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 83));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 83));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 83));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 82));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 82));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 82));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 81));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 81));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 81));
        }

        private void BuildScreen105(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 5, 4, 200, 205, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 112));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 112));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 112));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 83));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 83));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 83));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 82));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 82));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 82));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 81));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 81));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 81));
        }

        private void BuildScreen107(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 0, 3, 200, 205, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 114));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 114));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 114));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 108));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 108));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 108));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 82));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 82));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 82));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 81));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 81));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 81));
        }

        private void BuildScreen108(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 1, 3, 200, 205, 45));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 114));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 114));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 114));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 109));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 109));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 109));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 101));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 101));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 101));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 107));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 107));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 107));
        }

        private void BuildScreen109(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 2, 3, 200, 205, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 116));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 116));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 116));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 109));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 109));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 109));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 101));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 101));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 101));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 108));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 108));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 108));
        }

        private void BuildScreen110(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 3, 3, 200, 205, 45));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 116));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 116));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 116));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 111));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 111));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 111));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 101));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 101));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 101));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 108));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 108));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 108));
        }

        private void BuildScreen111(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 4, 3, 200, 205, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 118));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 118));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 118));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 112));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 112));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 112));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 101));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 101));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 101));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 110));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 110));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 110));
        }

        private void BuildScreen112(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 5, 3, 200, 205, 45));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 118));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 118));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 118));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 113));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 113));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 113));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 105));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 105));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 105));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 111));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 111));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 111));
        }

        private void BuildScreen113(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 6, 3, 200, 205, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 120));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 120));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 120));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 113));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 113));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 113));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 105));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 105));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 105));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 112));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 112));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 112));
        }

        private void BuildScreen114(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 0, 2, 200, 205, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 121));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 121));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 121));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 113));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 113));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 113));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 107));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 107));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 107));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 111));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 111));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 111));
        }

        private void BuildScreen116(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 2, 2, 200, 205, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 123));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 123));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 123));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 113));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 113));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 113));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 109));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 109));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 109));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 111));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 111));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 111));
        }

        private void BuildScreen118(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 4, 2, 200, 205, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 125));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 125));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 125));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 113));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 113));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 113));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 111));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 111));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 111));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 111));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 111));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 111));
        }

        private void BuildScreen120(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 6, 2, 200, 205, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 127));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 127));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 127));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 113));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 113));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 113));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 113));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 113));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 113));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 111));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 111));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 111));
        }

        private void BuildScreen121(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 0, 1, 200, 205, 45));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 127));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 127));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 127));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 122));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 122));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 122));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 114));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 114));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 114));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 111));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 111));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 111));
        }

        private void BuildScreen122(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 1, 1, 200, 205, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 129));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 129));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 129));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 122));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 122));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 122));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 114));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 114));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 114));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 121));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 121));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 121));
        }

        private void BuildScreen123(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 2, 1, 200, 205, 45));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 127));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 127));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 127));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 124));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 124));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 124));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 116));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 116));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 116));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 121));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 121));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 121));
        }

        private void BuildScreen124(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 3, 1, 200, 205, 45));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 127));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 127));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 127));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 125));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 125));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 125));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 116));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 116));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 116));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 123));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 123));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 123));
        }

        private void BuildScreen125(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 4, 1, 200, 205, 45));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 127));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 127));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 127));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 126));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 126));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 126));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 118));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 118));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 118));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 124));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 124));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 124));
        }

        private void BuildScreen126(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 5, 1, 200, 205, 45));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 133));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 133));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 133));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 124));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 124));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 124));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 118));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 118));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 118));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 125));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 125));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 125));
        }

        private void BuildScreen127(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 6, 1, 200, 205, 45));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 133));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 133));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 133));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 120));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 120));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 120));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 120));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 120));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 120));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 126));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 126));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 126));
        }

        private void BuildScreen129(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 1, 0, 200, 205, 45));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 133));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 133));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 133));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 120));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 120));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 120));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 122));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 122));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 122));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 126));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 126));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 126));
        }

        private void BuildScreen133(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(3, 5, 0, 200, 205, 45));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 133));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 133));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 133));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 120));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 120));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 120));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 126));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 126));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 126));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 126));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 126));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 126));
        }

        private void BuildScreen140(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 4, 6, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 142));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 142));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 142));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 120));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 120));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 120));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 126));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 126));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 126));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 126));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 126));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 126));
        }

        private void BuildScreen141(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 1, 5, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 144));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 144));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 144));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 120));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 120));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 120));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 126));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 126));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 126));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 126));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 126));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 126));
        }

        private void BuildScreen142(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 4, 5, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 146));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 146));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 146));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 143));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 143));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 143));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 140));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 140));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 140));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 126));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 126));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 126));
        }

        private void BuildScreen143(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 5, 5, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 147));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 147));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 147));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 142));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 142));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 142));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 140));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 140));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 140));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 142));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 142));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 142));
        }

        private void BuildScreen144(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 1, 4, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 150));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 150));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 150));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 145));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 145));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 145));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 141));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 141));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 141));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 142));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 142));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 142));
        }

        private void BuildScreen145(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 2, 4, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 151));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 151));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 151));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 145));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 145));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 145));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 141));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 141));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 141));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 144));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 144));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 144));
        }

        private void BuildScreen146(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 4, 4, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 153));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 153));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 153));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 147));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 147));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 147));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 142));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 142));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 142));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 144));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 144));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 144));
        }

        private void BuildScreen147(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 5, 4, 87, 80, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 153));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 153));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 153));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 148));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 148));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 148));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 143));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 143));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 143));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 146));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 146));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 146));
        }

        private void BuildScreen148(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 6, 4, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 154));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 154));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 154));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 148));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 148));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 148));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 143));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 143));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 143));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 147));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 147));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 147));
        }

        private void BuildScreen149(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 0, 3, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 155));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 155));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 155));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 150));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 150));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 150));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 143));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 143));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 143));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 147));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 147));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 147));
        }

        private void BuildScreen150(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 1, 3, 87, 80, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 151));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 151));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 151));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 151));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 151));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 151));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 144));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 144));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 144));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 149));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 149));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 149));
        }

        private void BuildScreen151(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 2, 3, 87, 80, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 151));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 151));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 151));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 152));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 152));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 152));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 145));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 145));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 145));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 150));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 150));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 150));
        }

        private void BuildScreen152(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 3, 3, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 157));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 157));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 157));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 153));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 153));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 153));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 145));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 145));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 145));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 151));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 151));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 151));
        }

        private void BuildScreen153(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 4, 3, 87, 80, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 157));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 157));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 157));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 153));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 153));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 153));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 146));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 146));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 146));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 152));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 152));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 152));
        }

        private void BuildScreen154(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 6, 3, 87, 80, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 157));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 157));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 157));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 153));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 153));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 153));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 148));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 148));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 148));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 152));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 152));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 152));
        }

        private void BuildScreen155(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 0, 2, 87, 80, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 157));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 157));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 157));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 153));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 153));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 153));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 149));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 149));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 149));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 152));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 152));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 152));
        }

        private void BuildScreen156(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 2, 2, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 159));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 159));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 159));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 153));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 153));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 153));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 149));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 149));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 149));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 152));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 152));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 152));
        }

        private void BuildScreen157(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 3, 2, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 160));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 160));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 160));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 158));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 158));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 158));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 152));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 152));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 152));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 152));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 152));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 152));
        }

        private void BuildScreen158(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 4, 2, 87, 80, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 160));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 160));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 160));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 158));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 158));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 158));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 152));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 152));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 152));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 157));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 157));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 157));
        }

        private void BuildScreen159(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 2, 1, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 163));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 163));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 163));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 160));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 160));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 160));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 156));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 156));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 156));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 157));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 157));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 157));
        }

        private void BuildScreen160(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 3, 1, 87, 80, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 161));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 161));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 161));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 161));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 161));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 161));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 157));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 157));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 157));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 159));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 159));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 159));
        }

        private void BuildScreen161(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 4, 1, 87, 80, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 161));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 161));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 161));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 162));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 162));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 157));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 157));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 157));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 160));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 160));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 160));
        }

        private void BuildScreen162(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 5, 1, 87, 80, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 164));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 164));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 164));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 162));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 162));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 157));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 157));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 157));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 161));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 161));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 161));
        }

        private void BuildScreen163(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 2, 0, 87, 80, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 164));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 164));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 164));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 162));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 162));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 159));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 159));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 159));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 161));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 161));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 161));
        }

        private void BuildScreen164(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(4, 5, 0, 87, 80, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 164));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 164));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 164));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 162));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 162));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 162));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 162));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 162));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 161));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 161));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 161));
        }

        private void BuildScreen200(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 5, 9, 205, 127, 47));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 201));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 201));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 201));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 162));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 162));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 162));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 162));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 162));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 162));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 161));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 161));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 161));
        }

        private void BuildScreen201(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 5, 8, 205, 127, 47));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 204));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 204));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 204));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 162));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 162));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 162));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 200));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 200));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 200));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 161));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 161));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 161));
        }

        private void BuildScreen202(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 3, 7, 205, 127, 47));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 209));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 209));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 209));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 203));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 203));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 203));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 200));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 200));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 200));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 161));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 161));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 161));
        }

        private void BuildScreen203(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 4, 7, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 209));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 209));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 209));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 204));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 204));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 204));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 200));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 200));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 200));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 202));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 202));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 202));
        }

        private void BuildScreen204(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 5, 7, 205, 127, 47));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 211));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 211));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 211));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 205));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 205));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 205));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 201));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 201));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 201));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 203));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 203));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 203));
        }

        private void BuildScreen205(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 6, 7, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 209));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 209));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 209));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 204));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 204));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 204));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 200));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 200));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 200));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 204));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 204));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 204));
        }

        private void BuildScreen206(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 0, 6, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 209));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 209));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 209));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 207));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 207));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 207));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 200));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 200));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 200));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 204));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 204));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 204));
        }

        private void BuildScreen207(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 1, 6, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 209));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 209));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 209));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 208));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 208));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 208));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 200));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 200));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 200));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 206));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 206));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 206));
        }

        private void BuildScreen208(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 2, 6, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 209));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 209));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 209));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 209));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 209));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 209));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 200));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 200));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 200));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 207));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 207));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 207));
        }

        private void BuildScreen209(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 3, 6, 205, 127, 47));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 213));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 213));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 213));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 210));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 210));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 210));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 202));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 202));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 202));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 208));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 208));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 208));
        }

        private void BuildScreen210(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 4, 6, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 213));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 213));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 213));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 210));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 210));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 210));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 202));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 202));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 202));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 209));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 209));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 209));
        }

        private void BuildScreen211(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 5, 6, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 213));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 213));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 213));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 210));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 210));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 210));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 204));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 204));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 204));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 209));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 209));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 209));
        }

        private void BuildScreen212(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 7, 6, 205, 127, 47));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 214));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 214));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 214));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 210));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 210));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 210));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 204));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 204));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 204));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 209));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 209));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 209));
        }

        private void BuildScreen213(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 3, 5, 205, 127, 47));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 218));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 218));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 218));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 210));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 210));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 210));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 209));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 209));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 209));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 209));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 209));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 209));
        }

        private void BuildScreen214(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 7, 5, 205, 127, 47));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 222));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 222));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 222));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 215));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 215));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 215));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 212));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 212));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 212));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 209));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 209));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 209));
        }

        private void BuildScreen215(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 8, 5, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 222));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 222));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 222));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 215));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 215));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 215));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 212));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 212));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 212));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 214));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 214));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 214));
        }

        private void BuildScreen216(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 1, 4, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 222));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 222));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 222));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 217));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 217));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 217));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 212));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 212));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 212));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 214));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 214));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 214));
        }

        private void BuildScreen217(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 2, 4, 205, 127, 47));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 225));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 225));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 225));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 218));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 218));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 218));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 212));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 212));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 212));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 216));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 216));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 216));
        }

        private void BuildScreen218(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 3, 4, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 225));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 225));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 225));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 219));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 219));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 219));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 213));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 213));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 213));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 217));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 217));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 217));
        }

        private void BuildScreen219(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 4, 4, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 225));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 225));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 225));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 220));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 220));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 220));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 213));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 213));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 213));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 218));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 218));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 218));
        }

        private void BuildScreen220(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 5, 4, 205, 127, 47));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 224));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 224));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 224));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 221));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 221));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 221));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 213));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 213));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 213));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 219));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 219));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 219));
        }

        private void BuildScreen221(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 6, 4, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 224));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 224));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 224));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 222));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 222));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 222));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 213));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 213));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 213));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 220));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 220));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 220));
        }

        private void BuildScreen222(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 7, 4, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 224));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 224));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 224));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 222));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 222));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 222));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 214));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 214));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 214));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 221));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 221));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 221));
        }

        private void BuildScreen223(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 2, 3, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 224));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 224));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 224));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 222));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 222));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 222));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 217));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 217));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 217));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 220));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 220));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 220));
        }

        private void BuildScreen224(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 5, 3, 205, 127, 47));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 225));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 225));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 225));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 222));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 222));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 222));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 220));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 220));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 220));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 220));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 220));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 220));
        }

        private void BuildScreen225(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 5, 2, 205, 127, 47));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 228));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 228));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 228));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 226));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 226));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 226));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 224));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 224));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 224));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 220));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 220));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 220));
        }

        private void BuildScreen226(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 6, 2, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 228));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 228));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 228));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 226));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 226));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 226));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 224));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 224));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 224));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 225));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 225));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 225));
        }

        private void BuildScreen227(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 4, 1, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 228));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 228));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 228));

            commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 228));
            commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 228));
            commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 228));

            //commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 224));
            //commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 224));
            //commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 224));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 225));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 225));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 225));
        }

        private void BuildScreen228(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 5, 1, 205, 127, 47));

            commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 229));
            commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 229));
            commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 229));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 228));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 228));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 228));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 225));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 225));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 225));

            commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 227));
            commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 227));
            commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 227));
        }

        private void BuildScreen229(LinkedList<BuildCommand> commands)
        {
            commands.AddLast(new DeclareCaveCommand(5, 5, 0, 205, 127, 47));

            //commands.AddLast(new AddEdgeCommand(4, 7, 1, 0, 229));
            //commands.AddLast(new AddEdgeCommand(4, 8, 1, 0, 229));
            //commands.AddLast(new AddEdgeCommand(4, 9, 1, 0, 229));

            //commands.AddLast(new AddEdgeCommand(4, 15, 6, 1, 228));
            //commands.AddLast(new AddEdgeCommand(4, 15, 7, 1, 228));
            //commands.AddLast(new AddEdgeCommand(4, 15, 8, 1, 228));

            commands.AddLast(new AddEdgeCommand(4, 7, 13, 2, 228));
            commands.AddLast(new AddEdgeCommand(4, 8, 13, 2, 228));
            commands.AddLast(new AddEdgeCommand(4, 9, 13, 2, 228));

            //commands.AddLast(new AddEdgeCommand(4, 1, 6, 3, 227));
            //commands.AddLast(new AddEdgeCommand(4, 1, 7, 3, 227));
            //commands.AddLast(new AddEdgeCommand(4, 1, 8, 3, 227));
        }
    }
}

