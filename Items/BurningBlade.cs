using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
	public class BurningBlade : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Burning Blade"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A sword engulfed in pure fire energy.");
		}

		public override void SetDefaults() 
		{
			item.damage = 18;
			item.melee = true;
			item.width = 44;
			item.height = 44;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 1800;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBroadsword, 1);
			recipe.AddIngredient(ItemID.FireEssence, 2);
			recipe.AddTile(TileID.Anvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}