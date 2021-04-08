using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
    public class LunarFragment : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The four fragments combined into one..");
            DisplayName.SetDefault("Lunar Fragment");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 2560;
            item.rare = 10;
            ItemID.Sets.ItemNoGravity[item.type] = true;
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FragmentSolar, 1);
            recipe.AddIngredient(ItemID.FragmentVortex, 1);
            recipe.AddIngredient(ItemID.FragmentNebula, 1);
            recipe.AddIngredient(ItemID.FragmentStardust, 1);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}