using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
    public class AridOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Hardened lead that got consumed by the massive amounts of sand in the arid desert.");
            DisplayName.SetDefault("Arid Ore");
        }

        public override void SetDefaults()
        {
            item.createTile = mod.TileType("AridOreTile");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.width = 18;
            item.height = 18;
            item.maxStack = 999;
            item.value = 400;
            item.rare = 5;
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
            // Recipes here. See Basic Recipe Guide
        }
    }
}