using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace theangelurdsmod.Tiles
{
    public class AridOreTile : ModTile

    {

        public override void SetDefaults()

        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            dustType = 57;
            soundType = 21;
            soundStyle = 2;
            mineResist = 4f;
            minPick = 150;
            AddMapEntry(new Color(76, 49, 0)); //color for map
            drop = mod.ItemType("AridOre");
            TileID.Sets.Ore[Type] = true;
            Main.tileSpelunker[Type] = true;

        }
    }
}