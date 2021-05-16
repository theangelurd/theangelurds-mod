using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
	public class RustedAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rusted Axe"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 8;
			item.melee = true;
			item.width = 26;
			item.height = 26;
			item.useTime = 18;
			item.useAnimation = 18;
			item.axe = 6;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 2800;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("RustedBar"), 10);
			recipe.AddTile(mod.TileType("RustedAnvilTile"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}