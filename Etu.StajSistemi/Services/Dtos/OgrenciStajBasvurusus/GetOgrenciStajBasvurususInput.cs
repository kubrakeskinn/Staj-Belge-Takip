using Etu.StajSistemi.Entities;
using Volo.Abp.Application.Dtos;
using System;

namespace Etu.StajSistemi.OgrenciStajBasvurusus
{
    public class GetOgrenciStajBasvurususInput : PagedAndSortedResultRequestDto
    {

        public string? FilterText { get; set; }

        public int? GunSayisiMin { get; set; }
        public int? GunSayisiMax { get; set; }
        public string? BolumBaskaniAdiSoyadi { get; set; }
        public string? OgrenciAdiSoyadi { get; set; }
        public string? OgrenciNo { get; set; }
        public string? OgrenciBolumu { get; set; }
        public string? OgrenciOgretimYili { get; set; }
        public string? OgrenciTelefonNo { get; set; }
        public string? OgrenciEposta { get; set; }
        public string? OgrenciAdresi { get; set; }
        public string? KurulusAdi { get; set; }
        public string? KurulusTelefonNo { get; set; }
        public string? KurulusAdresi { get; set; }
        public string? StajYeriYetkilisiAdiSoyadi { get; set; }
        public string? StajYeriYetkilisiGorevVeUnvani { get; set; }
        public string? StajYeriYetkilisiEpostaAdresi { get; set; }
        public DateTime? StajYeriYetkilisiOnayTarihiMin { get; set; }
        public DateTime? StajYeriYetkilisiOnayTarihiMax { get; set; }
        public DateTime? OgrenciStajBaslamaTarihiMin { get; set; }
        public DateTime? OgrenciStajBaslamaTarihiMax { get; set; }
        public DateTime? OgrenciStajBitisTarihiMin { get; set; }
        public DateTime? OgrenciStajBitisTarihiMax { get; set; }
        public string? OgrenciAdi { get; set; }
        public string? OgrenciSoyadi { get; set; }
        public string? OgrenciTcKimlikNo { get; set; }
        public string? OgrenciSskNo { get; set; }
        public string? OgrenciBabaAdi { get; set; }
        public string? OgrenciAnaAdi { get; set; }
        public string? OgrenciDogumYeri { get; set; }
        public DateTime? OgrenciDogumTarihiMin { get; set; }
        public DateTime? OgrenciDogumTarihiMax { get; set; }
        public OgrenciSaglikGuvencesi? OgrenciSaglikGuvencesi { get; set; }
        public DateTime? BolumStajKomisyonuBaskanOnayiTarihiMin { get; set; }
        public DateTime? BolumStajKomisyonuBaskanOnayiTarihiMax { get; set; }
        public DateTime? DekanlikOnayTarihiMin { get; set; }
        public DateTime? DekanlikOnayTarihiMax { get; set; }
        public DateTime? SksDaireBaskanligiOnayTarihiMin { get; set; }
        public DateTime? SksDaireBaskanligiOnayTarihiMax { get; set; }

        public GetOgrenciStajBasvurususInput()
        {

        }
    }
}