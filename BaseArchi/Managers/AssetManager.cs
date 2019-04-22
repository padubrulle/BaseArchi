using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseArchi.Managers
{
    class AssetManager
    {
        public static ContentManager Content { get; private set; }

        public static void LoadContentManager(ContentManager content)
        {
            Content = content;
        }
    }
}
