using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
	public class MalecartPickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Malecart Pickaxe"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Can mine Sefarium Ore.");
		}

		public override void SetDefaults()
		{
			item.damage = 78;
			item.melee = true;
			item.width = 96;
			item.height = 88;
			item.useTime = 7;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 7.45f;
			item.value = 2437900;
			item.pick = 235;
			item.rare = 12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("TaintedRock"), 43);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}