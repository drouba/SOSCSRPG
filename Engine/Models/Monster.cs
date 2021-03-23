using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Engine.Models
{
    public class Monster : BaseNotificationClass
    {
        private int _hitpoints;

        public string Name { get; private set; }
        public string ImageName { get; set; }
        public int MaximumHitPoints { get; private set; }
        public int HitPoints 
        {
            get { return _hitpoints; }
            set
            {
                _hitpoints = value;
                OnPropertyChanged(nameof(HitPoints));
            }
        }

        public int MinimumDammage { get; set; }
        public int MaximumDammage { get; set; }

        public int RewardExperiencePoints { get; private set; }
        public int RewardGold { get; private set; }

        public ObservableCollection<ItemQuantity> Inventory { get; set; }

        public Monster(string name, string imageName, int maximumHitPoints, int hitPoints,
            int minimumDammage, int maximumDammage,
            int rewardExperiencePoints, int rewardGold)
        {
            Name = name;
            ImageName = $"/Engine;component/Images/Monsters/{imageName}";
            MaximumHitPoints = maximumHitPoints;
            MinimumDammage = minimumDammage;
            MaximumDammage = maximumDammage;
            HitPoints = hitPoints;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;

            Inventory = new ObservableCollection<ItemQuantity>();
        }


    }
}
