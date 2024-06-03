using Models;
using Services;

namespace Controllers
{
    public class CarController
    {
        private CarService _carService;
        private InsuranceService _insuranceService;

        public CarController() {
            _carService = new CarService();
            _insuranceService = new InsuranceService();
        }

        public bool Insert(Car car)
        {

            //Inserir o Insurance 
            car.Insurance.Id = _insuranceService.Insert(car.Insurance);
            return _carService.Insert(car);
        }
        public bool Delete(int id)
        {
            return _carService.Delete(id);
        }
        public Car Get(int id)
        {
            return _carService.Get(id);
        }
        public bool Update(Car car)
        {
            return _carService.Update(car);
        }
        public List<Car> GetAll()
        {
            return _carService.GetAll();
        }
    }
}
