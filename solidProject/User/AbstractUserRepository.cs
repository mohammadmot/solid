namespace solidProject.User
{
    public abstract class AbstractUserRepository
    {
        public int prop1 { get; set; }
        public abstract int prop2 { get; set; }

        public abstract void Add(User user); // implement just in inhered class
        public void Remove(User user)
        {
            // ... have to implement
        }

        public virtual void Edit(User user)
        {
            // ... have to implement - or - reImplement in inhered class
        }
    }
}