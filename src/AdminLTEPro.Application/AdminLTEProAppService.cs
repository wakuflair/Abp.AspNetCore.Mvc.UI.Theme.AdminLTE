using System;
using System.Collections.Generic;
using System.Text;
using AdminLTEPro.Localization;
using Volo.Abp.Application.Services;

namespace AdminLTEPro
{
    /* Inherit your application services from this class.
     */
    public abstract class AdminLTEProAppService : ApplicationService
    {
        protected AdminLTEProAppService()
        {
            LocalizationResource = typeof(AdminLTEProResource);
        }
    }
}
