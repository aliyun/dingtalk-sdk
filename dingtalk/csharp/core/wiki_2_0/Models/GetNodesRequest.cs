// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwiki_2_0.Models
{
    public class GetNodesRequest : TeaModel {
        [NameInMap("nodeIds")]
        [Validation(Required=false)]
        public List<string> NodeIds { get; set; }

        [NameInMap("option")]
        [Validation(Required=false)]
        public GetNodesRequestOption Option { get; set; }
        public class GetNodesRequestOption : TeaModel {
            [NameInMap("withPermissionRole")]
            [Validation(Required=false)]
            public bool? WithPermissionRole { get; set; }

            [NameInMap("withStatisticalInfo")]
            [Validation(Required=false)]
            public bool? WithStatisticalInfo { get; set; }

        }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
