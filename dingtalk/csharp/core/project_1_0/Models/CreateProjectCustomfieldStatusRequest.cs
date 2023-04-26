// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateProjectCustomfieldStatusRequest : TeaModel {
        [NameInMap("customfieldId")]
        [Validation(Required=false)]
        public string CustomfieldId { get; set; }

        [NameInMap("customfieldInstanceId")]
        [Validation(Required=false)]
        public string CustomfieldInstanceId { get; set; }

        [NameInMap("customfieldName")]
        [Validation(Required=false)]
        public string CustomfieldName { get; set; }

        [NameInMap("value")]
        [Validation(Required=false)]
        public List<CreateProjectCustomfieldStatusRequestValue> Value { get; set; }
        public class CreateProjectCustomfieldStatusRequestValue : TeaModel {
            [NameInMap("fieldvalueId")]
            [Validation(Required=false)]
            public string FieldvalueId { get; set; }

            [NameInMap("metaString")]
            [Validation(Required=false)]
            public string MetaString { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
