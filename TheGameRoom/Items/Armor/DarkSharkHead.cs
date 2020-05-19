using Terraria.ModLoader;
using Terraria.ID;

namespace TheGameRoom.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class DarkSharkHead : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("DarkShark58's Dev Helmet"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Head Brainstormer!");

		}
		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.rare = ItemRarityID.Blue;
			item.vanity = true;
		}

		public override bool DrawHead() {
			return false;
		}
	}
}