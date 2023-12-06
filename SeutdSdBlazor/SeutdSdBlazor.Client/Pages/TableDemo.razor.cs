using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using SeutdSdBlazor.Client.Data;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;

namespace SeutdSdBlazor.Client.Pages
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TableDemo : ComponentBase
    {
        [Inject]
        [NotNull]
        private IStringLocalizer<Foo>? Localizer { get; set; }

        private readonly ConcurrentDictionary<Foo, IEnumerable<SelectedItem>> _cache = new();

        private IEnumerable<SelectedItem> GetHobbies(Foo item) => _cache.GetOrAdd(item, f => Foo.GenerateHobbies(Localizer));

        /// <summary>
        /// 
        /// </summary>
        private static IEnumerable<int> PageItemsSource => new int[] { 20, 40 };
    }
}
