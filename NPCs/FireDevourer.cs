using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

                    namespace theangelurdsmod
                    }
                    public class FireDevourer : ModNPC  
                    public override void SetStaticDefaults()
                    {
            DisplayName.SetDefault("Fire Devourer");

        }
        public override void SetDefaults()
        {
           npc.CloneDefaults(NPCID.EaterofSouls);
            animationType = -1;
           npc.maxLife = 28
           npc.damage = 13
           npc.defense = 5
           npc.value = Item.buyPrice(0, 0, 0, 40);
        }
        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 160);
        }
        public override void NPCLoot()
        {
            if (Main.rand.Next(0,4) == 4) {
            Item.NewItem(npc.Center, ItemID.FireEssence);
            }
        }
}