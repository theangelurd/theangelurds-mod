using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace theangelurdsmod.Projectiles
{
    public class CelestialBall : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.friendly = false;
            projectile.hostile = true;
            projectile.timeLeft = 480;
            projectile.ignoreWater = true;
            projectile.tileCollide = false;
            projectile.penetrate = 2;
            projectile.width = 58;
            projectile.height = 18;
        }
        public override void AI()
        {
            var player = Main.player[(int)projectile.ai[0]];
            projectile.velocity.Y += 0.1f;
            Vector2 playerpos = player.Center;
            Vector2 playerdir = (playerpos - projectile.Center);
            playerdir.Normalize();
            projectile.velocity = Vector2.Lerp(projectile.velocity, playerdir * 31, 0f);
            projectile.rotation = projectile.velocity.ToRotation();
        }
    }
}