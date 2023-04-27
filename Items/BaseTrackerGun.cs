using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;


namespace SummonerTrackerGun.Items
{
    public abstract class BaseTrackerGun : ModItem
    {	
		public abstract void SetCustomDefaults();
		public override void SetDefaults()
		{
			SetCustomDefaults();
			Item.width = 40;
			Item.height = 40;
			Item.DamageType = DamageClass.Summon;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.UseSound = SoundID.Item11;
			Item.autoReuse = true;
			Item.noMelee = true;
		}
		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
		{	
			Vector2 offset = new Vector2(velocity.X * 5f, velocity.Y * 5f);
			position += offset;
			return true;
		}

	}
}
