using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
	public class CelestialThrower : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Celestial Thrower"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Shoots a barrage of bullets..");
		}

		public override void SetDefaults()
		{
			item.damage = 73;
			item.melee = false;
			item.ranged = true;
			item.width = 108;
			item.height = 34;
			item.useTime = 8;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 2;
			item.value = 1278000;
			item.rare = 11;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = ProjectileID.Bullet;
			item.useAmmo = AmmoID.Bullet;
			item.shootSpeed = 287;
		}
		public override void AddRecipes()
		{
		}
	}
}