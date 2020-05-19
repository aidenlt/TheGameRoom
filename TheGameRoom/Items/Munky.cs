using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace TheGameRoom.Items
{
	public class Munky : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Munky"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Nugget.");

		}

			public override void SetDefaults() {
			item.damage = 28;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 26;
			item.useAnimation = 26;
			item.useStyle = 1;
			item.knockBack = 13;
			item.value = 10000;
			item.rare = -12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 25);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}