using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
	public class FireEssence : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Fire Essence"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("The pure essence of fire creatures.");
		}

		public override void SetDefaults() 
		{
			item.width = 22;
			item.height = 22;
			item.value = 10000;
			item.rare = 2;
			ItemID.Sets.ItemNoGravity[item.type] = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}