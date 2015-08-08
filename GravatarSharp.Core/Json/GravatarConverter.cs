using System;
using Newtonsoft.Json;

namespace GravatarSharp.Core.Json
{
    internal class SingleValueArrayConverter<T> : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var retVal = new Object();
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    {
                        retVal = (T)serializer.Deserialize(reader, typeof(T));
                        break;
                    }
                case JsonToken.StartArray:
                    {
                        var arr1 = serializer.Deserialize<T[]>(reader);
                        if (arr1 != null && arr1.Length > 0)
                            retVal = arr1[0];
                        else retVal = null;
                        break;
                    }
            }
            return retVal;
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}
