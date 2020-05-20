using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TheGameRoom.Items.Placeable;

namespace TheGameRoom.Items
{
	public class SaltSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Salt Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("For y'all salty bois");
		}
		public override void SetDefaults()
		{
			item.damage = 12;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 5);
			recipe.AddIngredient(ModContent.ItemType<Salt>(), 25);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}