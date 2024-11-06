using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Capybara;

public class Menu
{
    private SpriteBatch _sb;
    private FontManager _font;
    private bool menuLoad = false;
    private const float tempLimit = 3f;
    private float temp = 0f;

    public Menu(ContentManager c, SpriteBatch sb)
    {
        _sb = sb;
        _font = new FontManager(c);
    }

    public void Update(GameTime gt)
    {
        menuLoadUpdate(gt);
    }

    public void Draw(GameTime gt)
    {
        menuLoadDraw();
    }

    private void menuLoadDraw()
    {
        if (menuLoad == false)
        {
            _font.Draw(_sb, "Desenvolvido por:\n      Wagnxy", new Vector2(100, 100), new Color(255, 255, 255, 0));
        }
    }

    private void menuLoadUpdate(GameTime gt)
    {
        if (menuLoad == false)
        {
            temp += (float)gt.ElapsedGameTime.TotalSeconds;
            if (temp >= tempLimit) menuLoad = true;
        }
    }
}
