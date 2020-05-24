using TheGameRoom.Tiles;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace TheGameRoom.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class aidenltLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("aidenlt's Leggings");
			Tooltip.SetDefault("You Found a Dev Item!");
		}

		public override void SetDefaults()
		{
			item.width = 40;
			item.height = 40;
			item.value = 10000;
			item.rare = -12;
			item.vanity = true;
		}
	}
}