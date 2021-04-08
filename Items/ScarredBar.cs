using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
    public class ScarredBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Scarred Bar");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.maxStack = 999;
            item.value = 2800;
            item.rare = 5;
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SolidifiedRedOrb"), 2);
            recipe.AddIngredient(ItemID.Hellstone, 3);
            recipe.AddIngredient(ItemID.Obsidian, 1);
            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}