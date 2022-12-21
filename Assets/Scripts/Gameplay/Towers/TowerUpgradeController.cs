using UnityEngine;

namespace TMG.BloonsTD.Gameplay
{
    public class TowerUpgradeController : MonoBehaviour
    {
        public TowerUpgrade[] Upgrades => _upgrades;
        private TowerUpgrade[] _upgrades = new TowerUpgrade[6];

        public void InitializeUpgrades(TowerController controller)
        {
            var towerProperties = controller.TowerProperties;
            _upgrades[0] = TowerUpgrade.GetNewUpgrade(towerProperties.TowerUpgradeProperties1Path1);
            _upgrades[1] = TowerUpgrade.GetNewUpgrade(towerProperties.TowerUpgradeProperties1Path2);
            _upgrades[2] = TowerUpgrade.GetNewUpgrade(towerProperties.TowerUpgradeProperties1Path3);
            _upgrades[3] = TowerUpgrade.GetNewUpgrade(towerProperties.TowerUpgradeProperties2Path1);
            _upgrades[4] = TowerUpgrade.GetNewUpgrade(towerProperties.TowerUpgradeProperties2Path2);
            _upgrades[5] = TowerUpgrade.GetNewUpgrade(towerProperties.TowerUpgradeProperties2Path3);
        }
    }
}