using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace theangelurdsmod.NPCs
{
    public class HellDog : ModNPC
    {
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (spawnInfo.player.ZoneUnderworldHeight && Main.hardMode)
            {
                return 2f;
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
                if (frame > 5 - 1) 
                {
                    frame = 0;
                }
            }
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hell Dog");
            Main.npcFrameCount[npc.type] = 6;
        }
        public override void SetDefaults()
        {
            npc.CloneDefaults(NPCID.Wolf);
            npc.lifeMax = 175;
            npc.damage = 61;
            npc.defense = 28;
            npc.value = Item.buyPrice(0, 0, 11, 35);
            npc.lavaImmune = true;
        }
        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
            target.AddBuff(BuffID.Burning, 80);
            target.AddBuff(BuffID.Horrified, 800);
        }
        public override void NPCLoot()
        {
            if (Main.rand.Next(0, 5) == 2)
            {
                Item.NewItem(npc.Center, mod.ItemType("SolidifiedRedOrb"), 3);
            }
        }
        public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/HellDogHeadTorso"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/HellDogBodyLeg"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/HellDogLeg"), 1f);
            }
        }
    }
}