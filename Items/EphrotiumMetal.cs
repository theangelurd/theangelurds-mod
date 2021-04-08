using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
    public class EphrotiumMetal : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A sturdy metal, stronger than platinum even.");
            DisplayName.SetDefault("Ephrotium Metal");
        }

        public override void SetDefaults()
        {
            item.width = 14;
            item.height = 14;
            item.maxStack = 999;
            item.value = 190;
            item.rare = 1;
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
            // Recipes here. See Basic Recipe Guide
        }
    }
}