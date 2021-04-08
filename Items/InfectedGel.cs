using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
    public class InfectedGel : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Gel of a slime, blighted by a horrid infection deep underground...");
            DisplayName.SetDefault("Infected Gel");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 460;
            item.rare = 6;
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
            // Recipes here. See Basic Recipe Guide
        }
    }
}