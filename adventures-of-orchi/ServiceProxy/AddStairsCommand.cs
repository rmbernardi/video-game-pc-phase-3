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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProxy
{
    public sealed class AddStairsCommand : BuildCommand
    {
        private int type;
        private int layerId;
        private int x;
        private int y;
        private int destination;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public int LayerId
        {
            get { return layerId; }
            set { layerId = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public AddStairsCommand(int layerId, int x, int y, int destination)
        {
            this.type = 4;
            this.layerId = layerId;
            this.x = x;
            this.y = y;
            this.destination = destination;
        }
    }
}