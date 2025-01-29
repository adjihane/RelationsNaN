using RelationsNaN.Models;

namespace RelationsNaN.Data
{
    public class DbInitializer
    {
        protected RelationsNaNContext _context;

        public DbInitializer(RelationsNaNContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            if (_context.Game.Count() == 0)
            {
                Game game1 = new Game()
                {
                    Name = "Dark Souls III",
                    ReleaseYear = 2016,
                    Image = "image.png"
                };
                await _context.Game.AddAsync(game1);

                Game game2 = new Game()
                {
                    Name = "Super Smash Bros. Ultimate",
                    ReleaseYear = 2018,
                    Image = "image.png"
                };
                await _context.Game.AddAsync(game2);

                Game game3 = new Game()
                {
                    Name = "XCom 2",
                    ReleaseYear = 2016,
                    Image = "image.jpg"
                };


              


                await _context.Game.AddAsync(game3);



                await _context.SaveChangesAsync();
            }
            if (_context.Platform.Count() == 0)
            {
                Platform ps5 = new Platform()
                {
                    Name = "PS4"
                };
                await _context.Platform.AddAsync(ps5);

                Platform xbox360 = new Platform()
                {
                    Name = "Xbox One"
                };
                await _context.Platform.AddAsync(xbox360);

                Platform n64 = new Platform()
                {
                    Name = "Switch"
                };
                await _context.Platform.AddAsync(n64);

                Platform pc = new Platform()
                {
                    Name = "PC"
                };
                await _context.Platform.AddAsync(pc);

                await _context.SaveChangesAsync();
            }
        }
    }
}
