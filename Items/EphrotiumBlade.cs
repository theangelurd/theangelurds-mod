using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
	public class EphrotiumBlade : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Ephrotium Blade"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A very sturdy and sharp sword.");
		}

		public override void SetDefaults() 
		{
			item.damage = 21;
			item.melee = true;
			item.width = 34;
			item.height = 34;
			item.useTime = 19;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 2100;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("EphrotiumAlloy"), 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}