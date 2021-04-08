using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
	public class InfectedSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Infected Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A sword crafted from infected roots and gel.");
		}

		public override void SetDefaults()
		{
			item.damage = 87;
			item.melee = true;
			item.width = 58;
			item.height = 58;
			item.useTime = 15;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 7;
			item.value = 11700;
			item.rare = 6;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("InfectedGel"), 14);
			recipe.AddIngredient(mod.ItemType("InfectedRoot"), 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}