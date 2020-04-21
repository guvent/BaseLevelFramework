using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Common.Utilities.Mappings
{
    public class AutoMapperHelper
    {
        public static List<T> MappedList<T>(List<T> list)
        {
            Mapper.Initialize(c => c.CreateMap<T, T>());

            return Mapper.Map<List<T>, List<T>>(list);
        }

        public static T MappedData<T>(T data)
        {
            Mapper.Initialize(c => c.CreateMap<T, T>());

            return Mapper.Map<T, T>(data);
        }
    }
}
