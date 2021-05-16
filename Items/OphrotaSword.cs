using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
	public class OphrotaSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ophrota Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 32;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 26;
			item.useAnimation = 26;
			item.useStyle = 1;
			item.knockBack = 6.5f;
			item.value = 5000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.shoot = mod.ProjectileType("CrystalBolt");
			item.shootSpeed = 18;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Turquorium"), 40);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}