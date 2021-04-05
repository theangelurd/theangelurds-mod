using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
    public class FireEssence : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The essence of pure fire.");
            DisplayName.SetDefault("Fire Essence");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 22;
            item.maxStack = 999;
            item.value = 190;
            item.rare = 1;
            ItemID.Sets.ItemNoGravity[item.type] = true;
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
            // Recipes here. See Basic Recipe Guide
        }
    }
}