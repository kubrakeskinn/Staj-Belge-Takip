namespace Etu.StajSistemi.Permissions;

public static class StajSistemiPermissions
{
    public const string GroupName = "StajSistemi";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";

    public static class OgrenciStajBasvurusus
    {
        public const string Default = GroupName + ".OgrenciStajBasvurusus";
        public const string Edit = Default + ".Edit";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
        public const string StajKomisyonuOnayla = Default + ".StajKomisyonuOnayla";
        public const string BolumBaskaniOnayla = Default + ".BolumBaskaniOnayla";
        public const string DekanlikOnayla = Default + ".DekanlikOnayla";
        public const string SksDaireBaskanligiOnayla = Default + ".SksDaireBaskanligiOnayla";
        public const string KurumOnayla = Default + ".KurumOnayla";
    }
}