﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace 贪吃蛇
{
    public class SnakePart
    {
        public UIElement UiElement { set; get; }
        public Point Position { set; get; }
        public Boolean IsHead { set; get; }
    }
}
