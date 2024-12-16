using Etu.StajSistemi.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Volo.Abp.Content;

namespace Etu.StajSistemi.OgrenciStajBasvurusus
{
    public class OgrenciStajBasvurusuCreateDto
    {
        [Range(OgrenciStajBasvurusuConsts.GunSayisiMinLength, OgrenciStajBasvurusuConsts.GunSayisiMaxLength)]
        public int GunSayisi { get; set; }
        [Required]
        [StringLength(OgrenciStajBasvurusuConsts.BolumBaskaniAdiSoyadiMaxLength, MinimumLength = OgrenciStajBasvurusuConsts.BolumBaskaniAdiSoyadiMinLength)]
        public string BolumBaskaniAdiSoyadi { get; set; } = null!;
        [Required]
        [StringLength(OgrenciStajBasvurusuConsts.OgrenciAdiSoyadiMaxLength, MinimumLength = OgrenciStajBasvurusuConsts.OgrenciAdiSoyadiMinLength)]
        public string OgrenciAdiSoyadi { get; set; } = null!;
        [Required]
        [RegularExpression(@"^\d+$")]
        [StringLength(OgrenciStajBasvurusuConsts.OgrenciNoMaxLength, MinimumLength = OgrenciStajBasvurusuConsts.OgrenciNoMinLength)]
        public string OgrenciNo { get; set; } = null!;
        [Required]
        [StringLength(OgrenciStajBasvurusuConsts.OgrenciBolumuMaxLength, MinimumLength = OgrenciStajBasvurusuConsts.OgrenciBolumuMinLength)]
        public string OgrenciBolumu { get; set; } = null!;
        [Required]
        [StringLength(OgrenciStajBasvurusuConsts.OgrenciOgretimYiliMaxLength)]
        public string OgrenciOgretimYili { get; set; } = null!;
        [Required]
        public string OgrenciTelefonNo { get; set; } = null!;
        [Required]
        [EmailAddress]
        [StringLength(OgrenciStajBasvurusuConsts.OgrenciEpostaMaxLength)]
        public string OgrenciEposta { get; set; } = null!;
        [Required]
        [StringLength(OgrenciStajBasvurusuConsts.OgrenciAdresiMaxLength)]
        public string OgrenciAdresi { get; set; } = null!;
        [Required]
        [StringLength(OgrenciStajBasvurusuConsts.KurulusAdiMaxLength)]
        public string KurulusAdi { get; set; } = null!;
        [Required]
        [StringLength(OgrenciStajBasvurusuConsts.KurulusTelefonNoMaxLength)]
        public string KurulusTelefonNo { get; set; } = null!;
        [Required]
        [StringLength(OgrenciStajBasvurusuConsts.KurulusAdresiMaxLength)]
        public string KurulusAdresi { get; set; } = null!;
        
        public DateTime OgrenciStajBaslamaTarihi { get; set; }
        
        public DateTime OgrenciStajBitisTarihi { get; set; }
        [Required]
        [StringLength(OgrenciStajBasvurusuConsts.OgrenciAdiMaxLength)]
        public string OgrenciAdi { get; set; } = null!;
        [Required]
        [StringLength(OgrenciStajBasvurusuConsts.OgrenciSoyadiMaxLength)]
        public string OgrenciSoyadi { get; set; } = null!;
        [Required]
        [RegularExpression(@"^[1-9]\d{10}$")]
        [StringLength(OgrenciStajBasvurusuConsts.OgrenciTcKimlikNoMaxLength)]
        public string OgrenciTcKimlikNo { get; set; } = null!;
        [StringLength(OgrenciStajBasvurusuConsts.OgrenciSskNoMaxLength)]
        public string? OgrenciSskNo { get; set; }
        [Required]
        [StringLength(OgrenciStajBasvurusuConsts.OgrenciBabaAdiMaxLength)]
        public string OgrenciBabaAdi { get; set; } = null!;
        [Required]
        [StringLength(OgrenciStajBasvurusuConsts.OgrenciAnaAdiMaxLength)]
        public string OgrenciAnaAdi { get; set; } = null!;
        [Required]
        [StringLength(OgrenciStajBasvurusuConsts.OgrenciDogumYeriMaxLength)]
        public string OgrenciDogumYeri { get; set; } = null!;
        
        public DateTime OgrenciDogumTarihi { get; set; }
        [Required]
        public OgrenciSaglikGuvencesi OgrenciSaglikGuvencesi { get; set; }
        public IRemoteStreamContent OgrenciVesikalikFile { get; set; } = null!;
        public IRemoteStreamContent OgrenciImzasi{ get; set; } = null!;
    }
}