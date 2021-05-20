// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class SyncDataResponseBody : TeaModel {
        /// <summary>
        /// resultList
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<SyncDataResponseBodyList> List { get; set; }
        public class SyncDataResponseBodyList : TeaModel {
            [NameInMap("triggerId")]
            [Validation(Required=false)]
            public string TriggerId { get; set; }

            [NameInMap("bizPrimaryKey")]
            [Validation(Required=false)]
            public string BizPrimaryKey { get; set; }

            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            [NameInMap("subErrCode")]
            [Validation(Required=false)]
            public string SubErrCode { get; set; }

            [NameInMap("subErrMsg")]
            [Validation(Required=false)]
            public string SubErrMsg { get; set; }

        }

    }

}
