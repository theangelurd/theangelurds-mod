using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
	public class CelestialMegablade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Celestial Mega Blade"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A humongous sword crafted from pure luminite bars and essence of the celestial creatures.");
		}

		public override void SetDefaults()
		{
			item.damage = 478;
			item.melee = true;
			item.width = 124;
			item.height = 124;
			item.useTime = 27;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 9;
			item.value = 1113400;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 8);
			recipe.AddIngredient(mod.ItemType("CelestialEssence"), 17);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}