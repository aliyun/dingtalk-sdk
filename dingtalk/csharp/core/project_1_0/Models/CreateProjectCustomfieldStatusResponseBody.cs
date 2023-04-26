// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateProjectCustomfieldStatusResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateProjectCustomfieldStatusResponseBodyResult Result { get; set; }
        public class CreateProjectCustomfieldStatusResponseBodyResult : TeaModel {
            [NameInMap("advCfObjectType")]
            [Validation(Required=false)]
            public string AdvCfObjectType { get; set; }

            [NameInMap("customfieldId")]
            [Validation(Required=false)]
            public string CustomfieldId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("originalId")]
            [Validation(Required=false)]
            public string OriginalId { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public List<CreateProjectCustomfieldStatusResponseBodyResultValue> Value { get; set; }
            public class CreateProjectCustomfieldStatusResponseBodyResultValue : TeaModel {
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

}
