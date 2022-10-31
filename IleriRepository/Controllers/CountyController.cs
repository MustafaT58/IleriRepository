using IleriRepository.Data;
using IleriRepository.DTO;
using IleriRepository.Models;
using IleriRepository.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace IleriRepository.Controllers
{
    public class CountyController : Controller
    {
        IUnit _uow;
        CountyModel _model;
        public CountyController(IUnit uow,CountyModel model)
        {
            _uow = uow;
            _model = model;
        }
        public IActionResult List()
        {
            var cList =_uow._countyRep.Set().Select(x => new CountyDTO
            {
                Id = x.Id,
                CountyName = x.CountyName,
                CityName = x.City.CityName,
            }).ToList();
            //var cList = _uow._countyRep.List();
            return View(cList);
        }
        public IActionResult Create()
        {
            _model.Head = "Yeni Giriş";
            _model.Text = "KAYDET";
            _model.Cls = "btn btn-primary";
            _model.County = new County();
            _model.Cities=_uow._cityRep.List();
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Create(CountyModel model)
        {
            _uow._countyRep.Add(model.County);
            _uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Delete(int Id)
        {
            _model.Head = "Silme İşlemi";
            _model.Text = "SİL";
            _model.Cls = "btn btn-danger";
            _model.County = _uow._countyRep.Find(Id);
            _model.Cities = _uow._cityRep.List();
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Delete(County county)
        {
            _uow._countyRep.Delete(county);
            _uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Update(int Id)
        {
            _model.Head = "Güncelleme Ekranı";
            _model.Text = "GÜNCELLE";
            _model.Cls = "btn btn-success";
            _model.County = _uow._countyRep.Find(Id);
            _model.Cities = _uow._cityRep.List();
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Update(CountyModel model)
        {
            _uow._countyRep.Update(model.County);
            _uow.Commit();
            return RedirectToAction("List");
        }
    }
}
