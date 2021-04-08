using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
    public class Secratium : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Stronger than Ephrotium, but rarer to find. Very likely some sort of ancient, really hardened fossil.");
            DisplayName.SetDefault("Secratium");
        }

        public override void SetDefaults()
        {
            item.width = 14;
            item.height = 14;
            item.maxStack = 999;
            item.value = 280;
            item.rare = 2;
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
            // Recipes here. See Basic Recipe Guide
        }
    }
}