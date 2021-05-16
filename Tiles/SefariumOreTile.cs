using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace theangelurdsmod.Tiles
{
    public class SefariumOreTile : ModTile

    {

        public override void SetDefaults()

        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            dustType = 57;
            soundType = 21;
            soundStyle = 2;
            mineResist = 5f;
            minPick = 235;
            AddMapEntry(new Color(0, 238, 255));
            drop = mod.ItemType("SefariumOre");
            TileID.Sets.Ore[Type] = true;
            Main.tileSpelunker[Type] = true;

        }
    }
}