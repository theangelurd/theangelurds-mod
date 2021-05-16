using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace theangelurdsmod.NPCs
{
    [AutoloadBossHead]
    public class StarKeeper : ModNPC
    {
        public float shoot1;
        private float shoot2;
        public float shoot3;
        private float shoot4;
        public int phase;
        public float speed;
        public float rotation;
        public float gravityResist;
        public int projectileDamage;
        public int projectileDamage2;
        public int projectileDamage3;
        public int projectileDamage4;
        int homingProjectile1;
        public int shoot5;
        private int shoot6;
        public int shoot7;
        private int shoot8;
        public int shoot9;
        private int shoot10;
        private Vector2 offset;
        public override void AI()
        {
            var player = Main.player[npc.target];
            Vector2 playerpos = player.Center;
            Vector2 playerposoffset = playerpos + offset;
            float playerdir = (playerposoffset - npc.Center).ToRotation();
            Vector2 shootdir = new Vector2((float)Math.Cos(playerdir), (float)Math.Sin(playerdir)) * 10;
            shoot2++;
            shoot8++;
            if (shoot2 > shoot1)
            {
                int par = Projectile.NewProjectile(npc.Center, shootdir, mod.ProjectileType("CelestialBolt"), projectileDamage, 8, Main.myPlayer);
                Main.projectile[par].ai[0] = npc.target;
                shoot2 = 0;
            }
            if (shoot8 > shoot7)
            {
                int par = Projectile.NewProjectile(npc.Center, shootdir, mod.ProjectileType("StarFragment"), projectileDamage3, 7, Main.myPlayer);
                Main.projectile[par].ai[0] = npc.target;
                shoot8 = 0;
            }
            if (phase >= 1)
            {
                shoot4++;
                if (shoot4 > shoot3)
                {
                    int par = Projectile.NewProjectile(npc.Center, shootdir, mod.ProjectileType("CelestialBall"), projectileDamage2, 8, Main.myPlayer);
                    Main.projectile[par].ai[0] = npc.target;
                    shoot4 = 0;
                }
            }
            if (phase >= 1)
            {
                shoot10++;
                if (shoot10 > shoot9)
                {
                    int par = Projectile.NewProjectile(npc.Center, shootdir, mod.ProjectileType("CelestialFlame"), projectileDamage4, 8, Main.myPlayer);
                    Main.projectile[par].ai[0] = npc.target;
                    shoot10 = 0;
                }
            }
            if (phase >= 2)
            {
                shoot6++;
                if (shoot6 > shoot5)
                {
                    int par = Projectile.NewProjectile(npc.Center, shootdir, mod.ProjectileType("CelestialStar"), projectileDamage3, 13, Main.myPlayer);
                    Main.projectile[par].ai[0] = npc.target;
                    shoot6 = 0;
                }
            }
            Vector2 playerdir2 = playerposoffset - npc.Center;
            playerdir2.Normalize();
            npc.velocity = Vector2.Lerp(npc.velocity, playerdir2 * speed, gravityResist);
            npc.width = 376;
            npc.height = 212;
            npc.rotation += rotation;
            if (npc.life < npc.lifeMax / 2 && phase == 0)
            {
                phase++;
                npc.defense += 13;
                shoot1 -= 15;
                gravityResist += 0.3f;
            }
            if (npc.life < npc.lifeMax / 5 && phase == 1)
            {
                phase++;
                npc.defense += 134;
                shoot1 -= 10;
                gravityResist += 0.3f;
                projectileDamage += 2;
                shoot3 -= 20;
                offset = Vector2.Zero;
            }
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Star Keeper");
        }
        public override void SetDefaults()
        {
            npc.lifeMax = 214000;
            npc.damage = 139;
            npc.defense = 21;
            npc.value = Item.buyPrice(0, 34, 91, 70);
            npc.lavaImmune = true;
            shoot1 = 70;
            shoot2 = 0;
            speed = 9;
            gravityResist = 0.7f;
            shoot3 = 100;
            shoot4 = 0;
            shoot7 = 140;
            shoot8 = 0;
            shoot9 = 40;
            shoot10 = 0;
            music = MusicID.Boss2;
            npc.knockBackResist = 0;
            projectileDamage = 38;
            projectileDamage2 = 78;
            projectileDamage3 = 47;
            projectileDamage4 = 51;
            shoot5 = 60;
            shoot6 = 0;
            offset = new Vector2(0, -320);
            npc.noTileCollide = true;
            npc.boss = true;
        }
        public override void NPCLoot()
        {
            if (!theangelurdWorld.celestialboss)
            {
                theangelurdWorld.celestialboss = true;
            }
            {
                Item.NewItem(npc.Center, mod.ItemType("CelestialEssence"), Main.rand.Next(37, 57));
                Item.NewItem(npc.Center, ItemID.SuperHealingPotion, Main.rand.Next(7, 15));
                if (Main.rand.Next(0, 5) == 4)
                {
                    Item.NewItem(npc.Center, mod.ItemType("StarFall"), 1);
                }
                if (Main.rand.Next(0, 5) == 4)
                {
                    Item.NewItem(npc.Center, mod.ItemType("CelestialKnife"), 1);
                }
                if (Main.rand.Next(0, 5) == 4)
                {
                    Item.NewItem(npc.Center, mod.ItemType("CelestialPhaser"), 1);
                }

            }
        }
    }
}