using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coliseum.Entites
{
    public class Entity
    {
        public int X;
        public int Y;

        public int size;

        public int idleFrames;
        public int runFrames;
        public int attackFrames;
        public int deathFrames;

        public Image spriteSheet;
        public Entity(int X, int Y, int idleFrames, int runFrames, int attackFrames, int deathFrames, Image spriteSheet)
        {
            this.X = X;
            this.Y = Y;
            this.idleFrames = idleFrames;
            this.runFrames = runFrames;
            this.attackFrames = attackFrames;
            this.deathFrames = deathFrames;
            this.spriteSheet = spriteSheet;
            size = 32;
        }
        public void Move(int shiftX, int shiftY)
        {
            X += shiftX;
            Y += shiftY;
        }
    }
}
