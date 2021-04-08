using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
    public class SolidifiedRedOrb : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Very strange orb covered with charred plates of rock.");
            DisplayName.SetDefault("Red Orb");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.maxStack = 999;
            item.value = 980;
            item.rare = 2;
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
            // Recipes here. See Basic Recipe Guide
        }
    }
}