namespace Ksiegarnia.Dtos
{
    public class CityDto
    {


        public string postal_code { get; set; }

        public string city { get; set; }

        public CityDto(string postal_code, string city)
        {
            this.postal_code=postal_code;
            this.city=city;
        }

    }
}
