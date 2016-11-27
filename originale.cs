using Terraria;
using Terraria.ModLoader;

namespace MyMod.Items {
public class SuperduperawesomeSword : ModItem
{
  public override void SetDefaults()
  {
     base.SetDefaults();
     item.name = "Example Sword";
     item.damage = 50;
     item.melee = true;
     item.width = 40;
     item.height = 40;
     item.useTime = 20;
     item.useAnimation = 20;
     item.useStyle = 1;
     item.knockBack = 6;
     item.value = 10; // Value is in copper
     item.rare = 2;
     item.useSound = 1;
     item.autoReuse = true;

     AddTooltip("This is my super duper awesome sword.");
  }

  public override void AddRecipes()
  {
    ModRecipe recipe = new ModRecipe(mod);
    recipe.AddIngredient(Terraria.ID.ItemID.DirtBlock, 10);
    recipe.SetResult(this);
    recipe.AddRecipe();
  }
}
