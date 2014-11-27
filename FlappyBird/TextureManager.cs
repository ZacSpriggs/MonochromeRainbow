using System;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;

using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;


namespace FlappyBird
{
	public class TextureManager
	{
		public SpriteUV sprite;
		public TextureInfo textureInfo;
		public Vector2 textureSize;
		
		public TextureManager (Scene scene)
		{
			
		}
		public void LoadTexture(string path, Vector2 position)
		{
			textureInfo = new TextureInfo(path);
			
			sprite = new SpriteUV();
			sprite = new SpriteUV(textureInfo);
			sprite.Quad.S = textureInfo.TextureSizef;
			sprite.Position = position;
			
			
		}
		
		public void Animate()
		{
			
		}
	}
}

