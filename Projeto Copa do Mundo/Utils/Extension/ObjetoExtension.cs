using System;
using System.Linq;
using System.Reflection;

namespace Projeto_Copa_do_Mundo.Utils.Extension
{
    public static class ObjetoExtension
    {
        public static void CopiarPropriedades<TDestino>(this object origem, ref TDestino objDestino)
        {
            try
            {
                Type tipoOrigem = origem.GetType();
                Type tipoDestino = typeof(TDestino);

                PropertyInfo[] arrCamposOrigem = tipoOrigem.GetProperties();
                PropertyInfo[] arrCamposDestino = tipoDestino.GetProperties();

                foreach (PropertyInfo campoDestino in arrCamposDestino)
                {
                    PropertyInfo campoOrigem = arrCamposOrigem.Where(cpOrigem => cpOrigem.Name == campoDestino.Name).FirstOrDefault();

                    if (campoOrigem != null)
                    {
                        if (campoOrigem.PropertyType == campoDestino.PropertyType)
                        {
                            var vlrOrigem = tipoOrigem.GetProperty(campoOrigem.Name).GetValue(origem, null);
                            tipoDestino.GetProperty(campoDestino.Name).SetValue(objDestino, vlrOrigem, null);
                        }
                    }
                }
            }
            catch (System.Exception exc)
            {
                throw exc;
            }
        }
    }
}