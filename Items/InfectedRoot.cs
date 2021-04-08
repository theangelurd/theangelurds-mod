using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
    public class InfectedRoot : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Roots of a plant swallowed by a slime which then infected it.");
            DisplayName.SetDefault("Infected Roots");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 1780;
            item.rare = 6;
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
            // Recipes here. See Basic Recipe Guide
        }
    }
}