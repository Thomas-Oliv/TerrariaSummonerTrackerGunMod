using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;


namespace SummonerTrackerGun.Items
{
	public class HellishTrackerGun : BaseTrackerGun
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hellish Tracker Gun");
			Tooltip.SetDefault("Ignites your target with the flames of hell");
		}
		public override void SetCustomDefaults()
		{
			Item.damage = 40;
			Item.mana = 8;
			Item.useTime = 23;
			Item.useAnimation = 23;
			Item.knockBack = 2.5f;
			Item.value = 10000;
			Item.rare = ItemRarityID.Orange;
			Item.shootSpeed = 9f;
			Item.shoot = Mod.Find<ModProjectile>("FlamingTrackerProjectile").Type;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<DemonicTrackerGun>(), 1);
			recipe.AddIngredient(ItemID.HellstoneBar, 20);
			recipe.AddTile(TileID.Hellforge);
			recipe.Register();
		}


	}
}
