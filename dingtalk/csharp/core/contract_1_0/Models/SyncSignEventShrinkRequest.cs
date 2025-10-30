// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class SyncSignEventShrinkRequest : TeaModel {
        [NameInMap("contractBizId")]
        [Validation(Required=false)]
        public string ContractBizId { get; set; }

        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public string ExtInfoShrink { get; set; }

        [NameInMap("sealType")]
        [Validation(Required=false)]
        public string SealTypeShrink { get; set; }

        [NameInMap("signDate")]
        [Validation(Required=false)]
        public long? SignDate { get; set; }

        [NameInMap("signFileList")]
        [Validation(Required=false)]
        public string SignFileListShrink { get; set; }

        [NameInMap("staffId")]
        [Validation(Required=false)]
        public string StaffId { get; set; }

    }

}
