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
	[AutoloadEquip(EquipType.Body)]
	public class LunarChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lunar Chestplate"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("11% more damage");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 20;
			item.value = 998700;
			item.rare = 10;
			item.autoReuse = true;
			item.defense = 25;
		}
		public override void UpdateEquip(Player player)
		{
			player.allDamage += 0.11f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("LunarBar"), 25);
			recipe.AddIngredient(ItemID.FragmentNebula, 1);
			recipe.AddIngredient(ItemID.FragmentSolar, 1);
			recipe.AddIngredient(ItemID.FragmentStardust, 1);
			recipe.AddIngredient(ItemID.FragmentVortex, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}