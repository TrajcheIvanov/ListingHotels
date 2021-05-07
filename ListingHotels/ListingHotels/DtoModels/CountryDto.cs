using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ListingHotels.DtoModels
{
    public class CreateCountryDto
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country Name is Too Long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 3, ErrorMessage = "Short Country Name is Too Long")]
        public string ShortName { get; set; }
    }
    public class CountryDto : CreateCountryDto
    {
        public int Id { get; set; }

        public virtual IList<HotelDto> Hotels { get; set; }
    }
}
