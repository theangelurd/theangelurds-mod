using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

                    namespace theangelurdsmod
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
        }
        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 160);
        }
        public override void NPCLoot()
        {
            Item.NewItem(npc.Center, ItemID.FireEssence, Main.rand.Next(0,3);
        }
}