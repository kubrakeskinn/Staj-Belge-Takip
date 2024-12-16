$(function () {
    var l = abp.localization.getResource("StajSistemi");

    var ogrenciStajBasvurusuService = window.etu.stajSistemi.ogrenciStajBasvurusus.ogrenciStajBasvurusus;


    var createModal = new abp.ModalManager({
        viewUrl: abp.appPath + "OgrenciStajBasvurusus/CreateModal",
        scriptUrl: abp.appPath + "Pages/OgrenciStajBasvurusus/createModal.js",
        modalClass: "ogrenciStajBasvurusuCreate"
    });

    var editModal = new abp.ModalManager({
        viewUrl: abp.appPath + "OgrenciStajBasvurusus/EditModal",
        scriptUrl: abp.appPath + "Pages/OgrenciStajBasvurusus/editModal.js",
        modalClass: "ogrenciStajBasvurusuEdit"
    });

    var getFilter = function () {
        return {
            filterText: $("#FilterText").val(),
            gunSayisiMin: $("#GunSayisiFilterMin").val(),
            gunSayisiMax: $("#GunSayisiFilterMax").val(),
            bolumBaskaniAdiSoyadi: $("#BolumBaskaniAdiSoyadiFilter").val(),
            ogrenciAdiSoyadi: $("#OgrenciAdiSoyadiFilter").val(),
            ogrenciNo: $("#OgrenciNoFilter").val(),
            ogrenciBolumu: $("#OgrenciBolumuFilter").val(),
            ogrenciOgretimYili: $("#OgrenciOgretimYiliFilter").val(),
            ogrenciTelefonNo: $("#OgrenciTelefonNoFilter").val(),
            ogrenciEposta: $("#OgrenciEpostaFilter").val(),
            ogrenciAdresi: $("#OgrenciAdresiFilter").val(),
            kurulusAdi: $("#KurulusAdiFilter").val(),
            kurulusTelefonNo: $("#KurulusTelefonNoFilter").val(),
            kurulusAdresi: $("#KurulusAdresiFilter").val(),
            stajYeriYetkilisiAdiSoyadi: $("#StajYeriYetkilisiAdiSoyadiFilter").val(),
            stajYeriYetkilisiGorevVeUnvani: $("#StajYeriYetkilisiGorevVeUnvaniFilter").val(),
            stajYeriYetkilisiEpostaAdresi: $("#StajYeriYetkilisiEpostaAdresiFilter").val(),
            stajYeriYetkilisiOnayTarihiMin: $("#StajYeriYetkilisiOnayTarihiFilterMin").val(),
            stajYeriYetkilisiOnayTarihiMax: $("#StajYeriYetkilisiOnayTarihiFilterMax").val(),
            ogrenciStajBaslamaTarihiMin: $("#OgrenciStajBaslamaTarihiFilterMin").val(),
            ogrenciStajBaslamaTarihiMax: $("#OgrenciStajBaslamaTarihiFilterMax").val(),
            ogrenciStajBitisTarihiMin: $("#OgrenciStajBitisTarihiFilterMin").val(),
            ogrenciStajBitisTarihiMax: $("#OgrenciStajBitisTarihiFilterMax").val(),
            ogrenciAdi: $("#OgrenciAdiFilter").val(),
            ogrenciSoyadi: $("#OgrenciSoyadiFilter").val(),
            ogrenciTcKimlikNo: $("#OgrenciTcKimlikNoFilter").val(),
            ogrenciSskNo: $("#OgrenciSskNoFilter").val(),
            ogrenciBabaAdi: $("#OgrenciBabaAdiFilter").val(),
            ogrenciAnaAdi: $("#OgrenciAnaAdiFilter").val(),
            ogrenciDogumYeri: $("#OgrenciDogumYeriFilter").val(),
            ogrenciDogumTarihiMin: $("#OgrenciDogumTarihiFilterMin").val(),
            ogrenciDogumTarihiMax: $("#OgrenciDogumTarihiFilterMax").val(),
            ogrenciSaglikGuvencesi: $("#OgrenciSaglikGuvencesiFilter").val(),
            bolumStajKomisyonuBaskanOnayiTarihiMin: $("#BolumStajKomisyonuBaskanOnayiTarihiFilterMin").val(),
            bolumStajKomisyonuBaskanOnayiTarihiMax: $("#BolumStajKomisyonuBaskanOnayiTarihiFilterMax").val(),
            dekanlikOnayTarihiMin: $("#DekanlikOnayTarihiFilterMin").val(),
            dekanlikOnayTarihiMax: $("#DekanlikOnayTarihiFilterMax").val(),
            sksDaireBaskanligiOnayTarihiMin: $("#SksDaireBaskanligiOnayTarihiFilterMin").val(),
            sksDaireBaskanligiOnayTarihiMax: $("#SksDaireBaskanligiOnayTarihiFilterMax").val()
        };
    };


    var dataTableColumns = [
        {
            rowAction: {
                items:
                    [
                        {
                            text: l("Kurum linki kopyala"),
                            visible: function (data) {
                                return data.basvuruDurumu === 0;
                            },
                            action: function (data) {
                                var copyText = window.location.origin + "/Kurum/Onayla/" + data.record.id;
                                navigator.clipboard.writeText(copyText);
                                abp.notify.info(l("Link Kopyalandi"));
                            }
                        },
                        {
                            text: "Görüntüle",
                            action: function (data) {
                                window.location.href = "/View/" + data.record.id;
                            }
                        }
                    ]
            },
            width: "1rem"
        },
        {
            data: "basvuruDurumu", render: function (basvuruDurumu) {
                if (basvuruDurumu === undefined || basvuruDurumu === null) {
                    return "";
                }
                
                switch (basvuruDurumu) {
                    case 0:
                        return "Kurum Onay Bekliyor";
                    case 1:
                        return "Kurum Reddetti";
                    case 2:
                        return "Staj Komisyonu Başkanı Onay Bekliyor";
                    case 3:
                        return "Staj Komisyonu Başkanı Reddetti";
                    case 4:
                        return "Bölüm Başkanı Onay Bekliyor";
                    case 5:
                        return "Bölüm Başkanı Reddetti";
                    case 6:
                        return "Dekanlık Onayı Bekliyor";
                    case 7:
                        return "Dekanlık Reddetti";
                    case 8:
                        return "SKS Daire Başkanlığı Onayı Bekliyor";
                    case 9:
                        return "SKS Daire Başkanlığı Reddetti";
                    case 10:
                        return "Tamamlandı";
                    default:
                        return "";
                }
                        
            }
        },
        {data: "gunSayisi"},
        {data: "bolumBaskaniAdiSoyadi"},
        {data: "ogrenciAdiSoyadi"},
        {data: "ogrenciNo"},
        {data: "ogrenciBolumu"},
        {data: "ogrenciOgretimYili"},
        {data: "ogrenciTelefonNo"},
        {data: "ogrenciEposta"},
        {data: "ogrenciAdresi"},
        {data: "kurulusAdi"},
        {data: "kurulusTelefonNo"},
        {data: "kurulusAdresi"},
        {data: "stajYeriYetkilisiAdiSoyadi"},
        {data: "stajYeriYetkilisiGorevVeUnvani"},
        {data: "stajYeriYetkilisiEpostaAdresi"},
        {
            data: "stajYeriYetkilisiOnayTarihi",
            render: function (stajYeriYetkilisiOnayTarihi) {
                if (!stajYeriYetkilisiOnayTarihi) {
                    return "";
                }

                var date = Date.parse(stajYeriYetkilisiOnayTarihi);
                return (new Date(date)).toLocaleDateString(abp.localization.currentCulture.name);
            }
        },
        {
            data: "ogrenciStajBaslamaTarihi",
            render: function (ogrenciStajBaslamaTarihi) {
                if (!ogrenciStajBaslamaTarihi) {
                    return "";
                }

                var date = Date.parse(ogrenciStajBaslamaTarihi);
                return (new Date(date)).toLocaleDateString(abp.localization.currentCulture.name);
            }
        },
        {
            data: "ogrenciStajBitisTarihi",
            render: function (ogrenciStajBitisTarihi) {
                if (!ogrenciStajBitisTarihi) {
                    return "";
                }

                var date = Date.parse(ogrenciStajBitisTarihi);
                return (new Date(date)).toLocaleDateString(abp.localization.currentCulture.name);
            }
        },
        {data: "ogrenciAdi"},
        {data: "ogrenciSoyadi"},
        {data: "ogrenciTcKimlikNo"},
        {data: "ogrenciSskNo"},
        {data: "ogrenciBabaAdi"},
        {data: "ogrenciAnaAdi"},
        {data: "ogrenciDogumYeri"},
        {
            data: "ogrenciDogumTarihi",
            render: function (ogrenciDogumTarihi) {
                if (!ogrenciDogumTarihi) {
                    return "";
                }

                var date = Date.parse(ogrenciDogumTarihi);
                return (new Date(date)).toLocaleDateString(abp.localization.currentCulture.name);
            }
        },
        {
            data: "ogrenciSaglikGuvencesi",
            render: function (ogrenciSaglikGuvencesi) {
                if (ogrenciSaglikGuvencesi === undefined ||
                    ogrenciSaglikGuvencesi === null) {
                    return "";
                }

                var localizationKey = "Enum:OgrenciSaglikGuvencesi." + ogrenciSaglikGuvencesi;
                var localized = l(localizationKey);

                if (localized === localizationKey) {
                    abp.log.warn("No localization found for " + localizationKey);
                    return "";
                }

                return localized;
            }
        },
        {
            data: "bolumStajKomisyonuBaskanOnayiTarihi",
            render: function (bolumStajKomisyonuBaskanOnayiTarihi) {
                if (!bolumStajKomisyonuBaskanOnayiTarihi) {
                    return "";
                }

                var date = Date.parse(bolumStajKomisyonuBaskanOnayiTarihi);
                return (new Date(date)).toLocaleDateString(abp.localization.currentCulture.name);
            }
        },
        {
            data: "dekanlikOnayTarihi",
            render: function (dekanlikOnayTarihi) {
                if (!dekanlikOnayTarihi) {
                    return "";
                }

                var date = Date.parse(dekanlikOnayTarihi);
                return (new Date(date)).toLocaleDateString(abp.localization.currentCulture.name);
            }
        },
        {
            data: "sksDaireBaskanligiOnayTarihi",
            render: function (sksDaireBaskanligiOnayTarihi) {
                if (!sksDaireBaskanligiOnayTarihi) {
                    return "";
                }

                var date = Date.parse(sksDaireBaskanligiOnayTarihi);
                return (new Date(date)).toLocaleDateString(abp.localization.currentCulture.name);
            }
        }
    ];


    var dataTable = $("#OgrenciStajBasvurususTable").DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        scrollX: true,
        autoWidth: true,
        scrollCollapse: true,
        order: [[1, "asc"]],
        ajax: abp.libs.datatables.createAjax(ogrenciStajBasvurusuService.getList, getFilter),
        columnDefs: dataTableColumns
    }));


    createModal.onResult(function () {
        dataTable.ajax.reloadEx();
        ;


    });

    editModal.onResult(function () {
        dataTable.ajax.reloadEx();
        ;


    });

    $("#NewOgrenciStajBasvurusuButton").click(function (e) {
        e.preventDefault();
        window.location.href = "/OgrenciStajBasvurusus/Create";
    });

    $("#SearchForm").submit(function (e) {
        e.preventDefault();
        dataTable.ajax.reloadEx();


    });

    $('#AdvancedFilterSectionToggler').on('click', function (e) {
        $('#AdvancedFilterSection').toggle();
    });

    $('#AdvancedFilterSection').on('keypress', function (e) {
        if (e.which === 13) {
            dataTable.ajax.reloadEx();


        }
    });

    $('#AdvancedFilterSection select').change(function () {
        dataTable.ajax.reloadEx();


    });


});
