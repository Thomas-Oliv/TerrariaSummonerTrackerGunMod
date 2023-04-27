using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;


namespace SummonerTrackerGun.Items
{
    public class BasicTrackerGun : BaseTrackerGun
    {
        public override void SetStaticDefaults()
        {
			//Item name
            DisplayName.SetDefault("Basic Tracker Gun");
			Tooltip.SetDefault("Leaves a magical mark on your enemies which summons can target");
		}
		public override void SetCustomDefaults()
		{
			// Item stats and dimensions.
			Item.damage = 20;
			Item.mana = 15;
			Item.useTime = 29;
			Item.useAnimation = 29;
			Item.knockBack = 1f;
			Item.value = 1000;
			Item.rare = ItemRarityID.Blue;
			Item.shootSpeed = 8f;
			Item.shoot = Mod.Find<ModProjectile>("TrackerProjectile").Type;
		}
		// Recipe
		public override void AddRecipes()
		{	
			//Allow for Tungsten or silver to be used.
			RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " Silver Bar", new int[]
			{
					ItemID.SilverBar,
					ItemID.TungstenBar
			});

			RecipeGroup.RegisterGroup("Any Silver Bar", group);

			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Diamond, 1);
			recipe.AddIngredient(ItemID.Gel, 25);
			recipe.AddRecipeGroup("Any Silver Bar", 10);
			recipe.AddIngredient(ItemID.FallenStar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}


	}
}
