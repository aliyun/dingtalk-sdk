// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class GetSignRecordByIdResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetSignRecordByIdResponseBodyResult> Result { get; set; }
        public class GetSignRecordByIdResponseBodyResult : TeaModel {
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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
