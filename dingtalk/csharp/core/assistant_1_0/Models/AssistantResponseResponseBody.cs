// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkassistant_1_0.Models
{
    public class AssistantResponseResponseBody : TeaModel {
        [NameInMap("created_at")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("error")]
        [Validation(Required=false)]
        public string Error { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        [NameInMap("object")]
        [Validation(Required=false)]
        public string Object { get; set; }

        [NameInMap("output")]
        [Validation(Required=false)]
        public List<AssistantResponseResponseBodyOutput> Output { get; set; }
        public class AssistantResponseResponseBodyOutput : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public List<AssistantResponseResponseBodyOutputContent> Content { get; set; }
            public class AssistantResponseResponseBodyOutputContent : TeaModel {
                [NameInMap("annotations")]
                [Validation(Required=false)]
                public List<object> Annotations { get; set; }

                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
