using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace theangelurdsmod.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class LunarVisage : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lunar Visage"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("14% more ranged damage");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 20;
			item.value = 998700;
			item.rare = 10;
			item.autoReuse = true;
			item.defense = 19;
		}
		public override void UpdateEquip(Player player)
		{
			player.rangedDamage += 0.14f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("LunarBar"), 15);
			recipe.AddIngredient(ItemID.FragmentVortex, 2);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}