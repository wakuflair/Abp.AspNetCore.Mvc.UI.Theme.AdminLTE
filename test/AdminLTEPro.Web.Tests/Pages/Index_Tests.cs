using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AdminLTEPro.Pages
{
    public class Index_Tests : AdminLTEProWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
