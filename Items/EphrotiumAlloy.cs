using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
    public class EphrotiumAlloy : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("An alloy made out of Secratium and Ephrotium altogether.");
            DisplayName.SetDefault("Ephrotium Alloy");
        }

        public override void SetDefaults()
        {
            item.width = 34;
            item.height = 24;
            item.maxStack = 999;
            item.value = 830;
            item.rare = 2;
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("EphrotiumMetal"), 3);
            recipe.AddIngredient(mod.ItemType("Secratium"), 2);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}