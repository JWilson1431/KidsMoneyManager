using KidsMoneyManager.Models;

namespace KidsMoneyManager.Services
{
    public class ChildService
    {
        private List<Child> _children = new List<Child>();

        public ChildService()
        {
            Child child1 = new Child()
            {
                Id = 1,
                Name = "Lily",
                Avatar = "/images/avatars/stitch2.jpg",
                Color = "#F590C7",
                BankBalance = 0,
                InterestRate = 0.02m
            };
            Child child2 = new Child()
            {
                Id = 2,
                Name = "Nicky",
                Color = "#549C48",
                Avatar = "/images/avatars/otter2.png",
                BankBalance = 0,
                InterestRate = 0.02m
            };
            _children.Add(child1);
            _children.Add(child2);
        }

        public List<Child> GetAllChildren()
        {
            return _children;
        }

        public void AddChild(Child child)
        {
            _children.Add(child);
        }

        public void RemoveChild(Child child)
        {
            _children.Remove(child);
        }

        public Child? GetChildById(int id)
        {
            var child = _children.Where(x => x.Id == id).FirstOrDefault();
            return child;
        }
    }
}
