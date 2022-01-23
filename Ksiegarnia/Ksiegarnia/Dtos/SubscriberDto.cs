namespace Ksiegarnia.Dtos
{
    public class SubscriberDto
    {
        public SubscriberDto(int sub_id, DateTime sub_start, UserDto user, DateTime sub_end, bool is_active)
        {
            this.sub_id=sub_id;
            this.sub_start=sub_start;
            this.sub_end=sub_end;
            this.is_active=is_active;
            this.user.user_id=user.user_id;
        }
 


        public int sub_id { get; set; }

        public DateTime sub_start { get; set; }

        public virtual UserDto user { get; set; }

        public DateTime sub_end { get; set; }
        public bool is_active { get; set; }

    }
}
