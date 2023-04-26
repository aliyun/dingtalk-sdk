// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class GetFlowIdByRelationEntityIdRequest : TeaModel {
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        [NameInMap("relationEntity")]
        [Validation(Required=false)]
        public string RelationEntity { get; set; }

        [NameInMap("relationEntityId")]
        [Validation(Required=false)]
        public string RelationEntityId { get; set; }

    }

}
