using System;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;

using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;

namespace FlappyBird
{
	public class Background
	{	
		//Private variables.
		private SpriteUV[] 	sprites;
		private TextureInfo	textureInfo;
		private float		width;
		
		//Public functions.
		public Background (Scene scene)
		{
			sprites	= new SpriteUV[3];
			
			textureInfo  		= new TextureInfo("/Application/textures/background.png");
			//Left
			sprites[0] 			= new SpriteUV(textureInfo);
			sprites[0].Quad.S 	= textureInfo.TextureSizef;
			//Middle
			sprites[1] 			= new SpriteUV(textureInfo);
			sprites[1].Quad.S 	= textureInfo.TextureSizef;
			//Right
			sprites[2] 			= new SpriteUV(textureInfo);
			sprites[2].Quad.S 	= textureInfo.TextureSizef;
			
			//Get sprite bounds.
			Bounds2 b = sprites[0].Quad.Bounds2();
			width     = b.Point10.X;
			
			//Add to the current scene.
			foreach(SpriteUV sprite in sprites)
				scene.AddChild(sprite);
		}	
		
		public void Dispose()
		{
			textureInfo.Dispose();
		}
	}
}



