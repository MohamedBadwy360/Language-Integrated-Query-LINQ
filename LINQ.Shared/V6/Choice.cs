
namespace LINQ.Shared.V6
{
    public class Choice
    {
        public int Order { get; set; }
        public string Description { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (this.GetType() != obj.GetType())
            {
                return false;
            }

            var other = (Choice)obj;

            return other.Order == this.Order && other.Description.Equals(this.Description);
        }
        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + Order.GetHashCode();
            hash = hash * 23 + Description.GetHashCode();

            return hash;
        }
    }
}
