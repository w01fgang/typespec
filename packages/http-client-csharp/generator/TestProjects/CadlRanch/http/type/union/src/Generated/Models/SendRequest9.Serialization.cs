// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace _Type.Union.Models
{
    public partial class SendRequest9 : IJsonModel<SendRequest9>
    {
        void IJsonModel<SendRequest9>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        SendRequest9 IJsonModel<SendRequest9>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual SendRequest9 JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<SendRequest9>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        SendRequest9 IPersistableModel<SendRequest9>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual SendRequest9 PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<SendRequest9>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        public static implicit operator BinaryContent(SendRequest9 sendRequest9) => throw null;

        public static explicit operator SendRequest9(ClientResult result) => throw null;
    }
}
