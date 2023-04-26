// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateCustomfieldValueResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateCustomfieldValueResponseBodyResult Result { get; set; }
        public class UpdateCustomfieldValueResponseBodyResult : TeaModel {
            [NameInMap("customfields")]
            [Validation(Required=false)]
            public List<UpdateCustomfieldValueResponseBodyResultCustomfields> Customfields { get; set; }
            public class UpdateCustomfieldValueResponseBodyResultCustomfields : TeaModel {
                [NameInMap("customfieldId")]
                [Validation(Required=false)]
                public string CustomfieldId { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public List<UpdateCustomfieldValueResponseBodyResultCustomfieldsValue> Value { get; set; }
                public class UpdateCustomfieldValueResponseBodyResultCustomfieldsValue : TeaModel {
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

        }

    }

}
