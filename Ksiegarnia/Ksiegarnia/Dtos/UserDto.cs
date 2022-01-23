namespace Ksiegarnia.Dtos
{
    public class UserDto
    {


 
        public int user_id { get; set; }


        public string name { get; set; }


        public virtual CityDto postal_code { get; set; }

   
        public string lastname { get; set; }

  
        public string username { get; set; }

    
        public string email { get; set; }


    
        public string? address { get; set; }

   
        public string password { get; set; }

        public virtual ICollection<TransactionsDto> transactions { get; set; }



        public UserDto(int user_id, string name, CityDto postal_code, string lastname, string username, string email, string? address, string password)
        {
            this.user_id=user_id;
            this.name=name;
            this.postal_code=postal_code;
            this.lastname=lastname;
            this.username=username;
            this.email=email;
            this.address=address;
            this.password=password;
        }

        
        
    }
}
