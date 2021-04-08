using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
	public class LunarGreatsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lunar Greatsword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A massive sword made out of pure lunar bars.");
		}

		public override void SetDefaults()
		{
			item.damage = 168;
			item.melee = true;
			item.width = 96;
			item.height = 96;
			item.useTime = 16;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = 998700;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("LunarBar"), 18);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}