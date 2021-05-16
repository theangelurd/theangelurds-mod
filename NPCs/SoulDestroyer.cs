using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace theangelurdsmod.NPCs
{
    public class SoulDestroyer : ModNPC
    {
        public float shoot1;
        private float shoot2;
        public int phase;
        public int speed;
        public float rotation;
        public float gravityResist;
        public int projectileDamage;
        public float shoot3;
        private float shoot4;
        public float shoot5;
        private float shoot6;
        public float shoot7;
        private float shoot8;
        public int projectileDamage2;
        public int projectileDamage3;
        public int projectileDamage4;
        public bool charge;
        public bool charging;
        public int chargetimer;
        public int maxchargetimer;
        public int charges;
        public int frame;
        public Vector2 playerdashdir;
        public override void FindFrame(int frameHeight)
        {
            npc.frame.Y = frame * frameHeight;
            npc.frameCounter += 0.3f;
            if (phase == 0)
            {
                if (frame > 3) { frame = 0; }
                if (npc.frameCounter > 1)
                {
                    frame++;
                    if (frame > 3)
                    {
                        frame = 0;
                    }
                }
            }
            if (phase == 1)
            {
                if (frame > 5) { frame = 3; }
                if (frame < 3) { frame = 3; }
                if (npc.frameCounter > 1)
                {
                    frame++;
                    if (frame > 5)
                    {
                        frame = 3;
                    }
                }
            }
            if (phase == 2)
            {
                if (frame > 8) { frame = 5; }
                if (frame < 5) { frame = 5; }
                if (npc.frameCounter > 1)
                {
                    frame++;
                    if (frame > 2)
                    {
                        frame = 1;
                    }
                }
            }
        }
        public override void AI()
        {
            var player = Main.player[npc.target];
            Vector2 playerpos = player.Center;
            float playerdir = (playerpos - npc.Center).ToRotation();
            Vector2 shootdir = new Vector2((float)Math.Cos(playerdir), (float)Math.Sin(playerdir)) * 10;
            shoot2++;
            npc.rotation = npc.velocity.ToRotation();
            if (shoot2 > shoot1)
            {
                Projectile.NewProjectile(npc.Center, shootdir, mod.ProjectileType("SoulBullet"), projectileDamage, 8, Main.myPlayer);
                shoot2 = 0;
            }
            if (shoot4 > shoot3)
            {
                Projectile.NewProjectile(npc.Center, shootdir, mod.ProjectileType("SoulBulletBig"), projectileDamage2, 9, Main.myPlayer);
                shoot4 = 0;
            }
            Vector2 playerdir2 = playerpos - npc.Center;
            playerdir2.Normalize();
            if (!charging)
            {
                npc.velocity = Vector2.Lerp(npc.velocity, playerdir2 * speed, gravityResist);
            }
            chargetimer++;
            if (chargetimer > maxchargetimer)
            {
                charging = true;
                if (!charge)
                {
                    playerdashdir = playerpos - npc.Center;
                    charge = true;
                    playerdashdir.Normalize();
                }
                npc.velocity = Vector2.Lerp(npc.velocity, playerdashdir * 10, 0.21f);
                if (chargetimer > maxchargetimer + 50)
                {
                    chargetimer = maxchargetimer;
                    charge = false;
                    if (charges > 0) // change the 3 to any number you want it to dash
                    {
                        charging = false;
                        charges = 0;
                        chargetimer = 0;
                    }
                }
            }
            npc.width = 196;
            npc.height = 148;
            npc.rotation = npc.velocity.ToRotation();
            if (npc.life < npc.lifeMax / 2 && phase == 0)
            {
                phase++;
                speed += 2;
                npc.damage += 13;
                npc.defense += 59;
                gravityResist += 0.3f;
                rotation += 0.15f;
            }
            if (npc.life < npc.lifeMax / 5 && phase == 1)
            {
                phase++;
                speed += 4;
                npc.damage += 21;
                npc.defense += 23;
                gravityResist += 0.3f;
                projectileDamage += 20;
            }
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul Destroyer");
            Main.npcFrameCount[npc.type] = 9;
        }
        public override void SetDefaults()
        {
            npc.lifeMax = 307000;
            npc.damage = 118;
            npc.defense = 63;
            npc.value = Item.buyPrice(0, 40, 30, 10);
            npc.lavaImmune = true;
            shoot1 = 120;
            shoot2 = 0;
            shoot3 = 200;
            shoot4 = 0;
            shoot5 = 150;
            shoot6 = 0;
            shoot7 = 100;
            shoot8 = 0;
            projectileDamage = 73;
            projectileDamage2 = 97;
            projectileDamage3 = 109;
            projectileDamage4 = 81;
            npc.knockBackResist = 0;
            speed = 5;
            gravityResist = 0.21f;
            npc.noTileCollide = true;
        }
        public override void NPCLoot()
        {
            {
                Item.NewItem(npc.Center, mod.ItemType("CelestialEssence"), Main.rand.Next(6, 9));
            }
        }
    }
}