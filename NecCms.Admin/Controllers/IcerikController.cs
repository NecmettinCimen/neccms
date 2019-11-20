﻿using Microsoft.AspNetCore.Mvc;
using NecCms.Admin.Models;
using NecCms.Database;
using NecCms.Database.Service;
using System;
using System.IO;
using System.Linq;

namespace NecCms.Admin.Controllers
{
    public class IcerikController : Controller
    {
        readonly IGenericService _genericService;
        public IcerikController(IGenericService genericService) => _genericService = genericService;
        public IActionResult Liste() => View();
        public IActionResult Ekle() => View();
        public IActionResult Duzenle(int id) => View("Ekle");
        public IActionResult Bul(int id) => Json(new { data = _genericService.IQueryable<Icerik.Icerikler>().First(x => x.Id == id) });
        public IActionResult Kaydet(Icerik.Icerikler model)
        {

            var file = Request.Form.Files.Count > 0 ? Request.Form.Files.First() : null;

            if (file != null)
            {
                model.ResimId = DosyaIslemleri.Kaydet(file, _genericService);
            }

            if (model.Id != 0)
            {
                Icerik.Icerikler dbmodel = _genericService.IQueryable<Icerik.Icerikler>().First(x => x.Id == model.Id);
                if (file == null)
                {
                    model.ResimId = dbmodel.ResimId;
                }
                model.YazarId = dbmodel.YazarId;
                model.Durum = dbmodel.Durum;
            }
            else
            {
                model.YazarId = 1;
                model.Durum = Icerik.IcerikDurumEnum.Hazirlandi;
            }

            return Json(new
            {
                data = _genericService.Save(model)
            });
        }

        public IActionResult Kaldir([FromBody]Icerik.Icerikler model) => Json(new { data = _genericService.Remove(model) });
        public IActionResult IcerikListesi() => Json(new
        {
            data = (from x in _genericService.IQueryable<Icerik.Icerikler>()
                    join m in _genericService.IQueryable<Menu>() on x.MenuId equals m.Id
                    select new
                    {
                        x.Baslik,
                        x.Id,
                        x.Durum,
                        Menu = m.Isim
                    })
        });
        public IActionResult Durum(int id)
        {
            Icerik.Icerikler dbmodel = _genericService.IQueryable<Icerik.Icerikler>().First(x => x.Id == id);
            dbmodel.Durum = dbmodel.Durum == Icerik.IcerikDurumEnum.Hazirlandi ? Icerik.IcerikDurumEnum.Yayinlandi : Icerik.IcerikDurumEnum.Hazirlandi;

            return Json(new { data = _genericService.Save(dbmodel) });
        }
    }
}