// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class IsvDataWriteRequest : TeaModel {
        [NameInMap("objectCode")]
        [Validation(Required=false)]
        public string ObjectCode { get; set; }

        [NameInMap("rowValueList")]
        [Validation(Required=false)]
        public List<List<IsvDataWriteRequestRowValueList>> RowValueList { get; set; }
        public class IsvDataWriteRequestRowValueList : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
