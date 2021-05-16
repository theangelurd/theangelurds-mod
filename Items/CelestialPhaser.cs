using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
	public class CelestialPhaser : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Celestial Phaser"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A blade that wields the power of the cosmos.");
		}

		public override void SetDefaults()
		{
			item.damage = 341;
			item.melee = true;
			item.width = 96;
			item.height = 96;
			item.useTime = 27;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 9;
			item.value = 31134000;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
		}
	}
}