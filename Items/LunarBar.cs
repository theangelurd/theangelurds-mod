using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
    public class LunarBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The mix beetween 3 lunar fragments and an iron bar.");
            DisplayName.SetDefault("Lunar Bar");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.maxStack = 999;
            item.value = 2700;
            item.rare = 9;
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("LunarFragment"), 3);
            recipe.AddRecipeGroup("IronBar", 1);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}