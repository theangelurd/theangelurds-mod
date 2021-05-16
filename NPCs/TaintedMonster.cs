using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace theangelurdsmod.NPCs
{
    public class TaintedMonster : ModNPC
    {
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (spawnInfo.player.ZoneRockLayerHeight && theangelurdWorld.celestialboss)
            {
                return 0.4f;
            }
            else
            {
                return 0f;
            }
        }
        public int frame;
        public override void FindFrame(int frameHeight)
        {
            npc.frame.Y = frame * frameHeight;
            npc.frameCounter += 0.2f;
            if (npc.frameCounter > 1)
            {
                frame++;
                npc.frameCounter = 0;
                if (frame > 4 - 1) 
                {
                    frame = 0;
                }
            }
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tainted Monster");
            Main.npcFrameCount[npc.type] = 5;
        }
        public override void SetDefaults()
        {
            npc.CloneDefaults(NPCID.Wolf);
            npc.lifeMax = 14900;
            npc.damage = 97;
            npc.defense = 117;
            npc.value = Item.buyPrice(0, 0, 98, 35);
            npc.lavaImmune = true;
            npc.knockBackResist = 0.4f;
            npc.width = 196;
            npc.height = 62;
        }
        public override void NPCLoot()
        {
                Item.NewItem(npc.Center, mod.ItemType("TaintedRock"), Main.rand.Next(2, 6));
        }
        public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/TaintedMonstergore1"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/TaintedMonstergore2"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/TaintedMonstergore3"), 1f);
            }
        }
    }
}