using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace theangelurdsmod.Projectiles
{
    public class BoneShards : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.timeLeft = 840;
            projectile.ignoreWater = true;
            projectile.tileCollide = true;
            projectile.width = 82;
            projectile.height = 46;
        }
        public override void Kill(int timeLeft)
        {
            for (int i = 0; i < 4; i++)
            {
                int dust = Dust.NewDust(projectile.Center + new Vector2(Main.rand.Next(-32, 32), Main.rand.Next(-32, 32)), 0, 0, mod.DustType("MaliciousRockDust"));
                Main.dust[dust].noGravity = false;
            }
        }
        public override void AI()
        {
            projectile.velocity.Y += 0.1f;
            projectile.rotation = projectile.velocity.ToRotation();
        }
    }
}