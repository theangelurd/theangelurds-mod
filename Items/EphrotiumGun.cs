using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
	public class EphrotiumGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ephrotium Gun"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Quickly shoots barrages of bullets.");
		}

		public override void SetDefaults()
		{
			item.damage = 17;
			item.melee = false;
			item.width = 16;
			item.height = 32;
			item.useTime = 40;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 3;
			item.value = 2100;
			item.rare = 3;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = ProjectileID.Bullet;
			item.useAmmo = AmmoID.Bullet;
			item.shootSpeed = 29;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("EphrotiumAlloy"), 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}