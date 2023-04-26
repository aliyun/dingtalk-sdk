// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class GetInstancesByIdsRequest : TeaModel {
        [NameInMap("formCode")]
        [Validation(Required=false)]
        public string FormCode { get; set; }

        [NameInMap("openDataInstanceIdList")]
        [Validation(Required=false)]
        public List<string> OpenDataInstanceIdList { get; set; }

        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

    }

}
