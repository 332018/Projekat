using FakultetDataLayer;
using FakultetDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakultetBussinessLayer
{
    public class FakultetBussiness
    {
        private readonly FakultetRepository fakultetRepository;


        public FakultetBussiness()
        {
            this.fakultetRepository = new FakultetRepository();
        }

        public List<Profesor> GetProfesors()
        {
            return this.fakultetRepository.GetProfesors();
        }

        public bool InsertProfesor(Profesor p)
        {
            if (this.fakultetRepository.InsertProfesor(p) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
