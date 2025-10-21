// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class SubmitAsrTaskRequest : TeaModel {
        [NameInMap("bizKey")]
        [Validation(Required=false)]
        public string BizKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dentryId")]
        [Validation(Required=false)]
        public string DentryId { get; set; }

        [NameInMap("phrases")]
        [Validation(Required=false)]
        public List<string> Phrases { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("spaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        [NameInMap("transcription")]
        [Validation(Required=false)]
        public SubmitAsrTaskRequestTranscription Transcription { get; set; }
        public class SubmitAsrTaskRequestTranscription : TeaModel {
            [NameInMap("diarization")]
            [Validation(Required=false)]
            public SubmitAsrTaskRequestTranscriptionDiarization Diarization { get; set; }
            public class SubmitAsrTaskRequestTranscriptionDiarization : TeaModel {
                [NameInMap("speakerCount")]
                [Validation(Required=false)]
                public long? SpeakerCount { get; set; }

            }

            [NameInMap("diarizationEnabled")]
            [Validation(Required=false)]
            public bool? DiarizationEnabled { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
