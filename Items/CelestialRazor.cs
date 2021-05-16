using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
	public class CelestialRazor : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Celestial Razor"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Throws powerful razor projectiles.");
		}

		public override void SetDefaults()
		{
			item.damage = 297;
			item.ranged = true;
			item.width = 76;
			item.height = 50;
			item.useTime = 26;
			item.useAnimation = 26;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 5;
			item.value = 1278000;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("CelestialRazorProjectile");
			item.shootSpeed = 22;
		}

		public override void AddRecipes()
		{
		}
	}
}