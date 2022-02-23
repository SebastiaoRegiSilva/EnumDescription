using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System;

namespace TesteEnumAnnotations
{
    public static class Program
    {
        static void Main(string[] args)
        {
            tipoDeGarrafa tdp = tipoDeGarrafa.Aluminio;
            
            string displayName = GetDescription(tdp);
            Console.WriteLine($" Funcionou!{displayName}");
        }

        /// <summary>Buscar description do Enum.</summary>
        /// <param name="GenericEnum">Lista genérica para a busca do description.</param>
        public static string GetDescription(this Enum GenericEnum)
        {
            Type genericEnumType = GenericEnum.GetType();
            MemberInfo[] memberInfo = genericEnumType.GetMember(GenericEnum.ToString());
            if ((memberInfo != null && memberInfo.Length > 0))
            {
                var _Attribs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if ((_Attribs != null && _Attribs.Count() > 0))
                {
                    return ((DescriptionAttribute)_Attribs.ElementAt(0)).Description;
                }
            }
            return GenericEnum.ToString();
        }
    }
}
