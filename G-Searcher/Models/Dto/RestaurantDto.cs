namespace G_Searcher.Models.Dto;

public class RestaurantDto
{
    public Result Results { get; set; }

    public class Result
    {
        public Shops[] Shop { get; set; }

        public class Shops
        {
            public string Name { get; set; }

            public string Address { get; set; }

            public Genres Genre { get; set; }

            public string Mobile_access { get; set; }

            public Url Urls { get; set; }

            public string Open { get; set; }
            public string Close { get; set; }

            public string Card { get; set; }

            public string Non_Smoking { get; set; }
            public class Genres
            {
                public string Name { get; set; }
            }

            public class Url
            {
                public string PC { get; set;}
            }
        }
    }
}
