using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
	public class CelestialPistol : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Celestial Pistol"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Shoots powerful bullets.");
		}

		public override void SetDefaults()
		{
			item.damage = 237;
			item.melee = false;
			item.ranged = true;
			item.width = 76;
			item.height = 50;
			item.useTime = 15;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 5;
			item.value = 1278000;
			item.rare = 11;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = ProjectileID.Bullet;
			item.useAmmo = AmmoID.Bullet;
			item.shootSpeed = 52;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 9);
			recipe.AddIngredient(mod.ItemType("CelestialEssence"), 19);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}