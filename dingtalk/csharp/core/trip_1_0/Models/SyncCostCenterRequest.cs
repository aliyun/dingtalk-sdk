// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class SyncCostCenterRequest : TeaModel {
        [NameInMap("channelCorpId")]
        [Validation(Required=false)]
        public string ChannelCorpId { get; set; }

        [NameInMap("costCenterId")]
        [Validation(Required=false)]
        public string CostCenterId { get; set; }

        [NameInMap("deleteFlag")]
        [Validation(Required=false)]
        public bool? DeleteFlag { get; set; }

        [NameInMap("extension")]
        [Validation(Required=false)]
        public string Extension { get; set; }

        [NameInMap("gmtAction")]
        [Validation(Required=false)]
        public string GmtAction { get; set; }

        [NameInMap("number")]
        [Validation(Required=false)]
        public string Number { get; set; }

        [NameInMap("scope")]
        [Validation(Required=false)]
        public int? Scope { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("thirdPartId")]
        [Validation(Required=false)]
        public string ThirdPartId { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
