using System.Drawing;
using StdBE100;
using StdBrandingInfo100;
using StdClasses100;

namespace Primavera.ExtForms100
{
    public class clsExtImages : clsAplImages
    {
        /// <summary>
        /// Application image.
        /// </summary>
        /// <param name="TipoPlataforma"></param>
        /// <param name="TipoAmbiente"></param>
        /// <returns></returns>
        public Image GetIcon(StdBETipos.EnumTipoPlataforma TipoPlataforma, StdBETipos.EnumTipoAmbiente TipoAmbiente)
        {
            StdBrandingInfo100.clsBranding clsBranding = new clsBranding();

            return clsBranding.Imagens.DaIconeLinha(TipoPlataforma, TipoAmbiente).ToBitmap();
        }
    }
}
