using System.Collections.Generic;

namespace FirstAspMvc.Models
{
    public class HomeViewModel
    {
        public List<ServicesModel> MesServices { get; set; }
        public HoraireViewModel Horaire { get; set; }

    }
}
