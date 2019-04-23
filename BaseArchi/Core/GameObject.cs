using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace BaseArchi.Core
{
    abstract class GameObject
    {
        public Vector2 Position { get; protected set; }

        public GameObject()
        {
            Position = new Vector2(0,0);
        }

        public void ChangePosition(Vector2 _position)
        {
            Position = _position;
        }
    }
}
