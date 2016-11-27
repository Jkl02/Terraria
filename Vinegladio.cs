using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace Test.Items.Weapons {  //where is located
public class {Vine gladio ModItem;
    public override void SetDefaults()
    {
        item.name = "Vine Gladio";    //Sword name
        item.damage = 60;             //Sword damage
        item.melee = true             //if it's melee
        item.width = 60;              //Sword width
        item.height = 60;             //Sword height
        item.toolTip = "First sword"; //Item description
        item.useTime = 25;            //how fast
		item.useAnimation = 25; 
        item.useStyle = 25;           //Style is how this item is used, is the style of the sword
        item.knockBack = 5;           //Sword knockback
        item.value = 100;
        item.rare = 10;
        item.useSound = 1;            //1 is the sound of the sword
        item.autoRefuse = true;       //if it's capable of autoswing
        item.useTurn = true;
        
        AddTooltip("Vine gladio");
    }
    public override void AddRecipes()    //How to craft this sword
    {
     ModRecipe recipe = new ModRecipe(mod);
     recipe.AddIngredient(ItemID.DirtBlock, 1);   //at work bench
     recipe.SetResult(this);
     recipe.AddRecipe();
    }
   }
 }
