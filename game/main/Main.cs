using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Capybara;

public class Main : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _sb;
    private Menu _menu;
    private enum gameState { Menu, Playing }
    private gameState currentGameStates = gameState.Menu;

    public Main()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {


        base.Initialize();
    }

    protected override void LoadContent()
    {
        _sb = new SpriteBatch(GraphicsDevice);
        _menu = new Menu(Content, _sb);

    }

    protected override void Update(GameTime gt)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        switch (currentGameStates)
        {
            case gameState.Menu:

                break;

            case gameState.Playing:

                break;
        }

        base.Update(gt);
    }


    protected override void Draw(GameTime gt)
    {
        GraphicsDevice.Clear(Color.Black);
        _sb.Begin();

        switch (currentGameStates)
        {
            case gameState.Menu:
            _menu.Draw(gt);
                break;

            case gameState.Playing:

                break;
        }
        _sb.End();

        base.Draw(gt);
    }
}
