using KidsMoneyManager.Models;

namespace KidsMoneyManager.Services
{
    public class ChildService
    {
        private List<Child> _children = new List<Child>();

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
