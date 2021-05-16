using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace theangelurdsmod.Dusts
{
    public class MaliciousRockDust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.noGravity = false;
            dust.noLight = true;
            dust.scale += Main.rand.NextFloat(-0.2f, 0.2f);
        }
        public override bool Update(Dust dust)
        {
            dust.alpha += 5;
            dust.rotation += 0.1f;
            dust.velocity.Y += 0.3f;
            if (dust.alpha > 255)
            {
                dust.active = false;
            }
            return false;
        }
    }
}