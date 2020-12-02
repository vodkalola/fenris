using System.Collections.Generic;
using gta_mp_database.Entity;

namespace gta_mp_database.Providers.Interfaces {
    public interface IHousesProvider {
        /// <summary>
        /// ���������� ������ ���������� � �����
        /// </summary>
        List<House> GetHouses();

        /// <summary>
        /// �������� ���������� � �����
        /// </summary>
        void UpdateHouses(IEnumerable<House> houses);
    }
}