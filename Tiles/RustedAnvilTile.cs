using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ObjectData;

namespace theangelurdsmod.Tiles
{
    public class RustedAnvilTile : ModTile

    {

        public override void SetDefaults()

        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            dustType = 57;
            soundType = 21;
            soundStyle = 2;
            mineResist = 4f;
            minPick = 1;
            AddMapEntry(new Color(185, 144, 100)); //color for map
            drop = mod.ItemType("RustedAnvil");
            TileID.Sets.Ore[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileObsidianKill[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileTable[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
            TileObjectData.addTile(Type);
        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY) {
            Item.NewItem(i * 16, j * 16, 32, 48, mod.ItemType("RustedAnvil"));
        }
    }
}