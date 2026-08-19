// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class CreateTemplateProcessTaskRequest : TeaModel {
        [NameInMap("fillData")]
        [Validation(Required=false)]
        public List<CreateTemplateProcessTaskRequestFillData> FillData { get; set; }
        public class CreateTemplateProcessTaskRequestFillData : TeaModel {
            [NameInMap("structKey")]
            [Validation(Required=false)]
            public string StructKey { get; set; }

            [NameInMap("structValue")]
            [Validation(Required=false)]
            public string StructValue { get; set; }

        }

        [NameInMap("formId")]
        [Validation(Required=false)]
        public string FormId { get; set; }

        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

    }

}
