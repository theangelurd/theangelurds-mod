using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace theangelurdsmod.Items
{
    public class RogueStar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Super hot due to the plasma in it.");
            DisplayName.SetDefault("Rogue Star");
        }

        public override void SetDefaults()
        {
            item.width = 64;
            item.height = 64;
            item.maxStack = 99;
            item.value = 830;
            item.rare = 11;
            item.consumable = true;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 100;
            item.useAnimation = 100;
            // Set other item.X values here
        }
        public override bool UseItem(Player player)
        {
            Vector2 playerPos = player.Center;
            NPC.NewNPC((int)playerPos.X - -1080, (int)playerPos.Y - -910, mod.NPCType("StarKeeper"));
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("CelestialEssence"), 30);
            recipe.AddIngredient(ItemID.LunarBar, 4);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}