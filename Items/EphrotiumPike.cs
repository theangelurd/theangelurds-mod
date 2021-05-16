using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace theangelurdsmod.Items
{
	public class EphrotiumPike : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A very sharp pike, made from pure ephrotium alloy.");
		}

		public override void SetDefaults()
		{
			item.damage = 22;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.useAnimation = 18;
			item.useTime = 19;
			item.shootSpeed = 5f;
			item.knockBack = 6f;
			item.width = 44;
			item.height = 44;
			item.scale = 1f;
			item.rare = 2;
			item.value = 2800;
			item.melee = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.autoReuse = false;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType("EphrotiumPikeProjectile");
		}

		public override bool CanUseItem(Player player)
		{
			// Ensures no more than one spear can be thrown out, use this when using autoReuse
			return player.ownedProjectileCounts[item.shoot] < 1;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("EphrotiumAlloy"), 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}