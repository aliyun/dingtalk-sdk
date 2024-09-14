// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class PublishTemplateResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public PublishTemplateResponseBodyData Data { get; set; }
        public class PublishTemplateResponseBodyData : TeaModel {
            [NameInMap("commonVariableList")]
            [Validation(Required=false)]
            public object CommonVariableList { get; set; }

            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("expVariableList")]
            [Validation(Required=false)]
            public object ExpVariableList { get; set; }

            [NameInMap("extendType")]
            [Validation(Required=false)]
            public string ExtendType { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("localVariableList")]
            [Validation(Required=false)]
            public object LocalVariableList { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("preview")]
            [Validation(Required=false)]
            public string Preview { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
