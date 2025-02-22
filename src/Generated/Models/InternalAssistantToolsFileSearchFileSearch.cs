// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalAssistantToolsFileSearchFileSearch
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InternalAssistantToolsFileSearchFileSearch()
        {
        }

        internal InternalAssistantToolsFileSearchFileSearch(FileSearchRankingOptions rankingOptions, int? internalMaxNumResults, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            RankingOptions = rankingOptions;
            InternalMaxNumResults = internalMaxNumResults;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public FileSearchRankingOptions RankingOptions { get; set; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
