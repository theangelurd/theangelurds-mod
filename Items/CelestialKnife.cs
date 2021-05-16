using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
	public class CelestialKnife : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Celestial Knife"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A very light knife that can quickly do a lot of damage.");
		}

		public override void SetDefaults()
		{
			item.damage = 193;
			item.melee = true;
			item.width = 28;
			item.height = 28;
			item.useTime = 3;
			item.useAnimation = 7;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 47800000;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
		}
	}
}