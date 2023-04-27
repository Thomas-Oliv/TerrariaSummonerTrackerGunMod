using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;


namespace SummonerTrackerGun.Items
{
	public class LunarTrackerGun : BaseTrackerGun
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lunar Tracker Gun");
			Tooltip.SetDefault("Feel the wrath of a God");
		}
		public override void SetCustomDefaults()
		{
			Item.damage = 150;
			Item.mana = 2;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.knockBack = 4f;
			Item.value = 10000000;
			Item.rare = ItemRarityID.Red;
			Item.shootSpeed = 14f;
			Item.shoot = Mod.Find<ModProjectile>("LunarTrackerProjectile").Type;
		}
		public override void AddRecipes()
		{
			RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " Lunar Fragment", new int[]
			{
				ItemID.FragmentNebula,
				ItemID.FragmentSolar,
				ItemID.FragmentStardust,
				ItemID.FragmentVortex
			});

			RecipeGroup.RegisterGroup("Any Lunar Fragment", group);

			// main recipe
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<PurifiedHolyTrackerGun>(), 1);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddRecipeGroup("Any Lunar Fragment", 10);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.Register();
		}


	}
}
