using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
	public class Hellsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hell Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Massive sword crafted out of materials that come out of hell itself.");
		}

		public override void SetDefaults()
		{
			item.damage = 57;
			item.melee = true;
			item.width = 58;
			item.height = 58;
			item.useTime = 12;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 7;
			item.value = 27000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("ScarredBar"), 9);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}