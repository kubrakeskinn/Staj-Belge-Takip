namespace Etu.StajSistemi.OgrenciStajBasvurusus
{
    public static class OgrenciStajBasvurusuConsts
    {
        private const string DefaultSorting = "{0}GunSayisi asc";

        public static string GetDefaultSorting(bool withEntityName)
        {
            return string.Format(DefaultSorting, withEntityName ? "OgrenciStajBasvurusu." : string.Empty);
        }

        public const int GunSayisiMinLength = 0;
        public const int GunSayisiMaxLength = 365;
        public const int BolumBaskaniAdiSoyadiMinLength = 0;
        public const int BolumBaskaniAdiSoyadiMaxLength = 64;
        public const int BolumBaskaniImzasiMinLength = 0;
        public const int BolumBaskaniImzasiMaxLength = 256;
        public const int BolumBaskaniImzasiContentTypeMinLength = 0;
        public const int BolumBaskaniImzasiContentTypeMaxLength = 64;
        public const int OgrenciAdiSoyadiMinLength = 0;
        public const int OgrenciAdiSoyadiMaxLength = 128;
        public const int OgrenciNoMinLength = 0;
        public const int OgrenciNoMaxLength = 64;
        public const int OgrenciBolumuMinLength = 0;
        public const int OgrenciBolumuMaxLength = 128;
        public const int OgrenciOgretimYiliMaxLength = 128;
        public const int OgrenciEpostaMaxLength = 128;
        public const int OgrenciAdresiMaxLength = 256;
        public const int OgrenciVesikalikFileNameMaxLength = 128;
        public const int OgrenciVesikalikFileContentTypeMaxLength = 64;
        public const int KurulusAdiMaxLength = 256;
        public const int KurulusTelefonNoMaxLength = 64;
        public const int KurulusAdresiMaxLength = 256;
        public const int StajYeriYetkilisiAdiSoyadiMaxLength = 128;
        public const int StajYeriYetkilisiGorevVeUnvaniMaxLength = 256;
        public const int StajYeriYetkilisiEpostaAdresiMaxLength = 256;
        public const int StajYeriYetkilisiImzaFileNameMaxLength = 256;
        public const int StajYeriYetkilisiImzaContentTypeMaxLength = 64;
        public const int OgrenciAdiMaxLength = 64;
        public const int OgrenciSoyadiMaxLength = 64;
        public const int OgrenciTcKimlikNoMaxLength = 11;
        public const int OgrenciSskNoMaxLength = 256;
        public const int OgrenciBabaAdiMaxLength = 128;
        public const int OgrenciAnaAdiMaxLength = 128;
        public const int OgrenciDogumYeriMaxLength = 128;
        public const int BolumStajKomisyonuBaskanOnayiImzaFileNameMaxLength = 128;
        public const int BolumStajKomisyonuBaskanOnayiImzaContentTypeMaxLength = 64;
        public const int DekanlikOnayImzaFileNameMaxLength = 128;
        public const int DekanlikOnayImzaFileContentTypeMaxLength = 64;
        public const int SksDaireBaskanligiOnayImzaFileNameMaxLength = 128;
        public const int SksDaireBaskanligiOnayImzaFileContentTypeMaxLength = 64;
        public const int OgrenciImzaFileNameMaxLength = 128;
        public const int OgrenciImzaFileContentTypeMaxLength = 64;
    }
}