namespace UniBet.Entities
{
    public class User : EntitiyBase
    {
        public string Document {  get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public float Amount { get; set; }
    }
}
