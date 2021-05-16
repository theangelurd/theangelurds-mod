using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace theangelurdsmod.StatusEffects
{
    public class SoulDrain : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;

            DisplayName.SetDefault("Soul Drain");

            Description.SetDefault("Your soul is being drained");
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<theangelurdPlayer>().SoulDrain = true;
        }
    }
}