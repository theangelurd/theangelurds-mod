using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
	public class DyedBower : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dyed Bower"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 269;
			item.melee = false;
			item.ranged = true;
			item.width = 76;
			item.height = 50;
			item.useTime = 13;
			item.useAnimation = 13;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 5.75f;
			item.value = 2178000;
			item.rare = 12;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = ProjectileID.WoodenArrowFriendly;
			item.useAmmo = AmmoID.Arrow;
			item.shootSpeed = 20;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("TaintedRock"), 27);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}