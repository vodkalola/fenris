using gta_mp_database.Models.Player;

namespace gta_mp_database.Providers.Interfaces {
    public interface IPlayersAppearanceProvider {
        /// <summary>
        /// ��������� ��������� �������� ���� ������
        /// </summary>
        void Save(long accountId, PlayerAppearance model);

        /// <summary>
        /// ���������� ��������� �������� ���� ������
        /// </summary>
        PlayerAppearance Get(long accountId);
    }
}