using System;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;

using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;


namespace FlappyBird
{
	public class Enemy
	{
		public Vector2 position;
		private SpriteUV 	sprites;
		private TextureInfo	textureInfo;
		private float		width;
		
		public Enemy (Scene scene)
		{
			sprites	= new SpriteUV();
			position = new Vector2(100,100);
			textureInfo  		= new TextureInfo("/Application/textures/GenericTexture.png");
			//Left
			sprites 			= new SpriteUV(textureInfo);
			sprites.Quad.S 	= textureInfo.TextureSizef;
			sprites.Position= position;
			
			//Get sprite bounds.
			Bounds2 b = sprites.Quad.Bounds2();
			width     = b.Point10.X;
			
			//Add to the current scene.
			
				scene.AddChild(sprites);
		}
		
		
		public void Update()
		{
			
		}
		
		public void Draw()
		{
			
		}
	}
}

