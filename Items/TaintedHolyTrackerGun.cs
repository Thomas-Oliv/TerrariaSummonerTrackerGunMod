using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;


namespace SummonerTrackerGun.Items
{
	public class TaintedHolyTrackerGun : BaseTrackerGun
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tainted Holy Tracker Gun");
			Tooltip.SetDefault("Weakens your target with unholy juices");
		}
		public override void SetCustomDefaults()
		{
			// Same base stats as Cursed alternative.
			// Only difference is that it inflicts a different debuff.
			Item.damage = 70;
			Item.mana = 6;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 23;
			Item.useAnimation = 23;
			Item.knockBack = 2.5f;
			Item.value = 100000;
			Item.rare = ItemRarityID.Pink;
			Item.shootSpeed = 10f;
			Item.shoot = Mod.Find<ModProjectile>("TaintedTrackerProjectile").Type;
		}
		public override void AddRecipes()
		{
			// main recipe
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<HellishTrackerGun>(), 1);
			recipe.AddIngredient(ItemID.SoulofNight, 15);
			recipe.AddIngredient(ItemID.Ichor, 20);
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();

			//Allow for 1:1 swap between weapons at demon altars
			Recipe recipe2 = CreateRecipe();
			recipe2.AddIngredient(ModContent.ItemType<CursedHolyTrackerGun>(), 1);
			recipe2.AddTile(TileID.DemonAltar);
			recipe2.Register();
		}


	}
}
