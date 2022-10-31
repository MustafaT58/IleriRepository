using IleriRepository.Data;
using IleriRepository.Models;
using IleriRepository.Repositories.Concretes;
using IleriRepository.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace IleriRepository.Controllers
{
    public class CityController : Controller
    {
        IUnit _uow;
        CityModel _model;
        public CityController(IUnit uow,CityModel model)
        {
            _uow = uow;
            _model=model;
        }
        public IActionResult List()
        {
            var cList=_uow._cityRep.List();
            return View(cList);       
        }
        public IActionResult Create()
        {
            _model.Head = "Yeni Giriş";
            _model.Text = "KAYDET";
            _model.Cls = "btn btn-primary";
            _model.city  = new City();
            return View("Crud",_model);
        }
        [HttpPost]
        public IActionResult Create(CityModel model)
        {
            _uow._cityRep.Add(model.city);
            _uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Delete(int Id)
        {
            _model.Head = "Silme İşlemi";
            _model.Text = "SİL";
            _model.Cls = "btn btn-danger";
            _model.city = _uow._cityRep.Find(Id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Delete(CityModel model)
        {
            _uow._cityRep.Delete(model.city);
            _uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Update(int Id)
        {
            _model.Head = "Güncelleme Ekranı";
            _model.Text = "GÜNCELLE";
            _model.Cls = "btn btn-success";
            _model.city = _uow._cityRep.Find(Id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Update(City city)
        {
            _uow._cityRep.Update(city);
            _uow.Commit();
            return RedirectToAction("List");
        }
    }
}
