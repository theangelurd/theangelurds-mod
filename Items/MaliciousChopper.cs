using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
	public class MaliciousChopper : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Malicious Chopper"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Throws rocks at enemies.");
		}

		public override void SetDefaults()
		{
			item.damage = 438;
			item.melee = true;
			item.width = 96;
			item.height = 88;
			item.useTime = 26;
			item.useAnimation = 26;
			item.useStyle = 1;
			item.knockBack = 9.5f;
			item.value = 1737900;
			item.rare = 12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("MaliciousRock");
			item.shootSpeed = 10;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("TaintedRock"), 33);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}