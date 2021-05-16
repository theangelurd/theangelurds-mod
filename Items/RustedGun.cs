using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
	public class RustedPistol : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rusted Pistol"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 7;
			item.melee = false;
			item.ranged = true;
			item.width = 26;
			item.height = 18;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 5;
			item.value = 2200;
			item.rare = 1;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = ProjectileID.Bullet;
			item.useAmmo = AmmoID.Bullet;
			item.shootSpeed = 52;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("RustedBar"), 8);
			recipe.AddTile(mod.TileType("RustedAnvilTile"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}