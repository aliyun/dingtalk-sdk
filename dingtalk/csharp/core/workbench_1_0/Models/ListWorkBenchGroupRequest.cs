// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkbench_1_0.Models
{
    public class ListWorkBenchGroupRequest : TeaModel {
        [NameInMap("ecologicalCorpId")]
        [Validation(Required=false)]
        public string EcologicalCorpId { get; set; }

        [NameInMap("groupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        [NameInMap("opUnionId")]
        [Validation(Required=false)]
        public string OpUnionId { get; set; }

    }

}
