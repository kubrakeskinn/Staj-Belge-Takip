using System.ComponentModel.DataAnnotations;

namespace Etu.StajSistemi.Entities;

public enum OgrenciSaglikGuvencesi
{
    [Display(Name = "Kendisi")]
    Kendisi,

    [Display(Name = "Annesi / Babası")]
    AnneBabasi,

    [Display(Name = "Yeşil Kart")]
    YesilKart,

    [Display(Name = "Yok")]
    Yok
}