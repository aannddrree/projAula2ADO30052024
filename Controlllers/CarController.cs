using Models;
using Services;

namespace Controllers
{
    public class CarController
    {
        private CarService _carService;    

        public CarController() {
            _carService = new CarService();
        }

        public bool Insert(Car car)
        {
            Console.WriteLine("Camada Controller");
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
