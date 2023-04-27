using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;


namespace SummonerTrackerGun.Items
{
	public class PurifiedHolyTrackerGun : BaseTrackerGun
	{
		public override void SetCustomStaticDefaults()
		{
			DisplayName.SetDefault("Purified Holy Tracker Gun");
			Tooltip.SetDefault("Erodes your targets defense with holy light");
		}
		public override void SetCustomDefaults()
		{
			Item.damage = 100;
			Item.mana = 4;
			Item.useTime = 18;
			Item.useAnimation = 18;
			Item.knockBack = 3f;
			Item.value = 1000000;
			Item.rare = ItemRarityID.Yellow;
			Item.shootSpeed = 12f;
			Item.shoot = Mod.Find<ModProjectile>("PurifiedTrackerProjectile").Type;
		}
		public override void AddRecipes()
		{

			RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " Evil Holy Gun", new int[]
			{
				ModContent.ItemType<CursedHolyTrackerGun>(),
				ModContent.ItemType<TaintedHolyTrackerGun>()
			});

			RecipeGroup.RegisterGroup("Any Evil Holy Gun", group);

			// main recipe
			Recipe recipe = CreateRecipe();
			recipe.AddRecipeGroup("Any Evil Holy Gun", 1);
			recipe.AddIngredient(ItemID.SpectreBar, 15);
			recipe.AddIngredient(ItemID.EyeoftheGolem, 1);
			recipe.AddTile(TileID.LihzahrdAltar);
			recipe.Register();
		}


	}
}
