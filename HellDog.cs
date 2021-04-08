using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace theangelurdsmod
{
    public class HellDog : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hell Dog");

        }
        public override void SetDefaults()
        {
            npc.CloneDefaults(NPCID.Wolf);
            npc.lifeMax = 175;
            npc.damage = 61;
            npc.defense = 28;
            npc.value = Item.buyPrice(0, 0, 11, 35);
        }
        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
            target.AddBuff(BuffID.Burning, 80);
            target.AddBuff(BuffID.Horrified, 800);
        }
        public override void NPCLoot()
        {
            if (Main.rand.Next(0, 5) == 3)
            {
                Item.NewItem(npc.Center, mod.ItemType("SolidifiedRedOrb"));
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