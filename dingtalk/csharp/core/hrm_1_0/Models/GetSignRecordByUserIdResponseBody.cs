// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class GetSignRecordByUserIdResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetSignRecordByUserIdResponseBodyResult Result { get; set; }
        public class GetSignRecordByUserIdResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<GetSignRecordByUserIdResponseBodyResultData> Data { get; set; }
            public class GetSignRecordByUserIdResponseBodyResultData : TeaModel {
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("signExpireTime")]
                [Validation(Required=false)]
                public long? SignExpireTime { get; set; }

                [NameInMap("signFileName")]
                [Validation(Required=false)]
                public string SignFileName { get; set; }

                [NameInMap("signFileUrl")]
                [Validation(Required=false)]
                public string SignFileUrl { get; set; }

                [NameInMap("signFinishTime")]
                [Validation(Required=false)]
                public long? SignFinishTime { get; set; }

                [NameInMap("signLegalEntityName")]
                [Validation(Required=false)]
                public string SignLegalEntityName { get; set; }

                [NameInMap("signRecordId")]
                [Validation(Required=false)]
                public string SignRecordId { get; set; }

                [NameInMap("signStartTime")]
                [Validation(Required=false)]
                public long? SignStartTime { get; set; }

                [NameInMap("signStatus")]
                [Validation(Required=false)]
                public string SignStatus { get; set; }

                [NameInMap("signStatusRemarks")]
                [Validation(Required=false)]
                public string SignStatusRemarks { get; set; }

                [NameInMap("signTemplateType")]
                [Validation(Required=false)]
                public string SignTemplateType { get; set; }

                [NameInMap("signUserId")]
                [Validation(Required=false)]
                public string SignUserId { get; set; }

                [NameInMap("signUserName")]
                [Validation(Required=false)]
                public string SignUserName { get; set; }

                [NameInMap("signWay")]
                [Validation(Required=false)]
                public string SignWay { get; set; }

            }

            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public long? NextToken { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
