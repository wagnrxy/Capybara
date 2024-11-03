using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Capybara;

public class Menu
{
    private SpriteFont _font;
    private SpriteBatch _sb;

    public Menu(ContentManager c, SpriteBatch sb)
    {
        _font = c.Load<SpriteFont>("assents/fonts/fontPixel");
        _sb = sb;
    }
    public void Update(GameTime gt)
    {

    }

    public void Draw(GameTime gt)
    {
        _sb.DrawString(_font, "Hello world", new Vector2(100, 100), Color.White);
    }
}