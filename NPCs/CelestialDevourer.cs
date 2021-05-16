using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace theangelurdsmod.NPCs
{
    public class CelestialDevourer : ModNPC
    {
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (spawnInfo.player.ZoneRockLayerHeight && NPC.downedMoonlord)
            {
                return 0.6f;
            }
            else
            {
                return 0f;
            }
        }
        public float shoot1;
        private float shoot2;
        public int phase;
        public int speed;
        public float rotation;
        public float gravityResist;
        public int projectileDamage;
        public override void AI()
        {
            var player = Main.player[npc.target];
            Vector2 playerpos = player.Center;
            float playerdir = (playerpos - npc.Center).ToRotation();
            Vector2 shootdir = new Vector2((float)Math.Cos(playerdir), (float)Math.Sin(playerdir)) * 10;
            shoot2++;
            if (shoot2 > shoot1)
            {
                Projectile.NewProjectile(npc.Center, shootdir, ProjectileID.PhantasmalBolt, projectileDamage, 8, Main.myPlayer);
                shoot2 = 0;
            }
            Vector2 playerdir2 = playerpos - npc.Center;
            playerdir2.Normalize();
            npc.velocity = Vector2.Lerp(npc.velocity, playerdir2 * speed, gravityResist);
            npc.width = 264;
            npc.height = 126;
            npc.rotation += rotation;
            if (npc.life < npc.lifeMax / 4 && phase == 0)
            {
                phase++;
                speed += 7;
                npc.damage += 131;
                npc.defense += 46;
                shoot1 -= 50;
                gravityResist += 0.005f;
            }
            if (npc.life < npc.lifeMax / 7 && phase == 1)
            {
                phase++;
                npc.damage += 34;
                speed += 8;
            }
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Celestial Devourer");
        }
        public override void SetDefaults()
        {
            npc.lifeMax = 28700;
            npc.damage = 178;
            npc.defense = 67;
            npc.value = Item.buyPrice(0, 3, 47, 70);
            npc.lavaImmune = true;
            shoot1 = 100;
            shoot2 = 0;
            speed = 19;
            gravityResist = 0.02f;
            projectileDamage = 38;
        }
        public override void NPCLoot()
        {
            {
                Item.NewItem(npc.Center, mod.ItemType("CelestialEssence"), Main.rand.Next(17, 27));
                if (Main.rand.Next(0, 5) == 10)
                {
                    Item.NewItem(npc.Center, mod.ItemType("CelestialThrower"), 1);
                }
            }
        }
    }
}