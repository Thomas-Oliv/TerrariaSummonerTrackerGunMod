using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;


namespace SummonerTrackerGun.Items
{
	public class DemonicTrackerGun : BaseTrackerGun
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Demonic Tracker Gun");
			Tooltip.SetDefault("Plagues your target for your minions to devour");
		}
		public override void SetCustomDefaults()
		{
			Item.damage = 30;
			Item.mana = 12;
			Item.useTime = 26;
			Item.useAnimation = 26;
			Item.knockBack = 2f;
			Item.value = 6000;
			Item.rare = ItemRarityID.Green;
			Item.shootSpeed = 8.5f;
			Item.shoot = Mod.Find<ModProjectile>("PoisonTrackerProjectile").Type;
		}
		public override void AddRecipes()
		{
			
			RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " Evil Bar", new int[]
			{
				ItemID.DemoniteBar,
				ItemID.CrimtaneBar
			});

			RecipeGroup.RegisterGroup("Any Evil Bar", group);


			RecipeGroup group2 = new RecipeGroup(() => Lang.misc[37] + " Evil Material", new int[]
			{
				ItemID.TissueSample,
				ItemID.ShadowScale
			});

			RecipeGroup.RegisterGroup("Any Evil Material", group2);

			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<BasicTrackerGun>(), 1);
			recipe.AddRecipeGroup("Any Evil Bar", 10);
			recipe.AddRecipeGroup("Any Evil Material", 10);
			recipe.AddIngredient(ItemID.Stinger, 5);
			recipe.AddTile(TileID.DemonAltar);
			recipe.Register();
		}


	}
}
