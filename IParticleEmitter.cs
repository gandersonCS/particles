using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace ParticleSystemExercise
{
    public interface IParticleEmitter
    {
        public Vector2 Position {get; set;}

        public Vector2 Velocity {get; set;}
    }
}