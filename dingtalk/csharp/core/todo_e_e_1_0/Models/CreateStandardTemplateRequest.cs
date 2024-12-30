// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_e_e_1_0.Models
{
    public class CreateStandardTemplateRequest : TeaModel {
        [NameInMap("actions")]
        [Validation(Required=false)]
        public List<CreateStandardTemplateRequestActions> Actions { get; set; }
        public class CreateStandardTemplateRequestActions : TeaModel {
            [NameInMap("actionGroup")]
            [Validation(Required=false)]
            public string ActionGroup { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("needReason")]
            [Validation(Required=false)]
            public bool? NeedReason { get; set; }

            [NameInMap("needReasonRequired")]
            [Validation(Required=false)]
            public bool? NeedReasonRequired { get; set; }

            [NameInMap("order")]
            [Validation(Required=false)]
            public long? Order { get; set; }

            [NameInMap("styleType")]
            [Validation(Required=false)]
            public long? StyleType { get; set; }

        }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        [NameInMap("service")]
        [Validation(Required=false)]
        public CreateStandardTemplateRequestService Service { get; set; }
        public class CreateStandardTemplateRequestService : TeaModel {
            [NameInMap("callbackUrl")]
            [Validation(Required=false)]
            public string CallbackUrl { get; set; }

        }

    }

}
