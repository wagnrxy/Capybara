using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Capybara;

public class Menu
{
    private SpriteBatch _sb;
    private FontManager _font;

    public Menu(ContentManager c, SpriteBatch sb)
    {
        _sb = sb;
        _font = new FontManager(c);
    }
    public void Update(GameTime gt)
    {

    }

    public void Draw(GameTime gt)
    {
        _font.Draw(_sb, "ai meu cu", new Vector2(100, 100), Color.White);
    }
}