using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
    public class RustedMetal : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Piece of metal rusted by the rain and old age.");
            DisplayName.SetDefault("Rusted Metal");
        }

        public override void SetDefaults()
        {
            item.width = 14;
            item.height = 14;
            item.maxStack = 999;
            item.value = 120;
            item.rare = 1;
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
            // Recipes here. See Basic Recipe Guide
        }
    }
}