using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGameRoom.Items
{
	public class TreeSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Tree Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("For our inner lumberjack!");
        }
			public override void SetDefaults() {
			item.damage = 40;
			item.melee = true;
			item.width = 70;
			item.height = 129;
			item.useTime = 50;
			item.useAnimation = 50;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 10000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 100);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}