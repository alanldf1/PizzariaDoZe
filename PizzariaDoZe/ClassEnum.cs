﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe
{
    public enum EnumFuncionarioGrupo
    {
        [Description("Administrador")]
        Admin = 1,
        [Description("Atendente")]
        Atende = 2,
        [Description("Entregador")]
        Entrega = 3,
    }

    public static class EnumExtensions
    {
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

    public enum EnumSaborCategoria
    {
        [Description("Tradicional")]
        Tradicional = 'T',
        [Description("Especial")]
        Especial = 'E'
    }

    public enum EnumSaborTipo
    {
        [Description("Doce")]
        Doce = 'D',
        [Description("Salgada")]
        Salgada = 'S'
    }
}
