using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace theangelurdsmod
{
    public class InfectedSlime : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Infected Slime");

        }
        public override void SetDefaults()
        {
            npc.CloneDefaults(NPCID.PurpleSlime);
            npc.lifeMax = 273;
            npc.damage = 54;
            npc.defense = 24;
            npc.value = Item.buyPrice(0, 0, 7, 60);
        }
        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
            target.AddBuff(BuffID.Darkness, 780);
        }
        public override void NPCLoot()
        {
            if (Main.rand.Next(2, 5) == 2)
            {
                Item.NewItem(npc.Center, mod.ItemType("InfectedGel")); //I'm not sure if this is correct, i hope this works.
            }
        }
    }
}