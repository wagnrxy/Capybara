using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Capybara;

public class FontManager
{
    private SpriteFont _font;

    public FontManager(ContentManager c)
    {
        _font = c.Load<SpriteFont>("assents/fonts/fontPixel");
    }

    public void Draw(SpriteBatch _sb, string t, Vector2 pos, Color c)
    {
        _sb.DrawString(_font, t, pos, c);
    }
}