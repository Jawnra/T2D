using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    public static class Globals
    {
        public static Vector2 flowPoint = new Vector2(0, 1.1f);
    }

    enum Dir
    {
        Up,
        Down,
        Left,
        Right
    }
}
