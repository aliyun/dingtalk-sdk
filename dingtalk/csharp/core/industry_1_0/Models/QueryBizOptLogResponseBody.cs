// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryBizOptLogResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryBizOptLogResponseBodyContent> Content { get; set; }
        public class QueryBizOptLogResponseBodyContent : TeaModel {
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public int? BizType { get; set; }

            [NameInMap("dataType")]
            [Validation(Required=false)]
            public int? DataType { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("optAfterData")]
            [Validation(Required=false)]
            public string OptAfterData { get; set; }

            [NameInMap("optBeforeData")]
            [Validation(Required=false)]
            public string OptBeforeData { get; set; }

            [NameInMap("optBizType")]
            [Validation(Required=false)]
            public int? OptBizType { get; set; }

            [NameInMap("optExtend")]
            [Validation(Required=false)]
            public string OptExtend { get; set; }

            [NameInMap("optJobNumber")]
            [Validation(Required=false)]
            public string OptJobNumber { get; set; }

            [NameInMap("optObjectCode")]
            [Validation(Required=false)]
            public string OptObjectCode { get; set; }

            [NameInMap("optObjectName")]
            [Validation(Required=false)]
            public string OptObjectName { get; set; }

            [NameInMap("optObjectUserJobNo")]
            [Validation(Required=false)]
            public string OptObjectUserJobNo { get; set; }

            [NameInMap("optSuccess")]
            [Validation(Required=false)]
            public int? OptSuccess { get; set; }

            [NameInMap("optTime")]
            [Validation(Required=false)]
            public long? OptTime { get; set; }

            [NameInMap("optType")]
            [Validation(Required=false)]
            public int? OptType { get; set; }

            [NameInMap("optUserCode")]
            [Validation(Required=false)]
            public string OptUserCode { get; set; }

            [NameInMap("optUserName")]
            [Validation(Required=false)]
            public string OptUserName { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
