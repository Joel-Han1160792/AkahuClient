using System.Text.Json;
using System.Text.Json.Serialization;
using AkahuClient.Models.Accounts.Enums;
using AkahuClient.Models.Commons.Enums;

namespace AkahuClient.Configurations;

public class AkahuJsonSerializerConfiguration()
{
    private static JsonSerializerOptions? _options;
    
    public static JsonSerializerOptions Options
    {
        get
        {
            if(_options != null) return _options;
            
            _options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };
            
            var enumTypes = new[]
            {
                typeof(AccountType),
                typeof(AccountStatus),
                typeof(AccountAttribute),
                typeof(Currency)
            };

            foreach (var enumType in enumTypes)
            {
                var converterType = typeof(CaseInsensitiveEnumConverter<>).MakeGenericType(enumType);
                var converterInstance = (JsonConverter)Activator.CreateInstance(converterType)!;
                _options.Converters.Add(converterInstance);
            }
            
            return _options;
        }
    }
}