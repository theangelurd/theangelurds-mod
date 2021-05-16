using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
	public class EphrotiumBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chain Bow"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Shoots weak arrows extremely fast.");
		}

		public override void SetDefaults()
		{
			item.damage = 999;
			item.melee = false;
			item.width = 16;
			item.height = 32;
			item.useTime = 1;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 3;
			item.value = 2100;
			item.rare = 2;
			item.UseSound = SoundID.Item9;
			item.autoReuse = true;
			item.shoot = ProjectileID.WoodenArrowFriendly;
			item.ammo = AmmoID.Arrow;
			item.shootSpeed = 99;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 4999);
			recipe.AddIngredient(ItemID.LunarBar, 1999);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}