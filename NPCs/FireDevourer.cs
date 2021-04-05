using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

                    namespace theangelurdsmod
                    {
                    public class FireDevourer : ModNPC  
                    { 
                    public override void SetStaticDefaults()
                    {
            DisplayName.SetDefault("Fire Devourer");

        }
        public override void SetDefaults()
        {
           npc.CloneDefaults(NPCID.EaterofSouls);
           npc.lifeMax = 28;
           npc.damage = 13;
           npc.defense = 5;
           npc.value = Item.buyPrice(0, 0, 0, 40);
        }
        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 160);
        }
        public override void NPCLoot()
        {
            if (Main.rand.Next(0,4) == 3) {
            Item.NewItem(npc.Center, mod.ItemType("FireEssence"); //I'm not sure if this is correct, i hope this works.
            }
        }
        public override void HitEffect(int hitDirection, double damage)
        {
          if (npc.life <= 0)
            {
            Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/FireDevourerGore1"), 1f);
            Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/FireDevourerGore2"), 1f);
            Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/FireDevourerGore3"), 1f);
            }
        }
    }
}