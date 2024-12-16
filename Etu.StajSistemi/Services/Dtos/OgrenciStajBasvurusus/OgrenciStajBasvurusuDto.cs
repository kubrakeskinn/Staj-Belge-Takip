using Etu.StajSistemi.Entities;
using System;
using System.Collections.Generic;

using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;

namespace Etu.StajSistemi.OgrenciStajBasvurusus
{
    public class OgrenciStajBasvurusuDto : FullAuditedEntityDto<Guid>, IHasConcurrencyStamp
    {
        public int GunSayisi { get; set; }
        public string BolumBaskaniAdiSoyadi { get; set; } = null!;
        public string? BolumBaskaniImzasi { get; set; }
        public string? BolumBaskaniImzasiContentType { get; set; }
        public string OgrenciAdiSoyadi { get; set; } = null!;
        public string OgrenciNo { get; set; } = null!;
        public string OgrenciBolumu { get; set; } = null!;
        public string OgrenciOgretimYili { get; set; } = null!;
        public string OgrenciTelefonNo { get; set; } = null!;
        public string OgrenciEposta { get; set; } = null!;
        public string OgrenciAdresi { get; set; } = null!;
        public string? OgrenciVesikalikFileName { get; set; }
        public string? OgrenciVesikalikFileContent { get; set; }
        public string KurulusAdi { get; set; } = null!;
        public string KurulusTelefonNo { get; set; } = null!;
        public string KurulusAdresi { get; set; } = null!;
        public string? StajYeriYetkilisiAdiSoyadi { get; set; }
        public string? StajYeriYetkilisiGorevVeUnvani { get; set; }
        public string? StajYeriYetkilisiEpostaAdresi { get; set; }
        public DateTime? StajYeriYetkilisiOnayTarihi { get; set; }
        public string? StajYeriYetkilisiImzaFileName { get; set; }
        public string? StajYeriYetkilisiImzaContentType { get; set; }
        public DateTime OgrenciStajBaslamaTarihi { get; set; }
        public DateTime OgrenciStajBitisTarihi { get; set; }
        public string OgrenciAdi { get; set; } = null!;
        public string OgrenciSoyadi { get; set; } = null!;
        public string OgrenciTcKimlikNo { get; set; } = null!;
        public string? OgrenciSskNo { get; set; }
        public string OgrenciBabaAdi { get; set; } = null!;
        public string OgrenciAnaAdi { get; set; } = null!;
        public string OgrenciDogumYeri { get; set; } = null!;
        public DateTime OgrenciDogumTarihi { get; set; }
        public OgrenciSaglikGuvencesi OgrenciSaglikGuvencesi { get; set; }
        public DateTime? BolumStajKomisyonuBaskanOnayiTarihi { get; set; }
        public string? BolumStajKomisyonuBaskanOnayiImzaFileName { get; set; }
        public string? BolumStajKomisyonuBaskanOnayiImzaContentType { get; set; }
        public DateTime? DekanlikOnayTarihi { get; set; }
        public string? DekanlikOnayImzaFileName { get; set; }
        public string? DekanlikOnayImzaFileContentType { get; set; }
        public DateTime? SksDaireBaskanligiOnayTarihi { get; set; }
        public string? SksDaireBaskanligiOnayImzaFileName { get; set; }
        public string? SksDaireBaskanligiOnayImzaFileContentType { get; set; }
        public string? OgrenciImzaFileName { get; set; }
        public string? OgrenciImzaFileContentType { get; set; }
        
        public virtual BasvuruDurumu BasvuruDurumu { get; set; }
        
        public virtual string? BasvuruRedAciklamasi { get; set; }
        
        public virtual DateTime? BasvuruRedTarihi { get; set; }
        public DateTime? BolumBaskaniOnayTarihi { get; set; }

        public string ConcurrencyStamp { get; set; } = null!;

    }
}